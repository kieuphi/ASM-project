using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VOBJ
{
   public class RoomTypeRateDetailOBJcs
    {
        public int Index  { get; set; }
        public string RateCode { get; set; }
        public string RoomTypeCode { get; set; }
        public string Description { get; set; }
        public string RateTypeCode { get; set; }
        public int RateValue { get; set; }
        public int Rate2Value { get; set; }
        public int Rate3Value { get; set; }
        public string LastChangeUSID { get; set; }
        public DateTime LastChangeTime { get; set; }
        public Boolean isActive { get; set; }

    }
}
