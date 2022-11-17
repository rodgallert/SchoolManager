using SchoolManager.Data.Repositories;
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
    public class StudentActivityService : IStudentActivityService
    {
        private readonly IStudentActivityRepository _repository;

        public StudentActivityService(IStudentActivityRepository repository)
        {
            _repository = repository;
        }

        public async Task<StudentActivity> GetByIdAsync(string id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<ICollection<StudentActivity>> GetByStudentIdAsync(string studentId)
        {
            return await _repository.GetByStudentIdAsync(studentId);
        }
    }
}
