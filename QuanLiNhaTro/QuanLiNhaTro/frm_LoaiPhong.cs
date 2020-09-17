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
    public partial class frm_LoaiPhong : Form
    {
        KetNoi kn;
        public frm_LoaiPhong()
        {
            InitializeComponent();
            MongoClientSettings settings = new MongoClientSettings();
            kn = new KetNoi();
        }
        void load_grid()
        {
            var db = kn.connosql;
            var collection = db.GetCollection<BsonDocument>("LOAIPHONG");
            var query = collection.AsQueryable<BsonDocument>().ToList();
            dtgv_ph.Rows.Clear();
            foreach (var query1 in query)
            {
                dtgv_ph.Rows.Add(query1[0], query1[1], query1[2], query1[3], query1[4], query1[5]);
            }
        }
        private void frm_LoaiPhong_Load(object sender, EventArgs e)
        {
            load_grid();
            btn_luu.Enabled = false;
            btn_sua.Enabled = false;
            btn_them.Enabled = true;
            btn_xoa.Enabled = false;
            txt_malp.Enabled = false;
            txt_tenlp.Enabled = false;
            txt_songuoitd.Enabled = false;
            txt_kichthuoc.Enabled = false;
            txt_dongia.Enabled = false;
            
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            btn_luu.Enabled = true;
            txt_malp.Enabled = true;
            txt_tenlp.Enabled = true;
            txt_songuoitd.Enabled = true;
            txt_kichthuoc.Enabled = true;
            txt_dongia.Enabled = true;
            txt_malp.Clear();
            txt_kichthuoc.Clear();
            txt_dongia.Clear();
            txt_songuoitd.Clear();
            txt_tenlp.Clear();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            btn_xoa.Enabled = true;
            btn_them.Enabled = false;
            btn_luu.Enabled = true;
            txt_malp.Enabled = false;
            txt_tenlp.Enabled = true;
            txt_songuoitd.Enabled = true;
            txt_kichthuoc.Enabled = true;
            txt_dongia.Enabled = true;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                var db = kn.connosql;
                var collection = db.GetCollection<BsonDocument>("LOAIPHONG");
                if (txt_malp.Enabled == false)// update docment
                {
                    DialogResult r;
                    r = MessageBox.Show("Bạn thật sự muốn chỉnh sửa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        try
                        {
                            var document = collection.AsQueryable<BsonDocument>().ToList();
                            var filter = Builders<BsonDocument>.Filter.Eq("MaLoaiPH", txt_malp.Text);
                            var update = Builders<BsonDocument>.Update
                                .Set("TenLoaiPH", txt_tenlp.Text)
                                .Set("KichThuoc", txt_kichthuoc.Text)
                                .Set("DonGia", txt_dongia.Text)
                                .Set("SoNguoiTD", txt_songuoitd.Text);
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
                        { "MaLoaiPH",txt_malp.Text},
                        { "TenLoaiPH",txt_tenlp.Text},
                        { "KichThuoc",txt_kichthuoc.Text},
                        { "DonGia",txt_dongia.Text},
                        { "SoNguoiTD",txt_songuoitd.Text},
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
            btn_them.Enabled = true;
            btn_xoa.Enabled = false;

            txt_malp.Enabled = false;
            txt_tenlp.Enabled = false;
            txt_songuoitd.Enabled = false;
            txt_kichthuoc.Enabled = false;
            txt_dongia.Enabled = false;
        }

        private void dtgv_ph_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtgv_ph.SelectedRows.Count == 0)
                    return;
                txt_malp.Text = dtgv_ph.Rows[dtgv_ph.CurrentRow.Index].Cells[1].Value.ToString();
                txt_tenlp.Text = dtgv_ph.Rows[dtgv_ph.CurrentRow.Index].Cells[2].Value.ToString();
                txt_kichthuoc.Text = dtgv_ph.Rows[dtgv_ph.CurrentRow.Index].Cells[3].Value.ToString();
                txt_dongia.Text = dtgv_ph.Rows[dtgv_ph.CurrentRow.Index].Cells[4].Value.ToString();
                txt_songuoitd.Text = dtgv_ph.Rows[dtgv_ph.CurrentRow.Index].Cells[5].Value.ToString();
            }
            catch { }
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
                    var collection = db.GetCollection<BsonDocument>("LOAIPHONG");
                    var filter = Builders<BsonDocument>.Filter.Eq("MaLoaiPH", txt_malp.Text);
                    collection.DeleteOne(filter);
                    MessageBox.Show("xóa thành công");
                }
                catch
                {
                    MessageBox.Show("Dữ liệu đang sử dụng.Không thể xóa");
                }
            }
            btn_luu.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_them.Enabled = true;
            load_grid();
        }
        public class LP//loại phòng
        {
            public Object id { get; set; }
            public String MaLoaiPH { get; set; }
            public String TenLoaiPH { get; set; }
            public String KichThuoc { get; set; }
            public String DonGia { get; set; }
            public String SoNguoiTD { get; set; }

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn thật sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
            frm_Phong frm = new frm_Phong();
            frm.Show();
        }

        private void dtgv_ph_Click(object sender, EventArgs e)
        {
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
        }

        private void frm_LoaiPhong_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn thật sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void txt_songuoitd_TextChanged(object sender, EventArgs e)
        {
            //Control ctr = (Control)sender;
            //if (ctr.Text.Length > 0 && !char.IsDigit(ctr.Text[ctr.Text.Length - 11]))
            
            //    this.errorProvider1.SetError(ctr, "");
            //    //MessageBox.Show("Số người phải là kí tự số!");
            
            //else
            //    this.errorProvider1.Clear();
                


        }

        private void txt_dongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true; // chỉ nhập số nếu nhập chữ sẽ không hiển thị
            }
        }

        private void txt_songuoitd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true; // chỉ nhập số nếu nhập chữ sẽ không hiển thị
            }
        }

        private void txt_tenlp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true; // chỉ cho nhập ký tự là chữ cái nếu nhập số sẽ không hiển thị
        }
    }
}
