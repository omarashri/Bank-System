using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bank_System_GUI
{
    public partial class CheckingMenu : MetroFramework.Forms.MetroForm
    {
        public CheckingMenu()
        {
            InitializeComponent();

        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sherif\Documents\Test.mdf;Integrated Security=True;Connect Timeout=30");

        private void btnDeposite_Click(object sender, EventArgs e)
        {
           
            PanelWithdraw.Visible = false;
            PanelDeposite.Visible = true;
          
        }

        private void CheckingMenu_Load(object sender, EventArgs e)
        {
            PanelDeposite.Visible = false;
            PanelWithdraw.Visible = false;
        }
        public void update_balance()//update the balance in the database
        {

            SqlConnection condatabase = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sherif\Documents\Test.mdf;Integrated Security=True;Connect Timeout=30");
            condatabase.Open();
            SqlCommand cmd = condatabase.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Account set Balance='" + Program.logged_in.Check[Program.logged_in.AccountIndex].get_Balance() + "' where AccountID='" + Program.logged_in.Check[Program.logged_in.AccountIndex].get_ID() + "' ";

            cmd.ExecuteNonQuery();

            condatabase.Close();
        }
        private void btnDepAmount_Click(object sender, EventArgs e)
        {
          //  CheckingAccount moza;
            SqlConnection condatabase = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sherif\Documents\test.mdf;Integrated Security=True;Connect Timeout=30");

            SqlDataReader reader = null;


            condatabase.Open();

            SqlCommand cmd = condatabase.CreateCommand();
            cmd.CommandText = "select * from Account";
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
            //    moza = new CheckingAccount(reader.GetDouble(3), reader.GetString(1), reader.GetDouble(5));


                double OverdraftFee;
                double Balance;
                Balance = Program.logged_in.Check[Program.logged_in.AccountIndex].get_Balance();
                OverdraftFee = Program.logged_in.Check[Program.logged_in.AccountIndex].Get_Overdraftfee();
                if (reader.GetString(1) == Program.logged_in.Check[Program.logged_in.AccountIndex].get_ID())
                {
                    if (OverdraftFee > 0)
                    {
                        double value = Convert.ToDouble(txtDeposite.Text);

                        if (OverdraftFee < value)
                        {
                            value -= OverdraftFee;
                            Balance = value;
                            Program.logged_in.Check[Program.logged_in.AccountIndex].balanceupgrade(Balance);
                            Program.logged_in.Check[Program.logged_in.AccountIndex].Overdraftupgrade(0);

                            MetroFramework.MetroMessageBox.Show(CheckingMenu.ActiveForm, "Your New Balance = " + Balance);
                            return;
                        }

                        else if (OverdraftFee == value)
                        {
                            Program.logged_in.Check[Program.logged_in.AccountIndex].balanceupgrade(0);
                            Program.logged_in.Check[Program.logged_in.AccountIndex].Overdraftupgrade(0);
                            MetroFramework.MetroMessageBox.Show(CheckingMenu.ActiveForm, "Your New Balance = " + Balance);
                            return;
                        }

                        else
                        {
                            OverdraftFee -= value;
                            Program.logged_in.Check[Program.logged_in.AccountIndex].balanceupgrade(Balance);
                            Program.logged_in.Check[Program.logged_in.AccountIndex].Overdraftupgrade(OverdraftFee);
                            MetroFramework.MetroMessageBox.Show(CheckingMenu.ActiveForm, "Your New Balance = " + Balance);
                            return;
                        }
                    }
                    else
                    {
                        double value = Convert.ToDouble(txtDeposite.Text);
                        Balance += value;
                        Program.logged_in.Check[Program.logged_in.AccountIndex].balanceupgrade(Balance);
                        MetroFramework.MetroMessageBox.Show(CheckingMenu.ActiveForm,"Your New Balance = " + Balance);
                        return;
                    }
                }
            }
            reader.Close();
            condatabase.Close();
        }

        private void btnWithdrawAmount_Click(object sender, EventArgs e)
        {
           // CheckingAccount moza;
            SqlConnection condatabase = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sherif\Documents\test.mdf;Integrated Security=True;Connect Timeout=30");

            SqlDataReader reader = null;


            condatabase.Open();

            SqlCommand cmd = condatabase.CreateCommand();
            cmd.CommandText = "select * from Account";
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
              //  moza = new CheckingAccount(reader.GetDouble(3), reader.GetString(1), reader.GetDouble(5));



                double OverdraftFee;
                double Balance;
                Balance = Program.logged_in.Check[Program.logged_in.AccountIndex].get_Balance();
                OverdraftFee = Program.logged_in.Check[Program.logged_in.AccountIndex].Get_Overdraftfee();

                if (reader.GetString(1) == Program.logged_in.Check[Program.logged_in.AccountIndex].get_ID())
                {

                    if (Balance >= Convert.ToDouble(txtWithdraw.Text))
                    {
                        double value = Convert.ToDouble(txtWithdraw.Text);
                        Balance -= value;
                        Program.logged_in.Check[Program.logged_in.AccountIndex].balanceupgrade(Balance);
                        MetroFramework.MetroMessageBox.Show(CheckingMenu.ActiveForm ,"Your New Balance = " + Program.logged_in.Check[Program.logged_in.AccountIndex].get_Balance().ToString());
                        return;
                    }

                    else
                    {

                        double value = Convert.ToDouble(txtWithdraw.Text);
                        Balance -= value;
                        OverdraftFee = Balance * -1;
                        OverdraftFee += Program.logged_in.Check[Program.logged_in.AccountIndex].Get_Overdraftfee();

                        if (OverdraftFee >= Program.logged_in.Check[Program.logged_in.AccountIndex].Get_Credit())
                        {
                            MetroFramework.MetroMessageBox.Show(CheckingMenu.ActiveForm,"Operation Failed");
                            return;
                        }
                        Program.logged_in.Check[Program.logged_in.AccountIndex].balanceupgrade(0);
                        Program.logged_in.Check[Program.logged_in.AccountIndex].Overdraftupgrade(OverdraftFee);

                        MetroFramework.MetroMessageBox.Show(CheckingMenu.ActiveForm, "Your New Balance = " + Balance);

                    }
                }
            }
            reader.Close();
            condatabase.Close();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            PanelDeposite.Visible = false;
     
            PanelWithdraw.Visible = true;

        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            PanelDeposite.Visible = false;
            PanelWithdraw.Visible = false;
            MetroFramework.MetroMessageBox.Show(CheckingMenu.ActiveForm, "Your balance is :" + Program.logged_in.Check[Program.logged_in.AccountIndex].get_Balance().ToString());
        }

        private void CheckingMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
