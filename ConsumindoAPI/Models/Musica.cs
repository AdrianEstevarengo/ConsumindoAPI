using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;

namespace ConsumindoAPI.Models;

internal class Musica
{
    [JsonPropertyName("song")]
    public string Nome { get; set; }
    [JsonPropertyName("artist")]
    public string Artista { get; set; }
    [JsonPropertyName("genre")]
    public string Genero { get; set; }
    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    public void ExibirMusicas()
    {
        Console.WriteLine($"Musica : {Nome}");
        Console.WriteLine($"Artista : {Artista}");
        Console.WriteLine($"Genero : {Genero}");
        Console.WriteLine($"Duração : {Duracao}");
    }
}