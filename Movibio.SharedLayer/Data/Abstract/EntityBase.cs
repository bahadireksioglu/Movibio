using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movibio.SharedLayer.Data.Abstract
{
    public abstract class EntityBase
    {
        public virtual int Id { get; set; }
        public virtual string CreatedByUserName { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual string ModifiedByUserName { get; set; }
        public virtual DateTime ModifiedDate { get; set; } = DateTime.Now;
    }
}
