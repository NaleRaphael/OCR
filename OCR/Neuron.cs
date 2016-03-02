using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCR
{
    class Neuron
    {
        #region Attribute
        /// <summary>
        /// Input weight. Its length depends on the length of input vector.
        /// </summary>
        public double[] Weight { get; set; }
        /// <summary>
        /// Output.
        /// </summary>
        public double Output { get; set; }
        /// <summary>
        /// For back-propagation algorithm.
        /// </summary>
        public double Delta { get; set; }
        #endregion

        #region Constructor
        public Neuron()
        {
        }
        /// <summary>
        /// Constructor of a neuron.
        /// </summary>
        /// <param name="inputLength"></param>
        public Neuron(int inputLength)
        {
            Weight = new double[inputLength];
            Output = new double();
            Delta = new double();
        }
        #endregion
    }
}
