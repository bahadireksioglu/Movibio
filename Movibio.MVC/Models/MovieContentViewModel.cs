using Movibio.DataLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movibio.MVC.Models
{
    public class MovieContentViewModel
    {
        public Movie Movie { get; set; }
        public User User { get; set; }
    }
}
