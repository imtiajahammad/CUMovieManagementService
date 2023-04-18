using System;
using Microsoft.EntityFrameworkCore;
using MovieManagement.Domain.Entities;

namespace MovieManagement.DataAccess.Context
{
	public class MovieManagementDbContext : DbContext
	{
		public MovieManagementDbContext(DbContextOptions<MovieManagementDbContext> options) : base(options) { }

		public DbSet<Actor> Actors { get; set; }
		public DbSet<Biography> Biographies { get; set; }
		public DbSet<Genre> Genres { get; set; }
		public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			modelBuilder.Entity<Actor>().HasData(
					new Actor { Id = 1, FirstName = "Chuck", LastName = "Norris" }
					, new Actor { Id = 2, FirstName = "Jane", LastName = "Doe" }
					, new Actor { Id = 3, FirstName = "Van", LastName = "Damme" }
				);
			modelBuilder.Entity<Movie>().HasData(
					new Movie { Id = 1, Name = "Wakanda Forever", Description = "Box Office we coming", ActorId = 1 }
					,new Movie { Id = 2, Name = "Wakanda Forever 2", Description = "Box Office we coming", ActorId = 2 }
					,new Movie { Id = 3, Name = "Spiderman", Description = "Sky Scappers be warned", ActorId = 3 }
					,new Movie { Id = 4, Name = "Matrix", Description = "Blue or red pill", ActorId = 3 }
                );
        }
    }
}

