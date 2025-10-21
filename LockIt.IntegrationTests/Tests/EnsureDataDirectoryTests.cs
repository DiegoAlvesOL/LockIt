using LockIt.LockItInfra;
using LockIt.TestHelpers.Helpers;

namespace LockIt.IntegrationTests.Tests;



/// <summary>
/// Testes de integração focados na criação do diretório de dados do LockIt.
/// </summary>
public class EnsureDataDirectoryTests : IDisposable
{
    private readonly string _tempDir;


    /// <summary>
    /// Testes de integração focados na criação do diretório de dados do LockIt.
    /// </summary>
    public EnsureDataDirectoryTests()
    {
        // Cria um diretório temporário exclusivo para este teste
        _tempDir = TestEnvironmentHelper.CreateTemporaryDirectory();
        
        // Classe responsável por informar ao programa pincipal LockIt o diretório temporário
        TestEnvironmentHelper.SetBaseDir(_tempDir);
        
        
        AppPaths.EnsureDataDirectoryExists();
    }
    
}