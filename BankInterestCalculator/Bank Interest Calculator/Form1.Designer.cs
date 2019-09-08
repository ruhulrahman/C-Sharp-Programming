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
            this.resultBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bank Name";
            // 
            // bankNamecomboBox
            // 
            this.bankNamecomboBox.FormattingEnabled = true;
            this.bankNamecomboBox.Location = new System.Drawing.Point(135, 23);
            this.bankNamecomboBox.Name = "bankNamecomboBox";
            this.bankNamecomboBox.Size = new System.Drawing.Size(169, 21);
            this.bankNamecomboBox.TabIndex = 1;
            // 
            // YearBox
            // 
            this.YearBox.Location = new System.Drawing.Point(135, 70);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(56, 20);
            this.YearBox.TabIndex = 2;
            // 
            // balanceBox
            // 
            this.balanceBox.Location = new System.Drawing.Point(135, 112);
            this.balanceBox.Name = "balanceBox";
            this.balanceBox.Size = new System.Drawing.Size(169, 20);
            this.balanceBox.TabIndex = 3;
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(135, 203);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(169, 20);
            this.resultBox.TabIndex = 4;
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.Color.Red;
            this.CalculateButton.Location = new System.Drawing.Point(135, 148);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(169, 39);
            this.CalculateButton.TabIndex = 5;
            this.CalculateButton.Text = "Calculate Interest";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total Interest";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Balance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Time (In Year)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.balanceBox);
            this.Controls.Add(this.YearBox);
            this.Controls.Add(this.bankNamecomboBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox bankNamecomboBox;
        private System.Windows.Forms.TextBox YearBox;
        private System.Windows.Forms.TextBox balanceBox;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

