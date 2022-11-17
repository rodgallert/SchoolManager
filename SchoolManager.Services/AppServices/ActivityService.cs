using SchoolManager.Domain.Interfaces.Repositories;
using SchoolManager.Domain.Interfaces.Services;
using SchoolManager.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManager.Services.AppServices
{
    public class ActivityService : IActivityService
    {
        private readonly IActivityRepository _repository;

        public ActivityService(IActivityRepository repository)
        {
            _repository = repository;
        }

        public async Task<ICollection<Activity>> GetAllActiveAsync()
        {
            return await _repository.GetAllActiveAsync();
        }

        public async Task<Activity> GetByIdAsync(string id)
        {
            return await _repository.GetByIdAsync(id);
        }
    }
}
