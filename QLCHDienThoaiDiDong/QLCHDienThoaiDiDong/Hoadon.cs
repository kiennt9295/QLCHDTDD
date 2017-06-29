using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BAL;

namespace QLCHDienThoaiDiDong
{
    public partial class Hoadon : Form
    {
        DMHoaDon HD = new DMHoaDon();
        public Hoadon()
        {
            InitializeComponent();
        }
        public string MAHD { set; get; }
        public int SOLUONG { set; get; }
        public string MAKH { set; get; }
        public string NGAYLAP { set; get; }
        public string MANV { set; get; }
        public float TONGTIEN { set; get; }
        public bool THEM { set; get; }

        private void Hoadon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCHDienThoaiDDDataSet5.NHANVIEN' table. You can move, or remove it, as needed.
            //this.nHANVIENTableAdapter.Fill(this.qLCHDienThoaiDDDataSet5.NHANVIEN);
            // TODO: This line of code loads data into the 'qLCHDienThoaiDDDataSet6.KHACHHANG' table. You can move, or remove it, as needed.
            //this.kHACHHANGTableAdapter.Fill(this.qLCHDienThoaiDDDataSet6.KHACHHANG);
            txtMaHD.Text = MAHD;
            txtSL.Text = SOLUONG.ToString();
            lueKH.Text = MAKH;
            dtpNgayLap.Text = NGAYLAP;
            lueNV.Text = MANV;
            txtTongTien.Text = TONGTIEN.ToString();
            
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool DEM { set; get; }
        private void btnluu_Click(object sender, EventArgs e)
        {
            if (THEM)
            {
                try
                {
                    HD.ThemHoaDon(int.Parse(txtMaHD.Text.Trim()),txtSL.Text.Trim(),int.Parse(lueKH.Text.Trim()),DateTime.Parse(dtpNgayLap.Text.Trim()),int.Parse(lueNV.Text.Trim()),txtTongTien.Text.Trim());
                    MessageBox.Show("Thêm hóa đơn mới thành công", "Thông báo");
                    DEM = true;
                }
                catch
                {
                    MessageBox.Show("Không thêm được hóa đơn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (!THEM)
            {
                try
                {
                    HD.CapNhatHoaDon(int.Parse(txtMaHD.Text), int.Parse(txtSL.Text), int.Parse(lueKH.Text), DateTime.Parse(dtpNgayLap.Text), int.Parse(lueNV.Text), float.Parse(txtTongTien.Text));
                    MessageBox.Show("Đã cập nhật hóa đơn mới", "Thông báo");
                }
                catch
                {
                    MessageBox.Show("Không cập nhật được hóa đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            if(DEM==true)
            {
                int DEM2 = int.Parse(txtMaHD.Text) + 1;
                txtMaHD.Text = DEM2.ToString();
                DEM = false;
            }
            dtpNgayLap.ResetText();
            txtSL.Focus();
        }
    }
}
