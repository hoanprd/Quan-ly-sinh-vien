using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KetNoiMySQL
{
    public partial class Form1 : Form
    {
        string constr;
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataAdapter adt;

        public Form1()
        {
            InitializeComponent();
        }

        public void MoKetNoi()
        {
            con.Open();
        }

        public void LoadKetNoi()
        {
            constr = "server=" + SeverTextBox.Text + ";user=" + UsernameTextBox.Text + ";pwd=" + PasswordTextBox.Text + ";database=" + DatabaseNameTextBox.Text + ";port=" + PortTextBox.Text + ";";
            con = new MySqlConnection(constr);
            MoKetNoi();
            cmd = new MySqlCommand("select * from student", con);
            adt = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adt.Fill(dt);
            dataGridView1.DataSource = dt;
            DongKetNoi();
        }

        public void DongKetNoi()
        {
            con.Close();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            try
            {
                LoadKetNoi();
            }
            catch
            {
                MessageBox.Show("Lỗi thông tin!");
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ThemButton_Click(object sender, EventArgs e)
        {
            string query = string.Format("INSERT INTO student VALUES('{0}', '{1}', '{2}', '{3}')", MSSVTextBox.Text, HoVaTenTextBox.Text, LopTextBox.Text, GioiTinhTextBox.Text);
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Thêm thành công!");
                    LoadKetNoi();
                    MSSVTextBox.Clear();
                    HoVaTenTextBox.Clear();
                    LopTextBox.Clear();
                    GioiTinhTextBox.Clear();
                }
            }
        }

        public string id { get; set; }

        private void SuaButton_Click(object sender, EventArgs e)
        {
            string query = string.Format("UPDATE student SET MSSV = '{0}', hovaten = '{1}', lop = '{2}', gioitinh = '{3}' WHERE MSSV = {4}", MSSVTextBox.Text, HoVaTenTextBox.Text, LopTextBox.Text, GioiTinhTextBox.Text, id);
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Sửa thành công!");
                    LoadKetNoi();
                    MSSVTextBox.Clear();
                    HoVaTenTextBox.Clear();
                    LopTextBox.Clear();
                    GioiTinhTextBox.Clear();
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                id = row.Cells[0].Value.ToString();
                MSSVTextBox.Text = row.Cells[0].Value.ToString();
                HoVaTenTextBox.Text = row.Cells[1].Value.ToString();
                LopTextBox.Text = row.Cells[2].Value.ToString();
                GioiTinhTextBox.Text = row.Cells[3].Value.ToString();
            }
        }

        private void XoaButton_Click(object sender, EventArgs e)
        {
            string query = string.Format("DELETE FROM student WHERE MSSV = {0}", id);
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadKetNoi();
                    MSSVTextBox.Clear();
                    HoVaTenTextBox.Clear();
                    LopTextBox.Clear();
                    GioiTinhTextBox.Clear();
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                id = row.Cells[0].Value.ToString();
            }
        }
    }
}
