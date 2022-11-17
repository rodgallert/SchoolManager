using SchoolManager.Domain.Model;

namespace SchoolManager.Domain.Interfaces.Repositories
{
    public interface ISubjectRepository
    {
        Task<ICollection<Subject>> GetAllActiveAsync();
        Task<ICollection<Subject>> GetByGradeIdAsync(string gradeId);
        Task<Subject> GetByIdAsync(string id);
    }
}
