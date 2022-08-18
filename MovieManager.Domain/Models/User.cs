using MovieManager.Domain.Enums;

namespace MovieManager.Domain.Models
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Genre FavoriteGenre { get; set; }
        public List<MovieUser> MovieList { get; set; }
    }
}
