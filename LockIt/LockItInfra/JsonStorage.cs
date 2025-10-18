using LockIt.LockItCore;

namespace LockIt.LockItInfra;
using System.IO;
using System.Text.Json;

public static class JsonStorage
{
    private static readonly string filePath = AppPaths.CredentialFile;

    static JsonStorage()
    {
        AppPaths.EnsureDataDirectoryExists();
    }

    public static void Save(Credential credential)
    {
        List<Credential> existing = JsonLoader.Load();
        
        existing.Add(credential);

        string json = JsonSerializer.Serialize(existing, new JsonSerializerOptions { WriteIndented = true });
        
        File.WriteAllText(filePath, json);
        
        Console.WriteLine($"[INFO] Credentials saved to {filePath}");
    }

}