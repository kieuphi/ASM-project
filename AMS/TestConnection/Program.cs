using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace TestConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=localhost;Uid=root;Pwd=123456;Database=new_data";
            DataHelepr dataHelepr = new DataHelepr(connectionString,"Mysql");
            dataHelepr.Run();
        }
    }
}
