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
    public class CastMap : IEntityTypeConfiguration<Cast>
    {
        public void Configure(EntityTypeBuilder<Cast> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.FirstName).HasMaxLength(100);
            builder.Property(c => c.FirstName).IsRequired();
            builder.Property(c => c.LastName).HasMaxLength(150);
            builder.Property(c => c.LastName).IsRequired();
            builder.Property(c => c.BirthCountry).HasMaxLength(100);
            builder.Property(c => c.BirthCity).HasMaxLength(100);
            builder.Property(c => c.Biography).HasMaxLength(300);
            builder.Property(c => c.PicturePath).HasMaxLength(500);
            builder.Property(c => c.CreatedByUserName).IsRequired();
            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.ModifiedByUserName).IsRequired();
            builder.Property(c => c.ModifiedDate).IsRequired();


            builder.ToTable("Casts");
        }
    }
}
