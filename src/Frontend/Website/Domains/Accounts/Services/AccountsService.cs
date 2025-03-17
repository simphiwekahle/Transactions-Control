using Shared.Domains.Accounts.Models;
using Website.Domains.Accounts.Repositories;
using Website.Domains.Entities.Persons.Repositories;

namespace Website.Domains.Accounts.Services
{
	public class AccountsService(
		IAccountsRepository accountsRepository,
		IPersonsRepository personsRepository) : IAccountsService
	{
		public Task<AccountsModel?> AddAccountAsync(AccountsModel account)
		{
			throw new NotImplementedException();
		}

		public Task<List<AccountsModel>?> GetAccountsAsync()
		{
			throw new NotImplementedException();
		}

		public Task<AccountsModel?> GetSingleAccountAsync(int code)
		{
			throw new NotImplementedException();
		}

		public Task<bool> RemoveAccountAsync(int code)
		{
			throw new NotImplementedException();
		}

		public Task<bool> UpdateAccountAsync(int code, AccountsModel account)
		{
			throw new NotImplementedException();
		}
	}
}
