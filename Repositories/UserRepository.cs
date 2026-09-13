using HotelManagementSystem.Database;
using HotelManagementSystem.Interface;
using HotelManagementSystem.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagementSystem.Repositories
{
    public class UserRepository : IUserRepo
    {
        public async Task<User> Login(string username, string password)
        {
            using MySqlConnection conn = DBConnection.GetConnection();
            await conn.OpenAsync();

            string sql = "SELECT username, password FROM users WHERE username=@username LIMIT 1";

            using MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@username", username);

            using MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync();

            if (await reader.ReadAsync())
            {
                string pass = reader.GetString("password");

                if (password.Equals(pass))
                {
                    User user = new();
                    user.Username = reader.GetString("username");
                    user.Password = reader.GetString("password");
                    return user;
                }
            }
            return null;
        }

        public async Task<List<User>> GetUsersAsync()
        {
            List<User> users = [];

            using MySqlConnection conn = DBConnection.GetConnection();
            await conn.OpenAsync();

            string sql = "SELECT userID, username, role, fullName, status FROM users";

            using MySqlCommand cmd = new(sql, conn);
            using MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                User user = new()
                {
                    UserId = reader.GetInt32(0),
                    Username = reader.GetString(1),
                    Role = reader.GetString(2),
                    FullName = reader.GetString(3),
                    Status = reader.GetString(4)
                   
                };
                users.Add(user);
            }

            return users;
        }

        public async Task<int> GetUsersCountAsync(string keyword)
        {
            using MySqlConnection conn = DBConnection.GetConnection();
            await conn.OpenAsync();

            string sql = "SELECT COUNT(*) FROM users " +
                         "WHERE username LIKE @keyword OR fullName LIKE @keyword OR role LIKE @keyword";

            using MySqlCommand cmd = new(sql, conn);

            cmd.Parameters.AddWithValue("@keyword", $"%{keyword}%");

            return Convert.ToInt32(await cmd.ExecuteScalarAsync());
        }

        public async Task<List<User>> GetPaginatedUsersAsync(int pageSize, int pageNumber, string keyword)
        {
            List<User> users = [];

            using MySqlConnection conn = DBConnection.GetConnection();
            await conn.OpenAsync();

            int offset = (pageNumber - 1) * pageSize;
            string sql = "SELECT userID, username, role, fullName, status " +
                         "FROM users " +
                         "WHERE username LIKE @keyword OR fullName LIKE @keyword OR role LIKE @keyword " +
                         "LIMIT @limit OFFSET @offset";

            using MySqlCommand cmd = new(sql, conn);

            cmd.Parameters.AddWithValue("@keyword", $"%{keyword}%");
            cmd.Parameters.AddWithValue("@limit", pageSize);
            cmd.Parameters.AddWithValue("@offset", offset);

            using MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                User user = new()
                {
                    UserId = reader.GetInt32(0),
                    Username = reader.GetString(1),
                    Role = reader.GetString(2),
                    FullName = reader.GetString(3),
                    Status = reader.GetString(4)

                };
                users.Add(user);
            }

            return users;
        }

        public async Task<User> GetUserAsync(int id)
        {
            using MySqlConnection conn = DBConnection.GetConnection();
            await conn.OpenAsync();

            string sql = "SELECT userID, username, password, role, fullName, status FROM users WHERE userID=@userID";

            using MySqlCommand cmd = new(sql, conn);

            cmd.Parameters.AddWithValue("@userID", id);

            using MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync();

            if (await reader.ReadAsync())
            {
                User user = new()
                {
                    UserId = reader.GetInt32(0),
                    Username = reader.GetString(1),
                    Password = reader.GetString(2),
                    Role = reader.GetString(3),
                    FullName = reader.GetString(4),
                    Status = reader.GetString(5)

                };
                return user;
            }

            return null;
        }

        public async Task<bool> AddUserAsync(User user)
        {
            using MySqlConnection conn = DBConnection.GetConnection();
            await conn.OpenAsync();

            string sql = "INSERT INTO users (username, password, role, fullName) VALUES(@username, @password, @role, @fullName)";

            using MySqlCommand cmd = new(sql, conn);

            cmd.Parameters.AddWithValue("@username", user.Username);
            cmd.Parameters.AddWithValue("@password", user.Password);
            cmd.Parameters.AddWithValue("@role", user.Role);
            cmd.Parameters.AddWithValue("@fullName", user.FullName);

            return await cmd.ExecuteNonQueryAsync() > 0;
        }

        public async Task<bool> UpdateUserAsync(User user)
        {
            using MySqlConnection conn = DBConnection.GetConnection();
            await conn.OpenAsync();

            string sql = "UPDATE users SET username=@username, password=@password, role=@role, fullName=@fullName WHERE userID=@userID";

            using MySqlCommand cmd = new(sql, conn);

            cmd.Parameters.AddWithValue("@username", user.Username);
            cmd.Parameters.AddWithValue("@password", user.Password);
            cmd.Parameters.AddWithValue("@role", user.Role);
            cmd.Parameters.AddWithValue("@fullName", user.FullName);
            cmd.Parameters.AddWithValue("@userID", user.UserId);

            return await cmd.ExecuteNonQueryAsync() > 0;
        }

        public async Task<bool> DeleteUserAsync(int id)
        {
            using MySqlConnection conn = DBConnection.GetConnection();
            await conn.OpenAsync();

            string sql = "DELETE FROM users WHERE userID=@userID";

            using MySqlCommand cmd = new(sql, conn);

            cmd.Parameters.AddWithValue("@userID", id);

            return await cmd.ExecuteNonQueryAsync() > 0;
        }
    }
}
