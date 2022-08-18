using Microsoft.Extensions.DependencyInjection;
using MovieManager.DataAccess.Repositories;
using MovieManager.DataAccess.Repositories.Interfaces;
using MovieManager.Domain.Models;

namespace MovieManager.DependecyInjection
{
    public static class RepositoriesDependecy
    {
        public static IServiceCollection RegisterRepositoriesDependency
           (this IServiceCollection services)
        {
            services.AddTransient<IRepository<Movie>, MovieRepository>();

            return services;
        }
    }
}
