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
  public  class RateCodePeriodDAL
    {
        ConnectSQL db = new ConnectSQL();
        public DataTable GetList_RatePriod(string DieuKien)
        {
            return db.GetData("Select RateCode, Description from Sale_RateRoomPeriod");
        }
    }
}
