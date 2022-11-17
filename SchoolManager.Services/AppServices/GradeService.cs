using SchoolManager.Domain.Interfaces.Repositories;
using SchoolManager.Domain.Interfaces.Services;
using SchoolManager.Domain.Model;

namespace SchoolManager.Services.AppServices
{
    public class GradeService : IGradeService
    {
        private readonly IGradeRepository _repository;

        public GradeService(IGradeRepository repository)
        {
            _repository = repository;
        }

        public async Task<ICollection<Grade>> GetAllActiveAsync()
        {
            return await _repository.GetAllActiveAsync();
        }

        public async Task<Grade> GetByIdAsync(string id)
        {
            return await _repository.GetByIdAsync(id);
        }
    }
}
