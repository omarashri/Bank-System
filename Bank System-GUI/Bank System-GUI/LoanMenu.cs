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
    public partial class LoanMenu : MetroFramework.Forms.MetroForm
    {
        public LoanMenu()
        {
            InitializeComponent();
        }

        private void btnAddAmn_Click(object sender, EventArgs e)
        {


            double payment_temp = Convert.ToDouble(enteryPayment_txt.Text);//get monthly payment from customer
            //check if remains less than monthly payment 
            if (Program.logged_in.Looan[Program.logged_in.AccountIndex].Calculate_Payment() > Program.logged_in.Looan[Program.logged_in.AccountIndex].Calculate_remains())
            {
                Program.logged_in.Looan[Program.logged_in.AccountIndex].update_payment(payment_temp);
                if (Program.logged_in.Looan[Program.logged_in.AccountIndex].delete_account())
                {
                    MetroFramework.MetroMessageBox.Show(LoanMenu.ActiveForm, "Your Account Deleted Successfully ");
                }
                else
                    MetroFramework.MetroMessageBox.Show(LoanMenu.ActiveForm, "Your Operation Approved ");

            }
            else
            {
                if (payment_temp < Program.logged_in.Looan[Program.logged_in.AccountIndex].Calculate_Payment())
                {
                    MetroFramework.MetroMessageBox.Show(LoanMenu.ActiveForm, "At least you enter " + Program.logged_in.Looan[Program.logged_in.AccountIndex].Calculate_Payment());
                }
                else if (payment_temp > Program.logged_in.Looan[Program.logged_in.AccountIndex].get_Balance())
                {
                    MetroFramework.MetroMessageBox.Show(LoanMenu.ActiveForm, "Your Loan amount is " + Program.logged_in.Looan[Program.logged_in.AccountIndex].get_Balance().ToString());
                }
                else if (payment_temp >= Program.logged_in.Looan[Program.logged_in.AccountIndex].Calculate_Payment())
                {

                    Program.logged_in.Looan[Program.logged_in.AccountIndex].update_payment(payment_temp);
                    if (Program.logged_in.Looan[Program.logged_in.AccountIndex].delete_account())
                    {
                        MetroFramework.MetroMessageBox.Show(LoanMenu.ActiveForm, "Your Account Deleted Successfully ");
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(LoanMenu.ActiveForm, "Your Operation Approved ");
                }
              
            }
        }
    
        private void LoanMenu_Load(object sender, EventArgs e)
        {
            PanelAdd.Visible = false;
            PanelCheck.Visible = false;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            PanelAdd.Visible = false;

            PanelCheck.Visible = true;

            CurrentBalance_txt.Enabled = false;
            Payment_txt.Enabled = false;


            CurrentBalance_txt.Text = Convert.ToString(Program.logged_in.Looan[Program.logged_in.AccountIndex].Calculate_remains());
            Payment_txt.Text = Convert.ToString(Program.logged_in.Looan[Program.logged_in.AccountIndex].get_Pay());

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PanelCheck.Visible = false;
            PanelAdd.Visible = true;
        }

        private void LoanMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}