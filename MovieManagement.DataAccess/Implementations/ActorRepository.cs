using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieManagement.DataAccess.Context;
using MovieManagement.Domain.Entities;
using MovieManagement.Domain.Repository;

namespace MovieManagement.DataAccess.Implementations;

public class ActorRepository : GenericRepository<Actor>, IActorRepository
{
    public ActorRepository(MovieManagementDbContext context) : base(context)
    {
    }

    public IEnumerable<Actor> GetActorsWithMovies()
    {
        var actorsWithMovies = _context.Actors.Include(x => x.Movies).ToList();
        return actorsWithMovies;
    }
}
