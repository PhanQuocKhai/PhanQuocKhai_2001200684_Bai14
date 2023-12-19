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
    public partial class Form2 : Form
    {
        public Form2(SqlConnection conn)
        {
            InitializeComponent();
            LoadCS_ComboBox(conn);
            LoadDV_ComboBox(conn);
        }

        private void LoadDV_ComboBox(SqlConnection conn)
        {
            conn.Open();
            string cmdStr = "SELECT * FROM DONVI";
            SqlCommand cmd = new SqlCommand(cmdStr, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                comboBox1.Items.Add(rd["tenDonVi"].ToString());
            }
            rd.Close();
            conn.Close();
        }
        private void LoadCS_ComboBox(SqlConnection conn)
        {
            conn.Open();
            string cmdStr = "SELECT * FROM COSO";
            SqlCommand cmd = new SqlCommand(cmdStr, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                comboBox1.Items.Add(rd["tenCoSo"].ToString());
            }
            rd.Close();
            conn.Close();
        }
    }
}