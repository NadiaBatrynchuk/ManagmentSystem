using DAL.EF;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = System.Threading.Tasks.Task;

namespace DAL.Repositories.Impl
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(ManagementSystemContext context) : base(context)
        {
        }

        // Retrieves a user from the database by their username
        public async Task<User> GetByUsernameAsync(string username)
        {
            return await _set.FirstOrDefaultAsync(u => u.Username == username);
        }

        // Updates an existing user in the database
        public async Task UpdateAsync(User user)
        {
            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

    }
}
