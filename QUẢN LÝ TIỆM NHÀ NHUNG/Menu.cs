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
    public partial class Menu : Form
    {
        
        public Menu()
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
            command.CommandText = "select * from MONAN";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView2.DataSource = table;
        }



        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView2.CurrentRow.Index;
            textBox1.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
            textBox6.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
            comboBox2.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
            numericUpDown1.Text = dataGridView2.Rows[i].Cells[3].Value.ToString();
        }
      


        private void Menu_Load(object sender, EventArgs e)
        {

            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            this.Close();
            fmanagetable back = new fmanagetable();
            back.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into MONAN values(dbo.AddMonAn(),'" + textBox6.Text + "','" + comboBox2.Text + "','" + numericUpDown1.Text + "')";

            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnDele_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from MONAN where MaMon='" + textBox1.Text + "'";

            command.ExecuteNonQuery();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update MONAN set TenMon='" + textBox6.Text + "',DVT='" + comboBox2.Text + "',DonGia_Mon='" + numericUpDown1.Text + "' where MaNV='" + textBox1.Text + "'";

            command.ExecuteNonQuery();
            loaddata();
        }
    }
}
