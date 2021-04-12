using Movibio.SharedLayer.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movibio.DataLayer.Concrete
{
    public class MovieCast : IEntity
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int CastId { get; set; }
        public Cast Cast { get; set; }
    }
}
