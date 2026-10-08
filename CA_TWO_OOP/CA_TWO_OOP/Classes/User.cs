using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_TWO_OOP.Classes
{
    public class User
    {
        public string Username {  get; set; }

        public string Password { get; set; }

        private static string connectionString = @"Server=(local)\SQLEXPRESS;
            Database=Bank;
            Trusted_Connection=True;";

        public User(string un, string pass)
        {
            Username = un;
            Password = pass;
        }
        public bool AddUser()
        {
            if (UsernameExists(Username))
            {
                return false;
            }
            else
            {
                SqlConnection con = new SqlConnection(connectionString);

                string insert = "INSERT INTO [User](Username, Password) VALUES(@un, @pass)";

                SqlCommand cmd = new SqlCommand(insert, con);

                cmd.Parameters.AddWithValue("@un", Username);
                cmd.Parameters.AddWithValue("@pass", Password);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            return true;

        }
        public static bool UsernameExists(string username)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM [User] WHERE Username = @un";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@un", username);

                con.Open();
                int count = (int)cmd.ExecuteScalar();

                return count > 0;
            }
        }
        public static bool Login(string username, string password)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT COUNT(*) FROM [User] WHERE Username = @un AND Password = @pass";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@un", username);
                cmd.Parameters.AddWithValue("@pass", password);

                con.Open();
                int result = (int)cmd.ExecuteScalar();

                return result > 0;
            }
        }
    }
}
