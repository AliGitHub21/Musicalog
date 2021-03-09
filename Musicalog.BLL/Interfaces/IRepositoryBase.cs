using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Musicalog.BLL.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> AddAsync(T entity);
        Task<T> RemoveAsync(int id);
        void Update(T entity);
    }
}
