using Microsoft.EntityFrameworkCore;
using SchoolManager.Data.Context;
using SchoolManager.Domain.Interfaces.Repositories;
using SchoolManager.Domain.Model;

namespace SchoolManager.Data.Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly SchoolManagerContext _context;

        public TeacherRepository(SchoolManagerContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Teacher>> GetAllActiveAsync()
        {
            return await _context.Teacher.Where(x => x.Active).ToListAsync();
        }

        public async Task<Teacher> GetByIdAsync(string id)
        {
            return await _context.Teacher.Where(x => x.Id == new Guid(id)).FirstOrDefaultAsync();
        }
    }
}
