using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCR
{
    class NeuralNetwork
    {
        #region Field
        //private Neuron[][] _neurons = null;
        private double[] _AbsMax;
        #endregion

        #region Attribute
        public double Etta { get; set; }
        public double Alpha { get; set; }
        public Neuron[][] Neurons { get; set; }
        #endregion

        #region Constructor
        public NeuralNetwork(params int[] neuronsInEachLayer)
        {
            this.CreateNetwork(neuronsInEachLayer);
            this.InitializeNetwork();
        }
        #endregion

        #region Private function
        private void CreateNetwork(int[] neuronsNum)
        {
            Neurons = new Neuron[neuronsNum.Length][];
            for (int i = 0; i < neuronsNum.Length; i++)
            {
                Neurons[i] = new Neuron[neuronsNum[i]];
                for (int j = 0; j < neuronsNum[i]; j++)
                {
                    if (i == 0)
                    {
                        // First layer: input layer, so that the length of weight vector is one.
                        Neurons[i][j] = new Neuron(1);
                    }
                    else
                    {
                        // Other layer: length of weight depends on the neurons of previous layer.
                        Neurons[i][j] = new Neuron(neuronsNum[i - 1]);
                    }
                }
            }
        }
        // Set the weight of neurons as random values. (range: -1 ~ +1)
        private void InitializeNetwork()
        {
            Random rand = new Random();
            for (int i = 0; i < Neurons.Length; i++)
            {
                for (int j = 0; j < Neurons[i].Length; j++)
                {
                    for (int k = 0; k < Neurons[i][j].Weight.Length; k++)
                    {
                        Neurons[i][j].Weight[k] = rand.Next(0, 100) / 50.0 - 1;
                    }
                }
            }
        }
        private void Normalize(ref double[][] inputAry)
        {
            FindAbsMax(ref inputAry);
            for (int i = 0; i < inputAry.Length; i++)
            {
                if (_AbsMax[i] != 1)
                {
                    for (int j = 0; j < inputAry[i].Length; j++)
                    {
                        inputAry[i][j] /= _AbsMax[i];
                    }
                }
            }
        }
        private void Denormalize(ref double[][] outputAry)
        {
            for (int i = 0; i < outputAry.Length; i++)
            {
                if (_AbsMax[i] != 1)
                {
                    for (int j = 0; j < outputAry[i].Length; j++)
                    {
                        outputAry[i][j] *= _AbsMax[i];
                    }
                }
            }
        }
        private void FindAbsMax(ref double[][] inputAry)
        {
            if (_AbsMax == null)
            {
                _AbsMax = new double[inputAry.Length];
            }
            for (int i = 0; i < inputAry.Length; i++)
            {
                _AbsMax[i] = inputAry[i][0];
                foreach (double d in inputAry[i])
                {
                    if (Math.Abs(d) > _AbsMax[i])
                    {
                        _AbsMax[i] = Math.Abs(d);
                    }
                }
            }
        }
        /// <summary>
        /// Compute output of every neurons
        /// </summary>
        /// <param name="inputAry"></param>
        private void ComputeOutput(ref double[] inputAry)
        {
            double tempOut = 0;

            // First loop
            // Note: j: Neuron
            for (int j = 0; j < Neurons[0].Length; j++)
            {
                tempOut = 0;    // Reset
                tempOut = inputAry[j] * Neurons[0][j].Weight[0];
                Neurons[0][j].Output = 1 / (1 + Math.Exp(-tempOut));
            }

            // Note: i: Layer; j: Neuron; k: Weight
            for (int i = 1; i < Neurons.Length; i++)
            {
                for (int j = 0; j < Neurons[i].Length; j++)
                {
                    tempOut = 0;    // Reset
                    for (int k = 0; k < Neurons[i][j].Weight.Length; k++)
                    {
                        // tempOut = the output of previous layer * the weight of this layer
                        // Note: k equals the amount of neurons in previous layer
                        //       Because the length of weight depends on the neurons of previous layer.
                        tempOut += Neurons[i-1][k].Output * Neurons[i][j].Weight[k];
                    }
                    Neurons[i][j].Output = 1 / (1 + Math.Exp(-tempOut));
                }
            }
        }
        /// <summary>
        /// Compute error of this neural network. Return an root-square error.
        /// </summary>
        /// <param name="targetAry"></param>
        /// <returns></returns>
        private double ComputeError(ref double[] targetAry)
        {
            double error = 0;
            int idx = this.Neurons.Length - 1;   // index of last layer
            for (int i = 0; i < targetAry.Length; i++)
            {
                error += (targetAry[i] - this.Neurons[idx][i].Output) * (targetAry[i] - this.Neurons[idx][i].Output);
            }
            return Math.Sqrt(error);
        }
        private void UpdateWeight(ref double[] input, ref double[] output)
        {
            // Back propagation: Compute delta of output layer
            int idx = Neurons.Length-1;   // Index of last layer
            double tempDelta = 0;
            double temp = 0;

            #region Compute delta
            for (int j = 0; j < output.Length; j++)
            {
                //Neurons[idx][j].Delta = (this.Output[j] - _actualOutput[j]) * _actualOutput[j] * (1 - _actualOutput[j]);
                Neurons[idx][j].Delta = output[j] - Neurons[idx][j].Output;
            }
            // Back propagation: Compute delta of the whole network
            // Note: i: Layer; j: Neuron
            for (int i = idx-1; i >= 0; i--)
            {
                for (int j = 0; j < Neurons[i].Length; j++)
                {
                    tempDelta = 0;  // Reset
                    // Note: h: amount of the neurons in next layer
                    for (int h = 0; h < Neurons[i + 1].Length; h++)
                    {
                        // Note: delta of this layer = delta of next layer * weight of next layer
                        tempDelta += this.Alpha * Neurons[i + 1][h].Delta * Neurons[i + 1][h].Weight[j];
                    }
                    Neurons[i][j].Delta = tempDelta;
                }
            }
            #endregion

            #region Update weight
            // Update weight: first layer
            for (int j = 0; j<Neurons[0].Length; j++)
            {
                temp = Neurons[0][j].Delta * Neurons[0][j].Output * (1 - Neurons[0][j].Output);
                // Note: k: weight
                for (int k = 0; k < Neurons[0][j].Weight.Length; k++)
                {
                    Neurons[0][j].Weight[k] = this.Alpha * Neurons[0][j].Weight[k] + this.Etta * temp * input[k];
                }
                
            }
            // Update weight: other layer
            // Note: i: Layer; j: Neuron; k: Weight
            for (int i = 1; i < Neurons.Length; i++)
            {
                for (int j = 0; j < Neurons[i].Length; j++)
                {
                    temp = Neurons[i][j].Delta * Neurons[i][j].Output * (1 - Neurons[i][j].Output);
                    for (int k = 0; k < Neurons[i][j].Weight.Length; k++)
                    {
                        Neurons[i][j].Weight[k] = this.Alpha * Neurons[i][j].Weight[k] + this.Etta * temp * Neurons[i - 1][k].Output;
                    }
                }
            }
            #endregion
        }
        /// <summary>
        /// Run one epoch. Return error of this epoch.
        /// </summary>
        /// <param name="inputAry"></param>
        /// <param name="targetAry"></param>
        /// <returns>Root-square error</returns>
        private double RunEpoch(ref double[][] inputAry, ref double[][] targetAry)
        {
            double error = 0;
            for (int i = 0; i < inputAry.Length; i++)
            {
                ComputeOutput(ref inputAry[i]);
                error += ComputeError(ref targetAry[i]);
                UpdateWeight(ref inputAry[i], ref targetAry[i]);
            }
            return error;
        }
        /// <summary>
        /// For 'Infer' function. Get output of neural network and save them into 'result'.
        /// </summary>
        /// <param name="result"></param>
        private void GetResult(ref double[] result)
        {
            int idx = this.Neurons.Length - 1;  // index of last layer
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = this.Neurons[idx][i].Output;
            }
        }
        #endregion

        #region Public function
        /// <summary>
        /// Train the network.
        /// </summary>
        /// <param name="epoch">Max iteration times for training.</param>
        /// <param name="error">Tolerance error to stop training.</param>
        public void Train(ref double[][] inputAry, ref double[][] targetAry, ref double[] errorAry, int epoch, double error, double etta, double alpha)
        {
            // Check
            if (inputAry == null || targetAry == null)
            {
                throw new Exception("Input and target data array is empty.");
            }

            // Progress bar
            Form form = new Form();
            form.ClientSize = new System.Drawing.Size(200, 20);
            form.Show();
            ProgressBar pbar = new ProgressBar();
            pbar.Size = new System.Drawing.Size(200, 20);
            pbar.Visible = true;
            pbar.Minimum = 1;
            pbar.Maximum = epoch;
            pbar.Value = 1;
            pbar.Step = 1;
            form.Controls.Add(pbar);

            int counter = 0;
            double sumError = error + 1;    // +1: to make 'sumError' differs from 'Error' in first loop
            Etta = etta;
            Alpha = alpha;

            // Make a copy of input and target, then do normalization
            double[][] nnInput = new double[inputAry.Length][];
            double[][] nnTarget = new double[targetAry.Length][];
            for (int i = 0; i < inputAry.Length; i++)
            {
                nnInput[i] = new double[inputAry[i].Length];
                for (int j = 0; j < inputAry[i].Length; j++)
                {
                    nnInput[i][j] = inputAry[i][j];
                }
            }
            for (int i = 0; i < targetAry.Length; i++)
            {
                nnTarget[i] = new double[targetAry[i].Length];
                for (int j = 0; j < targetAry[i].Length; j++)
                {
                    nnTarget[i][j] = targetAry[i][j];
                }
            }

            Normalize(ref nnInput);
            Normalize(ref nnTarget);

            // Start training
            while (counter < epoch && (sumError > error))
            {
                sumError = RunEpoch(ref nnInput, ref nnTarget);
                counter++;
                pbar.PerformStep();
                errorAry[counter - 1] = sumError;
            }
        }
        public void Infer(ref double[] data, ref double[] result)
        {
            if (data == null)
            {
                throw new InputParameterException("Data array is null.");
            }
            if (result == null)
            {
                throw new InputParameterException("The array to store output is null.");
            }

            ComputeOutput(ref data);
            GetResult(ref result);
        }
        /// <summary>
        /// Get 'data' as input and compute. Output will be saved in 'result'.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="result"></param>
        public void Infer(ref double[][] data, ref double[][] result)
        {
            // 0. Check
            if (data == null)
            {
                throw new InputParameterException("Data array is null");
            }
            if (data[0].Length != this.Neurons[0].Length)
            {
                throw new InputParameterException("Length of each vector in input array might not meet to the length of input neurons.");
            }
            // 1. Normalize input

            // 2. Compute
            for (int i = 0; i < data.Length; i++)
            {
                ComputeOutput(ref data[i]);
                GetResult(ref result[i]);
            }
        }
        /// <summary>
        /// Get 'data' as input, compute result and error. Output will be saved in 'result'.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="result"></param>
        /// <param name="target"></param>
        /// <param name="error"></param>
        public void Infer(ref double[][] data, ref double[][] result, ref double[][] target, ref double[] error)
        {
            // 0. Check
            if (data == null)
            {
                throw new InputParameterException("data array is null");
            }
            if (data[0].Length != this.Neurons[0].Length)
            {
                throw new InputParameterException("Length of each vector in input array might not meet to the length of input neurons.");
            }
            // 1. Normalize input

            // 2. Compute
            for (int i = 0; i < data.Length; i++)
            {
                ComputeOutput(ref data[i]);
                GetResult(ref result[i]);
                error[i] = ComputeError(ref target[i]);
            }
        }
        #endregion
    }

    public class InputParameterException : Exception
    {
        public InputParameterException(string message)
            :base(message)
        {
        }
    }
}
