using SchoolManager.Domain.Model;

namespace SchoolManager.Domain.Interfaces.Services
{
    public interface ITeacherService
    {
        ICollection<Teacher> GetAllActiveAsync();
        Teacher GetByIdAsync(string id);
    }
}
