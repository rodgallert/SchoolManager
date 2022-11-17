using Microsoft.EntityFrameworkCore;
using SchoolManager.Data.Context;
using SchoolManager.Domain.Interfaces.Repositories;
using SchoolManager.Domain.Model;

namespace SchoolManager.Data.Repositories
{
    public class UserTypeRepository : IUserTypeRepository
    {
        private readonly SchoolManagerContext _context;

        public UserTypeRepository(SchoolManagerContext context)
        {
            _context = context;
        }

        public async Task<UserType> GetByIdAsync(string id)
        {
            return await _context.UserType.Where(x => x.Id == new Guid(id)).FirstOrDefaultAsync();
        }

        public async Task<UserType> GetByUserIdAsync(string userId)
        {
            return await _context.User.Where(x => x.Id == new Guid(userId)).Select(x => x.UserType).FirstOrDefaultAsync();
        }
    }
}
