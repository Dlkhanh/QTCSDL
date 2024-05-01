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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=LAPTOP-SRIPCOI8\\PTHAO;Initial Catalog=TiemnhaNhung;Integrated Security=True;TrustServerCertificate=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from NHANVIEN";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            textBox3.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txbCustomerPhone.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            fmanagetable back = new fmanagetable();
            back.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into NHANVIEN values(dbo.AddNhanVien(),N'" + textBox2.Text + "',N'" + txbCustomerPhone.Text + "',N'" + comboBox1.Text + "')";

            command.ExecuteNonQuery();
            loaddata();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from NHANVIEN where MaNV='" + textBox3.Text + "'";

            command.ExecuteNonQuery();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update NHANVIEN set TenNV=N'" + textBox2.Text + "',SDT_NV='" + txbCustomerPhone.Text + "',ChucVu=N'" + comboBox1.Text + "' where MaNV='" + textBox3.Text + "'";

            command.ExecuteNonQuery();
            loaddata();
        }
    }
}
