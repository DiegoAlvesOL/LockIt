namespace LockIt.LockItCore;

public class Credential
{
    public string Service { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public DateTime CreatedAt { get; set; }
    public string Notes { get; set; }
}