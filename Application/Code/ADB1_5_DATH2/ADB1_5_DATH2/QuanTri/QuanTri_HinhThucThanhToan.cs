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
    public partial class QuanTri_HinhThucThanhToan : Form
    {
        string sql;
        public QuanTri_HinhThucThanhToan()
        {
            InitializeComponent();
        }

        private void QuanTri_HinhThucThanhToan_Load(object sender, EventArgs e)
        {
            Function.FillCombo("SELECT MaHTTT FROM HTTHANHTOAN", comboBoxMaHTTT, "MaHTTT", "MaHTTT");
            comboBoxMaHTTT.SelectedIndex = -1;
        }

        private void buttonThemHTTT_Click(object sender, EventArgs e)
        {
            if (Them_textBoxTenHTTT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hình thức thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Them_textBoxTenHTTT.Focus();
                return;
            }
            string query = "QT_THEM_HTTT N'" + Them_textBoxTenHTTT.Text + "'";
            sql = Function.GetFieldValues(query);
            MessageBox.Show("Thêm hình thức thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Function.FillCombo("SELECT MaHTTT FROM HTTHANHTOAN", comboBoxMaHTTT, "MaHTTT", "MaHTTT");
            comboBoxMaHTTT.SelectedIndex = -1;

            DataSet data = new DataSet();
            
            string sql1 = "SELECT * FROM HTTHANHTOAN WHERE MaHTTT = '" + sql + "'";
            using (SqlConnection connection = new SqlConnection(Connection.connectionString))
            {
                connection.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql1, connection);
                dap.Fill(data);
                connection.Close();
            }
            dataGridViewXemHTTT.DataSource = data.Tables[0];

            Them_textBoxTenHTTT.Text = "";
        }

        private void comboBoxMaHTTT_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (comboBoxMaHTTT.Text == "")
            {
                CapNhat_textBoxTenHTTT.Text = "";
            }
            str = "SELECT TenHTTT FROM HTTHANHTOAN WHERE MaHTTT = N'" + comboBoxMaHTTT.SelectedValue + "'";
            CapNhat_textBoxTenHTTT.Text = Function.GetFieldValues(str);
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            if (comboBoxMaHTTT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã hình thức thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxMaHTTT.Focus();
                return;
            }
            if (CapNhat_textBoxTenHTTT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hình thức thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CapNhat_textBoxTenHTTT.Focus();
                return;
            }           
            string query = "QT_SUA_HTTT N'" + comboBoxMaHTTT.SelectedValue + "', N'" + CapNhat_textBoxTenHTTT.Text + "'";
            Function.RunSQL(query);
            MessageBox.Show("Cập nhật hình thức thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataSet data = new DataSet();
            string sql1 = "SELECT * FROM HTTHANHTOAN WHERE MaHTTT = '" + comboBoxMaHTTT.SelectedValue + "'";
            using (SqlConnection connection = new SqlConnection(Connection.connectionString))
            {
                connection.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql1, connection);
                dap.Fill(data);
                connection.Close();
            }
            dataGridViewXemHTTT.DataSource = data.Tables[0];

            comboBoxMaHTTT.Text = "";
            CapNhat_textBoxTenHTTT.Text = "";
        }

        private void buttonXem_Click(object sender, EventArgs e)
        {
            string query = "QT_XEM_HTTT";
            Function.RunSQL(query);
            DataSet data = new DataSet();
            using (SqlConnection connection = new SqlConnection(Connection.connectionString))
            {
                connection.Open();
                SqlDataAdapter dap = new SqlDataAdapter(query, connection);
                dap.Fill(data);
                connection.Close();
            }
            dataGridViewXemHTTT.DataSource = data.Tables[0];
        }
    }
}
