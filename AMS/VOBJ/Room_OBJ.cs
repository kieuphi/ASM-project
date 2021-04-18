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
        public Room_OBJ(int roomcode, string roomname, string floor, string rowx, string coly, string rstatus)
        {
            this.RoomCode = roomcode;
            this.RoomName = roomname;
            this.Floor = floor;
            this.RowX = rowx;
            this.ColY = coly;
            this.RStatus = rstatus;
        }

        public Room_OBJ(DataRow row)
        {
            this.RoomCode = Convert.ToInt32(row["RoomCode"]);
            this.RoomName = row["RoomName"].ToString();
            this.Floor = row["Floor"].ToString();
            this.RowX = row["RowX"].ToString();
            this.ColY = row["ColY"].ToString();
            this.RStatus = row["RStatus"].ToString();

        }


        private int roomcode;
        public int RoomCode
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
        private string rowX;
        public string RowX
        {
            get { return rowX; }
            set { rowX = value; }
        }

        private string colY;
        public string ColY
        {
            get { return colY; }
            set { colY = value; }
        }
        private string rstatuS;
        public string RStatus
        {
            get { return rstatuS; }
            set { rstatuS = value; }
        }
    }
}
