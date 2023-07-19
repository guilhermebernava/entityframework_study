﻿using EntityProject.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityProject.Configurations
{
    public class IdiomaConfiguration : IEntityTypeConfiguration<Idioma>
    {
        public void Configure(EntityTypeBuilder<Idioma> builder)
        {
            builder.ToTable("language");

            builder.Property(t => t.Id)
                .HasColumnName("language_id")
                .HasColumnType("tinyint")
                .IsRequired();

            builder.Property(x => x.Nome)
               .HasColumnName("name")
               .HasColumnType("char(20)")
               .IsRequired();

            builder.Property<DateTime>("last_update")
              .HasColumnType("datetime")
              .HasDefaultValueSql("getdate()")
              .IsRequired();
        }
    }
}
