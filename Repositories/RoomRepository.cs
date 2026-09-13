using HotelManagementSystem.Database;
using HotelManagementSystem.Model;
using HotelManagementSystem.UserControls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagementSystem.Repositories
{
    public class RoomRepository
    {
        public async Task<List<Room>> GetRoomsAsync()
        {
            List<Room> rooms = [];

            using MySqlConnection conn = DBConnection.GetConnection();
            await conn.OpenAsync();

            string sql = "SELECT roomID, roomNumber, roomTypeID, floor, status, description " +
                          "FROM rooms";

            using MySqlCommand cmd = new(sql, conn);
            using MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                Room room = new()
                {
                    RoomID = reader.GetInt32(0),
                    RoomNumber = reader.GetInt32(1),
                    RoomTypeID = reader.GetInt32(2),
                    Floor = reader.GetInt32(3),
                    Status = reader.GetString(4),
                    Description = reader.GetString(5)
                };
                rooms.Add(room);
            }
            return rooms;
        }

        public async Task<List<Room>> SearchRoomAsync(string keyword)
        {
            List<Room> rooms = [];

            using MySqlConnection conn = DBConnection.GetConnection();
            await conn.OpenAsync();

            string sql = "SELECT roomID, roomNumber, roomTypeID, floor, status, description " +
                          "FROM rooms WHERE roomNumber LIKE @keyword " +
                          "OR floor LIKE @keyword " +
                          "OR status LIKE @keyword";

            using MySqlCommand cmd = new(sql, conn);

            cmd.Parameters.AddWithValue("@keyword", $"%{keyword}%");

            using MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                Room room = new()
                {
                    RoomID = reader.GetInt32(0),
                    RoomNumber = reader.GetInt32(1),
                    RoomTypeID = reader.GetInt32(2),
                    Floor = reader.GetInt32(3),
                    Status = reader.GetString(4),
                    Description = reader.GetString(5)
                };
                rooms.Add(room);
            }
            return rooms;
        }

        public async Task<int> RoomsCountAsync(string keyword)
        {
            using MySqlConnection conn = DBConnection.GetConnection();
            await conn.OpenAsync();

            string sql = "SELECT COUNT(*) FROM rooms " +
                         "WHERE roomNumber LIKE @keyword " +
                         "OR floor LIKE @keyword " +
                         "OR status LIKE @keyword";

            using MySqlCommand cmd = new(sql, conn);

            cmd.Parameters.AddWithValue("@keyword", $"%{keyword}%");

            return Convert.ToInt32(await cmd.ExecuteScalarAsync());
        }

        public async Task<List<Room>> PaginatedRoomAsync(int pageNumber, int pageSize, string keyword)
        {
            List<Room> rooms = [];

            using MySqlConnection conn = DBConnection.GetConnection();
            await conn.OpenAsync();

            string sql = "SELECT r.roomID, r.roomNumber, r.roomTypeID, r.floor, r.status, r.description, " +
                         "rt.name, rt.capacity, rt.basePrice " +
                         "FROM rooms r " +
                         "INNER JOIN roomtypes rt ON r.roomTypeID = rt.roomTypeID " +
                         "WHERE roomNumber LIKE @keyword " +
                         "OR floor LIKE @keyword " +
                         "OR status LIKE @keyword " +
                         "LIMIT @limit OFFSET @offset";
            int offset = (pageNumber - 1) * pageSize;

            using MySqlCommand cmd = new(sql, conn);

            cmd.Parameters.AddWithValue("@keyword", $"%{keyword}%");
            cmd.Parameters.AddWithValue("@limit", pageSize);
            cmd.Parameters.AddWithValue("@offset", offset);

            using MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                Room room = new()
                {
                    RoomID = reader.GetInt32(0),
                    RoomNumber = reader.GetInt32(1),
                    RoomTypeID = reader.GetInt32(2),
                    Floor = reader.GetInt32(3),
                    Status = reader.GetString(4),
                    Description = reader.GetString(5),

                    RoomType = new RoomType
                    {
                        Name = reader.GetString(6),
                        Capacity = reader.GetInt32(7),
                        BasePrice = reader.GetInt32(8),
                    }
                };
                rooms.Add(room);
            }

            return rooms;
        }

        public async Task<Room?> GetRoomAsync(int id)
        {
            using MySqlConnection conn = DBConnection.GetConnection();
            await conn.OpenAsync();

            string sql = "SELECT r.roomID, r.roomNumber, r.roomTypeID, r.floor, r.status, r.description, " +
                         "rt.name, rt.capacity, rt.basePrice "+
                         "FROM rooms r " +
                         "INNER JOIN roomtypes rt ON r.roomTypeID = rt.roomTypeID " +
                         "WHERE roomID=@id";

            using MySqlCommand cmd = new(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            using MySqlDataReader reader =(MySqlDataReader)await cmd.ExecuteReaderAsync();

            if (await reader.ReadAsync())
            {
                Room room = new()
                {
                    RoomID = reader.GetInt32(0),
                    RoomNumber = reader.GetInt32(1),
                    RoomTypeID = reader.GetInt32(2),
                    Floor = reader.GetInt32(3),
                    Status = reader.GetString(4),
                    Description = reader.GetString(5),

                    RoomType = new RoomType
                    {
                        Name = reader.GetString(6),
                        Capacity = reader.GetInt32(7),
                        BasePrice = reader.GetInt32(8),
                    }
                };
                return room;
            }
            return null;
        }

        public async Task<bool> AddRoomAsync(Room room)
        {
            using MySqlConnection conn = DBConnection.GetConnection();
            await conn.OpenAsync();

            string sql = "INSERT INTO rooms " +
                         "(roomNumber, roomTypeID, floor, status, description) " +
                         "VALUES (@roomNumber, @roomTypeID, @floor, @status, @description)";

            using MySqlCommand cmd = new(sql, conn);

            cmd.Parameters.AddWithValue("@roomNumber", room.RoomNumber);
            cmd.Parameters.AddWithValue("@roomTypeID", room.RoomTypeID);
            cmd.Parameters.AddWithValue("@floor", room.Floor);
            cmd.Parameters.AddWithValue("@status", room.Status);
            cmd.Parameters.AddWithValue("@description", room.Description);

            return await cmd.ExecuteNonQueryAsync() > 0;
        }

        public async Task<bool> UpdateRoomAsync(Room room)
        {
            using MySqlConnection conn = DBConnection.GetConnection();
            await conn.OpenAsync();

            string sql = "UPDATE rooms " +
                         "SET roomNumber=@roomNumber, roomTypeID=@roomTypeID, floor=@floor, status=@status, description=@description " +
                         "WHERE roomID=@id";

            using MySqlCommand cmd = new(sql, conn);

            cmd.Parameters.AddWithValue("@roomNumber", room.RoomNumber);
            cmd.Parameters.AddWithValue("@roomTypeID", room.RoomTypeID);
            cmd.Parameters.AddWithValue("@floor", room.Floor);
            cmd.Parameters.AddWithValue("@status", room.Status);
            cmd.Parameters.AddWithValue("@description", room.Description);
            cmd.Parameters.AddWithValue("@id", room.RoomID);

            return await cmd.ExecuteNonQueryAsync() > 0;
        }

        public async Task<bool> DeleteRoomAsync(int id)
        {
            using MySqlConnection conn = DBConnection.GetConnection();
            await conn.OpenAsync();

            string sql = "DELETE FROM rooms WHERE roomID=@id";

            using MySqlCommand cmd = new(sql, conn);

            cmd.Parameters.AddWithValue("@id", id);

            return await cmd.ExecuteNonQueryAsync() > 0;
        }

        public async Task<List<Room>> GetRoomsByTypeAsync(int roomTypeID)
        {
            List<Room> rooms = [];

            using MySqlConnection conn = DBConnection.GetConnection();
            await conn.OpenAsync();

            string sql = "SELECT roomID, roomNumber, roomTypeID, floor, status, description " +
                          "FROM rooms " +
                          "WHERE roomTypeID LIKE @roomTypeID";

            using MySqlCommand cmd = new(sql, conn);

            cmd.Parameters.AddWithValue("@roomTypeID", roomTypeID);

            using MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                Room room = new()
                {
                    RoomID = reader.GetInt32(0),
                    RoomNumber = reader.GetInt32(1),
                    RoomTypeID = reader.GetInt32(2),
                    Floor = reader.GetInt32(3),
                    Status = reader.GetString(4),
                    Description = reader.GetString(5)
                };
                rooms.Add(room);
            }
            return rooms;
        }
    }
}
