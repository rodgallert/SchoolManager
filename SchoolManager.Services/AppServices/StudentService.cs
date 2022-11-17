using SchoolManager.Domain.Interfaces.Repositories;
using SchoolManager.Domain.Interfaces.Services;
using SchoolManager.Domain.Model;

namespace SchoolManager.Services.AppServices
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repository;

        public StudentService(IStudentRepository repository)
        {
            _repository = repository;
        }

        public async Task<ICollection<Student>> GetAllActiveAsync()
        {
            return await _repository.GetAllActiveAsync();
        }

        public async Task<ICollection<Student>> GetByClassIdAsync(string classId)
        {
            return await _repository.GetByClassIdAsync(classId);
        }

        public async Task<Student> GetByIdAsync(string id)
        {
            return await _repository.GetByIdAsync(id);
        }
    }
}
