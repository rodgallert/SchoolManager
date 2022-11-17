using SchoolManager.Domain.Model;

namespace SchoolManager.Domain.Interfaces.Services
{
    public interface IUserService
    {
        User AuthenticateAsync(string email, string password);
    }
}
