using HotelManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagementSystem.Interface
{
    public interface IUserService
    {
        Task<User> Login(string username, string password);
        Task<List<User>> GetUsersAsync();
        Task<int> GetUsersCountAsync(string keyword);
        Task<List<User>> GetPaginatedUsersAsync(int pageSize, int pageNumber, string keyword);
        Task<User> GetUserAsync(int id);
        Task<string> AddUserAsync(User user);
        Task<string> UpdateUserAsync(User user);
        Task<string> DeleteUserAsync(int id);
    }
}
