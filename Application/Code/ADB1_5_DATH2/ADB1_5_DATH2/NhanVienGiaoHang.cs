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
    public partial class NhanVienGiaoHang : Form
    {
        public NhanVienGiaoHang()
        {
            InitializeComponent();
        }

        private void NhanVienGiaoHang_Load(object sender, EventArgs e)
        {
            Function.FillCombo("SELECT MaNVGH FROM NV_GIAOHANG", comboBoxMaNV, "MaNVGH", "MaNVGH");
            comboBoxMaNV.SelectedIndex = -1;

            Function.FillCombo("SELECT MaDGHK FROM DONGH_KHACH WHERE MaNVGH IS NULL ", comboBoxMaDGH, "MaDGHK", "MaDGHK");
            comboBoxMaDGH.SelectedIndex = -1;

            Function.FillCombo("SELECT MaDGHK FROM DONGH_KHACH WHERE MaNVGH = N'"+ comboBoxMaNV.SelectedValue+ "'", comboBoxCapNhatMaDGH, "MaDGHK", "MaDGHK");
            comboBoxCapNhatMaDGH.SelectedIndex = -1;

            Function.FillCombo("SELECT distinct TinhTrangGiao FROM DONGH_KHACH", comboBoxTinhTrang, "TinhTrangGiao", "TinhTrangGiao");
            comboBoxTinhTrang.SelectedIndex = -1;
        }

        DataSet GetAll()
        {
            DataSet data = new DataSet();
            string query = "SELECT * FROM DONGH_KHACH WHERE MaDGHK = N'"+comboBoxMaDGH.SelectedValue+"' AND MaNVGH = N'"+comboBoxMaNV.SelectedValue+"'";
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
            dataGridViewDonHang.DataSource = GetAll().Tables[0];

        }

        private void buttonTimDonGiao_Click(object sender, EventArgs e)
        {
            string query = "NVGH_TIM_DONGH";
            Function.RunSQL(query);
            DataSet data = new DataSet();
            using (SqlConnection connection = new SqlConnection(Connection.connectionString))
            {
                connection.Open();
                SqlDataAdapter dap = new SqlDataAdapter(query, connection);
                dap.Fill(data);
                connection.Close();
            }
            dataGridViewDonHang.DataSource = data.Tables[0];
        }

        private void btnNhanDon_Click(object sender, EventArgs e)
        {
            if (comboBoxMaDGH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã đơn giao hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxMaDGH.Focus();
                return;
            }
            if (comboBoxMaNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã nhân viên giao hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxMaNV.Focus();
                return;
            }
            string query = "NVGH_NHAN_DONGH N'"+comboBoxMaNV.SelectedValue+"', N'"+comboBoxMaDGH.SelectedValue+"'";
            Function.RunSQL(query);
            LoadDataGridView();

            Function.FillCombo("SELECT MaDGHK FROM DONGH_KHACH WHERE MaNVGH = N'" + comboBoxMaNV.SelectedValue + "'", comboBoxCapNhatMaDGH, "MaDGHK", "MaDGHK");
            comboBoxCapNhatMaDGH.SelectedIndex = -1;

            MessageBox.Show("Nhận đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            comboBoxMaDGH.Text = "";

            Function.FillCombo("SELECT MaDGHK FROM DONGH_KHACH WHERE MaNVGH IS NULL ", comboBoxMaDGH, "MaDGHK", "MaDGHK");
            comboBoxMaDGH.SelectedIndex = -1;
        }

        private void btnXemDH_Click(object sender, EventArgs e)
        {
            if(comboBoxMaNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã nhân viên giao hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxMaNV.Focus();
                return;
            }
            string query = "NVGH_XEM_DONGH N'" + comboBoxMaNV.SelectedValue + "'";
            Function.RunSQL(query);
            DataSet data = new DataSet();
            using (SqlConnection connection = new SqlConnection(Connection.connectionString))
            {
                connection.Open();
                SqlDataAdapter dap = new SqlDataAdapter(query, connection);
                dap.Fill(data);
                connection.Close();
            }
            dataGridViewDonHang.DataSource = data.Tables[0];
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            if (comboBoxCapNhatMaDGH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã đơn giao hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxCapNhatMaDGH.Focus();
                return;
            }
            if (comboBoxMaNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã nhân viên giao hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxMaNV.Focus();
                return;
            }
            if (comboBoxTinhTrang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn tình trạng đơn hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxTinhTrang.Focus();
                return;
            }
            string query = "NVGH_CAP_NHAT_DONGH N'" + comboBoxMaNV.SelectedValue + "', N'" + comboBoxCapNhatMaDGH.SelectedValue + "', N'"+comboBoxTinhTrang.SelectedValue+"'";
            Function.RunSQL(query);
            DataSet data = new DataSet();
            using (SqlConnection connection = new SqlConnection(Connection.connectionString))
            {
                connection.Open();
                SqlDataAdapter dap = new SqlDataAdapter(query, connection);
                dap.Fill(data);
                connection.Close();
            }
            dataGridViewDonHang.DataSource = data.Tables[0];

            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            comboBoxCapNhatMaDGH.Text = "";
            comboBoxTinhTrang.Text = "";
        }
    }
}
