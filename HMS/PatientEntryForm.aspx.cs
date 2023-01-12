using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace HMS
{
    public partial class PatientEntryForm : System.Web.UI.Page
    {
        InsertClass objbll = new InsertClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int i = objbll.DB_Insert(TextBox1.Text, Convert.ToInt32(TextBox2.Text), RadioButtonList1.SelectedItem.Text, TextBox3.Text, TextBox4.Text);
            if (i != 0)
            {
                Response.Write("<script>alert('Successfully Inserted!!!!')</script>");
            }
            else
            {
                Response.Write("<script>alert('Not Inserted!!!!')</script>");
            }
        }
    }
}