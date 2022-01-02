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
    public partial class QuanTri_NhaCungCap : Form
    {
        string sql;

        public QuanTri_NhaCungCap()
        {
            InitializeComponent();
        }

        private void QuanTri_NhaCungCap_Load(object sender, EventArgs e)
        {
            Function.FillCombo("SELECT MaNCC FROM NHACUNGCAP", comboBoxMaNCC, "MaNCC", "MaNCC");
            comboBoxMaNCC.SelectedIndex = -1;
        }

        private void buttonThemNCC_Click(object sender, EventArgs e)
        {
            if (Them_textBoxDC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Them_textBoxDC.Focus();
                return;
            }
            if (Them_textBoxSDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Them_textBoxSDT.Focus();
                return;
            }
            if (Them_textBoxTenNCC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Them_textBoxTenNCC.Focus();
                return;
            }
            string query = "QT_THEM_NCC N'" + Them_textBoxTenNCC.Text + "', N'" + Them_textBoxDC.Text + "', N'"+Them_textBoxSDT.Text+"'";
            MessageBox.Show("Thêm cung cấp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataSet data = new DataSet();
            sql = Function.GetFieldValues(query);
            string sql1 = "SELECT * FROM NHACUNGCAP WHERE MaNCC = '" + sql + "'";
            using (SqlConnection connection = new SqlConnection(Connection.connectionString))
            {
                connection.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql1, connection);
                dap.Fill(data);
                connection.Close();
            }
            dataGridViewXem.DataSource = data.Tables[0];
            Function.FillCombo("SELECT MaNCC FROM NHACUNGCAP", comboBoxMaNCC, "MaNCC", "MaNCC");
            comboBoxMaNCC.SelectedIndex = -1;

            Them_textBoxSDT.Text = "";
            Them_textBoxDC.Text = "";
            Them_textBoxTenNCC.Text = "";
        }

        private void comboBoxMaNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (comboBoxMaNCC.Text == "")
            {
                CapNhat_textBoxTenNCC.Text = "";
                CapNhat_textBoxSDT.Text = "";
                CapNhat_textBoxDiaChi.Text = "";
            }
            str = "SELECT SoDienThoai FROM NHACUNGCAP WHERE MaNCC = N'" + comboBoxMaNCC.SelectedValue + "'";
            CapNhat_textBoxSDT.Text = Function.GetFieldValues(str);

            str = "SELECT DiaChiNCC FROM NHACUNGCAP WHERE MaNCC = N'" + comboBoxMaNCC.SelectedValue + "'";
            CapNhat_textBoxDiaChi.Text = Function.GetFieldValues(str);

            str = "SELECT TenNCC FROM NHACUNGCAP WHERE MaNCC = N'" + comboBoxMaNCC.SelectedValue + "'";
            CapNhat_textBoxTenNCC.Text = Function.GetFieldValues(str);
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            if (comboBoxMaNCC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxMaNCC.Focus();
                return;
            }
            if (CapNhat_textBoxDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CapNhat_textBoxDiaChi.Focus();
                return;
            }
            if (CapNhat_textBoxSDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CapNhat_textBoxSDT.Focus();
                return;
            }
            if (CapNhat_textBoxTenNCC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CapNhat_textBoxTenNCC.Focus();
                return;
            }
            string query = "QT_SUA_NCC N'" + comboBoxMaNCC.SelectedValue + "', N'" + CapNhat_textBoxTenNCC.Text + "', N'" + CapNhat_textBoxDiaChi.Text + "', N'"+CapNhat_textBoxSDT.Text+"'";
            Function.RunSQL(query);
            MessageBox.Show("Cập nhật nhà cung cấp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataSet data = new DataSet();
            string sql1 = "SELECT * FROM NHACUNGCAP WHERE MaNCC = '" + comboBoxMaNCC.SelectedValue + "'";
            using (SqlConnection connection = new SqlConnection(Connection.connectionString))
            {
                connection.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql1, connection);
                dap.Fill(data);
                connection.Close();
            }
            dataGridViewXem.DataSource = data.Tables[0];

            comboBoxMaNCC.Text = "";
            CapNhat_textBoxTenNCC.Text = "";
            CapNhat_textBoxDiaChi.Text = "";
            CapNhat_textBoxSDT.Text = "";
        }

        private void buttonXem_Click(object sender, EventArgs e)
        {
            string query = "QT_XEM_NCC";
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
