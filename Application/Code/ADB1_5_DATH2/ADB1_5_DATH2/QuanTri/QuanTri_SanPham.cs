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
    public partial class QuanTri_KiemTraSanPham : Form
    {
        string sql;
        public QuanTri_KiemTraSanPham()
        {
            InitializeComponent();
        }

        private void QuanTri_KiemTraSanPham_Load(object sender, EventArgs e)
        {
            Function.FillCombo("SELECT MaSP FROM SANPHAM", comboBoxMaSP, "MaSP", "MaSP");
            comboBoxMaSP.SelectedIndex = -1;
        }

        private void comboBoxMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (comboBoxMaSP.Text == "")
            {
                CapNhat_textBoxGiaSP.Text = "";
                CapNhat_textBoxMoTa.Text = "";
                CapNhat_textBoxSL.Text = "";
                CapNhat_textBoxTenSP.Text = "";

            }
            str = "SELECT GiaSP FROM SANPHAM WHERE MaSP = N'" + comboBoxMaSP.SelectedValue + "'";
            CapNhat_textBoxGiaSP.Text = Function.GetFieldValues(str);

            str = "SELECT MoTa FROM SANPHAM WHERE MaSP = N'" + comboBoxMaSP.SelectedValue + "'";
            CapNhat_textBoxMoTa.Text = Function.GetFieldValues(str);

            str = "SELECT SoLuong FROM SANPHAM WHERE MaSP = N'" + comboBoxMaSP.SelectedValue + "'";
            CapNhat_textBoxSL.Text = Function.GetFieldValues(str);

            str = "SELECT TenSP FROM SANPHAM WHERE MaSP = N'" + comboBoxMaSP.SelectedValue + "'";
            CapNhat_textBoxTenSP.Text = Function.GetFieldValues(str);
        }

        private void buttonThemSP_Click(object sender, EventArgs e)
        {
            if (Them_textBoxTenSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Them_textBoxTenSP.Focus();
                return;
            }
            if (Them_textBoxGiaSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giá sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Them_textBoxGiaSP.Focus();
                return;
            }
            if (Them_textBoxSoLuong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Them_textBoxSoLuong.Focus();
                return;
            }
            if (Them_textBoxMoTa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mô tả sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Them_textBoxMoTa.Focus();
                return;
            }
            string query = "QT_THEM_SP N'" + Them_textBoxTenSP.Text + "', N'" + Them_textBoxGiaSP.Text + "', N'"+Them_textBoxSoLuong.Text+"', N'"+Them_textBoxMoTa+"'";
            MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataSet data = new DataSet();
            sql = Function.GetFieldValues(query);
            string sql1 = "SELECT * FROM SANPHAM WHERE MaSP = '" + sql + "'";
            using (SqlConnection connection = new SqlConnection(Connection.connectionString))
            {
                connection.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql1, connection);
                dap.Fill(data);
                connection.Close();
            }
            dataGridViewXemTimSP.DataSource = data.Tables[0];

            Them_textBoxGiaSP.Text = "";
            Them_textBoxMoTa.Text = "";
            Them_textBoxSoLuong.Text = "";
            Them_textBoxTenSP.Text = "";
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            if (comboBoxMaSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxMaSP.Focus();
                return;
            }
            if (CapNhat_textBoxTenSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CapNhat_textBoxTenSP.Focus();
                return;
            }
            if (CapNhat_textBoxGiaSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giá sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CapNhat_textBoxGiaSP.Focus();
                return;
            }
            if (CapNhat_textBoxSL.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CapNhat_textBoxSL.Focus();
                return;
            }
            if (CapNhat_textBoxMoTa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mô tả sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CapNhat_textBoxMoTa.Focus();
                return;
            }
            string query = "QT_SUA_SP N'" + comboBoxMaSP.SelectedValue + "', N'" + CapNhat_textBoxTenSP.Text + "', N'" + CapNhat_textBoxGiaSP.Text + "', N'" + CapNhat_textBoxSL.Text + "', N'" + CapNhat_textBoxMoTa.Text + "'";
            Function.RunSQL(query);
            MessageBox.Show("Cập nhật chi nhánh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataSet data = new DataSet();
            string sql1 = "SELECT * FROM SANPHAM WHERE MaSP = '" + comboBoxMaSP.SelectedValue + "'";
            using (SqlConnection connection = new SqlConnection(Connection.connectionString))
            {
                connection.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql1, connection);
                dap.Fill(data);
                connection.Close();
            }
            dataGridViewXemTimSP.DataSource = data.Tables[0];

            comboBoxMaSP.Text = "";
            CapNhat_textBoxTenSP.Text = "";
            CapNhat_textBoxGiaSP.Text = "";
            CapNhat_textBoxSL.Text = "";
            CapNhat_textBoxMoTa.Text = "";
        }

        private void buttonXem_Click(object sender, EventArgs e)
        {
            string query = "QT_XEM_SP";
            Function.RunSQL(query);
            DataSet data = new DataSet();
            using (SqlConnection connection = new SqlConnection(Connection.connectionString))
            {
                connection.Open();
                SqlDataAdapter dap = new SqlDataAdapter(query, connection);
                dap.Fill(data);
                connection.Close();
            }
            dataGridViewXemTimSP.DataSource = data.Tables[0];
        }
    }
}
