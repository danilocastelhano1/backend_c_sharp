using Interfaces;
using Services;
using Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Injection
{
    public class Injector
    {
        public static void RegisterServices(IServiceCollection services) 
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            //Repository
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IPostsRepository, PostRepository>();

            //Services
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IPostsService, PostService>();
        }
    }
}
