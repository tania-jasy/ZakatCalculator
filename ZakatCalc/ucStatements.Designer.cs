namespace ZakatCalc
{
    partial class ucStatements
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
            lblDonations = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            lblDonors = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            lblTransactions = new System.Windows.Forms.Label();
            panel4 = new System.Windows.Forms.Panel();
            lblOrganizations = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            dgvOrg = new System.Windows.Forms.DataGridView();
            dgvTime = new System.Windows.Forms.DataGridView();
            label10 = new System.Windows.Forms.Label();
            dgvDonation = new System.Windows.Forms.DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDonation).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.Info;
            panel1.Controls.Add(lblDonations);
            panel1.Location = new System.Drawing.Point(84, 9);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(153, 59);
            panel1.TabIndex = 1;
            // 
            // lblDonations
            // 
            lblDonations.AutoSize = true;
            lblDonations.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblDonations.Location = new System.Drawing.Point(3, 13);
            lblDonations.Name = "lblDonations";
            lblDonations.Size = new System.Drawing.Size(25, 30);
            lblDonations.TabIndex = 8;
            lblDonations.Text = "0";
            lblDonations.Click += lblDonations_Click;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.Info;
            panel2.Controls.Add(lblDonors);
            panel2.Location = new System.Drawing.Point(243, 9);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(153, 59);
            panel2.TabIndex = 2;
            // 
            // lblDonors
            // 
            lblDonors.AutoSize = true;
            lblDonors.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblDonors.Location = new System.Drawing.Point(56, 13);
            lblDonors.Name = "lblDonors";
            lblDonors.Size = new System.Drawing.Size(25, 30);
            lblDonors.TabIndex = 9;
            lblDonors.Text = "0";
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.SystemColors.Info;
            panel3.Controls.Add(lblTransactions);
            panel3.Location = new System.Drawing.Point(402, 9);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(153, 59);
            panel3.TabIndex = 3;
            // 
            // lblTransactions
            // 
            lblTransactions.AutoSize = true;
            lblTransactions.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTransactions.Location = new System.Drawing.Point(63, 13);
            lblTransactions.Name = "lblTransactions";
            lblTransactions.Size = new System.Drawing.Size(25, 30);
            lblTransactions.TabIndex = 10;
            lblTransactions.Text = "0";
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.SystemColors.Info;
            panel4.Controls.Add(lblOrganizations);
            panel4.Location = new System.Drawing.Point(561, 9);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(153, 59);
            panel4.TabIndex = 3;
            // 
            // lblOrganizations
            // 
            lblOrganizations.AutoSize = true;
            lblOrganizations.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblOrganizations.Location = new System.Drawing.Point(61, 13);
            lblOrganizations.Name = "lblOrganizations";
            lblOrganizations.Size = new System.Drawing.Size(25, 30);
            lblOrganizations.TabIndex = 11;
            lblOrganizations.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(120, 71);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(79, 20);
            label1.TabIndex = 4;
            label1.Text = "Donations";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(283, 71);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(59, 20);
            label2.TabIndex = 5;
            label2.Text = "Donors";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(427, 71);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(93, 20);
            label3.TabIndex = 6;
            label3.Text = "Transactions";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(581, 71);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(104, 20);
            label4.TabIndex = 7;
            label4.Text = "Organizations";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label8.Location = new System.Drawing.Point(15, 124);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(199, 20);
            label8.TabIndex = 8;
            label8.Text = "Breakdown by Organizations";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label9.Location = new System.Drawing.Point(402, 124);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(186, 20);
            label9.TabIndex = 9;
            label9.Text = "Breakdown by Time Period";
            // 
            // dgvOrg
            // 
            dgvOrg.AllowUserToAddRows = false;
            dgvOrg.AllowUserToDeleteRows = false;
            dgvOrg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrg.Location = new System.Drawing.Point(15, 156);
            dgvOrg.Name = "dgvOrg";
            dgvOrg.ReadOnly = true;
            dgvOrg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvOrg.Size = new System.Drawing.Size(381, 196);
            dgvOrg.TabIndex = 10;
            // 
            // dgvTime
            // 
            dgvTime.AllowUserToAddRows = false;
            dgvTime.AllowUserToDeleteRows = false;
            dgvTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTime.Location = new System.Drawing.Point(402, 156);
            dgvTime.Name = "dgvTime";
            dgvTime.ReadOnly = true;
            dgvTime.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvTime.Size = new System.Drawing.Size(381, 196);
            dgvTime.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label10.Location = new System.Drawing.Point(324, 368);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(137, 20);
            label10.TabIndex = 12;
            label10.Text = "Donation Summary";
            // 
            // dgvDonation
            // 
            dgvDonation.AllowUserToAddRows = false;
            dgvDonation.AllowUserToDeleteRows = false;
            dgvDonation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonation.Location = new System.Drawing.Point(15, 393);
            dgvDonation.Name = "dgvDonation";
            dgvDonation.ReadOnly = true;
            dgvDonation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvDonation.Size = new System.Drawing.Size(768, 214);
            dgvDonation.TabIndex = 13;
            // 
            // ucStatements
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(dgvDonation);
            Controls.Add(label10);
            Controls.Add(dgvTime);
            Controls.Add(dgvOrg);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ucStatements";
            Size = new System.Drawing.Size(790, 620);
            Load += ucStatements_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrg).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDonation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDonations;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDonors;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTransactions;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblOrganizations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvOrg;
        private System.Windows.Forms.DataGridView dgvTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvDonation;
    }
}
