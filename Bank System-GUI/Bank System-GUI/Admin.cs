using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System_GUI
{
    class Admin
    {
        private string ID;
        private string password;
        private string name;

        public Admin()
        {
            ID = "000";
            password = "123";
            name = "AMR";

        }

        public string Get_ID()
        {
            return ID;
        }

        public string Get_Password()
        {

            return password;
        }
    }
}
