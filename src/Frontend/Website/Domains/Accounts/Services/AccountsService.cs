using Shared.Domains.Accounts.Models;
using Website.Domains.Accounts.Repositories;
using Website.Domains.Entities.Persons.Repositories;

namespace Website.Domains.Accounts.Services
{
	public class AccountsService(
		IAccountsRepository accountsRepository,
		IPersonsRepository personsRepository) : IAccountsService
	{
		public async Task<AccountsModel?> AddAccountAsync(AccountsModel account)
		{
			if (account is null)
				return null;

			var accountCheck = (await accountsRepository.RetrieveAllAsync())
				.Find(a => a.Account_Number.Equals(account!.Account_Number));

			var personCheck = await personsRepository.RetrieveSingleAsync(account.Person_Code);

			if (accountCheck is null && personCheck is not null)
			{
				var newAccount = await accountsRepository.CreateAsync(account);

				return newAccount;
			}

			return null;
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
