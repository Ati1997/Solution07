﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RepositoryDesignPattern.ApplicationServices.Services.Contracts;
using RepositoryDesignPattern.Models.DomainModels.PersonAggregates;
using RepositoryDesignPattern.Sample01.Models.Services;

namespace RepositoryDesignPattern.Controllers
{
    public class PeopleController : Controller
    {
        private readonly IPersonApplicationService _personApplicationService;

        public PeopleController(IPersonApplicationService personApplicationService)
        {
            _personApplicationService = personApplicationService;
        }

        public async Task<IActionResult> Index()
        {
            var persons = await _personApplicationService.GetAllAsync();
            return View(persons);
        }
    }
}
//        //private readonly OnlineShopDbContext _context;

//        //public PeopleController(OnlineShopDbContext context)
//        //{
//        //    _context = context;
//        //}

//        // GET: People
//        public async Task<IActionResult> Index()
//        {
//            return View(await _context.Person.ToListAsync());
//        }

//        // GET: People/Details/5
//        public async Task<IActionResult> Details(Guid? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var person = await _context.Person
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (person == null)
//            {
//                return NotFound();
//            }

//            return View(person);
//        }

//        // GET: People/Create
//        public IActionResult Create()
//        {
//            return View();
//        }

//        // POST: People/Create
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create([Bind("Id,FName,LName")] Person person)
//        {
//            if (ModelState.IsValid)
//            {
//                person.Id = Guid.NewGuid();
//                _context.Add(person);
//                await _context.SaveChangesAsync();
//                return RedirectToAction(nameof(Index));
//            }
//            return View(person);
//        }

//        // GET: People/Edit/5
//        public async Task<IActionResult> Edit(Guid? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var person = await _context.Person.FindAsync(id);
//            if (person == null)
//            {
//                return NotFound();
//            }
//            return View(person);
//        }

//        // POST: People/Edit/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(Guid id, [Bind("Id,FName,LName")] Person person)
//        {
//            if (id != person.Id)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Update(person);
//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!PersonExists(person.Id))
//                    {
//                        return NotFound();
//                    }
//                    else
//                    {
//                        throw;
//                    }
//                }
//                return RedirectToAction(nameof(Index));
//            }
//            return View(person);
//        }

//        // GET: People/Delete/5
//        public async Task<IActionResult> Delete(Guid? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var person = await _context.Person
//                .FirstOrDefaultAsync(m => m.Id == id);
//            if (person == null)
//            {
//                return NotFound();
//            }

//            return View(person);
//        }

//        // POST: People/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(Guid id)
//        {
//            var person = await _context.Person.FindAsync(id);
//            if (person != null)
//            {
//                _context.Person.Remove(person);
//            }

//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }

//        private bool PersonExists(Guid id)
//        {
//            return _context.Person.Any(e => e.Id == id);
//        }
//    }
//}
