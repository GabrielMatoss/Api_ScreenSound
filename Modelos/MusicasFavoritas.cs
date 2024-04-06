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
    
}