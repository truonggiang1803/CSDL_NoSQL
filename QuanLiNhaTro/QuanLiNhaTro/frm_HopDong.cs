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
using MongoDB.Driver.GeoJsonObjectModel;
using MongoDB.Driver.Linq;
namespace QuanLiNhaTro
{
    public partial class frm_HopDong : Form
    {
        KetNoi kn;
        public frm_HopDong()
        {
            InitializeComponent();
            MongoClientSettings settings = new MongoClientSettings();
            kn = new KetNoi();
        }

        void load_grid()
        {

            var db = kn.connosql;
            var collection = db.GetCollection<BsonDocument>("HOPDONG");
            var document = collection.AsQueryable<BsonDocument>().ToList();
            dtgv_hopdong.Rows.Clear();
            foreach (var item in document)
            {
                dtgv_hopdong.Rows.Add(item[0], item[1], item[2], item[3], item[4], item[5], item[6], item[7]);
            }
        }
        void load_KhachHang()
        {
            var db = kn.connosql;
            var collection = db.GetCollection<BsonDocument>("KHACHHANG");
            var document = collection.AsQueryable<BsonDocument>().ToList();
            foreach (var item in document)
            {
                cboMaKH.Items.Add(item[1]);
            }
        }
        Boolean kt(string a)
        {
            var db = kn.connosql;
            var collection1 = db.GetCollection<BsonDocument>("HOPDONG");
            var document1 = collection1.AsQueryable<BsonDocument>().ToList();
            foreach (var item1 in document1)
            {
                if (item1[3].ToString() == a)
                {
                    return true;
                }
            }
            return false;
        }
        void load_Phong()
        {
            var db = kn.connosql;
            var collection = db.GetCollection<BsonDocument>("PHONG");
            var document = collection.AsQueryable<BsonDocument>().ToList();

            foreach (var item in document)
            {
                if (kt(item[1].ToString()) == false)
                    cboMaPH.Items.Add(item[1]);
            }
        }

        private void frm_HopDong_Load(object sender, EventArgs e)
        {
            load_grid();
            load_KhachHang();
            load_Phong();
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            btn_luu.Enabled = false;
            txt_mahd.Enabled = false;
            txt_ngaylamhd.Enabled = false;
            txt_tiencoc.Enabled = false;
            txt_ngaybd.Enabled = false;
            txt_ngaykt.Enabled = false;
            cboMaKH.Enabled = false;
            cboMaPH.Enabled = false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            btn_luu.Enabled = true;
            txt_mahd.Clear();
            txt_tiencoc.Clear();
            txt_mahd.Enabled = true;
            txt_tiencoc.Enabled = true;
            txt_ngaybd.Enabled = true;
            txt_ngaykt.Enabled = true;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            cboMaKH.Enabled = true;
            cboMaPH.Enabled = true;
            txt_mahd.Focus();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            btn_luu.Enabled = true;
            txt_mahd.Enabled = false;
            txt_tiencoc.Enabled = true;
            txt_ngaybd.Enabled = true;
            txt_ngaykt.Enabled = true;
            btn_xoa.Enabled = false;
            btn_them.Enabled = false;
            cboMaKH.Enabled = true;
            cboMaPH.Enabled = true;
        }

        private void dtgv_hopdong_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_ngaylamhd.Text = "";
                if (dtgv_hopdong.SelectedRows.Count == 0)
                    return;

