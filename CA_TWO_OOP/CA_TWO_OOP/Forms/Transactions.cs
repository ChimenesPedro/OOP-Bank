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
    public partial class Transactions : Form
    {
        QueriesClass q = new QueriesClass();
        public Transactions()
        {
            InitializeComponent();
            Trandgvselect.DataSource = q.ShowAccounts();
            Trandgvselect.Columns["AccountID"].Visible = false;
        }

        private void Transactions_Load(object sender, EventArgs e)
        {
            
        }

        private void Trandgvselect_SelectionChanged(object sender, EventArgs e)
        {
            if (Trandgvselect.SelectedRows.Count > 0)
            {
                int accountId = Convert.ToInt32(
                    Trandgvselect.SelectedRows[0].Cells["AccountID"].Value
                );

                DataTable dt = q.GetTransactions(accountId);
                Trandgvshow.DataSource = dt;

                FormatGrid();
            }
        }

        private void FormatGrid()
        {
            Trandgvshow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            Trandgvshow.Columns["Type"].HeaderText = "Transaction Type";
            Trandgvshow.Columns["Amount"].HeaderText = "Amount (€)";
            Trandgvshow.Columns["DateTime"].HeaderText = "Date";
            Trandgvshow.Columns["DestinationAccount"].HeaderText = "To / From";


            foreach (DataGridViewRow row in Trandgvshow.Rows)
            {
                if (row.Cells["Type"].Value != null)
                {
                    string type = row.Cells["Type"].Value.ToString();

                    if (type == "Deposit" || type == "Transfer In")
                        row.DefaultCellStyle.BackColor = Color.LightGreen;

                    if (type == "Withdraw" || type == "Transfer Out")
                        row.DefaultCellStyle.BackColor = Color.LightCoral;
                }
            }
        }

        private void Trandgvshow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
