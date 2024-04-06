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

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musica, string genero)
    {
        var artistasPorGeneroMusical = musica.Where(musica => musica.Genero!.Contains(genero))
            .Select(musica => musica.Artista)
            .Distinct()
            .ToList();

        Console.WriteLine($"Exibindo artistas por gênero musical: {genero} \n");
        artistasPorGeneroMusical.ForEach(artista => Console.WriteLine($"- {artista}"));
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
        Console.WriteLine(nomeDoArtista);
        musicasDoArtista.ForEach(musica => Console.WriteLine($"- {musica.Nome}"));
    }

    public static void FiltrarMusicasPorAno(List<Musica> musicas, int ano)
    {
        var musicasDoAno = musicas.Where(musica => musica.Ano == ano)
            .OrderBy(musicas => musicas.Nome)
            .Distinct()
            .ToList();

        Console.WriteLine($"Musicas do ano: {ano} \n");
        musicasDoAno.ForEach(musica => Console.WriteLine($"- {musica.Nome}"));
    }
}