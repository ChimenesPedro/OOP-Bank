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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CA_TWO_OOP.Forms
{
    public partial class Deposit : Form
    {
        QueriesClass q = new QueriesClass();
        public Deposit()
        {
            InitializeComponent();
            Ddgvdeposit.DataSource = q.ShowAccounts();
            DBALANCEBOX.Enabled = false;
            DACCOUNTBOX.Enabled = false;
        }

        private void Deposit_Load(object sender, EventArgs e)
        {

        }

        private void Ddgvdeposit_SelectionChanged(object sender, EventArgs e)
        {
            if (Ddgvdeposit.SelectedRows.Count > 0)
            {

                DataGridViewRow row = Ddgvdeposit.SelectedRows[0];

                DBalance.Text = row.Cells["Balance"].Value.ToString();
                DAccountNumber.Text = row.Cells["AccountNumber"].Value.ToString();



            }
        }

        private void EInitialBalance_Enter(object sender, EventArgs e)
        {

        }

        // quando clica no botao
        public void DConfirm_Click(object sender, EventArgs e)
        {
            
            if (!decimal.TryParse(DDeposit.Text, out decimal deposit) || deposit <= 0)
            {
                DErrorLabel.Text = "Enter a valid deposit amount";
                return;
            }

            // se nao tiver nenhuma row no banco de dados aparece isso
            if (Ddgvdeposit.SelectedRows.Count == 0)
            {
                DErrorLabel.Text = "No account selected";
                return;
            }

            // converte tudo que esta na caixa de balance pra decimal e armazena em balance
            decimal balance = decimal.Parse(DBalance.Text);
            // soma simples
            decimal newbalance = balance + deposit;

            // armazena o accountid em accountid
            int accountId = Convert.ToInt32(Ddgvdeposit.SelectedRows[0].Cells["AccountID"].Value);

            // chama o metodo que faz update em queriesclass
            q.UpdateBalance(accountId, newbalance);

            // faz o grid atualizar chamando outro metodo de queriesclass
            Ddgvdeposit.DataSource = q.ShowAccounts();

            // atualiza o textbox com o novo valor
            DBalance.Text = newbalance.ToString();
            // o textbox do newbalance volta a ser como antes
            DNewBalance.Text = "";

            DDeposit.Text = "";

            // mostra uma mensagem dizendo que ta tranquilo e deu certo
            MessageBox.Show("Deposit successful!");


        }

        // essa merda aq serve pra quando o texto na textbox de deposit mudar
        private void DDeposit_TextChanged(object sender, EventArgs e)
        {
            
            if (!decimal.TryParse(DDeposit.Text, out decimal deposit))
            {
                DNewBalance.Text = "";
                return;
            }

            if (!decimal.TryParse(DBalance.Text, out decimal balance))
            {
                DNewBalance.Text = "";
                return;
            }

            if (deposit < 0)
            {
                DErrorLabel.Text = "Cannot deposit negative amount";
                return;
            }

            decimal newbalance = balance + deposit;
            DNewBalance.Text = newbalance.ToString();
        }

        private void Ddgvdeposit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
