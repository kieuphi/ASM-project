using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Common
{
    public class SqlHelper
    {
        SqlConnection cn;
        public SqlHelper(string conectionString)
        {
            cn = new SqlConnection(conectionString);
        }
        public bool IsConnection
        {
            get
            {
                if (cn.State == System.Data.ConnectionState.Closed)
                    cn.Open();
                return true;
        }
        }
    }

}
