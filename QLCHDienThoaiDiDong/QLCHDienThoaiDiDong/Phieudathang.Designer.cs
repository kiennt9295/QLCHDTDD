namespace QLCHDienThoaiDiDong
{
    partial class Phieudathang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Phieudathang));
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Tất cả");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Đã trả");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Còn nợ");
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.nHACUNGCAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLCHDienThoaiDDDataSet8 = new QLCHDienThoaiDiDong.QLCHDienThoaiDDDataSet8();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.trvtimkiem = new System.Windows.Forms.TreeView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.gridPhieuDH = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbThem = new System.Windows.Forms.ToolStripButton();
            this.tsbxoa = new System.Windows.Forms.ToolStripButton();
            this.tsbsua = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbIn = new System.Windows.Forms.ToolStripButton();
            this.tsbref = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lueMaNCC = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MANCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nHACUNGCAPTableAdapter = new QLCHDienThoaiDiDong.QLCHDienThoaiDDDataSet8TableAdapters.NHACUNGCAPTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHACUNGCAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHDienThoaiDDDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPhieuDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueMaNCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 61);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Phiếu đặt hàng";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(707, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "aaaaaa.jpg");
            // 
            // nHACUNGCAPBindingSource
            // 
            this.nHACUNGCAPBindingSource.DataMember = "NHACUNGCAP";
            this.nHACUNGCAPBindingSource.DataSource = this.qLCHDienThoaiDDDataSet8;
            // 
            // qLCHDienThoaiDDDataSet8
            // 
            this.qLCHDienThoaiDDDataSet8.DataSetName = "QLCHDienThoaiDDDataSet8";
            this.qLCHDienThoaiDDDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 61);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.trvtimkiem);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridPhieuDH);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(707, 316);
            this.splitContainer1.SplitterDistance = 171;
            this.splitContainer1.TabIndex = 2;
            // 
            // trvtimkiem
            // 
            this.trvtimkiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvtimkiem.ImageIndex = 0;
            this.trvtimkiem.ImageList = this.imageList1;
            this.trvtimkiem.Location = new System.Drawing.Point(0, 50);
            this.trvtimkiem.Name = "trvtimkiem";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Tất cả";
            treeNode5.Name = "Node1";
            treeNode5.Text = "Đã trả";
            treeNode6.Name = "Node2";
            treeNode6.Text = "Còn nợ";
            this.trvtimkiem.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6});
            this.trvtimkiem.SelectedImageIndex = 0;
            this.trvtimkiem.Size = new System.Drawing.Size(171, 266);
            this.trvtimkiem.TabIndex = 2;
            this.trvtimkiem.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvtimkiem_AfterSelect);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(171, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // gridPhieuDH
            // 
            this.gridPhieuDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPhieuDH.Location = new System.Drawing.Point(0, 76);
            this.gridPhieuDH.MainView = this.gridView1;
            this.gridPhieuDH.Name = "gridPhieuDH";
            this.gridPhieuDH.Size = new System.Drawing.Size(532, 240);
            this.gridPhieuDH.TabIndex = 5;
            this.gridPhieuDH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridPhieuDH;
            this.gridView1.Name = "gridView1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbThem,
            this.tsbxoa,
            this.tsbsua,
            this.toolStripSeparator1,
            this.tsbIn,
            this.tsbref});
            this.toolStrip1.Location = new System.Drawing.Point(0, 51);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(532, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbThem
            // 
            this.tsbThem.Image = ((System.Drawing.Image)(resources.GetObject("tsbThem.Image")));
            this.tsbThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbThem.Name = "tsbThem";
            this.tsbThem.Size = new System.Drawing.Size(82, 22);
            this.tsbThem.Text = "Thêm mới";
            this.tsbThem.Click += new System.EventHandler(this.tsbThem_Click_1);
            // 
            // tsbxoa
            // 
            this.tsbxoa.Image = ((System.Drawing.Image)(resources.GetObject("tsbxoa.Image")));
            this.tsbxoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbxoa.Name = "tsbxoa";
            this.tsbxoa.Size = new System.Drawing.Size(47, 22);
            this.tsbxoa.Text = "Xóa";
            this.tsbxoa.Click += new System.EventHandler(this.tsbxoa_Click_1);
            // 
            // tsbsua
            // 
            this.tsbsua.Image = ((System.Drawing.Image)(resources.GetObject("tsbsua.Image")));
            this.tsbsua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbsua.Name = "tsbsua";
            this.tsbsua.Size = new System.Drawing.Size(80, 22);
            this.tsbsua.Text = "Chỉnh sữa";
            this.tsbsua.Click += new System.EventHandler(this.tsbsua_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbIn
            // 
            this.tsbIn.Image = ((System.Drawing.Image)(resources.GetObject("tsbIn.Image")));
            this.tsbIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbIn.Name = "tsbIn";
            this.tsbIn.Size = new System.Drawing.Size(38, 22);
            this.tsbIn.Text = "In";
            this.tsbIn.Click += new System.EventHandler(this.tsbIn_Click_1);
            // 
            // tsbref
            // 
            this.tsbref.Image = ((System.Drawing.Image)(resources.GetObject("tsbref.Image")));
            this.tsbref.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbref.Name = "tsbref";
            this.tsbref.Size = new System.Drawing.Size(68, 22);
            this.tsbref.Text = "Refresh";
            this.tsbref.Click += new System.EventHandler(this.tsbref_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lueMaNCC);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 51);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã NCC:";
            // 
            // lueMaNCC
            // 
            this.lueMaNCC.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.lueMaNCC.Location = new System.Drawing.Point(211, 15);
            this.lueMaNCC.Name = "lueMaNCC";
            this.lueMaNCC.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lueMaNCC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.lueMaNCC.Properties.DataSource = this.nHACUNGCAPBindingSource;
            this.lueMaNCC.Properties.DisplayMember = "MANCC";
            this.lueMaNCC.Properties.NullText = "Chọn mã nhà cung cấp";
            this.lueMaNCC.Properties.ShowClearButton = false;
            this.lueMaNCC.Properties.View = this.searchLookUpEdit1View;
            this.lueMaNCC.Size = new System.Drawing.Size(183, 20);
            this.lueMaNCC.TabIndex = 4;
            this.lueMaNCC.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.lueMaNCC_ButtonClick);
            this.lueMaNCC.EditValueChanged += new System.EventHandler(this.lueMaNCC_EditValueChanged_1);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MANCC,
            this.TENNCC,
            this.SDT});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // MANCC
            // 
            this.MANCC.Caption = "Mã NCC";
            this.MANCC.FieldName = "MANCC";
            this.MANCC.Name = "MANCC";
            this.MANCC.Visible = true;
            this.MANCC.VisibleIndex = 0;
            // 
            // TENNCC
            // 
            this.TENNCC.Caption = "Tên NCC";
            this.TENNCC.FieldName = "TENNCC";
            this.TENNCC.Name = "TENNCC";
            this.TENNCC.Visible = true;
            this.TENNCC.VisibleIndex = 1;
            // 
            // SDT
            // 
            this.SDT.Caption = "Điện Thoại";
            this.SDT.FieldName = "SDT";
            this.SDT.Name = "SDT";
            this.SDT.Visible = true;
            this.SDT.VisibleIndex = 2;
            // 
            // nHACUNGCAPTableAdapter
            // 
            this.nHACUNGCAPTableAdapter.ClearBeforeFill = true;
            // 
            // Phieudathang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 377);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "Phieudathang";
            this.Text = "Phiếu đặt hàng";
            this.Load += new System.EventHandler(this.Phieudathang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHACUNGCAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHDienThoaiDDDataSet8)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPhieuDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueMaNCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private QLCHDienThoaiDDDataSet8 qLCHDienThoaiDDDataSet8;
        private System.Windows.Forms.BindingSource nHACUNGCAPBindingSource;
        private QLCHDienThoaiDDDataSet8TableAdapters.NHACUNGCAPTableAdapter nHACUNGCAPTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbThem;
        private System.Windows.Forms.ToolStripButton tsbxoa;
        private System.Windows.Forms.ToolStripButton tsbsua;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbIn;
        private System.Windows.Forms.ToolStripButton tsbref;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.GridControl gridPhieuDH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TreeView trvtimkiem;
        private System.Windows.Forms.PictureBox pictureBox3;
        private DevExpress.XtraEditors.SearchLookUpEdit lueMaNCC;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn MANCC;
        private DevExpress.XtraGrid.Columns.GridColumn TENNCC;
        private DevExpress.XtraGrid.Columns.GridColumn SDT;
    }
}