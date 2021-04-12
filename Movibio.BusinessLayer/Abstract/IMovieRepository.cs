using Movibio.DataLayer.Concrete;
using Movibio.SharedLayer.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movibio.BusinessLayer.Abstract
{
    public interface IMovieRepository : IEntityRepository<Movie>
    {
    }
}
