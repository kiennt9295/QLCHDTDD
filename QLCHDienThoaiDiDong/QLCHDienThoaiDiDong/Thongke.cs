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
    public partial class Thongke : Form
    {
        public Thongke()
        {
            InitializeComponent();
        }
        private bool Existform(Form frm)
        {
            foreach (var child in MdiChildren)
            {
                if (child.Name == frm.Name)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }
        private void Thongke_Load(object sender, EventArgs e)
        {

        }

        private void bntbanhang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            picHInh.Visible = false;
            var frm = new Thongkebanhang();
            if (Existform(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btndoanhthu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            picHInh.Visible = false;
            var frm = new Thongkedoanhthu();
            if (Existform(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnkho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            picHInh.Visible = false;
            var frm = new Thongkekho();
            if (Existform(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btngioithieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            picHInh.Visible = true;
        }

    }
}
