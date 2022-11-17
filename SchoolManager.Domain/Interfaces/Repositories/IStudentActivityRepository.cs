using SchoolManager.Domain.Model;

namespace SchoolManager.Domain.Interfaces.Repositories
{
    public interface IStudentActivityRepository
    {
        Task<ICollection<StudentActivity>> GetByStudentIdAsync(string studentId);
        Task<StudentActivity> GetByIdAsync(string id);
    }
}
