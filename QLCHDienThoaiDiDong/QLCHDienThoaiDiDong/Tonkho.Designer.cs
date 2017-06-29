namespace QLCHDienThoaiDiDong
{
    partial class Tonkho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tonkho));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.trvtimkiem = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.gridLoaiMH = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridTonkho = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SLNHAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SLBAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SLCON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbREf = new System.Windows.Forms.ToolStripButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.luetimkiem = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.mATHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLCHDienThoaiDDDataSet16 = new QLCHDienThoaiDiDong.QLCHDienThoaiDDDataSet16();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MAMH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DACDIEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.mATHANGTableAdapter = new QLCHDienThoaiDiDong.QLCHDienThoaiDDDataSet16TableAdapters.MATHANGTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLoaiMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTonkho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luetimkiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHDienThoaiDDDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 48);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xem kho hàng";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 48);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.trvtimkiem);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridLoaiMH);
            this.splitContainer1.Panel2.Controls.Add(this.gridTonkho);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Size = new System.Drawing.Size(738, 362);
            this.splitContainer1.SplitterDistance = 207;
            this.splitContainer1.TabIndex = 2;
            // 
            // trvtimkiem
            // 
            this.trvtimkiem.BackColor = System.Drawing.Color.White;
            this.trvtimkiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvtimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvtimkiem.ImageIndex = 0;
            this.trvtimkiem.ImageList = this.imageList1;
            this.trvtimkiem.Location = new System.Drawing.Point(0, 38);
            this.trvtimkiem.Name = "trvtimkiem";
            this.trvtimkiem.SelectedImageIndex = 0;
            this.trvtimkiem.Size = new System.Drawing.Size(207, 324);
            this.trvtimkiem.TabIndex = 2;
            this.trvtimkiem.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvtimkiem_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "PoisonMushroom.png");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 38);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhóm mặt hàng";
            // 
            // gridLoaiMH
            // 
            this.gridLoaiMH.Enabled = false;
            this.gridLoaiMH.Location = new System.Drawing.Point(-211, 346);
            this.gridLoaiMH.MainView = this.gridView2;
            this.gridLoaiMH.Name = "gridLoaiMH";
            this.gridLoaiMH.Size = new System.Drawing.Size(139, 168);
            this.gridLoaiMH.TabIndex = 3;
            this.gridLoaiMH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridLoaiMH;
            this.gridView2.Name = "gridView2";
            // 
            // gridTonkho
            // 
            this.gridTonkho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTonkho.Location = new System.Drawing.Point(0, 63);
            this.gridTonkho.MainView = this.gridView1;
            this.gridTonkho.Name = "gridTonkho";
            this.gridTonkho.Size = new System.Drawing.Size(527, 299);
            this.gridTonkho.TabIndex = 3;
            this.gridTonkho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MAMH,
            this.SLNHAP,
            this.SLBAN,
            this.SLCON});
            this.gridView1.GridControl = this.gridTonkho;
            this.gridView1.Name = "gridView1";
            // 
            // MAMH
            // 
            this.MAMH.Caption = "Mã MH";
            this.MAMH.FieldName = "MAMH";
            this.MAMH.Name = "MAMH";
            this.MAMH.Visible = true;
            this.MAMH.VisibleIndex = 0;
            // 
            // SLNHAP
            // 
            this.SLNHAP.Caption = "Số lượng nhập";
            this.SLNHAP.FieldName = "SLNHAP";
            this.SLNHAP.Name = "SLNHAP";
            this.SLNHAP.Visible = true;
            this.SLNHAP.VisibleIndex = 1;
            // 
            // SLBAN
            // 
            this.SLBAN.Caption = "Số lượng bán";
            this.SLBAN.FieldName = "SLBAN";
            this.SLBAN.Name = "SLBAN";
            this.SLBAN.Visible = true;
            this.SLBAN.VisibleIndex = 2;
            // 
            // SLCON
            // 
            this.SLCON.Caption = "Số lượng còn";
            this.SLCON.FieldName = "SLCON";
            this.SLCON.Name = "SLCON";
            this.SLCON.Visible = true;
            this.SLCON.VisibleIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbREf});
            this.toolStrip1.Location = new System.Drawing.Point(0, 38);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(527, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbREf
            // 
            this.tsbREf.Image = ((System.Drawing.Image)(resources.GetObject("tsbREf.Image")));
            this.tsbREf.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbREf.Name = "tsbREf";
            this.tsbREf.Size = new System.Drawing.Size(68, 22);
            this.tsbREf.Text = "Refresh";
            this.tsbREf.Click += new System.EventHandler(this.tsbREf_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.luetimkiem);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(527, 38);
            this.panel3.TabIndex = 1;
            // 
            // luetimkiem
            // 
            this.luetimkiem.Location = new System.Drawing.Point(74, 9);
            this.luetimkiem.Name = "luetimkiem";
            this.luetimkiem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.luetimkiem.Properties.DataSource = this.mATHANGBindingSource;
            this.luetimkiem.Properties.DisplayMember = "MAMH";
            this.luetimkiem.Properties.NullText = "Chọn mã mặt hàng";
            this.luetimkiem.Properties.ShowClearButton = false;
            this.luetimkiem.Properties.ValueMember = "MAMH";
            this.luetimkiem.Properties.View = this.searchLookUpEdit1View;
            this.luetimkiem.Size = new System.Drawing.Size(192, 20);
            this.luetimkiem.TabIndex = 2;
            this.luetimkiem.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.luetimkiem_ButtonClick);
            this.luetimkiem.EditValueChanged += new System.EventHandler(this.luetimkiem_EditValueChanged_1);
            // 
            // mATHANGBindingSource
            // 
            this.mATHANGBindingSource.DataMember = "MATHANG";
            this.mATHANGBindingSource.DataSource = this.qLCHDienThoaiDDDataSet16;
            // 
            // qLCHDienThoaiDDDataSet16
            // 
            this.qLCHDienThoaiDDDataSet16.DataSetName = "QLCHDienThoaiDDDataSet16";
            this.qLCHDienThoaiDDDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MAMH1,
            this.TENMH,
            this.HINH,
            this.DACDIEM});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // MAMH1
            // 
            this.MAMH1.Caption = "Mã MH";
            this.MAMH1.FieldName = "MAMH";
            this.MAMH1.Name = "MAMH1";
            this.MAMH1.Visible = true;
            this.MAMH1.VisibleIndex = 0;
            // 
            // TENMH
            // 
            this.TENMH.Caption = "Tên MH";
            this.TENMH.FieldName = "TENMH";
            this.TENMH.Name = "TENMH";
            this.TENMH.Visible = true;
            this.TENMH.VisibleIndex = 1;
            // 
            // HINH
            // 
            this.HINH.Caption = "Hình";
            this.HINH.FieldName = "HINH";
            this.HINH.Name = "HINH";
            this.HINH.Visible = true;
            this.HINH.VisibleIndex = 2;
            // 
            // DACDIEM
            // 
            this.DACDIEM.Caption = "Đặc điểm";
            this.DACDIEM.FieldName = "DACDIEM";
            this.DACDIEM.Name = "DACDIEM";
            this.DACDIEM.Visible = true;
            this.DACDIEM.VisibleIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tìm:";
            // 
            // mATHANGTableAdapter
            // 
            this.mATHANGTableAdapter.ClearBeforeFill = true;
            // 
            // Tonkho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(738, 410);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "Tonkho";
            this.Text = "Tồn kho";
            this.Load += new System.EventHandler(this.Tonkho_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLoaiMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTonkho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luetimkiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHDienThoaiDDDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView trvtimkiem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.GridControl gridTonkho;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbREf;
        private DevExpress.XtraGrid.Columns.GridColumn MAMH;
        private DevExpress.XtraGrid.Columns.GridColumn SLNHAP;
        private DevExpress.XtraGrid.Columns.GridColumn SLBAN;
        private DevExpress.XtraGrid.Columns.GridColumn SLCON;
        private DevExpress.XtraEditors.SearchLookUpEdit luetimkiem;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn MAMH1;
        private DevExpress.XtraGrid.Columns.GridColumn TENMH;
        private DevExpress.XtraGrid.Columns.GridColumn HINH;
        private DevExpress.XtraGrid.Columns.GridColumn DACDIEM;
        private QLCHDienThoaiDDDataSet16 qLCHDienThoaiDDDataSet16;
        private System.Windows.Forms.BindingSource mATHANGBindingSource;
        private QLCHDienThoaiDDDataSet16TableAdapters.MATHANGTableAdapter mATHANGTableAdapter;
        private DevExpress.XtraGrid.GridControl gridLoaiMH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}