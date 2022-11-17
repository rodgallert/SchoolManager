using SchoolManager.Domain.Interfaces.Repositories;
using SchoolManager.Domain.Interfaces.Services;
using SchoolManager.Domain.Model;

namespace SchoolManager.Services.AppServices
{
    public class StudentActivityService : IStudentActivityService
    {
        private readonly IStudentActivityRepository _repository;

        public StudentActivityService(IStudentActivityRepository repository)
        {
            _repository = repository;
        }

        public async Task<StudentActivity> GetByIdAsync(string id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<ICollection<StudentActivity>> GetByStudentIdAsync(string studentId)
        {
            return await _repository.GetByStudentIdAsync(studentId);
        }
    }
}
