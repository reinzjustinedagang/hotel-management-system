using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagementSystem.Model
{
    public class RoomType
    {
        public int RoomTypeID { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int BasePrice { get; set; }

    }
}
