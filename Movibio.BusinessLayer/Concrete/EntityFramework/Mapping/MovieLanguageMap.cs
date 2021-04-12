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
    public class MovieLanguageMap : IEntityTypeConfiguration<MovieLanguage>
    {
        public void Configure(EntityTypeBuilder<MovieLanguage> builder)
        {
            builder.HasKey(ml => new { ml.MovieId, ml.LanguageId });
            builder.HasOne<Movie>(ml => ml.Movie)
                .WithMany(m => m.MovieLanguages).OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(ml => ml.MovieId);

            builder.HasOne<Language>(ml => ml.Language)
                .WithMany(l => l.MovieLanguages).OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(ml => ml.LanguageId);

            builder.ToTable("MovieLanguages");
        }
    }
}
