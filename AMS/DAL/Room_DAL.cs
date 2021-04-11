using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Common;
using VOBJ;

namespace DAL
{
    public class Room_DAL
    {
        private static Room_DAL instance;

        public static Room_DAL Instance
        {
            get { if (instance == null) instance = new Room_DAL(); return Room_DAL.instance; }
            private set { Room_DAL.instance = value; }
        }

        public static int PTNWith = 90;
        public static int PTNHeight = 90;


        ConnectSQL db = new ConnectSQL();
        private Room_DAL() { }

        public List<Room_OBJ> LoadPTNlist(string id)
        {
            List<Room_OBJ> ptnlist = new List<Room_OBJ>();

            DataTable data = db.GetData("select RoomCode,RoomName,Floor from APM_Room where Roomcode not like N'%Sys%'" + id);

            foreach (DataRow item in data.Rows)
            {
                Room_OBJ roommap = new Room_OBJ(item);
                ptnlist.Add(roommap);
            }

            return ptnlist;

        }
    }
}
