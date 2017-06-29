namespace QLCHDienThoaiDiDong
{
    partial class Thongke
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Thongke));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btndoanhthu = new DevExpress.XtraBars.BarButtonItem();
            this.bntbanhang = new DevExpress.XtraBars.BarButtonItem();
            this.btnkho = new DevExpress.XtraBars.BarButtonItem();
            this.btngioithieu = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.picHInh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHInh)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btndoanhthu,
            this.bntbanhang,
            this.btnkho,
            this.btngioithieu});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbonControl1.Size = new System.Drawing.Size(914, 129);
            this.ribbonControl1.Toolbar.ItemLinks.Add(this.btngioithieu);
            // 
            // btndoanhthu
            // 
            this.btndoanhthu.Caption = "Doanh thu";
            this.btndoanhthu.Glyph = ((System.Drawing.Image)(resources.GetObject("btndoanhthu.Glyph")));
            this.btndoanhthu.Id = 3;
            this.btndoanhthu.Name = "btndoanhthu";
            this.btndoanhthu.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btndoanhthu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btndoanhthu_ItemClick);
            // 
            // bntbanhang
            // 
            this.bntbanhang.Caption = "Bán hàng";
            this.bntbanhang.Glyph = ((System.Drawing.Image)(resources.GetObject("bntbanhang.Glyph")));
            this.bntbanhang.Id = 4;
            this.bntbanhang.Name = "bntbanhang";
            this.bntbanhang.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.bntbanhang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bntbanhang_ItemClick);
            // 
            // btnkho
            // 
            this.btnkho.Caption = "Nhập xuất kho";
            this.btnkho.Glyph = ((System.Drawing.Image)(resources.GetObject("btnkho.Glyph")));
            this.btnkho.Id = 5;
            this.btnkho.Name = "btnkho";
            this.btnkho.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnkho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnkho_ItemClick);
            // 
            // btngioithieu
            // 
            this.btngioithieu.Caption = "giới thiệu";
            this.btngioithieu.Glyph = ((System.Drawing.Image)(resources.GetObject("btngioithieu.Glyph")));
            this.btngioithieu.Id = 6;
            this.btngioithieu.Name = "btngioithieu";
            this.btngioithieu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btngioithieu_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Thông kê";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bntbanhang);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btndoanhthu);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnkho);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // picHInh
            // 
            this.picHInh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picHInh.Image = ((System.Drawing.Image)(resources.GetObject("picHInh.Image")));
            this.picHInh.Location = new System.Drawing.Point(0, 129);
            this.picHInh.Name = "picHInh";
            this.picHInh.Size = new System.Drawing.Size(914, 369);
            this.picHInh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHInh.TabIndex = 4;
            this.picHInh.TabStop = false;
            // 
            // Thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 498);
            this.Controls.Add(this.picHInh);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "Thongke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông kê";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Thongke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHInh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btndoanhthu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem bntbanhang;
        private DevExpress.XtraBars.BarButtonItem btnkho;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btngioithieu;
        private System.Windows.Forms.PictureBox picHInh;
    }
}