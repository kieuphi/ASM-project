using DataConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    [TableName("APM_RoomType")]
    public class APM_RoomType
    {
        public string RoomTypeCode { get; set; }
        public string Description { get; set; }
        public string ClassCode { get; set; }
        public int DisplayOrder { get; set; }

        public int NumRoom { get; set; }
        public string CruiseCode { get; set; }
        public int TrnCode { get; set; }
        public int CruiseCodTrnSubCodee { get; set; }
        public string ApartmentID { get; set; }
    }
}