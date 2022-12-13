using employee_accounting.Models.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_accounting.Data.Base
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        private readonly WorkersContext _context;
        public EntityBaseRepository(WorkersContext context)
        {
            _context = context;
        }

        public async Task AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(int id, T entity)
        {
            throw new NotImplementedException();
        }
    }
}
