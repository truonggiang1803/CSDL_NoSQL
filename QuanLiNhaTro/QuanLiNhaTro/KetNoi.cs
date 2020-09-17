using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core;
namespace QuanLiNhaTro
{
    class KetNoi
    {

        private SqlConnection _connsql;
        private IMongoDatabase db;
        public SqlConnection connsql
        {
            get { return _connsql; }
            set { _connsql = value; }
        }
        public IMongoDatabase connosql
        {
            get { return db; }
            set { db = value; }
        }
        public KetNoi()
        {
            
            MongoClient client = new MongoClient("mongodb://localhost:27017");
            db = client.GetDatabase("QLNHATRO");
        }

    }
}
