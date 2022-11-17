using SchoolManager.Domain.Model;

namespace SchoolManager.Domain.Interfaces.Services
{
    public interface IActivityService
    {
        ICollection<Activity> GetAllActiveAsync();
        Activity GetByIdAsync(string id);
    }
}
