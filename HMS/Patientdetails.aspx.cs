using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using System.Data.SqlClient;

namespace HMS
{
    public partial class Patientdetails : System.Web.UI.Page
    {

       SqlConnection con = new SqlConnection(@"server=DESKTOP-L00HMUS\SQLEXPRESS;database=HMS;Integrated Security=true");
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Bind_Grid();
            }

        }
        public void Bind_Grid()
        {
            string str = "select * from Table1";
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int i = e.RowIndex;
            int id = Convert.ToInt32(GridView1.DataKeys[i].Value);
            string strdel = "delete from Table1 where id=" + id + "";
            SqlCommand cmd = new SqlCommand(strdel, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Bind_Grid();
        }
    }
}