using EntityProject.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityProject.Configurations
{
    public class FilmeCategoriaConfiguration : IEntityTypeConfiguration<FilmeCategoria>
    {
        public void Configure(EntityTypeBuilder<FilmeCategoria> builder)
        {
            builder.ToTable("film_category");

            builder.Property<int>("film_id").IsRequired();
            builder.Property<byte>("category_id").IsRequired();
            builder.Property<DateTime>("last_update").HasColumnType("datetime").HasDefaultValueSql("getdate()").IsRequired();
            builder.HasKey("category_id", "film_id");

            builder.HasOne(_ => _.Filme).WithMany(_ => _.FilmeCategorias).HasForeignKey("film_id");
            builder.HasOne(_ => _.Categoria).WithMany(_ => _.FilmeCategorias).HasForeignKey("category_id");
        }
    }
}
