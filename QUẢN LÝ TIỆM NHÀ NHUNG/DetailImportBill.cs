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
    public partial class DetailImportBill : Form
    {
        public DetailImportBill()
        {
            InitializeComponent();
            loadcombobox();
            loadcombobox1();
           
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-SRIPCOI8\\PTHAO;Initial Catalog=TiemnhaNhung;Integrated Security=True;TrustServerCertificate=TrueData Source=LAPTOP-SRIPCOI8\\PTHAO;Initial Catalog=TiemnhaNhung;Integrated Security=True;TrustServerCertificate=True");


        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=LAPTOP-SRIPCOI8\\PTHAO;Initial Catalog=TiemnhaNhung;Integrated Security=True;TrustServerCertificate=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from HOADONNHAPCHITIET";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bill  f = new Bill();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            comboBox2.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            numericUpDown1.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBox8.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
           
        }

        private void DetailImportBill_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }
        private void loadcombobox()
        {
            comboBox1.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select MaHH from HANGHOA";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["MaHH"].ToString());
            }
            con.Close();

        }
        private void loadcombobox1()
        {
            comboBox2.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select MaHDN from HOADONNHAP order by MaHDN desc ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox2.Items.Add(dr["MaHDN"].ToString());
            }
            con.Close();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            fmanagetable back = new fmanagetable();
            back.Show();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            this.Close();
            fmanagetable back = new fmanagetable();
            back.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into HOADONNHAPCHITIET values(N'" + comboBox2.Text + "',N'" +comboBox1.Text + "',N'" + numericUpDown1.Text + "',N'" + textBox8.Text+ "')";

            command.ExecuteNonQuery();
            loaddata();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from HOADONNHAPCHITIET where MaHDN='" + comboBox2.Text + "'";

            command.ExecuteNonQuery();
            loaddata();
;        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void DetailImportBill_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT GIANHAP*'"+ numericUpDown1.Text + "' FROM HANGHOA where MaHH='" + comboBox1.Text + "'";
            command.Connection = connection;
            object data = command.ExecuteScalar();
            int n = (int)data;
            textBox8.Text = "" + n;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update HOADONNHAPCHITIET set SoLuongHang='" + numericUpDown1.Text + "',ThanhTien_NH='" + textBox8.Text + "' where MaHDN='" + comboBox2.Text + "' AND MaHH='" + comboBox1.Text + "'";

            command.ExecuteNonQuery();
            loaddata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bill f = new Bill();
            this.Hide();
            f.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
