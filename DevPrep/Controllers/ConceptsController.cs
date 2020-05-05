using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevPrep.Data;
using DevPrep.Models;
using DevPrep.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DevPrep.Controllers
{
    public class ConceptsController : Controller
    {
            
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public ConceptsController(ApplicationDbContext ctx, SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _context = ctx;
        }
        // GET: Concept
        public async Task<ActionResult> Index(int? id)

        //{
        //    var concepts = from c in _context.Concepts
        //                  .Include(c => c.SoftwareLanguage)
        //                   select c;
        //    if (id != null)
        //    {
        //        concepts = concepts.Where(c => c.SoftwareLanguageId == id);
        //    }
        //    return View(await concepts.ToListAsync());
        //}
        {
            var model = new ConceptViewModel();


            model.ConceptsWithStuff = await _context
                .Concepts
                .Where(c => c.SoftwareLanguageId == id)
                .Select(c => new ConceptWithDescriptionAndLink()
                {
                    ConceptId = c.id,
                    ConceptName = c.Name,
                    SoftwareLanguageId = id,
                    UsefulLinks = c.UsefulLinks.ToList(),
                    Descriptions = c.Descriptions.ToList()
                }).ToListAsync();

            return View(model);
        }

        // GET: Concept/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Concept/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Concept/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Concept/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Concept/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Concept/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Concept/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}