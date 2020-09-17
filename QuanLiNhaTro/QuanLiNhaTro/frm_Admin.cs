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
    public partial class frm_Admin : Form
    {
        
        KetNoi kn;
        public frm_Admin()
        {
            
            InitializeComponent();
            MongoClientSettings settings = new MongoClientSettings();
            kn = new KetNoi();

        }
        void load_grid()
        {
            var db = kn.connosql;
            var collection = db.GetCollection<BsonDocument>("ADMIN");
            var query = collection.AsQueryable<BsonDocument>().ToList();        
            foreach (var query1 in query)
            {
                dtgv_qltk.Rows.Add(query1[0],query1[1], query1[2], query1[3], query1[4], query1[5], query1[6], query1[7], query1[8], query1[9]);
            }

        }

        void loadAD()
        {
            var db = kn.connosql;
            var collection = db.GetCollection<BsonDocument>("ADMIN");
            var builder = Builders<BsonDocument>.Filter;
            var query1 = builder.Eq("MaAD", frm_DangNhap.ma);
            var query = collection.Find(query1).ToList();
            foreach (var query2 in query)
            {

                txt_ma.Text = frm_DangNhap.ma;
                txt_hoten.Text = query2[2].ToString();
                if (query2[5].ToString()=="Nam")
                {
                    rdo_nam.Checked = true;
                    rdo_nu.Checked = false;
                }
                else
                {
                    rdo_nam.Checked = false;
                    rdo_nu.Checked = true;
                }
                mtxt_ngaysinh.Text = (DateTime.Parse(query2[6].ToString())).ToString("dd/MM/yyyy");
                txt_mail.Text= query2[8].ToString();
                txt_sdt.Text = query2[7].ToString();
                txt_tentk.Text = query2[3].ToString();
                txt_mk.Text = query2[4].ToString();
            }
        }
            public void loadQuyen()
        {

        }
        private void frm_Admin_Load(object sender, EventArgs e)
        {
            loadAD();
            loadQuyen();
            load_grid();

            cbo_quyen.Enabled = false;
            rdo_nam.Enabled = false;
            rdo_nu.Enabled = false;

            txt_manv.Enabled = false;
            txt_tenngql.Enabled = false;
            txt_tendn.Enabled = false;
            txtMatKhau.Enabled = false;
            txtNgaySinh.Enabled = false;
            txtSDT.Enabled = false;
            txtEmail.Enabled = false;
        }

        private void tab_thongtinad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            foreach (Control item in tableLayoutPanel5.Controls)
            {
                if (item.GetType() == typeof(TextBox) || item.GetType() == typeof(MaskedTextBox) ||
                    item.GetType() == typeof(RadioButton))
                {
                    item.Enabled = true;
                }
            }
            load_grid();
            txt_ma.Enabled = false;
            rdo_nam.Enabled = true;
            rdo_nu.Enabled = true;
        }

        private void btn_dangxuat_Click_1(object sender, EventArgs e)
        {

        }

        private void dtgv_qltk_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            btn_luu.Enabled = true;
            foreach (Control item in tableLayoutPanel2.Controls)
            {
                if (item.GetType() == typeof(TextBox) || item.GetType() == typeof(ComboBox) || item.GetType() == typeof(MaskedTextBox))
                    item.Enabled = true;
            }
            rdoNam.Enabled = true;
            rdoNu.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            txt_manv.Clear();
            txt_tenngql.Clear();
            txt_tendn.Clear();
            txtMatKhau.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txt_manv.Focus();
            txtNgaySinh.Enabled = true;

        }

        private void dtgv_qltk_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            foreach (Control item in tableLayoutPanel2.Controls)
            {
                if (item.GetType() == typeof(TextBox) || item.GetType() == typeof(ComboBox) || item.GetType() == typeof(MaskedTextBox))
                    item.Enabled = true;
            }
            rdoNam.Enabled = true;
            rdoNu.Enabled = true;
            txtNgaySinh.Enabled = true;
            txt_manv.Enabled = false;
            btn_luu.Enabled = true;
            btnXoa.Enabled = true;
            btn_them.Enabled = false;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {

            try
            {
                var db = kn.connosql;
                var collection = db.GetCollection<BsonDocument>("AD");
                if (txt_manv.Enabled == false)// update docment
                {
                    DialogResult r;
                    r = MessageBox.Show("Bạn thật sự muốn chỉnh sửa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        try
                        {
                            var document = collection.AsQueryable<BsonDocument>().ToList();
                            var filter = Builders<BsonDocument>.Filter.Eq("MaAD", txt_manv.Text);
                            var update = Builders<BsonDocument>.Update
                                .Set("HoTen", txt_hoten.Text)
                                .Set("TenDN", txt_tentk.Text)
                                .Set("MatKhau", txt_mk.Text)
                                //    if (rdoNam.Checked == true)
                                //{
                                //    .Set("GioiTinh", rdoNam.Text);
                                //}

                                //else
                                //{
                                //    .Set("GioiTinh", rdoNam.Text);
                                //}    
                                //.Set(DateTime.Parse(txtNgaySinh.Text).ToString())
                                .Set("SDT", txt_sdt.Text)
                                .Set("Email", txt_mail.Text);
                                //.Set("MaQ", .Text);
                            collection.UpdateOne(filter, update);
                            loadAD();
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
                        { "MaAD",txt_manv.Text},
                        { "HoTen",txt_tenngql.Text},
                        { "TenDN",txt_tendn.Text},
                        { "MatKhau",txtMatKhau.Text},
                //        {
                //                if (rdoNam.Checked == true)
                //    {
                //        { "GioiTinh", rdoNam.Text; }
                //    }

                //    else
                //    {
                //        { "GioiTinh", rdoNam.Text; }
                //    }
                //},       
                        { "NgaySinh", DateTime.Parse(txtNgaySinh.Text).ToString()},
                        { "SDT",txtSDT.Text},
                        { "Email",txtEmail.Text},
                        //{ "MaQ",txt_songuoitd.Text},
                    };
                    collection.InsertOne(bsonElements);
                    MessageBox.Show("Đã lưu thành công");
                    loadAD();
                }
            }
            catch
            {
                MessageBox.Show("Thất bại");
            }
            loadAD();
            txt_manv.Enabled = false;
            txt_tenngql.Enabled = false;
            txt_tendn.Enabled = false;
            txtMatKhau.Enabled = false;
            cbo_quyen.Enabled = false;
            rdo_nam.Enabled = false;
            rdo_nu.Enabled = false;
            txtNgaySinh.Enabled = false;
            txtSDT.Enabled = false;
            txtEmail.Enabled = false;
            btn_luu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btn_them.Enabled = true;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r;
                r = MessageBox.Show("Bạn thật sự muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (r == DialogResult.OK)
                {
                    try
                    {
                        var db = kn.connosql;
                        var collection = db.GetCollection<BsonDocument>("AD");
                        var filter = Builders<BsonDocument>.Filter.Eq("MaAD", txt_manv.Text);
                        collection.DeleteOne(filter);
                        MessageBox.Show("xóa thành công");
                    }
                    catch
                    {
                        MessageBox.Show("Dữ liệu đang sử dụng.Không thể xóa");
                    }
                }
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btn_them.Enabled = true;
                btn_luu.Enabled = false;
                loadAD();
            }
            catch
            {
                MessageBox.Show("Dữ liệu đang sử dụng.Không thể xóa");
            }
            loadAD();

        }

        private void frm_Admin_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult r;
            r = MessageBox.Show("Bạn thật sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
            frm_QuanLiNhaTro frm = new frm_QuanLiNhaTro();
            frm.Show();
        }

        private void dtgv_qltk_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtgv_qltk.SelectedRows.Count == 0)
                    return;
                txt_manv.Text = dtgv_qltk.Rows[dtgv_qltk.CurrentRow.Index].Cells[1].Value.ToString();
                txt_tenngql.Text = dtgv_qltk.Rows[dtgv_qltk.CurrentRow.Index].Cells[2].Value.ToString();
                txt_tendn.Text = dtgv_qltk.Rows[dtgv_qltk.CurrentRow.Index].Cells[3].Value.ToString();
                txtMatKhau.Text = dtgv_qltk.Rows[dtgv_qltk.CurrentRow.Index].Cells[4].Value.ToString();
                cbo_quyen.Text = dtgv_qltk.Rows[dtgv_qltk.CurrentRow.Index].Cells[9].Value.ToString();
                if (dtgv_qltk.Rows[dtgv_qltk.CurrentRow.Index].Cells[5].Value.ToString().Equals("Nam") == true)
                    rdoNam.Checked = true;
                else
                    rdoNu.Checked = true;
                txtNgaySinh.Text = dtgv_qltk.Rows[dtgv_qltk.CurrentRow.Index].Cells[6].Value.ToString();
                txtSDT.Text = dtgv_qltk.Rows[dtgv_qltk.CurrentRow.Index].Cells[7].Value.ToString();
                txtEmail.Text = dtgv_qltk.Rows[dtgv_qltk.CurrentRow.Index].Cells[8].Value.ToString();


            }
            catch { }
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btn_them.Enabled = true;
            btn_luu.Enabled = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn thật sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                
            }
            this.Close();
            frm_QuanLiNhaTro frm = new frm_QuanLiNhaTro();
            this.Show();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn thật sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                
            }
            this.Close();
            frm_QuanLiNhaTro frm = new frm_QuanLiNhaTro();
            frm.Show();
        }

        private void txt_tenngql_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true; // chỉ cho nhập ký tự là chữ cái nếu nhập số sẽ không hiển thị
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true; // chỉ nhập số nếu nhập chữ sẽ không hiển thị
            }
        }

        private void txt_hoten_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true; // chỉ cho nhập ký tự là chữ cái nếu nhập số sẽ không hiển thị
        }

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true; // chỉ nhập số nếu nhập chữ sẽ không hiển thị
            }
        }

        private void btn_sua_Click_1(object sender, EventArgs e)
        {

        }

        private void dtgv_qltk_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
