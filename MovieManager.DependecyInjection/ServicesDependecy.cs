using Microsoft.Extensions.DependencyInjection;
using MovieManager.Services;
using MovieManager.Services.Interfaces;

namespace MovieManager.DependecyInjection
{
    public static class ServicesDependecy
    {
        public static IServiceCollection RegisterServicesDependency
            (this IServiceCollection services)
        {
            services.AddTransient<IMovieService, MovieService>();

            return services;
        }
    }
}
