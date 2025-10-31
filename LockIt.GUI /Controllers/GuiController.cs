using System;
using LockIt.LockItCore;
using LockIt.LockItInfra;

namespace LockIt.GUI.Controllers;


/// <summary>
/// Classe que atua como uma ponte entre a interface gráfica (GUI) e o backend.
/// É responsável por receber comandos da interface (como "gerar senha" ou "salvar credencial")
/// e chamar as classes do Core e Infra para realizar essas ações.
/// </summary>
public class GuiController
{
    /// <summary>
    /// Método responsável por gerar uma nova senha.
    /// </summary>
    /// <param name="length"></param>
    /// <returns></returns>
    public string GenerateNewPassword(int length, string charset)
    {
        PasswordGenerator generator = new PasswordGenerator(charset);
        return generator.GeneratePassword(length);
    }

    public void SaveCredential(string service, string username, string password, string? notes)
    {
        Credential newCredential = new Credential
        {
            Service = service,
            UserName = username,
            Password = password,
            CreatedAt = DateTime.UtcNow,
            Notes = notes
        };
        JsonStorage.Save(newCredential);
    }
}