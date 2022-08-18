using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieManager.ServiceModels.MovieModels;
using MovieManager.Services.Interfaces;

namespace MovieManager.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]

    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet("/all")]
        public ActionResult<IEnumerable<MovieDto>> GetAllMovies()
        {
            try
            {
                var movies = _movieService.GetAllMovies();
                return Ok(movies);   
            }
            catch (Exception ex)
            {
                return NotFound();
                throw;
            }
        }

        [HttpGet("/{id}")]
        public ActionResult<MovieDto> GetMovieById(int id)
        {
            try
            {
                var movie = _movieService.GetMovieById(id);
                return Ok(movie);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
