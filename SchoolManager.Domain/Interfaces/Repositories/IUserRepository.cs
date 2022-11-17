using SchoolManager.Domain.Model;

namespace SchoolManager.Domain.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<User> AuthenticateAsync(string email, string password);
    }
}
