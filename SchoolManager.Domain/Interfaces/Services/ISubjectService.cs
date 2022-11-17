using SchoolManager.Domain.Model;

namespace SchoolManager.Domain.Interfaces.Services
{
    public interface ISubjectService
    {
        ICollection<Subject> GetAllActiveAsync();
        ICollection<Subject> GetByGradeIdAsync(string gradeId);
        Subject GetByIdAsync(string id);
    }
}
