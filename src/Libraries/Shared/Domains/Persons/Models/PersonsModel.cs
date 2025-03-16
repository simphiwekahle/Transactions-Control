namespace Shared.Domains.Persons.Models;

public class PersonsModel
{
	public int Code { get; set; }
	public string? Name { get; set; }
	public string? Surname { get; set; }
	public string Id_Number { get; set; } = string.Empty;
}
