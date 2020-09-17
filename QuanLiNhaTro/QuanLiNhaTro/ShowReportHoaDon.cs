using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.Data.Filtering.Helpers;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Linq.Expressions;

namespace QuanLiNhaTro
{
    public partial class ShowReportHoaDon : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string mahd = "";
        KetNoi kn;
        public ShowReportHoaDon()
        {
            InitializeComponent();
            MongoClientSettings settings = new MongoClientSettings();
            kn = new KetNoi();
        }
        public ShowReportHoaDon(string ma)
        {
            mahd = ma;
            InitializeComponent();
            kn = new KetNoi();
        }
        private void documentViewer1_Load(object sender, EventArgs e)
        {
            try
            {
                var db = kn.connosql;
                var collection1 = db.GetCollection<BsonDocument>("HOADON");
                var query = Builders<BsonDocument>.Filter.Eq("MaHoaDon", mahd);
                var hoadon = collection1.Find(query).FirstOrDefault();
                ReportHoaDon rp = new ReportHoaDon();
                rp.Parameters["NgayLap"].Value = DateTime.Parse(hoadon[3].ToString()).ToString("MM/yyyy");
                rp.Parameters["SoPhong"].Value = hoadon[6].ToString();
                rp.Parameters["TongTien"].Value = hoadon[5].ToString();
                var collection2 = db.GetCollection<BsonDocument>("HOPDONG");
                var maphong = Builders<BsonDocument>.Filter.Eq("MaPH", hoadon[6].ToString());
                var khachhang = collection2.Find(maphong).FirstOrDefault();
                var collection3 = db.GetCollection<BsonDocument>("KHACHHANG");
                var makh = Builders<BsonDocument>.Filter.Eq("MaKH", khachhang[2].ToString());
                var tenkh = collection3.Find(makh).FirstOrDefault();
                rp.Parameters["TenKH"].Value = tenkh[2].ToString();
                var collection4 = db.GetCollection<BsonDocument>("PHONG");
                var maphong1 = Builders<BsonDocument>.Filter.Eq("MaPH", hoadon[6].ToString());
                var phong = collection4.Find(maphong1).FirstOrDefault();
                rp.Parameters["SoNguoi"].Value = phong[2].ToString();
                /////
                var collection5 = db.GetCollection<BsonDocument>("LOAIPHONG");
                var maloaiphong = Builders<BsonDocument>.Filter.Eq("MaLoaiPH", phong[3].ToString());
                var tienphong = collection5.Find(maloaiphong).FirstOrDefault();
                rp.Parameters["TienPhong"].Value = tienphong[4].ToString();
                documentViewer1.DocumentSource = rp;
                /////
                var collection6 = db.GetCollection<BsonDocument>("SD_DICHVU");
                var dichvu = Builders<BsonDocument>.Filter.Eq("MaPH", phong[1].ToString());
                var dichvu1 = collection6.Find(dichvu).ToList();
                foreach (var item in dichvu1)
                {
                    if (item[8].ToString() == "L01")
                    {
                        rp.Parameters["TienDien"].Value = item[7].ToString();
                        rp.Parameters["DienCu"].Value = item[5].ToString();
                        rp.Parameters["DienMoi"].Value = item[6].ToString();


                    }
                    else if (item[8].ToString() == "L02")
                    {
                        rp.Parameters["TienWifi"].Value = item[7].ToString();

                    }
                    else if (item[8].ToString() == "L03")
                    {
                        rp.Parameters["TienXe"].Value = item[7].ToString();
                        rp.Parameters["SLXe"].Value = item[4].ToString();
                    }
                    else if (item[8].ToString() == "L04")
                    {
                        rp.Parameters["TienNuoc"].Value = item[7].ToString();
                        rp.Parameters["NuocCu"].Value = item[5].ToString();
                        rp.Parameters["NuocMoi"].Value = item[6].ToString();
                    }
                    else if (item[8].ToString() == "L05")
                    {
                        rp.Parameters["TienRac"].Value = item[7].ToString();
                    }
                }

                documentViewer1.Refresh();
            }
            catch
            {
                MessageBox.Show("Phòng này chưa được đăng kí ở, lỗi hệ thống");
            }
        }
    }
}