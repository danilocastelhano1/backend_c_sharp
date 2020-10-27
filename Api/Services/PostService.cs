using Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class PostService : BaseService<Post>, IPostsService
    {
        private readonly IPostsRepository _postRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PostService(IPostsRepository repository,
                                 ICategoryRepository categoryRepository) : base(repository)
        {
            _postRepository = repository;
            _categoryRepository = categoryRepository;
        }

        public new Post Add(Post post) 
        {
            //Check if Category Exists
            if(_categoryRepository.GetById(post.CategoryID) != null)
            {
                return _postRepository.Add(post);    
            }
            //if not exists return object without updates
            return post;
        }
    }
}
