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
            try
            {
                Da = new DataAccess();

                DonationId = donationId;
                Amount = amount;
                this.trnxID = trnxID;

                if (admin != null) { Fa = admin; }
                if (donor != null) { Fd = donor; }

                Da.PopulateGridView("SELECT org_id, name, category, bank_details FROM Organizations", "organizations", dgvOrgSplit);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                if (Fa != null) { Fa.LoadControl(new ucDonations()); }
                else if (Fd != null) { Fd.LoadControl(new ucDonations()); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // This runs when the Auto Split checkbox is checked or unchecked
        private void cbAutoSplit_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                // If they turn it off, just stop.
                if (cbAutoSplit.Checked == false) return;

                // 1. Find all the rows that are actually checked
                List<DataGridViewRow> selectedRows = new List<DataGridViewRow>();

                foreach (DataGridViewRow row in dgvOrgSplit.Rows)
                {
                    // Clear the percentage immediately while we are looking at the row
                    row.Cells["Percentage"].Value = "";

                    bool isSelected = Convert.ToBoolean(row.Cells["Select"].Value);
                    if (isSelected == true)
                    {
                        selectedRows.Add(row);
                    }
                }

                // 2. Check if we have enough to split
                if (selectedRows.Count == 0)
                {
                    MessageBox.Show("Select some rows first!");
                    cbAutoSplit.Checked = false;
                    return;
                }

                // 3. Do the simple math
                // Using '100m' tells C# this is a Decimal (money), not a whole number.
                decimal share = 100m / selectedRows.Count;

                // 4. Put that number into every checked row
                foreach (DataGridViewRow row in selectedRows)
                {
                    row.Cells["Percentage"].Value = share;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // This runs when the Donate button is clicked
        private void btnDonate_Click(object sender, EventArgs e)
        {
            try
            {
                // Simple lists to store data we find in the grid
                List<int> idList = new List<int>();
                List<decimal> percentList = new List<decimal>();

                foreach (DataGridViewRow currentRow in dgvOrgSplit.Rows)
                {
                    // Just convert whatever is in the 'Select' box to a true/false
                    bool isChecked = Convert.ToBoolean(currentRow.Cells["Select"].Value);

                    // If it's not checked, skip this row and move to the next one immediately
                    if (isChecked == false) continue;

                    object cellValue = currentRow.Cells["Percentage"].Value;

                    // Check for empty or null
                    if (cellValue == null || cellValue.ToString() == "")
                    {
                        MessageBox.Show("Fill in all percentages!");
                        return;
                    }

                    // Convert to decimal. If it's ugly or has letters, this will jump to 'catch'
                    decimal myPercent = Convert.ToDecimal(cellValue);

                    if (myPercent <= 0)
                    {
                        MessageBox.Show("Percent must be positive!");
                        return;
                    }

                    // Save the ID and the Percent for later
                    int myId = Convert.ToInt32(currentRow.Cells["org_id"].Value);
                    idList.Add(myId);
                    percentList.Add(myPercent);
                }

                if (idList.Count == 0)
                {
                    MessageBox.Show("Pick at least one organization.");
                    return;
                }

                if (cbAutoSplit.Checked == false)
                {
                    decimal sum = 0;
                    foreach (decimal p in percentList)
                    {
                        sum = sum + p;
                    }

                    if (sum != 100)
                    {
                        MessageBox.Show("Total is " + sum + "%, but it needs to be 100%.");
                        return;
                    }
                }

                for (int i = 0; i < idList.Count; i++)
                {
                    // Basic math: Amount times the percentage (divided by 100)
                    decimal money = Amount * (percentList[i] / 100);
                    decimal roundedMoney = Math.Round(money, 2);

                    // Building the SQL string manually
                    string sql = "INSERT INTO DONATION_SPLITS (donation_id, org_id, amount, percentage) VALUES ("
                               + DonationId + ", "
                               + idList[i] + ", "
                               + roundedMoney + ", "
                               + percentList[i] + ")";

                    Da.ExecuteQuery(sql);
                }

                string sqlReceipt = "INSERT INTO RECEIPTS (donation_id, transaction_id, issued_at) VALUES ("
                                  + DonationId + ", '" + trnxID + "', GETDATE()); "
                                  + "SELECT SCOPE_IDENTITY();";

                // Get the new ID from the database
                object result = Da.ExecuteScalar(sqlReceipt);
                int newReceiptId = Convert.ToInt32(result);

                MessageBox.Show("All done! Saving receipt...");

                // Open the next screen
                FormReciept nextForm = new FormReciept(DonationId, Amount, newReceiptId, trnxID);
                this.Hide();
                nextForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvOrgSplit_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
        }

        private void dgvOrgSplit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvOrgSplit_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}