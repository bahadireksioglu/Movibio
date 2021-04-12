using Movibio.DataLayer.Concrete;
using Movibio.SharedLayer.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movibio.ServiceLayer.Abstract
{
    public interface IMovieService
    {
        Task<IDataResult<Movie>> Get(int movieId);
        Task<IDataResult<IList<Movie>>> GetAll();
        Task<IDataResult<Movie>> Insert(Movie movie);
        Task<IDataResult<Movie>> Update(Movie movie);
        Task<IDataResult<Movie>> Delete(Movie movie);
    }
}
