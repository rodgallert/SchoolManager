using SchoolManager.Domain.Model;

namespace SchoolManager.Domain.Interfaces.Services
{
    public interface IGradeService
    {
        Task<ICollection<Grade>> GetAllActiveAsync();
        Task<Grade> GetByIdAsync(string id);
    }
}
