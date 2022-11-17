using SchoolManager.Domain.Model;

namespace SchoolManager.Domain.Interfaces.Repositories
{
    public interface IUserTypeRepository
    {
        Task<UserType> GetByUserIdAsync(string userId);
        Task<UserType> GetByIdAsync(string id);
    }
}
