using SchoolManager.Domain.Model;

namespace SchoolManager.Domain.Interfaces.Services
{
    public interface IStudentService
    {
        Task<ICollection<Student>> GetAllActiveAsync();
        Task<ICollection<Student>> GetByClassIdAsync(string classId);
        Task<Student> GetByIdAsync(string id);
    }
}
