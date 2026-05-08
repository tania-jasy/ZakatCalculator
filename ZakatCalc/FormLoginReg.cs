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
    public partial class FormLoginReg : Form
    {
        public FormLoginReg()
        {
            InitializeComponent();
        }

        public void LoadControl(UserControl control)
        {
            pnlRegLogin.Controls.Clear();
            control.Dock = DockStyle.Fill;
            pnlRegLogin.Controls.Add(control);
        }

        private void FormLoginReg_Load(object sender, EventArgs e)
        {
            LoadControl(new ucLogin());
        }

        private void cbReg_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbReg.Checked)
            {
                LoadControl(new ucLogin());
            }
            else
            {
                LoadControl(new ucRegistration());
            }
        }
    }
}
