using SchoolManager.Domain.Model;

namespace SchoolManager.Domain.Interfaces.Services
{
    public interface IUserTypeService
    {
        UserType GetByUserIdAsync(string userId);
        UserType GetByIdAsync(string id);
    }
}
