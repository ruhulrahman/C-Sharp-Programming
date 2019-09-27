namespace ElectricityBillCalculator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonCommercial = new System.Windows.Forms.RadioButton();
            this.radioButtonIndustrial = new System.Windows.Forms.RadioButton();
            this.radioButtonResident = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.offPeakHourBox = new System.Windows.Forms.TextBox();
            this.peakHourBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Controls.Add(this.radioButtonCommercial);
            this.groupBox1.Controls.Add(this.radioButtonIndustrial);
            this.groupBox1.Controls.Add(this.radioButtonResident);
            this.groupBox1.Location = new System.Drawing.Point(28, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection Type";
            // 
            // radioButtonCommercial
            // 
            this.radioButtonCommercial.AutoSize = true;
            this.radioButtonCommercial.Location = new System.Drawing.Point(24, 68);
            this.radioButtonCommercial.Name = "radioButtonCommercial";
            this.radioButtonCommercial.Size = new System.Drawing.Size(79, 17);
            this.radioButtonCommercial.TabIndex = 2;
            this.radioButtonCommercial.TabStop = true;
            this.radioButtonCommercial.Text = "Commercial";
            this.radioButtonCommercial.UseVisualStyleBackColor = true;
            // 
            // radioButtonIndustrial
            // 
            this.radioButtonIndustrial.AutoSize = true;
            this.radioButtonIndustrial.Location = new System.Drawing.Point(24, 103);
            this.radioButtonIndustrial.Name = "radioButtonIndustrial";
            this.radioButtonIndustrial.Size = new System.Drawing.Size(67, 17);
            this.radioButtonIndustrial.TabIndex = 1;
            this.radioButtonIndustrial.TabStop = true;
            this.radioButtonIndustrial.Text = "Industrial";
            this.radioButtonIndustrial.UseVisualStyleBackColor = true;
            // 
            // radioButtonResident
            // 
            this.radioButtonResident.AutoSize = true;
            this.radioButtonResident.Location = new System.Drawing.Point(24, 31);
            this.radioButtonResident.Name = "radioButtonResident";
            this.radioButtonResident.Size = new System.Drawing.Size(77, 17);
            this.radioButtonResident.TabIndex = 0;
            this.radioButtonResident.TabStop = true;
            this.radioButtonResident.Text = "Residential";
            this.radioButtonResident.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.offPeakHourBox);
            this.groupBox2.Controls.Add(this.peakHourBox);
            this.groupBox2.Location = new System.Drawing.Point(254, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 179);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "KWH Used";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Off Peak Hour";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Peak Hour";
            // 
            // offPeakHourBox
            // 
            this.offPeakHourBox.Location = new System.Drawing.Point(90, 91);
            this.offPeakHourBox.Name = "offPeakHourBox";
            this.offPeakHourBox.Size = new System.Drawing.Size(100, 20);
            this.offPeakHourBox.TabIndex = 1;
            // 
            // peakHourBox
            // 
            this.peakHourBox.Location = new System.Drawing.Point(90, 46);
            this.peakHourBox.Name = "peakHourBox";
            this.peakHourBox.Size = new System.Drawing.Size(100, 20);
            this.peakHourBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Bill";
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(78, 231);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(146, 20);
            this.resultBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(254, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calculate Bill";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(744, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Form1";
            this.Text = "Electricity Bill Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonCommercial;
        private System.Windows.Forms.RadioButton radioButtonIndustrial;
        private System.Windows.Forms.RadioButton radioButtonResident;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox offPeakHourBox;
        private System.Windows.Forms.TextBox peakHourBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button button1;
    }
}

