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
            var a = Sql.Builder.From("GlobalParameter");
            try
            {
                var asd = database.Fetch<GlobalParameter>(a);
                GlobalParameter b = new GlobalParameter();
                b.ID = 2;
                b.ApartmentID = "sda";
                b.ParaName = "adsd";
                database.Insert("GlobalParameter", "ID", b);
            }
            catch(Exception ex)
            {
                
            }
        }
    }
}