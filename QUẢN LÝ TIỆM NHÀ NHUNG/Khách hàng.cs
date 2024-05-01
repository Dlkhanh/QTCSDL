using quan_tri_tiem_nha_nhung.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace quan_tri_tiem_nha_nhung
{
    public partial class Admin : Form
    {
        SqlConnection connection;
        SqlCommand command; 
        string str = "Data Source=LAPTOP-SRIPCOI8\\PTHAO;Initial Catalog=TiemnhaNhung;Integrated Security=True;TrustServerCertificate=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from KHACH";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        public Admin()
        {
            InitializeComponent();
           
        }
 


        








        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void supplier_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            fmanagetable back = new fmanagetable();
            back.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {              
            command = connection.CreateCommand();
            command.CommandText = "insert into KHACH values(dbo.ADDKHACH(),N'" + textBox2.Text+ "',N'"+textBox3.Text+ "',N'"+textBox4.Text+ "')";

            command.ExecuteNonQuery();
            loaddata();


        }

        private void button19_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update KHACH set TenKH=N'" + textBox2.Text + "',SDTKH='" + textBox3.Text + "',DiaChiKH=N'" + textBox4.Text + "' where MaKH='" + textBox1.Text + "'";

            command.ExecuteNonQuery();
            loaddata();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from  KHACH where MaKH='"+ textBox1.Text + "'";

            command.ExecuteNonQuery();
            loaddata();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bill f = new Bill();
            this.Hide();
            f.Show();
        }
    }
}
