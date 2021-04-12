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
    public class MovieDirectorMap : IEntityTypeConfiguration<MovieDirector>
    {
        public void Configure(EntityTypeBuilder<MovieDirector> builder)
        {
            builder.HasKey(md => new { md.MovieId, md.DirectorId });

            builder.HasOne<Movie>(md => md.Movie)
                .WithMany(m => m.MovieDirectors).OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(md => md.MovieId);

            builder.HasOne<Director>(md => md.Director)
                .WithMany(d => d.MovieDirectors).OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(md => md.DirectorId);

            builder.ToTable("MovieDirectors");
        }
    }
}
