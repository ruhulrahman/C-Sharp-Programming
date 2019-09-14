namespace Bank_Interest_Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.bankNamecomboBox = new System.Windows.Forms.ComboBox();
            this.YearBox = new System.Windows.Forms.TextBox();
            this.balanceBox = new System.Windows.Forms.TextBox();
            this.interestBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalInterestWithCapBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.totalCycleInterestWIthCapBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.totalCycleInterestBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bank Name";
            // 
            // bankNamecomboBox
            // 
            this.bankNamecomboBox.FormattingEnabled = true;
            this.bankNamecomboBox.Location = new System.Drawing.Point(132, 13);
            this.bankNamecomboBox.Name = "bankNamecomboBox";
            this.bankNamecomboBox.Size = new System.Drawing.Size(169, 21);
            this.bankNamecomboBox.TabIndex = 1;
            // 
            // YearBox
            // 
            this.YearBox.Location = new System.Drawing.Point(132, 60);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(56, 20);
            this.YearBox.TabIndex = 2;
            // 
            // balanceBox
            // 
            this.balanceBox.Location = new System.Drawing.Point(132, 102);
            this.balanceBox.Name = "balanceBox";
            this.balanceBox.Size = new System.Drawing.Size(169, 20);
            this.balanceBox.TabIndex = 3;
            // 
            // interestBox
            // 
            this.interestBox.Location = new System.Drawing.Point(155, 25);
            this.interestBox.Name = "interestBox";
            this.interestBox.Size = new System.Drawing.Size(169, 20);
            this.interestBox.TabIndex = 4;
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.Color.OrangeRed;
            this.CalculateButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CalculateButton.Location = new System.Drawing.Point(132, 138);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(169, 39);
            this.CalculateButton.TabIndex = 5;
            this.CalculateButton.Text = "Calculate Interest";
            this.CalculateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total Interest";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Balance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Time (In Year)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Total Interest with Capital";
            // 
            // totalInterestWithCapBox
            // 
            this.totalInterestWithCapBox.Location = new System.Drawing.Point(155, 51);
            this.totalInterestWithCapBox.Name = "totalInterestWithCapBox";
            this.totalInterestWithCapBox.Size = new System.Drawing.Size(169, 20);
            this.totalInterestWithCapBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Total Interest with Capital";
            // 
            // totalCycleInterestWIthCapBox
            // 
            this.totalCycleInterestWIthCapBox.Location = new System.Drawing.Point(144, 55);
            this.totalCycleInterestWIthCapBox.Name = "totalCycleInterestWIthCapBox";
            this.totalCycleInterestWIthCapBox.Size = new System.Drawing.Size(169, 20);
            this.totalCycleInterestWIthCapBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Total Interest";
            // 
            // totalCycleInterestBox
            // 
            this.totalCycleInterestBox.Location = new System.Drawing.Point(144, 29);
            this.totalCycleInterestBox.Name = "totalCycleInterestBox";
            this.totalCycleInterestBox.Size = new System.Drawing.Size(169, 20);
            this.totalCycleInterestBox.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.totalCycleInterestWIthCapBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.totalCycleInterestBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 102);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cycle Interest";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.totalInterestWithCapBox);
            this.groupBox2.Controls.Add(this.interestBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 102);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Simple Interest";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(210, 428);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(61, 13);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ruhul Amin";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(92, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Software Developed by ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(374, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.balanceBox);
            this.Controls.Add(this.YearBox);
            this.Controls.Add(this.bankNamecomboBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bank Interest Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox bankNamecomboBox;
        private System.Windows.Forms.TextBox YearBox;
        private System.Windows.Forms.TextBox balanceBox;
        private System.Windows.Forms.TextBox interestBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox totalInterestWithCapBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox totalCycleInterestWIthCapBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox totalCycleInterestBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label8;
    }
}

