using SchoolManager.Domain.Model;

namespace SchoolManager.Domain.Interfaces.Services
{
    public interface IStudentService
    {
        ICollection<Student> GetAllActiveAsync();
        ICollection<Student> GetByClassIdAsync(string classId);
        Student GetByIdAsync(string id);
    }
}
