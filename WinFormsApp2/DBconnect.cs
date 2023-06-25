using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace PDS2CS12
{
    internal class DBconnect
    {
        private static string strCon = "server=LAPTOP-81NRM4HS\\SQLEXPRESS;Initial Catalog=db2cs2;Integrated Security=true";
        public SqlConnection cn = new SqlConnection(strCon);
        public SqlCommand cmd = new SqlCommand();
        public SqlDataAdapter da = new SqlDataAdapter();
        public DataTable dt = new DataTable();

        public void getData(string sql)
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            da = new SqlDataAdapter(sql, cn);
            dt = new DataTable();
            da.Fill(dt);
        }
        public void exeCuteData(string sql)
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            cmd.Parameters.Clear();
            cmd = new SqlCommand(sql, cn);
            cmd.ExecuteNonQuery();
        }
    }
}
  

