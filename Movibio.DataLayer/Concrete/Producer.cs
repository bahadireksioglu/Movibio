using Movibio.SharedLayer.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movibio.DataLayer.Concrete
{
    public class Producer : EntityBase, IEntity
    {
        
        public string PicturePath { get; set; }
        public ProducerCorporate ProducerCorporate { get; set; }
        public ProducerIndividual ProducerIndividual { get; set; }
        public ICollection<MovieProducer> MovieProducers { get; set; }
    }
}
