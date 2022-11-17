﻿using SchoolManager.Domain.Interfaces.Repositories;
using SchoolManager.Domain.Interfaces.Services;
using SchoolManager.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManager.Services.AppServices
{
    public class ClassService : IClassService
    {
        private readonly IClassRepository _repository;

        public ClassService(IClassRepository repository)
        {
            _repository = repository;
        }

        public async Task<ICollection<Class>> GetAllActiveAsync()
        {
            return await _repository.GetAllActiveAsync();
        }

        public async Task<Class> GetByIdAsync(string id)
        {
            return await _repository.GetByIdAsync(id);
        }
    }
}
