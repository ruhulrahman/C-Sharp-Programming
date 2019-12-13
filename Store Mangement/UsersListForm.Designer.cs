namespace Store_Mangement
{
    partial class UsersListForm
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
            this.panelAddProductHead = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panelAddProductHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAddProductHead
            // 
            this.panelAddProductHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelAddProductHead.Controls.Add(this.label10);
            this.panelAddProductHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAddProductHead.Location = new System.Drawing.Point(0, 0);
            this.panelAddProductHead.Name = "panelAddProductHead";
            this.panelAddProductHead.Size = new System.Drawing.Size(728, 36);
            this.panelAddProductHead.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(302, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Users List";
            // 
            // UsersListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 407);
            this.Controls.Add(this.panelAddProductHead);
            this.Name = "UsersListForm";
            this.Text = "UsersListForm";
            this.panelAddProductHead.ResumeLayout(false);
            this.panelAddProductHead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAddProductHead;
        private System.Windows.Forms.Label label10;
    }
}