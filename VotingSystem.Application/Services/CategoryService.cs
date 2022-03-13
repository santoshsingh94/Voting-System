using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingSystem.Application.SeedWorks;
using VotingSystem.Application.Services.Interfaces;
using VotingSystem.Entity.Entities;
using VotingSystem.Infrastructure.SeedWorks;

namespace VotingSystem.Application.Services
{
    public class CategoryService : BaseService, ICategoryService
    {
        private readonly IRepository<Category> _repository;

        public CategoryService(IUnitOfWork unitOfWork, IRepository<Category> repository) : base(unitOfWork)
        {
            _repository = repository;
        }
        public async Task<List<Category>> GetAll()
        {
            return await _repository.GetAllAsync();
        }
        public async Task<Category> Get(int id)
        {
            return await _repository.GetAsync(id);
        }
        public async Task<Category> Add(Category category)
        {
            _repository.Add(category);
            await UnitOfWork.SaveChangeAsync();
            return category;
        }       

        public async Task Remove(int id)
        {
            var category = await _repository.GetAsync(id);
            if (category != null)
            {
                _repository.Delete(category);
                await UnitOfWork.SaveChangeAsync();
            }
        }
    }
}
