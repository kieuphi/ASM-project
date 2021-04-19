using DataConnector;

namespace VOBJ
{
    [TableName("Sale_ServiceList")]
    [PrimaryKey("Index", AutoIncrement = true)]
    public class ServiceList
    {
        public long Index { get; set; }
        public string SCode { get; set; }
        public string SName { get; set; }
        public string SGroup { get; set; }
        public double Price { get; set; }
        public string IUnit { get; set; }
        public bool OpenPrice { get; set; }
        public string ApartmentID { get; set; }
        public int InActive { get; set; }
    }
}