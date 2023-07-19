using EntityProject.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityProject.Configurations
{
    //Isso vai fazer que todas as suas FILHAS possam utilizar esse codigo
    //para agilizar seu mapeamento
    public class PessoaConfiguration<T> : IEntityTypeConfiguration<T> where T : Pessoa
    {
        //Ele está como VIRTUAL para suas classes filhas possam usar
        //esse método para adicionar suas próprias configurações
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder
            .Property(c => c.PrimeiroNome)
            .HasColumnName("first_name")
            .HasColumnType("varchar(45)")
            .IsRequired();

            builder
                .Property(c => c.UltimoNome)
                .HasColumnName("last_name")
                .HasColumnType("varchar(45)")
                .IsRequired();

            builder
                .Property(c => c.Email)
                .HasColumnName("email")
                .HasColumnType("varchar(50)");

            builder
                .Property(c => c.Ativo)
                .HasColumnName("active");

            builder
                .Property<DateTime>("last_update")
                .HasColumnType("datetime")
                .HasDefaultValueSql("getdate()")
                .IsRequired();
        }
    }
}
