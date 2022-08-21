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

        [HttpGet("all")]
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
            }
        }

        [HttpGet("{id}")]
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

        [HttpGet("genre/{genre}")]
        public ActionResult<MovieDto> GetMoviesByGenre(string genre)
        {
            try
            {
                var movies = _movieService.GetMovieByGenre(genre);
                return Ok(movies);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("add")]
        public ActionResult<AddMovieDto> AddNewMovie([FromBody] AddMovieDto newMovie)
        {
            if (ModelState.IsValid)
            {
                _movieService.AddMovie(newMovie);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}/edit")]
        public ActionResult<EditMovieDto> EditMovie(int id, [FromBody] EditMovieDto editMovie)
        {
            try
            {
                _movieService.UpdateMovie(id, editMovie);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("delete/id/{id}")]
        public ActionResult<MovieDto> DeleteMovie(int id)
        {
            try
            {
                _movieService.DeleteMovie(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
