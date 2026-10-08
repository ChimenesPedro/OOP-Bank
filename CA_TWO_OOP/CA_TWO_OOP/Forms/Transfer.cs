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
    public partial class Transfer : Form
    {
        QueriesClass q = new QueriesClass();
        public Transfer()
        {
            InitializeComponent();
            Tdgvtransfer.DataSource = q.ShowAccounts();
        }

        private void Transfer_Load(object sender, EventArgs e)
        {
            Tdgvtransfer.Columns["AccountID"].Visible = false;
            Tdgvtransfer.Columns["OverdraftLimit"].Visible = false;
            Tdgvtransfer.Columns["Email"].Visible = false;
            Tdgvtransfer.Columns["Phone"].Visible = false;
            Tdgvtransfer.Columns["AddressLine1"].Visible = false;
            Tdgvtransfer.Columns["AddressLine2"].Visible = false;
            Tdgvtransfer.Columns["City"].Visible = false;
            Tdgvtransfer.Columns["County"].Visible = false;
        }

        private void TConfirm_Click(object sender, EventArgs e)
        {
            
        }

        private void TConfirm_Click_1(object sender, EventArgs e)
        {
            if (Tdgvtransfer.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a source account");
                return;
            }

            int sourceId = Convert.ToInt32(Tdgvtransfer.SelectedRows[0].Cells["AccountID"].Value);

            if (!int.TryParse(TAccountNumber.Text, out int destAcc) ||
                !int.TryParse(TSortCode.Text, out int destSort) ||
                !decimal.TryParse(TAmount.Text, out decimal amount))
            {
                MessageBox.Show("Invalid input");
                return;
            }

            try
            {
                QueriesClass.TransferFunds(sourceId, destAcc, destSort, amount);

                MessageBox.Show("Transfer successful!");

                DefaultForm main = (DefaultForm)Application.OpenForms["DefaultForm"];
                main.LoadForm(new DashboardForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
