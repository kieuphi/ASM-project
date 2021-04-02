using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VOBJ
{
    public class Room_OBJ
    {
        public Room_OBJ(string roomcode, string roomname, string floor)
        {
            this.RoomCode = roomcode;
            this.RoomName = roomname;
            this.Floor = floor;
        }

        public Room_OBJ(DataRow row)
        {
            this.RoomCode = row["RoomCode"].ToString();
            this.RoomName = row["RoomName"].ToString();
            this.Floor = row["Floor"].ToString();

        }


        private string roomcode;
        public string RoomCode
        {
            get { return roomcode; }
            set { roomcode = value; }
        }
        private string roomname;
        public string RoomName
        {
            get { return roomname; }
            set { roomname = value; }
        }

        private string floor;
        public string Floor
        {
            get { return floor; }
            set { floor = value; }
        }
    }
}
