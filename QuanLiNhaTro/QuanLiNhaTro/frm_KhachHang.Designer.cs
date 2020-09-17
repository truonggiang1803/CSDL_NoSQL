namespace QuanLiNhaTro
{
    partial class frm_KhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_KhachHang));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Ten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtDulieu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnThem = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThemThuocTinh = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.treeView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1114, 518);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(551, 512);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.listView1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(560, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.23438F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.76563F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(551, 512);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ten,
            this.Value});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(545, 327);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // Ten
            // 
            this.Ten.Text = "Tên thuộc tính";
            this.Ten.Width = 150;
            // 
            // Value
            // 
            this.Value.Text = "giá trị";
            this.Value.Width = 150;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 336);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.37209F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.62791F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(545, 173);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.74648F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.25352F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178F));
            this.tableLayoutPanel4.Controls.Add(this.txtTen, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtDulieu, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(539, 60);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // txtTen
            // 
            this.txtTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTen.Location = new System.Drawing.Point(95, 3);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(183, 35);
            this.txtTen.TabIndex = 1;
            this.txtTen.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtDulieu
            // 
            this.txtDulieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDulieu.Location = new System.Drawing.Point(363, 3);
            this.txtDulieu.Name = "txtDulieu";
            this.txtDulieu.Size = new System.Drawing.Size(173, 35);
            this.txtDulieu.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 60);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên thuộc tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 58);
            this.label2.TabIndex = 4;
            this.label2.Text = "Giá trị";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.btnThem, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnXoa, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnThemThuocTinh, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.btnLuu, 1, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 69);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(539, 101);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.ImageIndex = 0;
            this.btnThem.ImageList = this.imageList1;
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(263, 44);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            // btnXoa
            // 
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.ImageIndex = 1;
            this.btnXoa.ImageList = this.imageList1;
            this.btnXoa.Location = new System.Drawing.Point(272, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(264, 44);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemThuocTinh
            // 
            this.btnThemThuocTinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThemThuocTinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemThuocTinh.ImageIndex = 0;
            this.btnThemThuocTinh.ImageList = this.imageList1;
            this.btnThemThuocTinh.Location = new System.Drawing.Point(3, 53);
            this.btnThemThuocTinh.Name = "btnThemThuocTinh";
            this.btnThemThuocTinh.Size = new System.Drawing.Size(263, 45);
            this.btnThemThuocTinh.TabIndex = 2;
            this.btnThemThuocTinh.Text = "Thêm Thuộc Tính";
            this.btnThemThuocTinh.UseVisualStyleBackColor = true;
            this.btnThemThuocTinh.Click += new System.EventHandler(this.btnThemThuocTinh_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.ImageIndex = 3;
            this.btnLuu.ImageList = this.imageList1;
            this.btnLuu.Location = new System.Drawing.Point(272, 53);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(264, 45);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frm_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 518);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_KhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ KHÁCH HÀNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_KhachHang_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThemThuocTinh;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ColumnHeader Ten;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.TextBox txtDulieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
    }
}