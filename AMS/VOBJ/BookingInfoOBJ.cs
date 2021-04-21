using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VOBJ
{
   public class BookingInfoOBJ
    {
        public BookingInfoOBJ(int contractnum, string contractcode, string roomcode, string bbkstatus, string arrival, string depature, string lastname)
        {
            this.ContractNum = contractnum;
            this.ContractCode = contractcode;
            this.RoomCode = roomcode;
            this.BookStatus = bbkstatus;
            this.ArrivalDate = arrival;
            this.DepartureDate = depature;
            this.LastName = lastname;
        }
        public BookingInfoOBJ(DataRow row)
        {
            this.ContractNum = Convert.ToInt32(row["ContractNum"]);
            this.ContractCode = row["ContractCode"].ToString();
            this.RoomCode = row["RoomCode"].ToString();
            this.BookStatus = row["BookStatus"].ToString();
            this.ArrivalDate = row["ArrivalDate"].ToString();
            this.DepartureDate = row["DepartureDate"].ToString();
            this.LastName = row["LastName"].ToString();

        }
        public int Index { get; set; }

        private int contractnum;
        public int ContractNum
        {
            get { return contractnum; }
            set { contractnum = value; }
        }

        private string contractcode;
        public string ContractCode
        {
            get { return contractcode; }
            set { contractcode = value; }
        }
        public string lastname { get; set; }
        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string FirstName { get; set; }
        public string TitleCode { get; set; }
        public string TelNum { get; set; }
        public string FaxNum { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
        public int Nationality { get; set; }
        public string arrivaldate { get; set; }
        public string ArrivalDate
        {
            get { return arrivaldate; }
            set { arrivaldate = value; }
        }
        public string ArrivalTime { get; set; }
        public string departuredate { get; set; }
        public string DepartureDate
        {
            get { return departuredate; }
            set { departuredate = value; }
        }
        public DateTime DepartureTime { get; set; }
        public string RoomTypeCode { get; set; }
        public string RoomCode { get; set; }
        public int NumAdult { get; set; }
        public int NumChild { get; set; }
        public string CompanyName { get; set; }
        public string MarketSegmentCode { get; set; }
        public string MarketBusinessCode { get; set; }
        public string MarketChannelCode { get; set; }
        public string ContactName { get; set; }
        public string RoomRateCode { get; set; }
        public decimal RateAmount { get; set; }
        public decimal RateManual { get; set; }
        public string DscType { get; set; }
        public string DscPer { get; set; }
        public string DscAmount { get; set; }
        public string PaymentCode { get; set; }
        public string BreakfastCode { get; set; }
        public int AdtBF { get; set; }
        public int ChilBF { get; set; }
        public string CurrencyCode { get; set; }
        public string ExtraBedNum { get; set; }
        public int NumGuestBF { get; set; }
        public bool BlockFlag { get; set; }      
        public string Notice { get; set; }
        public bool RoomTaxPostedFlag { get; set; }
        public bool NoShowFlag { get; set; }
        public bool SysExtendedStayOverFlag { get; set; }
        public bool DelayCheckOutFlag { get; set; }
        public DateTime ReservationTime { get; set; }
        public DateTime  CheckInTime { get; set; }
        public DateTime CheckOutTime { get; set; }
        public string ReservationUSID { get; set; }
        public string CancelerName { get; set; }
        public DateTime CancelTime { get; set; }
        public string CancelUSID { get; set; }
        public string CheckInUSID { get; set; }
        public string CheckOutUSID { get; set; }
        public string LastChangeUSID { get; set; }
        public string LastChangeTime { get; set; }
        public DateTime StsCode1 { get; set; }
        public string StsCode2 { get; set; }
        public string StsCode3 { get; set; }
        public string StsCode4 { get; set; }
        public string StsCode5 { get; set; }
        public string StsCode6 { get; set; }
        public string StsCode7 { get; set; }
        public string StsCode8 { get; set; }
        public string CreditCode { get; set; }
        public string CreditCardNum { get; set; }
        public string CreditCardExpireTime { get; set; }
        public string ConfidentialFlag { get; set; }
        public string NoPostFlag { get; set; }
        public string CreditCardTypeCode { get; set; }
        public string BookByCode { get; set; }
        public string CancelReason { get; set; }
        public string RoomChargeToMasterFlag { get; set; }
        public decimal ExRate { get; set; }
        public string ProfileNumber { get; set; }
        public DateTime TraceDate { get; set; }
        public string TraceNote { get; set; }
        public string ContractStatus { get; set; }
        public bool DayUse { get; set; }
        public bool OwnerFlag { get; set; }
        public bool InternalFlag { get; set; }
        public bool PartnerFlag { get; set; }
        public string bookstatus { get; set; }
        public string BookStatus
        {
            get { return bookstatus; }
            set { bookstatus = value; }
        }
        public bool NetRate { get; set; }
        public bool IncludeBF { get; set; }
        public bool CancelFlag { get; set; }
        public string ApartmentID { get; set; }



    }



}
