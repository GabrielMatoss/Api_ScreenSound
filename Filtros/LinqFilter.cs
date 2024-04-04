using ScreenSoundApi.Modelos;

namespace ScreenSoundApi.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        todosOsGenerosMusicais.ForEach(genero => Console.WriteLine($"- {genero}"));
    }
}