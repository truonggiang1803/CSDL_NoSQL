namespace QuanLiNhaTro
{
    partial class frm_DangNhap
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
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DangNhap));
            this.lbl_tendn = new System.Windows.Forms.Label();
            this.txt_tendn = new System.Windows.Forms.TextBox();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.lbl_matkhau = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.llbl_quenmk = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_dangnhap = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("#9Slide03 Arima Madurai ExtraLi", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(199, 10);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(420, 119);
            label2.TabIndex = 6;
            label2.Text = "ĐĂNG NHẬP";
            // 
            // lbl_tendn
            // 
            this.lbl_tendn.AutoSize = true;
            this.lbl_tendn.Location = new System.Drawing.Point(220, 122);
            this.lbl_tendn.Name = "lbl_tendn";
            this.lbl_tendn.Size = new System.Drawing.Size(189, 35);
            this.lbl_tendn.TabIndex = 0;
            this.lbl_tendn.Text = "Tên đăng nhập:";
            // 
            // txt_tendn
            // 
            this.txt_tendn.Location = new System.Drawing.Point(395, 115);
            this.txt_tendn.Name = "txt_tendn";
            this.txt_tendn.Size = new System.Drawing.Size(213, 38);
            this.txt_tendn.TabIndex = 1;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Location = new System.Drawing.Point(395, 169);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(213, 38);
            this.txt_matkhau.TabIndex = 2;
            this.txt_matkhau.UseSystemPasswordChar = true;
            // 
            // lbl_matkhau
            // 
            this.lbl_matkhau.AutoSize = true;
            this.lbl_matkhau.Location = new System.Drawing.Point(260, 169);
            this.lbl_matkhau.Name = "lbl_matkhau";
            this.lbl_matkhau.Size = new System.Drawing.Size(128, 35);
            this.lbl_matkhau.TabIndex = 2;
            this.lbl_matkhau.Text = "Mật khẩu:";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ad.png");
            this.imageList1.Images.SetKeyName(1, "thoat.png");
            // 
            // llbl_quenmk
            // 
            this.llbl_quenmk.AutoSize = true;
            this.llbl_quenmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbl_quenmk.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llbl_quenmk.LinkColor = System.Drawing.Color.Red;
            this.llbl_quenmk.Location = new System.Drawing.Point(504, 293);
            this.llbl_quenmk.Name = "llbl_quenmk";
            this.llbl_quenmk.Size = new System.Drawing.Size(157, 25);
            this.llbl_quenmk.TabIndex = 8;
            this.llbl_quenmk.TabStop = true;
            this.llbl_quenmk.Text = "Quên mật khẩu?";
            this.llbl_quenmk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_quenmk_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.White;
            this.btn_thoat.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_thoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_thoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.ImageIndex = 1;
            this.btn_thoat.ImageList = this.imageList1;
            this.btn_thoat.Location = new System.Drawing.Point(456, 231);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(152, 41);
            this.btn_thoat.TabIndex = 4;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.BackColor = System.Drawing.Color.White;
            this.btn_dangnhap.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_dangnhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_dangnhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_dangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dangnhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dangnhap.ImageIndex = 0;
            this.btn_dangnhap.ImageList = this.imageList1;
            this.btn_dangnhap.Location = new System.Drawing.Point(284, 231);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(166, 41);
            this.btn_dangnhap.TabIndex = 3;
            this.btn_dangnhap.Text = "Đăng nhập";
            this.btn_dangnhap.UseVisualStyleBackColor = false;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(715, 340);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.llbl_quenmk);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(label2);
            this.Controls.Add(this.btn_dangnhap);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.lbl_matkhau);
            this.Controls.Add(this.txt_tendn);
            this.Controls.Add(this.lbl_tendn);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_DangNhap_FormClosing);
            this.Load += new System.EventHandler(this.frm_DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tendn;
        private System.Windows.Forms.TextBox txt_tendn;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.Label lbl_matkhau;
        private System.Windows.Forms.Button btn_dangnhap;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.LinkLabel llbl_quenmk;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

