using EntityProject.Enums;

namespace EntityProject.Extensions
{
    public static class ClassificacaoIndicativaExtensions
    {
        //Mapa com os dados para fazer a conversão para STRING e ENUM
        private static Dictionary<string, ClassificacaoIndicativa> _ClassificationMap = 
            new Dictionary<string, ClassificacaoIndicativa>
            {
                { "G", ClassificacaoIndicativa.Livre},
                { "PG", ClassificacaoIndicativa.MaioresQue10},
                { "PG-13", ClassificacaoIndicativa.MaioresQue13 },
                { "R", ClassificacaoIndicativa.MaioresQue14 },
                { "NC-17", ClassificacaoIndicativa.MaioresQue18 }
            };

        //Converte o ENUM para o valor desejado em STRING
        public static string ParaString(this ClassificacaoIndicativa classificacaoIndicativa) => _ClassificationMap.First(c => c.Value == classificacaoIndicativa).Key;

        //Converte a STRING para o ENUM que precisamos
        public static ClassificacaoIndicativa ParaValor(this string texto) =>  _ClassificationMap.First(c => c.Key == texto).Value;
    }
}
