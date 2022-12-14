using SchoolManager.Domain.Interfaces.Repositories;
using SchoolManager.Domain.Interfaces.Services;
using SchoolManager.Domain.Model;

namespace SchoolManager.Services.AppServices
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _repository;

        public TeacherService(ITeacherRepository repository)
        {
            _repository = repository;
        }

        public async Task<ICollection<Teacher>> GetAllActiveAsync()
        {
            return await _repository.GetAllActiveAsync();
        }

        public async Task<Teacher> GetByIdAsync(string id)
        {
            return await _repository.GetByIdAsync(id);
        }
    }
}
