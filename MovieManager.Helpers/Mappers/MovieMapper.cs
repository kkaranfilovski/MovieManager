using AutoMapper;
using MovieManager.Domain.Models;
using MovieManager.ServiceModels.MovieModels;

namespace MovieManager.Helpers.Mappers
{
    public class MovieMapper : Profile
    {
        public MovieMapper()
        {
            CreateMap<Movie, MovieDto>();
        }
    }
}
