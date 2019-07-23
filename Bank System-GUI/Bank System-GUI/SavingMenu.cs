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
    public partial class SavingMenu : MetroFramework.Forms.MetroForm
    {
        public SavingMenu()
        {
            InitializeComponent();
        }

        private void SavingMenu_Load(object sender, EventArgs e)//update last checked
        {
            PanelWithdraw.Visible = false;
            PanelDeposite.Visible = false;
            pnlTransfer.Visible = false;

            if (Program.logged_in.sv[Program.logged_in.AccountIndex].Get_LastChecked_Date().Month < Program.Time_now.Month)
            {
                int diff = Program.Time_now.Month - Program.logged_in.sv[Program.logged_in.AccountIndex].Get_LastChecked_Date().Month;

                Program.logged_in.sv[Program.logged_in.AccountIndex].Calculate_Balance(diff);

                Program.logged_in.sv[Program.logged_in.AccountIndex].Set_LastCheched_Date(Program.Time_now);

                Program.logged_in.sv[Program.logged_in.AccountIndex].update_LastChecked();

            }
        }


        private void btnDeposite_Click(object sender, EventArgs e)//open deposite panel
        {
            PanelWithdraw.Visible = false;
            pnlTransfer.Visible = false;
            PanelDeposite.Visible = true;
        }

        private void btnDepAmn_Click(object sender, EventArgs e)//deposite in table the amount entered
        {

            double b = Convert.ToDouble(txtDeposite.Text);
            Program.logged_in.sv[Program.logged_in.AccountIndex].Deposit(b);
            Program.logged_in.sv[Program.logged_in.AccountIndex].update_balance();
            MetroFramework.MetroMessageBox.Show(SavingMenu.ActiveForm, "Done");

            txtDeposite.Clear();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)//open withdraw panel
        {
            PanelDeposite.Visible = false;
            PanelWithdraw.Visible = true;
            pnlTransfer.Visible = false;
        }

        private void btnWithAmn_Click(object sender, EventArgs e)//withdraw function
        {
            double b = Convert.ToDouble(txtWithdraw.Text);

            if (Program.logged_in.sv[Program.logged_in.AccountIndex].Withdraw(b))
            {
                Program.logged_in.sv[Program.logged_in.AccountIndex].update_balance();
                MetroFramework.MetroMessageBox.Show(SavingMenu.ActiveForm, "Done");
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(SavingMenu.ActiveForm, "You don't have this amount");
            }

            txtWithdraw.Clear();

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)//Balance enquery
        {
            MetroFramework.MetroMessageBox.Show(SavingMenu.ActiveForm, "Your Balance is : " + Program.logged_in.sv[Program.logged_in.AccountIndex].get_Balance());

        }

        private void SavingMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnTransfer_Click(object sender, EventArgs e)//open panel money transfer
        {
            pnlTransfer.Visible = true;
            PanelDeposite.Visible = false;
            PanelWithdraw.Visible = false;

            ComboTrans.SelectedIndex = 0;

           
            //Add logged in accounts in combo box
            for (int i = 0; i < Program.logged_in.sv.Count; i++)
            {
                if (Program.logged_in.sv[Program.logged_in.AccountIndex].get_ID() == Program.logged_in.sv[i].get_ID())
                {
                    continue;
                }
                ComboTrans.Items.Add(Program.logged_in.sv[i].get_ID().ToString());
            }
            for (int i = 0; i < Program.logged_in.Check.Count; i++)
            {
                if (Program.logged_in.Check[Program.logged_in.AccountIndex].get_ID() == Program.logged_in.Check[i].get_ID())
                {
                    continue;
                }
                ComboTrans.Items.Add(Program.logged_in.Check[i].get_ID());
            }
        
        }

        private void btnTransAmn_Click(object sender, EventArgs e)//money transfer function
        {
            double Trans = Convert.ToDouble(txtBalance.Text);

            SqlConnection condatabase = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sherif\Documents\test.mdf;Integrated Security=True;Connect Timeout=30");

            SqlDataReader reader = null;


            condatabase.Open();

            SqlCommand cmd = condatabase.CreateCommand();
            cmd.CommandText = "select * from Account";
            reader = cmd.ExecuteReader();
            string SelId = ComboTrans.SelectedItem.ToString();
            while (reader.Read())
            {
                if (SelId == reader.GetString(1))
                {
                    if (reader.GetString(2) == "Saving")
                    {
                        SavingAccount Obj = new SavingAccount(reader.GetDouble(3) , reader.GetString(1));

                        if (Program.logged_in.sv[Program.logged_in.AccountIndex].Withdraw(Trans))
                        {
                            Program.logged_in.sv[Program.logged_in.AccountIndex].update_balance();

                            Obj.Deposit(Trans);

                            Obj.update_balance();

                            MetroFramework.MetroMessageBox.Show(SavingMenu.ActiveForm, "Transfer completed !");
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(SavingMenu.ActiveForm, "Error !");
                        }
                    }
                  
                }
            }          
        }
    }
}
