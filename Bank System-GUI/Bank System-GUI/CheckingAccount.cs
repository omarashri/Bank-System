using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Bank_System_GUI
{
    class CheckingAccount :Account
    {
        double overdraft;
        double CreditLimit = 101;
        public CheckingAccount(double b, string ID, double Value) : base(b, ID)
        {
            overdraft = Value;
        }
     
        public void set_overdaraft(double x)
        {
            overdraft = x;
        }
        public double Get_Overdraftfee()
        {
            return overdraft;
        }
        public double Get_Credit()
        {
            return CreditLimit;
        }

        public void balanceupgrade(double balance)
        {
            SqlConnection condatabase = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sherif\Documents\Test.mdf;Integrated Security=True;Connect Timeout=30");
            condatabase.Open();
            SqlCommand cmd = condatabase.CreateCommand();
            cmd.CommandType = CommandType.Text;
            set_Balance(balance);
            
            cmd.CommandText = "update Account set Balance='" + balance + "' where AccountID='" + get_ID() + "' ";

            cmd.ExecuteNonQuery();

            condatabase.Close();
        }

        public void Overdraftupgrade(double Overdraft)
        {
            SqlConnection condatabase = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sherif\Documents\Test.mdf;Integrated Security=True;Connect Timeout=30");
            condatabase.Open();
            SqlCommand cmd = condatabase.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Account set OverDraft='" + Overdraft + "' where AccountID='" + get_ID() + "' ";

            cmd.ExecuteNonQuery();

            condatabase.Close();
        }
    }
}
