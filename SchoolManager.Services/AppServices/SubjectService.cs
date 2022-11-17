using SchoolManager.Domain.Interfaces.Repositories;
using SchoolManager.Domain.Interfaces.Services;
using SchoolManager.Domain.Model;

namespace SchoolManager.Services.AppServices
{
    public class SubjectService : ISubjectService
    {
        private readonly ISubjectRepository _repository;

        public SubjectService(ISubjectRepository repository)
        {
            _repository = repository;
        }

        public async Task<ICollection<Subject>> GetAllActiveAsync()
        {
            return await _repository.GetAllActiveAsync();
        }

        public async Task<ICollection<Subject>> GetByGradeIdAsync(string gradeId)
        {
            return await _repository.GetByGradeIdAsync(gradeId);
        }

        public async Task<Subject> GetByIdAsync(string id)
        {
            return await _repository.GetByIdAsync(id);
        }
    }
}
