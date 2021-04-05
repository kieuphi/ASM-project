using DataConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    [TableName("APM_RoomOOS")]
    public class RoomOOS
    {
        public string Roomcode { get; set; }
        public DateTime SetTime { get; set; }
        public string SetByUS { get; set; }
        public DateTime ClearTime { get; set; }
        public string ClearByUS { get; set; }
        public int isCleared { get; set; }
        public string HKNotes { get; set; }
        public string ENGNotes { get; set; }
        public string OOSCode { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string ApartmentID { get; set; }
    }
}