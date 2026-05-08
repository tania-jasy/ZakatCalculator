namespace ZakatCalc
{
    partial class FormLoginReg
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
            this.pnlRegLogin = new System.Windows.Forms.Panel();
            this.cbReg = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // pnlRegLogin
            // 
            this.pnlRegLogin.Location = new System.Drawing.Point(9, 81);
            this.pnlRegLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlRegLogin.Name = "pnlRegLogin";
            this.pnlRegLogin.Size = new System.Drawing.Size(274, 314);
            this.pnlRegLogin.TabIndex = 0;
            // 
            // cbReg
            // 
            this.cbReg.AutoSize = true;
            this.cbReg.Location = new System.Drawing.Point(106, 60);
            this.cbReg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbReg.Name = "cbReg";
            this.cbReg.Size = new System.Drawing.Size(82, 17);
            this.cbReg.TabIndex = 1;
            this.cbReg.Text = "Registration";
            this.cbReg.UseVisualStyleBackColor = true;
            this.cbReg.CheckedChanged += new System.EventHandler(this.cbReg_CheckedChanged);
            // 
            // FormLoginReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(292, 405);
            this.Controls.Add(this.cbReg);
            this.Controls.Add(this.pnlRegLogin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormLoginReg";
            this.Text = "Login and Registration";
            this.Load += new System.EventHandler(this.FormLoginReg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlRegLogin;
        private System.Windows.Forms.CheckBox cbReg;
    }
}

