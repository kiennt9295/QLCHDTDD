namespace QLCHDienThoaiDiDong
{
    partial class Nhapkho1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nhapkho1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmapn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLCHDienThoaiDDDataSet5 = new QLCHDienThoaiDiDong.QLCHDienThoaiDDDataSet5();
            this.dtpngaynhap = new System.Windows.Forms.DateTimePicker();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.nHANVIENTableAdapter = new QLCHDienThoaiDiDong.QLCHDienThoaiDDDataSet5TableAdapters.NHANVIENTableAdapter();
            this.luemamh = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.mATHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLCHDienThoaiDDDataSet15 = new QLCHDienThoaiDiDong.QLCHDienThoaiDDDataSet15();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MAMH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENMH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LOAIMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.luemanv = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MANV1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MABP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mATHANGTableAdapter = new QLCHDienThoaiDiDong.QLCHDienThoaiDDDataSet15TableAdapters.MATHANGTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHDienThoaiDDDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luemamh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHDienThoaiDDDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luemanv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(355, 52);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý kho hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã phiếu nhập:";
            // 
            // txtmapn
            // 
            this.txtmapn.Enabled = false;
            this.txtmapn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmapn.Location = new System.Drawing.Point(135, 80);
            this.txtmapn.Name = "txtmapn";
            this.txtmapn.Size = new System.Drawing.Size(200, 21);
            this.txtmapn.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã mặt hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mã nhân viên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày nhập:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Số lượng:";
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.qLCHDienThoaiDDDataSet5;
            // 
            // qLCHDienThoaiDDDataSet5
            // 
            this.qLCHDienThoaiDDDataSet5.DataSetName = "QLCHDienThoaiDDDataSet5";
            this.qLCHDienThoaiDDDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpngaynhap
            // 
            this.dtpngaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaynhap.Location = new System.Drawing.Point(135, 165);
            this.dtpngaynhap.Name = "dtpngaynhap";
            this.dtpngaynhap.Size = new System.Drawing.Size(200, 20);
            this.dtpngaynhap.TabIndex = 12;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsoluong.Location = new System.Drawing.Point(135, 193);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(200, 21);
            this.txtsoluong.TabIndex = 13;
            // 
            // btnluu
            // 
            this.btnluu.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.Image")));
            this.btnluu.Location = new System.Drawing.Point(34, 240);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(100, 34);
            this.btnluu.TabIndex = 14;
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Image = ((System.Drawing.Image)(resources.GetObject("btnhuy.Image")));
            this.btnhuy.Location = new System.Drawing.Point(159, 240);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 34);
            this.btnhuy.TabIndex = 15;
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.Location = new System.Drawing.Point(260, 240);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 34);
            this.btnthoat.TabIndex = 16;
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // luemamh
            // 
            this.luemamh.Location = new System.Drawing.Point(135, 110);
            this.luemamh.Name = "luemamh";
            this.luemamh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luemamh.Properties.DataSource = this.mATHANGBindingSource;
            this.luemamh.Properties.DisplayMember = "MAMH";
            this.luemamh.Properties.NullText = "";
            this.luemamh.Properties.ShowClearButton = false;
            this.luemamh.Properties.ValueMember = "MAMH";
            this.luemamh.Properties.View = this.searchLookUpEdit1View;
            this.luemamh.Size = new System.Drawing.Size(200, 20);
            this.luemamh.TabIndex = 17;
            this.luemamh.EditValueChanged += new System.EventHandler(this.luemamh_EditValueChanged);
            // 
            // mATHANGBindingSource
            // 
            this.mATHANGBindingSource.DataMember = "MATHANG";
            this.mATHANGBindingSource.DataSource = this.qLCHDienThoaiDDDataSet15;
            // 
            // qLCHDienThoaiDDDataSet15
            // 
            this.qLCHDienThoaiDDDataSet15.DataSetName = "QLCHDienThoaiDDDataSet15";
            this.qLCHDienThoaiDDDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MAMH1,
            this.TENMH1,
            this.HINH,
            this.LOAIMH});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // MAMH1
            // 
            this.MAMH1.Caption = "MA MH";
            this.MAMH1.FieldName = "MAMH";
            this.MAMH1.Name = "MAMH1";
            this.MAMH1.Visible = true;
            this.MAMH1.VisibleIndex = 0;
            // 
            // TENMH1
            // 
            this.TENMH1.Caption = "TENMH";
            this.TENMH1.FieldName = "TENMH";
            this.TENMH1.Name = "TENMH1";
            this.TENMH1.Visible = true;
            this.TENMH1.VisibleIndex = 1;
            // 
            // HINH
            // 
            this.HINH.Caption = "HINH";
            this.HINH.FieldName = "HINH";
            this.HINH.Name = "HINH";
            this.HINH.Visible = true;
            this.HINH.VisibleIndex = 2;
            // 
            // LOAIMH
            // 
            this.LOAIMH.Caption = "LOAIMH";
            this.LOAIMH.FieldName = "LOAIMH";
            this.LOAIMH.Name = "LOAIMH";
            this.LOAIMH.Visible = true;
            this.LOAIMH.VisibleIndex = 3;
            // 
            // luemanv
            // 
            this.luemanv.Location = new System.Drawing.Point(135, 138);
            this.luemanv.Name = "luemanv";
            this.luemanv.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luemanv.Properties.DataSource = this.nHANVIENBindingSource;
            this.luemanv.Properties.DisplayMember = "MANV";
            this.luemanv.Properties.NullText = "";
            this.luemanv.Properties.ShowClearButton = false;
            this.luemanv.Properties.ValueMember = "MANV";
            this.luemanv.Properties.View = this.gridView1;
            this.luemanv.Size = new System.Drawing.Size(200, 20);
            this.luemanv.TabIndex = 18;
            this.luemanv.EditValueChanged += new System.EventHandler(this.luemanv_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MANV1,
            this.HOTEN,
            this.SDT,
            this.MABP});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // MANV1
            // 
            this.MANV1.Caption = "MANV";
            this.MANV1.FieldName = "MANV";
            this.MANV1.Name = "MANV1";
            this.MANV1.Visible = true;
            this.MANV1.VisibleIndex = 0;
            // 
            // HOTEN
            // 
            this.HOTEN.Caption = "HOTEN";
            this.HOTEN.FieldName = "HOTEN";
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Visible = true;
            this.HOTEN.VisibleIndex = 1;
            // 
            // SDT
            // 
            this.SDT.Caption = "DIEN THOAI";
            this.SDT.FieldName = "SDT";
            this.SDT.Name = "SDT";
            this.SDT.Visible = true;
            this.SDT.VisibleIndex = 2;
            // 
            // MABP
            // 
            this.MABP.Caption = "MABP";
            this.MABP.FieldName = "MABP";
            this.MABP.Name = "MABP";
            this.MABP.Visible = true;
            this.MABP.VisibleIndex = 3;
            // 
            // mATHANGTableAdapter
            // 
            this.mATHANGTableAdapter.ClearBeforeFill = true;
            // 
            // Nhapkho1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(355, 296);
            this.Controls.Add(this.luemanv);
            this.Controls.Add(this.luemamh);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.dtpngaynhap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmapn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Nhapkho1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập kho";
            this.Load += new System.EventHandler(this.Nhapkho1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHDienThoaiDDDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luemamh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHDienThoaiDDDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luemanv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmapn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpngaynhap;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnthoat;
        private QLCHDienThoaiDDDataSet5 qLCHDienThoaiDDDataSet5;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private QLCHDienThoaiDDDataSet5TableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private DevExpress.XtraEditors.SearchLookUpEdit luemamh;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SearchLookUpEdit luemanv;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn SDT;
        private DevExpress.XtraGrid.Columns.GridColumn MABP;
        private QLCHDienThoaiDDDataSet15 qLCHDienThoaiDDDataSet15;
        private System.Windows.Forms.BindingSource mATHANGBindingSource;
        private QLCHDienThoaiDDDataSet15TableAdapters.MATHANGTableAdapter mATHANGTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn TENMH1;
        private DevExpress.XtraGrid.Columns.GridColumn HINH;
        private DevExpress.XtraGrid.Columns.GridColumn LOAIMH;
        private DevExpress.XtraGrid.Columns.GridColumn MAMH1;
        private DevExpress.XtraGrid.Columns.GridColumn MANV1;
    }
}