                txt_mahd.Text = dtgv_hopdong.Rows[dtgv_hopdong.CurrentRow.Index].Cells[1].Value.ToString();
                cboMaKH.Text = dtgv_hopdong.Rows[dtgv_hopdong.CurrentRow.Index].Cells[2].Value.ToString();
                cboMaPH.Text = dtgv_hopdong.Rows[dtgv_hopdong.CurrentRow.Index].Cells[3].Value.ToString();
                txt_tiencoc.Text = dtgv_hopdong.Rows[dtgv_hopdong.CurrentRow.Index].Cells[7].Value.ToString();
                txt_ngaylamhd.Text = (DateTime.Parse(dtgv_hopdong.Rows[dtgv_hopdong.CurrentRow.Index].Cells[4].Value.ToString()).ToString("dd/MM/yyyy"));
                txt_ngaykt.Text = (DateTime.Parse(dtgv_hopdong.Rows[dtgv_hopdong.CurrentRow.Index].Cells[5].Value.ToString()).ToString("dd/MM/yyyy"));
                txt_ngaybd.Text = (DateTime.Parse(dtgv_hopdong.Rows[dtgv_hopdong.CurrentRow.Index].Cells[6].Value.ToString()).ToString("dd/MM/yyyy"));
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
                btn_them.Enabled = true;
                btn_luu.Enabled = false;
                txt_mahd.Enabled = false;
                //txt_ngaylamhd.Enabled = false;
                //txt_tiencoc.Enabled = false;
                txt_ngaybd.Enabled = false;
                txt_ngaykt.Enabled = false;
                cboMaKH.Enabled = false;
                cboMaPH.Enabled = false;
            }
            catch { }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                var db = kn.connosql;
                var collection = db.GetCollection<BsonDocument>("HOPDONG");
                if (txt_mahd.Enabled == false)// update docment
                {
                    DialogResult r;
                    r = MessageBox.Show("Bạn thật sự muốn chỉnh sửa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        try
                        {
                            var document = collection.AsQueryable<BsonDocument>().ToList();
                            var filter = Builders<BsonDocument>.Filter.Eq("MaHD", txt_mahd.Text);
                            var update = Builders<BsonDocument>.Update
                                .Set("MaKH", cboMaKH.Text)
                                .Set("MaPH", cboMaPH.Text)
                                .Set("NgayLapHD", DateTime.Now.ToString("dd/MM/yyyy"))
                                .Set("NgayBD", DateTime.Parse(txt_ngaybd.Text).ToString("dd/MM/yyyy"))
                                .Set("NgayKT", DateTime.Parse(txt_ngaykt.Text).ToString("dd/MM/yyyy"))
                                .Set("TienCoc", double.Parse(txt_tiencoc.Text));
                            collection.UpdateOne(filter, update);
                            load_grid();
                            MessageBox.Show("Bạn đã chỉnh sửa thành công");
                        }
                        catch
                        {
                            MessageBox.Show("Dữ liệu đang sử dụng.Không thể xóa");
                        }
                        cboMaKH.Enabled = false;
                        cboMaPH.Enabled = false;

                    }
                }
                else// insert document
                {
                    BsonDocument bsonElements = new BsonDocument
                    {
                        { "MaHD",txt_mahd.Text},
                        { "MaKH",cboMaKH.Text},
                        { "MaPH",cboMaPH.Text},
                        { "NgayLapHD",DateTime.Now.ToString("dd/MM/yyyy")},
                        { "NgayBD",DateTime.Parse(txt_ngaybd.Text).ToString("dd/MM/yyyy")},
                        { "NgayKT",DateTime.Parse(txt_ngaykt.Text).ToString("dd/MM/yyyy")},
                        { "TienCoc",double.Parse(txt_tiencoc.Text)},
                    };
                    collection.InsertOne(bsonElements);
                    MessageBox.Show("Đã lưu thành công");
                    load_grid();
                }
            }
            catch
            {

            }
            load_grid();
            btn_luu.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_them.Enabled = true;
            txt_mahd.Enabled = false;
            txt_ngaylamhd.Enabled = false;
            txt_tiencoc.Enabled = false;
            txt_ngaybd.Enabled = false;
            txt_ngaykt.Enabled = false;
        }

        private void dtp2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtp3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn thật sự muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                var db = kn.connosql;
                try
                {
                    var collection = db.GetCollection<BsonDocument>("HOPDONG");
                    var document = collection.AsQueryable<BsonDocument>().ToList();
                    var filter = Builders<BsonDocument>.Filter.Eq("MaHD", txt_mahd.Text);
                    var result = collection.DeleteOne(filter);
                    MessageBox.Show("xóa thành công");
                    load_grid();
                }
                catch
                {
                    MessageBox.Show("Dữ liệu đang sử dụng.Không thể xóa");
                }
            }
            //load_grid();
            //btn_them.Enabled = true;
            //btn_sua.Enabled = false;
            //btn_luu.Enabled = false;
            //btn_xoa.Enabled = false;


        }

        private void frm_HopDong_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btn_tim_Click(object sender, EventArgs e)
        {
            //DataRow drtk = dt_HD.Rows.Find(txt_tim.Text);
            //if (txt_tim.Text != string.Empty)
            //{
            //    if (drtk != null)
            //    {
            //        string inserthd = "select * from HopDong where MaHD ='" + txt_tim.Text + "'";
            //        DataTable dt_inserthd = new DataTable();
            //        SqlDataAdapter da_inserthd = new SqlDataAdapter(inserthd, kn.connsql);
            //        da_inserthd.Fill(dt_inserthd);
            //        dtgv_hopdong.DataSource = dt_inserthd;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Mã hợp đồng không tồn tại");
            //        return;
            //    }
            //}
            //else
            //{
            //    dtgv_hopdong.DataSource = dt_HD;
            //}

        }

        private void btn_xemin_Click(object sender, EventArgs e)
        {
            //frm_ShowReportHopDong s = new frm_ShowReportHopDong(cboMaPH.SelectedText.ToString());
            //this.Hide();
            //s.ShowDialog();
            //this.Show();
        }

        //private void btn_xemin_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //    PrintHopDong phd = new PrintHopDong(txt_mahd.Text);
        //    phd.ShowDialog();
        //    phd.Close();
        //}
        public class HD//hợp đồng
        {
            public Object id { get; set; }
            public String MaHD { get; set; }
            public String MaKH { get; set; }
            public String MaPH { get; set; }
            public String NgayLamHD { get; set; }
            public String NgayBD { get; set; }
            public String NgayKT { get; set; }
            public String TienCoc { get; set; }
        }

        private void txt_tiencoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true; // chỉ nhập số nếu nhập chữ sẽ không hiển thị
            }
        }

        private void dtgv_hopdong_Click(object sender, EventArgs e)
        {
            btn_sua.Enabled = true;
            btn_them.Enabled = true;
            btn_xoa.Enabled = true;
        }

        private void txt_ngaybd_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
