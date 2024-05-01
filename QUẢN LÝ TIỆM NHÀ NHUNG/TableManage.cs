using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quan_tri_tiem_nha_nhung
{
    public partial class fmanagetable : Form
    {
        bool isThoat = true;
        public fmanagetable()
        {
            InitializeComponent();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void managetable_Load(object sender, EventArgs e)
        {

        }

        private void ongTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lsvBill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void adminToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void flpTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xemThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin f = new Admin();
            this.Hide();
            f.ShowDialog();
            this.Show(); ; ;
        }

        private void xemTổngHợpHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bill f = new Bill();
            this.Hide();
            f.ShowDialog();
            this.Show(); ;
        }



        private void hóaĐơnNhậpChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetailImportBill f = new DetailImportBill();
            this.Hide();
            f.ShowDialog();
            this.Show(); ;
        }

        private void hóaĐơnĐặtChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetailOrderBill f = new DetailOrderBill();
            this.Hide();
            f.ShowDialog();
            this.Show(); ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isThoat = false;
            
                this.Close();
                Login f = new Login();
                f.Show();
            
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (isThoat)
            {
                Application.Exit();
            }
        }

        private void fmanagetable_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            
        }

        private void fmanagetable_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat)
            {
                Application.Exit();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bill f = new Bill();
            this.Hide();
            f.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DetailOrderBill f = new DetailOrderBill();
            this.Hide();
            f.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DetailImportBill f = new DetailImportBill();
            this.Hide();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Menu f = new Menu();
            this.Hide();
            f.Show();
        }

  



        private void button3_Click(object sender, EventArgs e)
        {
            Admin f = new Admin();
            this.Hide();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Hide();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            this.Hide();
            f.Show();
        }
    }
}
