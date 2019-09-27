namespace Data_Add_in_Array_List
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
            this.addItemBtn = new System.Windows.Forms.Button();
            this.addItemBox = new System.Windows.Forms.TextBox();
            this.listItemBox = new System.Windows.Forms.ListBox();
            this.ClearAllBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addItemBtn
            // 
            this.addItemBtn.Location = new System.Drawing.Point(270, 23);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(89, 41);
            this.addItemBtn.TabIndex = 0;
            this.addItemBtn.Text = "Add Item";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // addItemBox
            // 
            this.addItemBox.Location = new System.Drawing.Point(12, 23);
            this.addItemBox.Multiline = true;
            this.addItemBox.Name = "addItemBox";
            this.addItemBox.Size = new System.Drawing.Size(235, 41);
            this.addItemBox.TabIndex = 1;
            this.addItemBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listItemBox
            // 
            this.listItemBox.FormattingEnabled = true;
            this.listItemBox.Location = new System.Drawing.Point(12, 86);
            this.listItemBox.Name = "listItemBox";
            this.listItemBox.Size = new System.Drawing.Size(235, 108);
            this.listItemBox.TabIndex = 2;
            this.listItemBox.SelectedIndexChanged += new System.EventHandler(this.listItemBox_SelectedIndexChanged);
            // 
            // ClearAllBtn
            // 
            this.ClearAllBtn.Location = new System.Drawing.Point(270, 93);
            this.ClearAllBtn.Name = "ClearAllBtn";
            this.ClearAllBtn.Size = new System.Drawing.Size(89, 38);
            this.ClearAllBtn.TabIndex = 3;
            this.ClearAllBtn.Text = "Clear All";
            this.ClearAllBtn.UseVisualStyleBackColor = true;
            this.ClearAllBtn.Click += new System.EventHandler(this.ClearAllBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(270, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 44);
            this.button2.TabIndex = 4;
            this.button2.Text = "Clear Selected Item";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 406);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ClearAllBtn);
            this.Controls.Add(this.listItemBox);
            this.Controls.Add(this.addItemBox);
            this.Controls.Add(this.addItemBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.TextBox addItemBox;
        private System.Windows.Forms.ListBox listItemBox;
        private System.Windows.Forms.Button ClearAllBtn;
        private System.Windows.Forms.Button button2;
    }
}

