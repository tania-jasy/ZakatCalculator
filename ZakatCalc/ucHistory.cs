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
    public partial class ucHistory : UserControl
    {
        private DataAccess da;
        private int userID;
        public ucHistory(int userID)
        {
            InitializeComponent();
            da = new DataAccess();
            this.userID = userID;
        }

        private void ucHistory_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Get Total Given (Sum of total_amount for this user)
                string totalSql = $"SELECT ISNULL(SUM(total_amount), 0) FROM DONATIONS WHERE user_id = {userID}";
                lblTotal.Text = da.ExecuteScalar(totalSql).ToString("C0");

                // 2. Get Donation Count
                string countSql = $"SELECT COUNT(donation_id) FROM DONATIONS WHERE user_id = {userID}";
                lblDonationCount.Text = da.ExecuteScalar(countSql).ToString();

                // 3. Populate GridView with Detailed History
                // We use STRING_AGG to list all organizations for a specific donation on one line
                string historySql = $@"
                    SELECT 
                        d.donated_at AS [Date], 
                        d.total_amount AS [Amount], 
                        d.payment_method AS [Method], 
                        d.transaction_ref AS [Reference],
                        (SELECT STRING_AGG(o.name, ', ') 
                         FROM DONATION_SPLITS ds 
                         JOIN ORGANIZATIONS o ON ds.org_id = o.org_id 
                         WHERE ds.donation_id = d.donation_id) AS [Allocated To]
                    FROM DONATIONS d
                    WHERE d.user_id = {userID}
                    ORDER BY d.donated_at DESC";

                dgvHistory.DataSource = da.ExecuteQueryTable(historySql);

                // Styling
                dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvHistory.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load history: " + ex.Message);
            }
        }
    }
    
}
