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
   public class SaleLocationBUS
    {

        SaleLocationBUS sale = new SaleLocationBUS();

        public DataTable GetList_SaleLocation(string DieuKien)
        {
            return sale.GetList_SaleLocation(DieuKien);
        }
    }
}

