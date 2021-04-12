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
    public class PictureMap : IEntityTypeConfiguration<Picture>
    {
        public void Configure(EntityTypeBuilder<Picture> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.PicturePath).HasMaxLength(500);
            builder.Property(p => p.PicturePath).IsRequired();

            builder.HasOne<Movie>(p => p.Movie).
                WithMany(m => m.Pictures).OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(p => p.MovieId);

            builder.ToTable("Pictures");
        }
    }
}
