using SchoolManager.Domain.Model;

namespace SchoolManager.Domain.Interfaces.Services
{
    public interface IUserService
    {
        Task<User> AuthenticateAsync(string email, string password);
    }
}
