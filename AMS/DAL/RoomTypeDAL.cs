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
   public class RoomTypeDAL
    {
        ConnectSQL db = new ConnectSQL();
        public DataTable GetList_RoomType(string DieuKien)
        {
            return db.GetData("Select RoomTypeCode, Description from APM_RoomType");
        }
    }
}
