using DataConnector;
using System.Collections.Generic;
using VOBJ;

namespace DAL.Common
{
    public class DataHelpers
    {
        public static string ConnectionString = "Server=localhost;Uid=sa;Pwd=123;Database=Apartment_Solutions";
        public Database Database;

        public DataHelpers()
        {
            Database = new Database(ConnectionString, "SqlServer");
        }

        public List<ServiceGroup> GetAllServiceGroup()
        {
            Sql sql = Sql.Builder.From("Sale_ServiceGroup");
            return Database.Fetch<ServiceGroup>(sql);
        }

        public ContractInfo GetConTractInfoByContractNum(double contractNum)
        {
            Sql sql = Sql.Builder.From("Sale_ContractInfo").Where(nameof(ContractInfo.ContractNum) + "=" + contractNum);
            return Database.FirstOrDefault<ContractInfo>(sql);
        }

        public List<ServiceList> GetAllServiceList()
        {
            Sql sql = Sql.Builder.From("Sale_ServiceList");
            return Database.Fetch<ServiceList>(sql);
        }
    }
}