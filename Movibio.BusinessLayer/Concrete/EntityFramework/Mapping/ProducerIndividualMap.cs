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
    public class ProducerIndividualMap : IEntityTypeConfiguration<ProducerIndividual>
    {
        public void Configure(EntityTypeBuilder<ProducerIndividual> builder)
        {

            builder.HasKey(pi => pi.Id);
            builder.Property(pi => pi.Id).ValueGeneratedOnAdd();
            builder.Property(pi => pi.FirstName).HasMaxLength(100);
            builder.Property(pi => pi.FirstName).IsRequired();
            builder.Property(pi => pi.LastName).HasMaxLength(150);
            builder.Property(pi => pi.LastName).IsRequired();

            builder.HasOne(pi => pi.Producer)
                .WithOne(p => p.ProducerIndividual).OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey<ProducerIndividual>(pi => pi.ProducerId);

            builder.ToTable("ProducerIndividual");
        }
    }
}
