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
    public partial class Nhapkho1 : Form
    {
        DMPhieuNhap PN = new DMPhieuNhap();
        public Nhapkho1()
        {
            InitializeComponent();
        }
        public string MAPN { set; get; }
        public string MAMH { set; get; }
        public string MANV { set; get; }
        public string NGAYNHAP { set; get; }
        public string SOLUONG { set; get; }
        public bool THEM { set; get; }
        private void Nhapkho1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCHDienThoaiDDDataSet15.MATHANG' table. You can move, or remove it, as needed.
            //this.mATHANGTableAdapter.Fill(this.qLCHDienThoaiDDDataSet15.MATHANG);
            // TODO: This line of code loads data into the 'qLCHDienThoaiDDDataSet9.MATHANG' table. You can move, or remove it, as needed.
           // this.nHANVIENTableAdapter.Fill(this.qLCHDienThoaiDDDataSet5.NHANVIEN);
            txtmapn.Text = MAPN;
            luemamh.Text = MAMH;
            luemanv.Text = MANV;
            dtpngaynhap.Text = NGAYNHAP;
            txtsoluong.Text = SOLUONG;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            if(DEM==true)
            {
                int DEM2 = int.Parse(txtmapn.Text) + 1;
                txtmapn.Text = DEM2.ToString();
                DEM = false;
            }
            txtsoluong.ResetText();
            dtpngaynhap.ResetText();
            luemamh.Focus();
        }
        public bool DEM { set; get; }
        private void btnluu_Click(object sender, EventArgs e)
        {
            if (THEM)
            {
                try
                {
                    PN.ThemPhieuNhap(int.Parse(txtmapn.Text.Trim()),int.Parse(luemamh.Text.Trim()),int.Parse(luemanv.Text.Trim()),
                                        DateTime.Parse(dtpngaynhap.Text.Trim()),int.Parse(txtsoluong.Text.Trim()));
                    MessageBox.Show("Thêm phiếu nhập mới thành công", "Thông báo");
                    DEM = true;
                }
                catch
                {
                    MessageBox.Show("Không thêm được phiếu nhập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (!THEM)
            {
                try
                {
                    PN.CapNhatPhieuNhap(int.Parse(txtmapn.Text), int.Parse(luemamh.Text), int.Parse(luemanv.Text),DateTime.Parse(dtpngaynhap.Text), int.Parse(txtsoluong.Text));
                    MessageBox.Show("Đã cập nhật phiếu nhập mới", "Thông báo");
                }
                catch
                {
                    MessageBox.Show("Không cập nhật được phiếu nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void luemamh_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void luemanv_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
