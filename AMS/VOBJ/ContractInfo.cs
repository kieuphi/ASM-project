using DataConnector;
using System;

namespace VOBJ

{
    [TableName("Sale_ContractInfo")]
    [PrimaryKey("Index", AutoIncrement = true)]
    public class ContractInfo
    {
        public long Index { get; set; }
        public int ContractNum { get; set; }
        public string ContractCode { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public string RoomTypeCode { get; set; }
        public string RoomCode { get; set; }
        public string CompanyName { get; set; }
        public int NumAdult { get; set; }
        public int NumChild { get; set; }

        public DateTime ArrivalTime { get; set; }

        public DateTime DepartureTime { get; set; }

        public string MarketSegmentCode { get; set; }

        public string MarketBusinessCode { get; set; }
        public string MarketChannelCode { get; set; }
        public string ContactName { get; set; }

        public string Notice { get; set; }

        public bool RoomTaxPostedFlag { get; set; }

        public bool NoShowFlag { get; set; }

        public bool SysExtendedStayOverFlag { get; set; }
        public bool DelayCheckOutFlag { get; set; }
        public DateTime ReservationTime { get; set; }
        public string ReservationUSID { get; set; }

        public DateTime CancelTime { get; set; }

        public string CancelUSID { get; set; }
        public DateTime CheckInTime { get; set; }
        public string CheckInUSID { get; set; }
        public DateTime CheckOutTime { get; set; }
        public string CheckOutUSID { get; set; }
        public string LastChangeUSID { get; set; }
        public DateTime LastChangeTime { get; set; }
        public string StsCode1 { get; set; }
        public string StsCode2 { get; set; }
        public string StsCode3 { get; set; }
        public string StsCode4 { get; set; }
        public string StsCode5 { get; set; }
        public string StsCode6 { get; set; }
        public string StsCode7 { get; set; }
        public string StsCode8 { get; set; }
        public string RoomRateCode { get; set; }
        public string PaymentCode { get; set; }

        public string CreditCode { get; set; }

        public string CreditCardNum { get; set; }
        public string CreditCardExpireTime { get; set; }
        public double RateAmount { get; set; }//[numeric](19, 2)

        public bool ConfidentialFlag { get; set; }

        public bool NoPostFlag { get; set; }
        public string CreditCardTypeCode { get; set; }

        public string Booker { get; set; }

        public string BookByCode { get; set; }
        public int BookStatus { get; set; } //tinyint
        public bool NetRate { get; set; }
        public bool IncludeBF { get; set; }
        public string CancelReason { get; set; }
        public string BreakfastCode { get; set; }

        public bool RoomChargeToMasterFlag { get; set; }

        public int NumGuestBF { get; set; }

        public string LastName { get; set; }
        public string FirstName { get; set; }

        public double ProfileNumber { get; set; } //[numeric] (18, 2)

        public string CreditLimit { get; set; }
        public bool BlockFlag { get; set; }
        public string BlockUSID { get; set; }
        public string RoomTypeBooked { get; set; }
        public DateTime TraceDate { get; set; }
        public double CancelCharge { get; set; } //[numeric] (18, 2)
        public string UserInfo1 { get; set; }
        public string UserInfo2 { get; set; }
        public string UserInfo3 { get; set; }
        public string UserInfo4 { get; set; }
        public double DscPcnt { get; set; } //[numeric] (18, 2)
        public double DscAmount { get; set; } //[numeric] (18, 2)
        public string TraceNote { get; set; }

        public int ChargeNights { get; set; }

        public string ApartmentID { get; set; }
    }
}