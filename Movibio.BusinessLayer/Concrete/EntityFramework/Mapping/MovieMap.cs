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
    public class MovieMap : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id).ValueGeneratedOnAdd();
            builder.Property(m => m.Name).HasMaxLength(150);
            builder.Property(m => m.Name).IsRequired();
            builder.Property(m => m.PosterPath).HasMaxLength(500);
            builder.Property(m => m.PosterPath).IsRequired();
            builder.Property(m => m.Subject).HasMaxLength(500);
            builder.Property(m => m.Subject).IsRequired();
            builder.Property(m => m.ReleaseDate).IsRequired();
            builder.Property(m => m.CreatedByUserName).IsRequired();
            builder.Property(m => m.CreatedDate).IsRequired();
            builder.Property(m => m.ModifiedByUserName).IsRequired();
            builder.Property(m => m.ModifiedDate).IsRequired();
            builder.Property(m => m.AverageScore).HasColumnType("DECIMAL(3,2)");
            builder.Property(m => m.AverageScore).IsRequired();
            builder.Property(m => m.CommentCount).IsRequired();

            builder.ToTable("Movies");

        }
    }
}
