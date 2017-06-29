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
    public partial class Nhanvien2 : Form
    {
        DMNhanVien nv = new DMNhanVien();
        DMBoPhan bp = new DMBoPhan();
        DMTimKiem TK = new DMTimKiem();
        public Nhanvien2()
        {
            InitializeComponent();
        }
        public int DEM1 { set; get; }
        public int DEM2 { set; get; }
        void LoadData()
        {
            try
            {
                gridnhanvien.DataSource = nv.LayNhanVien();
                DEM1 = int.Parse(gridView2.RowCount.ToString());
                if (DEM1 != 1)
                    DEM2 = int.Parse(gridView2.GetRowCellValue(DEM1 - 1, "MANV").ToString()) + 1;
                else
                    DEM2 = 1;
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void LoadDataBP()
        {
            gridBP.DataSource = bp.LayBoPhan();
            int b = int.Parse(gridView1.RowCount.ToString());
            treeView1.Nodes.Add("Tất cả");
            for (int i = 0; i < b; i++)
            {
                treeView1.Nodes.Add(gridView1.GetRowCellValue(i, "TENBP").ToString());
                treeView1.Nodes[i].Tag = "1";

            }
        }
        private void Nhanvien2_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadDataBP();
        }

        private void tsbthem_Click(object sender, EventArgs e)
        {
            NhanVien1 frm = new NhanVien1();
            frm.THEM = true;
            frm.MANV = DEM2.ToString();
            frm.ShowDialog();
            LoadData();
        }

        private void tsbxoa_Click(object sender, EventArgs e)
        {
            try
            {
                
                DialogResult TRALOI;
                TRALOI = MessageBox.Show("Bạn muốn xóa nhân viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (TRALOI == DialogResult.Yes)
                {
                    string strMANV = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MANV").ToString();
                    nv.XoaNhanVien(int.Parse(strMANV));
                    LoadData();
                    MessageBox.Show("Nhân viên đã được xóa", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không xóa nhân viên này", "Thông báo");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được nhân viên  này.", "Lỗi");
            }
        }

        private void tsbref_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void tsbsua_Click(object sender, EventArgs e)
        {
            NhanVien1 frm = new NhanVien1();
            frm.THEM = false;
            if(DEM1==0)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên để cập nhật thông tin mơi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                if (gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MANV")!=null)
                    frm.MANV = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MANV").ToString();
                if (gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "HOTEN") != null)
                    frm.HOTEN = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "HOTEN").ToString();
                if (gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "DIACHI") != null)
                    frm.DIACHI = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "DIACHI").ToString();
                if (gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "SDT") != null)
                    frm.DIENTHOAI = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "SDT").ToString();
                if (gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MABP") != null)
                    frm.MABP = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MABP").ToString();
                if (gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "GIOITINH") != null)
                    frm.GIOITINH = bool.Parse(gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "GIOITINH").ToString());
                frm.ShowDialog();
            }
            
            LoadData();
        }

        private void tsbin_Click(object sender, EventArgs e)
        {
            gridnhanvien.ShowRibbonPrintPreview();
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            TreeNode thenode = this.treeView1.SelectedNode;
            if(txttimkiem.Text=="")
            {
                if (thenode.Text == "Tất cả")
                    gridnhanvien.DataSource = TK.TKnhanvien1(txttimkiem.Text);
                else
                    gridnhanvien.DataSource = TK.TKnhanvien(txttimkiem.Text, thenode.Text);
            }
            else
            {
                if (thenode.Text == "Tất cả")
                    gridnhanvien.DataSource = TK.TKnhanvien1(txttimkiem.Text);
                else
                    gridnhanvien.DataSource = TK.TKnhanvien(txttimkiem.Text, thenode.Text);
            }
            DEM1 = int.Parse(gridView2.RowCount.ToString());
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode thenode = this.treeView1.SelectedNode;
            if (thenode.Text == "Tất cả")
                gridnhanvien.DataSource = nv.LayNhanVien();
            else
                gridnhanvien.DataSource = TK.TKnhanvien(txttimkiem.Text, thenode.Text);
            DEM1 = int.Parse(gridView2.RowCount.ToString());
        }
    }
}
