using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLTPKS.DTO
{
    class connect
    {
        public connect() { }
        public SqlConnection conn;
        public SqlCommand cmd;

        string strketnoi1 = "Data Source=TRAN-CHAN;Initial Catalog=QL_TPKS;User ID=sa;Password=123";
        public SqlConnection ketnoiCN1 = new SqlConnection("Data Source=TRAN-CHAN\\CHINHANH1;Initial Catalog=QL_TPKS;User ID=sa;Password=123");
        public SqlConnection ketnoiCN2 = new SqlConnection("Data Source=TRAN-CHAN\\CHINHANH2;Initial Catalog=QL_TPKS;User ID=sa;Password=123");
        public SqlConnection ketnoiCN = new SqlConnection("Data Source=TRAN-CHAN;Initial Catalog=QL_TPKS;User ID=sa;Password=123");

        public void Openconnect()
        {
            
            string ketnoi1 = strketnoi1;
            
            conn = new SqlConnection(strketnoi1);
            conn.Open();
        }
        public void Closeconnect()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
        public void query1(string query)
        {
            Openconnect();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            Closeconnect();
        }
        //public void query(string query, SqlParameter[] p)
        //{
        //    Openconnect();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = conn;
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.CommandText = query;
        //    foreach (SqlParameter p1 in p)
        //    {
        //        cmd.Parameters.Add(p1);
        //    }
        //    cmd.ExecuteNonQuery();
        //    Closeconnect();
        //}
        public DataTable returnquery(string query)
        {
            Openconnect();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable tb = new DataTable();
            da.Fill(tb);
            Closeconnect();
            return tb;
        }
       
        //public DataTable ReturnStored(SqlCommand cm, string storedname)
        //{
        //    Openconnect();
        //    cm.Connection = conn;
        //    cm.CommandType = CommandType.StoredProcedure;
        //    cm.CommandText = storedname;
        //    SqlDataAdapter da = new SqlDataAdapter(cm);
        //    DataTable table = new DataTable();
        //    da.Fill(table);
        //    Closeconnect();
        //    return table;
        //}
        public DataTable taobang(string sql)
        {
            Openconnect();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
            Closeconnect();
            return dt;
        }
        public void capnhat1()
        {
            conn = new SqlConnection(strketnoi1);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = System.String.Concat("exec sp_startmergepushsubscription_agent 'QLTPKS_CN1','TRAN-CHAN\\CHINHANH1','QL_TPKS'");
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
        }
        public void capnhat2()
        {
            conn = new SqlConnection(strketnoi1);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = System.String.Concat("exec sp_startmergepushsubscription_agent 'QLTPKS_CN2','CHINHANH2','QL_TPKS'");
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
        }

        
    }
}
