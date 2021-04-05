using DataConnector;

namespace DAL.Model
{
    [TableName("Sale_ContractLog")]
    public class ContractLog
    {
        public long SLipsID { get; set; }
        public double SLipsNum { get; set; }
        public int SLipsSubNum { get; set; }
        public string FieldName { get; set; }
        public string FieldType { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public string ChangedClerk { get; set; }
        public string ChangedTime { get; set; }
        public string Notice { get; set; }
        public string ApartmentID { get; set; }
    }
}