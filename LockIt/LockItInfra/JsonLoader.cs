using LockIt.LockItCore;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;


namespace LockIt.LockItInfra;

// A classe é 'static' pois não precisamos criar um objeto JsonLoader, apenas usar o método diretamente.
public static class JsonLoader
{
    // Guarda o caminho completo do arquivo JSON (credentials.json)
    // Ele é obtido da classe AppPaths (responsável por centralizar os caminhos)
    private static readonly string filePath = AppPaths.CredentialFile;

    // Método público e estático (acessível de qualquer lugar, sem precisar instanciar)
    public static List<Credential> Load()
    {
        if (!File.Exists(filePath))
        {
            return new List<Credential>();
        }

        string json = File.ReadAllText(filePath);
        // Desserializa (converte) o JSON em uma lista de objetos Credential
        // Caso a desserialização falhe (retorne null), cria uma nova lista vazia
        return JsonSerializer.Deserialize<List<Credential>>(json) ?? new List<Credential>();
    }
}