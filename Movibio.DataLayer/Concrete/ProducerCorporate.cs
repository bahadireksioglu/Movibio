using Movibio.SharedLayer.Data.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movibio.DataLayer.Concrete
{
    public class ProducerCorporate : IEntity
    {
        
        public int Id { get; set; }
        public int ProducerId { get; set; }
        public Producer Producer { get; set; }
        public string Name { get; set; }
    }
}
