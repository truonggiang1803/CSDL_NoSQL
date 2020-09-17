namespace QuanLiNhaTro
{
    partial class frm_TrangThietBi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TrangThietBi));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_thietbi = new System.Windows.Forms.Label();
            this.lbl_maph = new System.Windows.Forms.Label();
            this.cbo_thietbi = new System.Windows.Forms.ComboBox();
            this.txt_maph = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_sdttb = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dtgv_thietbi = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAPH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_thietbi)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "thoat.png");
            this.imageList1.Images.SetKeyName(1, "sua.png");
            this.imageList1.Images.SetKeyName(2, "dangxuat.jpg");
            this.imageList1.Images.SetKeyName(3, "them.png");
            this.imageList1.Images.SetKeyName(4, "xoa.ico");
            this.imageList1.Images.SetKeyName(5, "save.ico");
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.55366F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.36116F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.33901F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.08688F));
            this.tableLayoutPanel5.Controls.Add(this.btn_them, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btn_xoa, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btn_luu, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.button1, 3, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 462);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(587, 45);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_them.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_them.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.ImageIndex = 3;
            this.btn_them.ImageList = this.imageList1;
            this.btn_them.Location = new System.Drawing.Point(3, 3);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(143, 39);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_xoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_xoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_xoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.ImageIndex = 4;
            this.btn_xoa.ImageList = this.imageList1;
            this.btn_xoa.Location = new System.Drawing.Point(152, 3);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(136, 39);
            this.btn_xoa.TabIndex = 1;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_luu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_luu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_luu.ForeColor = System.Drawing.Color.Black;
            this.btn_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_luu.ImageIndex = 5;
            this.btn_luu.ImageList = this.imageList1;
            this.btn_luu.Location = new System.Drawing.Point(294, 3);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(130, 39);
            this.btn_luu.TabIndex = 3;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(430, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Thoát";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_thietbi
            // 
            this.lbl_thietbi.AutoSize = true;
            this.lbl_thietbi.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_thietbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_thietbi.Location = new System.Drawing.Point(58, 171);
            this.lbl_thietbi.Name = "lbl_thietbi";
            this.lbl_thietbi.Size = new System.Drawing.Size(143, 29);
            this.lbl_thietbi.TabIndex = 0;
            this.lbl_thietbi.Text = "Thiết bị";
            this.lbl_thietbi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_maph
            // 
            this.lbl_maph.AutoSize = true;
            this.lbl_maph.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_maph.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maph.Location = new System.Drawing.Point(58, 225);
            this.lbl_maph.Name = "lbl_maph";
            this.lbl_maph.Size = new System.Drawing.Size(143, 29);
            this.lbl_maph.TabIndex = 1;
            this.lbl_maph.Text = "Mã phòng";
            this.lbl_maph.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbo_thietbi
            // 
            this.cbo_thietbi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_thietbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_thietbi.FormattingEnabled = true;
            this.cbo_thietbi.Location = new System.Drawing.Point(207, 174);
            this.cbo_thietbi.Name = "cbo_thietbi";
            this.cbo_thietbi.Size = new System.Drawing.Size(255, 37);
            this.cbo_thietbi.TabIndex = 2;
            // 
            // txt_maph
            // 
            this.txt_maph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_maph.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maph.Location = new System.Drawing.Point(207, 228);
            this.txt_maph.Name = "txt_maph";
            this.txt_maph.Size = new System.Drawing.Size(255, 36);
            this.txt_maph.TabIndex = 3;
            this.txt_maph.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(468, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "Thêm TB mới";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.51417F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.50607F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.73684F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.64777F));
            this.tableLayoutPanel4.Controls.Add(this.lbl_thietbi, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.lbl_maph, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.cbo_thietbi, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.txt_maph, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.button2, 3, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.81726F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.92893F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.6599F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.59391F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(587, 453);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(401, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(593, 510);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // lbl_sdttb
            // 
            this.lbl_sdttb.AutoSize = true;
            this.lbl_sdttb.BackColor = System.Drawing.Color.White;
            this.lbl_sdttb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_sdttb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sdttb.ForeColor = System.Drawing.Color.Red;
            this.lbl_sdttb.Location = new System.Drawing.Point(4, 0);
            this.lbl_sdttb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sdttb.Name = "lbl_sdttb";
            this.lbl_sdttb.Size = new System.Drawing.Size(995, 58);
            this.lbl_sdttb.TabIndex = 0;
            this.lbl_sdttb.Text = "QUẢN LÍ SỬ DỤNG THIẾT BỊ";
            this.lbl_sdttb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.Controls.Add(this.dtgv_thietbi, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 61);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(997, 516);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // dtgv_thietbi
            // 
            this.dtgv_thietbi.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_thietbi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_thietbi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MAPH,
            this.MATB,
            this.TENTB});
            this.dtgv_thietbi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_thietbi.Location = new System.Drawing.Point(3, 3);
            this.dtgv_thietbi.Name = "dtgv_thietbi";
            this.dtgv_thietbi.RowHeadersWidth = 51;
            this.dtgv_thietbi.Size = new System.Drawing.Size(392, 510);
            this.dtgv_thietbi.TabIndex = 0;
            this.dtgv_thietbi.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_thietbi_CellEnter);
            this.dtgv_thietbi.Click += new System.EventHandler(this.dtgv_thietbi_Click);
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
            this.MAPH.HeaderText = "MAPH";
            this.MAPH.MinimumWidth = 6;
            this.MAPH.Name = "MAPH";
            this.MAPH.Width = 125;
            // 
            // MATB
            // 
            this.MATB.HeaderText = "MATB";
            this.MATB.MinimumWidth = 6;
            this.MATB.Name = "MATB";
            this.MATB.Width = 125;
            // 
            // TENTB
            // 
            this.TENTB.HeaderText = "TENTB";
            this.TENTB.MinimumWidth = 6;
            this.TENTB.Name = "TENTB";
            this.TENTB.Width = 125;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_sdttb, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1003, 580);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // frm_TrangThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1003, 580);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_TrangThietBi";
            this.Text = "frm_TrangThietBi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_TrangThietBi_FormClosing_1);
            this.Load += new System.EventHandler(this.frm_TrangThietBi_Load);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_thietbi)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lbl_thietbi;
        private System.Windows.Forms.Label lbl_maph;
        private System.Windows.Forms.ComboBox cbo_thietbi;
        private System.Windows.Forms.TextBox txt_maph;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbl_sdttb;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dtgv_thietbi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTB;
    }
}