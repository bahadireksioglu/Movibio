using Movibio.SharedLayer.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movibio.DataLayer.Concrete
{
    public class MovieProducer : IEntity
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int ProducerId { get; set; }
        public Producer Producer { get; set; }       
    }
}
