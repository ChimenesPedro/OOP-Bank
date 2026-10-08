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
    public partial class DefaultForm : Form
    {
        public DefaultForm()
        {
            InitializeComponent();
        }

        private void DefaultForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void LoadForm(Form form)
        {
            panel1.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panel1.Controls.Add(form);
            form.Show();
        }

        private void newAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new NewAccount());
            this.Size = new Size(816, 489);
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            LoadForm(new Login());
            this.Size = new Size(816, 489);
            // faz o account sumir la de cima se alguem clicar em loginstrip
            accountToolStripMenuItem.Visible = false;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // faz o load do editform quando alguem clica no edit la em cima
            LoadForm(new EditForm());
            // muda o tamanho da janela pra ficar maior ja que tem o dashboard do outro lado
            this.Size = new Size(1224, 700);
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            LoadForm(new DashboardForm());
            this.Size = new Size(816, 489);
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new Deposit());
            this.Size = new Size(1279, 642);
        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new Transfer());
            this.Size = new Size(963, 470);
        }

        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new Withdraw());
            this.Size = new Size(1287, 599);
        }

        private void viewTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new Transactions());
            this.Size = new Size(1257, 489);
        }
    }
}
