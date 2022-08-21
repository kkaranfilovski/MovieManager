﻿using System.ComponentModel.DataAnnotations;

namespace MovieManager.ServiceModels.MovieModels
{
    public class EditMovieDto
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int? Year { get; set; }
        public string? Genre { get; set; }
    }
}
