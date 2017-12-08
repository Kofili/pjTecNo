using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;

namespace TPvorbereitung
{


    class DataConnection
    {
        private string Db
        {
            get
            {
                string s = "Database";
                return s;
            }
        }
        private string Server
        {
            get
            {
                string s = "Server";
                return s;
            }
        }
        private string Uid
        {
            get
            {
                string s = "User";
                return s;
            }
        }
        private string Pw
        {
            get
            {
                string s = "Pwd";
                return s;
            }
        }

        private void connect()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = String.Format("Server ={0};Database={1}; User ID={2}; Pw={3}", Server, Db, Uid, Pw);
                conn.Open();
            }
        }
        public List<object> select( string clm, string tbl, string w)
        {
            List<object> list = new List<object>();
            SqlCommand cmd = new SqlCommand("");
            cmd.Parameters.Add(new SqlParameter("clm", clm));
            cmd.Parameters.Add(new SqlParameter("tbl", tbl));
            cmd.Parameters.Add(new SqlParameter("w", w));
            return list;
        }
    }

}
