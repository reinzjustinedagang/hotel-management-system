using HotelManagementSystem.Model;
using HotelManagementSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagementSystem.Services
{
    public class RoomService
    {
        private readonly RoomRepository repo = new();

        public async Task<List<Room>> PaginatedRoomAsync(int pageNumber, int pageSize, string keyword)
        {
            return await repo.PaginatedRoomAsync(pageNumber, pageSize, keyword);
        }

        public async Task<int> RoomsCountAsync(string keyword)
        {
            return await repo.RoomsCountAsync(keyword);
        }

        public async Task<List<Room>> GetRoomsAsync()
        {
            return await repo.GetRoomsAsync();
        }

        public async Task<Room?> GetRoomAsync(int id)
        {
            if (id <= 0) return null;

            return await repo.GetRoomAsync(id);
        }

        public async Task<string> AddRoomAsync(Room room)
        {
            if (room.RoomNumber <= 0)
                return "Room number is required";
            if (room.Floor <= 0)
                return "Floor is required";
            if (string.IsNullOrWhiteSpace(room.Description))
                return "Description is required";
            if (string.IsNullOrWhiteSpace(room.Status))
                return "Status is required";

            bool success = await repo.AddRoomAsync(room);

            if (success)
                return "Success: Room added successfully";
            else
                return "Error: Failed to add room. Please try again";
        }

        public async Task<string> UpdateRoomAsync(Room room)
        {
            if (room.RoomNumber <= 0)
                return "Room number is required";
            if (room.Floor <= 0)
                return "Floor is required";
            if (string.IsNullOrWhiteSpace(room.Description))
                return "Description is required";
            if (string.IsNullOrWhiteSpace(room.Status))
                return "Status is required";

            bool success = await repo.UpdateRoomAsync(room);

            if (success)
                return "Success: Room updated successfully";
            else
                return "Error: Failed to update room. Please try again";
        }

        public async Task<string> DeleteRoomAsync(int id)
        {

            bool success = await repo.DeleteRoomAsync(id);

            if (success)
                return "Success: Room deleted successfully";
            else
                return "Error: Failed to delete room. Please try again";
        }

        public async Task<List<Room>?> GetRoomsByTypeAsync(int roomTypeID)
        {
            if (roomTypeID <= 0) return null;

            return await repo.GetRoomsByTypeAsync(roomTypeID);
        }
    }
}
