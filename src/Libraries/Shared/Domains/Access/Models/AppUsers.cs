namespace Shared.Domains.Access.Models;

public class AppUsers
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;
    public string Id_Number { get; set; } = string.Empty;
    public string Phone_Number { get; set; } = string.Empty;
    public string Gender { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;
    public DateOnly Date_Of_Birth { get; set; }
}
