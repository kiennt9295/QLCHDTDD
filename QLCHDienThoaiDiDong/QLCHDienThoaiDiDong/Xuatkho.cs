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
    public partial class Xuatkho : Form
    {
        DMChiTietHoaDon XK = new DMChiTietHoaDon();
        DMTimKiem timkiem = new DMTimKiem();
        public Xuatkho()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                gridXuatKho.DataSource = XK.LayCTHD();
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Xuatkho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCHDienThoaiDDDataSet7.HOADON' table. You can move, or remove it, as needed.
            //this.hOADONTableAdapter.Fill(this.qLCHDienThoaiDDDataSet7.HOADON);
            LoadData();
        }

        private void tsbRef_Click(object sender, EventArgs e)
        {
            LoadData();
            lueTimkiem.EditValue = null;
            lueTimkiem.Properties.NullText = "Chọn mã hóa đơn";
        }

        private void tsbIn_Click(object sender, EventArgs e)
        {
            gridXuatKho.ShowRibbonPrintPreview();
        }
        private void lueTimkiem_EditValueChanged_1(object sender, EventArgs e)
        {
            if (lueTimkiem.Text == "Chọn mã hóa đơn")
                gridXuatKho.DataSource = XK.LayCTHD();
            else
                gridXuatKho.DataSource = timkiem.TKxuatkho(int.Parse(lueTimkiem.Text));
        }

        private void lueTimkiem_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(e.Button.Kind==DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
            {
                lueTimkiem.EditValue = null;
                lueTimkiem.Properties.NullText = "Chọn mã hóa đơn";
            }
        }
    }
}
