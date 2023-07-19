using EntityProject.Enums;
using EntityProject.Extensions;

namespace EntityProject.Entities
{
    public class Filme
    {

        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string AnoLancamento { get; set; }
        public short Duracao { get; set; }
        public string TextoClassificacao { get; private set; }
        public ClassificacaoIndicativa Classificacao
        {
            get { return TextoClassificacao.ParaValor(); }
            set { TextoClassificacao = value.ParaString(); }
        }
        public IList<FilmeAtor> FilmeAtores { get; set; } = new List<FilmeAtor>();
        public IList<FilmeCategoria> FilmeCategorias { get; set; } = new List<FilmeCategoria>();

        public Idioma IdiomaFalado { get; private set; }
        public Idioma IdiomaOriginal { get; private set; }


        public override string ToString()
        {
            return $"{Titulo} - {AnoLancamento} \n{Descricao}";
        }
    }
}
