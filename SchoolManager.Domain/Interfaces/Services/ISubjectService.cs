using SchoolManager.Domain.Model;

namespace SchoolManager.Domain.Interfaces.Services
{
    public interface ISubjectService
    {
        Task<ICollection<Subject>> GetAllActiveAsync();
        Task<ICollection<Subject>> GetByGradeIdAsync(string gradeId);
        Task<Subject> GetByIdAsync(string id);
    }
}
