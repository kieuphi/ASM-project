using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL.Common;
using VOBJ;

namespace DAL
{
  public  class BookSourceDAL
    {
        ConnectSQL db = new ConnectSQL();
        public DataTable GetList_BookSource(string DieuKien)
        {
            return db.GetData("Select Code, Description from APM_BookSource");
        }
    }
}
