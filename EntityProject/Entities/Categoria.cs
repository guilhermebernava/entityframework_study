namespace EntityProject.Entities
{
    public class Categoria
    {
        public byte Id { get; set; }
        public string Nome { get; set; }
        public IList<FilmeCategoria> FilmeCategorias { get; set; } = new List<FilmeCategoria>();

        public override string ToString()
        {
            return $"({Id}) - {Nome}";
        }
    }
}
