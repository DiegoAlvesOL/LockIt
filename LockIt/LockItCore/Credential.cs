namespace LockIt.LockItCore;

public class Credential
{
    public required string Service { get; set; }
    public required string UserName { get; set; }
    public required string Password { get; set; }
    public DateTime CreatedAt { get; set; }
    public string? Notes { get; set; }
}