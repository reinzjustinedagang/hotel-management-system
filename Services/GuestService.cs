using HotelManagementSystem.Model;
using HotelManagementSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace HotelManagementSystem.Services
{
    public class GuestService
    {
        private readonly GuestRepository repo = new();

        public async Task<List<Guest>> GetGuests()
        {
            return await repo.GetGuests();
        }

        public Guest? GetGuest(int id)
        {
            if (id <= 0) return null;

            return repo.GetGuest(id);
        }

        public string AddGuest(Guest guest)
        {
            if (string.IsNullOrWhiteSpace(guest.FirstName) ||
                string.IsNullOrWhiteSpace(guest.LastName) ||
                string.IsNullOrWhiteSpace(guest.Email) ||
                string.IsNullOrWhiteSpace(guest.Phone) ||
                string.IsNullOrWhiteSpace(guest.Address) ||
                string.IsNullOrWhiteSpace(guest.Nationality))
            {
                return "Please fill up all fields";
            }

            bool success = repo.AddGuest(guest);

            return success
                ? "Guest added successfully"
                : "Failed to add guest";
        }

        public string UpdateGuest(Guest guest)
        {
            if (string.IsNullOrWhiteSpace(guest.FirstName))
                return "First name is required.";

            bool success = repo.UpdateGuest(guest);

            return success
                ? "Guest updated successfully."
                : "Guest not found.";
        }

        public string DeleteGuest(int id)
        {
            if (id <= 0) 
                return "Invalid id";

            bool success = repo.DeleteGuest(id);

            return success
                ? "Guest deleted successfully."
                : "Guest not found.";
        }

        public List<Guest> SearchGuest(string keyword)
        {
            return repo.SearchGuest(keyword);
        }

        public int GetTotalGuestCount(string keyword)
        {
            return repo.GetTotalGuestCount(keyword);
        }

        public List<Guest> PaginatedGuest(int pageNumber, int pageSize, string keyword)
        {
            return repo.PaginatedGuest(pageNumber, pageSize, keyword);

        }

        public async Task<int> CreateAsync(Guest guest)
        {
            return await repo.CreateAsync(guest);
        }
    }
}
