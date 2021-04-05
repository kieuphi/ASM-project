using DataConnector;
using System;

namespace DAL.Model
{
    [TableName("Sale_ContractTrn")]
    public class ContractTrn
    {
        public long Id { get; set; }
        public string SlipNum { get; set; }
        public string RoomCode { get; set; }
        public string PageCode { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionCode { get; set; }
        public int TransactionSubCode { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double TransactionAmount { get; set; }
        public string OriginSlipNumber { get; set; }
        public double SubAmount { get; set; }
        public double ServiceCharge { get; set; }
        public double TaxAmount { get; set; }
        public double Discount { get; set; }
        public double STaxAmount { get; set; }
        public string PostingUSID { get; set; }
        public string TrnNumber { get; set; }
        public int MealPeriodCode { get; set; }
        public string Comment { get; set; }
        public string CurrencyCode { get; set; }
        public string TaxCode { get; set; }
        public string SrcCode { get; set; }
        public string OriginCurrency { get; set; }
        public double OriginAmount { get; set; }
        public bool VoidTransactionFlag { get; set; }
        public string LastChangeUSID { get; set; }
        public DateTime LastChangeTime { get; set; }
        public DateTime SystemTime { get; set; }
        public string OriginRoom { get; set; }
        public bool ARTransferredFlag { get; set; }
        public bool Printed { get; set; }
        public long RptExRate { get; set; }
        public double BillExRate { get; set; }
        public double BillAmount { get; set; }
        public double BillID { get; set; }
        public bool PostToACC { get; set; }
        public string StsCode1 { get; set; }
        public string StsCode2 { get; set; }
        public string StsCode3 { get; set; }
        public string StsCode4 { get; set; }
        public string StsCode5 { get; set; }
        public string StsCode6 { get; set; }
        public string StsCode7 { get; set; }
        public string StsCode8 { get; set; }
        public string STaxCode { get; set; }
        public DateTime InvoiceDate { get; set; }
        public long GuestID { get; set; }
        public long OrgGuestID { get; set; }
        public string ErrCheck { get; set; }
        public string ApartmentID { get; set; }
    }
}