using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PeopleCoreMvcApplication.Models;
using PeopleCoreMvcApplication.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PeopleCoreMvcApplication.Controllers
{
    public class PeopleController : Controller
    {
        private readonly IPeopleRepository _peopleRepository;

        public PeopleController(IPeopleRepository peopleRepository)
        {
            _peopleRepository = peopleRepository;
        }

        // GET: People
        public async Task<IActionResult> Index()
        {
            return View(await _peopleRepository.GetPeopleAsync());
        }

        // GET: People/Details/5
        public ActionResult Details(Guid id)
        {
            var person = _peopleRepository.GetPersonById(id);

            if (person == null)
            {
                return NotFound();
            }

            return View(person);
        }

        // GET: People/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: People/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Person person)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int result = _peopleRepository.InsertPerson(person);

                    if (result > 0)
                    {
                        TempData["Result"] = person.Name + " added successfully";
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Unable to add a person. Please try again or contact your administrator if the issue persists.");
            }

            return View(person);
        }

        // GET: People/Edit/5
        public ActionResult Edit(Guid id)
        {
            var person = _peopleRepository.GetPersonById(id);

            if (person == null)
            {
                return NotFound();
            }

            return View(person);
        }

        // POST: People/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Person person)
        {
            try
            {
                // TODO: Add edit logic here
                if (ModelState.IsValid)
                {
                    int result = _peopleRepository.UpdatePerson(person);

                    if (result > 0)
                    {
                        TempData["Result"] = person.Name + " updated successfully";
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }
            catch(Exception)
            {
                ModelState.AddModelError("", "Unable to edit a person. Please try again or contact your administrator if the issue persists.");
            }

            return View(person);
        }

        // GET: People/Delete/5
        public ActionResult Delete(Guid id)
        {
            var person = _peopleRepository.GetPersonById(id);

            if (person == null)
            {
                return NotFound();
            }

            return View(person);
        }

        // POST: People/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Person person)
        {
            try
            {
                // TODO: Add delete logic here
                
                int result = _peopleRepository.DeletePerson(person.Id);

                if (result > 0)
                {
                    TempData["Result"] = person.Name + " deleted successfully";
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Unable to delete a person. Please try again or contact your administrator if the issue persists.");
            }

            return View();
        }
    }
}