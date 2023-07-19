using EntityProject.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityProject.Configurations
{
    //Usando a configuração feita por a classe PAI (PESSOA)
    //e adicionando usas próprias configurações
    public class FuncionarioConfiguration : PessoaConfiguration<Funcionario>
    {
        public override void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            //irá trazer todas as configurações que PESSOA fez
            base.Configure(builder);

            builder.ToTable("staff");

            builder
            .Property(c => c.Id)
            .HasColumnName("staff_id")
            .HasColumnType("tinyint")
            .IsRequired();

            builder
                .Property(c=> c.Login)
                .HasColumnName("username")
                .HasColumnType("varchar(16)")
                .IsRequired();

            builder
                .Property(c => c.Login)
                .HasColumnName("password")
                .HasColumnType("varchar(40)");
        }
    }
}
