using HotelManagementSystem.Database;
using HotelManagementSystem.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagementSystem.Repositories
{
    internal class RoomTypeRepository
    {

        public async Task<List<RoomType>> GetRoomTypesAsync()
        {
            List<RoomType> roomTypes = [];

            using MySqlConnection conn = DBConnection.GetConnection();
            await conn.OpenAsync();

            string sql = "SELECT roomTypeID, name, capacity, basePrice FROM roomtypes";

            using MySqlCommand cmd = new(sql, conn);
            using MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                RoomType roomType = new()
                {
                    RoomTypeID = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Capacity = reader.GetInt32(2),
                    BasePrice = reader.GetInt32(3)
                };
                roomTypes.Add(roomType);
            }

            return roomTypes;

        }

        public async Task<RoomType?> GetRoomTypeAsync(int id)
        {
            using MySqlConnection conn = DBConnection.GetConnection();
            await conn.OpenAsync();

            string sql = "SELECT roomTypeID, name, capacity, basePrice FROM roomtypes WHERE roomTypeID=@id";

            using MySqlCommand cmd = new(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            using MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync();

            if (await reader.ReadAsync())
            {
                RoomType roomType = new()
                {
                    RoomTypeID = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Capacity = reader.GetInt32(2),
                    BasePrice = reader.GetInt32(3)
                };
                return roomType;
            }
            return null;
        }

        public async Task<bool> AddRoomTypeAsync(RoomType roomType)
        {
            using MySqlConnection conn = DBConnection.GetConnection();
            await conn.OpenAsync();

            string sql = "INSERT INTO roomtypes (name, capacity, basePrice) VALUES(@name, @capacity, @basePrice)";

            using MySqlCommand cmd = new(sql, conn);

            cmd.Parameters.AddWithValue("@name", roomType.Name);
            cmd.Parameters.AddWithValue("@capacity", roomType.Capacity);
            cmd.Parameters.AddWithValue("@basePrice", roomType.BasePrice);

            return await cmd.ExecuteNonQueryAsync() > 0;
        }

        public async Task<bool> UpdateRoomTypeAsync(RoomType roomType)
        {
            using MySqlConnection conn = DBConnection.GetConnection();
            await conn.OpenAsync();

            string sql = "UPDATE roomtypes SET name=@name, capacity=@capacity, basePrice=@basePrice WHERE roomTypeID=@id";

            using MySqlCommand cmd = new(sql, conn);

            cmd.Parameters.AddWithValue("@name", roomType.Name);
            cmd.Parameters.AddWithValue("@capacity", roomType.Capacity);
            cmd.Parameters.AddWithValue("@basePrice", roomType.BasePrice);
            cmd.Parameters.AddWithValue("@id", roomType.RoomTypeID);

            return await cmd.ExecuteNonQueryAsync() > 0;
        }

        public async Task<bool> DeleteRoomTypeAsync(int id)
        {
            using MySqlConnection conn = DBConnection.GetConnection();
            await conn.OpenAsync();

            string sql = "DELETE FROM roomtypes WHERE roomTypeID=@id";

            using MySqlCommand cmd = new(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            return await cmd.ExecuteNonQueryAsync() > 0;
        }
    }
}
