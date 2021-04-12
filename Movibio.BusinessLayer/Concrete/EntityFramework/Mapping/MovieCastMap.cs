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
    public class MovieCastMap : IEntityTypeConfiguration<MovieCast>
    {
        public void Configure(EntityTypeBuilder<MovieCast> builder)
        {
            builder.HasKey(mc => new { mc.MovieId, mc.CastId });

            builder.HasOne<Movie>(mc => mc.Movie)
                .WithMany(m => m.MovieCasts).OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(mc => mc.MovieId);

            builder.HasOne<Cast>(mc => mc.Cast)
                .WithMany(c => c.MovieCasts).OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(mc => mc.CastId);

            builder.ToTable("MovieCasts");
        }
    }
}
