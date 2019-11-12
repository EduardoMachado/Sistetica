using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistetica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistetica.Infra.Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Cpf)
                .IsRequired()
                .HasColumnName("Cpf");

            builder.Property(c => c.DataAniversario)
                .IsRequired()
                .HasColumnName("BirthDate");

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnName("Name");
        }
                
    }
}
