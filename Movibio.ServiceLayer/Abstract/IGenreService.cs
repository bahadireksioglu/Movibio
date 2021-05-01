using Movibio.DataLayer.Concrete;
using Movibio.SharedLayer.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movibio.ServiceLayer.Abstract
{
    public interface IGenreService
    {
        Task<IDataResult<Genre>> Get(int genreId);
        Task<IDataResult<IList<Genre>>> GetAll();
    }
}
