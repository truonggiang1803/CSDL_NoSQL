namespace QuanLiNhaTro
{
    partial class frm_Phong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Phong));
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
            this.btn_loaiphong = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtgv_ph = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAPH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MALOAIPH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KichThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_maph = new System.Windows.Forms.Label();
            this.lbl_soluong = new System.Windows.Forms.Label();
            this.txt_maphong = new System.Windows.Forms.TextBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.lbl_loaiph = new System.Windows.Forms.Label();
            this.lbl_kichthuoc = new System.Windows.Forms.Label();
            this.lbl_dongia = new System.Windows.Forms.Label();
            this.cbo_loaiph = new System.Windows.Forms.ComboBox();
            this.txt_kichthuoc = new System.Windows.Forms.TextBox();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ph)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.btn_loaiphong});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(773, 41);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_them
            // 
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(100, 36);
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 41);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Enabled = false;
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(79, 36);
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 41);
            // 
            // btn_sua
            // 
            this.btn_sua.Enabled = false;
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(78, 36);
            this.btn_sua.Text = "Sửa";
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 41);
            // 
            // btn_luu
            // 
            this.btn_luu.Enabled = false;
            this.btn_luu.Image = ((System.Drawing.Image)(resources.GetObject("btn_luu.Image")));
            this.btn_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_luu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(78, 36);
            this.btn_luu.Text = "Lưu";
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 41);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.Image")));
            this.btn_thoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(100, 36);
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 41);
            // 
            // txt_tim
            // 
            this.txt_tim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tim.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(150, 41);
            // 
            // btn_tim
            // 
            this.btn_tim.Image = ((System.Drawing.Image)(resources.GetObject("btn_tim.Image")));
            this.btn_tim.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(138, 36);
            this.btn_tim.Text = "Tìm kiếm";
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 35);
            // 
            // btn_loaiphong
            // 
            this.btn_loaiphong.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_loaiphong.Image = ((System.Drawing.Image)(resources.GetObject("btn_loaiphong.Image")));
            this.btn_loaiphong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_loaiphong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_loaiphong.Name = "btn_loaiphong";
            this.btn_loaiphong.Size = new System.Drawing.Size(206, 36);
            this.btn_loaiphong.Text = "Thêm Loại Phòng";
            this.btn_loaiphong.Click += new System.EventHandler(this.btn_loaiphong_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dtgv_ph, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 41);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(773, 400);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // dtgv_ph
            // 
            this.dtgv_ph.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_ph.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ph.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MAPH,
            this.SOLUONG,
            this.MALOAIPH,
            this.KichThuoc,
            this.DonGia});
            this.dtgv_ph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_ph.Location = new System.Drawing.Point(3, 123);
            this.dtgv_ph.Name = "dtgv_ph";
            this.dtgv_ph.RowHeadersWidth = 51;
            this.dtgv_ph.Size = new System.Drawing.Size(767, 274);
            this.dtgv_ph.TabIndex = 0;
            this.dtgv_ph.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_ph_CellEnter);
            this.dtgv_ph.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_ph_RowEnter);
            this.dtgv_ph.Click += new System.EventHandler(this.dtgv_ph_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // MAPH
            // 
            this.MAPH.HeaderText = "Mã phòng";
            this.MAPH.MinimumWidth = 6;
            this.MAPH.Name = "MAPH";
            this.MAPH.Width = 125;
            // 
            // SOLUONG
            // 
            this.SOLUONG.HeaderText = "Số lượng";
            this.SOLUONG.MinimumWidth = 6;
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.Width = 125;
            // 
            // MALOAIPH
            // 
            this.MALOAIPH.HeaderText = "Tên loại phòng";
            this.MALOAIPH.MinimumWidth = 6;
            this.MALOAIPH.Name = "MALOAIPH";
            this.MALOAIPH.Width = 150;
            // 
            // KichThuoc
            // 
            this.KichThuoc.HeaderText = "Kích thước";
            this.KichThuoc.MinimumWidth = 8;
            this.KichThuoc.Name = "KichThuoc";
            this.KichThuoc.Width = 150;
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 8;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 150;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_maph, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_soluong, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_maphong, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_soluong, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_loaiph, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_kichthuoc, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_dongia, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbo_loaiph, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_kichthuoc, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_dongia, 3, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(767, 114);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lbl_maph
            // 
            this.lbl_maph.AutoSize = true;
            this.lbl_maph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_maph.Location = new System.Drawing.Point(3, 0);
            this.lbl_maph.Name = "lbl_maph";
            this.lbl_maph.Size = new System.Drawing.Size(147, 37);
            this.lbl_maph.TabIndex = 0;
            this.lbl_maph.Text = "Mã phòng";
            this.lbl_maph.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_soluong
            // 
            this.lbl_soluong.AutoSize = true;
            this.lbl_soluong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_soluong.Location = new System.Drawing.Point(3, 37);
            this.lbl_soluong.Name = "lbl_soluong";
            this.lbl_soluong.Size = new System.Drawing.Size(147, 37);
            this.lbl_soluong.TabIndex = 1;
            this.lbl_soluong.Text = "Số lượng";
            this.lbl_soluong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_maphong
            // 
            this.txt_maphong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_maphong.Enabled = false;
            this.txt_maphong.Location = new System.Drawing.Point(156, 3);
            this.txt_maphong.Name = "txt_maphong";
            this.txt_maphong.Size = new System.Drawing.Size(224, 35);
            this.txt_maphong.TabIndex = 3;
            this.txt_maphong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_soluong.Location = new System.Drawing.Point(156, 40);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(224, 35);
            this.txt_soluong.TabIndex = 4;
            this.txt_soluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_soluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_soluong_KeyPress);
            // 
            // lbl_loaiph
            // 
            this.lbl_loaiph.AutoSize = true;
            this.lbl_loaiph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_loaiph.Location = new System.Drawing.Point(386, 0);
            this.lbl_loaiph.Name = "lbl_loaiph";
            this.lbl_loaiph.Size = new System.Drawing.Size(147, 37);
            this.lbl_loaiph.TabIndex = 6;
            this.lbl_loaiph.Text = "Loại phòng";
            this.lbl_loaiph.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_kichthuoc
            // 
            this.lbl_kichthuoc.AutoSize = true;
            this.lbl_kichthuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_kichthuoc.Location = new System.Drawing.Point(386, 37);
            this.lbl_kichthuoc.Name = "lbl_kichthuoc";
            this.lbl_kichthuoc.Size = new System.Drawing.Size(147, 37);
            this.lbl_kichthuoc.TabIndex = 7;
            this.lbl_kichthuoc.Text = "Kích thước";
            this.lbl_kichthuoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_dongia
            // 
            this.lbl_dongia.AutoSize = true;
            this.lbl_dongia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_dongia.Location = new System.Drawing.Point(386, 74);
            this.lbl_dongia.Name = "lbl_dongia";
            this.lbl_dongia.Size = new System.Drawing.Size(147, 40);
            this.lbl_dongia.TabIndex = 8;
            this.lbl_dongia.Text = "Đơn giá";
            this.lbl_dongia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbo_loaiph
            // 
            this.cbo_loaiph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_loaiph.FormattingEnabled = true;
            this.cbo_loaiph.Location = new System.Drawing.Point(539, 3);
            this.cbo_loaiph.Name = "cbo_loaiph";
            this.cbo_loaiph.Size = new System.Drawing.Size(225, 37);
            this.cbo_loaiph.TabIndex = 9;
            // 
            // txt_kichthuoc
            // 
            this.txt_kichthuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_kichthuoc.Enabled = false;
            this.txt_kichthuoc.Location = new System.Drawing.Point(539, 40);
            this.txt_kichthuoc.Name = "txt_kichthuoc";
            this.txt_kichthuoc.Size = new System.Drawing.Size(225, 35);
            this.txt_kichthuoc.TabIndex = 10;
            this.txt_kichthuoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_dongia
            // 
            this.txt_dongia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_dongia.Enabled = false;
            this.txt_dongia.Location = new System.Drawing.Point(539, 77);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(225, 35);
            this.txt_dongia.TabIndex = 11;
            this.txt_dongia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frm_Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 441);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_Phong";
            this.Text = "PHÒNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Phong_FormClosing);
            this.Load += new System.EventHandler(this.frm_Phong_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ph)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dtgv_ph;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_maph;
        private System.Windows.Forms.Label lbl_soluong;
        private System.Windows.Forms.TextBox txt_maphong;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Label lbl_loaiph;
        private System.Windows.Forms.Label lbl_kichthuoc;
        private System.Windows.Forms.Label lbl_dongia;
        private System.Windows.Forms.ComboBox cbo_loaiph;
        private System.Windows.Forms.TextBox txt_kichthuoc;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btn_loaiphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOAIPH;
        private System.Windows.Forms.DataGridViewTextBoxColumn KichThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
    }
}