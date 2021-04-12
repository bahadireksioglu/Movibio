using Movibio.DataLayer.Concrete;
using Movibio.SharedLayer.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movibio.ServiceLayer.Abstract
{
    public interface IProducerService
    {
        Task<IDataResult<Producer>> Get(int producerId);
        Task<IDataResult<IList<Producer>>> GetAll();
        Task<IDataResult<IList<Producer>>> GetAllByCorporate();
        Task<IDataResult<IList<Producer>>> GetAllByIndividual();
        Task<IDataResult<Producer>> Insert(Producer producer);
        Task<IDataResult<Producer>> Update(Producer producer);
        Task<IDataResult<Producer>> Delete(Producer caproducerst);
    }
}
