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
    public class DescriptionsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public DescriptionsController(ApplicationDbContext ctx, SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _context = ctx;
        }
        // GET: Descriptions
        public ActionResult Index()
        {
            return View();
        }

        // GET: Descriptions/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Descriptions/Create
        [Route("Descriptions/Create/{id}")]
        public async Task<ActionResult> Create(int? id)
        {
            var matchingConcept = await _context.Concepts.FirstOrDefaultAsync(c => c.id == id);


            var desc = new Description();
            desc.Concept = matchingConcept;
            return View(desc);
          
        }

        // POST: Descriptions/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Descriptions/Create/{id}")]

        public   async Task<ActionResult> Create (int? id, Description description)
        {
            try
            {
                var matchingConcept = await _context.Concepts.FirstOrDefaultAsync(c => c.id == id);
                var user = await GetCurrentUserAsync();
                var des = new Description();

                des.Paragraph = description.Paragraph;
                des.ConceptId = id;
                des.ApplicationUserId = user.Id;
                des.Concept = matchingConcept;


                _context.Descriptions.Add(des);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index), "Concepts", new { id = des.Concept.SoftwareLanguageId });
         

                
            }
            catch
            {
                return View();
            }
        }

        // GET: Descriptions/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Descriptions/Edit/5
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

        // GET: Descriptions/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Descriptions/Delete/5
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
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

    }
}