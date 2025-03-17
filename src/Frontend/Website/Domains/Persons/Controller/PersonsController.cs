using Microsoft.AspNetCore.Mvc;
using Shared.Domains.Persons.Models;
using Website.Domains.Persons.Services;

namespace Website.Controllers
{
	public class PersonsController(
		IPersonsServices personsService) : Controller
	{
		// GET: Persons
		public async Task<IActionResult> Index()
		{
			var persons = await personsService.GetPersonsAsync();
			return View(persons);
		}

		// GET: Persons/Details/5
		public async Task<IActionResult> Details(int id)
		{
			var person = await personsService.GetSinglePersonAsync(id);
			if (person == null) return NotFound();
			return View(person);
		}

		// GET: Persons/Create
		public IActionResult Create()
		{
			return View();
		}

		// POST: Persons/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(PersonsModel person)
		{
			if (ModelState.IsValid)
			{
				var addedPerson = await personsService.AddPersonAsync(person);
				if (addedPerson != null)
					return RedirectToAction(nameof(Index));
			}
			return View(person);
		}

		// GET: Persons/Edit/5
		public async Task<IActionResult> Edit(int id)
		{
			var person = await personsService.GetSinglePersonAsync(id);
			if (person == null) return NotFound();
			return View(person);
		}

		// POST: Persons/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, PersonsModel person)
		{
			if (id != person.Code) return NotFound();

			if (ModelState.IsValid)
			{
				var success = await personsService.UpdatePersonAsync(id, person);
				if (success)
					return RedirectToAction(nameof(Index));
			}
			return View(person);
		}

		// GET: Persons/Delete/5
		public async Task<IActionResult> Delete(int id)
		{
			var person = await personsService.GetSinglePersonAsync(id);
			if (person == null) return NotFound();
			return View(person);
		}

		// POST: Persons/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			var success = await personsService.RemovePersonAsync(id);
			if (success)
				return RedirectToAction(nameof(Index));

			return View();
		}
	}
}
