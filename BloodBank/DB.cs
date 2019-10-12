using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank
{
    public static class DB
    {
        public static SqlConnection getinstance()
        {
            String _conString = @"Data Source=(LocalDB)\v11.0;Initial Catalog=project; Integrated Security=True";
            SqlConnection conn = new SqlConnection(_conString);

            return conn;
        }
    }
}
