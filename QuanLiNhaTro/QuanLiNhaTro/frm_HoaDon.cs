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
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core;
namespace QuanLiNhaTro
{
    public partial class frm_HoaDon : Form
    {
        KetNoi kn;
        public frm_HoaDon()
        {
            InitializeComponent();
            MongoClientSettings settings = new MongoClientSettings();
            kn = new KetNoi();
        }

        private void frm_HoaDon_Load(object sender, EventArgs e)
        {
            load_hd();
        }
        void load_hd()
        {
            try
            {
                var db = kn.connosql;
                var collection = db.GetCollection<BsonDocument>("HOADON");
                var document = collection.AsQueryable<BsonDocument>().ToList();
                dtgv_hoadon.Rows.Clear();
                foreach (var item in document)
                {
                    dtgv_hoadon.Rows.Add(item[0], item[1], item[2], item[3], String.Format("{0:0.00}",
                        float.Parse(item[4].ToString())), item[5], item[6]);
                }

                txt_mahd.Enabled = false;
                txt_maph.Enabled = false;
                txt_ngaylap.Enabled = false;
                txt_thue.Enabled = false;
                btn_luu.Enabled = false;
                btn_them.Enabled = true;
                btn_xoa.Enabled = false;
            }
            catch { }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            btn_luu.Enabled = true;
            txt_mahd.Enabled = false;
            txt_ngaylap.Enabled = false;
            txt_thue.Enabled = true;
            txt_tongtien.Enabled = false;
            txt_thanhtien.Enabled = false;
            btn_xoa.Enabled = false;
            txt_maph.Enabled = true;
            txt_mahd.Clear();
            txt_maph.Clear();
            txt_thanhtien.Clear();
            txt_thue.Clear();
            txt_tongtien.Clear();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn thật sự muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (r == DialogResult.OK)
            {
                var db = kn.connosql;
                try
                {
                    var collection = db.GetCollection<BsonDocument>("HOADON");
                    var filter = Builders<BsonDocument>.Filter.Eq("MaHoaDon", txt_mahd.Text);
                    var result = collection.DeleteOne(filter);
                    MessageBox.Show("Xóa thành công");
                    load_hd();
                }
                catch
                {
                    MessageBox.Show("Dữ liệu đang sử dụng.Không thể xóa");
                }
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                var db = kn.connosql;
                var collection = db.GetCollection<BsonDocument>("HOADON");
                var document = collection.AsQueryable<BsonDocument>().ToList();
                var collection1 = db.GetCollection<BsonDocument>("SD_DICHVU");
                var buider = Builders<BsonDocument>.Filter;
                var query = buider.Eq("MaPH", txt_maph.Text);
                var maph = collection1.Find(query).ToList();
                double tt = 0;
                double ttien = 0;
                foreach (var item in maph)
                {
                    DateTime dt = new DateTime();
                    dt = DateTime.Parse(item[3].ToString());
                    DateTime dt1 = new DateTime();
                    dt1 = DateTime.Parse(txt_ngaylap.Text);
                    if (dt.Year == dt1.Year && dt.Month == dt1.Month)
                    {
                        tt = tt + double.Parse(item[7].ToString());
                    }
                }
                var collection2 = db.GetCollection<BsonDocument>("PHONG");
                var buider1 = Builders<BsonDocument>.Filter;
                var query1 = buider1.Eq("MaPH", txt_maph.Text);
                var maph1 = collection2.Find(query1).FirstOrDefault();
                ///////////////////////////////////////////
                var collection3 = db.GetCollection<BsonDocument>("LOAIPHONG");
                var buider2 = Builders<BsonDocument>.Filter;
                var query2 = buider2.Eq("MaLoaiPH", maph1["MaLoaiPH"].ToString());
                var malp = collection3.Find(query2).FirstOrDefault();
                txt_thanhtien.Text = (tt + double.Parse(malp["DonGia"].ToString())).ToString();
                ttien = double.Parse(txt_thanhtien.Text) * double.Parse(txt_thue.Text) + double.Parse(txt_thanhtien.Text);
                txt_tongtien.Text = ttien.ToString();
                try
                {
                    BsonDocument document1 = new BsonDocument
                        {
                        { "MaHoaDon","HD"+(document.Count()+1)},
                        { "ThanhTien",double.Parse(txt_thanhtien.Text)},
                        { "NgayLapHD",DateTime.Now.ToString("dd/MM/yyyy")},
                        { "ThueVAT",double.Parse(txt_thue.Text)},
                        { "TongTien", ttien},
                        { "MaPH", txt_maph.Text }
                        };

                    collection.InsertOne(document1);
                    MessageBox.Show("Thêm thành công");
                    load_hd();
                }
                catch
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            catch
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void dtgv_hoadon_Click(object sender, EventArgs e)
        {
            btn_xoa.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_HoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn thật sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgv_hoadon_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_hoadon.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {

                txt_mahd.Text = dtgv_hoadon.Rows[dtgv_hoadon.CurrentRow.Index].Cells[1].Value.ToString();
                txt_maph.Text = dtgv_hoadon.Rows[dtgv_hoadon.CurrentRow.Index].Cells[6].Value.ToString();
                txt_thanhtien.Text = dtgv_hoadon.Rows[dtgv_hoadon.CurrentRow.Index].Cells[2].Value.ToString();
                txt_ngaylap.Text = dtgv_hoadon.Rows[dtgv_hoadon.CurrentRow.Index].Cells[3].Value.ToString();
                txt_thue.Text = String.Format("{0:0.00}", float.Parse(dtgv_hoadon.Rows[dtgv_hoadon.CurrentRow.Index].Cells[4].Value.ToString()));
                txt_tongtien.Text = dtgv_hoadon.Rows[dtgv_hoadon.CurrentRow.Index].Cells[5].Value.ToString();
            }
        }

        public class HD//hóa đơn
        {
            public Object id { get; set; }
            public String MaHoaDon { get; set; }
            public String ThanhTien { get; set; }
            public String NgayLapHD { get; set; }
            public String ThueVAT { get; set; }
            public String TongTien { get; set; }

        }
        public class CTHD//chi tiết hóa đơn
        {
            public Object id { get; set; }
            public Object MaCTHD { get; set; }
            public Object MaHoaDon { get; set; }
            public Object MaPH { get; set; }
            public Object ThoiGian { get; set; }
            public Object ThanhTien { get; set; }
        }

        private void txt_thue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true; // chỉ nhập số nếu nhập chữ sẽ không hiển thị
            }
        }

