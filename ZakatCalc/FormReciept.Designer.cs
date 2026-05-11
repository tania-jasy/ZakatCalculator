namespace ZakatCalc
{
    partial class FormReciept
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
            lblReciept = new System.Windows.Forms.Panel();
            dgvHeader = new System.Windows.Forms.DataGridView();
            dgvBreakdown = new System.Windows.Forms.DataGridView();
            lblBreakDown = new System.Windows.Forms.Label();
            lblSubtitle = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            lblReciept.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHeader).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBreakdown).BeginInit();
            SuspendLayout();
            // 
            // lblReciept
            // 
            lblReciept.Controls.Add(dgvHeader);
            lblReciept.Controls.Add(dgvBreakdown);
            lblReciept.Controls.Add(lblBreakDown);
            lblReciept.Controls.Add(lblSubtitle);
            lblReciept.Controls.Add(lblTitle);
            lblReciept.Location = new System.Drawing.Point(-3, -1);
            lblReciept.Margin = new System.Windows.Forms.Padding(2);
            lblReciept.Name = "lblReciept";
            lblReciept.Size = new System.Drawing.Size(349, 466);
            lblReciept.TabIndex = 1;
            // 
            // dgvHeader
            // 
            dgvHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHeader.Location = new System.Drawing.Point(3, 85);
            dgvHeader.Name = "dgvHeader";
            dgvHeader.Size = new System.Drawing.Size(343, 170);
            dgvHeader.TabIndex = 4;
            // 
            // dgvBreakdown
            // 
            dgvBreakdown.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBreakdown.Location = new System.Drawing.Point(3, 301);
            dgvBreakdown.Name = "dgvBreakdown";
            dgvBreakdown.Size = new System.Drawing.Size(343, 162);
            dgvBreakdown.TabIndex = 3;
            // 
            // lblBreakDown
            // 
            lblBreakDown.AutoSize = true;
            lblBreakDown.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblBreakDown.Location = new System.Drawing.Point(13, 272);
            lblBreakDown.Name = "lblBreakDown";
            lblBreakDown.Size = new System.Drawing.Size(158, 17);
            lblBreakDown.TabIndex = 2;
            lblBreakDown.Text = "Organization Breakdown";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblSubtitle.Location = new System.Drawing.Point(13, 54);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new System.Drawing.Size(264, 17);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Confirmation and record of your donation";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTitle.Location = new System.Drawing.Point(143, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(61, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Reciept";
            // 
            // FormReciept
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(344, 470);
            Controls.Add(lblReciept);
            Name = "FormReciept";
            Text = "FormReciept";
            Load += FormReciept_Load;
            lblReciept.ResumeLayout(false);
            lblReciept.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHeader).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBreakdown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel lblReciept;
        private System.Windows.Forms.DataGridView dgvHeader;
        private System.Windows.Forms.DataGridView dgvBreakdown;
        private System.Windows.Forms.Label lblBreakDown;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTitle;
    }
}