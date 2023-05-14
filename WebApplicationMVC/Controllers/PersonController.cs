using Microsoft.AspNetCore.Mvc;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
{
    public class PersonController : Controller
    {
        static List<Person> PeopleList = new List<Person>
        {
            new Person
            {
                PersonId = 0,
                PersonName = "Zenon Martyniuk",
                PersonAge = 18
            },
            new Person
            {
                PersonId = 1,
                PersonName = "Joshua Graham",
                PersonAge = 20
            },
            new Person
            {
                PersonId = 2,
                PersonName = "Jarosław Kaczyński",
                PersonAge = 22
            },
            new Person
            {
                PersonId = 3,
                PersonName = "Elon Musk",
                PersonAge = 33
            }
        };

        public IActionResult Index()
        {
            return View(PeopleList.OrderBy(x => x.PersonAge).ToList());
        }
        
        public IActionResult Edit(int Id)
        {
            return View(PeopleList.Find(x => x.PersonId == Id));
        }

        [HttpPost]
        public IActionResult Edit(Person person)
        {
            var p = PeopleList.Find(x => x.PersonId == person.PersonId);
            if (p==null)
            {
                return NotFound();
			}
            PeopleList.Remove(p);
            PeopleList.Add(person);
            return RedirectToAction(nameof(Index));
        }
		public IActionResult Create()
		{
			return View(new Person());
		}

		[HttpPost]
		public IActionResult Create(Person person)
		{
            var p = PeopleList.OrderBy(x => x.PersonId).ToList().Last();
			if (!ModelState.IsValid)
			{
				return NotFound();
			}
            person.PersonId = p.PersonId + 1;
			PeopleList.Add(person);
			return RedirectToAction(nameof(Index));
		}
		public IActionResult Delete(int Id)
		{
			var p = PeopleList.Find(x => x.PersonId == Id);
			if (p == null)
			{
				return NotFound();
			}
			PeopleList.Remove(p);
			return RedirectToAction(nameof(Index));
		}
	}
}
