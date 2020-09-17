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
    public partial class frm_TrangThietBi : Form
    {
        KetNoi kn;
        //SqlConnection cn;
        DataSet ds;
        SqlDataAdapter da;
        DataColumn[] key = new DataColumn[1];
        public frm_TrangThietBi()
        {
            InitializeComponent();
            MongoClientSettings settings = new MongoClientSettings();
            kn = new KetNoi();
            //cn = new SqlConnection("Data Source=ACER-PC;Initial Catalog=QL_NHATRO;Integrated Security=True");

            //key[0] = ds.Tables["ThietBi"].Columns[0];
            //ds.Tables["ThietBi"].PrimaryKey = key;
        }
        void load_grid()
        {
            //string strselect = "select SDThietBi.MaTB,TenTB,MaPH from SDThietBi,ThietBi where SDThietBi.MaTB=Thietbi.MaTB";
            //da = new SqlDataAdapter(strselect, kn.connsql);
            //ds = new DataSet();
            //da.Fill(ds, "ThietBi");
            //dtgv_thietbi.DataSource = ds.Tables["ThietBi"];
            //Databingding(ds.Tables["LoaiDV"]);
            var db = kn.connosql;
            var collection = db.GetCollection<SDTB>("SD_THIETBI");
            var query = collection.AsQueryable<SDTB>().ToList();
            dtgv_thietbi.Rows.Clear();
            foreach (var query1 in query)
            {
                SDTB sdtb = new SDTB();
                sdtb.id = query1.id;
                sdtb.MaPH = query1.MaPH;
                sdtb.MaTB = query1.MaTB;
                dtgv_thietbi.Rows.Add(query1.id, query1.MaPH, query1.MaTB);
            }
        }

        private void frm_TrangThietBi_Load(object sender, EventArgs e)
        {
            loadTB();
            load_grid();
            btn_luu.Enabled = false;
            btn_xoa.Enabled = false;
            cbo_thietbi.Enabled = false;
            txt_maph.Enabled = false;

        }
        public void loadTB()
        {
            //string strselect;
            //strselect = "select * from ThietBi";
            //SqlDataAdapter da_TB = new SqlDataAdapter(strselect, kn.connsql);
            //DataTable dt_TB = new DataTable();
            //da_TB.Fill(dt_TB);
            //cbo_thietbi.DataSource = dt_TB;
            //cbo_thietbi.DisplayMember = "TenTB";
            //cbo_thietbi.ValueMember = "MaTB";
            //cbo_thietbi.SelectedItem = cbo_thietbi.Items[0];

        }

        private void dtgv_thietbi_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try {
                if (dtgv_thietbi.SelectedRows.Count == 0)
                    return;
                cbo_thietbi.Text = dtgv_thietbi.Rows[dtgv_thietbi.CurrentRow.Index].Cells[2].Value.ToString();
                txt_maph.Text = dtgv_thietbi.Rows[dtgv_thietbi.CurrentRow.Index].Cells[1].Value.ToString();

                btn_xoa.Enabled = true;
            }
            catch { }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            btn_luu.Enabled = true;

            btn_xoa.Enabled = false;
            cbo_thietbi.Enabled = true;
            txt_maph.Enabled = true;

        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                var db = kn.connosql;
                var collection = db.GetCollection<BsonDocument>("SD_THIETBI");
                if (cbo_thietbi.Enabled == false)// update docment
                {
                    DialogResult r;
                    r = MessageBox.Show("Bạn thật sự muốn chỉnh sửa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        try
                        {
                            var document = collection.AsQueryable<BsonDocument>().ToList();
                            var filter = Builders<BsonDocument>.Filter.Eq("MaTB", cbo_thietbi.Text);
                            //var update = Builders<BsonDocument>.Update.Set("TenTB", TENTB.Text);
                            //collection.UpdateOne(filter, update);
                            load_grid();
                            MessageBox.Show("Bạn đã chỉnh sửa thành công");
                        }
                        catch
                        {
                            MessageBox.Show("Dữ liệu đang sử dụng.Không thể xóa");
                        }
                        load_grid();

                    }
                }
                else// insert document
                {
                    BsonDocument bsonElements = new BsonDocument
                    {
                        { "MaTB",cbo_thietbi.Text},
                        //{ "TenTB",.Text},
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
                    var collection = db.GetCollection<BsonDocument>("SD_THIETBI");
                    var filter = Builders<BsonDocument>.Filter.Eq("MaTB", cbo_thietbi.Text);
                    collection.DeleteOne(filter);
                    MessageBox.Show("xóa thành công");
                }
                catch
                {
                    MessageBox.Show("Dữ liệu đang sử dụng.Không thể xóa");
                }
                load_grid();
            }
            btn_luu.Enabled = false;
            btn_them.Enabled = true;

            btn_xoa.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ThemThietBi tb = new ThemThietBi();
            //this.Hide();
            //tb.ShowDialog();
            //tb.Close();
            this.tableLayoutPanel1.Controls.Clear();
            frm_ThemThietBi tb = new frm_ThemThietBi();
            tb.TopLevel = false;
            this.tableLayoutPanel1.Controls.Add(tb);
            tb.Show();
        }

        private void frm_TrangThietBi_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn thật sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
        public class TB//thiết bị
        {
            public Object id { get; set; }
            public String MaTB { get; set; }
            public String TenTB { get; set; }
        }
        public class SDTB//sử dụng thiết bị
        {
            public Object id { get; set; }
            public String MaPH { get; set; }
            public String MaTB { get; set; }
        }

        private void dtgv_thietbi_Click(object sender, EventArgs e)
        {
            btn_luu.Enabled = false;
            btn_them.Enabled = false;
        }

        private void frm_TrangThietBi_FormClosing_1(object sender, FormClosingEventArgs e)
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
    }
}
