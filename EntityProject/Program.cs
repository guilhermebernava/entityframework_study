using EntityProject.Dados;
using Microsoft.EntityFrameworkCore;

static void RecuperarTodosFilmesEAtores(EntityContext context)
{
    //Estou primeiramente pegando todos os FILMES, depois estou dando um JOIN dentro da tabela
    //FILM_ACTOR e pegando todos os atores desse FILME, para assim ir carregar os atores pelo
    //THEN INCLUDE que é um JOIN da tabela FILM_ACTOR para ACTOR
    var films = context.Filmes.Include(_=> _.FilmeCategorias).ThenInclude(_=> _.Categoria).Include(_ => _.FilmeAtores).ThenInclude(_ => _.Ator).Include(_=> _.IdiomaFalado).Include(_=> _.IdiomaOriginal).ToList();
    foreach (var film in films)
    {
        Console.WriteLine("=======================================");
        Console.WriteLine(film);
        Console.WriteLine();
        Console.WriteLine(film.IdiomaFalado);
        Console.WriteLine(film.IdiomaOriginal.Nome);
        Console.WriteLine();
        Console.WriteLine("Categorias:");
        foreach (var filmeCategoria in film.FilmeCategorias)
        {
            Console.WriteLine(filmeCategoria.Categoria);
        }
        Console.WriteLine("Elenco: ");
        foreach (var filmeAtor in film.FilmeAtores)
        {
            //Através das linhas que consegui trazer pela tabela FILMS
            //da tabela FILM_ACTOR, eu carrego também todos os ACTOR que tem nesse
            //relacionamento
            Console.WriteLine(filmeAtor.Ator);
        }
    }
}

using (var context = new EntityContext())
{

}
