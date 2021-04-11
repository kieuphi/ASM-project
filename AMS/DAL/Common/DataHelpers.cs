using DataConnector;

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
    }
}