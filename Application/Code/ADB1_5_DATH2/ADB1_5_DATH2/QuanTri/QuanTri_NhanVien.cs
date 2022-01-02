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
    public partial class QuanTri_NhanVien : Form
    {
        string sql;

        public QuanTri_NhanVien()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void QuanTri_NhanVien_Load(object sender, EventArgs e)
        {
            Function.FillCombo("SELECT MaCN FROM CHINHANH", Them_comboBoxMaChiNhanh, "MaCN", "MaCN");
            Them_comboBoxMaChiNhanh.SelectedIndex = -1;

            Function.FillCombo("SELECT MaCN FROM CHINHANH", CapNhat_comboBoxMaCN, "MaCN", "MaCN");
            CapNhat_comboBoxMaCN.SelectedIndex = -1;

            CapNhat_textBoxCMND.ReadOnly = true;
        }

        private void buttonXemNVCN_Click(object sender, EventArgs e)
        {
            if (Them_comboBoxMaChiNhanh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã chi nhánh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Them_comboBoxMaChiNhanh.Focus();
                return;
            }
            string query = "NHANVIEN_CHINHANH N'"+Them_comboBoxMaChiNhanh.SelectedValue+"'";
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

        private void buttonThemNV_Click(object sender, EventArgs e)
        {
            if (Them_comboBoxMaChiNhanh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã chi nhánh để thêm nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Them_comboBoxMaChiNhanh.Focus();
                return;
            }
            if (Them_textBoxTenNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Them_textBoxTenNV.Focus();
                return;
            }
            if (Them_textBoxSDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Them_textBoxSDT.Focus();
                return;
            }
            if (Them_textBoxCMND.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập CMND của nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Them_textBoxCMND.Focus();
                return;
            }
            if (Them_textBoxDC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ của nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Them_textBoxDC.Focus();
                return;
            }
            if (Them_textBoxEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập email của nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Them_textBoxEmail.Focus();
                return;
            }
            string query = "QT_THEM_NV N'" + Them_textBoxTenNV.Text + "', N'" + Them_textBoxCMND.Text + "', N'"+Them_textBoxDC.Text+ "', N'"+Them_textBoxSDT.Text+ "', N'"+Them_textBoxEmail.Text+ "', N'"+Them_comboBoxMaChiNhanh.Text+"'";
            //Function.RunSQL(query);
            
            DataSet data = new DataSet();
            sql = Function.GetFieldValues(query);
            string sql1 = "SELECT * FROM NHANVIEN WHERE MaNV = '" + sql + "'";
            using (SqlConnection connection = new SqlConnection(Connection.connectionString))
            {
                connection.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql1, connection);
                dap.Fill(data);
                connection.Close();
            }
            dataGridViewXem.DataSource = data.Tables[0];

            MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Function.FillCombo("SELECT MaCN FROM CHINHANH", CapNhat_comboBoxMaCN, "MaCN", "MaCN");
            CapNhat_comboBoxMaCN.SelectedIndex = -1;

            Them_textBoxTenNV.Text = "";
            Them_textBoxCMND.Text = "";
            Them_textBoxDC.Text = "";
            Them_textBoxSDT.Text = "";
            Them_textBoxEmail.Text = "";
            Them_comboBoxMaChiNhanh.Text = "";
        }

        private void CapNhat_comboBoxMaCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            Function.FillCombo("SELECT MaNV FROM NHANVIEN WHERE MaCN = N'"+CapNhat_comboBoxMaCN.SelectedValue+"'", CapNhat_comboBoxMaNV, "MaNV", "MaNV");
            CapNhat_comboBoxMaNV.SelectedIndex = -1;
        }

        private void CapNhat_comboBoxMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (CapNhat_comboBoxMaNV.Text == "")
            {
                CapNhat_textBoxTenNV.Text = "";
                CapNhat_textBoxDC.Text = "";
                CapNhat_textBoxCMND.Text = "";
                CapNhat_textBoxEmail.Text = "";
                CapNhat_textBoxSDT.Text = "";
            }
            str = "SELECT SoDienThoai FROM NHANVIEN WHERE MaNV = N'" + CapNhat_comboBoxMaNV.SelectedValue + "'";
            CapNhat_textBoxSDT.Text = Function.GetFieldValues(str);

            str = "SELECT DiaChi FROM NHANVIEN WHERE MaNV = N'" + CapNhat_comboBoxMaNV.SelectedValue + "'";
            CapNhat_textBoxDC.Text = Function.GetFieldValues(str);

            str = "SELECT CMND FROM NHANVIEN WHERE MaNV = N'" + CapNhat_comboBoxMaNV.SelectedValue + "'";
            CapNhat_textBoxCMND.Text = Function.GetFieldValues(str);

            str = "SELECT Email FROM NHANVIEN WHERE MaNV = N'" + CapNhat_comboBoxMaNV.SelectedValue + "'";
            CapNhat_textBoxEmail.Text = Function.GetFieldValues(str);

            str = "SELECT TenNV FROM NHANVIEN WHERE MaNV = N'" + CapNhat_comboBoxMaNV.SelectedValue + "'";
            CapNhat_textBoxTenNV.Text = Function.GetFieldValues(str);
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            if (CapNhat_comboBoxMaCN.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã chi nhánh ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CapNhat_comboBoxMaCN.Focus();
                return;
            }
            if(CapNhat_comboBoxMaNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã nhân viên ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CapNhat_comboBoxMaNV.Focus();
                return;
            }
            if (CapNhat_textBoxTenNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CapNhat_textBoxTenNV.Focus();
                return;
            }
            if (CapNhat_textBoxSDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CapNhat_textBoxSDT.Focus();
                return;
            }
            if (CapNhat_textBoxCMND.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập CMND của nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CapNhat_textBoxCMND.Focus();
                return;
            }
            if (CapNhat_textBoxDC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ của nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Them_textBoxDC.Focus();
                return;
            }
            if (CapNhat_textBoxEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập email của nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CapNhat_textBoxEmail.Focus();
                return;
            }
            string query = "QT_SUA_NV N'" + CapNhat_comboBoxMaNV.SelectedValue + "', N'" + CapNhat_textBoxTenNV.Text + "', N'" + CapNhat_textBoxCMND.Text + "', N'" + CapNhat_textBoxDC.Text + "', N'" + CapNhat_textBoxSDT.Text + "', N'" + CapNhat_textBoxEmail.Text + "', N'" + CapNhat_comboBoxMaCN.SelectedValue + "'";
            Function.RunSQL(query);
            MessageBox.Show("Cập nhật nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataSet data = new DataSet();
            string sql1 = "SELECT * FROM NHANVIEN WHERE MaNV = '" + CapNhat_comboBoxMaNV.SelectedValue + "' AND MaCN = N'"+CapNhat_comboBoxMaCN.SelectedValue+"'";
            using (SqlConnection connection = new SqlConnection(Connection.connectionString))
            {
                connection.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql1, connection);
                dap.Fill(data);
                connection.Close();
            }
            dataGridViewXem.DataSource = data.Tables[0];

            CapNhat_comboBoxMaNV.Text = "";
            CapNhat_textBoxTenNV.Text = "";
            CapNhat_textBoxCMND.Text = "";
            CapNhat_textBoxDC.Text = "";
            CapNhat_textBoxSDT.Text = "";
            CapNhat_textBoxEmail.Text = "";
            CapNhat_comboBoxMaCN.Text = "";
        }

        private void buttonXem_Click(object sender, EventArgs e)
        {
            string query = "QT_XEM_NV";
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
