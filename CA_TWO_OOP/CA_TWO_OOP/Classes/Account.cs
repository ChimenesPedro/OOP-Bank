using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_TWO_OOP.Classes
{
    public class Account
    {
        public int AccountID { get; set; }
        public string First_Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address_Line1 { get; set; }
        public string Address_Line2 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string AccountType { get; set; }
        public int AccountNumber { get; set; }
        public int SortCode { get; set; }
        public decimal InitialBalance { get; set; }
        public decimal OverdraftLimit { get; set; }

        public Account(string fn, string sn, string em, string ph, string add1, string add2, string ct, string cy, string at, int an, int sc, decimal ib, decimal ol )
        {
            First_Name = fn;
            Surname = sn;
            Email = em;
            Phone = ph;
            Address_Line1 = add1;
            Address_Line2 = add2;
            City = ct;
            County = cy;
            AccountType = at;
            AccountNumber = an;
            SortCode = sc;
            InitialBalance = ib;
            OverdraftLimit = ol;

        }

        
        public void AddAccount()
        {
            SqlConnection con = new SqlConnection(@"Server=(local)\SQLEXPRESS;
            Database=Bank;
            Trusted_Connection=True;");

            string insert = "INSERT INTO Account(FirstName, Surname, Email, Phone, AddressLine1, AddressLine2, City, County, AccountType, AccountNumber, SortCode, Balance, OverdraftLimit) VALUES(@fn, @sn, @em, @ph, @add1, @add2, @ct, @cy, @at, @an, @sc, @ib, @ol)";
        
            SqlCommand cmd = new SqlCommand(insert, con);

            cmd.Parameters.AddWithValue("@fn", First_Name);
            cmd.Parameters.AddWithValue("@sn", Surname);
            cmd.Parameters.AddWithValue("@em", Email);
            cmd.Parameters.AddWithValue("@ph", Phone);
            cmd.Parameters.AddWithValue("@add1", Address_Line1);
            cmd.Parameters.AddWithValue("@add2", Address_Line2);
            cmd.Parameters.AddWithValue("@ct", City);
            cmd.Parameters.AddWithValue("@cy", County);
            cmd.Parameters.AddWithValue("@at", AccountType);
            cmd.Parameters.AddWithValue("@an", AccountNumber);
            cmd.Parameters.AddWithValue("@sc", SortCode);
            cmd.Parameters.AddWithValue("@ib", InitialBalance);
            cmd.Parameters.AddWithValue("@ol", OverdraftLimit);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


        }

        public void EditAccount()
        {
            SqlConnection con = new SqlConnection(@"Server=(local)\SQLEXPRESS;
            Database=Bank;
            Trusted_Connection=True;");

            string edit = "UPDATE Account SET Email = @em, Phone = @ph, AddressLine1 = @add1, AddressLine2 = @add2, City = @ct, County = @cy, OverdraftLimit = @ol WHERE AccountID = @AccountID";

            SqlCommand cmd = new SqlCommand(edit, con);


            cmd.Parameters.AddWithValue("@em", Email);
            cmd.Parameters.AddWithValue("@ph", Phone);
            cmd.Parameters.AddWithValue("@add1", Address_Line1);
            cmd.Parameters.AddWithValue("@add2", Address_Line2);
            cmd.Parameters.AddWithValue("@ct", City);
            cmd.Parameters.AddWithValue("@cy", County);
            cmd.Parameters.AddWithValue("@ol", OverdraftLimit);
            cmd.Parameters.AddWithValue("@AccountID", AccountID);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


        }
    }
}
