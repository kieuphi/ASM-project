using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using VOBJ;
using BUS;

namespace BUS
{
    public class MarketSegmentBUS
    {
        MarketSegmentBUS masg = new MarketSegmentBUS();

        public DataTable GetList_MarketSG(string DieuKien)
        {
            return masg.GetList_MarketSG(DieuKien);
        }
    }
}