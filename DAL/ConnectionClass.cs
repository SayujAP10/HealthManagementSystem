using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ConnectionClass
    {
        SqlConnection con;
        public ConnectionClass()
        {
            con = new SqlConnection(@"server=DESKTOP-L00HMUS\SQLEXPRESS;database=HMS;Integrated Security=true");
        }
        public int Fn_ExecuteNonQuery(string sqlquery)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            SqlCommand cmd = new SqlCommand(sqlquery, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

        public string Fn_ExScalar(string sqlquery)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            SqlCommand cmd = new SqlCommand(sqlquery, con);
            con.Open();
            string str = cmd.ExecuteScalar().ToString();
            con.Close();
            return str;
        }

       


    }
}
