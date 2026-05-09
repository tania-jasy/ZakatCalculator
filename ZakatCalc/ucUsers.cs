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
    public partial class ucUsers : UserControl
    {
        private DataAccess Da { get; set; }

        public ucUsers()
        {
            InitializeComponent();

            Da = new DataAccess();

            //datagridview is being filled up at the very starting of the page
            Da.PopulateGridView("select * from users", "users", dgvInfo);

        }
        //calling a method to clear all fields, will need it later in save button
        private void ClearSelections()
        {
            txtID.Clear();
            txtUserName.Clear();
            txtContact.Clear();
            txtPassword.Clear();
            cbUserRole.SelectedIndex = -1;
            dgvInfo.ClearSelection();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearSelections();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (dgvInfo.CurrentRow == null) return;

                txtID.Text = dgvInfo.CurrentRow.Cells["user_id"].Value.ToString();
                txtContact.Text = dgvInfo.CurrentRow.Cells["contact_no"].Value.ToString();
                txtUserName.Text = dgvInfo.CurrentRow.Cells["Username"].Value.ToString();
                txtPassword.Text = dgvInfo.CurrentRow.Cells["password"].Value.ToString();
                cbUserRole.SelectedItem = dgvInfo.CurrentRow.Cells["role"].Value.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading user data: " + ex.Message);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            //will do two jobs for the same button - save; to both add and update
            //logic - the id section shall remain empty for new entries (will use clear button to do that)
            if (IsValidToSave() == false)
            {
                MessageBox.Show("fill up all the fields");
                return;
            }
            string query = "select * from USERS where user_id = '" + txtID.Text + "'";
            DataTable dt = Da.ExecuteQueryTable(query);
            //to add
            if (dt.Rows.Count != 1)
            {
                string sql = "INSERT INTO USERS (username, password, contact_no, role, is_active) VALUES('" +txtUserName.Text+"', '"+txtPassword.Text+"', '"+txtContact.Text+"', '"+cbUserRole.Text+"', 1);";
                
                int count = this.Da.ExecuteQuery(sql);
                if (count == 1)
                {
                    MessageBox.Show("New user has been added");
                }
                else
                {
                    MessageBox.Show("Failed to add user");
                }
            }
            //to update
            if (dt.Rows.Count == 1)
            {
                string sql = "UPDATE USERS SET username = '" +txtUserName.Text + "', password = '" +txtPassword.Text + "', contact_no = '"+txtContact.Text+"', role = '"+cbUserRole.Text+"' WHERE user_id = '" + txtID.Text + "'";
                int count = this.Da.ExecuteQuery(sql);
                if (count == 1)
                {
                    MessageBox.Show("User information has been updated");
                }
                else
                {
                    MessageBox.Show("Failed to update user information");
                }
            }

            ClearSelections();
            Da.PopulateGridView("select * from users", "users", dgvInfo);
        }
        private bool IsValidToSave()
        {   //id should be spared while adding (database will increment it for us)
            if (String.IsNullOrEmpty(txtUserName.Text) || String.IsNullOrEmpty(txtContact.Text) || String.IsNullOrEmpty(txtPassword.Text) || cbUserRole.SelectedItem == null)
            {
                return false;
            }
                return true;
        }
        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            Da.PopulateGridView("select * from users", "users", dgvInfo);
            dgvInfo.ClearSelection();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvInfo.SelectedRows.Count != 1)
            {
                MessageBox.Show("Select one row");
                return;
            }
            string name = dgvInfo.CurrentRow.Cells["username"].Value.ToString();

            var result = MessageBox.Show("Sure?\nUsername is - " + name + "", "Confirmation", MessageBoxButtons.YesNo);
            
            if (result == DialogResult.No) return;
            
            string sql = "Delete FROM USERS WHERE username = '" + name + "'";

            int count = Da.ExecuteQuery(sql);
           
            if (count == 1)
            {
                MessageBox.Show("row deleted");
            }
            else
            {
                MessageBox.Show("deletion failed");
            }

            Da.PopulateGridView("select * from users", "users", dgvInfo);
            ClearSelections();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == null)
            {
                MessageBox.Show("Enter a search term");
                return;
            }
            string sql;

            if (rbUsername.Checked)
            {
                sql = "Select * from users where username like '%" + txtSearch.Text + "%';";
            }
            else if (rbContact.Checked)
            {
                sql = "Select * from users where contact_no like '%" + txtSearch.Text + "%';";
            }
            else if (rbUserRole.Checked)
            {
                sql = "Select * from users where role like '%" + txtSearch.Text + "%';";
            }
            else
            {
                MessageBox.Show("Select one category");
                return;
            }

            Da.PopulateGridView(sql, "users", dgvInfo);
        }

        private void ucUsers_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
