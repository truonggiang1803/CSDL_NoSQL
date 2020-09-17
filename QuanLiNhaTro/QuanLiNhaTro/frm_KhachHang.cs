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
    public partial class frm_KhachHang : Form
    {
        KetNoi kn;
        public frm_KhachHang()
        {
                kn = new KetNoi();
                InitializeComponent();
        }
        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            load_grid();
        }

        private void load_grid()
        {
            treeView1.Nodes.Clear();
            TreeNode tnode = new TreeNode();
            var db = kn.connosql;
            var collection = db.GetCollection<BsonDocument>("KHACHHANG");
            var document = collection.AsQueryable<BsonDocument>().ToList();
            int k = 0;
            foreach (BsonDocument doc in document)
            {
                tnode = treeView1.Nodes.Add("document[" + k + "]");
                int h = 0;
                foreach (var item in doc)
                {

                    string[] item1 = item.Value.ToString().Split(',');
                    if (item1.Count() == 1)
                    {
                        treeView1.Nodes[k].Nodes.Add(item.Name + ":" + item.Value);

                    }
                    else
                    {
                        treeView1.Nodes[k].Nodes.Add(item.Name);
                        for (int i = 0; i < item1.Count(); i++)
                            if (i == 0)
                            {
                                treeView1.Nodes[k].Nodes[h].Nodes.Add(item.Name + i + ":" + item1[i].Substring(1, item1[i].Count() - 1).ToString());
                            }
                            else if (i == item1.Count() - 1)
                            {
                                treeView1.Nodes[k].Nodes[h].Nodes.Add(item.Name + i + ":" + item1[i].Substring(0, item1[i].Count() - 1).ToString());
                            }
                            else
                            {
                                treeView1.Nodes[k].Nodes[h].Nodes.Add(item.Name + i + ":" + item1[i].ToString());
                            }

                    }
                    h++;
                }
                k++;
            }
        }

        public class KH//khách hàng
        {
            public Object id { get; set; }
            public String MaKH { get; set; }
            public String TenKH { get; set; }
            public String NgaySinh { get; set; }
            public String CMND { get; set; }
            public String QueQuan { get; set; }
            public String GioiTinh { get; set; }
            public String SDT { get; set; }
            public String MaPH { get; set; }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            listView1.Items.Clear();
            var db = kn.connosql;
            var collection = db.GetCollection<BsonDocument>("KHACHHANG");
            var document = collection.AsQueryable<BsonDocument>().ToList();
            int k = 0;
            int d = 0;
            foreach (BsonDocument doc in document)
            {
                int h = 0;
                if (e.Node.Index == d)
                {
                    foreach (var item in doc)
                    {

                        string[] item1 = item.Value.ToString().Split(',');
                        if (item1.Count() == 1)
                        {
                            ListViewItem kh = new ListViewItem(item.Name.ToString());
                            ListViewItem.ListViewSubItem ctkh = new ListViewItem.ListViewSubItem(kh, item.Value.ToString());
                            kh.SubItems.Add(ctkh);
                            listView1.Items.Add(kh);
                        }
                        else
                        {
                            for (int i = 0; i < item1.Count(); i++)
                            {
                                ListViewItem kh = new ListViewItem(item.Name + ':' + i);
                                ListViewItem.ListViewSubItem ctkh = new ListViewItem.ListViewSubItem();
                                if (i == 0)
                                {
                                    ctkh = new ListViewItem.ListViewSubItem(kh, item1[i].Substring(1, item1[i].Count() - 1).ToString());
                                }
                                else if (i == item1.Count() - 1)
                                {
                                    ctkh = new ListViewItem.ListViewSubItem(kh, item1[i].Substring(0, item1[i].Count() - 1).ToString());
                                }
                                else
                                {
                                    ctkh = new ListViewItem.ListViewSubItem(kh, item1[i].ToString());
                                }
                                kh.SubItems.Add(ctkh);

                                listView1.Items.Add(kh);
                            }




                        }
                        h++;

                    }

                }
                d++;

            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                ListViewItem item = listView1.SelectedItems[0];
                txtTen.Text = item.SubItems[0].Text;
                txtDulieu.Text = item.SubItems[1].Text;
            }
            catch
            {
                txtDulieu.Text = "";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            txtDulieu.Clear();
            txtTen.Clear();
        }

        private void btnThemThuocTinh_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTen.Text != "" && txtDulieu.Text != "")
                {

                    ListViewItem kh = new ListViewItem(txtTen.Text);
                    ListViewItem.ListViewSubItem ctkh = new ListViewItem.ListViewSubItem(kh, txtDulieu.Text);
                    kh.SubItems.Add(ctkh);
                    listView1.Items.Add(kh);
                    txtDulieu.Clear();
                    txtTen.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống!");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.Items[0].SubItems[0].Text != "_id")
                {
                    var db = kn.connosql;
                    var collection = db.GetCollection<BsonDocument>("KHACHHANG");
                    var str = "";
                    BsonDocument document1 = new BsonDocument();
                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        if (listView1.Items[i].SubItems[0].Text == "MaPH")
                        {
                            var db1 = kn.connosql;
                            var collection1 = db1.GetCollection<BsonDocument>("PHONG");
                            var filter1 = Builders<BsonDocument>.Filter.Eq("MaPH", listView1.Items[i].SubItems[1].Text);
                            var query = collection1.Find(filter1).FirstOrDefault();
                            if (query != null)
                            {
                                var update = Builders<BsonDocument>.Update.Set("SoLuong", int.Parse(query[2].ToString()) + 1);
                                collection1.UpdateOne(filter1, update);
                            }
                        }
                        BsonDocument document2;
                        str = '{' + listView1.Items[i].SubItems[0].Text + ':' + '"' + listView1.Items[i].SubItems[1].Text + '"' + '}';
                        document2 = MongoDB.Bson.Serialization.BsonSerializer.Deserialize<BsonDocument>(str);
                        document1.Add(document2);
                        document2.Clear();
                    }
                    txtDulieu.Clear();
                    //textBox1.Text = document1.ToString();
                    txtTen.Clear();
                    //textBox2.Text = str;
                    collection.InsertOne(document1);
                    MessageBox.Show("Đã lưu thành công");
                    treeView1.Nodes.Clear();
                    load_grid();
                }
                else
                {
                    var db = kn.connosql;
                    var collection = db.GetCollection<BsonDocument>("KHACHHANG");
                    var document = collection.AsQueryable<BsonDocument>().ToList();
                    var filter = Builders<BsonDocument>.Filter.Eq("MaKH", listView1.Items[1].SubItems[1].Text);
                    string[] b = txtTen.Text.Split(':');
                    if (b.Count() == 1)
                    {
                        if (txtTen.Text == "MaPH")
                        {
                    
                            var collection1 = db.GetCollection<BsonDocument>("PHONG");
                            var filter1 = Builders<BsonDocument>.Filter.Eq("MaPH", txtDulieu.Text);
                            var query = collection1.Find(filter1).FirstOrDefault();
                            if (query != null)
                            {
                                var update1 = Builders<BsonDocument>.Update.Set("SoLuong", int.Parse(query[2].ToString()) + 1);
                                collection1.UpdateOne(filter1, update1);
                            }
                        }
                        var update = Builders<BsonDocument>.Update.Set(txtTen.Text.Trim(), txtDulieu.Text.Trim());
                        collection.UpdateOne(filter, update);
                        MessageBox.Show("Ban da update thanh cong", "Thong bao");
                        listView1.Items.Clear();
                        txtDulieu.Clear();
                        txtTen.Clear();
                    }
                    else
                    {

                        string[] a = txtTen.Text.Split(':');
                        var update = Builders<BsonDocument>.Update.Set(a[0].Trim() + '.' + a[1].Trim(), txtDulieu.Text.Trim());

                        collection.UpdateOne(filter, update);
                        MessageBox.Show("Ban da update thanh cong", "Thong bao");
                        txtDulieu.Clear();
                        txtTen.Clear();
                        listView1.Items.Clear();
                        //textBox1.Text = a[1].Trim();
                        //textBox2.Text = a[0].Trim();
                    }
                    load_grid();


                }
            }
            catch
            {
                MessageBox.Show("Thao tac khong thanh cong", "Thong bao");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r;
                r = MessageBox.Show("Bạn thật sự muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (r == DialogResult.OK)
                {
                    if (txtTen.Text == "_id")
                    {
                        for (int i = 0; i < listView1.Items.Count; i++)
                        {
                            if (listView1.Items[i].SubItems[0].Text == "MaPH")
                            {
                                var db1 = kn.connosql;
                                var collection1 = db1.GetCollection<BsonDocument>("PHONG");
                                var filter1 = Builders<BsonDocument>.Filter.Eq("MaPH", listView1.Items[i].SubItems[1].Text);
                                var query = collection1.Find(filter1).FirstOrDefault();
                                if (query != null)
                                {
                                    var update = Builders<BsonDocument>.Update.Set("SoLuong", int.Parse(query[2].ToString()) - 1);
                                    collection1.UpdateOne(filter1, update);
                                }
                            }
                        }
                    }

                    var db = kn.connosql;
                    var collection = db.GetCollection<BsonDocument>("KHACHHANG");
                    var document = collection.AsQueryable<BsonDocument>().ToList();
                    var filter = Builders<BsonDocument>.Filter.Eq(txtTen.Text, ObjectId.Parse(txtDulieu.Text));
                    collection.DeleteOne(filter);
                    load_grid();
                    listView1.Items.Clear();
                    txtDulieu.Clear();
                    txtTen.Clear();
                }
            }
            catch {
                MessageBox.Show("Hãy chọn _id để xóa dữ liệu");
            }
        }
    
    }
}
