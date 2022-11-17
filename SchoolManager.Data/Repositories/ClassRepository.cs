using Microsoft.EntityFrameworkCore;
using SchoolManager.Data.Context;
using SchoolManager.Domain.Interfaces.Repositories;
using SchoolManager.Domain.Model;

namespace SchoolManager.Data.Repositories
{
    public class ClassRepository : IClassRepository
    {
        private readonly SchoolManagerContext _context;
        public ClassRepository(SchoolManagerContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Class>> GetAllActiveAsync()
        {
            return await _context.Class.Where(x => x.Active).ToListAsync();
        }

        public async Task<Class> GetByIdAsync(string id)
        {
            return await _context.Class.Where(x => x.Id == new Guid(id)).FirstOrDefaultAsync();
        }
    }
}
