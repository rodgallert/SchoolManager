using SchoolManager.Domain.Model;

namespace SchoolManager.Domain.Interfaces.Repositories
{
    public interface IActivityRepository
    {
        Task<ICollection<Activity>> GetAllActiveAsync();
        Task<Activity> GetByIdAsync(string id);
    }
}
