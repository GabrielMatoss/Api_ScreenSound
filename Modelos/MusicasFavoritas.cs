using System.Text.Json;

namespace ScreenSoundApi.Modelos;

internal class MusicasFavoritas
{
    public string? Nome { get; set; }

    public List<Musica> ListaDeMusicasFavoritas { get; }

    public MusicasFavoritas(string nome)
    {
        Nome = nome;
        ListaDeMusicasFavoritas = new List<Musica>();
    }

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Essas são as músicas favoritas: {Nome} \n");
        ListaDeMusicasFavoritas.ForEach(musica => Console.WriteLine($"- {musica.Nome} de {musica.Artista}"));
        Console.WriteLine();
    }

    public void GerarArquivoJson()
    {
        try
        {
            string json = JsonSerializer.Serialize(new {
                nome = Nome,
                musicas = ListaDeMusicasFavoritas
            });

            string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";
            File.WriteAllText(nomeDoArquivo, json);

            Console.WriteLine("Arquivo Json criado com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Mensagem de erro: {ex.Message}");
        }
        
    }
    
}