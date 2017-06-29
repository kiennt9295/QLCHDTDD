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
using System.IO;

namespace QLCHDienThoaiDiDong
{
    public partial class NhanVien1 : Form
    {
        MemoryStream ms;
        byte[] arrImage;
        DMNhanVien nv = new DMNhanVien();
        public NhanVien1()
        {
            InitializeComponent();
        }

        

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool DEM { set; get; }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (THEM)
            {
                try
                {
                    if (txtSDT.Text != "")
                    {
                        nv.ThemNhanVien(int.Parse(txtManv.Text.Trim()), txtTennv.Text.Trim(), txtDiachi.Text.Trim(), txtSDT.Text.Trim(), int.Parse(lueBophan.Text.Trim()), arrImage, chkNam.Checked);
                        MessageBox.Show("Thêm nhân viên mới thành công", "THÔNG BÁO");
                    }
                    else
                    {
                        nv.ThemNhanVien(int.Parse(txtManv.Text.Trim()), txtTennv.Text.Trim(), txtDiachi.Text.Trim(),null, int.Parse(lueBophan.Text.Trim()), arrImage, chkNam.Checked);
                        MessageBox.Show("Thêm nhân viên mới thành công", "THÔNG BÁO");
                    }
                    DEM = true;
                }
                catch
                {
                    MessageBox.Show("Không thêm được nhân viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (!THEM)
            {
                try
                {
                    if (txtSDT.Text !="")
                    {
                        nv.CapNhatNhanVien(int.Parse(txtManv.Text), txtTennv.Text, txtDiachi.Text, txtSDT.Text, int.Parse(lueBophan.Text), arrImage, chkNam.Checked);
                        MessageBox.Show("Đã cập nhật nhân viên mới", "Thông báo");
                    }
                    else
                    {
                        nv.CapNhatNhanVien(int.Parse(txtManv.Text), txtTennv.Text, txtDiachi.Text,null, int.Parse(lueBophan.Text), arrImage, chkNam.Checked);
                        MessageBox.Show("Đã cập nhật nhân viên mới", "Thông báo");
                    }
                }
                catch
                {
                    MessageBox.Show("Không cập nhật được nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public string MANV { set; get; }
        public string HOTEN { set; get; }
        public string DIACHI { set; get; }
        public string DIENTHOAI { set; get; }
        public string MABP { set; get; }
        public bool GIOITINH { set; get; }
        public Image HINH { set; get; }
        public bool THEM { set; get; }
        private void NhanVien1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCHDienThoaiDDDataSet1.BOPHAN' table. You can move, or remove it, as needed.
            this.bOPHANTableAdapter1.Fill(this.qLCHDienThoaiDDDataSet1.BOPHAN);
            // TODO: This line of code loads data into the 'qLCHDienThoaiDDDataSet.BOPHAN' table. You can move, or remove it, as needed.
            this.bOPHANTableAdapter.Fill(this.qLCHDienThoaiDDDataSet.BOPHAN);
            txtManv.Text = MANV;
            txtTennv.Text = HOTEN;
            txtDiachi.Text = DIACHI;
            txtSDT.Text = DIENTHOAI;
            lueBophan.Text = MABP;
            chkNam.Checked = GIOITINH;
            picHinh.Image=HINH;
        }

        private void btnlayhinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog odlgOpenFile = new OpenFileDialog();
            odlgOpenFile.InitialDirectory = "C:\\";
            odlgOpenFile.Title = "Open File";
            odlgOpenFile.Filter = "Image files (*.jpg)|*.jpg|All files (*.*)|*.*";
            if (odlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                picHinh.Image = System.Drawing.Image.FromFile(odlgOpenFile.FileName);
                //
                ms = new MemoryStream();
                picHinh.Image.Save(ms, picHinh.Image.RawFormat);
                arrImage = ms.GetBuffer();
                ms.Close();
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            if(DEM==true)
            {
                int DEM2 = int.Parse(txtManv.Text) + 1;
                txtManv.Text = DEM2.ToString();
                DEM = false;
            }
            txtTennv.ResetText();
            txtDiachi.ResetText();
            txtSDT.ResetText();
            chkNam.ResetText();
            txtTennv.Focus();
        }
    }
}
