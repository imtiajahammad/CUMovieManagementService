using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieManagement.DataAccess.Context;
using MovieManagement.Domain.Entities;
using MovieManagement.Domain.Repository;

namespace MovieManagement.DataAccess.Implementations;

public class MovieRepository : GenericRepository<Movie>, IMovieRepository
{
    public MovieRepository(MovieManagementDbContext context) : base(context)
    {
    }
}
