using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListPeople()
        {
            List<PersonModel> people = new List<PersonModel>();

            people.Add(new PersonModel { FirstName = "Mary", LastName = "Corey", age = 36 });
            people.Add(new PersonModel { FirstName = "Claire", LastName = "Corey", age = 22 });
            people.Add(new PersonModel { FirstName = "Edward", LastName = "Corey", age = 19 });

            return View(people);
        }
    }
}
