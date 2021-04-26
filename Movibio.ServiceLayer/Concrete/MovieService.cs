using Movibio.BusinessLayer.UnitOfWork;
using Movibio.DataLayer.Concrete;
using Movibio.ServiceLayer.Abstract;
using Movibio.SharedLayer.Utilities.Results.Abstract;
using Movibio.SharedLayer.Utilities.Results.ComplexTypes;
using Movibio.SharedLayer.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movibio.ServiceLayer.Concrete
{
    public class MovieService : IMovieService
    {
        private readonly IUnitOfWork _unitOfWork;
        public MovieService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IDataResult<Movie>> Get(int movieId)
        {
            var movie = await _unitOfWork.Movies.GetAsync(m =>
                 m.Id == movieId, m=>m.Comments);

            if (movie != null)
            {

                var movieCasts = await _unitOfWork.MovieCasts.GetAllAsync(m => m.MovieId == movieId, m => m.Cast);
                var movieDirectors = await _unitOfWork.MovieDirectors.GetAllAsync(m => m.MovieId == movieId, m => m.Director);
                var movieScenarists = await _unitOfWork.MovieScenarists.GetAllAsync(m => m.MovieId == movieId, m => m.Scenarist);
                movie.MovieCasts = movieCasts;
                movie.MovieDirectors = movieDirectors;
                movie.MovieScenarists = movieScenarists;
                return new DataResult<Movie>(ResultStatus.Success, movie);
            }

            return new DataResult<Movie>(ResultStatus.Error);
        }

        public async Task<IDataResult<Movie>> GetByName(string movieName)
        {
            var movie = await _unitOfWork.Movies.GetAsync(m =>
                 m.Name == movieName, m => m.Comments);

            if (movie != null)
            {

                var movieCasts = await _unitOfWork.MovieCasts.GetAllAsync(m => m.MovieId == movie.Id, m => m.Cast);
                var movieDirectors = await _unitOfWork.MovieDirectors.GetAllAsync(m => m.MovieId == movie.Id, m => m.Director);
                var movieScenarists = await _unitOfWork.MovieScenarists.GetAllAsync(m => m.MovieId == movie.Id, m => m.Scenarist);
                movie.MovieCasts = movieCasts;
                movie.MovieDirectors = movieDirectors;
                movie.MovieScenarists = movieScenarists;
                return new DataResult<Movie>(ResultStatus.Success, movie);
            }

            return new DataResult<Movie>(ResultStatus.Error);
        }
        public async Task<IDataResult<IList<Movie>>> GetAll()
        {
            var movies = await _unitOfWork.Movies.GetAllAsync(null);

            if (movies.Count > 0)
                return new DataResult<IList<Movie>>(ResultStatus.Success, movies);
            return new DataResult<IList<Movie>>(ResultStatus.Error);
        }

        public async Task<IDataResult<Movie>> Insert(Movie movie)
        {

            await _unitOfWork.Movies.InsertAsync(movie);
            await _unitOfWork.SaveAsync();
            return new DataResult<Movie>(ResultStatus.Success, movie);
        }

        public async Task<IDataResult<Movie>> Update(Movie movie)
        {
            await _unitOfWork.Movies.UpdateAsync(movie);
            await _unitOfWork.SaveAsync();
            return new DataResult<Movie>(ResultStatus.Success, movie);
        }
        public async Task<IDataResult<Movie>> Delete(Movie movie)
        {
            await _unitOfWork.Movies.DeleteAsync(movie);
            await _unitOfWork.SaveAsync();
            return new DataResult<Movie>(ResultStatus.Success, movie);
        }

        public async Task<IDataResult<Movie>> UpdateAvgScore(int movieId, int score)
        {
            var movie = await _unitOfWork.Movies.GetAsync(m=>m.Id==movieId);
            var totalScore = movie.AverageScore * movie.CommentCount;
            totalScore += score;
            movie.CommentCount++;
            movie.AverageScore = totalScore / movie.CommentCount;

            var updatedMovie = await _unitOfWork.Movies.UpdateAsync(movie);
            await _unitOfWork.SaveAsync();
            if (updatedMovie != null)
                return new DataResult<Movie>(ResultStatus.Success);
            return new DataResult<Movie>(ResultStatus.Error);
        }

    }
}
