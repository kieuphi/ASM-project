using DataConnector;
using System;

namespace VOBJ
{
    [TableName("Sale_ServicePosted")]
    [PrimaryKey("Index", AutoIncrement = true)]
    public class ServicePosted
    {
        public long Index { get; set; }
        public double ContractNum { get; set; }
        public string SCode { get; set; }
        public string SName { get; set; }
        public string SGroup { get; set; }
        public double Qty { get; set; }
        public bool DiscountFlag { get; set; }
        public bool DiscountType { get; set; }
        public double DiscountValue { get; set; }
        public double DiscountAmount { get; set; }
        public double SubAmount { get; set; }
        public double VAT { get; set; }
        public double Sptax { get; set; }
        public double SrcAmount { get; set; }
        public double TotalAmount { get; set; }
        public string BillNo { get; set; }
        public DateTime PostedTime { get; set; }
        public string PostedUSID { get; set; }
        public string Comment { get; set; }
        public bool FOC { get; set; }

        public long FOCNo { get; set; }
        public string ApartmentID { get; set; }
        public DateTime TrnDate { get; set; }
    }
}