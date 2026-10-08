using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_TWO_OOP.Classes
{
    internal class QueriesClass
    {

        SqlConnection con = new SqlConnection(@"Server=(local)\SQLEXPRESS;
                                                Database=Bank;
                                                Trusted_Connection=True;");

        SqlDataAdapter da;

        DataTable dt;

        public DataTable ShowAccounts()
        {
            DataTable dt = new DataTable();

            using (SqlCommand cmd = new SqlCommand("ShowAllAccounts", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    con.Open();
                    da.Fill(dt);
                    con.Close();
                }
            }

            return dt;
        }

        public void UpdateBalance(int accountId, decimal amount)
        {
            using (SqlConnection conn = new SqlConnection(@"Server=(local)\SQLEXPRESS;
                                                    Database=Bank;
                                                    Trusted_Connection=True;"))
            {
                SqlCommand cmd = new SqlCommand("UpdateBalance", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AccountID", accountId);
                cmd.Parameters.AddWithValue("@Amount", amount);  // was @NewBalance

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void Withdraw(int accountId, decimal amount)
        {
            using (SqlConnection conn = new SqlConnection(@"Server=(local)\SQLEXPRESS;
                                                            Database=Bank;
                                                            Trusted_Connection=True;"))
            {
                SqlCommand cmd = new SqlCommand("WithdrawMoney", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AccountID", accountId);
                cmd.Parameters.AddWithValue("@Amount", amount);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public static void TransferFunds(int sourceAccountID, int destAccountNumber, int destSortCode, decimal amount)
        {
            using (SqlConnection con = new SqlConnection(@"Server=(local)\SQLEXPRESS;Database=Bank;Trusted_Connection=True;"))
            {
                using (SqlCommand cmd = new SqlCommand("TransferFunds", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@SourceAccountID", sourceAccountID);
                    cmd.Parameters.AddWithValue("@DestAccountNumber", destAccountNumber);
                    cmd.Parameters.AddWithValue("@DestSortCode", destSortCode);
                    cmd.Parameters.AddWithValue("@Amount", amount);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
            }
        }
        public DataTable GetTransactions(int accountId)
        {
            using (SqlConnection con = new SqlConnection(@"Server=(local)\SQLEXPRESS;Database=Bank;Trusted_Connection=True;"))
            {
                using (SqlCommand cmd = new SqlCommand("GetTransactionsByAccount", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@AccountID", accountId);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    return dt;
                }
            }
        }
    }

}
