using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADB1_5_DATH2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Function.Connect();
        }

        private void pictureBoxKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang frm = new KhachHang();
            frm.ShowDialog();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang frm = new KhachHang();
            frm.ShowDialog();
        }

        private void pictureBoxNhanVien_Click(object sender, EventArgs e)
        {
            NhanVien frm = new NhanVien();
            frm.ShowDialog();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            NhanVien frm = new NhanVien();
            frm.ShowDialog();
        }

        private void pictureBoxNhanVienGH_Click(object sender, EventArgs e)
        {
            NhanVienGiaoHang frm = new NhanVienGiaoHang();
            frm.ShowDialog();
        }

        private void btnNhanVienGH_Click(object sender, EventArgs e)
        {
            NhanVienGiaoHang frm = new NhanVienGiaoHang();
            frm.ShowDialog();
        }

        private void pictureBoxQuanTri_Click(object sender, EventArgs e)
        {
            MainQuanTri frm = new MainQuanTri();
            frm.ShowDialog();
        }

        private void btnQuanTri_Click(object sender, EventArgs e)
        {
            MainQuanTri frm = new MainQuanTri();
            frm.ShowDialog();
        }
    }
}
