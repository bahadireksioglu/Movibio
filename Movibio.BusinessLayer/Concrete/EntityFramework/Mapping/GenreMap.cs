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
    public class GenreMap : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasKey(g => g.Id);
            builder.Property(g => g.Id).ValueGeneratedOnAdd();
            builder.Property(g => g.Name).HasMaxLength(100);
            builder.Property(g => g.Name).IsRequired();
            builder.Property(g => g.CreatedByUserName).IsRequired();
            builder.Property(g => g.CreatedDate).IsRequired();
            builder.Property(g => g.ModifiedByUserName).IsRequired();
            builder.Property(g => g.ModifiedDate).IsRequired();

            builder.ToTable("Genres");
        }
    }
}
