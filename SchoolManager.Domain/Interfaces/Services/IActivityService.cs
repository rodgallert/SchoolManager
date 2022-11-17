using SchoolManager.Domain.Model;

namespace SchoolManager.Domain.Interfaces.Services
{
    public interface IActivityService
    {
        Task<ICollection<Activity>> GetAllActiveAsync();
        Task<Activity> GetByIdAsync(string id);
    }
}
