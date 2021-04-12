using Movibio.DataLayer.Concrete;
using Movibio.DataLayer.Dtos.CastDtos;
using Movibio.SharedLayer.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movibio.ServiceLayer.Abstract
{
    public interface ICastService
    {
        Task<IDataResult<Cast>> Get(int castId);
        Task<IDataResult<IList<Cast>>> GetAll();
        Task<IDataResult<Cast>> Insert(CastInsertDto castInsertDto);
        Task<IDataResult<Cast>> Update(CastUpdateDto castUpdateDto);
        Task<IDataResult<Cast>> Delete(int castId);
    }
}
