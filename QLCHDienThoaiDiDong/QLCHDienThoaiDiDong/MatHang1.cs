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
using System.IO;

namespace QLCHDienThoaiDiDong
{
    public partial class MatHang1 : Form
    {
        MemoryStream ms;
        byte[] arrImage;
        DMMatHang mh = new DMMatHang();
        public MatHang1()
        {
            InitializeComponent();
        }
        public string MAMH { set; get; }
        public string TENMH { set; get; }
        public string HANGSX { set; get; }
        public string GIABAN { set; get; }
        public string GIAMUA { set; get; }
        public int BAOHANH { set; get; }
        public string KHUYENMAI { set; get; }
        public string DONVITINH { set; get; }
        public string SOLUONG { set; get; }
        public string DACDIEM { set; get; }
        public string GHICHU { set; get; }
        public Image HINH { set; get; }
        public string LOAIMH { set; get; }
        public bool THEM { set; get; }

        private void MatHang1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCHDienThoaiDDDataSet17.KHUYENMAI' table. You can move, or remove it, as needed.
            //this.kHUYENMAITableAdapter.Fill(this.qLCHDienThoaiDDDataSet17.KHUYENMAI);
            txtMamh.Text = MAMH;
            txttenmh.Text = TENMH;
            txthangsx.Text = HANGSX;
            txtgiaban.Text = GIABAN;
            txtgiamua.Text = GIAMUA;
            txtbaohanh.Text = BAOHANH.ToString();
            luekhuyenmai.Text =KHUYENMAI;
            cbbDVT.Text = DONVITINH;
            txtSoluong.Text = SOLUONG;
            txtDacDiem.Text = DACDIEM;
            txtGhiChu.Text = GHICHU;
            picHINH.Image =HINH ;
            cbbLoaiMH.Text = LOAIMH;
        }

        private void btnlayhinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog odlgOpenFile = new OpenFileDialog();
            odlgOpenFile.InitialDirectory = "C:\\";
            odlgOpenFile.Title = "Open File";
            odlgOpenFile.Filter = "Image files (*.jpg)|*.jpg|All files (*.*)|*.*";
            if (odlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                picHINH.Image = System.Drawing.Image.FromFile(odlgOpenFile.FileName);
                //
                ms = new MemoryStream();
                picHINH.Image.Save(ms, picHINH.Image.RawFormat);
                arrImage = ms.GetBuffer();
                ms.Close();
            }
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
                    if (luekhuyenmai.Text != "")
                    {
                        mh.Themmathang(int.Parse(txtMamh.Text.Trim()), txttenmh.Text.Trim(), txthangsx.Text.Trim(), double.Parse(txtgiamua.Text.Trim()), int.Parse(txtgiaban.Text.Trim()), cbbDVT.Text.Trim(),
                                        int.Parse(txtbaohanh.Text.Trim()), luekhuyenmai.Text.Trim(), txtDacDiem.Text.Trim(), int.Parse(txtSoluong.Text.Trim()), arrImage, txtGhiChu.Text.Trim(), cbbLoaiMH.Text.Trim());
                        MessageBox.Show("Thêm mặt hàng mới thành công", "Thông báo");
                    }
                    else
                    {
                        mh.Themmathang(int.Parse(txtMamh.Text.Trim()), txttenmh.Text.Trim(), txthangsx.Text.Trim(), double.Parse(txtgiamua.Text.Trim()), int.Parse(txtgiaban.Text.Trim()), cbbDVT.Text.Trim(),
                                       int.Parse(txtbaohanh.Text.Trim()),null, txtDacDiem.Text.Trim(), int.Parse(txtSoluong.Text.Trim()), arrImage, txtGhiChu.Text.Trim(), cbbLoaiMH.Text.Trim());
                        MessageBox.Show("Thêm mặt hàng mới thành công", "Thông báo");
                    }
                    DEM = true;
                }
                catch
                {
                    MessageBox.Show("Không thêm được mặt hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (!THEM)
            {
                try
                {
                    if (luekhuyenmai.Text != "")
                    {
                        mh.Capnhatmathang(int.Parse(txtMamh.Text), txttenmh.Text, txthangsx.Text, double.Parse(txtgiamua.Text), int.Parse(txtgiaban.Text), cbbDVT.Text,
                                        int.Parse(txtbaohanh.Text), luekhuyenmai.Text, txtDacDiem.Text, int.Parse(txtSoluong.Text), arrImage, txtGhiChu.Text, cbbLoaiMH.Text);
                        MessageBox.Show("Đã cập nhật mặt hàng mới", "Thông báo");
                    }
                    else
                    {
                        mh.Capnhatmathang(int.Parse(txtMamh.Text), txttenmh.Text, txthangsx.Text, double.Parse(txtgiamua.Text), int.Parse(txtgiaban.Text), cbbDVT.Text,
                                        int.Parse(txtbaohanh.Text),null, txtDacDiem.Text, int.Parse(txtSoluong.Text), arrImage, txtGhiChu.Text, cbbLoaiMH.Text);
                        MessageBox.Show("Đã cập nhật mặt hàng mới", "Thông báo");
                    }
                }
                catch
                {
                    MessageBox.Show("Không cập nhật được mặt hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            if(DEM==true)
            {
                int dem1 = int.Parse(txtMamh.Text) + 1;
                txtMamh.Text = dem1.ToString();
                DEM = false;
            }
            txtbaohanh.ResetText();
            txtDacDiem.ResetText();
            txtGhiChu.ResetText();
            txtgiaban.ResetText();
            txtgiamua.ResetText();
            txthangsx.ResetText();
            txtSoluong.Text = "0";
            txttenmh.ResetText();
            luekhuyenmai.ResetText();
            cbbDVT.ResetText();
            cbbLoaiMH.ResetText();
            txttenmh.Focus();
        }

        private void luekhuyenmai_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
            {
                luekhuyenmai.EditValue = null;
                luekhuyenmai.Properties.NullText ="";
            }
        }
    }
}
