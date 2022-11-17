using SchoolManager.Domain.Model;

namespace SchoolManager.Domain.Interfaces.Services
{
    public interface IUserTypeService
    {
        Task<UserType> GetByUserIdAsync(string userId);
        Task<UserType> GetByIdAsync(string id);
    }
}
