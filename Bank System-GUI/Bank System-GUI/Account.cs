using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Bank_System_GUI
{
    abstract class Account
    {
        private double Balance;

        private string Account_ID;
       
        public Account(double b, string ID)//constructor 
        {
            Balance = b;
            Account_ID = ID;

        }

        public string get_ID()//Get the account ID
        {
            return Account_ID;
        }
        public double get_Balance()//Get the account Balance
        {
            return Balance;
        }
        public void set_Balance(double Balance)//set the account balance
        {
            this.Balance = Balance;
        }
        public double Balance_enquiry()//enquire for the balance
        {
            return Balance;
        }
        public void Deposit(double Entery)//adding to the balance 
        {
            Balance += Entery;
        }
        public bool Withdraw(double Entery)//withdrawing form the balance
        {
            if (Entery > Balance)
            {
                return false;
            }
            else
            {
                Balance -= Entery;
                return true;
            }
        }
        public void update_balance()//update the balance in the database
        {

            SqlConnection condatabase = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sherif\Documents\Test.mdf;Integrated Security=True;Connect Timeout=30");
            condatabase.Open();
            SqlCommand cmd = condatabase.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Account set Balance='" + get_Balance() + "' where AccountID='" + get_ID() + "' ";

            cmd.ExecuteNonQuery();

            condatabase.Close();
        }


    }//class
}//naespace
