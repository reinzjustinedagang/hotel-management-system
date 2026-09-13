using HotelManagementSystem.Database;
using HotelManagementSystem.Interface;
using HotelManagementSystem.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace HotelManagementSystem.Repositories
{
    internal class GuestRepository : IGuestRepo
    {
        public async Task<List<Guest>> GetGuests()
        {
            List<Guest> guests = [];

            try
            {
                using MySqlConnection conn = DBConnection.GetConnection();
                await conn.OpenAsync();

                string sql = "SELECT guestID, firstName, lastName, phone, email, address, nationality FROM guests";

                using MySqlCommand cmd = new(sql, conn);
                using MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    Guest guest = new()
                    {
                        GuestsID = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        LastName = reader.GetString(2),
                        Phone = reader.GetString(3),
                        Email = reader.GetString(4),
                        Address = reader.GetString(5),
                        Nationality = reader.GetString(6)
                    };
                    guests.Add(guest);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return guests;
        }

        public Guest? GetGuest(int id)
        {
            try
            {
                using MySqlConnection conn = DBConnection.GetConnection();
                conn.Open();

                string sql = "SELECT * FROM guests WHERE guestID=@id";

                using MySqlCommand cmd = new(sql, conn);

                cmd.Parameters.AddWithValue("@id", id);

                using MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Guest guest = new()
                    {
                        GuestsID = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        LastName = reader.GetString(2),
                        Gender = reader.GetString(3),
                        Birthdate = reader.GetDateTime(4),
                        Phone = reader.GetString(5),
                        Email = reader.GetString(6),
                        Address = reader.GetString(7),
                        Nationality = reader.GetString(8),
                        ValidID = reader.GetString(9)
                    };
                    return guest;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return null;
        }

        public bool AddGuest(Guest guest)
        {
            try
            {
                using MySqlConnection conn = DBConnection.GetConnection();
                conn.Open();

                string sql = "INSERT INTO guests " +
                             "(firstName, lastName, gender, birthdate, phone, email, address, nationality, validID) VALUES " +
                             "(@firstName, @lastName, @gender, @birthdate, @phone, @email, @address, @nationality, @validID)";

                using MySqlCommand cmd = new(sql, conn);

                cmd.Parameters.AddWithValue("@firstName", guest.FirstName);
                cmd.Parameters.AddWithValue("@lastName", guest.LastName);
                cmd.Parameters.AddWithValue("@gender", guest.Gender);
                cmd.Parameters.AddWithValue("@birthdate", guest.Birthdate);
                cmd.Parameters.AddWithValue("@phone", guest.Phone);
                cmd.Parameters.AddWithValue("@email", guest.Email);
                cmd.Parameters.AddWithValue("@address", guest.Address);
                cmd.Parameters.AddWithValue("@nationality", guest.Nationality);
                cmd.Parameters.AddWithValue("@validID", guest.ValidID);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public bool UpdateGuest(Guest guest)
        {
            try
            {
                using MySqlConnection conn = DBConnection.GetConnection();
                conn.Open();

                string sql = "UPDATE guests " +
                             "SET firstName=@firstName, lastName=@lastName, gender=@gender, birthdate=@birthdate, " +
                             "phone=@phone, email=@email, address=@address, nationality=@nationality, validID=@validID " +
                             "WHERE guestID=@guestID";

                using MySqlCommand cmd = new(sql, conn);

                cmd.Parameters.AddWithValue("@firstName", guest.FirstName);
                cmd.Parameters.AddWithValue("@lastName", guest.LastName);
                cmd.Parameters.AddWithValue("@gender", guest.Gender);
                cmd.Parameters.AddWithValue("@birthdate", guest.Birthdate);
                cmd.Parameters.AddWithValue("@phone", guest.Phone);
                cmd.Parameters.AddWithValue("@email", guest.Email);
                cmd.Parameters.AddWithValue("@address", guest.Address);
                cmd.Parameters.AddWithValue("@nationality", guest.Nationality);
                cmd.Parameters.AddWithValue("@validID", guest.ValidID);
                cmd.Parameters.AddWithValue("@guestID", guest.GuestsID);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
                return false;
            }
        }

        public bool DeleteGuest(int id)
        {
            try
            {
                using MySqlConnection conn = DBConnection.GetConnection();
                conn.Open();

                string sql = "DELETE FROM guests WHERE guestID=@id";

                using MySqlCommand cmd = new(sql, conn);

                cmd.Parameters.AddWithValue("@id", id);

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
                return false;
            }
        }

        public List<Guest> SearchGuest(string keyword)
        {
            List<Guest> searchGuests = new();
            try
            {
                using MySqlConnection conn = DBConnection.GetConnection();
                conn.Open();

                string sql = "SELECT guestID, firstName, lastName, phone, email, address, nationality FROM guests " +
                             "WHERE firstName LIKE @keyword " +
                             "OR lastName LIKE @keyword " +
                             "OR phone LIKE @keyword " +
                             "OR email LIKE @keyword";

                using MySqlCommand cmd = new(sql, conn);

                cmd.Parameters.AddWithValue("@keyword", $"%{keyword}%");

                using MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Guest guest = new()
                    {
                        GuestsID = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        LastName = reader.GetString(2),
                        Phone = reader.GetString(3),
                        Email = reader.GetString(4),
                        Address = reader.GetString(5),
                        Nationality = reader.GetString(6)
                    };
                    searchGuests.Add(guest);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return searchGuests;
        }

        public int GetTotalGuestCount(string keyword = "")
        {
            try
            {
                string sql = "SELECT COUNT(*) FROM guests WHERE firstName LIKE @keyword OR lastName LIKE @keyword";
                using MySqlConnection conn = DBConnection.GetConnection();
                conn.Open();

                using MySqlCommand cmd = new(sql, conn);

                cmd.Parameters.AddWithValue("@keyword", $"%{keyword}%");

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine (ex.ToString());
                return 0;
            }
            
        }

        public List<Guest> PaginatedGuest(int pageNumber, int pageSize, string keyword)
        {
            List<Guest> guests = new();
            int offset = (pageNumber - 1) * pageSize;
            string sql = "SELECT guestID, firstName, lastName, phone, email, address, nationality " +
                         "FROM guests " +
                         "WHERE firstName LIKE @keyword OR lastName LIKE @keyword " +
                         "LIMIT @limit OFFSET @offset";
            try
            {
                using MySqlConnection conn = DBConnection.GetConnection();
                conn.Open();

                using MySqlCommand cmd = new(sql, conn);
               
                cmd.Parameters.AddWithValue("@keyword", $"%{keyword}%");
                cmd.Parameters.AddWithValue("@limit", pageSize);
                cmd.Parameters.AddWithValue("@offset", offset);

                using MySqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    Guest guest = new()
                    {
                        GuestsID = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        LastName = reader.GetString(2),
                        Phone = reader.GetString(3),
                        Email = reader.GetString(4),
                        Address = reader.GetString(5),
                        Nationality = reader.GetString(6)
                    };
                    guests.Add(guest);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return guests;
        }

        public async Task<int> CreateAsync(Guest guest)
        {
            using MySqlConnection conn = DBConnection.GetConnection();
            await conn.OpenAsync();

            string sql = @"INSERT INTO guests " +
                         "(firstName, lastName, gender, birthdate, phone, email, address, nationality, validID) VALUES " +
                         "(@firstName, @lastName, @gender, @birthdate, @phone, @email, @address, @nationality, @validID); " +
                         "SELECT LAST_INSERT_ID();";

            using MySqlCommand cmd = new(sql, conn);

            cmd.Parameters.AddWithValue("@firstName", guest.FirstName);
            cmd.Parameters.AddWithValue("@lastName", guest.LastName);
            cmd.Parameters.AddWithValue("@gender", guest.Gender);
            cmd.Parameters.AddWithValue("@birthdate", guest.Birthdate);
            cmd.Parameters.AddWithValue("@phone", guest.Phone);
            cmd.Parameters.AddWithValue("@email", guest.Email);
            cmd.Parameters.AddWithValue("@address", guest.Address);
            cmd.Parameters.AddWithValue("@nationality", guest.Nationality);
            cmd.Parameters.AddWithValue("@validID", guest.ValidID);

            return Convert.ToInt32(await cmd.ExecuteScalarAsync());
        }

    }
}
