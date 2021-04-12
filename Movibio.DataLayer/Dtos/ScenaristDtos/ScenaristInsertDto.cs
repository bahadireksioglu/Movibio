using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movibio.DataLayer.Dtos.ScenaristDtos
{
    public class ScenaristInsertDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthCountry { get; set; }
        public string BirthCity { get; set; }
        public string Biography { get; set; }
        public string PicturePath { get; set; }
        public string ModifiedByUserName { get; set; }
        public string CreatedByUserName { get; set; }
        public IFormFile Picture { get; set; }
    }
}
