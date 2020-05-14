using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevPrep.Data;
using DevPrep.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DevPrep.Controllers
{
    public class UsefulLinksController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public UsefulLinksController(ApplicationDbContext ctx, SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _context = ctx;
        }
        // GET: Links
        public ActionResult Index()
        {
            return View();
        }

        // GET: Links/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Links/Create
        [Route("UsefulLinks/Create/{id}")]

        public async Task<ActionResult> Create(int? id)
        {
            //if (ModelState.IsValid)
            //{
            //    _context.Add(usefulLink);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction(nameof(Index), "Concepts", new { area = "" });
            //}
            var matchingConcept = await _context.Concepts.FirstOrDefaultAsync(c => c.Id == id);


            var link = new UsefulLink();
            link.Concept = matchingConcept;
            return View(link);
        }
            
       

        // POST: Links/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("UsefulLinks/Create/{id}")]
        public async Task<ActionResult> Create(UsefulLink usefulLink, int? id)
        {
            try
            {
                var matchingConcept = await _context.Concepts.FirstOrDefaultAsync(c => c.Id == id);
                var user = await GetCurrentUserAsync();
                var useful = new UsefulLink();

                useful.Title = usefulLink.Title;
                useful.Link = usefulLink.Link;
                useful.ConceptId = id;
                useful.ApplicationUserId = user.Id;
                useful.Concept = matchingConcept;

    
                _context.UsefulLinks.Add(useful);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index), "Concepts", new { id = useful.Concept.SoftwareLanguageId });
            }
            catch
            {
                return View();
            }
        }

        // GET: Links/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Links/Edit/5
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

        // GET: Links/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var link = await _context.UsefulLinks.FirstOrDefaultAsync(item => item.Id == id);
            return View(link);
        }

        // POST: Links/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, UsefulLink usefulLink)
        {
            try
            {
                var matchingLink = await _context.UsefulLinks
                               .Include(ml => ml.Concept)
                               .FirstOrDefaultAsync(ml => ml.Id == id);

                var matchingSoftwareLangId = matchingLink.Concept.SoftwareLanguageId;
                _context.UsefulLinks.Remove(matchingLink);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index), "Concepts", new { id = matchingSoftwareLangId });
                // TODO: Add delete logic here
            }
            catch
            {
                return View();
            }
        }
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

    }
}