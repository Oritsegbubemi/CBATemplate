using CBATemplate.Core.Models;
using CBATemplate.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBATemplate.Data.Implementations
{
    public class UserRoleFunctionDao : IUserRoleFunctionDao
    {
        public UserRoleFunctionDao()
        {

        }

        public Task<UserRoleFunction> DeleteAsync(UserRoleFunction entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserRoleFunction>> RetrieveAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UserRoleFunction> RetrieveByIdAsync(long Id)
        {
            throw new NotImplementedException();
        }

        public Task<UserRoleFunction> SaveAsync(UserRoleFunction entity)
        {
            throw new NotImplementedException();
        }

        public Task<UserRoleFunction> UpdateAsync(UserRoleFunction entity)
        {
            throw new NotImplementedException();
        }
    }
}
