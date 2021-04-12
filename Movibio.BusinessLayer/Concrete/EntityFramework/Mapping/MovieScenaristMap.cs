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
    public class MovieScenaristMap : IEntityTypeConfiguration<MovieScenarist>
    {
        public void Configure(EntityTypeBuilder<MovieScenarist> builder)
        {
            builder.HasKey(ms => new { ms.MovieId, ms.ScenaristId });
            builder.HasOne<Movie>(ms => ms.Movie)
                .WithMany(m => m.MovieScenarists)
                .HasForeignKey(ms => ms.MovieId);

            builder.HasOne<Scenarist>(ms => ms.Scenarist)
                .WithMany(s => s.MovieScenarists)
                .HasForeignKey(ms => ms.ScenaristId);

            builder.ToTable("MovieScenarists");
        }
    }
}
