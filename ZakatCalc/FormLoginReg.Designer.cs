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
            this.pnlRegLogin.Location = new System.Drawing.Point(12, 100);
            this.pnlRegLogin.Name = "pnlRegLogin";
            this.pnlRegLogin.Size = new System.Drawing.Size(366, 386);
            this.pnlRegLogin.TabIndex = 0;
            // 
            // cbReg
            // 
            this.cbReg.AutoSize = true;
            this.cbReg.Location = new System.Drawing.Point(142, 74);
            this.cbReg.Name = "cbReg";
            this.cbReg.Size = new System.Drawing.Size(101, 20);
            this.cbReg.TabIndex = 1;
            this.cbReg.Text = "Registration";
            this.cbReg.UseVisualStyleBackColor = true;
            this.cbReg.CheckedChanged += new System.EventHandler(this.cbReg_CheckedChanged);
            // 
            // FormLoginReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 498);
            this.Controls.Add(this.cbReg);
            this.Controls.Add(this.pnlRegLogin);
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

