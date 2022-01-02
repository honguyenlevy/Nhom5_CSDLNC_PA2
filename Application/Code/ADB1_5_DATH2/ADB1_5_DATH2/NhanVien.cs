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

namespace ADB1_5_DATH2
{
    public partial class NhanVien : Form
    {
        string sql;

        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            Function.FillCombo("SELECT MaNV FROM NHANVIEN", comboBoxMaNV, "MaNV", "MaNV");
            comboBoxMaNV.SelectedIndex = -1;

            Function.FillCombo("SELECT SoDienThoai FROM KHACHHANG", comboBoxSDTKH, "SoDienThoai", "SoDienThoai");
            comboBoxSDTKH.SelectedIndex = -1;

            Function.FillCombo("SELECT TenHTTT FROM HTTHANHTOAN", comboBoxHTTT, "TenHTTT", "TenHTTT");
            comboBoxHTTT.SelectedIndex = -1;

            Function.FillCombo("SELECT TenSP FROM SANPHAM", comboBoxTenSP, "TenSP", "TenSP");
            comboBoxTenSP.SelectedIndex = -1;

            Function.FillCombo("SELECT MaSP FROM SANPHAM", comboBoxMaSP, "MaSP", "MaSP");
            comboBoxMaSP.SelectedIndex = -1;

            textBoxTongTien.ReadOnly = true;
        }

        DataSet GetAll()
        {
            DataSet data = new DataSet();
            string query = "SELECT * FROM CT_HOADON WHERE MaHD = N'" + sql + "'";
            using (SqlConnection connection = new SqlConnection(Connection.connectionString))
            {
                connection.Open();
                SqlDataAdapter dap = new SqlDataAdapter(query, connection);
                dap.Fill(data);
                connection.Close();
            }
            return data;
        }

        private void LoadDataGridView()
        {
            dataGridViewCTDH.DataSource = GetAll().Tables[0];

        }

        private void buttonThemHD_Click(object sender, EventArgs e)
        {
            if (comboBoxSDTKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxSDTKH.Focus();
                return;
            }
            if (comboBoxHTTT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn tên hình thức thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxHTTT.Focus();
                return;
            }
            if (comboBoxMaNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxMaNV.Focus();
                return;
            }
            string query = "NV_LAP_HD N'" + dateTimeNgayLap.Text + "', N'" + comboBoxHTTT.SelectedValue + "', N'" + comboBoxMaNV.SelectedValue + "', N'" + comboBoxSDTKH.SelectedValue + "'";
            Function.RunSQL(query);
            sql = Function.GetFieldValues(query);
            MessageBox.Show("Bạn đã thêm hóa đơn thành công, bây giờ hãy chọn sản phẩm nha!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonThemSP_Click(object sender, EventArgs e)
        {
            if (comboBoxMaSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxMaSP.Focus();
                return;
            }
            if (textBoxSoLuong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxSoLuong.Focus();
                return;
            }
            string query = "NV_LAP_HD_CT N'" + sql + "', N'" + comboBoxMaSP.SelectedValue + "', N'" + textBoxSoLuong.Text + "'";
            Function.RunSQL(query);
            textBoxTongTien.Text = Function.GetFieldValues("SELECT TongTien FROM HOADON WHERE MaHD = N'" + sql + "'");
            LoadDataGridView();
            MessageBox.Show("Bạn đã thêm sản phẩm vào đơn hàng của mình", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            comboBoxMaSP.Text = "";
            textBoxSoLuong.Text = "";
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            if (comboBoxTenSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxTenSP.Focus();
                return;
            }
            string query = "TIM_SP N'" + comboBoxTenSP.SelectedValue + "'";
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

        private void buttonXemSP_Click(object sender, EventArgs e)
        {
            string query = "XEM_DS_SP";
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

        private void buttonThanhToan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            comboBoxSDTKH.Text = "";
            comboBoxMaNV.Text = "";
            comboBoxHTTT.Text = "";
            comboBoxTenSP.Text = "";
            textBoxTongTien.Text = "";
            textBoxTongTien.Text = "";
            dataGridViewXemTimSP.DataSource = "";
            dataGridViewCTDH.DataSource = "";
        }
    }
}
