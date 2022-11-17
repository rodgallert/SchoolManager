using Microsoft.EntityFrameworkCore;
using SchoolManager.Data.Context;
using SchoolManager.Domain.Interfaces.Repositories;
using SchoolManager.Domain.Model;

namespace SchoolManager.Data.Repositories
{
    public class SubjectRepository : ISubjectRepository
    {
        private readonly SchoolManagerContext _context;

        public SubjectRepository(SchoolManagerContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Subject>> GetAllActiveAsync()
        {
            return await _context.Subject.Where(x => x.Active).ToListAsync();
        }

        public async Task<ICollection<Subject>> GetByGradeIdAsync(string gradeId)
        {
            return await _context.Grade.Where(x => x.Id == new Guid(gradeId)).SelectMany(x => x.Subjects).ToListAsync();
        }

        public async Task<Subject> GetByIdAsync(string id)
        {
            return await _context.Subject.Where(x => x.Id == new Guid(id)).FirstOrDefaultAsync();
        }
    }
}
