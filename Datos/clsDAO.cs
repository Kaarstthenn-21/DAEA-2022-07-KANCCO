using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Datos
{
    
    public class clsDAO
    {
        public SqlConnection con;
        public clsDAO()
        {
            string str = "Server=DESKTOP-7TI187F;DataBase=School;Integrated Security=true";
            con = new SqlConnection(str);
        }
    }
}
