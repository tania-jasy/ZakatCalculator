using FormStart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZakatCalc
{
    public partial class FormReciept : Form
    {
        int DonationId;
        decimal Amount;
        int ReceiptId;
        string trnxID;

        DataAccess Da;

        public FormReciept(int donationId, decimal amount, int receiptId, string trnxID)
        {
            InitializeComponent();
            Da = new DataAccess();

            DonationId = donationId;
            Amount = amount;
            ReceiptId = receiptId;
            this.trnxID = trnxID;
        }

        private void FormReciept_Load(object sender, EventArgs e)
        {
            LoadHeader();
            LoadOrgBreakdown();
        }

        private void LoadHeader()
        {
            string sql =
                "SELECT r.transaction_id, r.issued_at, u.username, d.total_amount, d.payment_method " +
                "FROM RECEIPTS r " +
                "JOIN DONATIONS d ON d.donation_id = r.donation_id " +
                "JOIN USERS u ON u.user_id = d.user_id " +
                "WHERE r.receipt_id = " + this.ReceiptId;

            DataTable result = Da.ExecuteQueryTable(sql);

            // Build a simple 2-column key/value DataTable for display
            var display = new DataTable();
            display.Columns.Add("Field");
            display.Columns.Add("Details");

            if (result.Rows.Count > 0)
            {
                var row = result.Rows[0];
                display.Rows.Add("Transaction ID", row["transaction_id"]);
                display.Rows.Add("Date & Time", Convert.ToDateTime(row["issued_at"]).ToString("yyyy-MM-dd HH:mm:ss"));
                display.Rows.Add("Donor Name", row["username"]);
                display.Rows.Add("Total Amount Paid", Convert.ToDecimal(row["total_amount"]).ToString("C"));
                display.Rows.Add("Payment Method", row["payment_method"]);
            }

            dgvHeader.DataSource = display;
            dgvHeader.AutoGenerateColumns = true;
            dgvHeader.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHeader.ReadOnly = true;
            dgvHeader.AllowUserToAddRows = false;
            dgvHeader.RowHeadersVisible = false;
        }

        private void LoadOrgBreakdown()
        {
            string sql =
                "SELECT o.name AS [Organization], " +
                "       ds.percentage AS [Percentage (%)], " +
                "       ds.amount AS [Amount] " +
                "FROM DONATION_SPLITS ds " +
                "JOIN ORGANIZATIONS o ON o.org_id = ds.org_id " +
                "WHERE ds.donation_id = " + this.DonationId;

            DataTable result = Da.ExecuteQueryTable(sql);

            dgvBreakdown.DataSource = result;
            dgvBreakdown.AutoGenerateColumns = true;
            dgvBreakdown.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBreakdown.ReadOnly = true;
            dgvBreakdown.AllowUserToAddRows = false;
            dgvBreakdown.RowHeadersVisible = false;
        }
    }
}
