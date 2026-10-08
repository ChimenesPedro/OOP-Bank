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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            DefaultForm main = (DefaultForm)Application.OpenForms["DefaultForm"];
            main.LoadForm(new Login());
        }

        private void usernametxbreg_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            string username = usernametxbreg.Text;
            string password = passwordtxbreg.Text;

            User u1 = new User(username, password);
            bool registered = u1.AddUser();
            if (registered)
            {
                userregistered.Text = "User registered successfully!";
            }
            else
            {
                userregistered.Text = "Username already exists. Choose another one.";
            }
        }
    }
}
