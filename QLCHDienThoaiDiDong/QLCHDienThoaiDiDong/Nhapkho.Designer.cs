namespace QLCHDienThoaiDiDong
{
    partial class Nhapkho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nhapkho));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNgaytu = new System.Windows.Forms.TextBox();
            this.txtngayden = new System.Windows.Forms.TextBox();
            this.luetimkiem = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.mATHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLCHDienThoaiDDDataSet14 = new QLCHDienThoaiDiDong.QLCHDienThoaiDDDataSet14();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DACDIEM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LOAIMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtpDenngay = new System.Windows.Forms.DateTimePicker();
            this.dtptungay = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridNhapkho = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tsbthem = new System.Windows.Forms.ToolStripButton();
            this.tsbxoa = new System.Windows.Forms.ToolStripButton();
            this.tsbsua = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbin = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbref = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mATHANGTableAdapter = new QLCHDienThoaiDiDong.QLCHDienThoaiDDDataSet14TableAdapters.MATHANGTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luetimkiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHDienThoaiDDDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNhapkho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 118);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtNgaytu);
            this.panel2.Controls.Add(this.txtngayden);
            this.panel2.Controls.Add(this.luetimkiem);
            this.panel2.Controls.Add(this.dtpDenngay);
            this.panel2.Controls.Add(this.dtptungay);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(874, 57);
            this.panel2.TabIndex = 3;
            // 
            // txtNgaytu
            // 
            this.txtNgaytu.Enabled = false;
            this.txtNgaytu.Location = new System.Drawing.Point(103, 16);
            this.txtNgaytu.Name = "txtNgaytu";
            this.txtNgaytu.Size = new System.Drawing.Size(116, 20);
            this.txtNgaytu.TabIndex = 14;
            this.txtNgaytu.Text = "Chọn ngày";
            // 
            // txtngayden
            // 
            this.txtngayden.Enabled = false;
            this.txtngayden.Location = new System.Drawing.Point(332, 16);
            this.txtngayden.Name = "txtngayden";
            this.txtngayden.Size = new System.Drawing.Size(116, 20);
            this.txtngayden.TabIndex = 13;
            this.txtngayden.Text = "Chọn ngày";
            // 
            // luetimkiem
            // 
            this.luetimkiem.Location = new System.Drawing.Point(590, 16);
            this.luetimkiem.Name = "luetimkiem";
            this.luetimkiem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.luetimkiem.Properties.DataSource = this.mATHANGBindingSource;
            this.luetimkiem.Properties.DisplayMember = "MAMH";
            this.luetimkiem.Properties.NullText = "Tìm kiếm";
            this.luetimkiem.Properties.ShowClearButton = false;
            this.luetimkiem.Properties.ValueMember = "MAMH";
            this.luetimkiem.Properties.View = this.searchLookUpEdit1View;
            this.luetimkiem.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.luetimkiem_Properties_ButtonClick);
            this.luetimkiem.Size = new System.Drawing.Size(179, 20);
            this.luetimkiem.TabIndex = 12;
            this.luetimkiem.EditValueChanged += new System.EventHandler(this.luetimkiem_EditValueChanged_1);
            // 
            // mATHANGBindingSource
            // 
            this.mATHANGBindingSource.DataMember = "MATHANG";
            this.mATHANGBindingSource.DataSource = this.qLCHDienThoaiDDDataSet14;
            // 
            // qLCHDienThoaiDDDataSet14
            // 
            this.qLCHDienThoaiDDDataSet14.DataSetName = "QLCHDienThoaiDDDataSet14";
            this.qLCHDienThoaiDDDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MAMH,
            this.TENMH,
            this.HINH,
            this.DACDIEM,
            this.LOAIMH});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // MAMH
            // 
            this.MAMH.Caption = "Mã MH";
            this.MAMH.FieldName = "MAMH";
            this.MAMH.Name = "MAMH";
            this.MAMH.Visible = true;
            this.MAMH.VisibleIndex = 0;
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
            this.DACDIEM.Caption = "Đặc Điểm";
            this.DACDIEM.FieldName = "DACDIEM";
            this.DACDIEM.Name = "DACDIEM";
            this.DACDIEM.Visible = true;
            this.DACDIEM.VisibleIndex = 3;
            // 
            // LOAIMH
            // 
            this.LOAIMH.Caption = "Loai MH";
            this.LOAIMH.FieldName = "LOAIMH";
            this.LOAIMH.Name = "LOAIMH";
            this.LOAIMH.Visible = true;
            this.LOAIMH.VisibleIndex = 4;
            // 
            // dtpDenngay
            // 
            this.dtpDenngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenngay.Location = new System.Drawing.Point(354, 16);
            this.dtpDenngay.Name = "dtpDenngay";
            this.dtpDenngay.Size = new System.Drawing.Size(122, 20);
            this.dtpDenngay.TabIndex = 11;
            this.dtpDenngay.ValueChanged += new System.EventHandler(this.dtpDenngay_ValueChanged);
            // 
            // dtptungay
            // 
            this.dtptungay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtptungay.Location = new System.Drawing.Point(141, 16);
            this.dtptungay.Name = "dtptungay";
            this.dtptungay.Size = new System.Drawing.Size(108, 20);
            this.dtptungay.TabIndex = 10;
            this.dtptungay.ValueChanged += new System.EventHandler(this.dtptungay_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Từ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(521, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mã MH:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(284, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Đến:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tìm:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(874, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
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
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý kho hàng";
            // 
            // gridNhapkho
            // 
            this.gridNhapkho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridNhapkho.Location = new System.Drawing.Point(0, 143);
            this.gridNhapkho.MainView = this.gridView1;
            this.gridNhapkho.Name = "gridNhapkho";
            this.gridNhapkho.Size = new System.Drawing.Size(874, 276);
            this.gridNhapkho.TabIndex = 4;
            this.gridNhapkho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridNhapkho;
            this.gridView1.Name = "gridView1";
            // 
            // tsbthem
            // 
            this.tsbthem.Image = ((System.Drawing.Image)(resources.GetObject("tsbthem.Image")));
            this.tsbthem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbthem.Name = "tsbthem";
            this.tsbthem.Size = new System.Drawing.Size(89, 22);
            this.tsbthem.Text = "Thêm mới";
            this.tsbthem.Click += new System.EventHandler(this.tsbthem_Click);
            // 
            // tsbxoa
            // 
            this.tsbxoa.Image = ((System.Drawing.Image)(resources.GetObject("tsbxoa.Image")));
            this.tsbxoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbxoa.Name = "tsbxoa";
            this.tsbxoa.Size = new System.Drawing.Size(51, 22);
            this.tsbxoa.Text = "Xóa";
            this.tsbxoa.Click += new System.EventHandler(this.tsbxoa_Click);
            // 
            // tsbsua
            // 
            this.tsbsua.Image = ((System.Drawing.Image)(resources.GetObject("tsbsua.Image")));
            this.tsbsua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbsua.Name = "tsbsua";
            this.tsbsua.Size = new System.Drawing.Size(89, 22);
            this.tsbsua.Text = "Chỉnh sữa";
            this.tsbsua.Click += new System.EventHandler(this.tsbsua_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbin
            // 
            this.tsbin.Image = ((System.Drawing.Image)(resources.GetObject("tsbin.Image")));
            this.tsbin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbin.Name = "tsbin";
            this.tsbin.Size = new System.Drawing.Size(40, 22);
            this.tsbin.Text = "In";
            this.tsbin.Click += new System.EventHandler(this.tsbin_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbref
            // 
            this.tsbref.Image = ((System.Drawing.Image)(resources.GetObject("tsbref.Image")));
            this.tsbref.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbref.Name = "tsbref";
            this.tsbref.Size = new System.Drawing.Size(74, 22);
            this.tsbref.Text = "Refresh";
            this.tsbref.Click += new System.EventHandler(this.tsbref_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.toolStrip1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbthem,
            this.tsbxoa,
            this.tsbsua,
            this.toolStripSeparator1,
            this.tsbin,
            this.toolStripSeparator2,
            this.tsbref});
            this.toolStrip1.Location = new System.Drawing.Point(0, 118);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(874, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // mATHANGTableAdapter
            // 
            this.mATHANGTableAdapter.ClearBeforeFill = true;
            // 
            // Nhapkho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 419);
            this.Controls.Add(this.gridNhapkho);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "Nhapkho";
            this.Text = "Nhập kho";
            this.Load += new System.EventHandler(this.Nhapkho_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luetimkiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHDienThoaiDDDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNhapkho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridNhapkho;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripButton tsbthem;
        private System.Windows.Forms.ToolStripButton tsbxoa;
        private System.Windows.Forms.ToolStripButton tsbsua;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbin;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbref;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDenngay;
        private System.Windows.Forms.DateTimePicker dtptungay;
        private DevExpress.XtraEditors.SearchLookUpEdit luetimkiem;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.TextBox txtngayden;
        private System.Windows.Forms.TextBox txtNgaytu;
        private DevExpress.XtraGrid.Columns.GridColumn MAMH;
        private DevExpress.XtraGrid.Columns.GridColumn TENMH;
        private DevExpress.XtraGrid.Columns.GridColumn HINH;
        private DevExpress.XtraGrid.Columns.GridColumn DACDIEM;
        private DevExpress.XtraGrid.Columns.GridColumn LOAIMH;
        private QLCHDienThoaiDDDataSet14 qLCHDienThoaiDDDataSet14;
        private System.Windows.Forms.BindingSource mATHANGBindingSource;
        private QLCHDienThoaiDDDataSet14TableAdapters.MATHANGTableAdapter mATHANGTableAdapter;
    }
}