using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ZakatCalc
{
    public partial class FormAdmin : Form
    {

        private FormLoginReg prevForm;
        private string name;
        private string userRole;
        private int userID;
        public FormAdmin()
        {
            InitializeComponent();
        }

        public FormAdmin(string username, FormLoginReg Form1, string userRole, int userID)
        {
            InitializeComponent();
            this.prevForm = Form1;
            this.name = username;
            this.userRole = userRole;
            this.userID = userID;


            LoadControl(new ucCalculator(userRole, userID));
        }
        public void LoadControl(UserControl control)
        {
            pnlHolder.Controls.Clear();
            control.Dock = DockStyle.Fill;
            pnlHolder.Controls.Add(control);
        }
        private void FormAdmin_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome\n " + name;
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            LoadControl(new ucCalculator(userRole, userID));
        }
        private void btnUsers_Click(object sender, EventArgs e)
        {
            LoadControl(new ucUsers());
        }
        private void btnOrgs_Click(object sender, EventArgs e)
        {
            LoadControl(new ucOrganizations());
        }
        private void btnStats_Click(object sender, EventArgs e)
        {
            LoadControl(new ucStatements());
        }
        private void FormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            prevForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnLog_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            prevForm.Show();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }


    }
}
