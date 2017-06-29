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
using DevExpress.Utils.Win;
using DevExpress.XtraLayout;
using DevExpress.XtraEditors;

namespace QLCHDienThoaiDiDong
{
    public partial class Tonkho : Form
    {
        DMThongke tk = new DMThongke();
        DMTimKiem timkiem = new DMTimKiem();
        DMMatHang mh = new DMMatHang();
        public Tonkho()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                gridTonkho.DataSource = tk.Laytonkho();
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu.","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        void LoaiMH()
        {
            gridLoaiMH.DataSource = mh.Laymathang1();
            int b = int.Parse(gridView2.RowCount.ToString());
            trvtimkiem.Nodes.Add("Tất cả");
            for (int i = 0; i < b; i++)
            {
                trvtimkiem.Nodes.Add(gridView2.GetRowCellValue(i, "lOAIMH").ToString());
            }
        }
        private void Tonkho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCHDienThoaiDDDataSet16.MATHANG' table. You can move, or remove it, as needed.
            //this.mATHANGTableAdapter.Fill(this.qLCHDienThoaiDDDataSet16.MATHANG);
            LoadData();
            LoaiMH();
        }

        private void tsbREf_Click(object sender, EventArgs e)
        {
            LoadData();
            luetimkiem.EditValue = null;
            luetimkiem.Properties.NullText = "Chọn mã mặt hàng";
        }

        private void trvtimkiem_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode thenode = this.trvtimkiem.SelectedNode;
            if (thenode.Text == "Tất cả")
            {
                gridTonkho.DataSource = tk.Laytonkho();
            }
            else
            {
                if (luetimkiem.Text == "" || luetimkiem.Text == "Chọn mã mặt hàng")
                    gridTonkho.DataSource = timkiem.TKtonkholoaiMH(thenode.Text);
                else
                    gridTonkho.DataSource = timkiem.TKtonkholoaiMHvaMaMH(luetimkiem.Text, thenode.Text);
            }
            
        }
        private void luetimkiem_EditValueChanged_1(object sender, EventArgs e)
        {
            TreeNode thenode = this.trvtimkiem.SelectedNode;
            if (luetimkiem.Text == ""||luetimkiem.Text=="Chọn mã mặt hàng")
            {
                if (thenode.Text == "Tất cả")
                    LoadData();
                else
                    gridTonkho.DataSource = timkiem.TKtonkholoaiMH(thenode.Text);
            }
            else
            {
                if (thenode.Text == "Tất cả")
                    gridTonkho.DataSource = timkiem.TKtonkho(luetimkiem.Text);
                else
                    gridTonkho.DataSource = timkiem.TKtonkholoaiMHvaMaMH(luetimkiem.Text, thenode.Text);
            }
        }

        private void luetimkiem_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
            {
                luetimkiem.EditValue = null;
                luetimkiem.Properties.NullText="Chọn mã mặt hàng";
            }
        }
    }
}
