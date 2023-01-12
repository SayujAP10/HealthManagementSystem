using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class LoginClass
    {
        ConnectionClass objdal = new ConnectionClass();

        public string DB_Login(string una, string pswd)
        {
            string str = "select count(id) from login where username='" + una + "' and password='" + pswd + "'";
            string cid = objdal.Fn_ExScalar(str);
            return cid;
        }
    }
}
