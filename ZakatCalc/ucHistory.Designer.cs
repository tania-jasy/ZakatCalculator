namespace ZakatCalc
{
    partial class ucHistory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new System.Windows.Forms.Panel();
            lblTotal = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            lblDonationCount = new System.Windows.Forms.Label();
            lbl = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            dgvHistory = new System.Windows.Forms.DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.Info;
            panel1.Controls.Add(lblTotal);
            panel1.Location = new System.Drawing.Point(187, 42);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(153, 59);
            panel1.TabIndex = 2;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTotal.Location = new System.Drawing.Point(3, 13);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new System.Drawing.Size(25, 30);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "0";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.Info;
            panel2.Controls.Add(lblDonationCount);
            panel2.Location = new System.Drawing.Point(417, 42);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(153, 59);
            panel2.TabIndex = 9;
            // 
            // lblDonationCount
            // 
            lblDonationCount.AutoSize = true;
            lblDonationCount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblDonationCount.Location = new System.Drawing.Point(63, 13);
            lblDonationCount.Name = "lblDonationCount";
            lblDonationCount.Size = new System.Drawing.Size(25, 30);
            lblDonationCount.TabIndex = 8;
            lblDonationCount.Text = "0";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lbl.Location = new System.Drawing.Point(221, 104);
            lbl.Name = "lbl";
            lbl.Size = new System.Drawing.Size(85, 20);
            lbl.TabIndex = 10;
            lbl.Text = "Total Given";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(435, 104);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(118, 20);
            label3.TabIndex = 11;
            label3.Text = "Donation Count";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label8.Location = new System.Drawing.Point(288, 200);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(176, 30);
            label8.TabIndex = 12;
            label8.Text = "Past Transactions";
            // 
            // dgvHistory
            // 
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.AllowUserToDeleteRows = false;
            dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Location = new System.Drawing.Point(3, 238);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.ReadOnly = true;
            dgvHistory.Size = new System.Drawing.Size(784, 379);
            dgvHistory.TabIndex = 13;
            // 
            // ucHistory
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(dgvHistory);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(lbl);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ucHistory";
            Size = new System.Drawing.Size(790, 620);
            Load += ucHistory_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDonationCount;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvHistory;
    }
}
