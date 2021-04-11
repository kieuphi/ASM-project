using DataConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VOBJ
{
    [TableName("GlobalParameter")]
    public class GlobalParameter
    {
        public string ParaName { get; set; }
        public string Paravalue { get; set; }
        public string ApartmentID { get; set; }
    }
}