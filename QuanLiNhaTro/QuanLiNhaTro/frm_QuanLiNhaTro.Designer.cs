namespace QuanLiNhaTro
{
    partial class frm_QuanLiNhaTro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QuanLiNhaTro));
            DevExpress.XtraCharts.XYDiagram3D xyDiagram3D1 = new DevExpress.XtraCharts.XYDiagram3D();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SeriesPoint seriesPoint1 = new DevExpress.XtraCharts.SeriesPoint("Phòng trống", new object[] {
            ((object)(10D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint2 = new DevExpress.XtraCharts.SeriesPoint("Phòng đã thuê", new object[] {
            ((object)(14D))});
            DevExpress.XtraCharts.SideBySideBar3DSeriesView sideBySideBar3DSeriesView1 = new DevExpress.XtraCharts.SideBySideBar3DSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_qlphong = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_qldv = new System.Windows.Forms.Button();
            this.btn_qlkh = new System.Windows.Forms.Button();
            this.btn_thietbi = new System.Windows.Forms.Button();
            this.btn_qlhd = new System.Windows.Forms.Button();
            this.btn_hoadon = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.item1 = new System.Windows.Forms.ToolStripMenuItem();
            this.itemtk = new System.Windows.Forms.ToolStripMenuItem();
            this.itemdx = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBar3DSeriesView1)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1067, 560);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1061, 554);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btn_qlphong, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btn_qldv, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btn_qlkh, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.btn_thietbi, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.btn_qlhd, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.btn_hoadon, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox1, 0, 7);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(206, 548);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btn_qlphong
            // 
            this.btn_qlphong.BackColor = System.Drawing.Color.White;
            this.btn_qlphong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_qlphong.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_qlphong.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_qlphong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_qlphong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_qlphong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_qlphong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_qlphong.ImageIndex = 1;
            this.btn_qlphong.ImageList = this.imageList1;
            this.btn_qlphong.Location = new System.Drawing.Point(3, 57);
            this.btn_qlphong.Name = "btn_qlphong";
            this.btn_qlphong.Size = new System.Drawing.Size(200, 48);
            this.btn_qlphong.TabIndex = 2;
            this.btn_qlphong.Text = "Phòng";
            this.btn_qlphong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_qlphong.UseVisualStyleBackColor = false;
            this.btn_qlphong.Click += new System.EventHandler(this.btn_qlphong_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ad.png");
            this.imageList1.Images.SetKeyName(1, "phong.png");
            this.imageList1.Images.SetKeyName(2, "dv.png");
            this.imageList1.Images.SetKeyName(3, "kh1.jpg");
            this.imageList1.Images.SetKeyName(4, "tb1.png");
            this.imageList1.Images.SetKeyName(5, "hd1.jpg");
            this.imageList1.Images.SetKeyName(6, "hoadon1.jpg");
            // 
            // btn_qldv
            // 
            this.btn_qldv.BackColor = System.Drawing.Color.White;
            this.btn_qldv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_qldv.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_qldv.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_qldv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_qldv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_qldv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_qldv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_qldv.ImageIndex = 2;
            this.btn_qldv.ImageList = this.imageList1;
            this.btn_qldv.Location = new System.Drawing.Point(3, 111);
            this.btn_qldv.Name = "btn_qldv";
            this.btn_qldv.Size = new System.Drawing.Size(200, 48);
            this.btn_qldv.TabIndex = 3;
            this.btn_qldv.Text = "Dịch vụ";
            this.btn_qldv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_qldv.UseVisualStyleBackColor = false;
            this.btn_qldv.Click += new System.EventHandler(this.btn_qldv_Click);
            // 
            // btn_qlkh
            // 
            this.btn_qlkh.BackColor = System.Drawing.Color.White;
            this.btn_qlkh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_qlkh.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_qlkh.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_qlkh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_qlkh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_qlkh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_qlkh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_qlkh.ImageIndex = 3;
            this.btn_qlkh.ImageList = this.imageList1;
            this.btn_qlkh.Location = new System.Drawing.Point(3, 165);
            this.btn_qlkh.Name = "btn_qlkh";
            this.btn_qlkh.Size = new System.Drawing.Size(200, 48);
            this.btn_qlkh.TabIndex = 4;
            this.btn_qlkh.Text = " Khách hàng";
            this.btn_qlkh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_qlkh.UseVisualStyleBackColor = false;
            this.btn_qlkh.Click += new System.EventHandler(this.btn_qlkh_Click);
            // 
            // btn_thietbi
            // 
            this.btn_thietbi.BackColor = System.Drawing.Color.White;
            this.btn_thietbi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_thietbi.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_thietbi.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_thietbi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_thietbi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_thietbi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thietbi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thietbi.ImageIndex = 4;
            this.btn_thietbi.ImageList = this.imageList1;
            this.btn_thietbi.Location = new System.Drawing.Point(3, 219);
            this.btn_thietbi.Name = "btn_thietbi";
            this.btn_thietbi.Size = new System.Drawing.Size(200, 48);
            this.btn_thietbi.TabIndex = 5;
            this.btn_thietbi.Text = "Thiết bị";
            this.btn_thietbi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_thietbi.UseVisualStyleBackColor = false;
            this.btn_thietbi.Click += new System.EventHandler(this.btn_thietbi_Click);
            // 
            // btn_qlhd
            // 
            this.btn_qlhd.BackColor = System.Drawing.Color.White;
            this.btn_qlhd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_qlhd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_qlhd.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_qlhd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_qlhd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_qlhd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_qlhd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_qlhd.ImageIndex = 5;
            this.btn_qlhd.ImageList = this.imageList1;
            this.btn_qlhd.Location = new System.Drawing.Point(3, 273);
            this.btn_qlhd.Name = "btn_qlhd";
            this.btn_qlhd.Size = new System.Drawing.Size(200, 48);
            this.btn_qlhd.TabIndex = 6;
            this.btn_qlhd.Text = "Hợp đồng";
            this.btn_qlhd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_qlhd.UseVisualStyleBackColor = false;
            this.btn_qlhd.Click += new System.EventHandler(this.btn_qlhd_Click);
            // 
            // btn_hoadon
            // 
            this.btn_hoadon.BackColor = System.Drawing.Color.White;
            this.btn_hoadon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_hoadon.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_hoadon.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_hoadon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_hoadon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_hoadon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hoadon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hoadon.ImageIndex = 6;
            this.btn_hoadon.ImageList = this.imageList1;
            this.btn_hoadon.Location = new System.Drawing.Point(3, 327);
            this.btn_hoadon.Name = "btn_hoadon";
            this.btn_hoadon.Size = new System.Drawing.Size(200, 48);
            this.btn_hoadon.TabIndex = 7;
            this.btn_hoadon.Text = "Hóa đơn";
            this.btn_hoadon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_hoadon.UseVisualStyleBackColor = false;
            this.btn_hoadon.Click += new System.EventHandler(this.btn_hoadon_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 381);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tableLayoutPanel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(215, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 548);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.64706F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.35294F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(843, 548);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.chartControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(837, 468);
            this.panel2.TabIndex = 1;
            // 
            // chartControl1
            // 
            xyDiagram3D1.RotationMatrixSerializable = "0.766044443118978;-0.0918913857565713;0.636185416675258;0;0;0.989728811022819;0.1" +
    "42957618304719;0;-0.642787609686539;-0.109511889103854;0.758176255878783;0;0;0;0" +
    ";1";
            this.chartControl1.Diagram = xyDiagram3D1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            series1.Name = "Series 1";
            seriesPoint2.ColorSerializable = "#FBD5B5";
            series1.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint1,
            seriesPoint2});
            series1.View = sideBySideBar3DSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(837, 468);
            this.chartControl1.TabIndex = 0;
            chartTitle1.Text = "Biểu đồ thể hiện tình trạng phòng";
            this.chartControl1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.86855F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.13145F));
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(837, 68);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("#9Slide03 Arima Madurai ExtraLi", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(654, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÍ NHÀ TRỌ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.menuStrip1, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.pictureBox2, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(663, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(171, 62);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item1});
            this.menuStrip1.Location = new System.Drawing.Point(85, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(86, 62);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // item1
            // 
            this.item1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemtk,
            this.itemdx});
            this.item1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.item1.Name = "item1";
            this.item1.Size = new System.Drawing.Size(57, 58);
            this.item1.Text = "dat";
            // 
            // itemtk
            // 
            this.itemtk.Name = "itemtk";
            this.itemtk.Size = new System.Drawing.Size(284, 36);
            this.itemtk.Text = "Thông tin tài khoản";
            this.itemtk.Click += new System.EventHandler(this.itemtk_Click);
            // 
            // itemdx
            // 
            this.itemdx.Name = "itemdx";
            this.itemdx.Size = new System.Drawing.Size(284, 36);
            this.itemdx.Text = "Đăng xuất";
            this.itemdx.Click += new System.EventHandler(this.itemdx_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // frm_QuanLiNhaTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 560);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_QuanLiNhaTro";
            this.Text = "PHẦN MỀM QUẢN LÍ NHÀ TRỌ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_QuanLiNhaTro_FormClosing);
            this.Load += new System.EventHandler(this.frm_QuanLiNhaTro_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBar3DSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btn_qlphong;
        private System.Windows.Forms.Button btn_qldv;
        private System.Windows.Forms.Button btn_qlkh;
        private System.Windows.Forms.Button btn_thietbi;
        private System.Windows.Forms.Button btn_qlhd;
        private System.Windows.Forms.Button btn_hoadon;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem item1;
        private System.Windows.Forms.ToolStripMenuItem itemtk;
        private System.Windows.Forms.ToolStripMenuItem itemdx;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevExpress.XtraCharts.ChartControl chartControl1;
    }
}