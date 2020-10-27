using Interfaces;
using Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostsService _postService;
        private readonly ICategoryService _categoryService;
        public PostController(IPostsService postService)
        {
            _postService = postService;
        }


        [HttpGet]
        public IEnumerable<Post> GetAll()
        {
            return _postService.GetAll();
        }

        [HttpGet("{id}")]
        public Post Get(int id)
        {
            return _postService.GetById(id);
        }

        [HttpPost]
        public Post Add(Post cat)
        {
            return _postService.Add(cat);
        }

        [HttpPut]
        public Post Edit(Post cat)
        {
            //var test = _postService.GetById(cat.ID);
            //if (cat.CategoryID == 0)
            //{
            //    cat.CategoryID = test.CategoryID;
            //}
            return _postService.Edit(cat);
        }

        [HttpDelete("{id}")]
        public int Delete(int id)
        {
            return _postService.Delete(id);
        }
    }
}
