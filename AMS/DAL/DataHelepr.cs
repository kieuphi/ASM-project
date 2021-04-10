using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;
using DataConnector;

namespace DAL
{
    public class DataHelepr
    {
        public Database database;

        public DataHelepr(string connection, string providerName)
        {
            database = new Database(connection, providerName);
        }

        public void Run()
        {
            database.OpenSharedConnection();
            var a = Sql.Builder.From("APM_Room");
            var asd = database.Fetch<Room>(a);
        }
    }
}