using DTOs;
using Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models;
using System.Collections.Generic;

namespace Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IEnumerable<Category> GetAll()
        {
            return _categoryService.GetAll();
        }

        [HttpGet("{id}")]
        public Category Get(int id)
        {
            return _categoryService.GetById(id);
        }

        [HttpPost]
        public Category Add(Category cat)
        {
            return _categoryService.Add(cat);
        }

        [HttpPut]
        public Category Edit(Category cat)
        { 
            return _categoryService.Edit(cat);
        }

        [HttpPut("{id}")]
        public Category Edit2(Category cat)
        {
            return _categoryService.Edit(cat);
        }

        [HttpDelete("{id}")]
        public int Delete(int id)
        {
            return _categoryService.Delete(id);
        }

        [HttpGet("{id}/posts")]
        public CategoryDTO GetWithPosts(int id)
        {
            return _categoryService.GetByIdWithPosts(id);
        }
    }
}
