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
    public partial class AdminMenu : MetroFramework.Forms.MetroForm
    {
        public AdminMenu()
        {
            InitializeComponent();
        }
        List<Customer> Customer_List = new List<Customer>();
        List<SavingAccount> Saving_list = new List<SavingAccount>();
        List<CheckingAccount> Checking_list = new List<CheckingAccount>();
        List<Loan> Loan_list = new List<Loan>();

        SqlConnection condatabase1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sherif\Documents\Test.mdf;Integrated Security=True;Connect Timeout=30");
        public void Get_cusData()//Get customer data from table
        {

            Customer obj = new Customer();

            SqlDataReader reader = null;
            condatabase1.Open();
            SqlCommand cmd1 = condatabase1.CreateCommand();
            cmd1.CommandText = "select * from Customer";
            reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                if (ID_txt.Text == reader.GetString(0))
                {
                    idtxt.Text = reader.GetString(0);
                    Fnametxt.Text = reader.GetString(1);
                    Lnametxt.Text = reader.GetString(2);
                    Passtxt.Text = reader.GetString(3);

                    SqlConnection condatabase2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sherif\Documents\Test.mdf;Integrated Security=True;Connect Timeout=30");
                    SqlDataReader reader2 = null;
                    condatabase2.Open();
                    SqlCommand cmd2 = condatabase2.CreateCommand();
                    cmd2.CommandText = "select * from Account";
                    reader2 = cmd2.ExecuteReader();
                    while (reader2.Read())
                    {
                        if (reader2.GetString(0) == ID_txt.Text)
                        {
                            if (reader2.GetString(2) == "Saving")
                            {
                                SavingAccount sa = new SavingAccount(reader2.GetDouble(3), reader2.GetString(1));

                                Saving_list.Add(sa);
                            }
                            else if (reader2.GetString(2) == "Checking")
                            {
                                CheckingAccount ca = new CheckingAccount(reader2.GetDouble(3), reader2.GetString(1), reader2.GetDouble(5));
                                Checking_list.Add(ca);
                            }
                            else if (reader2.GetString(2) == "Loan")
                            {
                                Loan La = new Loan(reader2.GetDouble(3), reader2.GetString(1), reader2.GetDouble(4));
                                Loan_list.Add(La);
                            }
                        }
                    }


                    condatabase2.Close();
                  //display data of customer in list view
                    for (int i = 0; i < Saving_list.Count; i++)
                    {
                        metroListView1.Items.Add("Account Type : "+"Saving Account");
                        metroListView1.Items.Add("ID : "+Saving_list[i].get_ID());
                        metroListView1.Items.Add("Balance : "+Convert.ToString(Saving_list[i].get_Balance()));
                        metroListView1.Items.Add("------------------");
                    }
                    for (int i = 0; i < Checking_list.Count; i++)
                    {
                        metroListView1.Items.Add("Account Type : "+"Checking");
                        metroListView1.Items.Add("ID : "+Checking_list[i].get_ID());
                        metroListView1.Items.Add("Balance : "+Convert.ToString(Checking_list[i].get_Balance()));
                        metroListView1.Items.Add("------------------");
                    }
                    for (int i = 0; i < Loan_list.Count; i++)
                    {
                        metroListView1.Items.Add("Account Type : "+"Loan Account");
                        metroListView1.Items.Add("ID : "+Loan_list[i].get_ID());
                        metroListView1.Items.Add("Balance : "+Convert.ToString(Loan_list[i].get_Balance()));
                        metroListView1.Items.Add("------------------");
                    }

                }
            }

            condatabase1.Close();

        }
        private void btnSearchID_Click(object sender, EventArgs e)
        {
            metroListView1.Clear();
            Get_cusData();//call function get customer data to display data
            Loan_list.Clear();
            Checking_list.Clear();
            Saving_list.Clear();
        }
     
        private void AdminMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DataSet1.DataTable1);

            pnlSearch.Visible = false;
            pnlAdd.Visible = false;
            pnlReport.Visible = false;

            /*-----------------------------------------------*/

            idtxt.Enabled = false;
            Fnametxt.Enabled = false;
            Lnametxt.Enabled = false;
            Passtxt.Enabled = false;

            /*-----------------------------------------------*/

            txtID.Enabled = false;
            txtBalance.Enabled = false;
            txtAccID.Enabled = false;
            comboAccType.SelectedIndex = 0;
            comboAccType.Enabled = false;

            /*-----------------------------------------------*/


            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtNewID.Enabled = false;
            txtNewPass.Enabled = false;
            txtNewPassAgain.Enabled = false;
            txtNewAccID.Enabled = false;
            txtNewBalance.Enabled = false;
            comboNewAccType.SelectedIndex = 0;
            comboNewAccType.Enabled = false;

            /*-----------------------------------------------*/

            lblPass.Visible = false;


            this.reportViewer1.RefreshReport();
        }

        private void metroListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = true;
            pnlSearch.Visible = false;
            pnlReport.Visible = false;


            radNewUser.Checked = false;
          
            radExistedUser.Checked = false;


            /*-----------------------------------------------*/

            txtID.Clear();
            txtBalance.Clear();
            txtAccID.Clear();
            comboAccType.SelectedIndex = 0;
      

            /*-----------------------------------------------*/


            txtFirstName.Clear();
            txtLastName.Clear();
            txtNewID.Clear();
            txtNewPass.Clear();
            txtNewPassAgain.Clear();
            txtNewAccID.Clear();
            txtNewBalance.Clear();
            comboNewAccType.SelectedIndex = 0;
       

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            pnlSearch.Visible = true;
            pnlAdd.Visible = false;
            pnlReport.Visible = false;

            ID_txt.Clear();
            metroListView1.Clear();
            idtxt.Clear();
            Passtxt.Clear();
            Fnametxt.Clear();
            Lnametxt.Clear();
        }
     
        private void radExistedUser_CheckedChanged(object sender, EventArgs e)
        {
            if (radExistedUser.Checked)
            {
                txtID.Enabled = true;
                txtBalance.Enabled = true;
                comboAccType.Enabled = true;
                txtAccID.Enabled = true;
            }
            else
            {
                txtAccID.Enabled = false;
                txtID.Enabled = false;
                txtBalance.Enabled = false;
                comboAccType.Enabled = false;
            }
        }

        private void radNewUser_CheckedChanged(object sender, EventArgs e)
        {
            //radio button to determine which is checked 1-add new customer 2-add new account
            if (radNewUser.Checked)
            {
                txtFirstName.Enabled = true;
                txtLastName.Enabled = true;
                txtNewID.Enabled = true;
                txtNewPass.Enabled = true;
                txtNewPassAgain.Enabled = true;
                comboNewAccType.Enabled = true;
                txtNewAccID.Enabled = true;
                txtNewBalance.Enabled = true;
            }
            else
            {
                txtNewAccID.Enabled = false;
                txtFirstName.Enabled = false;
                txtLastName.Enabled = false;
                txtNewID.Enabled = false;
                txtNewPass.Enabled = false;
                txtNewPassAgain.Enabled = false;
                comboNewAccType.Enabled = false;
                txtNewBalance.Enabled = false;
            }
        }


        private void AdminMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /*-------------------------------Mostafaaaa---------------------------------------*/

        public void ADD_ACC()//add new account for customer 1-checking 2-saving 3-loan
        {
            condatabase1.Open();

            SqlCommand cmd = condatabase1.CreateCommand();
            cmd.CommandType = CommandType.Text;

            if (comboNewAccType.SelectedItem.ToString() == "Checking")
            {
                cmd.CommandText = "insert into Account (UserID,AccountID,AccountType,Balance) values('"+ txtNewID.Text+"', '" + txtNewAccID.Text + "','Checking','" + float.Parse(txtNewBalance.Text) + "')";
                cmd.ExecuteNonQuery();
                condatabase1.Close();
                MessageBox.Show("Congratulation You Have New Checking Account :)");
            }
            else if (comboNewAccType.SelectedItem.ToString() == "Saving")
            {
                cmd.CommandText = "insert into Account (UserID,AccountID,AccountType,Balance,LastChecked) values('"+ txtNewID.Text + "', '" + txtNewAccID.Text + "','Saving','" + float.Parse(txtNewBalance.Text) + "','" + Program.Time_now + "')";
                cmd.ExecuteNonQuery();
                condatabase1.Close();
                MetroFramework.MetroMessageBox.Show(AdminMenu.ActiveForm, "Congratulation You Have New Saving Account ");

               
            }
            else if (comboNewAccType.SelectedItem.ToString() == "Loan")
            {
                double b = Convert.ToDouble(txtNewBalance.Text);
                b += b * 0.2;//calculate loan amount after adding interest rate
                cmd.CommandText = "insert into Account (UserID,AccountID,AccountType,Balance,Payment) values('"+ txtNewID.Text+"' , '" + txtNewAccID.Text + "','Loan','" + b + "','" + 0 + "')";
                cmd.ExecuteNonQuery();
                condatabase1.Close();
                MessageBox.Show("Congratulation You Have New Loan Account :)");
            }

          
        }
        public void ADD_Customer()//add new cusomter 
        {

            condatabase1.Open();

            SqlCommand cmd = condatabase1.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "insert into Customer (ID,FirstName,LastName,Password) values('" + txtNewID.Text + "','" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtNewPass.Text + "')";
            cmd.ExecuteNonQuery();
            condatabase1.Close();
            ADD_ACC();
            
        }

        private void comboNewAccType_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            if (comboNewAccType.SelectedItem.ToString() == "Checking" || comboNewAccType.SelectedItem.ToString() == "Saving")
            {
                txtNewBalance.WaterMark = "Balance";
              
            }
            else if (comboNewAccType.SelectedItem.ToString() == "Loan")
            {
                txtNewBalance.WaterMark = "Loan";
                
            }
          
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (radNewUser.Checked)
            {
                if (txtNewPass.Text != txtNewPassAgain.Text)
                {
                    lblPass.Visible = true;
                    return;
                }
                if (txtNewID.Text == "" || txtNewAccID.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "" || txtNewPass.Text == "" || txtNewPassAgain.Text == "" || txtNewBalance.Text == "" || comboNewAccType.SelectedIndex == 0)
                {
                    MessageBox.Show("Fill the form first");
                }
                else
                {
                    ADD_Customer();
                    this.DataTable1TableAdapter.Fill(this.DataSet1.DataTable1);
                    this.reportViewer1.Refresh();
                    this.reportViewer1.RefreshReport();
                    
                }
            }
            else if (radExistedUser.Checked)
            {
                if (comboAccType.SelectedIndex == 0)
                {
                    MessageBox.Show("Choose Account Type");
                    return;
                }
                condatabase1.Open();

                SqlDataReader reader = null;

                SqlCommand cmd1 = condatabase1.CreateCommand();
                cmd1.CommandText = "select * from Customer";
                reader = cmd1.ExecuteReader();
                while (reader.Read())
                {
                    if (txtID.Text == reader.GetString(0))
                    {

                        SqlConnection condatabase2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sherif\Documents\Test.mdf;Integrated Security=True;Connect Timeout=30");
                        condatabase2.Open();
                        SqlCommand cmd2 = condatabase2.CreateCommand();
                        if (comboAccType.SelectedItem.ToString() == "Loan")
                        {
                            double b = Convert.ToDouble(txtBalance.Text);
                            b += b * 0.2;
                            cmd2.CommandText = "insert into Account (UserID,AccountID,AccountType,Balance,Payment) values('" + txtID.Text + "','" + txtAccID.Text + "','" + comboAccType.SelectedItem.ToString() + "','" + b + "','"+0+"')";
                            cmd2.ExecuteNonQuery();
                            condatabase1.Close();
                            condatabase2.Close();
                            MetroFramework.MetroMessageBox.Show(AdminMenu.ActiveForm, "Saved !!");
                            this.DataTable1TableAdapter.Fill(this.DataSet1.DataTable1);
                            this.reportViewer1.Refresh();
                            this.reportViewer1.RefreshReport();
                            return;
                        }
                        else if (comboAccType.SelectedItem.ToString() == "Saving")
                        {
                            cmd2.CommandText = "insert into Account (UserID,AccountID,AccountType,Balance,LastChecked) values('" + txtID.Text + "','" + txtAccID.Text + "','" + comboAccType.SelectedItem.ToString() + "','" + txtBalance.Text + "','" + Program.Time_now + "')";
                            cmd2.ExecuteNonQuery();
                            condatabase1.Close();
                            condatabase2.Close();
                            MetroFramework.MetroMessageBox.Show(AdminMenu.ActiveForm, "Saved !!");
                            this.DataTable1TableAdapter.Fill(this.DataSet1.DataTable1);
                            this.reportViewer1.Refresh();
                            this.reportViewer1.RefreshReport();
                            return;
                        }
                        else 
                        {
                            cmd2.CommandText = "insert into Account (UserID,AccountID,AccountType,Balance) values('" + txtID.Text + "','" + txtAccID.Text + "','" + comboAccType.SelectedItem.ToString() + "','" + txtBalance.Text + "')";
                            cmd2.ExecuteNonQuery();
                            condatabase1.Close();
                            condatabase2.Close();
                            MetroFramework.MetroMessageBox.Show(AdminMenu.ActiveForm, "Saved !!");
                            this.DataTable1TableAdapter.Fill(this.DataSet1.DataTable1);
                            this.reportViewer1.Refresh();
                            this.reportViewer1.RefreshReport();
                            return;
                        }
                    }
                }
                MetroFramework.MetroMessageBox.Show(AdminMenu.ActiveForm, "Wrong user ID!!");
                condatabase1.Close();
            }

        }

        private void txtLastName_Click(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            pnlReport.Visible = true;
            pnlSearch.Visible = false;
            pnlAdd.Visible = false;
         
        }
    }//form
}//namespace
