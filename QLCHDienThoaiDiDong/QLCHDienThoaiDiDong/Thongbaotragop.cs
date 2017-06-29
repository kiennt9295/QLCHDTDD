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
    public partial class Thongbaotragop : Form
    {
        DMBienLaiTraGop BL = new DMBienLaiTraGop();
        DMKhachHang KH = new DMKhachHang();
        public Thongbaotragop()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                gridThongbaotragop.DataSource = BL.Laythongbaotragop();
                repositoryItemLookUpEdit1.DataSource = KH.LayKhachHang();
                repositoryItemLookUpEdit1.DisplayMember = "HOTEN";
                repositoryItemLookUpEdit1.ValueMember = "MAKH";
                int b = 0;
                b = int.Parse(gridView1.RowCount.ToString());
                lblTragop.Text = b.ToString();
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Thongbaotragop_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
