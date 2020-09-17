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
    public partial class frm_DangNhap : Form
    {
        KetNoi kn;
        public static string ID_USER = "";
        public static string ma = "";
        public static string maq = "";
        public frm_DangNhap()
        {
            kn = new KetNoi();
            InitializeComponent();
            MongoClientSettings settings = new MongoClientSettings();
            this.MaximizeBox = false;
        }
        private string getID(string username, string pass)
        {
            string id = "";
            try
            {
                var db = kn.connosql;
                var collection = db.GetCollection<BsonDocument>("ADMIN");
                var builder = Builders<BsonDocument>.Filter;
                var query1 = builder.Eq("TenDN", txt_tendn.Text);
                var query = collection.Find(query1).ToList();
                foreach (var query2 in query)
                {
                    if(query2[4] == txt_matkhau.Text)
                    {
                        id = query2[3].ToString();
                    }
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            return id;
        }
        private string getMa(string username, string pass)
        {
            string id = "";
            try
            {
                var db = kn.connosql;
                var collection = db.GetCollection<BsonDocument>("ADMIN");
                var builder = Builders<BsonDocument>.Filter;
                var query1 = builder.Eq("TenDN", txt_tendn.Text);
                var query = collection.Find(query1).ToList();
                foreach (var query2 in query)
                {

                    id = query2[1].ToString();
                    maq = query2[9].ToString();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            return id;
                }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            ma = getMa(txt_tendn.Text, txt_matkhau.Text);
            ID_USER = getID(txt_tendn.Text, txt_matkhau.Text);
            if (ID_USER != "")
            {
                frm_QuanLiNhaTro qlnt = new frm_QuanLiNhaTro();
                this.Hide();
                qlnt.Show();
            }
            else
            {
                MessageBox.Show("Tài khoảng và mật khẩu không đúng !");
            }
         
     
        }

        private void frm_DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn thật sự muốn thoát?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void frm_DangNhap_Load(object sender, EventArgs e)
        {

        }
        public class AD//admin
        {
            public Object id { get; set; }
            public String MaAD { get; set; }
            public String HoTen { get; set; }
            public String TenDN { get; set; }
            public String MatKhau { get; set; }
            public String GioiTinh { get; set; }
            public String NgaySinh { get; set; }
            public String SDT { get; set; }
            public String Email { get; set; }
            public String MaQ { get; set; }

        }

        private void llbl_quenmk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
