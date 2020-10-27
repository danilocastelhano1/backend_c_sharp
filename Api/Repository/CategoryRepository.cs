using Interfaces;
using Models;
using ApiInfra.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApiContext ctx) : base(ctx)
        {
        }
    }
}
