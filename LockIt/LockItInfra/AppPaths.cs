namespace LockIt.LockItInfra;
using System;
using System.IO;

/// <summary>
/// Centraliza os caminhos de diretórios e arquivos utilizados pela aplicação.
/// Essa classe facilita a manutenção e evita repetição de strings de caminho.
/// </summary>
public static class AppPaths
{
    private static string GetBaseDirectory()
    {
        string overrideBase = Environment.GetEnvironmentVariable("LOCKIT_BASEDIR");
        if (!string.IsNullOrWhiteSpace(overrideBase))
        {
            return Path.GetFullPath(overrideBase);
        }

        return Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "../../.."));
    }
    
    public static readonly string BaseDir = GetBaseDirectory();

    public static readonly string DataDir = Path.Combine(BaseDir, "LockItData");

    public static readonly string CredentialFile = Path.Combine(DataDir, "credentials.json");

    public static void EnsureDataDirectoryExists()
    {
        // used only to understand where the files were being saved and if the path was working. 
        // Console.WriteLine($"[DEBUG] BaseDir resolved to: {BaseDir}");
        // Console.WriteLine($"[DEBUG] DataDir resolved to: {DataDir}");
        // Console.WriteLine($"[DEBUG] CredentialFile resolved to: {CredentialFile}");

        if (!Directory.Exists(DataDir))
        {
            Directory.CreateDirectory(DataDir);
        }
    }
}
