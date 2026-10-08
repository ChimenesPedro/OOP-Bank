using CA_TWO_OOP.Classes;
using CA_TWO_OOP.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA_TWO_OOP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void passwordtxb_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string username = usernametxb.Text;
            string password = passwordtxb.Text;

            if (User.Login(username, password))
            {
                DefaultForm main = (DefaultForm)Application.OpenForms["DefaultForm"];
                main.LoadForm(new DashboardForm());


            }
            else
            {
                wronglabel.Text = "Wrong username or password!";
            }
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            DefaultForm main = (DefaultForm)Application.OpenForms["DefaultForm"];
            main.LoadForm(new SignUp());

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
