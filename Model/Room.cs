using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagementSystem.Model
{
    public class Room
    {
        public int RoomID { get; set; }
        public int RoomNumber { get; set; }
        public int RoomTypeID { get; set; }
        public int Floor { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }

        public RoomType RoomType { get; set; }

    }
}
