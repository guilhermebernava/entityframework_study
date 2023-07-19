using EntityProject.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityProject.Configurations
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("category");

            builder.Property(_=> _.Id).HasColumnName("category_id").IsRequired();
            builder.Property(_=> _.Nome).HasColumnName("name").HasColumnType("varchar(25)").IsRequired();
            builder
                .Property<DateTime>("last_update")
                .HasColumnType("datetime")
                .HasDefaultValueSql("getdate()")
                .IsRequired();
        }
    }
}
