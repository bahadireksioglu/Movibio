using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movibio.DataLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movibio.BusinessLayer.Concrete.EntityFramework.Mapping
{
    public class MovieGenreMap : IEntityTypeConfiguration<MovieGenre>
    {
        public void Configure(EntityTypeBuilder<MovieGenre> builder)
        {

            builder.HasKey(mg => new { mg.MovieId, mg.GenreId });
            builder.HasOne<Movie>(mg => mg.Movie)
                .WithMany(m => m.MovieGenres).OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(mg => mg.MovieId);

            builder.HasOne<Genre>(mg => mg.Genre)
                .WithMany(g => g.MovieGenres).OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(mg => mg.GenreId);

            builder.ToTable("MovieGenres");
        }
    }
}
