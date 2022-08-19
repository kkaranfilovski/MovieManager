using AutoMapper;
using MovieManager.Domain.Models;
using MovieManager.ServiceModels.MovieModels;

namespace MovieManager.Helpers.Mappers
{
    public class MovieMapper : Profile
    {
        public MovieMapper()
        {
            CreateMap<Movie, MovieDto>()
                .ForMember(dest => dest.Genre, opt => opt.MapFrom(x => x.Genre.ToString())).ReverseMap();

            CreateMap<Movie, AddMovieDto>()
                .ForMember(dest => dest.Genre, opt => opt.MapFrom(x => x.Genre.ToString())).ReverseMap();
        }
    }
}
