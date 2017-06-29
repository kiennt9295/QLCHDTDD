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
    public partial class Thongkedoanhthu : Form
    {
        DMThongke tk = new DMThongke();
        DMTimKiem timkiem = new DMTimKiem();
        public Thongkedoanhthu()
        {
            InitializeComponent();
        }
        void LoadDataThu()
        {
            try
            {
                gridthu.DataSource = tk.LayThongkethu();
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void LoadDataChi()
        {
            try
            {
                gridChi.DataSource=tk.LayThongkechi();
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public int DEM { set; get; }
        public double TONGTIENTHU { set; get; }
        public double TONGTIENCHI { set; get; }
        public double LOINHUAN { set; get; }
        void Tongtienthu()
        {
            DEM = int.Parse(gridView1.RowCount.ToString());
            TONGTIENTHU = 0;
            for (int i = 0; i < DEM; i++)
            {
                TONGTIENTHU = TONGTIENTHU + int.Parse(gridView1.GetRowCellValue(i, "TONGTIENTHU").ToString());
            }
            lbltienthu.Text = TONGTIENTHU.ToString();
            LOINHUAN = TONGTIENTHU - TONGTIENCHI;
            lblloinhuan.Text = LOINHUAN.ToString();
        }
        void Tongtienchi()
        {
            int DEM = int.Parse(gridView2.RowCount.ToString());
            int TONGTIENCHI = 0;
            for (int i = 0; i < DEM; i++)
            {
                TONGTIENCHI = TONGTIENCHI + int.Parse(gridView2.GetRowCellValue(i, "TONGTIENCHI").ToString());
            }
            lbltienchi.Text = TONGTIENCHI.ToString();
            LOINHUAN = TONGTIENTHU - TONGTIENCHI;
            lblloinhuan.Text = LOINHUAN.ToString();
        }
        private void Thongkedoanhthu_Load(object sender, EventArgs e)
        {
            LoadDataThu();
            Tongtienthu();
            LoadDataChi();
            Tongtienchi();
        }

        private void dtpTungay_ValueChanged(object sender, EventArgs e)
        {
            gridthu.DataSource = timkiem.TKthongkedoanhthu_phieuthu(DateTime.Parse(dtpTungay.Text), DateTime.Parse(dtpDenngay.Text));
            Tongtienthu();
            gridChi.DataSource = timkiem.TKthongkedoanhthu_phieuchi(DateTime.Parse(dtpTungay.Text), DateTime.Parse(dtpDenngay.Text));
            Tongtienchi();
        }

        private void dtpDenngay_ValueChanged(object sender, EventArgs e)
        {
            gridthu.DataSource = timkiem.TKthongkedoanhthu_phieuthu(DateTime.Parse(dtpTungay.Text), DateTime.Parse(dtpDenngay.Text));
            Tongtienthu();
            gridChi.DataSource = timkiem.TKthongkedoanhthu_phieuchi(DateTime.Parse(dtpTungay.Text), DateTime.Parse(dtpDenngay.Text));
            Tongtienchi();
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            LoadDataThu();
            Tongtienthu();
            LoadDataChi();
            Tongtienchi();
        }
    }
}
