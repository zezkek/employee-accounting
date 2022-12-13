using employee_accounting.Models.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_accounting.Data.Services
{
    public interface IWorkerService
    {
        Task DeleteAsync(int id);
        Task<WorkersData> GetByIdAsync(int id);
        Task<List<WorkersData>> GetAllAsync();
    }
}
