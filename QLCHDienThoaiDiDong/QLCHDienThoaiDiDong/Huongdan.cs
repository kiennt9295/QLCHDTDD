using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHDienThoaiDiDong
{
    public partial class Huongdan : Form
    {
        public Huongdan()
        {
            InitializeComponent();
        }

        private void Huongdan_Load(object sender, EventArgs e)
        {
            
        }

        private void trvHuongdan_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode thenode = this.trvHuongdan.SelectedNode;
            if (thenode.Text == "Đăng nhập")
            {
                pnDangNhap.Visible = true;
                pnDoimatkhau.Visible = false;
            }
            else if(thenode.Text=="Đổi mật khẩu")
            {
                pnDoimatkhau.Visible = true;
                pnDangxuat.Visible = false;
            }
            else if(thenode.Text=="Đăng xuất")
            {
                pnDangxuat.Visible = true;
                pnHD.Visible = false;
            }
            else if(thenode.Text=="Tạo hóa đơn, Chi tiết HĐ")
            {
                pnHD.Visible = true;
                pnkhuyenmai.Visible = false;
            }
            else if(thenode.Text=="Thông tin khuyến mãi")
            {
                pnkhuyenmai.Visible = true;
                panel1.Visible = false;
            }
        }
    }
}
