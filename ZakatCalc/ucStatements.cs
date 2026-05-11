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
    public partial class ucStatements : UserControl
    {
        private DataAccess da;
        public ucStatements()
        {
            InitializeComponent();
            da = new DataAccess();
        }

        private void ucStatements_Load(object sender, EventArgs e)
        {
            LoadAllReports();
        }

        private void LoadAllReports()
        {
            try
            {
                // 1. TOP SUMMARY CARDS
                // Using ISNULL to ensure we don't return DBNull to the Convert.ToInt32 in DataAccess
                lblDonations.Text = da.ExecuteScalar("SELECT ISNULL(SUM(total_amount), 0) FROM DONATIONS").ToString("C0");
                lblDonors.Text = da.ExecuteScalar("SELECT COUNT(DISTINCT user_id) FROM DONATIONS").ToString();
                lblTransactions.Text = da.ExecuteScalar("SELECT COUNT(donation_id) FROM DONATIONS").ToString();
                lblOrganizations.Text = da.ExecuteScalar("SELECT COUNT(org_id) FROM ORGANIZATIONS WHERE is_active = 1").ToString();

                // 2. BREAKDOWN BY ORGANIZATIONS (dgvOrg)
                // Joins DONATION_SPLITS with ORGANIZATIONS to get totals per org
                string orgSql = @"SELECT o.name AS [Organization], o.category AS [Category], 
                                  SUM(ds.amount) AS [Total Received], COUNT(ds.donation_id) AS [Donations]
                                  FROM ORGANIZATIONS o
                                  LEFT JOIN DONATION_SPLITS ds ON o.org_id = ds.org_id
                                  GROUP BY o.name, o.category
                                  ORDER BY [Total Received] DESC";
                dgvOrg.DataSource = da.ExecuteQueryTable(orgSql);

                // 3. BREAKDOWN BY TIME PERIOD (dgvTime)
                // Aggregates donations by month and year
                string timeSql = @"SELECT FORMAT(donated_at, 'MMMM yyyy') AS [Period], 
                                   COUNT(donation_id) AS [Transactions], 
                                   SUM(total_amount) AS [Total Collected]
                                   FROM DONATIONS
                                   GROUP BY FORMAT(donated_at, 'MMMM yyyy'), YEAR(donated_at), MONTH(donated_at)
                                   ORDER BY YEAR(donated_at) DESC, MONTH(donated_at) DESC";
                dgvTime.DataSource = da.ExecuteQueryTable(timeSql);

                // 4. ALL DONATIONS TABLE (dgvDonation)
                // Complex join to show donor name and the list of organizations involved in the split
                string allDonationsSql = @"SELECT u.username AS [Donor], d.donated_at AS [Date], 
                                           d.total_amount AS [Amount], d.payment_method AS [Method],
                                           (SELECT STRING_AGG(o.name, ', ') 
                                            FROM DONATION_SPLITS ds 
                                            JOIN ORGANIZATIONS o ON ds.org_id = o.org_id 
                                            WHERE ds.donation_id = d.donation_id) AS [Organizations]
                                           FROM DONATIONS d
                                           JOIN USERS u ON d.user_id = u.user_id
                                           ORDER BY d.donated_at DESC";
                dgvDonation.DataSource = da.ExecuteQueryTable(allDonationsSql);

                // Cleanup formatting for all grids
                ApplyGridStyling(dgvOrg);
                ApplyGridStyling(dgvTime);
                ApplyGridStyling(dgvDonation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reporting data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyGridStyling(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.RowHeadersVisible = false;
        }
    }
}
