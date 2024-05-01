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
    public partial class Form3 : Form
    {
        public Form3()
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
            command.CommandText = "select * from HANGHOA";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            numericUpDown1.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            fmanagetable back = new fmanagetable();
            back.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into HANGHOA values(dbo.AddHangHoa(),N'" + textBox2.Text + "',N'" + comboBox1.Text + "',N'" + numericUpDown1.Text + "')";

            command.ExecuteNonQuery();
            loaddata();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from HANGHOA where MaHH='" + textBox1.Text + "'";

            command.ExecuteNonQuery();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update HANGHOA set TenHang=N'" + textBox2.Text + "',DVT='" + comboBox1.Text + "',GiaNhap='" + numericUpDown1.Text + "' where MaHH='" + textBox1.Text + "'";

            command.ExecuteNonQuery();
            loaddata();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
