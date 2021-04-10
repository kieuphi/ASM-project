using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace TestConnection
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //string connectionString = "Server=localhost;Uid=root;Pwd=123456;Database=new_data";
            //DataHelepr dataHelepr = new DataHelepr(connectionString,"Mysql");
            string connectionString = "Server=localhost;Uid=sa;Pwd=123;Database=Apartment_Solutions";
            DataHelepr dataHelepr = new DataHelepr(connectionString, "SqlServer");
            dataHelepr.Run();
        }
    }
}