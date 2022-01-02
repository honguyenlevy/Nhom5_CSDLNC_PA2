using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADB1_5_DATH2.QuanTri
{
    public partial class QuanTri_KiemTra : Form
    {
        public QuanTri_KiemTra()
        {
            InitializeComponent();
        }

        private void buttonKiemTra_Click(object sender, EventArgs e)
        {
            string query = "QT_KIEM_TRA_SL N'" + textBoxSoLuong.Text + "'";
            Function.RunSQL(query);
            DataSet data = new DataSet();
            using (SqlConnection connection = new SqlConnection(Connection.connectionString))
            {
                connection.Open();
                SqlDataAdapter dap = new SqlDataAdapter(query, connection);
                dap.Fill(data);
                connection.Close();
            }
            dataGridViewXemSP.DataSource = data.Tables[0];

        }

        private void QuanTri_SanPham_Load(object sender, EventArgs e)
        {

        }

        private void buttonKiemTraHD_Click(object sender, EventArgs e)
        {
            string query = "QT_KIEM_TRA_HD N'" + dateTimePickerKT.Text + "'";
            Function.RunSQL(query);
            DataSet data = new DataSet();
            using (SqlConnection connection = new SqlConnection(Connection.connectionString))
            {
                connection.Open();
                SqlDataAdapter dap = new SqlDataAdapter(query, connection);
                dap.Fill(data);
                connection.Close();
            }
            dataGridViewHoaDon.DataSource = data.Tables[0];
        }
    }
}
