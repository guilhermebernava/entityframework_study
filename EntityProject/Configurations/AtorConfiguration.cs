using EntityProject.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityProject.Configurations
{
    public class AtorConfiguration : IEntityTypeConfiguration<Ator>
    {
        public void Configure(EntityTypeBuilder<Ator> builder)
        {
            //Vai dizer qual nome da tabela
            builder.ToTable("actor");

            //Vai dizer o nome da propriedade
            builder.Property(t => t.Id).HasColumnName("actor_id");

            //vai dizer o nome da propriedade, o tipo e seu tamanho
            //dela e que ela é NOT NULL
            builder.Property(x=> x.PrimeiroNome)
                .HasColumnName("first_name")
                .HasColumnType("varchar(45)")
                .IsRequired();

            builder.Property(x => x.SegundoNome)
               .HasColumnName("last_name")
               .HasColumnType("varchar(45)")
               .IsRequired();

            //SHADOW PROPERTIE, uma coluna que existe no banco que o
            //ENTITY FRAMEWORK cria mas não existe dentro da nossa 
            //classe/entidade
            builder.Property<DateTime>("last_update")
              .HasColumnType("datetime")
              //Toda vez que adicioanr um dado, vai colocar dateTime
              //de forma automatica
              .HasDefaultValueSql("getdate()")
              .IsRequired();

            //Adicionando um INDEX na tabela, primeiramente referenciando a coluna
            //e por fim dando um nome para esse index
            builder.HasIndex(_ => _.SegundoNome).HasDatabaseName("idx_actor_last_name");

            //Vai criar uma NOVA ALTERNATE KEY que vai validar se existe esse dado
            //duplicado, e caso houver ele não vai deixar fazer o INSERT no banco
            //nesse caso temos duas propriedades que não podem ser duplicadas.
            builder.HasAlternateKey(_ => new { _.PrimeiroNome, _.SegundoNome });
        }
    }
}
