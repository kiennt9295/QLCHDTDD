namespace QLCHDienThoaiDiDong
{
    partial class Xuatkho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Xuatkho));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lueTimkiem = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.hOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLCHDienThoaiDDDataSet7 = new QLCHDienThoaiDiDong.QLCHDienThoaiDDDataSet7();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbIn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRef = new System.Windows.Forms.ToolStripButton();
            this.gridXuatKho = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MACTHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DONVITINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.hOADONTableAdapter = new QLCHDienThoaiDiDong.QLCHDienThoaiDDDataSet7TableAdapters.HOADONTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueTimkiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHDienThoaiDDDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridXuatKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightYellow;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 50);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phiếu xuất hàng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.lueTimkiem);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(764, 47);
            this.panel2.TabIndex = 3;
            // 
            // lueTimkiem
            // 
            this.lueTimkiem.Location = new System.Drawing.Point(163, 17);
            this.lueTimkiem.Name = "lueTimkiem";
            this.lueTimkiem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.lueTimkiem.Properties.DataSource = this.hOADONBindingSource;
            this.lueTimkiem.Properties.DisplayMember = "MAHD";
            this.lueTimkiem.Properties.NullText = "Chọn mã hóa đơn";
            this.lueTimkiem.Properties.ShowClearButton = false;
            this.lueTimkiem.Properties.View = this.searchLookUpEdit1View;
            this.lueTimkiem.Size = new System.Drawing.Size(176, 20);
            this.lueTimkiem.TabIndex = 3;
            this.lueTimkiem.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.lueTimkiem_ButtonClick);
            this.lueTimkiem.EditValueChanged += new System.EventHandler(this.lueTimkiem_EditValueChanged_1);
            // 
            // hOADONBindingSource
            // 
            this.hOADONBindingSource.DataMember = "HOADON";
            this.hOADONBindingSource.DataSource = this.qLCHDienThoaiDDDataSet7;
            // 
            // qLCHDienThoaiDDDataSet7
            // 
            this.qLCHDienThoaiDDDataSet7.DataSetName = "QLCHDienThoaiDDDataSet7";
            this.qLCHDienThoaiDDDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã HĐ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tìm:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbIn,
            this.toolStripSeparator2,
            this.tsbRef});
            this.toolStrip1.Location = new System.Drawing.Point(0, 97);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(764, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbIn
            // 
            this.tsbIn.Image = ((System.Drawing.Image)(resources.GetObject("tsbIn.Image")));
            this.tsbIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbIn.Name = "tsbIn";
            this.tsbIn.Size = new System.Drawing.Size(38, 22);
            this.tsbIn.Text = "In";
            this.tsbIn.Click += new System.EventHandler(this.tsbIn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbRef
            // 
            this.tsbRef.Image = ((System.Drawing.Image)(resources.GetObject("tsbRef.Image")));
            this.tsbRef.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRef.Name = "tsbRef";
            this.tsbRef.Size = new System.Drawing.Size(68, 22);
            this.tsbRef.Text = "Refresh";
            this.tsbRef.Click += new System.EventHandler(this.tsbRef_Click);
            // 
            // gridXuatKho
            // 
            this.gridXuatKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridXuatKho.Location = new System.Drawing.Point(0, 122);
            this.gridXuatKho.MainView = this.gridView1;
            this.gridXuatKho.Name = "gridXuatKho";
            this.gridXuatKho.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridXuatKho.Size = new System.Drawing.Size(764, 277);
            this.gridXuatKho.TabIndex = 5;
            this.gridXuatKho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MACTHD,
            this.MAHD,
            this.MAMH,
            this.SOLUONG,
            this.DONVITINH});
            this.gridView1.GridControl = this.gridXuatKho;
            this.gridView1.Name = "gridView1";
            // 
            // MACTHD
            // 
            this.MACTHD.Caption = "Mã Phiếu";
            this.MACTHD.FieldName = "MACTHD";
            this.MACTHD.Name = "MACTHD";
            this.MACTHD.Visible = true;
            this.MACTHD.VisibleIndex = 0;
            // 
            // MAHD
            // 
            this.MAHD.Caption = "Mã HĐ";
            this.MAHD.FieldName = "MAHD";
            this.MAHD.Name = "MAHD";
            this.MAHD.Visible = true;
            this.MAHD.VisibleIndex = 1;
            // 
            // MAMH
            // 
            this.MAMH.Caption = "Mã MH";
            this.MAMH.FieldName = "MAMH";
            this.MAMH.Name = "MAMH";
            this.MAMH.Visible = true;
            this.MAMH.VisibleIndex = 2;
            // 
            // SOLUONG
            // 
            this.SOLUONG.Caption = "Số lượng";
            this.SOLUONG.FieldName = "SOLUONG";
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.Visible = true;
            this.SOLUONG.VisibleIndex = 3;
            // 
            // DONVITINH
            // 
            this.DONVITINH.Caption = "Đơn vị tính";
            this.DONVITINH.FieldName = "DONVITINH";
            this.DONVITINH.Name = "DONVITINH";
            this.DONVITINH.Visible = true;
            this.DONVITINH.VisibleIndex = 4;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Caption = "Check";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // hOADONTableAdapter
            // 
            this.hOADONTableAdapter.ClearBeforeFill = true;
            // 
            // Xuatkho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 399);
            this.Controls.Add(this.gridXuatKho);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Xuatkho";
            this.Text = "Xuất kho";
            this.Load += new System.EventHandler(this.Xuatkho_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueTimkiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHDienThoaiDDDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridXuatKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbIn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbRef;
        private DevExpress.XtraGrid.GridControl gridXuatKho;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label3;
        private QLCHDienThoaiDDDataSet7 qLCHDienThoaiDDDataSet7;
        private System.Windows.Forms.BindingSource hOADONBindingSource;
        private QLCHDienThoaiDDDataSet7TableAdapters.HOADONTableAdapter hOADONTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn MACTHD;
        private DevExpress.XtraGrid.Columns.GridColumn MAHD;
        private DevExpress.XtraGrid.Columns.GridColumn MAMH;
        private DevExpress.XtraGrid.Columns.GridColumn SOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn DONVITINH;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.SearchLookUpEdit lueTimkiem;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
    }
}