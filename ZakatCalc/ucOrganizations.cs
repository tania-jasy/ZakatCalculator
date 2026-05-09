using FormStart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZakatCalc
{
    public partial class ucOrganizations : UserControl
    {
        private DataAccess Da { get; set; }
        public ucOrganizations()
        {
            InitializeComponent();
            //datagridview is being filled up at the very starting of the page
            Da = new DataAccess();
            Da.PopulateGridView("select * from organizations", "organizations", dgvOrg);
        }
        private void ClearSelections()
        {
            txtID.Clear();
            txtName.Clear();
            txtContact.Clear();
            txtBank.Clear();
            cbCategory.SelectedIndex = -1;
            dgvOrg.ClearSelection();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearSelections();
        }
        private void dgvOrg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (dgvOrg.CurrentRow == null) return;

                txtID.Text = dgvOrg.CurrentRow.Cells["org_id"].Value.ToString();
                txtContact.Text = dgvOrg.CurrentRow.Cells["contact_phone"].Value.ToString();
                txtName.Text = dgvOrg.CurrentRow.Cells["name"].Value.ToString();
                cbCategory.SelectedItem = dgvOrg.CurrentRow.Cells["category"].Value.ToString();
                txtBank.Text = dgvOrg.CurrentRow.Cells["bank_details"].Value.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading user data: " + ex.Message);
            }
        }

        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(txtName.Text) ||
                cbCategory.SelectedItem == null ||
                String.IsNullOrEmpty(txtContact.Text) || String.IsNullOrEmpty(txtBank.Text))
            {
                return false;
            }
            return true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidToSave() == false)
            {
                MessageBox.Show("Please fill up all required fields");
                return;
            }

            // Check if the organization already exists based on ID
            string query = "select * from ORGANIZATIONS where org_id = '" + txtID.Text + "'";
            DataTable dt = Da.ExecuteQueryTable(query);

            if (dt.Rows.Count != 1)
            {
                // TO ADD: Note we skip org_id as it is IDENTITY (auto-increment)
                string sql = "INSERT INTO ORGANIZATIONS (name, category, contact_phone, bank_details, is_active, is_verified) " +
                             "VALUES('" + txtName.Text + "', '" + cbCategory.Text + "', '" + txtContact.Text + "', '" + txtBank.Text + "', 1, 0);";

                int count = this.Da.ExecuteQuery(sql);
                if (count == 1) MessageBox.Show("New organization added successfully");
                else MessageBox.Show("Failed to add organization");
            }
            else
            {
                // TO UPDATE: Update existing record based on org_id
                string sql = "UPDATE ORGANIZATIONS SET name = '" + txtName.Text + "', category = '" + cbCategory.Text + "', " +
                             "contact_phone = '" + txtContact.Text + "', bank_details = '" + txtBank.Text + "' " +
                             "WHERE org_id = '" + txtID.Text + "'";

                int count = this.Da.ExecuteQuery(sql);
                if (count == 1) MessageBox.Show("Organization information updated");
                else MessageBox.Show("Failed to update organization");
            }

            ClearSelections();
            Da.PopulateGridView("select * from ORGANIZATIONS", "ORGANIZATIONS", dgvOrg);
        }
       

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvOrg.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please select a row first");
                return;
            }

            string id = dgvOrg.CurrentRow.Cells["org_id"].Value.ToString();
            string name = dgvOrg.CurrentRow.Cells["name"].Value.ToString();

            var result = MessageBox.Show("Delete organization: " + name + "?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;

            string sql = "DELETE FROM ORGANIZATIONS WHERE org_id = '" + id + "'";
            int count = Da.ExecuteQuery(sql);

            if (count == 1) MessageBox.Show("Organization deleted");
            else MessageBox.Show("Deletion failed");

            Da.PopulateGridView("select * from ORGANIZATIONS", "ORGANIZATIONS", dgvOrg);
            ClearSelections();
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {            
            Da.PopulateGridView("select * from ORGANIZATIONS", "ORGANIZATIONS", dgvOrg);
            ClearSelections();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                Da.PopulateGridView("select * from ORGANIZATIONS", "ORGANIZATIONS", dgvOrg);
                return;
            }

            string sql;
            if (rbName.Checked)
                sql = "Select * from ORGANIZATIONS where name like '%" + txtSearch.Text + "%';";
            else if (rbCategory.Checked)
                sql = "Select * from ORGANIZATIONS where category like '%" + txtSearch.Text + "%';";
            else if (rbID.Checked)
                sql = "Select * from ORGANIZATIONS where org_id like '%" + txtSearch.Text + "%';";
            else
            {
                MessageBox.Show("Select a search category");
                return;
            }

            Da.PopulateGridView(sql, "ORGANIZATIONS", dgvOrg);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
