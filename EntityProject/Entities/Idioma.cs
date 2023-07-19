

namespace EntityProject.Entities
{
    public class Idioma
    {
        public Idioma(byte id, string nome)
        {
            Id = id;
            Nome = nome;
            FilmeFalados = new List<Filme>();
            FilmeOriginais = new List<Filme>();
        }

        public byte Id { get; set; }
        public string Nome { get; set; }
        public IList<Filme> FilmeFalados { get; private set; }
        public IList<Filme> FilmeOriginais { get; private set; }

        public override string ToString()
        {
            return $"Idioma({Id}) - {Nome}";
        }
    }
}
