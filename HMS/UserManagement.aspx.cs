using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace HMS
{
    public partial class UserManagement : System.Web.UI.Page
    {
        LoginClass objbll = new LoginClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = objbll.DB_Login(TextBox1.Text, TextBox2.Text);
            if (str == "1")
            {
                Response.Redirect("Patientdetails.aspx");
            }
            else
            {
                Response.Write("<script>alert('Invalid Username or Password!!!!')</script>");
            }
        }
    }
}