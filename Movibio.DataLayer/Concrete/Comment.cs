using Movibio.SharedLayer.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movibio.DataLayer.Concrete
{
    public class Comment : EntityBase, IEntity
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public string Content { get; set; }
        public int Score { get; set; }
    }
}
