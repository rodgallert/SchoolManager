using SchoolManager.Domain.Model;

namespace SchoolManager.Domain.Interfaces.Repositories
{
    public interface IStudentRepository
    {
        Task<ICollection<Student>> GetAllActiveAsync();
        Task<ICollection<Student>> GetByClassIdAsync(string classId);
        Task<Student> GetByIdAsync(string id);
    }
}
