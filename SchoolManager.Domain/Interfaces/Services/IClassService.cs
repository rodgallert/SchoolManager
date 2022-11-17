using SchoolManager.Domain.Model;

namespace SchoolManager.Domain.Interfaces.Services
{
    public interface IClassService
    {
        ICollection<Class> GetAllActiveAsync();
        Class GetByIdAsync(string id);
    }
}
