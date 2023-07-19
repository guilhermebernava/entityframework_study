using EntityProject.Configurations;
using EntityProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityProject.Dados
{
    public class EntityContext : DbContext
    {
        public DbSet<Ator> Atores { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<FilmeAtor> FilmesAtores { get; set; }
        public DbSet<FilmeCategoria> FilmeCategorias { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Idioma> Idiomas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //CONECTA COM O BANCO DE DADOS UTILIZANDO UMA STRING DE CONEXAO
            //E O METODO VINDO DO BANCO CORRETO
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=AluraFilmes;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //ADICIONA OS ARQUIVOS DE CONFIGURAÇÃO
            modelBuilder.ApplyConfiguration(new AtorConfiguration());
            modelBuilder.ApplyConfiguration(new FilmeConfiguration());
            modelBuilder.ApplyConfiguration(new FilmeAtorConfiguration());
            modelBuilder.ApplyConfiguration(new IdiomaConfiguration());
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration(new FuncionarioConfiguration());
            modelBuilder.ApplyConfiguration(new CategoriaConfiguration());
            modelBuilder.ApplyConfiguration(new FilmeCategoriaConfiguration());
        }
    }
}
