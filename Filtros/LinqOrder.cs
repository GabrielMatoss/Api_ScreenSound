using ScreenSoundApi.Modelos;

namespace ScreenSoundApi.Filtros;

internal class LinqOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(musica => musica.Artista)
            .Select(musica => musica.Artista)
            .Distinct()
            .ToList();
        Console.WriteLine("Lista de artistas ordenados");
        artistasOrdenados.ForEach(artista => Console.WriteLine($"- {artista}"));
    }
}