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
    public partial class KhachHang : Form
    {
        string sql;

        public KhachHang()
        {
            InitializeComponent();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            Function.FillCombo("SELECT MaKH FROM KHACHHANG", comboBoxMaKH, "MaKH", "MaKH");
            comboBoxMaKH.SelectedIndex = -1;

            Function.FillCombo("SELECT TenHTTT FROM HTTHANHTOAN", comboBoxHTTT, "TenHTTT", "TenHTTT");
            comboBoxHTTT.SelectedIndex = -1;

            Function.FillCombo("SELECT TenSP FROM SANPHAM", comboBoxTenSP, "TenSP", "TenSP");
            comboBoxTenSP.SelectedIndex = -1;

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
            if (comboBoxMaKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxMaKH.Focus();
                return;
            }
            if (comboBoxHTTT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn tên hình thức thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxHTTT.Focus();
                return;
            }
            if(textBoxDiaChiGH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên địa chỉ giao hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxDiaChiGH.Focus();
                return;
            }
            string query = "KH_DAT_HANG N'" + dateTimeNgayMua.Text + "', N'" + comboBoxMaKH.SelectedValue + "', N'" + comboBoxHTTT.SelectedValue + "', N'" + textBoxDiaChiGH.Text + "'";
            Function.RunSQL(query);
            sql = Function.GetFieldValues(query);
            MessageBox.Show("Bạn đã thêm hóa đơn thành công, bây giờ hãy chọn sản phẩm nha!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonThemSP_Click(object sender, EventArgs e)
        {
            if (comboBoxTenSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxTenSP.Focus();
                return;
            }
            if (textBoxSoLuong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxSoLuong.Focus();
                return;
            }
            string query = "KH_DAT_HANG_CT N'" + sql + "', N'" + comboBoxTenSP.SelectedValue + "', N'" + textBoxSoLuong.Text + "'";
            Function.RunSQL(query);
            textBoxTongTien.Text = Function.GetFieldValues("SELECT TongTien FROM HOADON WHERE MaHD = N'"+sql+"'");
            LoadDataGridView();
            MessageBox.Show("Bạn đã thêm sản phẩm vào đơn hàng của mình", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            comboBoxTenSP.Text = "";
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

        private void buttonDatHang_Click(object sender, EventArgs e)
        {
            comboBoxMaKH.Text = "";
            textBoxDiaChiGH.Text = "";
            comboBoxHTTT.Text = "";
            comboBoxTenSP.Text = "";
            textBoxTongTien.Text = "";
            textBoxTongTien.Text = "";
            dataGridViewXemTimSP.DataSource = "";
            dataGridViewCTDH.DataSource = "";
        }

        private void buttonXemDGH_Click(object sender, EventArgs e)
        {
            if (comboBoxMaKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxMaKH.Focus();
                return;
            }
            string query = "KH_XEM_DGH N'" + comboBoxMaKH.SelectedValue + "'";
            KhachHangXemDonGiaoHang frm = new KhachHangXemDonGiaoHang(query);
            frm.ShowDialog();

        }
    }
}
