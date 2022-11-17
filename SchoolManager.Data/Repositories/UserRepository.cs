using Microsoft.EntityFrameworkCore;
using SchoolManager.Data.Context;
using SchoolManager.Domain.Interfaces.Repositories;
using SchoolManager.Domain.Model;

namespace SchoolManager.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly SchoolManagerContext _context;

        public UserRepository(SchoolManagerContext context)
        {
            _context = context;
        }

        public async Task<User> AuthenticateAsync(string email, string password)
        {
            return await _context.User.Where(x => x.Email == email && x.Password == password).FirstOrDefaultAsync();
        }
    }
}
