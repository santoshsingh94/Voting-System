using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingSystem.Entity.Entities;

namespace VotingSystem.Application.Services.Interfaces
{
    public interface ICategoryService
    {
        public Task<List<Category>> GetAll();
        public Task<Category> Get(int id);
        public Task<Category> Add(Category category);
        public Task Remove(int id);
    }
}
