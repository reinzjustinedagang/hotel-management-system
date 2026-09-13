using HotelManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagementSystem.Interface
{
    public interface IGuestRepo
    {
        Task<List<Guest>> GetGuests();
        Guest GetGuest(int id);
        bool AddGuest(Guest guest);
    }
}
