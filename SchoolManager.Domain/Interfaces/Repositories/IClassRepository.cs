using SchoolManager.Domain.Model;

namespace SchoolManager.Domain.Interfaces.Repositories
{
    public interface IClassRepository
    {
        Task<ICollection<Class>> GetAllActiveAsync();
        Task<Class> GetByIdAsync(string id);
    }
}
