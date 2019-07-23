using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_System_GUI
{
    public partial class AccountsMenu : MetroFramework.Forms.MetroForm
    {
        public AccountsMenu()
        {
            InitializeComponent();
        }

      
        private void btnNext_Click(object sender, EventArgs e)
        {
        }

        private void AccountsMenu_Load(object sender, EventArgs e)
        {
            AccMenu.SelectedIndex = 0;

            for (int i = 0; i < Program.logged_in.sv.Count; i++)
            {
                AccMenu.Items.Add(Program.logged_in.sv[i].get_ID() + " ( Saving Account )");
            }
            for (int i = 0; i < Program.logged_in.Check.Count; i++)
            {
                AccMenu.Items.Add(Program.logged_in.Check[i].get_ID() + " ( Checking Account )");
            }
            for (int i = 0; i < Program.logged_in.Looan.Count; i++)
            {
                AccMenu.Items.Add(Program.logged_in.Looan[i].get_ID() + " ( Loan Account )");
            }


           
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {

            if (AccMenu.SelectedItem.ToString().Contains("Checking"))
            {
                for (int i = 0; i < Program.logged_in.Check.Count; i++)
                {
                    if (AccMenu.SelectedItem.ToString().Contains(Program.logged_in.Check[i].get_ID()))
                    {
                        Program.logged_in.AccountIndex = i;
                    }
                }

                CheckingMenu obj = new CheckingMenu();
                obj.Show();
                this.Hide();
            }
            else if (AccMenu.SelectedItem.ToString().Contains("Loan"))
            {

                for (int i = 0; i < Program.logged_in.Looan.Count; i++)
                {
                    if (AccMenu.SelectedItem.ToString().Contains(Program.logged_in.Looan[i].get_ID()))
                    {
                        Program.logged_in.AccountIndex = i;
                    }
                }
                LoanMenu obj = new LoanMenu();
                obj.Show();
                Hide();
            }
            else if (AccMenu.SelectedItem.ToString().Contains(" Saving "))
            {

                for (int i = 0; i < Program.logged_in.sv.Count; i++)
                {
                    if (AccMenu.SelectedItem.ToString().Contains(Program.logged_in.sv[i].get_ID()))
                    {
                        Program.logged_in.AccountIndex = i;
                    }
                }
                SavingMenu obj = new SavingMenu();
                obj.Show();
                Hide();

            }
        }

        private void AccountsMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bunifuRating1_onValueChanged(object sender, EventArgs e)
        {
            if(bunifuRating1.Value==5)
            {
                MetroFramework.MetroMessageBox.Show(AccountsMenu.ActiveForm, "Thanks ^_^");
            }
        }
    }
}
