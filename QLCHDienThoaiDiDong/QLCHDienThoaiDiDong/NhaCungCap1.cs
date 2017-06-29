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
    public partial class NhaCungCap1 : Form
    {
        DMNhaCungCap ncc = new DMNhaCungCap();
        public NhaCungCap1()
        {
            InitializeComponent();
        }
        public string MANCC { set; get; }
        public string TENNCC { set; get; }
        public string DIACHI { set; get; }
        public string SDT { set; get; }
        public string GHICHU { set; get; }
        public bool THEM { set; get; }
        private void NhaCungCap1_Load(object sender, EventArgs e)
        {
            txtMaNCC.Text = MANCC;
            txtTenNCC.Text = TENNCC;
            txtDiaChi.Text = DIACHI;
            txtSDT.Text = SDT;
            txtGhiChu.Text = GHICHU;
        }
        public bool DEM { set; get; }
        private void btnluu_Click(object sender, EventArgs e)
        {
            if (THEM)
            {
                try
                {
                    if (txtSDT.Text != "")
                    {
                        ncc.ThemNhaCC(int.Parse(txtMaNCC.Text.Trim()), txtTenNCC.Text.Trim(), txtDiaChi.Text.Trim(), txtSDT.Text.Trim(), txtGhiChu.Text.Trim());
                        MessageBox.Show("Thêm nhà cung cấp mới thành công", "Thông báo");
                    }
                    else
                    {
                        ncc.ThemNhaCC(int.Parse(txtMaNCC.Text.Trim()), txtTenNCC.Text.Trim(), txtDiaChi.Text.Trim(),null, txtGhiChu.Text.Trim());
                        MessageBox.Show("Thêm nhà cung cấp mới thành công", "Thông báo");
                    }
                    DEM = true;
                }
                catch
                {
                    MessageBox.Show("Không thêm được nhà cung cấp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (!THEM)
            {
                try
                {
                    if (txtSDT.Text != "")
                    {
                        ncc.CapNhatNhaCC(int.Parse(txtMaNCC.Text), txtTenNCC.Text, txtDiaChi.Text, txtSDT.Text, txtGhiChu.Text);
                        MessageBox.Show("Đã cập nhật nhà cung cấp mới", "Thông báo");
                    }
                    else
                    {
                        ncc.CapNhatNhaCC(int.Parse(txtMaNCC.Text), txtTenNCC.Text, txtDiaChi.Text,null, txtGhiChu.Text);
                        MessageBox.Show("Đã cập nhật nhà cung cấp mới", "Thông báo");
                    }
                }
                catch
                {
                    MessageBox.Show("Không cập nhật được nhà cung cấp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if(DEM==true)
            {
                int DEM2=int.Parse(txtMaNCC.Text)+1;
                txtMaNCC.Text = DEM2.ToString();
                DEM = false;
            }
            txtTenNCC.ResetText();
            txtSDT.ResetText();
            txtGhiChu.ResetText();
            txtDiaChi.ResetText();
            txtTenNCC.Focus();
        }
    }
}
