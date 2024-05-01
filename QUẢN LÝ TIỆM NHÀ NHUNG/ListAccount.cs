using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_tri_tiem_nha_nhung
{
     public class ListAccount
    {
        private static ListAccount instance;
        public static ListAccount Instance 
        { 
            get
            { 
                if(instance==null)
                {
                    instance = new ListAccount();
                }
            return  instance;
            }
            set => instance = value; 
        }

        List<Account> listTaiKhoan;

        public List<Account> ListTaiKhoan 
        {
            get => listTaiKhoan; 
            set => listTaiKhoan = value; 
        }
        

        ListAccount()
        {
            listTaiKhoan = new List<Account>();
            listTaiKhoan.Add(new Account("admin","admin"));
            listTaiKhoan.Add(new Account("", ""));
        }
    }
}
