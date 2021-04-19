using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BUS;
using VOBJ;



namespace BUS
{  
    public class CompanyBUS
    {
       CompanyBUS com = new CompanyBUS();

        public DataTable GetList_Company(string DieuKien)
        {
            return com.GetList_Company(DieuKien);
        }

    }
}
