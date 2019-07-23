using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Bank_System_GUI
{
    class Loan:Account
    {
        private double Inerest_rate = 0.2;
        private double payment;
        private double montly_duration = 24;
        public Loan(double B, string ID, double Pay) : base(B, ID)
        {
            this.payment = Pay;
        }

        public double get_Pay()
        {
            return payment;
        }
        public void read_Pay()
        {
            SqlConnection condatabase = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sherif\Documents\Test.mdf;Integrated Security=True;Connect Timeout=30");

            SqlDataReader reader = null;


            condatabase.Open();


            SqlCommand cmd = condatabase.CreateCommand();
            cmd.CommandText = "select * from Account";
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (reader.GetString(1) == Program.logged_in.Looan[Program.logged_in.AccountIndex].get_ID())
                {
                    set_Pay(reader.GetDouble(4));
                }
            }
            condatabase.Close();
        }//read payment value from sql 
        public void set_Pay(double p)
        {
            payment = p;
        }

        public void Calculate_Balance()//calculate Balance after interest rate
        {
            double temp = 0;
            temp =get_Balance() * Inerest_rate;//Balance after interest rate
            double temp_Balance =get_Balance();
            temp_Balance += temp;
           
            set_Balance(temp_Balance);

            update_balance();
            
        }
       
        public double Calculate_Payment()
        {
            double Calc_payment = (get_Balance()) * (1 / montly_duration);
            return Calc_payment;

        }//calculate minmium required to pay
        public double Calculate_remains()
        {
            double remains =get_Balance() - get_Pay();
            return remains;
        }//calculate remains
        public bool delete_account()//bool -> to check if payment is equal blaance or not
        {
            read_Pay();
            if (get_Pay() >= get_Balance())
            {
                SqlConnection condatabase2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sherif\Documents\Test.mdf;Integrated Security=True;Connect Timeout=30");
                condatabase2.Open();
                SqlCommand cmd2 = condatabase2.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "delete from Account where AccountID = '" + Program.logged_in.Looan[Program.logged_in.AccountIndex].get_ID() + "'";
                cmd2.ExecuteNonQuery();
                condatabase2.Close();

                return true;
            }
            else
                return false;
        }
        public void update_payment(double temp)
        {
            //write in sql server in Account Table

            read_Pay();
            double p = get_Pay() + temp;


            SqlConnection condatabase2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sherif\Documents\Test.mdf;Integrated Security=True;Connect Timeout=30");
            condatabase2.Open();
            SqlCommand cmd2 = condatabase2.CreateCommand();
            cmd2.CommandText = "update Account set Payment ='" +p + "'where AccountID = '" + Program.logged_in.Looan[Program.logged_in.AccountIndex].get_ID() + "'";
            cmd2.ExecuteNonQuery();
            condatabase2.Close();
        }//update payment value in sql
    }
}
