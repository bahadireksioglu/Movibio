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
    public class MovieProducerMap : IEntityTypeConfiguration<MovieProducer>
    {
        public void Configure(EntityTypeBuilder<MovieProducer> builder)
        {
            builder.HasKey(mp => new { mp.MovieId, mp.ProducerId });
            builder.HasOne<Movie>(mp => mp.Movie)
                .WithMany(m => m.MovieProducers).OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(mg => mg.MovieId);

            builder.HasOne<Producer>(mp => mp.Producer)
                .WithMany(p => p.MovieProducers).OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(mp => mp.ProducerId);

            builder.ToTable("MovieProducers");
        }
    }
}
