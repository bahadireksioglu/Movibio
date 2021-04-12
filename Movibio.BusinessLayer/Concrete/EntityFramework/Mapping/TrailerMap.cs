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
    public class TrailerMap : IEntityTypeConfiguration<Trailer>
    {
        public void Configure(EntityTypeBuilder<Trailer> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).ValueGeneratedOnAdd();
            builder.Property(t => t.TrailerPath).HasMaxLength(500);
            builder.Property(t => t.TrailerPath).IsRequired();

            builder.HasOne<Movie>(t => t.Movie)
                .WithMany(m => m.Trailers).OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(t => t.MovieId);

            builder.ToTable("Trailers");
        }
    }
}
