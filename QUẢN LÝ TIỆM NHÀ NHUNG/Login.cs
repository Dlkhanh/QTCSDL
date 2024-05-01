using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace quan_tri_tiem_nha_nhung
{
    public partial class Login : Form
    {
        List<Account> listTaiKhoan = ListAccount.Instance.ListTaiKhoan; 
        public Login()
        {
            InitializeComponent();
        }

        private void pannel1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Login_FormClosed(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (CheckLogin(txbUserName.Text, txbPassword.Text))
            {
                fmanagetable f = new fmanagetable();
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Lỗi");
                txbUserName.Focus();
            }
            
            
            
        }
        bool CheckLogin(string username, string password)
        {
            for (int i = 0 ; i<listTaiKhoan.Count; i++)
            {
                if (username == listTaiKhoan[i].Username && password == listTaiKhoan[i].Password1)
                {
                    return true;
                }
                
            }
            return false;
        }

        
    }
}
