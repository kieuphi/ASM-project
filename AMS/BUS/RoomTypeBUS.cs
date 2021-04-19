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
  public  class RoomTypeBUS
    {
        RoomTypeBUS Rmtype = new RoomTypeBUS();
        public DataTable GetList_RmType(string DieuKien)
        {
            return Rmtype.GetList_RmType(DieuKien);
        }


    }
}
