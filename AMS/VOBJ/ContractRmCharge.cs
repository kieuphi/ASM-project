using DataConnector;
using System;

namespace VOBJ
{
    [TableName("Sale_ContractRmCharge")]
    public class ContractRmCharge
    {
        public long Id { get; set; }
        public DateTime ApmDate { get; set; }
        public double ContractNum { get; set; }
        public string RoomCode { get; set; }
        public bool IsPkg { get; set; }
        public double Amount { get; set; }
        public string PostBy { get; set; }
        public DateTime PostTime { get; set; }
        public string ApartmentID { get; set; }
    }
}