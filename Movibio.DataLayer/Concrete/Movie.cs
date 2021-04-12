using Movibio.SharedLayer.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movibio.DataLayer.Concrete
{
    public class Movie : EntityBase, IEntity
    {        
        public string Name { get; set; }
        public string PosterPath { get; set; }
        public string Subject { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal AverageScore { get; set; }
        public int CommentCount { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Picture> Pictures { get; set; }
        public ICollection<Trailer> Trailers { get; set; }
        public ICollection<MovieCast> MovieCasts { get; set; }
        public ICollection<MovieDirector> MovieDirectors { get; set; }
        public ICollection<MovieGenre> MovieGenres { get; set; }
        public ICollection<MovieLanguage> MovieLanguages { get; set; }
        public ICollection<MovieProducer> MovieProducers { get; set; }
        public ICollection<MovieScenarist> MovieScenarists { get; set; }
    }
}
