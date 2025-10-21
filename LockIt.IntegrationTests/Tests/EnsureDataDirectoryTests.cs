using Xunit;
using LockIt.TestHelpers.Helpers;
using System;
using System.IO;
using LockIt.LockItInfra;

namespace LockIt.IntegrationTests.Tests
{
    /// <summary>
    /// Testes de integração focados na criação do diretório de dados do LockIt.
    /// </summary>
    public class EnsureDataDirectoryTests : IDisposable
    {
        private readonly string _tempDir;

        /// <summary>
        /// Construtor: executado antes de cada teste.
        /// Ele prepara o ambiente de teste criando um diretório temporário.
        /// </summary>
        public EnsureDataDirectoryTests()
        {
            // Cria um diretório temporário exclusivo para o teste
            _tempDir = TestEnvironmentHelper.CreateTemporaryDirectory();
            Console.WriteLine($"[DEBUG] Directory is {_tempDir}");

            // Define a variável de ambiente que o projeto LockIt usa como base de diretório
            TestEnvironmentHelper.SetBaseDir(_tempDir);

            // Garante que o diretório LockItData seja criado
            AppPaths.EnsureDataDirectoryExists();
        }

        /// <summary>
        /// Testa se o método EnsureDataDirectoryExists realmente cria o diretório LockItData.
        /// </summary>
        [Fact]
        public void EnsureDataDirectoryExists_CreatesDirectory_WhenMissing()
        {
            
            string expectedPath = Path.Combine(_tempDir, "LockItData");
            Assert.True(Directory.Exists(expectedPath), 
                $"O diretório {expectedPath} deveria existir após EnsureDataDirectoryExists.");
        }

        /// <summary>
        /// Método Dispose: é chamado automaticamente após cada teste.
        /// Aqui, limpamos o diretório temporário.
        /// </summary>
        public void Dispose()
        {
            
            TestEnvironmentHelper.CleanUp(_tempDir);
        
            
            Environment.SetEnvironmentVariable("LOCKIT_BASEDIR", null);
        }
    }
}
