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
    public partial class Phieutragop1 : Form
    {
        DMPhieuTraGop ptg = new DMPhieuTraGop();
        DMNhanVien nv = new DMNhanVien();
        DMKhachHang kh = new DMKhachHang();
        DMMatHang mh = new DMMatHang();
        public Phieutragop1()
        {
            InitializeComponent();
        }
        public string MAPTG { set; get; }
        public string MAKH { set; get; }
        public string MANV { set; get; }
        public string CMND { set; get; }
        public string NGAYLAP { set; get; }
        public string TONGTIEN { set; get; }
        public string MAMH { set; get; }
        public string HANTRA { set; get; }
        public string LAISUAT { set; get; }
        public bool THEM { set; get; }
        public bool dem { set; get; }
        private void Phieutragop1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCHDienThoaiDDDataSet13.MATHANG' table. You can move, or remove it, as needed.
            //this.mATHANGTableAdapter.Fill(this.qLCHDienThoaiDDDataSet13.MATHANG);
            // TODO: This line of code loads data into the 'qLCHDienThoaiDDDataSet4.MATHANG' table. You can move, or remove it, as needed.
            //this.nHANVIENTableAdapter.Fill(this.qLCHDienThoaiDDDataSet5.NHANVIEN);
            // TODO: This line of code loads data into the 'qLCHDienThoaiDDDataSet6.KHACHHANG' table. You can move, or remove it, as needed.
            //this.kHACHHANGTableAdapter.Fill(this.qLCHDienThoaiDDDataSet6.KHACHHANG);
            txtmaphieu.Text = MAPTG;
            luekhachhang.Text = MAKH;
            txtCMND.Text = CMND;
            luenhanvien.Text = MANV;
            dtpngay.Text = NGAYLAP;
            txttongtien.Text = TONGTIEN;
            luemathang.Text = MAMH;
            txthantra.Text = HANTRA;
            txtlaisuat.Text = LAISUAT;
            gridTRAGOP.DataSource = mh.Laymathang();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (THEM)
            {
                try
                {
                    ptg.ThemPhieuTG(int.Parse(txtmaphieu.Text.Trim()),int.Parse(luekhachhang.Text.Trim()),int.Parse(txtCMND.Text.Trim()), int.Parse(luenhanvien.Text.Trim()), DateTime.Parse(dtpngay.Text.Trim()),double.Parse(txttongtien.Text.Trim()),int.Parse(luemathang.Text.Trim()),int.Parse(txthantra.Text.Trim()),int.Parse(txtlaisuat.Text.Trim()));
                    MessageBox.Show("Thêm phiếu trả góp mới thành công", "Thông báo");
                    dem = true;
                }
                catch
                {
                    MessageBox.Show("Không thêm được phiếu trả góp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (!THEM)
            {
                try
                {
                    ptg.CapNhatPhieuTG(int.Parse(txtmaphieu.Text), int.Parse(luekhachhang.Text),int.Parse(txtCMND.Text), int.Parse(luenhanvien.Text), DateTime.Parse(dtpngay.Text), float.Parse(txttongtien.Text), int.Parse(luemathang.Text), int.Parse(txthantra.Text), int.Parse(txtlaisuat.Text));
                    MessageBox.Show("Đã cập nhật phiếu trả góp mới", "Thông báo");
                }
                catch
                {
                    MessageBox.Show("Không cập nhật được phiếu trả góp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dem==true)
            {
                int dem1 = int.Parse(txtmaphieu.Text)+1;
                txtmaphieu.Text = dem1.ToString();
                dem = false;
            }
            txtCMND.ResetText();
            txthantra.ResetText();
            txtlaisuat.ResetText();
            txttongtien.ResetText();
            luenhanvien.ResetText();
            luekhachhang.ResetText();
            luemathang.ResetText();
            luekhachhang.Focus();
        }

        private void luekhachhang_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(e.Button.Kind==DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
            {
                luekhachhang.EditValue = null;
                luekhachhang.Properties.NullText = "";
            }
        }

        private void luenhanvien_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
            {
                luenhanvien.EditValue = null;
                luenhanvien.Properties.NullText = "";
            }
        }

        private void luemathang_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
            {
                luemathang.EditValue = null;
                luemathang.Properties.NullText = "";
            }
        }

        private void luemathang_EditValueChanged(object sender, EventArgs e)
        {
            if (luemathang.Text == "")
                txttongtien.Text = "0";
            else
            {
                int b = int.Parse(gvtragop.RowCount.ToString());
                for (int I = 0; I < b; I++)
                {
                    if (gvtragop.GetRowCellValue(I, "MAMH").ToString() == luemathang.Text)
                    {
                        if (txtlaisuat.Text == "")
                            txttongtien.Text = gvtragop.GetRowCellValue(I, "GIABAN").ToString();
                        else
                        {
                            float C = float.Parse(gvtragop.GetRowCellValue(I, "GIABAN").ToString()) / 1000000;
                            float D = 1000000 * float.Parse(txtlaisuat.Text) / 100;
                            float G = D * C;
                            float H = float.Parse(gvtragop.GetRowCellValue(I, "GIABAN").ToString()) + G;
                            txttongtien.Text = H.ToString();
                        }
                    }
                }
            }
        }

        private void txtlaisuat_TextChanged(object sender, EventArgs e)
        {
            if (txtlaisuat.Text != "")
            {
                if (luemathang.Text == "")
                    txttongtien.Text = "0";
                else
                {
                    int b = int.Parse(gvtragop.RowCount.ToString());
                    for (int I = 0; I < b; I++)
                    {
                        if (gvtragop.GetRowCellValue(I, "MAMH").ToString() == luemathang.Text)
                        {
                            float C = float.Parse(gvtragop.GetRowCellValue(I, "GIABAN").ToString()) / 1000000;
                            float D = 1000000 * float.Parse(txtlaisuat.Text) / 100;
                            float G = D * C;
                            float H = float.Parse(gvtragop.GetRowCellValue(I, "GIABAN").ToString()) + G;
                            txttongtien.Text = H.ToString();
                        }
                    }
                }
            }
            else
                txttongtien.Text = "";
        }
    }
}
