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
        private FormLoginReg prevForm;
        private string name;

        public ucUsers(string username, FormLoginReg Form1)
        {
            InitializeComponent();

            Da = new DataAccess();

            this.prevForm = Form1;
            this.name = username;

            Da.PopulateGridView("select * from users", "users", dgvInfo);

        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {

        }

        private void ucUsers_Load(object sender, EventArgs e)
        {
            try
            {
                string query = $"SELECT * FROM users WHERE Username = '{name}'";
                DataTable dt = Da.ExecuteQueryTable(query);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    txtID.Text = row["user_id"].ToString();
                    txtContact.Text = row["contact_no"].ToString();
                    txtUserName.Text = row["Username"].ToString();
                    txtPassword.Text = row["password"].ToString();
                    cbUserRole.SelectedItem = row["role"].ToString();
                }
                else
                {
                    MessageBox.Show("No profile data found.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading user data: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
