using Movibio.DataLayer.Concrete;
using Movibio.DataLayer.Dtos.ScenaristDtos;
using Movibio.SharedLayer.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movibio.ServiceLayer.Abstract
{
    public interface IScenaristService
    {
        Task<IDataResult<Scenarist>> Get(int scenaristId);
        Task<IDataResult<IList<Scenarist>>> GetAll();
        Task<IDataResult<Scenarist>> Insert(ScenaristInsertDto scenaristInsertDto);
        Task<IDataResult<Scenarist>> Update(ScenaristUpdateDto scenaristUpdateDto);
        Task<IDataResult<Scenarist>> Delete(int scenaristId);
    }
}
