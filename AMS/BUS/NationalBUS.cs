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
  public  class NationalBUS
    {
        NationalBUS Na = new NationalBUS();
        public DataTable GetList_National(string DieuKien)
        {
            return Na.GetList_National(DieuKien);
        }
    }
}
