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
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
            list1();
            list2();
            loadcombobox2();
            loadcombobox3();
            loadcombobox4();
            loadcombobox5();
            loadcombobox6();

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
            command.CommandText = "select * from HOADONDATCHITIET";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
       
        }
      
        

        void list1()
        {
            string query = "select * from HOADONDAT";
           
            dataGridView2.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }
        void list2()
        {
            string query = "select * from HOADONNHAP";
            dataGridView3.DataSource = DataProvider.Instance.ExcuteQuery(query);
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

  

        private void button2_Click(object sender, EventArgs e)
        {
            DetailOrderBill f = new DetailOrderBill();


            this.Hide();
            f.ShowDialog();
            this.Show(); ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DetailImportBill f = new DetailImportBill();

            this.Hide();
            f.ShowDialog();
            this.Show(); ;
        }
 

      

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView2.CurrentRow.Index;
            comboBox5.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
            dateTimePicker1.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
            textBox2.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
            textBox8.Text = dataGridView2.Rows[i].Cells[3].Value.ToString();
            numericUpDown6.Text = dataGridView2.Rows[i].Cells[4].Value.ToString();
            comboBox2.Text = dataGridView2.Rows[i].Cells[6].Value.ToString();
            comboBox1.Text = dataGridView2.Rows[i].Cells[7].Value.ToString();
            
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
            
     
        
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            fmanagetable back = new fmanagetable();
            back.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            fmanagetable back = new fmanagetable();
            back.Show();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView3.CurrentRow.Index;
            comboBox6.Text = dataGridView3.Rows[i].Cells[0].Value.ToString();
            textBox6.Text = dataGridView3.Rows[i].Cells[1].Value.ToString();
            dateTimePicker2.Text = dataGridView3.Rows[i].Cells[2].Value.ToString();
            comboBox3.Text = dataGridView3.Rows[i].Cells[3].Value.ToString();
            comboBox4.Text = dataGridView3.Rows[i].Cells[4].Value.ToString();
            


        }

 

        private void button20_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into HOADONDAT values(dbo.AddHDD(),'" + dateTimePicker1.Value.ToString("dd-MMM-yyyy")+ "',N'" +textBox2.Text+ "',N'" + textBox8.Text+ "','" +numericUpDown6.Text+ "',N'" +textBox7.Text+ "',N'" +comboBox2.Text+ "',N'"+comboBox1.Text+ "')";

            command.ExecuteNonQuery();
            list1();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into HOADONNHAP values(dbo.AddHDN(),N'" + textBox6.Text+ "','" +dateTimePicker2.Value.ToString("dd-MMM-yyyy") + "',N'" +comboBox3.Text+ "',N'" +comboBox4.Text+ "')";

            command.ExecuteNonQuery();
            list2();
        }

     

        private void button19_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update HOADONDAT set NgayDat='" +dateTimePicker1.Value.ToString("dd-MMM-yyyy")+ "',GhiChu=N'" + textBox2.Text + "',TongDonDat='" + textBox8.Text + "',GiamGia='" + numericUpDown6.Text + "',TongCong='" + textBox7.Text + "',MaKH='" + comboBox2.Text + "',TrangThai='" + comboBox1.Text + "' where MaDDH='"+ comboBox5.Text+"'";

            command.ExecuteNonQuery();
            list1();

        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            //tính tiền
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT (SUM(THANHTIEN_DH)-SUM(THANHTIEN_DH)*'" + numericUpDown6.Text + "') FROM HOADONDAT INNER JOIN HOADONDATCHITIET ON hoadondat.MaDDH=hoadondatchitiet.MaDDH where hoadondat.MaDDH='" + comboBox5.Text + "' GROUP BY hoadondatchitiet.maDDH";
            command.Connection = connection;
            object data = command.ExecuteScalar();
            int n = (int)data;
            textBox7.Text = "" + n;
        }

       
        
        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {

        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update HOADONNHAP set Tongdon='" + textBox6.Text + "',NgayNH='" + dateTimePicker2.Value.ToString("dd-MMM-yyyy") + "',MaNV='" + comboBox3.Text + "',MaNCC='" + comboBox4.Text + "' where MaHDN='"+ comboBox6.Text+"'";

            command.ExecuteNonQuery();
            list2();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from HOADONNHAP where MaHDN='" + comboBox6.Text + "'";

            command.ExecuteNonQuery();
            list2();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from HOADONDAT where MaDDH='" + comboBox5.Text + "'";

            command.ExecuteNonQuery();
            list1();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT (SUM(THANHTIEN_DH)-SUM(THANHTIEN_DH)*'" + numericUpDown6.Text + "'/100) FROM HOADONDAT INNER JOIN HOADONDATCHITIET ON hoadondat.MaDDH=hoadondatchitiet.MaDDH where hoadondat.MaDDH='" + comboBox5.Text + "' GROUP BY hoadondatchitiet.maDDH";
            command.Connection = connection;
            object data = command.ExecuteScalar();
            if (data == null)
            {
                string n = (string)data;
                textBox7.Text = "" + n;
            }
            else
            {
                int n = (int)data;
                textBox7.Text = "" + n;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT SUM(THANHTIEN_NH) FROM HOADONNHAPCHITIET  INNER JOIN HOADONNHAP on HOADONNHAP.MaHDN=HOADONNHAPCHITIET.MaHDN where hoadonNHAP.MaHDN='" + comboBox6.Text + "' GROUP BY hoadonNHAPchitiet.maHDN";
            command.Connection = connection;
            object data = command.ExecuteScalar();
            if (data == null)
            {
                string n = (string)data;
                textBox6.Text = "" + n;
            }
            else
            {
                int n = (int)data;
                textBox6.Text = "" + n;
            }
            
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT SUM(THANHTIEN_DH) FROM HOADONDAT INNER JOIN HOADONDATCHITIET ON hoadondat.MaDDH=hoadondatchitiet.MaDDH where hoadondat.MaDDH='" + comboBox5.Text + "' GROUP BY hoadondatchitiet.maDDH";
            command.Connection = connection;
            object data = command.ExecuteScalar();
            if (data == null)
            {
                string n = (string)data;
                textBox8.Text = "" + n;
            }
            else
            {
                int n = (int)data;
                textBox8.Text = "" + n;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void loadcombobox2()
        {
            comboBox2.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select MaKH from KHACH";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox2.Items.Add(dr["MaKH"].ToString());
            }
            con.Close();
        }
        private void loadcombobox6()
        {
            comboBox6.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select MaHDN from HOADONNHAP order by MaHDN desc";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox6.Items.Add(dr["MaHDN"].ToString());
            }
            con.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void loadcombobox3()
        {
            comboBox3.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select MaNV from NHANVIEN";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox3.Items.Add(dr["MaNV"].ToString());
            }
            con.Close();
        }
        private void loadcombobox4()
        {
            comboBox4.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select MaNCC from NHACC";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox4.Items.Add(dr["MaNCC"].ToString());
            }
            con.Close();
        }
        private void loadcombobox5()
        {
            comboBox5.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select MaDDH from HOADONDAT order by MaDDH desc";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox5.Items.Add(dr["MaDDH"].ToString());
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetailOrderBill f = new DetailOrderBill();
            this.Hide();
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DetailImportBill f = new DetailImportBill();
            this.Hide();
            f.Show();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            comboBox6.ResetText();
            textBox6.ResetText();
            dateTimePicker2.ResetText();
            comboBox3.ResetText();
            comboBox4.ResetText();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            comboBox5.ResetText();
            dateTimePicker1.ResetText();
            textBox2.ResetText();
            textBox8.ResetText();
            numericUpDown6.ResetText();
            textBox7.ResetText();
            comboBox2.ResetText();
            comboBox1.ResetText();
        }

        private void comboBox5_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            

        }
    }
}
