using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_accounting.Data.Base
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        Task DeleteAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(int id, T entity);
    }
}
