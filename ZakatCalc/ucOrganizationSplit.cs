using FormStart;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Transactions;
using System.Windows.Forms;

namespace ZakatCalc
{
    public partial class ucOrganizationSplit : UserControl
    {
        DataAccess Da;
        FormAdmin Fa;
        FormDonor Fd;
        int DonationId;
        decimal Amount;
        string trnxID;  
        public ucOrganizationSplit(FormAdmin admin = null, FormDonor donor = null, int donationId = 0, decimal amount = 0, string trnxID = "")
        {
            InitializeComponent();
            Da = new DataAccess();

            DonationId = donationId;
            Amount = amount;
            this.trnxID = trnxID;

            if (admin != null) { Fa = admin; }
            if (donor != null) { Fd = donor; }

            Da.PopulateGridView("SELECT org_id, name, category, bank_details FROM Organizations", "organizations", dgvOrgSplit);


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (Fa != null) { Fa.LoadControl(new ucDonations()); }
            else if (Fd != null) { Fd.LoadControl(new ucDonations()); }
        }

        private void dgvOrgSplit_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvOrgSplit.CurrentCell?.OwningColumn.Name == "Percentage")
            {
                if (e.Control is TextBox tb)
                {
                    tb.KeyPress -= PercentageBox_KeyPress;
                    tb.KeyPress += PercentageBox_KeyPress;
                }
            }
        }

        private void PercentageBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b')
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == '.' && (sender as TextBox)?.Text.Contains(".") == true)
                e.Handled = true;
        }


        private void cbAutoSplit_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbAutoSplit.Checked) return;

            var checkedRows = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dgvOrgSplit.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Select"].Value) == true)
                    checkedRows.Add(row);
            }

            if (checkedRows.Count == 0)
            {
                MessageBox.Show("Please select at least one organization before using Auto Split.");
                cbAutoSplit.Checked = false;
                return;
            }

            foreach (DataGridViewRow row in dgvOrgSplit.Rows)
                row.Cells["Percentage"].Value = "";

            decimal equal = Math.Round(100m / checkedRows.Count, 2);
            decimal assigned = 0;

            for (int i = 0; i < checkedRows.Count; i++)
            {
                decimal value = (i == checkedRows.Count - 1) ? Math.Round(100m - assigned, 2) : equal;
                checkedRows[i].Cells["Percentage"].Value = value.ToString("0.##");
                assigned += equal;
            }
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            var selected = new List<(int OrgId, decimal Percentage)>();

            foreach (DataGridViewRow row in dgvOrgSplit.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Select"].Value) != true) continue;

                string rawPct = row.Cells["Percentage"].Value?.ToString()?.Trim();

                if (string.IsNullOrEmpty(rawPct) || !decimal.TryParse(rawPct, out decimal pct) || pct <= 0)
                {
                    MessageBox.Show("All selected rows must add up to 100%.");
                    return;
                }

                selected.Add((Convert.ToInt32(row.Cells["org_id"].Value), pct));
            }

            if (selected.Count == 0)
            {
                MessageBox.Show("Please select at least one organization.");
                return;
            }

            if (!cbAutoSplit.Checked)
            {
                decimal total = 0;
                foreach (var r in selected) total += r.Percentage;

                if (Math.Abs(total - 100m) > 0.01m)
                {
                    MessageBox.Show("Percentages must add up to 100%. Current total: " + total.ToString("0.##") + "%");
                    return;
                }
            }

            foreach (var (orgId, percentage) in selected)
            {
                decimal amount = Math.Round(Amount * percentage / 100m, 2);
                string query = "INSERT INTO DONATION_SPLITS (donation_id, org_id, amount, percentage) VALUES (" + DonationId + ", " + orgId + ", " + amount + ", " + percentage + ")";
                Da.ExecuteQuery(query);
            }

            string receiptQuery =
                "INSERT INTO RECEIPTS (donation_id, transaction_id, issued_at) VALUES (" + DonationId + ", '" + trnxID + "', GETDATE()); " +
                "SELECT SCOPE_IDENTITY();";  // or LAST_INSERT_ID() if MySQL

            int receiptId = Convert.ToInt32(Da.ExecuteScalar(receiptQuery));

            MessageBox.Show("Donation split saved successfully!");

            FormReciept receipt = new FormReciept(DonationId, Amount, receiptId, trnxID);
            receipt.Show();

        }



        private void dgvOrgSplit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
