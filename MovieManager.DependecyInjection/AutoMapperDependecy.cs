using Microsoft.Extensions.DependencyInjection;
using MovieManager.Helpers.Mappers;


namespace MovieManager.DependecyInjection
{
    public static class AutoMapperDependecy
    {
        public static IServiceCollection RegisterAutoMapperDependecy(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MovieMapper));

            return services;
        }
    }
}
