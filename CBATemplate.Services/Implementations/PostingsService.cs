using CBATemplate.Core.Interfaces;
using CBATemplate.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBATemplate.Services.Implementations
{
    public class PostingsService : IPostingsService
    {
        //private readonly ITransaction
        public PostingsService()
        {

        }

        public Task<bool> PostAsync(IAccount drAccount, IAccount crAccount)
        {
            throw new NotImplementedException();
        }
    }
}
