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
    public partial class Phieudathang1 : Form
    {
        DMPhieuDatHang PDH = new DMPhieuDatHang();
        public Phieudathang1()
        {
            InitializeComponent();
        }
        public string MAPDH { set; get; }
        public string MAMH { set; get; }
        public string SOLUONG { set; get; }
        public string GIANHAP { set; get; }
        public string MANCC { set; get; }
        public string MANV { set; get; }
        public string NGAYDH { set; get; }
        public string DATRA { set; get; }
        public string CONNO { set; get; }
        public bool THEM { set; get; }

        private void Phieudathang1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCHDienThoaiDDDataSet5.NHANVIEN' table. You can move, or remove it, as needed.
           // this.nHANVIENTableAdapter.Fill(this.qLCHDienThoaiDDDataSet5.NHANVIEN);
            // TODO: This line of code loads data into the 'qLCHDienThoaiDDDataSet8.NHACUNGCAP' table. You can move, or remove it, as needed.
            //this.nHACUNGCAPTableAdapter.Fill(this.qLCHDienThoaiDDDataSet8.NHACUNGCAP);
            // TODO: This line of code loads data into the 'qLCHDienThoaiDDDataSet4.MATHANG' table. You can move, or remove it, as needed.
            //this.mATHANGTableAdapter.Fill(this.qLCHDienThoaiDDDataSet4.MATHANG);
            txtmapdh.Text = MAPDH;
            luemamh.Text = MAMH;
            luemancc.Text = MANCC;
            luemanv.Text = MANV;
            txtsoluong.Text = SOLUONG;
            dtpngaydh.Text = NGAYDH;
            txtdatra.Text = DATRA;
            txtconno.Text = CONNO;
            txtgianhap.Text = GIANHAP;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool DEM { set; get; }
        private void bntluu_Click(object sender, EventArgs e)
        {
            if (THEM)
            {
                try
                {
                    PDH.ThemPhieuDH(int.Parse(txtmapdh.Text.Trim()),int.Parse(luemamh.Text.Trim()),int.Parse(luemancc.Text.Trim()),int.Parse(luemanv.Text.Trim()),
                                    int.Parse(txtsoluong.Text.Trim()),float.Parse(txtgianhap.Text.Trim()),DateTime.Parse(dtpngaydh.Text.Trim()),
                                    double.Parse(txtdatra.Text.Trim()),double.Parse(txtconno.Text.Trim()));
                    MessageBox.Show("Thêm phiếu đặt hàng mới thành công", "Thông báo");
                    DEM = true;
                }
                catch
                {
                    MessageBox.Show("Không thêm được phiếu đặt hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (!THEM)
            {
                try
                {
                    PDH.CapNhatPhieuDH(int.Parse(txtmapdh.Text), int.Parse(luemamh.Text), int.Parse(luemancc.Text), int.Parse(luemanv.Text),
                                    int.Parse(txtsoluong.Text), float.Parse(txtgianhap.Text), DateTime.Parse(dtpngaydh.Text),double.Parse(txtdatra.Text), double.Parse(txtconno.Text));
                    MessageBox.Show("Đã cập nhật phiếu đặt hàng mới", "Thông báo");
                }
                catch
                {
                    MessageBox.Show("Không cập nhật được phiếu đặt hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtdatra_TextChanged(object sender, EventArgs e)
        {
                if (txtdatra.Text == "" || txtgianhap.Text == "")
                    txtconno.Text = "0";
                else
                {
                    double A = double.Parse(txtgianhap.Text) - double.Parse(txtdatra.Text);
                    txtconno.Text = A.ToString();
                }
        }

        private void txtgianhap_TextChanged(object sender, EventArgs e)
        {
            if (txtdatra.Text == "" || txtgianhap.Text == "")
                txtconno.Text = "0";
            else
            {
                double A = double.Parse(txtgianhap.Text) - double.Parse(txtdatra.Text);
                txtconno.Text = A.ToString();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if(DEM==true)
            {
                int DEM2= int.Parse(txtmapdh.Text)+1;
                txtmapdh.Text = DEM2.ToString();
                DEM = false;
            }
            txtconno.ResetText();
            txtdatra.ResetText();
            txtgianhap.ResetText();
            txtsoluong.ResetText();
            luemamh.Focus();
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            
        }
    }
}
