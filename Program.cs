using System.Text.Json;
using ScreenSoundApi.Filtros;
using ScreenSoundApi.Modelos;

using (HttpClient client = new())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Michel Teló");
        //LinqFilter.FiltrarMusicasPorAno(musicas, 2005);

        var minhasMusicasFavoritas = new MusicasFavoritas("Gabriel");

        minhasMusicasFavoritas.AdicionarMusicasFavoritas(musicas[8]);
        minhasMusicasFavoritas.AdicionarMusicasFavoritas(musicas[20]);
        minhasMusicasFavoritas.AdicionarMusicasFavoritas(musicas[10]);
        minhasMusicasFavoritas.AdicionarMusicasFavoritas(musicas[54]);
        minhasMusicasFavoritas.AdicionarMusicasFavoritas(musicas[76]);

        minhasMusicasFavoritas.ExibirMusicasFavoritas();

        minhasMusicasFavoritas.GerarArquivoJson();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}