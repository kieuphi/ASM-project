using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataConnector;

namespace DAL
{
    public class DataHelepr
    {
        public Database database;

        public DataHelepr(Database database)
        {
            this.database = database;
        }
    }
}