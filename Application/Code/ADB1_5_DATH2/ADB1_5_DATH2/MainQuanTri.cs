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
    public partial class MainQuanTri : Form
    {
        public MainQuanTri()
        {
            InitializeComponent();
        }

        private void QuanTri_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxChiNhanh_Click(object sender, EventArgs e)
        {
            ADB1_5_DATH2.QuanTri.QuanTri_ChiNhanh  frm = new ADB1_5_DATH2.QuanTri.QuanTri_ChiNhanh();
            frm.ShowDialog();
        }

        private void btnChiNhanh_Click(object sender, EventArgs e)
        {
            ADB1_5_DATH2.QuanTri.QuanTri_ChiNhanh frm = new ADB1_5_DATH2.QuanTri.QuanTri_ChiNhanh();
            frm.ShowDialog();
        }

        private void pictureBoxHTTT_Click(object sender, EventArgs e)
        {
            ADB1_5_DATH2.QuanTri.QuanTri_HinhThucThanhToan frm = new ADB1_5_DATH2.QuanTri.QuanTri_HinhThucThanhToan();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADB1_5_DATH2.QuanTri.QuanTri_HinhThucThanhToan frm = new ADB1_5_DATH2.QuanTri.QuanTri_HinhThucThanhToan();
            frm.ShowDialog();
        }

        private void pictureBoxKhachHang_Click(object sender, EventArgs e)
        {
            ADB1_5_DATH2.QuanTri.QuanTri_KhachHang frm = new ADB1_5_DATH2.QuanTri.QuanTri_KhachHang();
            frm.ShowDialog();
        }

        private void buttonKhachHang_Click(object sender, EventArgs e)
        {
            ADB1_5_DATH2.QuanTri.QuanTri_KhachHang frm = new ADB1_5_DATH2.QuanTri.QuanTri_KhachHang();
            frm.ShowDialog();
        }

        private void pictureBoxKiemTraSP_Click(object sender, EventArgs e)
        {
            ADB1_5_DATH2.QuanTri.QuanTri_KiemTraSanPham frm = new ADB1_5_DATH2.QuanTri.QuanTri_KiemTraSanPham();
            frm.ShowDialog();
        }

        private void buttonKiemTraSP_Click(object sender, EventArgs e)
        {
            ADB1_5_DATH2.QuanTri.QuanTri_KiemTraSanPham frm = new ADB1_5_DATH2.QuanTri.QuanTri_KiemTraSanPham();
            frm.ShowDialog();
        }

        private void pictureBoxNhaCungCap_Click(object sender, EventArgs e)
        {
            ADB1_5_DATH2.QuanTri.QuanTri_NhaCungCap frm = new ADB1_5_DATH2.QuanTri.QuanTri_NhaCungCap();
            frm.ShowDialog();
        }

        private void buttonNhaCungCap_Click(object sender, EventArgs e)
        {
            ADB1_5_DATH2.QuanTri.QuanTri_NhaCungCap frm = new ADB1_5_DATH2.QuanTri.QuanTri_NhaCungCap();
            frm.ShowDialog();
        }

        private void pictureBoxNhanVien_Click(object sender, EventArgs e)
        {
            ADB1_5_DATH2.QuanTri.QuanTri_NhanVien frm = new ADB1_5_DATH2.QuanTri.QuanTri_NhanVien();
            frm.ShowDialog();
        }

        private void buttonNhanVien_Click(object sender, EventArgs e)
        {
            ADB1_5_DATH2.QuanTri.QuanTri_NhanVien frm = new ADB1_5_DATH2.QuanTri.QuanTri_NhanVien();
            frm.ShowDialog();
        }

        private void buttonNVGH_Click(object sender, EventArgs e)
        {
            ADB1_5_DATH2.QuanTri.QuanTri_NhanVienGiaoHang frm = new ADB1_5_DATH2.QuanTri.QuanTri_NhanVienGiaoHang();
            frm.ShowDialog();
        }

        private void pictureBoxNVGH_Click(object sender, EventArgs e)
        {
            ADB1_5_DATH2.QuanTri.QuanTri_NhanVienGiaoHang frm = new ADB1_5_DATH2.QuanTri.QuanTri_NhanVienGiaoHang();
            frm.ShowDialog();
        }

        private void buttonPhieuDatHang_Click(object sender, EventArgs e)
        {
            ADB1_5_DATH2.QuanTri.QuanTri_PhieuDatHang frm = new ADB1_5_DATH2.QuanTri.QuanTri_PhieuDatHang();
            frm.ShowDialog();
        }

        private void pictureBoxPhieuDatHang_Click(object sender, EventArgs e)
        {
            ADB1_5_DATH2.QuanTri.QuanTri_PhieuDatHang frm = new ADB1_5_DATH2.QuanTri.QuanTri_PhieuDatHang();
            frm.ShowDialog();
        }

        private void buttonSanPham_Click(object sender, EventArgs e)
        {
            ADB1_5_DATH2.QuanTri.QuanTri_KiemTra frm = new ADB1_5_DATH2.QuanTri.QuanTri_KiemTra();
            frm.ShowDialog();
        }
    }
}
