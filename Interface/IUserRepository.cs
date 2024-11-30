using OnlineChat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineChat.Interface
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUsersAsync();
        Task<User> GetUserByEmailAsync(string email);
        Task AddUserAsync(User user);
        Task UpdateUserAsync(User user);
    }
}
