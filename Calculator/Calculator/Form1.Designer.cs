namespace Calculator
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
            this.resultBox = new System.Windows.Forms.TextBox();
            this.buttonPercent = new System.Windows.Forms.Button();
            this.buttonRoot = new System.Windows.Forms.Button();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.buttonOneForth = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonMul = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonadd = new System.Windows.Forms.Button();
            this.buttonPlusMinus = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonEaual = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // resultBox
            // 
            this.resultBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.resultBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultBox.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox.ForeColor = System.Drawing.SystemColors.Window;
            this.resultBox.Location = new System.Drawing.Point(0, 0);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(254, 66);
            this.resultBox.TabIndex = 1;
            this.resultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.resultBox.UseWaitCursor = true;
            this.resultBox.TextChanged += new System.EventHandler(this.ResultBox_TextChanged);
            // 
            // buttonPercent
            // 
            this.buttonPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPercent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPercent.Location = new System.Drawing.Point(0, 72);
            this.buttonPercent.Name = "buttonPercent";
            this.buttonPercent.Size = new System.Drawing.Size(59, 46);
            this.buttonPercent.TabIndex = 2;
            this.buttonPercent.Text = "%";
            this.buttonPercent.UseVisualStyleBackColor = false;
            this.buttonPercent.Click += new System.EventHandler(this.ButtonPercent_Click);
            // 
            // buttonRoot
            // 
            this.buttonRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRoot.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRoot.Location = new System.Drawing.Point(65, 72);
            this.buttonRoot.Name = "buttonRoot";
            this.buttonRoot.Size = new System.Drawing.Size(59, 46);
            this.buttonRoot.TabIndex = 2;
            this.buttonRoot.Text = "√";
            this.buttonRoot.UseVisualStyleBackColor = false;
            this.buttonRoot.Click += new System.EventHandler(this.ButtonRoot_Click);
            // 
            // buttonSquare
            // 
            this.buttonSquare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSquare.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSquare.Location = new System.Drawing.Point(130, 72);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(59, 46);
            this.buttonSquare.TabIndex = 2;
            this.buttonSquare.Text = "x²";
            this.buttonSquare.UseVisualStyleBackColor = false;
            this.buttonSquare.Click += new System.EventHandler(this.ButtonSquare_Click);
            // 
            // buttonOneForth
            // 
            this.buttonOneForth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonOneForth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOneForth.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonOneForth.Location = new System.Drawing.Point(195, 72);
            this.buttonOneForth.Name = "buttonOneForth";
            this.buttonOneForth.Size = new System.Drawing.Size(59, 46);
            this.buttonOneForth.TabIndex = 2;
            this.buttonOneForth.Text = "¼";
            this.buttonOneForth.UseVisualStyleBackColor = false;
            this.buttonOneForth.Click += new System.EventHandler(this.ButtonOneForth_Click);
            // 
            // buttonCE
            // 
            this.buttonCE.BackColor = System.Drawing.Color.White;
            this.buttonCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCE.ForeColor = System.Drawing.Color.Red;
            this.buttonCE.Location = new System.Drawing.Point(0, 124);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(59, 46);
            this.buttonCE.TabIndex = 2;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = false;
            this.buttonCE.Click += new System.EventHandler(this.ButtonCE_Click);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.Color.Red;
            this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonC.ForeColor = System.Drawing.Color.White;
            this.buttonC.Location = new System.Drawing.Point(65, 124);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(59, 46);
            this.buttonC.TabIndex = 2;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.ButtonC_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDel.Location = new System.Drawing.Point(130, 124);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(59, 46);
            this.buttonDel.TabIndex = 2;
            this.buttonDel.Text = "<-";
            this.buttonDel.UseVisualStyleBackColor = false;
            // 
            // buttonDiv
            // 
            this.buttonDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDiv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDiv.Location = new System.Drawing.Point(195, 124);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(59, 46);
            this.buttonDiv.TabIndex = 2;
            this.buttonDiv.Text = "÷";
            this.buttonDiv.UseVisualStyleBackColor = false;
            this.buttonDiv.Click += new System.EventHandler(this.ButtonDiv_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.Location = new System.Drawing.Point(0, 176);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(59, 46);
            this.button7.TabIndex = 2;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.Location = new System.Drawing.Point(65, 176);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(59, 46);
            this.button8.TabIndex = 2;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button9.Location = new System.Drawing.Point(130, 176);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(59, 46);
            this.button9.TabIndex = 2;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // buttonMul
            // 
            this.buttonMul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMul.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMul.Location = new System.Drawing.Point(195, 176);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(59, 46);
            this.buttonMul.TabIndex = 2;
            this.buttonMul.Text = "×";
            this.buttonMul.UseVisualStyleBackColor = false;
            this.buttonMul.Click += new System.EventHandler(this.ButtonMul_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(0, 228);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(59, 46);
            this.button4.TabIndex = 2;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(65, 228);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(59, 46);
            this.button5.TabIndex = 2;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Location = new System.Drawing.Point(130, 228);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(59, 46);
            this.button6.TabIndex = 2;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSub.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSub.Location = new System.Drawing.Point(195, 228);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(59, 46);
            this.buttonSub.TabIndex = 2;
            this.buttonSub.Text = "-";
            this.buttonSub.UseVisualStyleBackColor = false;
            this.buttonSub.Click += new System.EventHandler(this.ButtonSub_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(0, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(65, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(130, 280);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // buttonadd
            // 
            this.buttonadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonadd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonadd.Location = new System.Drawing.Point(195, 280);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(59, 46);
            this.buttonadd.TabIndex = 2;
            this.buttonadd.Text = "+";
            this.buttonadd.UseVisualStyleBackColor = false;
            this.buttonadd.Click += new System.EventHandler(this.Buttonadd_Click);
            // 
            // buttonPlusMinus
            // 
            this.buttonPlusMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonPlusMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlusMinus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPlusMinus.Location = new System.Drawing.Point(0, 332);
            this.buttonPlusMinus.Name = "buttonPlusMinus";
            this.buttonPlusMinus.Size = new System.Drawing.Size(59, 46);
            this.buttonPlusMinus.TabIndex = 2;
            this.buttonPlusMinus.Text = "±";
            this.buttonPlusMinus.UseVisualStyleBackColor = false;
            this.buttonPlusMinus.Click += new System.EventHandler(this.ButtonPlusMinus_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button0.Location = new System.Drawing.Point(65, 332);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(59, 46);
            this.button0.TabIndex = 2;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.Button0_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDot.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDot.Location = new System.Drawing.Point(130, 332);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(59, 46);
            this.buttonDot.TabIndex = 2;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = false;
            this.buttonDot.Click += new System.EventHandler(this.ButtonDot_Click);
            // 
            // buttonEaual
            // 
            this.buttonEaual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEaual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEaual.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEaual.Location = new System.Drawing.Point(195, 332);
            this.buttonEaual.Name = "buttonEaual";
            this.buttonEaual.Size = new System.Drawing.Size(59, 46);
            this.buttonEaual.TabIndex = 2;
            this.buttonEaual.Text = "=";
            this.buttonEaual.UseVisualStyleBackColor = false;
            this.buttonEaual.Click += new System.EventHandler(this.ButtonEaual_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Developed By ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(144, 474);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(35, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ruhul";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(253, 490);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEaual);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonMul);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonOneForth);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonSquare);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonRoot);
            this.Controls.Add(this.buttonPlusMinus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.buttonPercent);
            this.Controls.Add(this.resultBox);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button buttonPercent;
        private System.Windows.Forms.Button buttonRoot;
        private System.Windows.Forms.Button buttonSquare;
        private System.Windows.Forms.Button buttonOneForth;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonMul;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Button buttonPlusMinus;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonEaual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

