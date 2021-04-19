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
  public  class MarketChanelBUS
    {
        MarketChanelBUS macn = new MarketChanelBUS();

        public DataTable GetList_MarketSG(string DieuKien)
        {
            return macn.GetList_MarketSG(DieuKien);
        }
    }
}
