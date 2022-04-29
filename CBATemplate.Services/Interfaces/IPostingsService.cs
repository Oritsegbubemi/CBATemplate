using CBATemplate.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBATemplate.Services.Interfaces
{
    public interface IPostingsService
    {
        Task<bool> PostAsync(IAccount drAccount, IAccount crAccount);
    }
}
