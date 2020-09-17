namespace QuanLiNhaTro
{
    partial class frm_HopDong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_HopDong));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_them = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_xoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_sua = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_luu = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_thoat = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.txt_tim = new System.Windows.Forms.ToolStripTextBox();
            this.btn_tim = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_xemin = new System.Windows.Forms.ToolStripButton();
            this.txt_ngaybd = new System.Windows.Forms.DateTimePicker();
            this.txt_ngaykt = new System.Windows.Forms.DateTimePicker();
            this.lbl_mahd = new System.Windows.Forms.Label();
            this.lbl_makh = new System.Windows.Forms.Label();
            this.lbl_maph = new System.Windows.Forms.Label();
            this.txt_mahd = new System.Windows.Forms.TextBox();
            this.lbl_ngaybd = new System.Windows.Forms.Label();
            this.dtgv_hopdong = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_ngaylamhd = new System.Windows.Forms.Label();
            this.lbl_ngaykt = new System.Windows.Forms.Label();
            this.lbl_tiencoc = new System.Windows.Forms.Label();
            this.txt_tiencoc = new System.Windows.Forms.TextBox();
            this.cboMaKH = new System.Windows.Forms.ComboBox();
            this.cboMaPH = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_ngaylamhd = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_hopdong)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_them,
            this.toolStripSeparator1,
            this.btn_xoa,
            this.toolStripSeparator2,
            this.btn_sua,
            this.toolStripSeparator3,
            this.btn_luu,
            this.toolStripSeparator4,
            this.btn_thoat,
            this.toolStripSeparator5,
            this.txt_tim,
            this.btn_tim,
            this.toolStripSeparator6,
            this.btn_xemin});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(986, 35);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_them
            // 
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(84, 32);
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(70, 32);
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // btn_sua
            // 
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(69, 32);
            this.btn_sua.Text = "Sửa";
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 35);
            // 
            // btn_luu
            // 
            this.btn_luu.Image = ((System.Drawing.Image)(resources.GetObject("btn_luu.Image")));
            this.btn_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_luu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(68, 32);
            this.btn_luu.Text = "Lưu";
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 35);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.Image")));
            this.btn_thoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(86, 32);
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 35);
            // 
            // txt_tim
            // 
            this.txt_tim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tim.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(150, 35);
            this.txt_tim.Tag = "";
            this.txt_tim.Text = "Mã hợp đồng";
            // 
            // btn_tim
            // 
            this.btn_tim.Image = ((System.Drawing.Image)(resources.GetObject("btn_tim.Image")));
            this.btn_tim.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(115, 32);
            this.btn_tim.Text = "Tìm kiếm";
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 35);
            // 
            // btn_xemin
            // 
            this.btn_xemin.Image = ((System.Drawing.Image)(resources.GetObject("btn_xemin.Image")));
            this.btn_xemin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_xemin.Name = "btn_xemin";
            this.btn_xemin.Size = new System.Drawing.Size(96, 32);
            this.btn_xemin.Text = "Xem in";
            this.btn_xemin.Click += new System.EventHandler(this.btn_xemin_Click);
            // 
            // txt_ngaybd
            // 
            this.txt_ngaybd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_ngaybd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_ngaybd.Location = new System.Drawing.Point(3, 3);
            this.txt_ngaybd.Name = "txt_ngaybd";
            this.txt_ngaybd.Size = new System.Drawing.Size(283, 30);
            this.txt_ngaybd.TabIndex = 0;
            this.txt_ngaybd.Value = new System.DateTime(2020, 7, 17, 0, 0, 0, 0);
            this.txt_ngaybd.ValueChanged += new System.EventHandler(this.txt_ngaybd_ValueChanged);
            // 
            // txt_ngaykt
            // 
            this.txt_ngaykt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_ngaykt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_ngaykt.Location = new System.Drawing.Point(3, 3);
            this.txt_ngaykt.Name = "txt_ngaykt";
            this.txt_ngaykt.Size = new System.Drawing.Size(283, 30);
            this.txt_ngaykt.TabIndex = 0;
            this.txt_ngaykt.Value = new System.DateTime(2020, 7, 17, 0, 0, 0, 0);
            // 
            // lbl_mahd
            // 
            this.lbl_mahd.AutoSize = true;
            this.lbl_mahd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_mahd.Location = new System.Drawing.Point(4, 0);
            this.lbl_mahd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_mahd.Name = "lbl_mahd";
            this.lbl_mahd.Size = new System.Drawing.Size(187, 45);
            this.lbl_mahd.TabIndex = 0;
            this.lbl_mahd.Text = "Mã hợp đồng";
            this.lbl_mahd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_makh
            // 
            this.lbl_makh.AutoSize = true;
            this.lbl_makh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_makh.Location = new System.Drawing.Point(3, 45);
            this.lbl_makh.Name = "lbl_makh";
            this.lbl_makh.Size = new System.Drawing.Size(189, 45);
            this.lbl_makh.TabIndex = 1;
            this.lbl_makh.Text = "Mã khách hàng";
            this.lbl_makh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_maph
            // 
            this.lbl_maph.AutoSize = true;
            this.lbl_maph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_maph.Location = new System.Drawing.Point(3, 90);
            this.lbl_maph.Name = "lbl_maph";
            this.lbl_maph.Size = new System.Drawing.Size(189, 45);
            this.lbl_maph.TabIndex = 2;
            this.lbl_maph.Text = "Mã phòng";
            this.lbl_maph.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_mahd
            // 
            this.txt_mahd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_mahd.Location = new System.Drawing.Point(198, 3);
            this.txt_mahd.Name = "txt_mahd";
            this.txt_mahd.Size = new System.Drawing.Size(287, 30);
            this.txt_mahd.TabIndex = 3;
            this.txt_mahd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_ngaybd
            // 
            this.lbl_ngaybd.AutoSize = true;
            this.lbl_ngaybd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_ngaybd.Location = new System.Drawing.Point(491, 0);
            this.lbl_ngaybd.Name = "lbl_ngaybd";
            this.lbl_ngaybd.Size = new System.Drawing.Size(189, 45);
            this.lbl_ngaybd.TabIndex = 6;
            this.lbl_ngaybd.Text = "Ngày bắt đầu";
            this.lbl_ngaybd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtgv_hopdong
            // 
            this.dtgv_hopdong.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_hopdong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_hopdong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column7,
            this.Column5,
            this.Column6});
            this.dtgv_hopdong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_hopdong.Location = new System.Drawing.Point(4, 197);
            this.dtgv_hopdong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgv_hopdong.Name = "dtgv_hopdong";
            this.dtgv_hopdong.RowHeadersWidth = 51;
            this.dtgv_hopdong.Size = new System.Drawing.Size(978, 279);
            this.dtgv_hopdong.TabIndex = 0;
            this.dtgv_hopdong.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_hopdong_CellEnter);
            this.dtgv_hopdong.Click += new System.EventHandler(this.dtgv_hopdong_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaHD";
            this.Column1.HeaderText = "Mã hợp đồng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaKH";
            this.Column2.HeaderText = "Mã khách hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MaPH";
            this.Column3.HeaderText = "Mã phòng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NgayLamHD";
            this.Column4.HeaderText = "Ngày làm HD";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "NgayBD";
            this.Column7.HeaderText = "Ngày bắt đầu";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NgayKT";
            this.Column5.HeaderText = "Ngày kết thúc";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TienCoc";
            this.Column6.HeaderText = "Tiền cọc";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dtgv_hopdong, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 35);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(986, 481);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_mahd, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_makh, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_maph, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txt_mahd, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_ngaybd, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_ngaylamhd, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbl_ngaykt, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_tiencoc, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.txt_tiencoc, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.cboMaKH, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cboMaPH, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 3, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(978, 182);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lbl_ngaylamhd
            // 
            this.lbl_ngaylamhd.AutoSize = true;
            this.lbl_ngaylamhd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_ngaylamhd.Location = new System.Drawing.Point(3, 135);
            this.lbl_ngaylamhd.Name = "lbl_ngaylamhd";
            this.lbl_ngaylamhd.Size = new System.Drawing.Size(189, 47);
            this.lbl_ngaylamhd.TabIndex = 7;
            this.lbl_ngaylamhd.Text = "Ngày làm hợp đồng";
            this.lbl_ngaylamhd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_ngaykt
            // 
            this.lbl_ngaykt.AutoSize = true;
            this.lbl_ngaykt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_ngaykt.Location = new System.Drawing.Point(491, 45);
            this.lbl_ngaykt.Name = "lbl_ngaykt";
            this.lbl_ngaykt.Size = new System.Drawing.Size(189, 45);
            this.lbl_ngaykt.TabIndex = 9;
            this.lbl_ngaykt.Text = "Ngày kết thúc";
            this.lbl_ngaykt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_tiencoc
            // 
            this.lbl_tiencoc.AutoSize = true;
            this.lbl_tiencoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_tiencoc.Location = new System.Drawing.Point(491, 90);
            this.lbl_tiencoc.Name = "lbl_tiencoc";
            this.lbl_tiencoc.Size = new System.Drawing.Size(189, 45);
            this.lbl_tiencoc.TabIndex = 10;
            this.lbl_tiencoc.Text = "Tiền cọc";
            this.lbl_tiencoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_tiencoc
            // 
            this.txt_tiencoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_tiencoc.Location = new System.Drawing.Point(686, 93);
            this.txt_tiencoc.Name = "txt_tiencoc";
            this.txt_tiencoc.Size = new System.Drawing.Size(289, 30);
            this.txt_tiencoc.TabIndex = 13;
            this.txt_tiencoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_tiencoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tiencoc_KeyPress);
            // 
            // cboMaKH
            // 
            this.cboMaKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboMaKH.FormattingEnabled = true;
            this.cboMaKH.Location = new System.Drawing.Point(198, 48);
            this.cboMaKH.Name = "cboMaKH";
            this.cboMaKH.Size = new System.Drawing.Size(287, 33);
            this.cboMaKH.TabIndex = 17;
            // 
            // cboMaPH
            // 
            this.cboMaPH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboMaPH.FormattingEnabled = true;
            this.cboMaPH.Location = new System.Drawing.Point(198, 93);
            this.cboMaPH.Name = "cboMaPH";
            this.cboMaPH.Size = new System.Drawing.Size(287, 33);
            this.cboMaPH.TabIndex = 18;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.99248F));
            this.tableLayoutPanel3.Controls.Add(this.txt_ngaylamhd, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(198, 138);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(287, 41);
            this.tableLayoutPanel3.TabIndex = 21;
            // 
            // txt_ngaylamhd
            // 
            this.txt_ngaylamhd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_ngaylamhd.Location = new System.Drawing.Point(3, 3);
            this.txt_ngaylamhd.MaxDate = new System.DateTime(2020, 8, 31, 0, 0, 0, 0);
            this.txt_ngaylamhd.MinDate = new System.DateTime(2020, 7, 17, 0, 0, 0, 0);
            this.txt_ngaylamhd.Name = "txt_ngaylamhd";
            this.txt_ngaylamhd.Size = new System.Drawing.Size(281, 30);
            this.txt_ngaylamhd.TabIndex = 0;
            this.txt_ngaylamhd.Value = new System.DateTime(2020, 7, 17, 0, 0, 0, 0);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.02898F));
            this.tableLayoutPanel4.Controls.Add(this.txt_ngaybd, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(686, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(289, 39);
            this.tableLayoutPanel4.TabIndex = 22;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.02898F));
            this.tableLayoutPanel5.Controls.Add(this.txt_ngaykt, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(686, 48);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(289, 39);
            this.tableLayoutPanel5.TabIndex = 23;
            // 
            // frm_HopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(986, 516);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_HopDong";
            this.Text = "HỢP ĐỒNG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_HopDong_FormClosing);
            this.Load += new System.EventHandler(this.frm_HopDong_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_hopdong)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_them;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_xoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_sua;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btn_luu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btn_thoat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripTextBox txt_tim;
        private System.Windows.Forms.ToolStripButton btn_tim;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btn_xemin;
        private System.Windows.Forms.DateTimePicker txt_ngaybd;
        private System.Windows.Forms.DateTimePicker txt_ngaykt;
        private System.Windows.Forms.Label lbl_mahd;
        private System.Windows.Forms.Label lbl_makh;
        private System.Windows.Forms.Label lbl_maph;
        private System.Windows.Forms.TextBox txt_mahd;
        private System.Windows.Forms.Label lbl_ngaybd;
        private System.Windows.Forms.DataGridView dtgv_hopdong;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_ngaylamhd;
        private System.Windows.Forms.Label lbl_ngaykt;
        private System.Windows.Forms.Label lbl_tiencoc;
        private System.Windows.Forms.TextBox txt_tiencoc;
        private System.Windows.Forms.ComboBox cboMaKH;
        private System.Windows.Forms.ComboBox cboMaPH;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DateTimePicker txt_ngaylamhd;
    }
}