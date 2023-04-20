using System;
namespace MovieManagement.Domain.Repository
{
	public interface IUnitOfWork : IDisposable
	{
		IActorRepository ActorRepository { get; }
		IMovieRepository MovieRepository { get; }
		IGenreRepository GenericRepository { get; }
		IBiographyRepository BiographyReposioty { get; }
		int Save();
	}
}

