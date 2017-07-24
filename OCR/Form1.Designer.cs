namespace OCR
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            NPlot.Windows.PlotSurface2D.PlotContextMenu plotContextMenu2 = new NPlot.Windows.PlotSurface2D.PlotContextMenu();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_Weight = new System.Windows.Forms.TextBox();
            this.grp_Setting = new System.Windows.Forms.GroupBox();
            this.txt_Error = new System.Windows.Forms.TextBox();
            this.txt_Etta = new System.Windows.Forms.TextBox();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.txt_Epoch = new System.Windows.Forms.TextBox();
            this.txt_Alpha = new System.Windows.Forms.TextBox();
            this.lbl_Etta = new System.Windows.Forms.Label();
            this.lbl_Epoch = new System.Windows.Forms.Label();
            this.lbl_Alpha = new System.Windows.Forms.Label();
            this.lbl_Neurons = new System.Windows.Forms.Label();
            this.txt_Neurons = new System.Windows.Forms.TextBox();
            this.grp_Weight = new System.Windows.Forms.GroupBox();
            this.grp_Input = new System.Windows.Forms.GroupBox();
            this.lbl_FilePath = new System.Windows.Forms.Label();
            this.txt_FilePath = new System.Windows.Forms.TextBox();
            this.btn_Open = new System.Windows.Forms.Button();
            this.txt_InputChar = new System.Windows.Forms.TextBox();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.lbl_InputChar = new System.Windows.Forms.Label();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.plotSurface = new NPlot.Windows.PlotSurface2D();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssl_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmb_InputChar = new System.Windows.Forms.ComboBox();
            this.btn_Train = new System.Windows.Forms.Button();
            this.btn_DeleteCurve = new System.Windows.Forms.Button();
            this.btn_AddNoise = new System.Windows.Forms.Button();
            this.grp_NoiseSetting = new System.Windows.Forms.GroupBox();
            this.lbl_Percentage = new System.Windows.Forms.Label();
            this.txt_NoisePercentage = new System.Windows.Forms.TextBox();
            this.btn_Infer = new System.Windows.Forms.Button();
            this.txt_NetworkOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Sorted = new System.Windows.Forms.TextBox();
            this.grp_Setting.SuspendLayout();
            this.grp_Weight.SuspendLayout();
            this.grp_Input.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.grp_NoiseSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 479);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // txt_Weight
            // 
            this.txt_Weight.Location = new System.Drawing.Point(8, 21);
            this.txt_Weight.Multiline = true;
            this.txt_Weight.Name = "txt_Weight";
            this.txt_Weight.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Weight.Size = new System.Drawing.Size(431, 193);
            this.txt_Weight.TabIndex = 4;
            // 
            // grp_Setting
            // 
            this.grp_Setting.Controls.Add(this.txt_Error);
            this.grp_Setting.Controls.Add(this.txt_Etta);
            this.grp_Setting.Controls.Add(this.lbl_Error);
            this.grp_Setting.Controls.Add(this.txt_Epoch);
            this.grp_Setting.Controls.Add(this.txt_Alpha);
            this.grp_Setting.Controls.Add(this.lbl_Etta);
            this.grp_Setting.Controls.Add(this.lbl_Epoch);
            this.grp_Setting.Controls.Add(this.lbl_Alpha);
            this.grp_Setting.Controls.Add(this.lbl_Neurons);
            this.grp_Setting.Controls.Add(this.txt_Neurons);
            this.grp_Setting.Location = new System.Drawing.Point(12, 12);
            this.grp_Setting.Name = "grp_Setting";
            this.grp_Setting.Size = new System.Drawing.Size(393, 102);
            this.grp_Setting.TabIndex = 5;
            this.grp_Setting.TabStop = false;
            this.grp_Setting.Text = "Setting";
            // 
            // txt_Error
            // 
            this.txt_Error.Location = new System.Drawing.Point(212, 71);
            this.txt_Error.Name = "txt_Error";
            this.txt_Error.Size = new System.Drawing.Size(60, 22);
            this.txt_Error.TabIndex = 3;
            this.txt_Error.Text = "0.5";
            // 
            // txt_Etta
            // 
            this.txt_Etta.Location = new System.Drawing.Point(323, 71);
            this.txt_Etta.Name = "txt_Etta";
            this.txt_Etta.Size = new System.Drawing.Size(60, 22);
            this.txt_Etta.TabIndex = 3;
            this.txt_Etta.Text = "0.5";
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Location = new System.Drawing.Point(133, 74);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(75, 12);
            this.lbl_Error.TabIndex = 2;
            this.lbl_Error.Text = "Error tolerance";
            // 
            // txt_Epoch
            // 
            this.txt_Epoch.Location = new System.Drawing.Point(212, 33);
            this.txt_Epoch.Name = "txt_Epoch";
            this.txt_Epoch.Size = new System.Drawing.Size(60, 22);
            this.txt_Epoch.TabIndex = 3;
            this.txt_Epoch.Text = "500";
            // 
            // txt_Alpha
            // 
            this.txt_Alpha.Location = new System.Drawing.Point(323, 33);
            this.txt_Alpha.Name = "txt_Alpha";
            this.txt_Alpha.Size = new System.Drawing.Size(60, 22);
            this.txt_Alpha.TabIndex = 3;
            this.txt_Alpha.Text = "1";
            // 
            // lbl_Etta
            // 
            this.lbl_Etta.AutoSize = true;
            this.lbl_Etta.Location = new System.Drawing.Point(294, 74);
            this.lbl_Etta.Name = "lbl_Etta";
            this.lbl_Etta.Size = new System.Drawing.Size(23, 12);
            this.lbl_Etta.TabIndex = 2;
            this.lbl_Etta.Text = "Etta";
            // 
            // lbl_Epoch
            // 
            this.lbl_Epoch.AutoSize = true;
            this.lbl_Epoch.Location = new System.Drawing.Point(173, 36);
            this.lbl_Epoch.Name = "lbl_Epoch";
            this.lbl_Epoch.Size = new System.Drawing.Size(35, 12);
            this.lbl_Epoch.TabIndex = 2;
            this.lbl_Epoch.Text = "Epoch";
            // 
            // lbl_Alpha
            // 
            this.lbl_Alpha.AutoSize = true;
            this.lbl_Alpha.Location = new System.Drawing.Point(284, 36);
            this.lbl_Alpha.Name = "lbl_Alpha";
            this.lbl_Alpha.Size = new System.Drawing.Size(33, 12);
            this.lbl_Alpha.TabIndex = 2;
            this.lbl_Alpha.Text = "Alpha";
            // 
            // lbl_Neurons
            // 
            this.lbl_Neurons.AutoSize = true;
            this.lbl_Neurons.Location = new System.Drawing.Point(6, 18);
            this.lbl_Neurons.Name = "lbl_Neurons";
            this.lbl_Neurons.Size = new System.Drawing.Size(44, 12);
            this.lbl_Neurons.TabIndex = 1;
            this.lbl_Neurons.Text = "Neurons";
            // 
            // txt_Neurons
            // 
            this.txt_Neurons.Location = new System.Drawing.Point(8, 33);
            this.txt_Neurons.Multiline = true;
            this.txt_Neurons.Name = "txt_Neurons";
            this.txt_Neurons.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Neurons.Size = new System.Drawing.Size(115, 60);
            this.txt_Neurons.TabIndex = 0;
            this.txt_Neurons.Text = "64,64,26";
            // 
            // grp_Weight
            // 
            this.grp_Weight.Controls.Add(this.txt_Weight);
            this.grp_Weight.Location = new System.Drawing.Point(411, 12);
            this.grp_Weight.Name = "grp_Weight";
            this.grp_Weight.Size = new System.Drawing.Size(445, 220);
            this.grp_Weight.TabIndex = 6;
            this.grp_Weight.TabStop = false;
            this.grp_Weight.Text = "Weight";
            // 
            // grp_Input
            // 
            this.grp_Input.Controls.Add(this.lbl_FilePath);
            this.grp_Input.Controls.Add(this.txt_FilePath);
            this.grp_Input.Controls.Add(this.btn_Open);
            this.grp_Input.Location = new System.Drawing.Point(12, 126);
            this.grp_Input.Name = "grp_Input";
            this.grp_Input.Size = new System.Drawing.Size(393, 60);
            this.grp_Input.TabIndex = 7;
            this.grp_Input.TabStop = false;
            this.grp_Input.Text = "Input";
            // 
            // lbl_FilePath
            // 
            this.lbl_FilePath.AutoSize = true;
            this.lbl_FilePath.Location = new System.Drawing.Point(7, 24);
            this.lbl_FilePath.Name = "lbl_FilePath";
            this.lbl_FilePath.Size = new System.Drawing.Size(45, 12);
            this.lbl_FilePath.TabIndex = 5;
            this.lbl_FilePath.Text = "File path";
            // 
            // txt_FilePath
            // 
            this.txt_FilePath.Location = new System.Drawing.Point(58, 21);
            this.txt_FilePath.Name = "txt_FilePath";
            this.txt_FilePath.Size = new System.Drawing.Size(303, 22);
            this.txt_FilePath.TabIndex = 4;
            // 
            // btn_Open
            // 
            this.btn_Open.Location = new System.Drawing.Point(361, 21);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(22, 22);
            this.btn_Open.TabIndex = 2;
            this.btn_Open.Text = "...";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // txt_InputChar
            // 
            this.txt_InputChar.Location = new System.Drawing.Point(21, 214);
            this.txt_InputChar.Multiline = true;
            this.txt_InputChar.Name = "txt_InputChar";
            this.txt_InputChar.ReadOnly = true;
            this.txt_InputChar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_InputChar.Size = new System.Drawing.Size(120, 140);
            this.txt_InputChar.TabIndex = 4;
            // 
            // txt_Result
            // 
            this.txt_Result.Location = new System.Drawing.Point(157, 214);
            this.txt_Result.Multiline = true;
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.ReadOnly = true;
            this.txt_Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Result.Size = new System.Drawing.Size(120, 140);
            this.txt_Result.TabIndex = 4;
            // 
            // lbl_InputChar
            // 
            this.lbl_InputChar.AutoSize = true;
            this.lbl_InputChar.Location = new System.Drawing.Point(19, 199);
            this.lbl_InputChar.Name = "lbl_InputChar";
            this.lbl_InputChar.Size = new System.Drawing.Size(53, 12);
            this.lbl_InputChar.TabIndex = 5;
            this.lbl_InputChar.Text = "Input char";
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Location = new System.Drawing.Point(156, 199);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(34, 12);
            this.lbl_Result.TabIndex = 5;
            this.lbl_Result.Text = "Result";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(122, 479);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 8;
            // 
            // plotSurface
            // 
            this.plotSurface.AutoScaleAutoGeneratedAxes = false;
            this.plotSurface.AutoScaleTitle = false;
            this.plotSurface.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.plotSurface.DateTimeToolTip = false;
            this.plotSurface.Legend = null;
            this.plotSurface.LegendZOrder = -1;
            this.plotSurface.Location = new System.Drawing.Point(419, 238);
            this.plotSurface.Name = "plotSurface";
            this.plotSurface.RightMenu = plotContextMenu2;
            this.plotSurface.ShowCoordinates = true;
            this.plotSurface.Size = new System.Drawing.Size(550, 400);
            this.plotSurface.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            this.plotSurface.TabIndex = 9;
            this.plotSurface.Text = "plotSurface";
            this.plotSurface.Title = "";
            this.plotSurface.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.plotSurface.XAxis1 = null;
            this.plotSurface.XAxis2 = null;
            this.plotSurface.YAxis1 = null;
            this.plotSurface.YAxis2 = null;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_Status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 660);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(984, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssl_Status
            // 
            this.tssl_Status.Name = "tssl_Status";
            this.tssl_Status.Size = new System.Drawing.Size(0, 17);
            // 
            // cmb_InputChar
            // 
            this.cmb_InputChar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_InputChar.FormattingEnabled = true;
            this.cmb_InputChar.Location = new System.Drawing.Point(20, 360);
            this.cmb_InputChar.Name = "cmb_InputChar";
            this.cmb_InputChar.Size = new System.Drawing.Size(121, 20);
            this.cmb_InputChar.TabIndex = 13;
            this.cmb_InputChar.SelectedIndexChanged += new System.EventHandler(this.cmb_InputChar_SelectedIndexChanged);
            // 
            // btn_Train
            // 
            this.btn_Train.Location = new System.Drawing.Point(93, 539);
            this.btn_Train.Name = "btn_Train";
            this.btn_Train.Size = new System.Drawing.Size(75, 23);
            this.btn_Train.TabIndex = 14;
            this.btn_Train.Text = "Train";
            this.btn_Train.UseVisualStyleBackColor = true;
            this.btn_Train.Click += new System.EventHandler(this.btn_Train_Click);
            // 
            // btn_DeleteCurve
            // 
            this.btn_DeleteCurve.Location = new System.Drawing.Point(338, 615);
            this.btn_DeleteCurve.Name = "btn_DeleteCurve";
            this.btn_DeleteCurve.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteCurve.TabIndex = 15;
            this.btn_DeleteCurve.Text = "Delete Curve";
            this.btn_DeleteCurve.UseVisualStyleBackColor = true;
            this.btn_DeleteCurve.Click += new System.EventHandler(this.btn_DeleteCurve_Click);
            // 
            // btn_AddNoise
            // 
            this.btn_AddNoise.Location = new System.Drawing.Point(111, 47);
            this.btn_AddNoise.Name = "btn_AddNoise";
            this.btn_AddNoise.Size = new System.Drawing.Size(75, 23);
            this.btn_AddNoise.TabIndex = 16;
            this.btn_AddNoise.Text = "Add noise";
            this.btn_AddNoise.UseVisualStyleBackColor = true;
            this.btn_AddNoise.Click += new System.EventHandler(this.btn_AddNoise_Click);
            // 
            // grp_NoiseSetting
            // 
            this.grp_NoiseSetting.Controls.Add(this.lbl_Percentage);
            this.grp_NoiseSetting.Controls.Add(this.txt_NoisePercentage);
            this.grp_NoiseSetting.Controls.Add(this.btn_AddNoise);
            this.grp_NoiseSetting.Location = new System.Drawing.Point(12, 394);
            this.grp_NoiseSetting.Name = "grp_NoiseSetting";
            this.grp_NoiseSetting.Size = new System.Drawing.Size(193, 79);
            this.grp_NoiseSetting.TabIndex = 17;
            this.grp_NoiseSetting.TabStop = false;
            this.grp_NoiseSetting.Text = "Noise Setting";
            // 
            // lbl_Percentage
            // 
            this.lbl_Percentage.AutoSize = true;
            this.lbl_Percentage.Location = new System.Drawing.Point(6, 22);
            this.lbl_Percentage.Name = "lbl_Percentage";
            this.lbl_Percentage.Size = new System.Drawing.Size(55, 12);
            this.lbl_Percentage.TabIndex = 18;
            this.lbl_Percentage.Text = "Percentage";
            // 
            // txt_NoisePercentage
            // 
            this.txt_NoisePercentage.Location = new System.Drawing.Point(86, 19);
            this.txt_NoisePercentage.Name = "txt_NoisePercentage";
            this.txt_NoisePercentage.Size = new System.Drawing.Size(100, 22);
            this.txt_NoisePercentage.TabIndex = 17;
            this.txt_NoisePercentage.Text = "0";
            // 
            // btn_Infer
            // 
            this.btn_Infer.Location = new System.Drawing.Point(174, 539);
            this.btn_Infer.Name = "btn_Infer";
            this.btn_Infer.Size = new System.Drawing.Size(75, 23);
            this.btn_Infer.TabIndex = 18;
            this.btn_Infer.Text = "Infer";
            this.btn_Infer.UseVisualStyleBackColor = true;
            this.btn_Infer.Click += new System.EventHandler(this.btn_Infer_Click);
            // 
            // txt_NetworkOutput
            // 
            this.txt_NetworkOutput.Location = new System.Drawing.Point(285, 214);
            this.txt_NetworkOutput.Multiline = true;
            this.txt_NetworkOutput.Name = "txt_NetworkOutput";
            this.txt_NetworkOutput.ReadOnly = true;
            this.txt_NetworkOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_NetworkOutput.Size = new System.Drawing.Size(120, 140);
            this.txt_NetworkOutput.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Network output";
            // 
            // txt_Sorted
            // 
            this.txt_Sorted.Location = new System.Drawing.Point(285, 361);
            this.txt_Sorted.Multiline = true;
            this.txt_Sorted.Name = "txt_Sorted";
            this.txt_Sorted.ReadOnly = true;
            this.txt_Sorted.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Sorted.Size = new System.Drawing.Size(120, 140);
            this.txt_Sorted.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 682);
            this.Controls.Add(this.btn_Infer);
            this.Controls.Add(this.grp_NoiseSetting);
            this.Controls.Add(this.btn_DeleteCurve);
            this.Controls.Add(this.btn_Train);
            this.Controls.Add(this.cmb_InputChar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.plotSurface);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.lbl_InputChar);
            this.Controls.Add(this.grp_Input);
            this.Controls.Add(this.grp_Weight);
            this.Controls.Add(this.txt_Sorted);
            this.Controls.Add(this.txt_NetworkOutput);
            this.Controls.Add(this.txt_Result);
            this.Controls.Add(this.txt_InputChar);
            this.Controls.Add(this.grp_Setting);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grp_Setting.ResumeLayout(false);
            this.grp_Setting.PerformLayout();
            this.grp_Weight.ResumeLayout(false);
            this.grp_Weight.PerformLayout();
            this.grp_Input.ResumeLayout(false);
            this.grp_Input.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grp_NoiseSetting.ResumeLayout(false);
            this.grp_NoiseSetting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_Weight;
        private System.Windows.Forms.GroupBox grp_Setting;
        private System.Windows.Forms.Label lbl_Neurons;
        private System.Windows.Forms.TextBox txt_Neurons;
        private System.Windows.Forms.TextBox txt_Error;
        private System.Windows.Forms.TextBox txt_Etta;
        private System.Windows.Forms.Label lbl_Error;
        private System.Windows.Forms.TextBox txt_Alpha;
        private System.Windows.Forms.Label lbl_Etta;
        private System.Windows.Forms.Label lbl_Alpha;
        private System.Windows.Forms.TextBox txt_Epoch;
        private System.Windows.Forms.Label lbl_Epoch;
        private System.Windows.Forms.GroupBox grp_Weight;
        private System.Windows.Forms.GroupBox grp_Input;
        private System.Windows.Forms.Label lbl_FilePath;
        private System.Windows.Forms.TextBox txt_FilePath;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.TextBox txt_InputChar;
        private System.Windows.Forms.TextBox txt_Result;
        private System.Windows.Forms.Label lbl_InputChar;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.TextBox textBox2;
        private NPlot.Windows.PlotSurface2D plotSurface;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssl_Status;
        private System.Windows.Forms.ComboBox cmb_InputChar;
        private System.Windows.Forms.Button btn_Train;
        private System.Windows.Forms.Button btn_DeleteCurve;
        private System.Windows.Forms.Button btn_AddNoise;
        private System.Windows.Forms.GroupBox grp_NoiseSetting;
        private System.Windows.Forms.Label lbl_Percentage;
        private System.Windows.Forms.TextBox txt_NoisePercentage;
        private System.Windows.Forms.Button btn_Infer;
        private System.Windows.Forms.TextBox txt_NetworkOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Sorted;
    }
}

