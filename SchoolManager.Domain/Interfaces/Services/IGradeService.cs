using SchoolManager.Domain.Model;

namespace SchoolManager.Domain.Interfaces.Services
{
    public interface IGradeService
    {
        ICollection<Grade> GetAllActiveAsync();
        Grade GetByIdAsync(string id);
    }
}