        private void txt_thanhtien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true; // chỉ nhập số nếu nhập chữ sẽ không hiển thị
            }
        }

        private void txt_tongtien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true; // chỉ nhập số nếu nhập chữ sẽ không hiển thị
            }
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            if (txt_timkiem.Text != "ALL")
            {
                try
                {
                    var db = kn.connosql;
                    var collection1 = db.GetCollection<BsonDocument>("HOADON");
                    var buider = Builders<BsonDocument>.Filter;
                    var query = buider.Eq("MaHoaDon", txt_timkiem.Text);
                    var document = collection1.Find(query).ToList();
                    dtgv_hoadon.Rows.Clear();
                    foreach (var item in document)
                    {
                        dtgv_hoadon.Rows.Add(item[0], item[1], item[2], item[3], String.Format("{0:0.00}", float.Parse(item[4].ToString())), item[5], item[6]);
                    }
                    txt_mahd.Enabled = false;
                    txt_maph.Enabled = false;
                    txt_ngaylap.Enabled = false;
                    txt_thue.Enabled = false;
                    btn_luu.Enabled = false;
                    btn_them.Enabled = true;
                    btn_xoa.Enabled = false;
                }
                catch { }
            }
            else
                load_hd();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (dtgv_hoadon.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                string mahd = dtgv_hoadon.Rows[dtgv_hoadon.CurrentRow.Index].Cells[1].Value.ToString();
                ShowReportHoaDon dv = new ShowReportHoaDon(mahd);
                dv.Show();

            }

            

        }
    }
    
}
