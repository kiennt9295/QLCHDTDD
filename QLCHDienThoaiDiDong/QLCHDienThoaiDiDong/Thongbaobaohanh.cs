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
    public partial class Thongbaobaohanh : Form
    {
        DMBaoHanh BH = new DMBaoHanh();
        public Thongbaobaohanh()
        {
            InitializeComponent();
        }
        public int b { set; get; }
        void LoadData()
        {
            try
            {
                b = 0;
                gridThongbaobaohanh.DataSource = BH.Laythongbaobaohanh();
                repositoryItemLookUpEdit1.DataSource = BH.LayBaoHanh();
                repositoryItemLookUpEdit1.DisplayMember = "TENKH";
                repositoryItemLookUpEdit1.ValueMember = "TENKH";
                b = int.Parse(gridView1.RowCount.ToString());
                lblBaohanh.Text = b.ToString();
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Thongbaobaohanh_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
