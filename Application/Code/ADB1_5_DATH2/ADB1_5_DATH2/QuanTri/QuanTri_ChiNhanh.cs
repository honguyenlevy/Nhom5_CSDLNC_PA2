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
    public partial class QuanTri_ChiNhanh : Form
    {
        string sql;
        public QuanTri_ChiNhanh()
        {
            InitializeComponent();
        }

        private void QuanTri_ChiNhanh_Load(object sender, EventArgs e)
        {
            Function.FillCombo("SELECT MaCN FROM CHINHANH", comboBoxMaCN, "MaCN", "MaCN");
            comboBoxMaCN.SelectedIndex = -1;
        }

        private void buttonThemCN_Click(object sender, EventArgs e)
        {
            if (Them_textBoxDiaChiCN.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ chi nhánh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Them_textBoxDiaChiCN.Focus();
                return;
            }
            if (Them_textBoxSDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại chi nhánh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Them_textBoxSDT.Focus();
                return;
            }
            string query = "QT_THEM_CN N'" + Them_textBoxDiaChiCN.Text + "', N'" + Them_textBoxSDT.Text + "'";
            MessageBox.Show("Thêm chi nhánh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataSet data = new DataSet();
            sql = Function.GetFieldValues(query);
            string sql1 = "SELECT * FROM CHINHANH WHERE MaCN = '" + sql + "'";
            using (SqlConnection connection = new SqlConnection(Connection.connectionString))
            {
                connection.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql1, connection);
                dap.Fill(data);
                connection.Close();
            }
            dataGridViewXemTimSP.DataSource = data.Tables[0];

            Function.FillCombo("SELECT MaCN FROM CHINHANH", comboBoxMaCN, "MaCN", "MaCN");
            comboBoxMaCN.SelectedIndex = -1;

            Them_textBoxDiaChiCN.Text = "";
            Them_textBoxSDT.Text = "";
        }

        private void comboBoxMaCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (comboBoxMaCN.Text == "")
            {
                CapNhat_textBoxDiaChiCN.Text = "";
                CapNhat_textBoxSDT.Text = "";
            }
            str = "SELECT SoDienThoai FROM CHINHANH WHERE MaCN = N'" + comboBoxMaCN.SelectedValue + "'";
            CapNhat_textBoxSDT.Text = Function.GetFieldValues(str);

            str = "SELECT DiaChiCN FROM CHINHANH WHERE MaCN = N'" + comboBoxMaCN.SelectedValue + "'";
            CapNhat_textBoxDiaChiCN.Text = Function.GetFieldValues(str);
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            if (comboBoxMaCN.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã chi nhánh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxMaCN.Focus();
                return;
            }
            if (CapNhat_textBoxDiaChiCN.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ chi nhánh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CapNhat_textBoxDiaChiCN.Focus();
                return;
            }
            if (CapNhat_textBoxSDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại chi nhánh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CapNhat_textBoxSDT.Focus();
                return;
            }
            string query = "QT_SUA_CN N'" + comboBoxMaCN.SelectedValue + "', N'" + CapNhat_textBoxDiaChiCN.Text + "', N'" + CapNhat_textBoxSDT.Text + "'";
            Function.RunSQL(query);
            MessageBox.Show("Cập nhật chi nhánh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataSet data = new DataSet();
            string sql1 = "SELECT * FROM CHINHANH WHERE MaCN = '" + comboBoxMaCN.SelectedValue + "'";
            using (SqlConnection connection = new SqlConnection(Connection.connectionString))
            {
                connection.Open();
                SqlDataAdapter dap = new SqlDataAdapter(sql1, connection);
                dap.Fill(data);
                connection.Close();
            }
            dataGridViewXemTimSP.DataSource = data.Tables[0];

            comboBoxMaCN.Text = "";
            CapNhat_textBoxDiaChiCN.Text = "";
            CapNhat_textBoxSDT.Text = "";
        }

        private void buttonXem_Click(object sender, EventArgs e)
        {
            string query = "QT_XEM_CN";
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
