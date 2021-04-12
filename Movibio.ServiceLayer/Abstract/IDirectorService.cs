using Movibio.DataLayer.Concrete;
using Movibio.DataLayer.Dtos.DirectorDtos;
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
        Task<IDataResult<Director>> Insert(DirectorInsertDto directorInsertDto);
        Task<IDataResult<Director>> Update(DirectorUpdateDto directorUpdateDto);
        Task<IDataResult<Director>> Delete(int directorId);
    }
}
