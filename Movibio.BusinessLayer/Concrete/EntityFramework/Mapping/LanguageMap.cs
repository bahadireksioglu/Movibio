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
    public class LanguageMap : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.HasKey(l => l.Id);
            builder.Property(l => l.Id).ValueGeneratedOnAdd();
            builder.Property(l => l.Name).HasMaxLength(100);
            builder.Property(l => l.Name).IsRequired();
            builder.Property(l => l.CreatedByUserName).IsRequired();
            builder.Property(l => l.CreatedDate).IsRequired();
            builder.Property(l => l.ModifiedByUserName).IsRequired();
            builder.Property(l => l.ModifiedDate).IsRequired();

            builder.ToTable("Languages");
        }
    }
}
