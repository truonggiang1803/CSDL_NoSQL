namespace QuanLiNhaTro
{
    partial class frm_ThemThietBi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ThemThietBi));
            this.lbl_sdttb = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dtgv_thietbi = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_thietbi = new System.Windows.Forms.Label();
            this.lbl_maph = new System.Windows.Forms.Label();
            this.txt_tenthietbi = new System.Windows.Forms.TextBox();
            this.txt_mathietbi = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_thietbi)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.lbl_sdttb.Size = new System.Drawing.Size(751, 42);
            this.lbl_sdttb.TabIndex = 0;
            this.lbl_sdttb.Text = "QUẢN LÍ TRANG THIẾT BỊ";
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 44);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(753, 382);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // dtgv_thietbi
            // 
            this.dtgv_thietbi.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_thietbi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_thietbi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MATB,
            this.TENTB});
            this.dtgv_thietbi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_thietbi.Location = new System.Drawing.Point(3, 2);
            this.dtgv_thietbi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgv_thietbi.Name = "dtgv_thietbi";
            this.dtgv_thietbi.RowHeadersWidth = 51;
            this.dtgv_thietbi.Size = new System.Drawing.Size(295, 378);
            this.dtgv_thietbi.TabIndex = 0;
            this.dtgv_thietbi.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_thietbi_CellEnter);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
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
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(304, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.91837F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.08163F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(446, 378);
            this.tableLayoutPanel3.TabIndex = 1;
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
            this.tableLayoutPanel4.Controls.Add(this.txt_tenthietbi, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.txt_mathietbi, 2, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.81726F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.92893F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.6599F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.59391F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(440, 320);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // lbl_thietbi
            // 
            this.lbl_thietbi.AutoSize = true;
            this.lbl_thietbi.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_thietbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_thietbi.Location = new System.Drawing.Point(44, 121);
            this.lbl_thietbi.Name = "lbl_thietbi";
            this.lbl_thietbi.Size = new System.Drawing.Size(105, 38);
            this.lbl_thietbi.TabIndex = 0;
            this.lbl_thietbi.Text = "Mã thiết bị";
            this.lbl_thietbi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_maph
            // 
            this.lbl_maph.AutoSize = true;
            this.lbl_maph.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_maph.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maph.Location = new System.Drawing.Point(44, 159);
            this.lbl_maph.Name = "lbl_maph";
            this.lbl_maph.Size = new System.Drawing.Size(105, 34);
            this.lbl_maph.TabIndex = 1;
            this.lbl_maph.Text = "Tên thiết bị";
            this.lbl_maph.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_tenthietbi
            // 
            this.txt_tenthietbi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_tenthietbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenthietbi.Location = new System.Drawing.Point(155, 161);
            this.txt_tenthietbi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tenthietbi.Name = "txt_tenthietbi";
            this.txt_tenthietbi.Size = new System.Drawing.Size(190, 36);
            this.txt_tenthietbi.TabIndex = 3;
            this.txt_tenthietbi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tenthietbi_KeyPress);
            // 
            // txt_mathietbi
            // 
            this.txt_mathietbi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_mathietbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mathietbi.Location = new System.Drawing.Point(155, 123);
            this.txt_mathietbi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_mathietbi.Name = "txt_mathietbi";
            this.txt_mathietbi.Size = new System.Drawing.Size(190, 36);
            this.txt_mathietbi.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.Controls.Add(this.button1, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.btn_them, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btn_xoa, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btn_sua, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.btn_luu, 3, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 326);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(440, 50);
            this.tableLayoutPanel5.TabIndex = 1;
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
            this.button1.Location = new System.Drawing.Point(355, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Thoát";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_them.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_them.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.ImageIndex = 3;
            this.btn_them.ImageList = this.imageList1;
            this.btn_them.Location = new System.Drawing.Point(3, 2);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(82, 46);
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
            this.btn_xoa.Location = new System.Drawing.Point(91, 2);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(82, 46);
            this.btn_xoa.TabIndex = 1;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_sua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_sua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.ImageIndex = 1;
            this.btn_sua.ImageList = this.imageList1;
            this.btn_sua.Location = new System.Drawing.Point(179, 2);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(82, 46);
            this.btn_sua.TabIndex = 2;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
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
            this.btn_luu.Location = new System.Drawing.Point(267, 2);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(82, 46);
            this.btn_luu.TabIndex = 3;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_sdttb, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(759, 428);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // frm_ThemThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 428);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_ThemThietBi";
            this.Text = "frm_ThemThietBi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_ThemThietBi_FormClosing_1);
            this.Load += new System.EventHandler(this.frm_ThemThietBi_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_thietbi)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_sdttb;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dtgv_thietbi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lbl_thietbi;
        private System.Windows.Forms.Label lbl_maph;
        private System.Windows.Forms.TextBox txt_tenthietbi;
        private System.Windows.Forms.TextBox txt_mathietbi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTB;
    }
}