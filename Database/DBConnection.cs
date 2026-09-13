using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagementSystem.Database
{
    public static class DBConnection
    {
        private static readonly string connectionString = "Server=localhost;Database=hotel_management;User=root;Password=;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
