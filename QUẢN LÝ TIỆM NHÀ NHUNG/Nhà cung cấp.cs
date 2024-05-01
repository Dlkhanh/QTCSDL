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
    public partial class Form2 : Form
    {
        public Form2()
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
            command.CommandText = "select * from NHACC";
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
            textBox1.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBox0.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            fmanagetable back = new fmanagetable();
            back.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into NHACC values(dbo.AddNhaCC(),N'" + textBox2.Text + "',N'" + textBox1.Text + "',N'" + textBox0.Text + "')";

            command.ExecuteNonQuery();
            loaddata();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from NHACC where MaNCC='" + textBox3.Text + "'";

            command.ExecuteNonQuery();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            
                command = connection.CreateCommand();
                command.CommandText = "update NHACC set TenNCC=N'" + textBox2.Text + "',SDT=N'" + textBox1.Text + "',DiaChi=N'" + textBox0.Text + "' where MaNCC='" + textBox3.Text + "'";

                command.ExecuteNonQuery();
                loaddata();
            
        }
    }
}
