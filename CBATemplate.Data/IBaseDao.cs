using CBATemplate.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBATemplate.Data
{
    public interface IBaseDao<T> where T : BaseEntity
    {
        Task<T> SaveAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(T entity);
        Task<IEnumerable<T>> RetrieveAllAsync();
        Task<T> RetrieveByIdAsync(long Id);
    }
}
