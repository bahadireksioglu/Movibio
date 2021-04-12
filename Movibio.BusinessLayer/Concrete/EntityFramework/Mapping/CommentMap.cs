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
    public class CommentMap : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Content).HasMaxLength(500);
            builder.Property(c => c.Content).IsRequired();
            builder.Property(c => c.Score).IsRequired();
            builder.Property(c => c.CreatedByUserName).IsRequired();
            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.ModifiedByUserName).IsRequired();
            builder.Property(c => c.ModifiedDate).IsRequired();

            builder.HasOne<Movie>(c => c.Movie)
                .WithMany(m => m.Comments).OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(c => c.MovieId);

            builder.ToTable("Comments");        
        }
    }
}
