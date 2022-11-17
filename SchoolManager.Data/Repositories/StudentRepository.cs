using Microsoft.EntityFrameworkCore;
using SchoolManager.Data.Context;
using SchoolManager.Domain.Interfaces.Repositories;
using SchoolManager.Domain.Model;

namespace SchoolManager.Data.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly SchoolManagerContext _context;

        public StudentRepository(SchoolManagerContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Student>> GetAllActiveAsync()
        {
            return await _context.Student.Where(x => x.Active).ToListAsync();
        }

        public async Task<ICollection<Student>> GetByClassIdAsync(string classId)
        {
            return await _context.Student.Where(x => x.ClassId == new Guid(classId)).ToListAsync();
        }

        public async Task<Student> GetByIdAsync(string id)
        {
            return await _context.Student.Where(x => x.Id == new Guid(id)).FirstOrDefaultAsync();
        }
    }
}
