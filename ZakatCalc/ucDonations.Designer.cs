namespace ZakatCalc
{
    partial class ucDonations
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
            lblAmount = new System.Windows.Forms.Label();
            lblPayment = new System.Windows.Forms.Label();
            lblTrnx = new System.Windows.Forms.Label();
            txtAmount = new System.Windows.Forms.TextBox();
            txtTrnxID = new System.Windows.Forms.TextBox();
            cbPayment = new System.Windows.Forms.ComboBox();
            btnConfirm = new System.Windows.Forms.Button();
            tnCancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblAmount.Location = new System.Drawing.Point(289, 211);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new System.Drawing.Size(85, 25);
            lblAmount.TabIndex = 0;
            lblAmount.Text = "Amount";
            // 
            // lblPayment
            // 
            lblPayment.AutoSize = true;
            lblPayment.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblPayment.Location = new System.Drawing.Point(284, 257);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new System.Drawing.Size(90, 25);
            lblPayment.TabIndex = 1;
            lblPayment.Text = "Payment";
            // 
            // lblTrnx
            // 
            lblTrnx.AutoSize = true;
            lblTrnx.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTrnx.Location = new System.Drawing.Point(234, 307);
            lblTrnx.Name = "lblTrnx";
            lblTrnx.Size = new System.Drawing.Size(140, 25);
            lblTrnx.TabIndex = 2;
            lblTrnx.Text = "Transaction ID";
            // 
            // txtAmount
            // 
            txtAmount.Location = new System.Drawing.Point(391, 213);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new System.Drawing.Size(151, 23);
            txtAmount.TabIndex = 3;
            // 
            // txtTrnxID
            // 
            txtTrnxID.Location = new System.Drawing.Point(391, 309);
            txtTrnxID.Name = "txtTrnxID";
            txtTrnxID.ReadOnly = true;
            txtTrnxID.Size = new System.Drawing.Size(151, 23);
            txtTrnxID.TabIndex = 4;
            txtTrnxID.TextChanged += txtTrnxID_TextChanged;
            // 
            // cbPayment
            // 
            cbPayment.FormattingEnabled = true;
            cbPayment.Items.AddRange(new object[] { "bKash", "Nagad", "Rocket", "Bank Transfer" });
            cbPayment.Location = new System.Drawing.Point(390, 259);
            cbPayment.Name = "cbPayment";
            cbPayment.Size = new System.Drawing.Size(152, 23);
            cbPayment.TabIndex = 5;
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnConfirm.Location = new System.Drawing.Point(467, 359);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new System.Drawing.Size(75, 30);
            btnConfirm.TabIndex = 6;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // tnCancel
            // 
            tnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tnCancel.Location = new System.Drawing.Point(390, 359);
            tnCancel.Name = "tnCancel";
            tnCancel.Size = new System.Drawing.Size(71, 30);
            tnCancel.TabIndex = 7;
            tnCancel.Text = "Cancel";
            tnCancel.UseVisualStyleBackColor = true;
            tnCancel.Click += tnCancel_Click;
            // 
            // ucDonations
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(cbPayment);
            Controls.Add(txtTrnxID);
            Controls.Add(txtAmount);
            Controls.Add(lblTrnx);
            Controls.Add(lblPayment);
            Controls.Add(lblAmount);
            Name = "ucDonations";
            Size = new System.Drawing.Size(790, 620);
            Load += ucDonations_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblTrnx;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtTrnxID;
        private System.Windows.Forms.ComboBox cbPayment;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button tnCancel;
    }
}
