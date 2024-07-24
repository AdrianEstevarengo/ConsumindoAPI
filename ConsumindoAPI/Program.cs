using ConsumindoAPI.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json")!;
        var musicas = JsonSerializer.Deserialize < List<Musica>>(resposta);
        musicas[69].ExibirMusicas();
    }                 
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}

