using EntityProject.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityProject.Configurations
{
    public class FilmeConfiguration : IEntityTypeConfiguration<Filme>
    {
        public void Configure(EntityTypeBuilder<Filme> builder)
        {
            builder.ToTable("film");

            builder.Property(t => t.Id).HasColumnName("film_id");

            builder.Property(x => x.Titulo)
                .HasColumnName("title")
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder.Property(x => x.Descricao)
               .HasColumnName("description")
               .HasColumnType("text");

            builder.Property(x => x.AnoLancamento)
              .HasColumnName("release_year")
              .HasColumnType("varchar(4)");

            builder.Property(x => x.Duracao)
             .HasColumnName("length")
             .HasColumnType("smallint");

            //Vai ignorar essa propriedade da classe e não irá mapear 
            //ela para o banco de dados
            builder.Ignore(x => x.Classificacao);

            builder.Property(x => x.TextoClassificacao)
            .HasColumnName("rating")
            .HasColumnType("varchar(10)");

            builder.Property<DateTime>("last_update")
              .HasColumnType("datetime")
              .HasDefaultValueSql("getdate()")
              .IsRequired();

            builder.Property<byte>("language_id").IsRequired();
            builder.Property<byte?>("original_language_id").IsRequired();

            builder.HasOne(_ => _.IdiomaFalado).WithMany(_ => _.FilmeFalados).HasForeignKey("language_id");
            builder.HasOne(_ => _.IdiomaOriginal).WithMany(_ => _.FilmeOriginais).HasForeignKey("original_language_id");
        }
    }
}
