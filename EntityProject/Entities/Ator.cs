namespace EntityProject.Entities
{
    public class Ator
    {
        public Ator( string primeiroNome, string segundoNome)
        {
            PrimeiroNome = primeiroNome;
            SegundoNome = segundoNome;
            FilmeAtores = new List<FilmeAtor>();
        }

        public int Id { get; set; }
        public string PrimeiroNome { get; set; }
        public string SegundoNome { get; set; }
        public IList<FilmeAtor> FilmeAtores { get; set; }

        public override string ToString()
        {
            return $"Nome Completo do Ator ({Id}): {PrimeiroNome} {SegundoNome}";
        }
    }
}