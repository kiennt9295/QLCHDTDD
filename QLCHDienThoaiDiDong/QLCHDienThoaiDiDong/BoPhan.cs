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
    public partial class BoPhan : Form
    {
        bool THEM;
        DMBoPhan bp = new DMBoPhan();
        public int dem1 { set; get; }
        public int dem2 { set; get; }
        public BoPhan()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                gridBP.DataSource = bp.LayBoPhan();
                dem1 = int.Parse(gridView1.RowCount.ToString());
                if(dem1==0)
                {
                    dem2 = 1;
                }
                else
                {
                    dem2 = int.Parse(gridView1.GetRowCellValue(dem1 - 1, "MABP").ToString())+1;
                }
                txtMaBP.ResetText();
                txtTenBP.ResetText();
                txtMaBP.Enabled = false;
                txtTenBP.Enabled = false;
                btnLuu.Enabled = false;
                btnThoat.Enabled = true;
                tsbthem.Enabled = true;
                tsbsua.Enabled = true;
                tsbxoa.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BoPhan_Load(object sender, EventArgs e)
        {
            LoadData();
            gridBP_Click(null,null);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbthem_Click(object sender, EventArgs e)
        {
            THEM = true;
            txtMaBP.Text = dem2.ToString();
            txtMaBP.Enabled = false;
            txtTenBP.Enabled = true;
            btnLuu.Enabled = true;
            tsbthem.Enabled = false;
            tsbsua.Enabled = false;
            tsbxoa.Enabled = false;
            txtTenBP.ResetText();
        }

        private void tsbsua_Click(object sender, EventArgs e)
        {
            THEM = false;
            txtMaBP.Enabled = false;
            txtTenBP.Enabled = true;
            btnLuu.Enabled = true;
            tsbthem.Enabled = false;
            tsbsua.Enabled = false;
            tsbxoa.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (THEM)
            {
                try
                {
                    bp.ThemBoPhan(int.Parse(txtMaBP.Text.Trim()),txtTenBP.Text.Trim());
                    MessageBox.Show("Thêm bộ phận mới thành công", "Thông báo");
                    LoadData();
                }
                catch
                {
                    MessageBox.Show("Không thêm được bộ phận", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (!THEM)
            {
                try
                {
                    bp.CapNhatBoPhan(int.Parse(txtMaBP.Text), txtTenBP.Text);
                    MessageBox.Show("Đã cập nhật bộ phận mới", "Thông báo");
                    LoadData();
                }
                catch
                {
                    MessageBox.Show("Không cập nhật được bộ phận.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsbref_Click(object sender, EventArgs e)
        {
            LoadData();
            gridBP_Click(null, null);
        }

        private void gridBP_Click(object sender, EventArgs e)
        {
            txtMaBP.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MABP").ToString();
            txtTenBP.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TENBP").ToString();
        }

        private void tsbxoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult TRALOI;
                TRALOI = MessageBox.Show("Bạn muốn xóa bộ phận này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (TRALOI == DialogResult.Yes)
                {
                    string STRMABP = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MABP").ToString();
                    bp.XoaBoPhan(int.Parse(STRMABP));
                    LoadData();
                    MessageBox.Show("Bộ phận đã được xóa", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không xóa bộ phận này", "Thông báo");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được bộ phân này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
