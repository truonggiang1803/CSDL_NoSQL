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
    public partial class frm_ThemThietBi : Form
    {
        KetNoi kn;
        public frm_ThemThietBi()
        {
            InitializeComponent();
            MongoClientSettings settings = new MongoClientSettings();
            kn = new KetNoi();
        }
        void load_grid()
        {
            var db = kn.connosql;
            var collection = db.GetCollection<TB>("THIETBI");
            var query = collection.AsQueryable<TB>().ToList();
            dtgv_thietbi.Rows.Clear();
            foreach (var query1 in query)
            {
                TB tb = new TB();
                tb.id = query1.id;
                tb.MaTB = query1.MaTB;
                tb.TenTB = query1.TenTB;
                dtgv_thietbi.Rows.Add(query1.id, query1.MaTB, query1.TenTB);
            }
        }
        private void frm_ThemThietBi_Load(object sender, EventArgs e)
        {
            load_grid();
            btn_luu.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            txt_mathietbi.Enabled = false;
            txt_tenthietbi.Enabled = false;
        }

        private void dtgv_thietbi_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_thietbi.SelectedRows.Count == 0)
                return;
            txt_mathietbi.Text = dtgv_thietbi.Rows[dtgv_thietbi.CurrentRow.Index].Cells[1].Value.ToString();
            txt_tenthietbi.Text = dtgv_thietbi.Rows[dtgv_thietbi.CurrentRow.Index].Cells[2].Value.ToString();
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_luu.Enabled = true;
            txt_mathietbi.Enabled = true;
            txt_tenthietbi.Enabled = true;
            txt_mathietbi.Clear();
            txt_tenthietbi.Clear();
            txt_mathietbi.Focus();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            btn_luu.Enabled = true;
            btn_them.Enabled = false;
            btn_xoa.Enabled = false;
            txt_mathietbi.Enabled = false;
            txt_tenthietbi.Enabled = true;
            btn_xoa.Enabled = true;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                var db = kn.connosql;
                var collection = db.GetCollection<BsonDocument>("THIETBI");
                if (txt_mathietbi.Enabled == false)// update docment
                {
                    DialogResult r;
                    r = MessageBox.Show("Bạn thật sự muốn chỉnh sửa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        try
                        {
                            var document = collection.AsQueryable<BsonDocument>().ToList();
                            var filter = Builders<BsonDocument>.Filter.Eq("MaTB", txt_mathietbi.Text);
                            var update = Builders<BsonDocument>.Update
                                .Set("TenTB", txt_tenthietbi.Text);
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
                        { "MaTB",txt_mathietbi.Text},
                        { "TenTB",txt_tenthietbi.Text},

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
            btn_them.Enabled = true;
            btn_sua.Enabled = false;
            btn_luu.Enabled = false;
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
                    var collection = db.GetCollection<BsonDocument>("THIETBI");
                    var filter = Builders<BsonDocument>.Filter.Eq("MaTB", txt_mathietbi.Text);
                    collection.DeleteOne(filter);
                    MessageBox.Show("xóa thành công");
                }
                catch
                {
                    MessageBox.Show("Dữ liệu đang sử dụng.Không thể xóa");
                }
            }
                
                btn_sua.Enabled = false;
                btn_xoa.Enabled = false;
                btn_luu.Enabled = false;
                btn_them.Enabled = true;
            load_grid();

            
        }

        private void frm_ThemThietBi_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn thật sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn thật sự muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
            frm_TrangThietBi frm = new frm_TrangThietBi();
            frm.Show();
        }
        public class TB//thiết bị
        {
            public Object id { get; set; }
            public String MaTB { get; set; }
            public String TenTB { get; set; }
        }

        private void frm_ThemThietBi_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn thật sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
            frm_TrangThietBi frm = new frm_TrangThietBi();
            frm.Show();
        }

        private void txt_tenthietbi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true; // chỉ cho nhập ký tự là chữ cái nếu nhập số sẽ không hiển thị
        }
    }
}
