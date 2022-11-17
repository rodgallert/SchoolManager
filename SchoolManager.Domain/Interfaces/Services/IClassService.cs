using SchoolManager.Domain.Model;

namespace SchoolManager.Domain.Interfaces.Services
{
    public interface IClassService
    {
        Task<ICollection<Class>> GetAllActiveAsync();
        Task<Class> GetByIdAsync(string id);
    }
}
