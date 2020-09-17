namespace QuanLiNhaTro
{
    partial class frm_HoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_HoaDon));
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.btn_tim = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tab_hoadon = new System.Windows.Forms.TabControl();
            this.tp_hoadon = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtgv_hoadon = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAHOADON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYLAPHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THUEVAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_nam = new System.Windows.Forms.Label();
            this.txt_mahd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_maph = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_thang = new System.Windows.Forms.Label();
            this.txt_ngaylap = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_tongtien = new System.Windows.Forms.Label();
            this.txt_thanhtien = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_thuevat = new System.Windows.Forms.Label();
            this.txt_thue = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.tableLayoutPanel13.SuspendLayout();
            this.tab_hoadon.SuspendLayout();
            this.tp_hoadon.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_hoadon)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 2;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel13.Controls.Add(this.txt_timkiem, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.btn_tim, 1, 0);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 1;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(433, 39);
            this.tableLayoutPanel13.TabIndex = 7;
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_timkiem.Location = new System.Drawing.Point(3, 3);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(297, 30);
            this.txt_timkiem.TabIndex = 0;
            this.txt_timkiem.Text = "Mã hóa đơn";
            // 
            // btn_tim
            // 
            this.btn_tim.BackColor = System.Drawing.Color.White;
            this.btn_tim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_tim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_tim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tim.ImageIndex = 6;
            this.btn_tim.ImageList = this.imageList1;
            this.btn_tim.Location = new System.Drawing.Point(306, 3);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(124, 33);
            this.btn_tim.TabIndex = 1;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_tim.UseVisualStyleBackColor = false;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "them.png");
            this.imageList1.Images.SetKeyName(1, "xoa.ico");
            this.imageList1.Images.SetKeyName(2, "sua.png");
            this.imageList1.Images.SetKeyName(3, "save.ico");
            this.imageList1.Images.SetKeyName(4, "thoat.png");
            this.imageList1.Images.SetKeyName(5, "mayin.png");
            this.imageList1.Images.SetKeyName(6, "timkiem.jpg");
            // 
            // tab_hoadon
            // 
            this.tab_hoadon.Controls.Add(this.tp_hoadon);
            this.tab_hoadon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_hoadon.Location = new System.Drawing.Point(0, 0);
            this.tab_hoadon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tab_hoadon.Name = "tab_hoadon";
            this.tab_hoadon.SelectedIndex = 0;
            this.tab_hoadon.Size = new System.Drawing.Size(1130, 507);
            this.tab_hoadon.TabIndex = 1;
            // 
            // tp_hoadon
            // 
            this.tp_hoadon.Controls.Add(this.tableLayoutPanel1);
            this.tp_hoadon.Location = new System.Drawing.Point(4, 34);
            this.tp_hoadon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tp_hoadon.Name = "tp_hoadon";
            this.tp_hoadon.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tp_hoadon.Size = new System.Drawing.Size(1122, 469);
            this.tp_hoadon.TabIndex = 0;
            this.tp_hoadon.Text = "Hóa đơn";
            this.tp_hoadon.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.dtgv_hoadon, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1114, 459);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dtgv_hoadon
            // 
            this.dtgv_hoadon.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_hoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MAHOADON,
            this.THANHTIEN,
            this.NGAYLAPHD,
            this.THUEVAT,
            this.TONGTIEN,
            this.MAPHONG});
            this.dtgv_hoadon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_hoadon.Location = new System.Drawing.Point(448, 3);
            this.dtgv_hoadon.Name = "dtgv_hoadon";
            this.dtgv_hoadon.RowHeadersWidth = 51;
            this.dtgv_hoadon.Size = new System.Drawing.Size(663, 453);
            this.dtgv_hoadon.TabIndex = 0;
            this.dtgv_hoadon.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_hoadon_CellEnter);
            this.dtgv_hoadon.Click += new System.EventHandler(this.dtgv_hoadon_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // MAHOADON
            // 
            this.MAHOADON.HeaderText = "Mã hóa đơn";
            this.MAHOADON.MinimumWidth = 6;
            this.MAHOADON.Name = "MAHOADON";
            this.MAHOADON.Width = 125;
            // 
            // THANHTIEN
            // 
            this.THANHTIEN.HeaderText = "Thành tiền";
            this.THANHTIEN.MinimumWidth = 6;
            this.THANHTIEN.Name = "THANHTIEN";
            this.THANHTIEN.Width = 125;
            // 
            // NGAYLAPHD
            // 
            this.NGAYLAPHD.HeaderText = "Ngày lập hóa đơn";
            this.NGAYLAPHD.MinimumWidth = 6;
            this.NGAYLAPHD.Name = "NGAYLAPHD";
            this.NGAYLAPHD.Width = 125;
            // 
            // THUEVAT
            // 
            this.THUEVAT.HeaderText = "Thuế VAT";
            this.THUEVAT.MinimumWidth = 6;
            this.THUEVAT.Name = "THUEVAT";
            this.THUEVAT.Width = 125;
            // 
            // TONGTIEN
            // 
            this.TONGTIEN.HeaderText = "Tổng tiền";
            this.TONGTIEN.MinimumWidth = 6;
            this.TONGTIEN.Name = "TONGTIEN";
            this.TONGTIEN.Width = 125;
            // 
            // MAPHONG
            // 
            this.MAPHONG.HeaderText = "Mã Phòng";
            this.MAPHONG.MinimumWidth = 6;
            this.MAPHONG.Name = "MAPHONG";
            this.MAPHONG.Width = 70;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel8, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel9, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel13, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.99779F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.94702F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.050773F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.271523F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.15453F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.42384F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(439, 453);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.Controls.Add(this.lbl_nam, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txt_mahd, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txt_maph, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 48);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(433, 71);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // lbl_nam
            // 
            this.lbl_nam.AutoSize = true;
            this.lbl_nam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_nam.Location = new System.Drawing.Point(3, 0);
            this.lbl_nam.Name = "lbl_nam";
            this.lbl_nam.Size = new System.Drawing.Size(123, 38);
            this.lbl_nam.TabIndex = 0;
            this.lbl_nam.Text = "Mã hóa đơn";
            this.lbl_nam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_mahd
            // 
            this.txt_mahd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_mahd.Enabled = false;
            this.txt_mahd.Location = new System.Drawing.Point(132, 3);
            this.txt_mahd.Name = "txt_mahd";
            this.txt_mahd.Size = new System.Drawing.Size(298, 30);
            this.txt_mahd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã phòng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_maph
            // 
            this.txt_maph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_maph.Location = new System.Drawing.Point(132, 41);
            this.txt_maph.Name = "txt_maph";
            this.txt_maph.Size = new System.Drawing.Size(298, 30);
            this.txt_maph.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.Controls.Add(this.lbl_thang, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.txt_ngaylap, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 125);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(433, 30);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // lbl_thang
            // 
            this.lbl_thang.AutoSize = true;
            this.lbl_thang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_thang.Location = new System.Drawing.Point(3, 0);
            this.lbl_thang.Name = "lbl_thang";
            this.lbl_thang.Size = new System.Drawing.Size(123, 30);
            this.lbl_thang.TabIndex = 0;
            this.lbl_thang.Text = "Ngày lập hóa đơn";
            this.lbl_thang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_ngaylap
            // 
            this.txt_ngaylap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_ngaylap.Enabled = false;
            this.txt_ngaylap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_ngaylap.Location = new System.Drawing.Point(132, 3);
            this.txt_ngaylap.Name = "txt_ngaylap";
            this.txt_ngaylap.Size = new System.Drawing.Size(298, 30);
            this.txt_ngaylap.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel5.Controls.Add(this.lbl_tongtien, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.txt_thanhtien, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 202);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(433, 36);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // lbl_tongtien
            // 
            this.lbl_tongtien.AutoSize = true;
            this.lbl_tongtien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_tongtien.Location = new System.Drawing.Point(3, 0);
            this.lbl_tongtien.Name = "lbl_tongtien";
            this.lbl_tongtien.Size = new System.Drawing.Size(145, 36);
            this.lbl_tongtien.TabIndex = 0;
            this.lbl_tongtien.Text = "Thành tiền";
            this.lbl_tongtien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_thanhtien
            // 
            this.txt_thanhtien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_thanhtien.Enabled = false;
            this.txt_thanhtien.Location = new System.Drawing.Point(154, 3);
            this.txt_thanhtien.Name = "txt_thanhtien";
            this.txt_thanhtien.Size = new System.Drawing.Size(276, 30);
            this.txt_thanhtien.TabIndex = 1;
            this.txt_thanhtien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_thanhtien_KeyPress);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel8.Controls.Add(this.lbl_thuevat, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.txt_thue, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 161);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(433, 35);
            this.tableLayoutPanel8.TabIndex = 4;
            // 
            // lbl_thuevat
            // 
            this.lbl_thuevat.AutoSize = true;
            this.lbl_thuevat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_thuevat.Location = new System.Drawing.Point(3, 0);
            this.lbl_thuevat.Name = "lbl_thuevat";
            this.lbl_thuevat.Size = new System.Drawing.Size(123, 35);
            this.lbl_thuevat.TabIndex = 0;
            this.lbl_thuevat.Text = "Thuế VAT";
            this.lbl_thuevat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_thue
            // 
            this.txt_thue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_thue.Enabled = false;
            this.txt_thue.Location = new System.Drawing.Point(132, 3);
            this.txt_thue.Name = "txt_thue";
            this.txt_thue.Size = new System.Drawing.Size(298, 30);
            this.txt_thue.TabIndex = 1;
            this.txt_thue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_thue_KeyPress);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel9.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.txt_tongtien, 1, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 244);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(433, 40);
            this.tableLayoutPanel9.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tổng tiền";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_tongtien.Enabled = false;
            this.txt_tongtien.Location = new System.Drawing.Point(132, 3);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(298, 30);
            this.txt_tongtien.TabIndex = 1;
            this.txt_tongtien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tongtien_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel10);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 160);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel11, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel12, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.btnIn, 0, 2);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 26);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 3;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.51351F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.05405F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(427, 131);
            this.tableLayoutPanel10.TabIndex = 0;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel11.Controls.Add(this.btn_them, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.btn_xoa, 1, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(421, 36);
            this.tableLayoutPanel11.TabIndex = 0;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.White;
            this.btn_them.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_them.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_them.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_them.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_them.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.ImageIndex = 0;
            this.btn_them.ImageList = this.imageList1;
            this.btn_them.Location = new System.Drawing.Point(3, 3);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(201, 30);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.White;
            this.btn_xoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_xoa.Enabled = false;
            this.btn_xoa.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_xoa.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_xoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_xoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.ImageIndex = 1;
            this.btn_xoa.ImageList = this.imageList1;
            this.btn_xoa.Location = new System.Drawing.Point(210, 3);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(208, 30);
            this.btn_xoa.TabIndex = 1;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 2;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Controls.Add(this.btn_luu, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.btn_thoat, 1, 0);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(3, 45);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(421, 44);
            this.tableLayoutPanel12.TabIndex = 1;
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.Color.White;
            this.btn_luu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_luu.Enabled = false;
            this.btn_luu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_luu.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_luu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_luu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_luu.ImageIndex = 3;
            this.btn_luu.ImageList = this.imageList1;
            this.btn_luu.Location = new System.Drawing.Point(3, 3);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(204, 38);
            this.btn_luu.TabIndex = 0;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.White;
            this.btn_thoat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_thoat.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_thoat.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_thoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_thoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.ImageIndex = 4;
            this.btn_thoat.ImageList = this.imageList1;
            this.btn_thoat.Location = new System.Drawing.Point(213, 3);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(205, 38);
            this.btn_thoat.TabIndex = 1;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIn.Location = new System.Drawing.Point(3, 95);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(421, 33);
            this.btnIn.TabIndex = 2;
            this.btnIn.Text = "In hóa đơn";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // frm_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 507);
            this.Controls.Add(this.tab_hoadon);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_HoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÍ HÓA ĐƠN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_HoaDon_FormClosing);
            this.Load += new System.EventHandler(this.frm_HoaDon_Load);
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            this.tab_hoadon.ResumeLayout(false);
            this.tp_hoadon.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_hoadon)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.TabControl tab_hoadon;
        private System.Windows.Forms.TabPage tp_hoadon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dtgv_hoadon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbl_nam;
        private System.Windows.Forms.TextBox txt_mahd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lbl_thang;
        private System.Windows.Forms.DateTimePicker txt_ngaylap;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lbl_tongtien;
        private System.Windows.Forms.TextBox txt_thanhtien;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label lbl_thuevat;
        private System.Windows.Forms.TextBox txt_thue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_maph;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHOADON;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYLAPHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn THUEVAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPHONG;
    }
}