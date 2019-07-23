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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true; // Enable the timer.
            timer1.Start();//Strart it
            timer1.Interval = 100; // The time per tick.

            bunifuCircleProgressbar1.MaxValue = 10;

            timer1.Tick += new EventHandler(timer1_Tick);
        }
        void timer1_Tick(object sender, EventArgs e)
        {
            if (bunifuCircleProgressbar1.Value != 10)
            {
                bunifuCircleProgressbar1.Value++;
            }
            else
            {
                timer1.Stop();
                LoginForm lf = new LoginForm();
                lf.Show();
                this.Hide();
               
            }
        }

    }
}
