using Microsoft.EntityFrameworkCore;
using MovieManager.Domain.Enums;
using MovieManager.Domain.Models;

namespace MovieManager.DataAccess.Data
{
    public class MovieManagerDbContext : DbContext
    {
        public MovieManagerDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasMany(x => x.MovieList)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);

            builder.Entity<Movie>()
                .HasMany(x => x.UserList)
                .WithOne(x => x.Movie)
                .HasForeignKey(x => x.MovieId);

            builder.Entity<User>()
                .HasData
                (
                    new User
                    {
                        Id = 1,
                        FirstName = "Kristijan",
                        LastName = "Karanfilovski",
                        Username = "kiko",
                        Password = "kiko123",
                        FavoriteGenre = Genre.Fantasy
                    },

                    new User
                    {
                        Id = 2,
                        FirstName = "Ilija",
                        LastName = "Mitev",
                        Username = "ile",
                        Password = "ile123",
                        FavoriteGenre = Genre.Comedy
                    },

                    new User
                    {
                        Id = 3,
                        FirstName = "Trajan",
                        LastName = "Stevkovski",
                        Username = "trajan",
                        Password = "trajan123",
                        FavoriteGenre = Genre.Action
                    }
                );

            builder.Entity<Movie>()
                .HasData
                (
                    new Movie
                    {
                        Id = 1,
                        Title = "Superman",
                        Description = "Scientist Jor-El rockets his infant son, Kal-El, to safety on Earth. Kal is raised as Clark Kent and develops unusual abilities and powers to become Superman who fights for truth and justice.",
                        Genre = Genre.Fantasy,
                        Year = 1978
                    },
                    new Movie
                    {
                        Id = 2,
                        Title = "The Batman",
                        Description = "Batman is called to intervene when the mayor of Gotham City is murdered. Soon, his investigation leads him to uncover a web of corruption, linked to his own dark past.",
                        Genre = Genre.Action,
                        Year = 2022
                    },
                    new Movie
                    {
                        Id = 3,
                        Title = "The Godfather",
                        Description = "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son.",
                        Genre = Genre.Drama,
                        Year = 1972
                    },
                    new Movie
                    {
                        Id = 4,
                        Title = "Rush Hour",
                        Description = "When a Chinese consul's young daughter is kidnapped, Hong Kong Detective Lee must team up with Carter, a loud-mouthed LA detective. Distinctive work styles and cultural differences pose hiccups.",
                        Genre = Genre.Comedy,
                        Year = 1998
                    },
                    new Movie
                    {
                        Id = 5,
                        Title = "The Notebook",
                        Description = "Duke reads the story of Allie and Noah, two lovers who were separated by fate, to Ms Hamilton, an old woman who suffers from dementia, on a daily basis out of his notebook.",
                        Genre = Genre.Romance,
                        Year = 2004
                    },
                    new Movie
                    {
                        Id = 6,
                        Title = "The Conjuring",
                        Description = "The Perron family moves into a farmhouse where they experience paranormal phenomena. They consult demonologists, Ed and Lorraine Warren, to help them get rid of the evil entity haunting them.",
                        Genre = Genre.Horror,
                        Year = 2013
                    },
                    new Movie
                    {
                        Id = 7,
                        Title = "Gone Girl",
                        Description = "Nick Dunne discovers that the entire media focus has shifted on him when his wife, Amy Dunne, mysteriously disappears on the day of their fifth wedding anniversary.",
                        Genre = Genre.Thriller,
                        Year = 2014
                    }
                );

            builder.Entity<MovieUser>()
                .HasData
                (
                    new MovieUser
                    {
                        Id = 1,
                        UserId = 1,
                        MovieId = 1
                    },
                    new MovieUser
                    {
                        Id = 2,
                        UserId = 1,
                        MovieId = 3
                    },
                    new MovieUser
                    {
                        Id = 3,
                        UserId = 2,
                        MovieId = 3
                    },
                    new MovieUser
                    {
                        Id = 4,
                        UserId = 2,
                        MovieId = 4
                    },
                    new MovieUser
                    {
                        Id = 5,
                        UserId = 3,
                        MovieId = 5
                    }
                );


        }
    }
}
