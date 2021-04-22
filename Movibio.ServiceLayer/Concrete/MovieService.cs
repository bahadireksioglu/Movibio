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
            var movie= await _unitOfWork.Movies.GetAsync(m =>
                m.Id == movieId);

            if (movie != null)
                return new DataResult<Movie>(ResultStatus.Success);

            return new DataResult<Movie>(ResultStatus.Error);
        }

        public async Task<IDataResult<IList<Movie>>> GetAll()
        {
            var movies = await _unitOfWork.Movies.GetAllAsync(null);

            if (movies.Count > 0)
                return new DataResult<IList<Movie>> (ResultStatus.Success, movies);
            return new DataResult<IList<Movie>> (ResultStatus.Error);
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
    }
}
