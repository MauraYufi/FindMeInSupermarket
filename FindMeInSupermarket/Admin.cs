using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMeInSupermarket
{
    class Admin
    {
        private string _loginName;
        private string _password;

        public Admin(string loginName, string password)
        {
            LoginName = loginName;
            Password = password;
        }

        public string LoginName
        {
            get { return _loginName; }
            set { _loginName = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public Boolean Login (string loginName, string password)
        {
            if (loginName == "Admin" & password == "12345")
            {
                return true;
            }
            else
                return false;
        }
    }
}
