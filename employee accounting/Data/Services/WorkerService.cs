using employee_accounting.Data.Base;
using employee_accounting.Models.db;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_accounting.Data.Services
{
    public class WorkerService : EntityBaseRepository<WorkersData>, IWorkerService
    {
        private readonly AppDbContext _context;
        public WorkerService(AppDbContext context): base(context)
        {
            _context = context;
        }
        public async Task<List<WorkersData>> GetAllAsync()
        {
            List<WorkersData> allWorkers = await _context.WorkersData.ToListAsync();
            return allWorkers;
        }

        public async Task<WorkersData> GetByIdAsync(int id)
        {
            var workerById = await _context.WorkersData.FirstOrDefaultAsync(w => w.Id == id);
            return workerById;
        }
    }
}
