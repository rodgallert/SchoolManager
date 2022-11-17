using SchoolManager.Domain.Model;

namespace SchoolManager.Domain.Interfaces.Services
{
    public interface IStudentActivityService
    {
        Task<ICollection<StudentActivity>> GetByStudentIdAsync(string studentId);
        Task<StudentActivity> GetByIdAsync(string id);
    }
}
