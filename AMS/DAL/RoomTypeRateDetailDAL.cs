using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using VOBJ;
using DAL.Common;

namespace DAL
{
  public  class RoomTypeRateDetailDAL
    {
        ConnectSQL db = new ConnectSQL();
        public DataTable GetList_Company(string DieuKien)
        {
            return db.GetData("Select RateCode, CompanyName from Sale_RoomTypeRateDetail");
        }
    }
}
