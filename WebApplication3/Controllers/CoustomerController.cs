using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class CoustomerController : Controller
    {
        private readonly User4Context Context;
        public CoustomerController(User4Context context)
        {
            Context = context;
        }
        public  IActionResult Index1()
        {
            return View(Context.Costomer5s.Include(a=>a.Country).Include(a=>a.State).ToList());
        }

        public IActionResult Index()
        {
            List<Country5> emplist = new List<Country5>();
            List<State2> States = new List<State2>();
            States = Context.State2s.ToList();
           emplist = Context.Country5s.ToList();
            ViewBag.CountryTbl = new SelectList(emplist, "CountryId", "Name");
            ViewBag.StateTbl = new SelectList(States, "StateId", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Costomer5 model)
        {
                Context.Add(model);
                Context.SaveChanges();
                return RedirectToAction("Index1");

            
        }
        [HttpGet]
        public IActionResult Edit(int? Id)
        {
            List<Country5> emplist = new List<Country5>();
            List<State2> States = new List<State2>();
            States = Context.State2s.ToList();
            emplist = Context.Country5s.ToList();
            ViewBag.CountryTbl = new SelectList(emplist, "CountryId", "Name");
            ViewBag.StateTbl = new SelectList(States, "StateId", "Name");
            var Costomer = Context.Costomer5s.Find(Id);
            if(Costomer== null)
            {
                return NotFound();
            }
            return View(Costomer);
        }
        [HttpPost]
        public IActionResult Edit(Costomer5 model)
        {
            var Costomer = Context.Costomer5s.FirstOrDefault(x => x.Id == model.Id);
            if (Costomer == null)
            {
                return NotFound();
            }
                Costomer.Name = model.Name;
                Costomer.Email = model.Email;
                Costomer.Dob = model.Dob;
                Costomer.CountryId = model.CountryId;
                Costomer.StateId = model.StateId;
                Costomer.Password = model.Password;
                Costomer.ConformPass = model.ConformPass;
                Context.SaveChanges();
                return RedirectToAction("Index1");
        }
        public IActionResult Details(Costomer5 model)
        {
            
            var Costomer = Context.Costomer5s.FirstOrDefault(x => x.Id == model.Id);
            if (Costomer == null)
            {
                return NotFound();
            }
            return View(Costomer);
        }
        [HttpGet]
        public IActionResult Delete(Costomer5 model)
        {
            var Costomer = Context.Costomer5s.FirstOrDefault(x => x.Id == model.Id);
            if (Costomer == null)
            {
                return NotFound();
            }
            return View(Costomer);
        }
        [HttpPost]
        public IActionResult Delete(int? Id)
        {
            var costomer = Context.Costomer5s.FirstOrDefault(x => x.Id==Id);
            Context.Costomer5s.Remove(costomer);
            
            Context.SaveChanges();
            return RedirectToAction("Index1");
            
        }
    }
}
