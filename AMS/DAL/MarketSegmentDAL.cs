using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Common;
using System.Data;
using VOBJ;

namespace DAL
{
  public  class MarketSegmentDAL
    {
        ConnectSQL db = new ConnectSQL();
        public DataTable GetList_MarketSegment(string DieuKien)
        {
            return db.GetData("Select Code, Description from APM_MarketSegment");
        }
    }
}
