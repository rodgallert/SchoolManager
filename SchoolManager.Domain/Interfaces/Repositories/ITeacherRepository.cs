using SchoolManager.Domain.Model;

namespace SchoolManager.Domain.Interfaces.Repositories
{
    public interface ITeacherRepository
    {
        Task<ICollection<Teacher>> GetAllActiveAsync();
        Task<Teacher> GetByIdAsync(string id);
    }
}
