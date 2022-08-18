using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieManager.DataAccess.Data;

namespace MovieManager.DependecyInjection
{
    public static class DbContextDependecy
    {
        public static IServiceCollection RegisterDbContextDependecy(this IServiceCollection services, string connString)
        {
            services.AddDbContext<MovieManagerDbContext>(options =>
                options.UseSqlServer(connString));

            return services;
        }
    }
}
