using SchoolManager.Domain.Model;

namespace SchoolManager.Domain.Interfaces.Services
{
    public interface IStudentActivityService
    {
        ICollection<StudentActivity> GetByStudentIdAsync(string studentId);
        StudentActivity GetByIdAsync(string id);
    }
}
