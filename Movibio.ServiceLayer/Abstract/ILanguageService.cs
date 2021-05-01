using Movibio.DataLayer.Concrete;
using Movibio.SharedLayer.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movibio.ServiceLayer.Abstract
{
    public interface ILanguageService
    {
        Task<IDataResult<Language>> Get(int genreId);
        Task<IDataResult<IList<Language>>> GetAll();
    }
}
