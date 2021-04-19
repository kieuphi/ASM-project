using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BUS;
using VOBJ;


namespace BUS
{
   public class RateCodePeriodBUS
    {
        RateCodePeriodBUS RatePeriod = new RateCodePeriodBUS();
        public DataTable GetList_RateCodPeriod(string DieuKien)
        {
            return RatePeriod.GetList_RateCodPeriod(DieuKien);
        }

    }
}
