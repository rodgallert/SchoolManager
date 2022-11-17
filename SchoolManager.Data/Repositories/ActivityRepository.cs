using Microsoft.EntityFrameworkCore;
using SchoolManager.Data.Context;
using SchoolManager.Domain.Interfaces.Repositories;
using SchoolManager.Domain.Model;

namespace SchoolManager.Data.Repositories
{
    public class ActivityRepository : IActivityRepository
    {
        private readonly SchoolManagerContext _context;
        public ActivityRepository(SchoolManagerContext context)
        {
            _context = context;
        }
        public async Task<ICollection<Activity>> GetAllActiveAsync()
        {
            return await _context.Activity.Where(x => x.Active).ToListAsync();
        }

        public async Task<Activity> GetByIdAsync(string id)
        {
            return await _context.Activity.Where(x => x.Id == new Guid(id)).FirstOrDefaultAsync();
        }
    }
}
