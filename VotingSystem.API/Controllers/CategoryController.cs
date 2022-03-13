using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VotingSystem.Application.Services.Interfaces;
using VotingSystem.Entity.Entities;

namespace VotingSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ILogger<CategoryController> _logger;
        private readonly ICategoryService _categoryService;

        public CategoryController(ILogger<CategoryController> logger, ICategoryService categoryService)
        {
            _logger = logger;
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<List<Category>> GetAll()
        {
            _logger.LogInformation($"Getting all Categories");
            return await _categoryService.GetAll();
        }
        [HttpGet("{id}")]
        public async Task<Category> GetById(int id)
        {
            _logger.LogInformation($"Getting Category id {id}");
            return await _categoryService.Get(id);
        }

        [HttpPost]
        public async Task<Category> Create([FromBody] Category product)
        {
            _logger.LogInformation($"Add Category");
            return await _categoryService.Add(product);
        }
    }
}
