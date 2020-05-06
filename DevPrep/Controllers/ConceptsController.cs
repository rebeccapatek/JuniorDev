using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevPrep.Data;
using DevPrep.Models;
using DevPrep.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace DevPrep.Controllers
{
    [Authorize]
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
        [Route("Concepts/Create/{id}")]
        public async Task<ActionResult> Create([FromRoute] int? id)
        {
            

            var technology = await _context.SoftwareLanguages.FirstOrDefaultAsync(SL => SL.id == id);
        

            var viewModel = new AddNewConceptwithDescriptionViewModel();

            viewModel.SoftwareLanguage = technology;
          

            return View(viewModel);
        }

        // POST: Concept/Create
        [Route("Concepts/Create/{id}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(AddNewConceptwithDescriptionViewModel addNewConceptwithDescriptionViewModel, int id)
        {
            try
            {
                var user = await GetCurrentUserAsync();
                var concept= new Concept
                {
                    Name = addNewConceptwithDescriptionViewModel.ConceptName,
                    SoftwareLanguageId = id,
                    ApplicationUserId=user.Id
                };
                _context.Concepts.Add(concept);
                await _context.SaveChangesAsync();
                //Do I need to add the decription to a list of Descriptions in the Concept?
                var description = new Description
                {
                    Paragraph = addNewConceptwithDescriptionViewModel.ConceptDescription,
                    ApplicationUserId = user.Id,
                    ConceptId = concept.id
                };
                _context.Descriptions.Add(description);
                await _context.SaveChangesAsync();
                

                ///How do I grab the ConceptId from the concept I just created




                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index), new {id = id });
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
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);
    }
 }