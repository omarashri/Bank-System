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
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }



        private void linkForget_Click(object sender, EventArgs e)
        {

            ForgotPassForm obj = new ForgotPassForm();
            obj.Show();
            this.Hide();
        }


       
        private void btnLogin_Click(object sender, EventArgs e)
        {

          

          

            SqlConnection condatabase = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sherif\Documents\Test.mdf;Integrated Security=True;Connect Timeout=30");

            SqlDataReader reader = null;


            condatabase.Open();

            SqlCommand cmd = condatabase.CreateCommand();
            cmd.CommandText = "select * from Customer";
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (txtID.Text == reader.GetString(0) && txtPass.Text == reader.GetString(3))
                {
                    Program.logged_in.ID = reader.GetString(0);


                    Program.logged_in.First_Name = reader.GetString(1);

                    Program.logged_in.Last_Name = reader.GetString(2);

                    Program.logged_in.Password = reader.GetString(3);





                    SqlConnection condatabase2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sherif\Documents\Test.mdf;Integrated Security=True;Connect Timeout=30");

                    SqlDataReader reader2 = null;


                    condatabase2.Open();


                    SqlCommand cmd2 = condatabase2.CreateCommand();
                    cmd2.CommandText = "select * from Account";
                    reader2 = cmd2.ExecuteReader();

                    while (reader2.Read())
                    {
                        if (reader2.GetString(0) == Program.logged_in.ID)
                        {
                            if (reader2.GetString(2) == "Saving")
                            {
                                SavingAccount sa = new SavingAccount(reader2.GetDouble(3), reader2.GetString(1));
                                sa.Set_LastCheched_Date(reader2.GetDateTime(6));

                                Program.logged_in.sv.Add(sa);

                            }
                            else if (reader2.GetString(2) == "Checking")
                            {
                                CheckingAccount ca = new CheckingAccount(reader2.GetDouble(3), reader2.GetString(1), reader2.GetDouble(5));
                                Program.logged_in.Check.Add(ca);
                            }
                            else if (reader2.GetString(2) == "Loan")
                            {
                                Loan La = new Loan(reader2.GetDouble(3), reader2.GetString(1), reader2.GetDouble(4));
                                Program.logged_in.Looan.Add(La);
                            }

                        }
                    }


                    condatabase2.Close();
                    condatabase.Close();


                    AccountsMenu am = new AccountsMenu();
                    am.Show();
                    this.Hide();
                    return;

                }
            }
            timer1.Start();
            pictureBox3.Visible = true;

        }

        private void linkAdmin_Click(object sender, EventArgs e)
        {
            AdminLoginForm obj = new AdminLoginForm();
            obj.Show();
            this.Hide();
        }


        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            pictureBox3.Visible = false;
            timer1.Stop();
            MetroFramework.MetroMessageBox.Show(LoginForm.ActiveForm, "Wrong userID or password!");
        }
    }
}