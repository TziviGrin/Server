using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using REPOSITORIES;
using REPOSITORIES.Entities;
using REPOSITORIES.Interfaces;
using REPOSITORIES.Repositories;
using SERVICES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICES
{
    public static class Extentions
    {
        public static void AddRepoDependencies(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IChildRepository, ChildRepository>();


            MapperConfiguration config = new MapperConfiguration(
                conf => { conf.CreateMap<User, UserModel>().ReverseMap();
                          conf.CreateMap<Child, ChildModel>().ReverseMap(); });

            IMapper mapper=config.CreateMapper();   
            services.AddSingleton(mapper);

           
           

            services.AddScoped<IDataSource, DataSource>();
            services.AddDbContext<IDataSource, DataSource>();

            services.AddSingleton<IHttpContextAccessor,HttpContextAccessor>();  
        }
    }
}
