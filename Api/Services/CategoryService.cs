using DTOs;
using Interfaces;
using Models;


namespace Services
{
    public class CategoryService : BaseService<Category>, ICategoryService
    {
        public readonly IPostsRepository _postRepository;
        public readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository,
                                IPostsRepository postRepository) : base(categoryRepository)
        {
            _categoryRepository = categoryRepository;
            _postRepository = postRepository;
        }

        public CategoryDTO GetByIdWithPosts(int id)
        {
            var cat = _categoryRepository.GetById(id);
            if (cat != null)
            {
                return new CategoryDTO()
                {
                    ID = cat.ID,
                    Title = cat.Title,
                    Posts = _postRepository.GetPostsByCategory(id)
                };
            }
            else
            {
                return null;
            }
        }
    }
}
