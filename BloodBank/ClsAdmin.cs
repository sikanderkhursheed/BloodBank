using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank
{
    class ClsAdmin
    {
        private int id;
        private string username;
        private string password;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
       
    }
}
