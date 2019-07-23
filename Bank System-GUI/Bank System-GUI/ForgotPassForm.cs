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
    public partial class ForgotPassForm : MetroFramework.Forms.MetroForm
    {
        public ForgotPassForm()
        {
            InitializeComponent();
        }

        private void ForgotPassForm_Load(object sender, EventArgs e)
        {
            txtPass.Enabled = false;
        }

      

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginForm obj = new LoginForm();
            obj.Show();
            this.Hide();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {


            SqlConnection condatabase = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sherif\Documents\Test.mdf;Integrated Security=True;Connect Timeout=30");

            SqlDataReader reader = null;


            condatabase.Open();

            SqlCommand cmd = condatabase.CreateCommand();
            cmd.CommandText = "select * from Customer";
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (txtID.Text == reader.GetString(0) && txtFirstName.Text==reader.GetString(1) && txtLastName.Text==reader.GetString(2))
                {
                    txtPass.Text = reader.GetString(3);
                    condatabase.Close();
                    return;
                }
               
            }
            MetroFramework.MetroMessageBox.Show(ForgotPassForm.ActiveForm, "You Dont Have an Account ");
            condatabase.Close();
        }

        private void ForgotPassForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
