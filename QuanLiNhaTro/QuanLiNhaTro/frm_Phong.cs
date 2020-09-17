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
using System.Web.UI.WebControls;

namespace QuanLiNhaTro
{
    public partial class frm_Phong : Form
    {
        KetNoi kn;
        public frm_Phong()
        {
            InitializeComponent();
            MongoClientSettings settings = new MongoClientSettings();
            kn = new KetNoi();
        }
        void load_grid()
        {

            var db = kn.connosql;
            var collection = db.GetCollection<BsonDocument>("PHONG");
            var query = collection.AsQueryable<BsonDocument>().ToList();
            var collection1 = db.GetCollection<BsonDocument>("LOAIPHONG");
            dtgv_ph.Rows.Clear();
            foreach (var query1 in query)
            {
                var buider = Builders<BsonDocument>.Filter;
                var maloaiph = buider.Eq("MaLoaiPH", query1[3]);
                var tenphong = collection1.Find(maloaiph).FirstOrDefault();
                dtgv_ph.Rows.Add(query1[0], query1[1], query1[2], tenphong[2],tenphong[3],tenphong[4]);

            }
        }
        public void loadLoaiPH()
        {
            var db = kn.connosql;
            var collection = db.GetCollection<BsonDocument>("LOAIPHONG");
            var document = collection.AsQueryable<BsonDocument>().ToList();
            foreach (var item in document)
            {
                cbo_loaiph.Items.Add(item[1]);
            }
        }

        private void frm_Phong_Load(object sender, EventArgs e)
        {
            load_grid();
            loadLoaiPH();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            btn_luu.Enabled = true;
            txt_maphong.Enabled = cbo_loaiph.Enabled = true;
            txt_maphong.Clear();
            txt_soluong.Clear();
            txt_kichthuoc.Clear();
            txt_dongia.Clear();
            txt_maphong.Focus();
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn thật sự muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                try
                {
                    var db = kn.connosql;
                    var collection = db.GetCollection<BsonDocument>("PHONG");
                    var filter = Builders<BsonDocument>.Filter.Eq("MaPH", txt_maphong.Text);
                    collection.DeleteOne(filter);
                    MessageBox.Show("xóa thành công");
                }
                catch
                {
                    MessageBox.Show("Dữ liệu đang sử dụng.Không thể xóa");
                }
            }
            load_grid();
            btn_luu.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_them.Enabled = true;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            btn_luu.Enabled = true;
            cbo_loaiph.Enabled = true;
            txt_maphong.Enabled = false;
            txt_soluong.Enabled = true;
            txt_soluong.Enabled = true;
            btn_them.Enabled = false;
            btn_xoa.Enabled = true;
        }

        private void dtgv_ph_Click(object sender, EventArgs e)
        {
            btn_xoa.Enabled = btn_sua.Enabled = true;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                var db = kn.connosql;
                var collection = db.GetCollection<BsonDocument>("PHONG");
                if (txt_maphong.Enabled == false)// update docment
                {
                    DialogResult r;
                    r = MessageBox.Show("Bạn thật sự muốn chỉnh sửa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        try
                        {
                            var document = collection.AsQueryable<BsonDocument>().ToList();
                            var filter = Builders<BsonDocument>.Filter.Eq("MaPH", txt_maphong.Text);
                            var update = Builders<BsonDocument>.Update
                                .Set("SoLuong", txt_soluong.Text);
                            collection.UpdateOne(filter, update);
                            load_grid();
                            MessageBox.Show("Bạn đã chỉnh sửa thành công");
                        }
                        catch
                        {
                            MessageBox.Show("Dữ liệu đang sử dụng.Không thể xóa");
                        }

                    }
                }
                else// insert document
                {
                    BsonDocument bsonElements = new BsonDocument
                    {
                        { "MaPH",txt_maphong.Text},
                        { "SoLuong",txt_soluong.Text},
                    };
                    collection.InsertOne(bsonElements);
                    MessageBox.Show("Đã lưu thành công");
                    load_grid();
                }
            }
            catch
            {
                MessageBox.Show("Thất bại");
            }
            btn_luu.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_them.Enabled = true;
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            //string strselect = "select MaPH,TenLoaiPH,KichThuoc,SoLuong,DonGia from Phong,LoaiPhong where Phong.MaLoaiPH=LoaiPhong.MaLoaiPH and MaPH=N'" + txt_tim.Text + "'";
            //da = new SqlDataAdapter(strselect, kn.connsql);
            //ds = new DataSet();
            //da.Fill(ds, "Phong");
            //key[0] = ds.Tables["Phong"].Columns["MaPH"];
            //ds.Tables["Phong"].PrimaryKey = key;
            //dtgv_ph.DataSource = ds.Tables["Phong"];
        }

        private void btn_loaiphong_Click(object sender, EventArgs e)
        {
            frm_LoaiPhong lp = new frm_LoaiPhong();
            this.Hide();
            lp.ShowDialog();

        }
        public class PH//phòng
        {
            public Object id { get; set; }
            public String MaPH { get; set; }
            public String SoLuong { get; set; }
            public String MaLoaiPH { get; set; }
        }
        public class LOAIPH//loại phòng
        {
            public Object id { get; set; }
            public String MaLoaiPH { get; set; }
            public String TenLoaiPH { get; set; }
            public String KichThuoc { get; set; }
            public String DonGia { get; set; }
            public String SoNguoiTD { get; set; }

        }
        private void dtgv_ph_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_ph.SelectedRows.Count == 0)
                return;
            txt_maphong.Text = dtgv_ph.Rows[dtgv_ph.CurrentRow.Index].Cells[1].Value.ToString();
            txt_soluong.Text = dtgv_ph.Rows[dtgv_ph.CurrentRow.Index].Cells[2].Value.ToString();
            cbo_loaiph.Text = dtgv_ph.Rows[dtgv_ph.CurrentRow.Index].Cells[3].Value.ToString();
            txt_kichthuoc.Text = dtgv_ph.Rows[dtgv_ph.CurrentRow.Index].Cells[4].Value.ToString();
            txt_dongia.Text = dtgv_ph.Rows[dtgv_ph.CurrentRow.Index].Cells[5].Value.ToString();
        }

        private void dtgv_ph_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn thật sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {

            }
            else
                this.Close();
            frm_QuanLiNhaTro frm = new frm_QuanLiNhaTro();
            frm.Show();
        }

        private void frm_Phong_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn thật sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
            frm_QuanLiNhaTro frm = new frm_QuanLiNhaTro();
            frm.Show();


        }

        private void txt_soluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true; // chỉ nhập số nếu nhập chữ sẽ không hiển thị
            }
        }
    }
}
