using Microsoft.EntityFrameworkCore;
using Movibio.SharedLayer.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movibio.DataLayer.Concrete
{
    public class MovieScenarist : IEntity
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int ScenaristId { get; set; }
        public Scenarist Scenarist { get; set; }
    }
}
