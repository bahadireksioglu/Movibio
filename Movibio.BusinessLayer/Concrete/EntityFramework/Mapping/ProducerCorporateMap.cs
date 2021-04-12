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
    public class ProducerCorporateMap : IEntityTypeConfiguration<ProducerCorporate>
    {
        public void Configure(EntityTypeBuilder<ProducerCorporate> builder)
        {

            builder.HasKey(pc => pc.Id);
            builder.Property(pc => pc.Id).ValueGeneratedOnAdd();
            builder.Property(pc => pc.Name).HasMaxLength(250);
            builder.Property(pc => pc.Name).IsRequired();

            builder.HasOne(pc => pc.Producer)
                .WithOne(p => p.ProducerCorporate).OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey<ProducerCorporate>(pc => pc.ProducerId);

            builder.ToTable("ProducerCorporate");
        }
    }
}
