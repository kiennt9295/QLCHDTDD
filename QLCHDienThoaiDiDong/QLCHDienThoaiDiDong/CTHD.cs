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
    public partial class CTHD : Form
    {
        DMChiTietHoaDon CTHD1 = new DMChiTietHoaDon();
        DMMatHang MH = new DMMatHang();
        DMHoaDon HD = new DMHoaDon();
        public CTHD()
        {
            InitializeComponent();
        }
        public string MACTHD { set; get; }
        public string MAHD { set; get; }
        public string MAMH { set; get; }
        public string MANV { set; get; }
        public string MAKH { set; get; }
        public string SOLUONG { set; get; }
        public string DONVITINH { set; get; }
        public float THANHTIEN { set; get; }
        public bool THEM { set; get; }

        private void CTHD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCHDienThoaiDDDataSet14.MATHANG' table. You can move, or remove it, as needed.
            //this.mATHANGTableAdapter1.Fill(this.qLCHDienThoaiDDDataSet14.MATHANG);
            // TODO: This line of code loads data into the 'qLCHDienThoaiDDDataSet11.HOADON' table. You can move, or remove it, as needed.
            //this.hOADONTableAdapter2.Fill(this.qLCHDienThoaiDDDataSet11.HOADON);
            // TODO: This line of code loads data into the 'qLCHDienThoaiDDDataSet10.HOADON' table. You can move, or remove it, as needed.
            //this.hOADONTableAdapter1.Fill(this.qLCHDienThoaiDDDataSet10.HOADON);
            // TODO: This line of code loads data into the 'qLCHDienThoaiDDDataSet7.HOADON' table. You can move, or remove it, as needed.
            //this.hOADONTableAdapter.Fill(this.qLCHDienThoaiDDDataSet7.HOADON);
            // TODO: This line of code loads data into the 'qLCHDienThoaiDDDataSet6.KHACHHANG' table. You can move, or remove it, as needed.
            //this.kHACHHANGTableAdapter.Fill(this.qLCHDienThoaiDDDataSet6.KHACHHANG);
            // TODO: This line of code loads data into the 'qLCHDienThoaiDDDataSet5.NHANVIEN' table. You can move, or remove it, as needed.
            //this.nHANVIENTableAdapter.Fill(this.qLCHDienThoaiDDDataSet5.NHANVIEN);
            // TODO: This line of code loads data into the 'qLCHDienThoaiDDDataSet4.MATHANG' table. You can move, or remove it, as needed.
            //this.mATHANGTableAdapter.Fill(this.qLCHDienThoaiDDDataSet4.MATHANG);
            txtmacthd.Text = MACTHD;
            luemaHD.Text = MAHD;
            luemamh.Text = MAMH;
            luemanv.Text = MANV;
            luemakh.Text = MAKH;
            txtsoluong.Text = SOLUONG;
            txtdonvitinh.Text = DONVITINH;
            txtthanhtien.Text = THANHTIEN.ToString();
            gridmathang.DataSource = MH.Laymathang();
            gridHoaDon.DataSource = HD.LayHoaDon();
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
                    CTHD1.ThemCTHD(int.Parse(txtmacthd.Text.Trim()),int.Parse(luemaHD.Text.Trim()),int.Parse(luemamh.Text.Trim()),int.Parse(luemanv.Text.Trim()),
                                    int.Parse(luemakh.Text.Trim()),int.Parse(txtsoluong.Text.Trim()),txtdonvitinh.Text.Trim(),float.Parse(txtthanhtien.Text.Trim()));
                    MessageBox.Show("Thêm chi tiết hóa đơn mới thành công", "Thông báo");
                    DEM = true;
                }
                catch
                {
                    MessageBox.Show("Không thêm được chi tiết hóa đơn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (!THEM)
            {
                try
                {
                    CTHD1.CapNhatCTHD(int.Parse(txtmacthd.Text), int.Parse(luemaHD.Text), int.Parse(luemamh.Text), int.Parse(luemanv.Text),
                                    int.Parse(luemakh.Text), int.Parse(txtsoluong.Text), txtdonvitinh.Text, float.Parse(txtthanhtien.Text));
                    MessageBox.Show("Đã cập nhật chi tiết hóa đơn mới", "Thông báo");
                }
                catch
                {
                    MessageBox.Show("Không cập nhật được chi tiết hóa đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            if(DEM==true)
            {
                int DEM2 = int.Parse(txtmacthd.Text) + 1;
                txtmacthd.Text = DEM2.ToString();
                DEM = false;
            }
            txtdonvitinh.ResetText();
            txtsoluong.Text="1";
            luemaHD.ResetText();
            luemakh.ResetText();
            luemamh.ResetText();
            luemaHD.Focus();
        }

        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {
            if (txtsoluong.Text == "")
                txtthanhtien.Text = "0";
            else
            {
                if (luemamh.Text == "")
                    txtthanhtien.Text = "0";
                else if (luemamh.Text != "")
                {
                    int b = int.Parse(gridView1.RowCount.ToString());
                    for (int I = 0; I < b; I++)
                    {
                        if (gridView1.GetRowCellValue(I, "MAMH").ToString() == luemamh.Text)
                        {
                            int d = int.Parse(gridView1.GetRowCellValue(I, "GIABAN").ToString()) * int.Parse(txtsoluong.Text);
                            txtthanhtien.Text = d.ToString();
                        }
                    }
                }
            }
        }

        private void luemamh_EditValueChanged(object sender, EventArgs e)
        {
            if (luemamh.Text == "")
                txtthanhtien.Text = "0";
            else
            {
                if (txtsoluong.Text == "")
                    txtthanhtien.Text = "0";
                else if (luemamh.Text != "")
                {
                    int b = int.Parse(gridView1.RowCount.ToString());
                    for (int I = 0; I < b; I++)
                    {
                        if (gridView1.GetRowCellValue(I, "MAMH").ToString() == luemamh.Text)
                        {
                            int d = int.Parse(gridView1.GetRowCellValue(I, "GIABAN").ToString()) * int.Parse(txtsoluong.Text);
                            txtthanhtien.Text = d.ToString();
                        }
                    }
                }
            }
        }

        private void luemaHD_EditValueChanged(object sender, EventArgs e)
        {
            if(luemaHD.Text=="")
            {
                luemanv.Text = "";
                luemakh.Text = "";
            }
            else
            {
                int b = int.Parse(gridHD.RowCount.ToString());
                for (int I = 0; I < b; I++)
                {
                    if (gridHD.GetRowCellValue(I, "MAHD").ToString() == luemaHD.Text)
                    {
                        luemakh.Text = gridHD.GetRowCellValue(I, "MAKH").ToString();
                        luemanv.Text = gridHD.GetRowCellValue(I, "MANV").ToString();
                    }
                }
            }
        }
    }
}
