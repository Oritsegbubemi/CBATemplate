using CBATemplate.Core.Models;
using CBATemplate.Data.Interfaces;
using CBATemplate.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBATemplate.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserDao userDao;
        private readonly IPostingsService postingsService;
        public UserService(IUserDao userDao, IPostingsService postingsService)
        {
            this.userDao = userDao;
            this.postingsService = postingsService;
        }

        public Task<User> DeleteAsync(User entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> RetrieveAllAsync() => this.userDao.RetrieveAllAsync();
        public Task<User> RetrieveByIdAsync(long Id) => this.userDao.RetrieveByIdAsync(Id);
        public async Task<User> SaveAsync(User entity)
        {
            await this.postingsService.PostAsync(new CustomerAccount(), new GLAccount());
            // Do Required Validations
            // Send email if necessary
            // Update the users password

            //Do all the other boring required stuffs before saving the user to the database
            return await this.userDao.SaveAsync(entity);
        }

        public Task<User> UpdateAsync(User entity)
        {
            return this.userDao.UpdateAsync(entity);
        }
    }
}
