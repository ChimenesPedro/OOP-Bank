using CA_TWO_OOP.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA_TWO_OOP.Forms
{
    public partial class Withdraw : Form
    {
        QueriesClass q = new QueriesClass();
        public Withdraw()
        {
            InitializeComponent();
            Wdgwithdraw.DataSource = q.ShowAccounts();
            DBALANCEBOX.Enabled = false;
            DACCOUNTBOX.Enabled = false;
            WOverdraftBOX.Enabled = false;
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {

        }

        private void Wdgwithdraw_SelectionChanged(object sender, EventArgs e)
        {
            if (Wdgwithdraw.SelectedRows.Count > 0)
            {

                DataGridViewRow row = Wdgwithdraw.SelectedRows[0];

                WBalance.Text = row.Cells["Balance"].Value.ToString();
                WAccountNumber.Text = row.Cells["AccountNumber"].Value.ToString();
                WOverdraftLimit.Text = row.Cells["OverdraftLimit"].Value.ToString();
            }
        }

        private void WConfirm_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(WWithdraw.Text, out decimal withdraw) || withdraw <= 0)
            {
                WErrorLabel.Text = "Enter a valid withdrawal amount";
                return;
            }

            if (Wdgwithdraw.SelectedRows.Count == 0)
            {
                WErrorLabel.Text = "No account selected";
                return;
            }

            int accountId = Convert.ToInt32(
                Wdgwithdraw.SelectedRows[0].Cells["AccountID"].Value
            );

            try
            {
                // Call the stored procedure
                q.Withdraw(accountId, withdraw);

                // Refresh grid
                Wdgwithdraw.DataSource = q.ShowAccounts();

                WBalance.Text = (decimal.Parse(WBalance.Text) - withdraw).ToString();
                WWithdraw.Clear();
                WNewBalance.Text = "";
                WErrorLabel.Text = "";

                MessageBox.Show("Withdrawal successful!");
            }
            catch (SqlException ex)
            {
                WErrorLabel.Text = ex.Message; // e.g. "Insufficient funds including overdraft."
            }
        }
        private void WWithdraw_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(WWithdraw.Text, out decimal withdraw))
            {
                WNewBalance.Text = "";
                return;
            }

            if (!decimal.TryParse(WBalance.Text, out decimal balance))
            {
                WNewBalance.Text = "";
                return;
            }

            decimal newbalance = balance - withdraw;
            WNewBalance.Text = newbalance.ToString();
        }

        private void WWithdraw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && WWithdraw.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void Wdgwithdraw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
