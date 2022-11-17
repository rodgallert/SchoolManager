using SchoolManager.Domain.Model;

namespace SchoolManager.Domain.Interfaces.Repositories
{
    public interface IGradeRepository
    {
        Task<ICollection<Grade>> GetAllActiveAsync();
        Task<Grade> GetByIdAsync(string id);
    }
}
