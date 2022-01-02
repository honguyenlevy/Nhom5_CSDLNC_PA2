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
    public partial class QuanTri_PhieuDatHang : Form
    {
        string sql;
        public QuanTri_PhieuDatHang()
        {
            InitializeComponent();
        }

        private void QuanTri_PhieuDatHang_Load(object sender, EventArgs e)
        {
            Function.FillCombo("SELECT MaPDH FROM PHIEUDATHANG", comboBoxMaPDH, "MaPDH", "MaPDH");
            comboBoxMaPDH.SelectedIndex = -1;

            Function.FillCombo("SELECT TenNCC FROM NHACUNGCAP", comboBoxTenNCC, "TenNCC", "TenNCC");
            comboBoxTenNCC.SelectedIndex = -1;

            textBoxGia.ReadOnly = true;
        }

        DataSet GetAll()
        {
            DataSet data = new DataSet();
            string query = "SELECT * FROM CT_PHIEUDATHANG WHERE MaPDH = N'" + sql + "'";
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

        private void buttonThemPDH_Click(object sender, EventArgs e)
        {           
            if (comboBoxTenNCC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxTenNCC.Focus();
                return;
            }
            string query = "QT_THEM_PHIEU_DH N'" + dateTimeNgayLap.Text + "', N'" + comboBoxTenNCC.SelectedValue + "'";
            Function.RunSQL(query);
            sql = Function.GetFieldValues(query);
            MessageBox.Show("Bạn đã thêm hóa đơn thành công, bây giờ hãy chọn sản phẩm nha!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Function.FillCombo("QT_XEM_SP_NCC N'"+comboBoxTenNCC.SelectedValue+"'", comboBoxTenSP, "TenSP", "TenSP");
            //Function.FillCombo("SELECT SP.TenSP FROM CUNGCAP_SP CCSP, NHACUNGCAP NCC, SANPHAM SP WHERE NCC.TenNCC = N'"+comboBoxTenNCC.SelectedValue+"'AND NCC.MaNCC = CCSP.MaNCC AND CCSP.MaSP = SP.MaSP", comboBoxTenSP, "TenSP", "TenSP");
            comboBoxTenSP.SelectedIndex = -1;
        }

        private void comboBoxTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (comboBoxTenSP.Text == "")
            {
                textBoxGia.Text = "";
            }
            str = "SELECT (GiaSP - 20000) FROM SANPHAM WHERE TenSP = N'" + comboBoxTenSP.SelectedValue + "'";
            textBoxGia.Text = Function.GetFieldValues(str);
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
            
            string query = "QT_THEM_CT_PHIEU_DH N'" + sql + "', N'" + comboBoxTenSP.SelectedValue + "', N'" + textBoxSoLuong.Text + "', N'"+textBoxGia.Text+"'";
            Function.RunSQL(query);
            LoadDataGridView();
            MessageBox.Show("Bạn đã thêm sản phẩm vào phiếu đặt hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            comboBoxTenSP.Text = "";
            textBoxSoLuong.Text = "";
            textBoxGia.Text = "";
        }

        private void buttonXemSP_Click(object sender, EventArgs e)
        {
            string query = "QT_XEM_PHIEU_DH";
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

        private void buttonDatHang_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đặt hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            comboBoxTenNCC.Text = "";
            comboBoxTenSP.Text = "";
            textBoxSoLuong.Text = "";
            textBoxGia.Text = "";            
        }

        private void textBoxGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonXemPGH_Click(object sender, EventArgs e)
        {
            if (comboBoxMaPDH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã phiếu đặt hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxMaPDH.Focus();
                return;
            }
            string query = "QT_XEM_PGH_PDH N'" + comboBoxMaPDH.SelectedValue + "'";
            QuanTri_XemPhieuGiaoHang frm = new QuanTri_XemPhieuGiaoHang(query);
            frm.ShowDialog();
        }
    }
}
