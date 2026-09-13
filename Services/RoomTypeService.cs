using HotelManagementSystem.Model;
using HotelManagementSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagementSystem.Services
{
    public class RoomTypeService
    {
        private RoomTypeRepository repo = new();

        public async Task<List<RoomType>> GetRoomTypesAsync()
        {
            return await repo.GetRoomTypesAsync();
        }

        public async Task<RoomType?> GetRoomTypeAsync(int id)
        {
            if (id <= 0) return null;

            return await repo.GetRoomTypeAsync(id);
        }

        public async Task<string> AddRoomTypesAsync(RoomType roomType)
        {
            if (string.IsNullOrWhiteSpace(roomType.Name))
                return "Name is required";
            if (roomType.Capacity <= 0)
                return "Capacity should not be 0";
            if (roomType.BasePrice <= 0)
                return "Base Price should not be 0";

            bool success = await repo.AddRoomTypeAsync(roomType);

            if (success)
                return "Success: Room Type added successfully";
            else
                return "Error: Failed to add room type";

        }

        public async Task<string> UpdateRoomTypesAsync(RoomType roomType)
        {
            if (string.IsNullOrWhiteSpace(roomType.Name))
                return "Name is required";
            if (roomType.Capacity <= 0)
                return "Capacity should not be 0";
            if (roomType.BasePrice <= 0)
                return "Base Price should not be 0";
            if (roomType.RoomTypeID <= 0)
                return "Room Type not found";

            bool success = await repo.UpdateRoomTypeAsync(roomType);

            if (success)
                return "Success: Room Type updated successfully";
            else
                return "Error: Failed to update room type";
        }

        public async Task<string> DeleteRoomTypeAsync(int id)
        {
            if (id <= 0)
                return "Room Type not found";

            bool sucess = await repo.DeleteRoomTypeAsync(id);

            if (sucess)
                return "Success: Room Type deleted successfully";
            else
                return "Error: Room Type not found";
        }
    }
}
