using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core;
namespace QuanLiNhaTro
{
    public partial class frm_QuanLiNhaTro : Form
    {
        public string tendn;
        public static string ma = "";
        KetNoi kn;
        public frm_QuanLiNhaTro()
        {
            InitializeComponent();
            MongoClientSettings settings = new MongoClientSettings();
            kn = new KetNoi();
        }

        private void imns_themtk_Click(object sender, EventArgs e)
        {
            //
        }

        private void imns_dangxuat_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn muốn đăng xuất ra khỏi tài khoản này?","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            //if(r==DialogResult.Cancel)
                
                
        }


        private void btn_qldv_Click(object sender, EventArgs e)
        {
            this.label1.Hide();
            this.panel2.Controls.Clear();
            frm_DichVu dv = new frm_DichVu();
            //frm_DangNhap dn = new frm_DangNhap();
            dv.TopLevel = false;
            this.panel2.Controls.Add(dv);
            ////this.Hide();
            //dv.Show();
            dv.Show();
            ////this.Show();
        }

        private void btn_ad_Click(object sender, EventArgs e)
        {
           //
        }

        private void btn_qlkh_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            frm_KhachHang dv = new frm_KhachHang();
            dv.TopLevel = false;
            this.panel2.Controls.Add(dv);
            dv.Show();
        }

        private void btn_thietbi_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            frm_TrangThietBi dv = new frm_TrangThietBi();
            dv.TopLevel = false;
            this.panel2.Controls.Add(dv);
            dv.Show();
        }
        void fillchart1()
        {
            //string select = "select * from ThietBi";
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(select, kn.connsql);
            //da.Fill(dt);
            //chart1.DataSource = dt;
            //chart1.Series["ht"].XValueMember = "TenTB";
            //var db = kn.connosql;
            //var collection = db.GetCollection<BsonDocument>("PHONG");
            //var query = collection.AsQueryable<BsonDocument>().ToList();
            //var filter = Builders<BsonDocument>.Filter.Eq("TenDN", txt_tendn.Text);
            //int dem0 = (int)cmd0.ExecuteScalar();

            //string count1 = "select count(*) from Phong where SoLuong!=0";
            //SqlCommand cmd1 = new SqlCommand(count1, kn.connsql);
            //int dem1 = (int)cmd1.ExecuteScalar();

            //string count2 = "select count(*) from Phong where SoLuong=2";
            //SqlCommand cmd2 = new SqlCommand(count2, kn.connsql);
            //int dem2 = (int)cmd2.ExecuteScalar();

            //string count3 = "select count(*) from Phong where SoLuong=3";
            //SqlCommand cmd3 = new SqlCommand(count3, kn.connsql);
            //int dem3 = (int)cmd3.ExecuteScalar();

            //string count4 = "select count(*) from Phong where SoLuong=4";
            //SqlCommand cmd4 = new SqlCommand(count4, kn.connsql);
            //int dem4 = (int)cmd4.ExecuteScalar();

            //kn.connsql.Close();
            //chart1.Series["ht"].Points.AddXY(dem0.ToString(), dem0);
            //chart1.Series["ht"].Points.AddXY(dem1.ToString(), dem1);
            //chart1.Series["ht"].Points.AddXY("Phòng 2 người", dem2);
            //chart1.Series["ht"].Points.AddXY("Phòng 3 người", dem3);
            //chart1.Series["ht"].Points.AddXY("Phòng 4 người", dem4);

            //chart1.Series["ht"].Points[0].Color = System.Drawing.Color.HotPink;
            //chart1.Series["ht"].Points[1].Color = System.Drawing.Color.SkyBlue;
            //chart1.Series["ht"].Points[0].LegendText = "Phòng trống";
            //chart1.Series["ht"].Points[1].LegendText = "Phòng đã có người";
            //chart1.Series["ht"].BorderWidth = 1;
            //chart1.Series["ht"].BorderColor = System.Drawing.Color.FromArgb(26, 59, 105);

            //chart1.Legends.Add("Legend1");
            //chart1.Legends[0].Enabled = true;
            //chart1.Legends[0].Docking = Docking.Bottom;
            //chart1.Legends[0].Alignment = System.Drawing.StringAlignment.Center;

            //chart1.Series[0].LegendText = "#PERCENT{P2}";
        }
        void fillchar2()
        {

            //var db = kn.connosql;
            //var collection = db.GetCollection<BsonDocument>("HoaDon");
            //var query = collection.AsQueryable<BsonDocument>().ToList();
            //double tt7 = 0;
            //double tt6 = 0;
            //double ttien = 0;
            //foreach (var item in query)
            //{
            //    DateTime dt = new DateTime();
            //    dt = DateTime.Parse(item[3].ToString());             
            //    if (dt.Year == 2020 && dt.Month == 7)
            //    {
            //        tt7 = tt7 + double.Parse(item[5].ToString());
            //    }
            //    if (dt.Year == 2020 && dt.Month == 6)
            //    {
            //        tt7 = tt7 + double.Parse(item[5].ToString());
            //    }
            //}    

            ////string count1 = "select Sum(ThanhTien) from SuDungDV where MaLoaiDV='L02' and Year(ThoiGian)='2019' and Month(ThoiGian)='1'";
            ////SqlCommand cmd1 = new SqlCommand(count1, kn.connsql);
            ////double dem1 = (double)cmd1.ExecuteScalar();

            ////string count2 = "select Sum(ThanhTien) from SuDungDV where MaLoaiDV='L03' and Year(ThoiGian)='2019' and Month(ThoiGian)='1'";
            ////SqlCommand cmd2 = new SqlCommand(count2, kn.connsql);
            ////double dem2 = (double)cmd2.ExecuteScalar();
            ////string count3 = "select Sum(ThanhTien) from SuDungDV where MaLoaiDV='L04' and Year(ThoiGian)='2019' and Month(ThoiGian)='1'";
            ////SqlCommand cmd3 = new SqlCommand(count3, kn.connsql);
            ////double dem3 = (double)cmd3.ExecuteScalar();
            ////string count4 = "select Sum(ThanhTien) from SuDungDV where MaLoaiDV='L05' and Year(ThoiGian)='2019' and Month(ThoiGian)='1'";
            ////SqlCommand cmd4 = new SqlCommand(count4, kn.connsql);
            ////double dem4 = (double)cmd4.ExecuteScalar();

            //chart2.Series["bd"].Points.AddXY("Tháng 7", tt7);
            //chart2.Series["bd"].Points.AddXY("Tháng 6", tt6);
            ////chart2.Series["bd"].Points.AddXY("Giữ xe", dem2);
            ////chart2.Series["bd"].Points.AddXY("Nước", dem3);
            ////chart2.Series["bd"].Points.AddXY("Rác", dem4);

            //chart2.Series["bd"].Points[0].LegendText = "Tháng 7";
            //chart2.Series["bd"].Points[1].LegendText = "Tháng 6";
            ////chart2.Series["bd"].Points[2].LegendText = "Giữ xe";
            ////chart2.Series["bd"].Points[3].LegendText = "Nước";
            ////chart2.Series["bd"].Points[4].LegendText = "Rác";

            //chart2.Series["bd"].Points[0].Color = System.Drawing.Color.DarkTurquoise;
            //chart2.Series["bd"].Points[1].Color = System.Drawing.Color.DarkTurquoise;
            ////chart2.Series["bd"].Points[2].Color = System.Drawing.Color.DarkTurquoise;
            ////chart2.Series["bd"].Points[3].Color = System.Drawing.Color.DarkTurquoise;
            ////chart2.Series["bd"].Points[4].Color = System.Drawing.Color.DarkTurquoise;


        }
        private void frm_QuanLiNhaTro_Load(object sender, EventArgs e)
        {
            item1.Text = frm_DangNhap.ID_USER.ToString();
            ma = frm_DangNhap.maq;
            if (ma == "2")
            {
                btn_qlhd.Enabled = false;
                itemtk.Enabled = false;
            }
            fillchar2();
            fillchart1();
        }

        private void btn_qlphong_Click(object sender, EventArgs e)
        {
            
            this.panel2.Controls.Clear();
            frm_Phong dv = new frm_Phong();
            dv.TopLevel = false;
            this.panel2.Controls.Add(dv);
            dv.Show();
            
        }

        private void btn_qlhd_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            frm_HopDong dv = new frm_HopDong();
            dv.TopLevel = false;
            this.panel2.Controls.Add(dv);
            dv.Show();
        }

        private void btn_hoadon_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            frm_HoaDon dv = new frm_HoaDon();
            dv.TopLevel = false;
            this.panel2.Controls.Add(dv);
            dv.Show();
        }

        

        private void frm_QuanLiNhaTro_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult r;
            r = MessageBox.Show("Bạn thật sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void itemtk_Click(object sender, EventArgs e)
        {

            this.panel2.Controls.Clear();
            frm_Admin dv = new frm_Admin();
            dv.TopLevel = false;
            this.panel2.Controls.Add(dv);

            dv.Show();
        }

        private void itemdx_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_DangNhap dn = new frm_DangNhap();
            dn.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
