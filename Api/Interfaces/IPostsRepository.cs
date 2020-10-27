using Models;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IPostsRepository: IBaseRepository<Post>
    {
        IEnumerable<Post> GetPostsByCategory(int categoryId);
    }
}
