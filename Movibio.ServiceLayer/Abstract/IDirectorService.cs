using Movibio.DataLayer.Concrete;
using Movibio.SharedLayer.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movibio.ServiceLayer.Abstract
{
    public interface IDirectorService
    {
        Task<IDataResult<Director>> Get(int directorId);
        Task<IDataResult<IList<Director>>> GetAll();
        Task<IDataResult<Director>> Insert(Director director);
        Task<IDataResult<Director>> Update(Director director);
        Task<IDataResult<Director>> Delete(Director director);
    }
}
