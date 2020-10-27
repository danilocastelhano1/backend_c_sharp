using DTOs;
using Models;

namespace Interfaces
{
    public interface ICategoryService : IBaseService<Category>
    {
        CategoryDTO GetByIdWithPosts(int id);
    }
}
