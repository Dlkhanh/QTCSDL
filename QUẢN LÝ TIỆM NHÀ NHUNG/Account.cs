using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_tri_tiem_nha_nhung
{
    public class Account
    {
        private string username;

        public string Username 
        { 
            get => username; 
            set => username = value; 
        }
        

        private string Password;
        public string Password1 
        { 
            get => Password; 
            set => Password = value; 
        }
        public Account(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

    }
}
