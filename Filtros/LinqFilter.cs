using ScreenSoundApi.Modelos;

namespace ScreenSoundApi.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        Console.WriteLine("Lista de generos musicais \n");
        todosOsGenerosMusicais.ForEach(genero => Console.WriteLine($"- {genero}"));
    }
}