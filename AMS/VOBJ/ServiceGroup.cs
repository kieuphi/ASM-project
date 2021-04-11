using DataConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VOBJ
{
    [TableName("Sale_ServiceGroup")]
    public class ServiceGroup
    {
        public string GroupCode { get; set; }
        public string GroupName { get; set; }
        public bool IsPriceNet { get; set; }
        public string ApartmentID { get; set; }
    }
}