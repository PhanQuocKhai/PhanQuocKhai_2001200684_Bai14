using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Bai14
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Có Chắc Chắn Muốn Thoát Không", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_KN_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=A209PC46; Initial Catalog=BAI14; Integrated Security = true";
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                MessageBox.Show("Kết nối đến cơ sở dữ liệu thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối đến cơ sở dữ liệu thất bại.");
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên chương trình hoặc tên cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK);
                textBox2.Focus();
            }
        }
        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên chương trình hoặc tên cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK);
                textBox2.Focus();
            }
        }
    }
}
