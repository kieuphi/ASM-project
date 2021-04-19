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
    public class BookingStatusDAL
    {
        ConnectSQL db = new ConnectSQL();
        public DataTable Get_ListBookingStatus(string DieuKien)
        {
            return db.GetData("Select StsCode,Description from APM_BookingStatus");
        }
    }
}
