namespace LockIt.TestHelpers.Helpers;

/// <summary>
/// Classe auxiliar para criação e gerenciamento de diretórios temporários usados nos testes integrados.
/// Essa classe garante que os testes usem um ambiente isolado (sem interferir no diretório real da aplicação).
/// </summary>
public static class TestEnvironmentHelper
{
    /// <summary>
    /// Cria um diretório temporário que será usado como base para os testes.
    /// </summary>
    public static string CreateTemporaryDirectory()
    {
        string tempPath = Path.GetTempPath();
        string testDir = Path.Combine(tempPath, "LockIt_TestEnv_" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(testDir);
        return testDir;
    }
    
    /// <summary>
    /// Limpa o diretório criado para o teste, removendo todos os arquivos e subpastas.
    /// </summary>
    public static void CleanUp(string directoryPath)
    {
        if (Directory.Exists(directoryPath))
        {
            try
            {
                Directory.Delete(directoryPath, true);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[WARN] Failed to clear test directory: {ex.Message}");
            }
        }
    }
    
    /// <summary>
    /// Define a variável de ambiente usada pela aplicação para localizar seu diretório base.
    /// </summary>
    public static void SetBaseDir(string path)
    {
        Environment.SetEnvironmentVariable("LOCKIT_BASEDIR", path);
    }
}