using Movibio.BusinessLayer.Abstract;
using Movibio.BusinessLayer.Concrete.EntityFramework.Context;
using Movibio.BusinessLayer.Concrete.EntityFramework.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movibio.BusinessLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly MovibioDbContext _context;
        private readonly MovieRepository _movieRepository;
        private readonly CastRepository _castRepository;
        private readonly DirectorRepository _directorRepository;
        private readonly GenreRepository _genreRepository;
        private readonly LanguageRepository _languageRepository;
        private readonly ScenaristRepository _scenaristRepository;
        private readonly CommentRepository _commentRepository;
        private readonly TrailerRepository _trailerRepository;
        private readonly PictureRepository _pictureRepository;
        private readonly MovieCastRepository _movieCastRepository;
        private readonly MovieDirectorRepository _movieDirectorRepository;
        private readonly MovieGenreRepository _movieGenreRepository;
        private readonly MovieLanguageRepository _movieLanguageRepository;
        private readonly MovieScenaristRepository _movieScenaristRepository;

        public UnitOfWork(MovibioDbContext context)
        {
            _context = context;
        }

        public IMovieRepository Movies => _movieRepository
            ?? new MovieRepository(_context);

        public ICastRepository Casts => _castRepository
            ?? new CastRepository(_context);

        public IDirectorRepository Directors => _directorRepository
            ?? new DirectorRepository(_context);

        public IGenreRepository Genres => _genreRepository
            ?? new GenreRepository(_context);

        public ILanguageRepository Languages => _languageRepository
            ?? new LanguageRepository(_context);

        public IScenaristRepository Scenarists => _scenaristRepository
            ?? new ScenaristRepository(_context);

        public ICommentRepository Comments => _commentRepository
            ?? new CommentRepository(_context);

        public ITrailerRepository Trailers => _trailerRepository
            ?? new TrailerRepository(_context);

        public IPictureRepository Pictures => _pictureRepository
            ?? new PictureRepository(_context);

        public IMovieCastRepository MovieCasts => _movieCastRepository
            ?? new MovieCastRepository(_context);

        public IMovieDirectorRepository MovieDirectors => _movieDirectorRepository
            ?? new MovieDirectorRepository(_context);

        public IMovieGenreRepository MovieGenres => _movieGenreRepository
            ?? new MovieGenreRepository(_context);

        public IMovieLanguageRepository MovieLanguages => _movieLanguageRepository
            ?? new MovieLanguageRepository(_context);

        public IMovieScenaristRepository MovieScenarists => _movieScenaristRepository
            ?? new MovieScenaristRepository(_context);

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
