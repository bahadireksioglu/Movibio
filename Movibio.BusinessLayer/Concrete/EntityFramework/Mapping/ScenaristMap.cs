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
    public class ScenaristMap : IEntityTypeConfiguration<Scenarist>
    {
        public void Configure(EntityTypeBuilder<Scenarist> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Id).ValueGeneratedOnAdd();
            builder.Property(s => s.FirstName).HasMaxLength(100);
            builder.Property(s => s.FirstName).IsRequired();
            builder.Property(s => s.LastName).HasMaxLength(150);
            builder.Property(s => s.LastName).IsRequired();
            builder.Property(s => s.BirthCountry).HasMaxLength(100);
            builder.Property(s => s.BirthCity).HasMaxLength(100);
            builder.Property(s => s.Biography).HasMaxLength(300);
            builder.Property(s => s.PicturePath).HasMaxLength(500);
            builder.Property(s => s.CreatedByUserName).IsRequired();
            builder.Property(s => s.CreatedDate).IsRequired();
            builder.Property(s => s.ModifiedByUserName).IsRequired();
            builder.Property(s => s.ModifiedDate).IsRequired();


            builder.ToTable("Scenarists");
        }
    }
}
