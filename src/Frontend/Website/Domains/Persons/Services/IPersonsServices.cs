using Shared.Domains.Persons.Models;

namespace Website.Domains.Persons.Services;

public interface IPersonsServices
{
	Task<PersonsModel?> AddPersonAsync(PersonsModel person);
	Task<List<PersonsModel>?> GetPersonsAsync();
	Task<PersonsModel?> GetSinglePersonAsync(int code);
	Task<bool> UpdatePersonAsync(int code, PersonsModel person);
	Task<bool> RemovePersonAsync(int code);
}
