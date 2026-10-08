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
    public partial class EditForm : Form
    {
        QueriesClass q = new QueriesClass();
        public EditForm()
        {
            InitializeComponent();
            Ecountycbo.DataSource = Enum.GetValues(typeof(County));
            DefaultForm main = (DefaultForm)Application.OpenForms["DefaultForm"];
            main.accountToolStripMenuItem.Visible = true;
            Edgvdashboard.DataSource = q.ShowAccounts();
            //• First Name 
            EFNBOX.Enabled = false;
            //• Surname
            ESBOX.Enabled = false;
            //• Initial Balance 
            EBALANCEBOX.Enabled = false;
            //• Account Type 
            EAccountTypeBox.Enabled = false;
            //• Account number 
            EACCNUMBOX.Enabled = false;
            //• Sort Code
            ESORTBOX.Enabled = false;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {

        }

        private void Edgvdashboard_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void Edgvdashboard_SelectionChanged(object sender, EventArgs e)
        {

            if (Edgvdashboard.SelectedRows.Count > 0)
            {
                
                DataGridViewRow row = Edgvdashboard.SelectedRows[0];

                EFirstName.Text = row.Cells["FirstName"].Value.ToString();
                ESurname.Text = row.Cells["Surname"].Value.ToString();
                EEmail.Text = row.Cells["Email"].Value.ToString();
                EPhone.Text = row.Cells["Phone"].Value.ToString();
                ECity.Text = row.Cells["City"].Value.ToString();
                Ecountycbo.Text = row.Cells["County"].Value.ToString();
                EAddress1.Text = row.Cells["AddressLine1"].Value.ToString();
                EAddress2.Text = row.Cells["AddressLine2"].Value.ToString();
                EAccountNumber.Text = row.Cells["AccountNumber"].Value.ToString();
                ESortCode.Text = row.Cells["SortCode"].Value.ToString();
                EInitialBalance.Text = row.Cells["Balance"].Value.ToString();
                EOverdraftLimit.Text = row.Cells["OverdraftLimit"].Value.ToString();

                // Account Type (Radio Buttons)
                string type = row.Cells["AccountType"].Value.ToString();
                
                if (type == "C")
                    ECurrentRadio.Checked = true;

                else
                    ESavingsRadio.Checked = true;
                    
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            // converte o valor da primeira celula e armazena em AccountID
            int accountId = Convert.ToInt32(Edgvdashboard.SelectedRows[0].Cells["AccountID"].Value);

            string fn = EFirstName.Text;
            string sur = ESurname.Text;
            string email = EEmail.Text;
            string phone = EPhone.Text;
            string ct = ECity.Text;
            string cy = Ecountycbo.SelectedItem?.ToString() ?? "";
            string add1 = EAddress1.Text;
            string add2 = EAddress2.Text;
            int an = int.Parse(EAccountNumber.Text);
            int sc = int.Parse(ESortCode.Text);
            decimal ib = decimal.Parse(EInitialBalance.Text);
            decimal ol = decimal.Parse(EOverdraftLimit.Text);
            string at = "C";
            if (ESavingsRadio.Checked)
            {
                at = "S";
                EOverdraftLimit.Text = "0";
            }
            Account acc = new Account(fn, sur, email, phone, add1, add2, ct, cy, at, an, sc, ib, ol);

            acc.AccountID = accountId;

            acc.EditAccount();

            DefaultForm main = (DefaultForm)Application.OpenForms["DefaultForm"];
            main.LoadForm(new DashboardForm());
        }

        private void Edgvdashboard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
