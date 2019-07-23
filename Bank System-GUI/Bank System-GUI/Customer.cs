using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System_GUI
{
    class Customer
    {
        public string ID { set; get; }
        public string First_Name { set; get; }
        public string Last_Name { set; get; }
        public string Password { set; get; }
        public int AccountIndex;
        public List<SavingAccount> sv = new List<SavingAccount>();
        public List<CheckingAccount> Check = new List<CheckingAccount>();
        public List<Loan> Looan = new List<Loan>();
        public Customer()
        {
            ID = null;
            First_Name = null;
            Last_Name = null;
            Password = null;
        }

    }
}
