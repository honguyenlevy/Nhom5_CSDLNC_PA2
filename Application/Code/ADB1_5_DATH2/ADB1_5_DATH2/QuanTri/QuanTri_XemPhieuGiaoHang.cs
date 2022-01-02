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
    public partial class QuanTri_XemPhieuGiaoHang : Form
    {
        string query;
        public QuanTri_XemPhieuGiaoHang()
        {
            InitializeComponent();
        }

        public QuanTri_XemPhieuGiaoHang(string sql) : this()
        {
            query = sql;
        }

        private void QuanTri_XemPhieuGiaoHang_Load(object sender, EventArgs e)
        {
            Function.RunSQL(query);
            DataSet data = new DataSet();
            using (SqlConnection connection = new SqlConnection(Connection.connectionString))
            {
                connection.Open();
                SqlDataAdapter dap = new SqlDataAdapter(query, connection);
                dap.Fill(data);
                connection.Close();
            }
            dataGridViewXem.DataSource = data.Tables[0];
        }
    }
}
