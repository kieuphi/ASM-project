using DataConnector;
using System;

namespace DAL.Model
{
    [TableName("APM_Room")]
    public class Room
    {
        public string Roomcode { get; set; }
        public string RoomName { get; set; }
        public int NumConnectedRoom { get; set; }
        public int DisplayOrder { get; set; }
        public string RoomTypeCode { get; set; }
        public int Floor { get; set; }
        public string RoomComment { get; set; }
        public string BuildingCode { get; set; }
        public int NumBed { get; set; }

        public int HKStation { get; set; }

        public int HKAssigned { get; set; }
        public int HKInHouse { get; set; }
        public int HKPickup { get; set; }
        public int HKCO { get; set; }
        public bool HKOccupied { get; set; }
        public bool HKClean { get; set; }
        public bool SYSOccupied { get; set; }
        public bool Checked { get; set; }
        public bool LateCheckOutFlag { get; set; }
        public DateTime StayOverFlag { get; set; }
        public string LastChangeClerkID { get; set; }
        public DateTime LastChangeTime { get; set; }
        public int AreaMap { get; set; }

        public int RStatus { get; set; }
        public string ApartmentID { get; set; }
    }
}