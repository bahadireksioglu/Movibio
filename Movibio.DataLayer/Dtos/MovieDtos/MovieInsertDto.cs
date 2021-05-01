using Microsoft.AspNetCore.Http;
using Movibio.DataLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movibio.DataLayer.Dtos.MovieDtos
{
    public class MovieInsertDto
    {
        public string Name { get; set; }
        public IFormFile Poster { get; set; }
        public string PosterPath { get; set; }
        public string Subject { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string CreatedByUserName { get; set; }
        public string ModifiedByUserName { get; set; }
        //public ICollection<IFormFile> PictureFiles { get; set; }
        //public ICollection<IFormFile> TrailerFiles { get; set; }
        public ICollection<int> Casts { get; set; }
        public ICollection<int> Directors { get; set; }
        public ICollection<int> Genres { get; set; }
        public ICollection<int> Languages { get; set; }
        public ICollection<int> Scenarists { get; set; }
    }
}
