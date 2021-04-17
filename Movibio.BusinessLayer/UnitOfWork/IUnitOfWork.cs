
using Movibio.BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movibio.BusinessLayer.UnitOfWork
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IMovieRepository Movies { get; }
        ICastRepository Casts { get; }
        IDirectorRepository Directors { get; }
        IGenreRepository Genres { get; }
        ILanguageRepository Languages { get; }
        IScenaristRepository Scenarists { get; }
        ICommentRepository Comments { get; }
        ITrailerRepository Trailers { get; }
        IPictureRepository Pictures { get; }      
        IMovieCastRepository MovieCasts { get; }
        IMovieDirectorRepository MovieDirectors { get; }
        IMovieGenreRepository MovieGenres { get; }
        IMovieLanguageRepository MovieLanguages { get; }
        IMovieScenaristRepository MovieScenarists { get; }
        Task<int> SaveAsync();
    }
}
