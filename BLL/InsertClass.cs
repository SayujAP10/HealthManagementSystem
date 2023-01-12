using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class InsertClass
    {
        ConnectionClass objdal = new ConnectionClass();
        public int DB_Insert(string na,int ag,string sex,string add,string mail)
        {
            string str = "insert into Table1 values('" + na + "'," + ag + ",'" + sex + "','" + add + "','" + mail + "')";
            int i = objdal.Fn_ExecuteNonQuery(str);
            return i;
        }
    }
}
