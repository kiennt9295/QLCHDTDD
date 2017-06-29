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
    public partial class Baohanh1 : Form
    {
        DMBaoHanh bh = new DMBaoHanh();
        public Baohanh1()
        {
            InitializeComponent();
        }
        public string MABH { set; get; }
        public string TENKH { set; get; }
        public string NGAYNHAN { set; get; }
        public string NGAYTRA { set; get; }
        public string DIENTHOAI { set; get; }
        public string MAMH { set; get; }
        public string MANV { set; get; }
        public string YEUCAU { set; get; }
        public string GHICHHU { set; get; }
        public bool DATRA { set; get; }
        public bool THEM { set; get; }
        private void Baohanh1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCHDienThoaiDDDataSet14.MATHANG' table. You can move, or remove it, as needed.
            //this.mATHANGTableAdapter.Fill(this.qLCHDienThoaiDDDataSet14.MATHANG);
            // TODO: This line of code loads data into the 'qLCHDienThoaiDDDataSet5.NHANVIEN' table. You can move, or remove it, as needed.
            //this.nHANVIENTableAdapter1.Fill(this.qLCHDienThoaiDDDataSet5.NHANVIEN);
           
            
            txtmabh.Text =MABH;
            txttenbh.Text = TENKH;
            txtdienthoai.Text = DIENTHOAI;
            txtyeucau.Text = YEUCAU;
            txtghichu.Text = GHICHHU;
            dtpngaynhan.Text = NGAYNHAN;
            dtpngaytra.Text = NGAYTRA;
            luemathang.Text = MAMH;
            luenhanvien.Text = MANV;
            chkdatra.Checked = DATRA;
        }

        public bool dem { set; get; }
        private void btnluu_Click_1(object sender, EventArgs e)
        {
            if (THEM)
            {
                try
                {
                    if (txtdienthoai.Text != "")
                    {
                        bh.ThemBaoHanh(int.Parse(txtmabh.Text.Trim()), DateTime.Parse(dtpngaynhan.Text.Trim()), txttenbh.Text.Trim(), txtdienthoai.Text.Trim(), int.Parse(luemathang.Text.Trim()),
                                       int.Parse(luenhanvien.Text.Trim()), txtyeucau.Text.Trim(), DateTime.Parse(dtpngaytra.Text.Trim()), txtghichu.Text.Trim(), chkdatra.Checked);
                        MessageBox.Show("Thêm phiếu bảo hành mới thành công", "Thông báo");
                        dem = true;
                    }
                    else
                    {
                        bh.ThemBaoHanh(int.Parse(txtmabh.Text.Trim()), DateTime.Parse(dtpngaynhan.Text.Trim()), txttenbh.Text.Trim(),null, int.Parse(luemathang.Text.Trim()),
                                       int.Parse(luenhanvien.Text.Trim()), txtyeucau.Text.Trim(), DateTime.Parse(dtpngaytra.Text.Trim()), txtghichu.Text.Trim(), chkdatra.Checked);
                        MessageBox.Show("Thêm phiếu bảo hành mới thành công", "Thông báo");
                        dem = true;
                    }
                }
                catch
                {
                    MessageBox.Show("Không thêm được phiếu bảo hành", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (!THEM)
            {
                try
                {
                    if (txtdienthoai.Text != "")
                    {
                        bh.CapNhatBaoHanh(int.Parse(txtmabh.Text), DateTime.Parse(dtpngaynhan.Text), txttenbh.Text, txtdienthoai.Text, int.Parse(luemathang.Text),
                                       int.Parse(luenhanvien.Text), txtyeucau.Text, DateTime.Parse(dtpngaytra.Text), txtghichu.Text, chkdatra.Checked);
                        MessageBox.Show("Đã cập nhật phiếu bảo hành mới", "Thông báo");
                    }
                    else
                    {
                        bh.CapNhatBaoHanh(int.Parse(txtmabh.Text), DateTime.Parse(dtpngaynhan.Text), txttenbh.Text,null, int.Parse(luemathang.Text),
                                       int.Parse(luenhanvien.Text), txtyeucau.Text, DateTime.Parse(dtpngaytra.Text), txtghichu.Text, chkdatra.Checked);
                        MessageBox.Show("Đã cập nhật phiếu bảo hành mới", "Thông báo");
                    }
                }
                catch
                {
                    MessageBox.Show("Không cập nhật được phiếu bảo hành.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            if (dem == true)
            {
                int dem1 = int.Parse(txtmabh.Text) + 1;
                txtmabh.Text = dem1.ToString();
                dem = false;
            }
            txttenbh.ResetText();
            txtdienthoai.ResetText();
            txtyeucau.ResetText();
            txtghichu.ResetText();
            txttenbh.Focus();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
