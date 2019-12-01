namespace AlcolizerFileBasedUnitConverter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txt_InputPath = new System.Windows.Forms.TextBox();
            this.Txt_OutputPath = new System.Windows.Forms.TextBox();
            this.Txt_OutputFileName = new System.Windows.Forms.TextBox();
            this.Btn_BrowseOutput = new System.Windows.Forms.Button();
            this.Btn_BrowseInput = new System.Windows.Forms.Button();
            this.Btn_ConvertInputToOutput = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_InputPath
            // 
            this.Txt_InputPath.Location = new System.Drawing.Point(76, 14);
            this.Txt_InputPath.Name = "Txt_InputPath";
            this.Txt_InputPath.ReadOnly = true;
            this.Txt_InputPath.Size = new System.Drawing.Size(507, 20);
            this.Txt_InputPath.TabIndex = 0;
            // 
            // Txt_OutputPath
            // 
            this.Txt_OutputPath.Location = new System.Drawing.Point(76, 40);
            this.Txt_OutputPath.Name = "Txt_OutputPath";
            this.Txt_OutputPath.ReadOnly = true;
            this.Txt_OutputPath.Size = new System.Drawing.Size(346, 20);
            this.Txt_OutputPath.TabIndex = 1;
            // 
            // Txt_OutputFileName
            // 
            this.Txt_OutputFileName.Location = new System.Drawing.Point(428, 40);
            this.Txt_OutputFileName.Name = "Txt_OutputFileName";
            this.Txt_OutputFileName.Size = new System.Drawing.Size(155, 20);
            this.Txt_OutputFileName.TabIndex = 2;
            this.Txt_OutputFileName.TextChanged += new System.EventHandler(this.Txt_OutputFileName_TextChanged);
            // 
            // Btn_BrowseOutput
            // 
            this.Btn_BrowseOutput.Location = new System.Drawing.Point(589, 38);
            this.Btn_BrowseOutput.Name = "Btn_BrowseOutput";
            this.Btn_BrowseOutput.Size = new System.Drawing.Size(75, 23);
            this.Btn_BrowseOutput.TabIndex = 3;
            this.Btn_BrowseOutput.Text = "Browse";
            this.Btn_BrowseOutput.UseVisualStyleBackColor = true;
            this.Btn_BrowseOutput.Click += new System.EventHandler(this.Btn_BrowseOutput_Click);
            // 
            // Btn_BrowseInput
            // 
            this.Btn_BrowseInput.Location = new System.Drawing.Point(589, 12);
            this.Btn_BrowseInput.Name = "Btn_BrowseInput";
            this.Btn_BrowseInput.Size = new System.Drawing.Size(75, 23);
            this.Btn_BrowseInput.TabIndex = 4;
            this.Btn_BrowseInput.Text = "Browse";
            this.Btn_BrowseInput.UseVisualStyleBackColor = true;
            this.Btn_BrowseInput.Click += new System.EventHandler(this.Btn_BrowseInput_Click);
            // 
            // Btn_ConvertInputToOutput
            // 
            this.Btn_ConvertInputToOutput.Enabled = false;
            this.Btn_ConvertInputToOutput.Location = new System.Drawing.Point(76, 67);
            this.Btn_ConvertInputToOutput.Name = "Btn_ConvertInputToOutput";
            this.Btn_ConvertInputToOutput.Size = new System.Drawing.Size(588, 23);
            this.Btn_ConvertInputToOutput.TabIndex = 5;
            this.Btn_ConvertInputToOutput.Text = "Convert";
            this.Btn_ConvertInputToOutput.UseVisualStyleBackColor = true;
            this.Btn_ConvertInputToOutput.Click += new System.EventHandler(this.Btn_ConvertInputToOutput_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Input File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Output Path";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 99);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_ConvertInputToOutput);
            this.Controls.Add(this.Btn_BrowseInput);
            this.Controls.Add(this.Btn_BrowseOutput);
            this.Controls.Add(this.Txt_OutputFileName);
            this.Controls.Add(this.Txt_OutputPath);
            this.Controls.Add(this.Txt_InputPath);
            this.Name = "Form1";
            this.Text = "Alcolizer File-based Unit Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_InputPath;
        private System.Windows.Forms.TextBox Txt_OutputPath;
        private System.Windows.Forms.TextBox Txt_OutputFileName;
        private System.Windows.Forms.Button Btn_BrowseOutput;
        private System.Windows.Forms.Button Btn_BrowseInput;
        private System.Windows.Forms.Button Btn_ConvertInputToOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

