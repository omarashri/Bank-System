using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Bank_System_GUI
{
    class SavingAccount : Account
    {
        private double Interest_rate;

        private DateTime LastChecked_Date;
        
        public SavingAccount(double B, string ID) : base(B, ID) //send the parameters to the base class constructor
        {
            
            Interest_rate = 0.0; //set interest rate
        }

        public void Set_LastChecked_Date(int year, int month, int day) //set last checked date
        {
            LastChecked_Date = new DateTime(year, month, day);
        }

        public void Set_LastCheched_Date(DateTime dt)
        {
            LastChecked_Date = dt;
        }
        public DateTime Get_LastChecked_Date()//get last checked date
        {
            return LastChecked_Date;
        }



        public  void Calculate_Balance(int no)//calculate new balance after adding the interest rate
        {
           
            for(int i=0;i<no;i++)
            {
                double old_balance = get_Balance();
                double new_balance = 0;

                Interest_rate = 0.01 * (old_balance);

                new_balance = Interest_rate + old_balance;

                set_Balance(new_balance);

                update_balance();
            }
           
        }

        public void update_LastChecked()//update into database
        {

            SqlConnection condatabase = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sherif\Documents\Test.mdf;Integrated Security=True;Connect Timeout=30");
            condatabase.Open();
            SqlCommand cmd = condatabase.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Account set LastChecked='" + Get_LastChecked_Date() + "' where AccountID='" + get_ID() + "' ";

            cmd.ExecuteNonQuery();

            condatabase.Close();
        }
    }
}
