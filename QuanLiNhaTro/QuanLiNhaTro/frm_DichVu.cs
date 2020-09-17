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
    public partial class frm_DichVu : Form
    {
        KetNoi kn;
        public frm_DichVu()
        {
            InitializeComponent();
            MongoClientSettings settings = new MongoClientSettings();
            kn = new KetNoi();

        }
        void load_grid()
        {

            var db = kn.connosql;
            var collection = db.GetCollection<BsonDocument>("LOAIDV");
            var document = collection.AsQueryable<BsonDocument>().ToList();
            dtgv_dv.Rows.Clear();
            foreach (var item in document)
            {
                dtgv_dv.Rows.Add(item[0], item[1], item[2], item[3]);
            }
            txt_madv.Enabled = false;
            txt_tendv.Enabled = false;
            txt_dongia.Enabled = false;
            btn_luu.Enabled = false;
            btn_sua.Enabled = false;
            btn_them.Enabled = true;
            btn_xoa.Enabled = false;
        }
        void load_gridsddv()
        {
            var db = kn.connosql;
            var collection = db.GetCollection<BsonDocument>("SD_DICHVU");
            var document = collection.AsQueryable<BsonDocument>().ToList();
            dtgv_qldv.Rows.Clear();
            foreach (var item in document)
            {
                var collection1 = db.GetCollection<BsonDocument>("LOAIDV");
                var buider = Builders<BsonDocument>.Filter;
                var query = buider.Eq("MaLoaiDV", item[8]);
                var malp = collection1.Find(query).FirstOrDefault();
                dtgv_qldv.Rows.Add(item[0], item[1], item[2], item[3], item[4], item[5], item[6], item[7], malp["TenLoaiDV"]);
            }
            txt_masd.Enabled = false;
            txt_maph.Enabled = false;
            txt_time.Enabled = false;
            txt_sl.Enabled = false;
            txt_socu.Enabled = false;
            txt_somoi.Enabled = false;
            txt_thanhtien.Enabled = false;
            cbo_dv.Enabled = false;
            toolStripButton1.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
        }
      

        private void label1_Click(object sender, EventArgs e)
        {
            //
        }

        private void frm_DichVu_Load(object sender, EventArgs e)
        {
            load_grid();
            load_gridsddv();
        }
        private void load_cbo()
        {
            DataTable dt = new DataTable();
            var db = kn.connosql;
            var collection = db.GetCollection<LOAIDV>("LOAIDV");
            var document = collection.AsQueryable<LOAIDV>().ToList();
            //foreach (var item in document)
            //{
            //    dt.Rows.Add(item[0], item[1], item[2],item[3]);

            //}

            cbo_dv.DataSource = document;
            cbo_dv.DisplayMember = "TenLoaiDV";
            cbo_dv.ValueMember = "MaLoaiDV";
        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            btn_luu.Enabled = true;
            txt_madv.Enabled = true;
            txt_tendv.Enabled = true;
            txt_dongia.Enabled = true;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            txt_dongia.Clear();
            txt_madv.Clear();
            txt_tendv.Clear();

        }

        private void dtgv_dv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgv_dv_Click(object sender, EventArgs e)
        {
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_DichVu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn thật sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btn_luu_Click(object sender, EventArgs e)// form dịch vụ
        {
            try
            {
                var db = kn.connosql;
                var collection = db.GetCollection<BsonDocument>("LOAIDV");
                //var document = collection.AsQueryable<BsonDocument>().ToList();

                if (txt_madv.Enabled == true)
                {
                    var buider = Builders<BsonDocument>.Filter;
                    var query = buider.Eq("MaLoaiDV", txt_madv.Text);
                    var document = collection.Find(query).FirstOrDefault();
                    if (document == null)
                    {
                        try
                        {
                            BsonDocument document1 = new BsonDocument
                            {
                            { "MaLoaiDV",txt_madv.Text},
                            { "TenLoaiDV",txt_tendv.Text},
                            { "DonGia",int.Parse(txt_dongia.Text)},
                            };

                            collection.InsertOne(document1);
                            MessageBox.Show("Thêm thành công");
                        }
                        catch { }
                    }
                    else
                    {
                        MessageBox.Show("Mã Loại dịch vụ đã tồn lại");
                    }

                }
                else
                {
                    var filter = Builders<BsonDocument>.Filter.Eq("MaLoaiDV", txt_madv.Text);
                    var update = Builders<BsonDocument>.Update.Set("TenLoaiDV", txt_tendv.Text).Set("DonGia", txt_dongia.Text);
                    collection.UpdateOne(filter, update);
                    MessageBox.Show("Bạn đã update thành công");
                }
                btn_luu.Enabled = false;
                btn_sua.Enabled = false;
                load_grid();

            }
            catch
            {
                MessageBox.Show("Thất bại");
                btn_luu.Enabled = true;
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            txt_madv.Enabled = false;
            txt_tendv.Enabled = true;
            txt_dongia.Enabled = true;
            btn_luu.Enabled = true;
            btn_xoa.Enabled = false;
            btn_them.Enabled = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)// form dịch vụ
        {
            try
            {
                DialogResult r;
                r = MessageBox.Show("Bạn thật sự muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (r == DialogResult.OK)
                {
                    var db = kn.connosql;
                    var collection1 = db.GetCollection<BsonDocument>("SD_DICHVU");
                    var buider = Builders<BsonDocument>.Filter;
                    var query = buider.Eq("MaLoaiDV", txt_madv.Text);
                    var document = collection1.Find(query).FirstOrDefault();
                    if (document == null)
                    {
                        try
                        {
                            var collection = db.GetCollection<BsonDocument>("LOAIDV");
                            var filter = Builders<BsonDocument>.Filter.Eq("MaLoaiDV", txt_madv.Text);
                            var result = collection.DeleteOne(filter);
                            MessageBox.Show("Xóa thành công");
                            load_grid();
                        }
                        catch
                        {
                            MessageBox.Show("Dữ liệu đang sử dụng.Không thể xóa");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Dữ liệu đang sử dụng.Không thể xóa");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống");
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            txt_masd.Enabled = true;
            txt_maph.Enabled = true;
            txt_sl.Enabled = false;
            txt_socu.Enabled = false;
            txt_somoi.Enabled = false;
            txt_time.Enabled = false;
            txt_thanhtien.Enabled = false;
            var db = kn.connosql;
            var collection = db.GetCollection<BsonDocument>("LOAIDV");
            var document = collection.AsQueryable<BsonDocument>().ToList();
            txt_masd.Clear();
            txt_maph.Clear();
            txt_socu.Clear();
            txt_somoi.Clear();
            txt_sl.Clear();
            txt_thanhtien.Clear();
            cbo_dv.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            load_cbo();


        }

        private void dtgv_qldv_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (cbo_dv.Text == "Điện" || cbo_dv.Text == "Nước")

            {
                txt_socu.Enabled = true;
                txt_somoi.Enabled = true;
                txt_sl.Enabled = false;
            }
            else if (cbo_dv.Text == "Giữ xe")
            {
                txt_sl.Enabled = true;
                txt_socu.Enabled = false;
                txt_somoi.Enabled = false;
            }
            else
            {
                txt_socu.Enabled = false;
                txt_somoi.Enabled = false;
                txt_sl.Enabled = false;
            }
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            toolStripButton1.Enabled = false;
        }

       

        private void btnXoa_Click(object sender, EventArgs e)// form sử dụng dịch vụ
        {
            try
            {
                DialogResult r;
                r = MessageBox.Show("Bạn thật sự muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (r == DialogResult.OK)
                {
                    var db = kn.connosql;
                    try
                    {
                        var collection = db.GetCollection<BsonDocument>("SD_DICHVU");
                        var filter = Builders<BsonDocument>.Filter.Eq("MaSD", txt_masd.Text);
                        var result = collection.DeleteOne(filter);
                        MessageBox.Show("Xóa thành công");
                        load_gridsddv();
                    }
                    catch
                    {
                        MessageBox.Show("Dữ liệu đang sử dụng.Không thể xóa");
                    }
                }
            }
            catch { }
        }
        public class LOAIDV
        {
            public ObjectId _id { get; set; }
            public string MaLoaiDV { get; set; }
            public string TenLoaiDV { get; set; }
            public int DonGia { get; set; }
        }
  



        
        private void lbl_socu_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        
        
        public class LDV//loại dịch vụ
        {
            public Object id { get; set; }
            public String MaLoaiDV { get; set; }
            public String TenLoaiDV { get; set; }
            public String DonGia { get; set; }

        }
        public class SDDV//sử dụng dịch vụ
        {
            public Object id { get; set; }
            public String MaSD { get; set; }
            public String MaPH { get; set; }
            public String ThoiGian { get; set; }
            public String SoLuong { get; set; }
            public String SoCu { get; set; }
            public String SoMoi { get; set; }
            public String ThanhTien { get; set; }
            public String MaLoaiDV { get; set; }
        }
     

        private void dtgv_dv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_dv.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                txt_madv.Text = dtgv_dv.Rows[dtgv_dv.CurrentRow.Index].Cells[1].Value.ToString();
                txt_tendv.Text = dtgv_dv.Rows[dtgv_dv.CurrentRow.Index].Cells[2].Value.ToString();
                txt_dongia.Text = dtgv_dv.Rows[dtgv_dv.CurrentRow.Index].Cells[3].Value.ToString();
            }
        }

        private void dtgv_qldv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_qldv.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                txt_masd.Text = dtgv_qldv.Rows[dtgv_qldv.CurrentRow.Index].Cells[1].Value.ToString();
                txt_maph.Text = dtgv_qldv.Rows[dtgv_qldv.CurrentRow.Index].Cells[2].Value.ToString();
                txt_time.Text = dtgv_qldv.Rows[dtgv_qldv.CurrentRow.Index].Cells[3].Value.ToString();
                txt_sl.Text = dtgv_qldv.Rows[dtgv_qldv.CurrentRow.Index].Cells[4].Value.ToString();
                txt_socu.Text = dtgv_qldv.Rows[dtgv_qldv.CurrentRow.Index].Cells[5].Value.ToString();
                txt_somoi.Text = dtgv_qldv.Rows[dtgv_qldv.CurrentRow.Index].Cells[6].Value.ToString();
                txt_thanhtien.Text = dtgv_qldv.Rows[dtgv_qldv.CurrentRow.Index].Cells[7].Value.ToString();
                cbo_dv.Text = dtgv_qldv.Rows[dtgv_qldv.CurrentRow.Index].Cells[8].Value.ToString();
            }
        }

    

        private void txt_tendv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true; // chỉ cho nhập ký tự là chữ cái nếu nhập số sẽ không hiển thị
        }

        private void txt_socu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true; // chỉ nhập số nếu nhập chữ sẽ không hiển thị
            }
        }

        private void txt_somoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true; // chỉ nhập số nếu nhập chữ sẽ không hiển thị
            }
        }

        private void txt_sl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
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

        private void txt_soluongxe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true; // chỉ nhập số nếu nhập chữ sẽ không hiển thị
            }
        }

        private void btnLuu_SuDungDichVu_Click(object sender, EventArgs e)
        {
            try
            {
                var db = kn.connosql;
                var collection = db.GetCollection<BsonDocument>("SD_DICHVU");
                //var document = collection.AsQueryable<BsonDocument>().ToList();
                var collection1 = db.GetCollection<BsonDocument>("LOAIDV");
                var buider = Builders<BsonDocument>.Filter;
                var query = buider.Eq("TenLoaiDV", cbo_dv.Text);
                var madv = collection1.Find(query).FirstOrDefault();

                if (cbo_dv.Text == "Điện" || cbo_dv.Text == "Nước")
                {
                    txt_thanhtien.Text = ((int.Parse(txt_somoi.Text) - int.Parse(txt_socu.Text)) * int.Parse(madv["DonGia"].ToString())).ToString();
                }
                else if (cbo_dv.Text == "Giữ xe")
                {
                    txt_thanhtien.Text = (int.Parse(txt_sl.Text) * int.Parse(madv["DonGia"].ToString())).ToString();
                }
                else
                {
                    txt_thanhtien.Text = madv["DonGia"].ToString();
                }
                if (txt_masd.Enabled == true)
                {
                    var document = collection.AsQueryable<BsonDocument>().ToList();

                    Boolean kt = false;
                    foreach (var item in document)
                    {
                        if (item[1].ToString() == txt_masd.Text || (item[2].ToString() == txt_maph.Text && item[8].ToString() == cbo_dv.SelectedValue.ToString()))
                            kt = true;
                    }
                    if (kt == false)
                    {
                        try
                        {
                            BsonDocument document1 = new BsonDocument
                            {
                                { "MaSD",txt_masd.Text},
                                { "MaPH",txt_maph.Text},
                                { "ThoiGian",DateTime.Now.ToString("dd/MM/yyyy")},
                                { "SoLuong", int.Parse(txt_sl.Text)},
                                { "SoCu", int.Parse(txt_socu.Text)},
                                { "SoMoi", int.Parse(txt_somoi.Text)},
                                { "ThanhTien", double.Parse(txt_thanhtien.Text)},
                                { "MaLoaiDV", cbo_dv.SelectedValue.ToString() },
                            };

                            collection.InsertOne(document1);
                            MessageBox.Show("Thêm thành công");
                        }
                        catch { }
                    }
                    else
                    {
                        MessageBox.Show("Mã sử dụng dịch vụ đã tồn lại");
                    }

                }
                else
                {
                    var filter = Builders<BsonDocument>.Filter.Eq("MaSD", txt_masd.Text);
                    var update = Builders<BsonDocument>.Update.Set("SoLuong", int.Parse(txt_sl.Text))
                        .Set("SoCu", int.Parse(txt_socu.Text))
                        .Set("SoMoi", int.Parse(txt_somoi.Text))
                        .Set("ThanhTien", double.Parse(txt_thanhtien.Text));
                    collection.UpdateOne(filter, update);
                    MessageBox.Show("Bạn đã update thành công");
                }
                btn_luu.Enabled = false;
                btn_sua.Enabled = false;
                load_gridsddv();

            }
            catch
            {
                MessageBox.Show("Thất bại");
                btn_luu.Enabled = true;
            }
        }

        private void cbo_dv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_dv.SelectedValue.ToString() == "L01" || cbo_dv.SelectedValue.ToString() == "L04")
            {
                txt_socu.Enabled = true;
                txt_somoi.Enabled = true;
                txt_sl.Enabled = false;
                txt_sl.Text = "0";
            }
            else if (cbo_dv.SelectedValue.ToString() == "L03")
            {
                txt_sl.Enabled = true;
                txt_socu.Enabled = false;
                txt_somoi.Enabled = false;
                txt_socu.Text = "0";
                txt_somoi.Text = "0";
            }
            else
            {
                txt_socu.Enabled = false;
                txt_somoi.Enabled = false;
                txt_sl.Enabled = false;
                txt_sl.Text = "0";
                txt_socu.Text = "0";
                txt_somoi.Text = "0";
            }
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            try
            {
                var db = kn.connosql;
                var collection1 = db.GetCollection<BsonDocument>("SD_DICHVU");
                var buider = Builders<BsonDocument>.Filter;
                var query = buider.Eq("MaPH", toolStripTextBox1.Text);
                var document = collection1.Find(query).ToList();
                dtgv_qldv.Rows.Clear();
                foreach (var item in document)
                {
                    dtgv_qldv.Rows.Add(item[0], item[1], item[2], item[3], item[4], item[5], item[6], item[7], item[8]);

                }
                txt_masd.Enabled = false;
                txt_maph.Enabled = false;
                txt_time.Enabled = false;
                txt_sl.Enabled = false;
                txt_socu.Enabled = false;
                txt_somoi.Enabled = false;
                txt_thanhtien.Enabled = false;
                cbo_dv.Enabled = false;
                toolStripButton1.Enabled = true;
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                btnLuu.Enabled = false;
            }
            catch { }
        }
    
    }
}
