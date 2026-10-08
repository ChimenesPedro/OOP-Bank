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
    public partial class NewAccount : Form
    {
        public NewAccount()
        {
            InitializeComponent();
            countycbo.DataSource = Enum.GetValues(typeof(County));
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void NSavingsRadio_CheckedChanged(object sender, EventArgs e)
        {

            if (NSavingsRadio.Checked == true) 
            {
                NOverdraftLimit.Clear();
                OverdraftBox.Enabled = false;
                
            }
            else
            {
                OverdraftBox.Enabled = true;
            }
        }

        private void NCurrentRadio_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            string fn = NFirstName.Text;
            string sn = NSurname.Text;
            string em = NEmail.Text;
            string ph = NPhone.Text;
            string add1 = NAddress1.Text;
            string add2 = NAddress2.Text;
            string ct = NCity.Text;
            string cy = countycbo.SelectedItem.ToString();
            string at = "C";
            if (NSavingsRadio.Checked)
            {
                 at = "S";
                NOverdraftLimit.Text = "0";
            }

            int an = int.Parse(NAccountNumber.Text);
            int sc = int.Parse(NSortCode.Text);
            decimal ib = decimal.Parse(NInitialBalance.Text);
            decimal ol = decimal.Parse(NOverdraftLimit.Text);


            Account a = new Account(fn, sn, em, ph, add1, add2, ct, cy, at, an, sc, ib, ol);

            a.AddAccount();

            NFirstName.Clear();
            NSurname.Clear();
            NEmail.Clear();
            NPhone.Clear();
            NAddress1.Clear();
            NAddress2.Clear();
            NCity.Clear();
            NCurrentRadio.Checked = false;
            NSavingsRadio.Checked = false;
            NAccountNumber.Clear();
            NSortCode.Clear();
            NInitialBalance.Clear();
            NOverdraftLimit.Clear();
        }
    }
}
