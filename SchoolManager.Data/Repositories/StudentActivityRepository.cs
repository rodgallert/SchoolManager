using Microsoft.EntityFrameworkCore;
using SchoolManager.Data.Context;
using SchoolManager.Domain.Interfaces.Repositories;
using SchoolManager.Domain.Model;

namespace SchoolManager.Data.Repositories
{
    public class StudentActivityRepository : IStudentActivityRepository
    {
        private readonly SchoolManagerContext _context;

        public StudentActivityRepository(SchoolManagerContext context)
        {
            _context = context;
        }

        public async Task<StudentActivity> GetByIdAsync(string id)
        {
            return await _context.StudentActivities.Where(x => x.Id == new Guid(id)).FirstOrDefaultAsync();
        }

        public async Task<ICollection<StudentActivity>> GetByStudentIdAsync(string studentId)
        {
            return await _context.StudentActivities.Where(x => x.StudentId == new Guid(studentId)).ToListAsync();
        }
    }
}
