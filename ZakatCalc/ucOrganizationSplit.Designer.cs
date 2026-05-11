namespace ZakatCalc
{
    partial class ucOrganizationSplit
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
            lblHeader = new System.Windows.Forms.Label();
            dgvOrgSplit = new System.Windows.Forms.DataGridView();
            btnBack = new System.Windows.Forms.Button();
            btnDonate = new System.Windows.Forms.Button();
            cbAutoSplit = new System.Windows.Forms.CheckBox();
            select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            org_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bank_details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            percentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvOrgSplit).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblHeader.Location = new System.Drawing.Point(277, 26);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new System.Drawing.Size(214, 30);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Split your donations";
            // 
            // dgvOrgSplit
            // 
            dgvOrgSplit.AllowUserToAddRows = false;
            dgvOrgSplit.AllowUserToDeleteRows = false;
            dgvOrgSplit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrgSplit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { select, org_id, name, category, bank_details, percentage });
            dgvOrgSplit.Location = new System.Drawing.Point(3, 86);
            dgvOrgSplit.Name = "dgvOrgSplit";
            dgvOrgSplit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvOrgSplit.Size = new System.Drawing.Size(784, 413);
            dgvOrgSplit.TabIndex = 1;
            dgvOrgSplit.CellContentClick += dgvOrgSplit_CellContentClick;
            dgvOrgSplit.EditingControlShowing += dgvOrgSplit_EditingControlShowing;
            // 
            // btnBack
            // 
            btnBack.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnBack.Location = new System.Drawing.Point(3, 18);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(75, 38);
            btnBack.TabIndex = 2;
            btnBack.Text = "<--";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnDonate
            // 
            btnDonate.Location = new System.Drawing.Point(621, 538);
            btnDonate.Name = "btnDonate";
            btnDonate.Size = new System.Drawing.Size(152, 45);
            btnDonate.TabIndex = 4;
            btnDonate.Text = "Donate";
            btnDonate.UseVisualStyleBackColor = true;
            btnDonate.Click += btnDonate_Click;
            // 
            // cbAutoSplit
            // 
            cbAutoSplit.AutoSize = true;
            cbAutoSplit.Location = new System.Drawing.Point(695, 513);
            cbAutoSplit.Name = "cbAutoSplit";
            cbAutoSplit.Size = new System.Drawing.Size(78, 19);
            cbAutoSplit.TabIndex = 5;
            cbAutoSplit.Text = "Auto Split";
            cbAutoSplit.UseVisualStyleBackColor = true;
            cbAutoSplit.CheckedChanged += cbAutoSplit_CheckedChanged;
            // 
            // select
            // 
            select.DataPropertyName = "select";
            select.HeaderText = "Select";
            select.Name = "select";
            select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            select.Width = 50;
            // 
            // org_id
            // 
            org_id.DataPropertyName = "org_id";
            org_id.HeaderText = "Org. ID";
            org_id.Name = "org_id";
            org_id.ReadOnly = true;
            // 
            // name
            // 
            name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            name.DataPropertyName = "name";
            name.HeaderText = "Organization Name";
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // category
            // 
            category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            category.DataPropertyName = "category";
            category.HeaderText = "Category of Charity";
            category.Name = "category";
            category.ReadOnly = true;
            // 
            // bank_details
            // 
            bank_details.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            bank_details.DataPropertyName = "bank_details";
            bank_details.HeaderText = "Bank Details";
            bank_details.Name = "bank_details";
            bank_details.ReadOnly = true;
            // 
            // percentage
            // 
            percentage.DataPropertyName = "percentage";
            percentage.HeaderText = "Percentage";
            percentage.Name = "percentage";
            // 
            // ucOrganizationSplit
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(cbAutoSplit);
            Controls.Add(btnDonate);
            Controls.Add(btnBack);
            Controls.Add(dgvOrgSplit);
            Controls.Add(lblHeader);
            Name = "ucOrganizationSplit";
            Size = new System.Drawing.Size(790, 620);
            ((System.ComponentModel.ISupportInitialize)dgvOrgSplit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DataGridView dgvOrgSplit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDonate;
        private System.Windows.Forms.CheckBox cbAutoSplit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn org_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn bank_details;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentage;
    }
}
