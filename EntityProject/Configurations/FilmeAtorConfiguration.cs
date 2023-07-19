using EntityProject.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityProject.Configurations
{
    public class FilmeAtorConfiguration : IEntityTypeConfiguration<FilmeAtor>
    {
        public void Configure(EntityTypeBuilder<FilmeAtor> builder)
        {
            //Essa tabela é para referenciar o relacionamento N para N de FILM e ACTOR
            builder.ToTable("film_actor");

            //Criando SHADOW PROPERTIES
            builder.Property<int>("film_id").IsRequired();
            builder.Property<int>("actor_id").IsRequired();
            builder.Property<DateTime>("last_update").HasColumnType("datetime").HasDefaultValueSql("getdate()").IsRequired();

            //Adicionando as DUAS PK dessa tabela, fazemos isso depois de 
            //criar a SHADOW PROPERTIE dessas PK para tabela de relacionamento
            builder.HasKey("actor_id", "film_id");

            //configurando FK entre FILME_ATOR e FILME
            //relacionamento é 1 para N, pois essa tabela tem
            //1 FILM que pode ter N ACTORS
            builder.HasOne(_ => _.Filme).WithMany(_ => _.FilmeAtores).HasForeignKey("film_id");

            //configurando FK entre ATOR e FILME_ATOR
            //relacionamento é 1 para N pois essa tabela tem
            //1 ACTOR que pode ter N FILMS
            builder.HasOne(_ => _.Ator).WithMany(_ => _.FilmeAtores).HasForeignKey("actor_id");
        }
    }
}
