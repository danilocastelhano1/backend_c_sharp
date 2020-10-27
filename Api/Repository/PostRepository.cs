using Interfaces;
using Models;
using ApiInfra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class PostRepository : BaseRepository<Post>, IPostsRepository
    {
        public PostRepository(ApiContext ctx) : base(ctx)
        {
        }

        public IEnumerable<Post> GetPostsByCategory(int categoryId)
        {
            return _ctx.Set<Post>().Where(c => c.CategoryID == categoryId);
        }

        public new Post GetById(int id)
        {
            return _ctx.Post.Where(c => c.ID == id).Include(c => c.Category).FirstOrDefault();
        }

        public new IEnumerable<Post> GetAll()
        {
            return _ctx.Post.Include(c => c.Category);
        }

        //public new Post Edit(Post obj)
        //{
        //    return _ctx.Post.Where(c => c.ID == obj.ID).Include(c => c.Category).FirstOrDefault();
        //}
    }
}
