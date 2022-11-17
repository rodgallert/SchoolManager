using SchoolManager.Domain.Model;

namespace SchoolManager.Domain.Interfaces.Services
{
    public interface ITeacherService
    {
        Task<ICollection<Teacher>> GetAllActiveAsync();
        Task<Teacher> GetByIdAsync(string id);
    }
}
