using CBATemplate.Core.Models;
using CBATemplate.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBATemplate.Data.Implementations
{
    public class UserRoleDao : IUserRoleDao
    {
        public UserRoleDao()
        {

        }
        public Task<UserRole> DeleteAsync(UserRole entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserRole>> RetrieveAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UserRole> RetrieveByIdAsync(long Id)
        {
            throw new NotImplementedException();
        }

        public Task<UserRole> SaveAsync(UserRole entity)
        {
            throw new NotImplementedException();
        }

        public Task<UserRole> UpdateAsync(UserRole entity)
        {
            throw new NotImplementedException();
        }
    }
}
