using EntityProject.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityProject.Configurations
{
    public class ClienteConfiguration : PessoaConfiguration<Cliente>
    {
        public override void Configure(EntityTypeBuilder<Cliente> builder)
        {
            //Adiciona as configurações de PESSOA
            base.Configure(builder);

            builder.ToTable("customer");

            builder
            .Property(c => c.Id)
            .HasColumnName("customer_id")
            .HasColumnType("tinyint")
            .IsRequired();

            builder
                .Property<DateTime>("create_date")
                .HasColumnType("datetime")
                .HasDefaultValueSql("getdate()")
                .IsRequired();
        }
    }
}
