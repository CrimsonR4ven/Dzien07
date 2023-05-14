using EFTest.Data;
using EFTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFTest.Controllers
{
	public class EmployeeController : Controller
	{
		private readonly ApplicationDbContext _context;
		public EmployeeController(ApplicationDbContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			List<Employee> employees = _context.Employees.ToList();
			return View(employees);
		}

		public IActionResult Edit(int Id)
		{
			var p = _context.Employees.ToList().Find(x => x.Id == Id);
			return View(p);
		}

		[HttpPost]
		public IActionResult Edit(Employee person)
		{
			var p = _context.Employees.ToList().Find(x => x.Id == person.Id);
			if (p == null)
			{
				return NotFound();
			}
			_context.Employees.Remove(p);
			_context.Employees.Add(person);
			_context.SaveChanges();
			return RedirectToAction(nameof(Index));
		}
		public IActionResult Create()
		{
			return View(new Employee());
		}

		[HttpPost]
		public IActionResult Create(Employee person)
		{
			if (!ModelState.IsValid)
			{
				return NotFound();
			}
			_context.Employees.Add(person);
			_context.SaveChanges();
			return RedirectToAction(nameof(Index));
		}
		public IActionResult Delete(int Id)
		{
			var p = _context.Employees.ToList().Find(x => x.Id == Id);
			if (p == null)
			{
				return NotFound();
			}
			_context.Employees.Remove(p);
			_context.SaveChanges();
			return RedirectToAction(nameof(Index));
		}
	}
}
