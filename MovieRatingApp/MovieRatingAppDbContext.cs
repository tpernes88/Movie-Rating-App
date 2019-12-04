using Microsoft.EntityFrameworkCore;
using MovieRatingApp.Data.Entities;

namespace MovieRatingApp.Data
{
    public class MovieRatingAppDbContext : DbContext
    {
        public MovieRatingAppDbContext(DbContextOptions<MovieRatingAppDbContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movie { get; set; }
        public DbSet<Actor> Actor { get; set; }
        public DbSet<Director> Director { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<MovieActor> MovieActor { get; set; }
    }
}
