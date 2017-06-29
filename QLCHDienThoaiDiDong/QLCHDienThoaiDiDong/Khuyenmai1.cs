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
    public partial class Khuyenmai1 : Form
    {
        DMKhuyenMai KM = new DMKhuyenMai();
        public Khuyenmai1()
        {
            InitializeComponent();
        }
        public string MAKM { set; get; }
        public string THONGTIN { set; get; }
        public string GIATRI { set; get; }
        public string NGAYBATDAU { set; get; }
        public string NGAYKETTHUC { set; get; }
        public string GHICHU { set; get; }
        public bool THEM { set; get; }
        private void Khuyenmai1_Load(object sender, EventArgs e)
        {
            txtmakm.Text = MAKM;
            txtthongtin.Text = THONGTIN;
            txtgiatri.Text = GIATRI;
            dtpngaybd.Text = NGAYBATDAU;
            dtpngaykt.Text = NGAYKETTHUC;
            txtghichu.Text = GHICHU;
        }
        public bool Dem { set; get; }
        private void btluu_Click(object sender, EventArgs e)
        {
            if (THEM)
            {
                try
                {
                    KM.ThemKhuyenMai(int.Parse(txtmakm.Text.Trim()), txtthongtin.Text.Trim(),float.Parse(txtgiatri.Text.Trim()),DateTime.Parse(dtpngaybd.Text.Trim()),DateTime.Parse(dtpngaykt.Text.Trim()),txtghichu.Text.Trim());
                    MessageBox.Show("Thêm khuyến mãi mới thành công", "Thông báo");
                    Dem = true;
                }
                catch
                {
                    MessageBox.Show("Không thêm được khuyến mãi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (!THEM)
            {
                try
                {
                    KM.CapNhatKhuyenMai(int.Parse(txtmakm.Text), txtthongtin.Text, float.Parse(txtgiatri.Text), DateTime.Parse(dtpngaybd.Text), DateTime.Parse(dtpngaykt.Text), txtghichu.Text);
                    MessageBox.Show("Đã cập nhật khuyến mãi mới", "Thông báo");
                }
                catch
                {
                    MessageBox.Show("Không cập nhật được khuyến mãi.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if(Dem==true)
            {
                int dem1 = int.Parse(txtmakm.Text) + 1;
                txtmakm.Text = dem1.ToString();
                Dem = false;
            }
            txtgiatri.ResetText();
            txtghichu.ResetText();
            txtthongtin.ResetText();
            dtpngaybd.ResetText();
            dtpngaykt.ResetText();
            txtthongtin.Focus();
        }
    }
}
