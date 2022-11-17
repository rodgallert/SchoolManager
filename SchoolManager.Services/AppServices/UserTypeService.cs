using SchoolManager.Domain.Interfaces.Repositories;
using SchoolManager.Domain.Interfaces.Services;
using SchoolManager.Domain.Model;

namespace SchoolManager.Services.AppServices
{
    public class UserTypeService : IUserTypeService
    {
        private readonly IUserTypeRepository _repository;

        public UserTypeService(IUserTypeRepository repository)
        {
            _repository = repository;
        }

        public async Task<UserType> GetByIdAsync(string id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<UserType> GetByUserIdAsync(string userId)
        {
            return await _repository.GetByUserIdAsync(userId);
        }
    }
}
