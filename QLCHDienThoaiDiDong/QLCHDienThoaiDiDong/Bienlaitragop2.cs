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
    public partial class Bienlaitragop2 : Form
    {
        DMBienLaiTraGop BL=new DMBienLaiTraGop();
        DMPhieuTraGop TG = new DMPhieuTraGop();
        public Bienlaitragop2()
        {
            InitializeComponent();
        }
        public string MABL { set; get; }
        public int MANV { set; get; }
        public string MAKH { set; get; }
        public string SOTIEN { set; get; }
        public string NGAY { set; get; }
        public string GHICHU { set; get; }
        public bool THEM { set; get; }
        private void Bienlaitragop2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCHDienThoaiDDDataSet6.KHACHHANG' table. You can move, or remove it, as needed.
            //this.kHACHHANGTableAdapter.Fill(this.qLCHDienThoaiDDDataSet6.KHACHHANG);
            // TODO: This line of code loads data into the 'qLCHDienThoaiDDDataSet5.NHANVIEN' table. You can move, or remove it, as needed.
            //this.nHANVIENTableAdapter.Fill(this.qLCHDienThoaiDDDataSet5.NHANVIEN);
            
            txtmabl.Text = MABL;
            luemanv.Text = MANV.ToString();
            luemakh.Text = MAKH;
            txtsotien.Text = SOTIEN;
            dtpngay.Text = NGAY;
            txtghichu.Text = GHICHU;
            gridTragop.DataSource = TG.LayPhieuTG();
        }
        public bool dem { set; get; }
        private void btnluu_Click(object sender, EventArgs e)
        {
             if (THEM)
            {
                try
                {
                    BL.ThemBienLaiTraGop(int.Parse(txtmabl.Text.Trim()),int.Parse(luemanv.Text.Trim()),DateTime.Parse(dtpngay.Text.Trim()),int.Parse(luemakh.Text.Trim()),float.Parse(txtsotien.Text.Trim()),txtghichu.Text.Trim());
                    MessageBox.Show("Thêm biên lai mới thành công", "Thông báo");
                    dem = true;
                }
                catch
                {
                    MessageBox.Show("Không thêm được biên lai", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
             if (!THEM)
             {
                 try
                 {
                     BL.CapNhatBienLaiTraGop(int.Parse(txtmabl.Text), int.Parse(luemanv.Text), DateTime.Parse(dtpngay.Text), int.Parse(luemakh.Text), float.Parse(txtsotien.Text), txtghichu.Text);
                     MessageBox.Show("Đã cập nhật biên lai mới", "Thông báo");
                 }
                 catch
                 {
                     MessageBox.Show("Không cập nhật được biên lai.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
             }
        }
        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            if(dem==true)
            {
                int dem1 = int.Parse(txtmabl.Text) + 1;
                txtmabl.Text = dem1.ToString();
                dem = false;
            }
            txtsotien.ResetText();
            txtghichu.ResetText();
            luemanv.Focus();
        }

        private void luemanv_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(e.Button.Kind==DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
            {
                luemanv.EditValue = null;
                luemanv.Properties.NullText = "";
            }
        }

        private void luemakh_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
            {
                luemakh.EditValue = null;
                luemakh.Properties.NullText = "";
            }
        }

        private void luemakh_EditValueChanged(object sender, EventArgs e)
        {
            int b = int.Parse(gvTraGop.RowCount.ToString());
            int b1 = int.Parse(gvBienlai.RowCount.ToString());
        }
    }
}
