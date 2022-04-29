using CBATemplate.Core.Models;
using CBATemplate.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBATemplate.Data.Implementations
{
    public class UserDao : IUserDao
    {
        private readonly AppDbContext context;
        public UserDao(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<User> DeleteAsync(User entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> RetrieveAllAsync()
        {
            return await context.Users.ToListAsync();
        }

        public async Task<User> RetrieveByIdAsync(long Id)
        {
            return await context.Users.FindAsync(Id);
        }

        public Task<User> SaveAsync(User entity)
        {
            throw new NotImplementedException();
        }

        public Task<User> UpdateAsync(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
