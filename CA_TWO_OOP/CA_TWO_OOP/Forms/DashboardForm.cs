using CA_TWO_OOP.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA_TWO_OOP.Forms
{
    public partial class DashboardForm : Form
    {
        QueriesClass q = new QueriesClass();
        public DashboardForm()
        {
            InitializeComponent();
            DefaultForm main = (DefaultForm)Application.OpenForms["DefaultForm"];
            main.accountToolStripMenuItem.Visible = true;
            dgvdashboard.DataSource = q.ShowAccounts();

            
        }
        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvdashboard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
