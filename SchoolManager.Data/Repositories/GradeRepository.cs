using Microsoft.EntityFrameworkCore;
using SchoolManager.Data.Context;
using SchoolManager.Domain.Interfaces.Repositories;
using SchoolManager.Domain.Model;

namespace SchoolManager.Data.Repositories
{
    public class GradeRepository : IGradeRepository
    {
        private readonly SchoolManagerContext _context;
        public GradeRepository(SchoolManagerContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Grade>> GetAllActiveAsync()
        {
            return await _context.Grade.Where(x => x.Active).ToListAsync();
        }

        public async Task<Grade> GetByIdAsync(string id)
        {
            return await _context.Grade.Where(x => x.Id == new Guid(id)).FirstOrDefaultAsync();
        }
    }
}
