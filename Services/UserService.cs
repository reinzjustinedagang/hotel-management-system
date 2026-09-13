using HotelManagementSystem.Interface;
using HotelManagementSystem.Model;
using HotelManagementSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagementSystem.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepo _repo;

        public UserService(IUserRepo repo)
        {
            _repo = repo;
        }

        public async Task<User> Login(string username, string password)
        {
            return await _repo.Login(username, password);
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await _repo.GetUsersAsync();
        }

        public async Task<int> GetUsersCountAsync(string keyword)
        {
            return await _repo.GetUsersCountAsync(keyword);
        }

        public async Task<List<User>> GetPaginatedUsersAsync(int pageSize, int pageNumber, string keyword)
        {
            return await _repo.GetPaginatedUsersAsync(pageSize, pageNumber, keyword);
        }

        public async Task<User> GetUserAsync(int id)
        {
            if (id == 0) return null;

            return await _repo.GetUserAsync(id);
        }

        public async Task<string> AddUserAsync(User user)
        {
            if (string.IsNullOrWhiteSpace(user.Username))
                return "Username is required";
            if (string.IsNullOrWhiteSpace(user.Role))
                return "Role is required";
            if (string.IsNullOrWhiteSpace(user.FullName))
                return "Full Name is required";
            if (string.IsNullOrWhiteSpace(user.Password))
                return "Password is required";

            bool success = await _repo.AddUserAsync(user);

            if (success)
                return "Success: User added successfully";
            else
                return "Error: Failed to add user";
        }

        public async Task<string> UpdateUserAsync(User user)
        {
            if (string.IsNullOrWhiteSpace(user.Username))
                return "Username is required";
            if (string.IsNullOrWhiteSpace(user.Role))
                return "Role is required";
            if (string.IsNullOrWhiteSpace(user.FullName))
                return "Full Name is required";
            if (string.IsNullOrWhiteSpace(user.Password))
                return "Password is required";

            bool success = await _repo.UpdateUserAsync(user);

            if (success)
                return "Success: User updated successfully";
            else
                return "Error: Failed to update user";
        }

        public async Task<string> DeleteUserAsync(int id)
        {
            if (id == 0) 
                return "User not found";
            

            bool success = await _repo.DeleteUserAsync(id);

            if (success)
                return "Success: User deleted successfully";
            else
                return "Error: Failed to delete user";
        }

    }
}
