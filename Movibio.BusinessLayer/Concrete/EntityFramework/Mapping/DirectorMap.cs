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
    public class DirectorMap : IEntityTypeConfiguration<Director>
    {
        public void Configure(EntityTypeBuilder<Director> builder)
        {
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Id).ValueGeneratedOnAdd();
            builder.Property(d => d.FirstName).HasMaxLength(100);
            builder.Property(d => d.FirstName).IsRequired();
            builder.Property(d => d.LastName).HasMaxLength(150);
            builder.Property(d => d.LastName).IsRequired();
            builder.Property(d => d.BirthCountry).HasMaxLength(100);
            builder.Property(d => d.BirthCity).HasMaxLength(100);
            builder.Property(d => d.Biography).HasMaxLength(300);
            builder.Property(d => d.PicturePath).HasMaxLength(500);
            builder.Property(d => d.CreatedByUserName).IsRequired();
            builder.Property(d => d.CreatedDate).IsRequired();
            builder.Property(d => d.ModifiedByUserName).IsRequired();
            builder.Property(d => d.ModifiedDate).IsRequired();

            builder.ToTable("Directors");
        }
    }
}
