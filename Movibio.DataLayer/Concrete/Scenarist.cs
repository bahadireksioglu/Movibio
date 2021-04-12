using Movibio.SharedLayer.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movibio.DataLayer.Concrete
{
    public class Scenarist : EntityBase, IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthCountry { get; set; }
        public string BirthCity { get; set; }
        public string Biography { get; set; }
        public string PicturePath { get; set; }
        public ICollection<MovieScenarist> MovieScenarists { get; set; }

    }
}
