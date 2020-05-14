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
            var user = await GetCurrentUserAsync();
            model.SoftwareLanguage = await _context
               .SoftwareLanguages.FirstOrDefaultAsync(sl => sl.Id == id);



            model.ConceptsWithStuff = await _context
                .Concepts
                .Where(c => c.SoftwareLanguageId == id)
                .Select(c => new ConceptWithDescriptionAndLink()
                {
                    ConceptId = c.Id,
                    ConceptName = c.Name,
                    SoftwareLanguageId = id,
                    UsefulLinks = c.UsefulLinks.ToList(),
                    Descriptions = c.Descriptions.ToList()
                }).ToListAsync();
            model.LoggedInUser = user;
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


            var technology = await _context.SoftwareLanguages.FirstOrDefaultAsync(SL => SL.Id == id);


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
                var concept = new Concept
                {
                    Name = addNewConceptwithDescriptionViewModel.ConceptName,
                    SoftwareLanguageId = id,
                    ApplicationUserId = user.Id
                };
                _context.Concepts.Add(concept);
                await _context.SaveChangesAsync();
                //Do I need to add the decription to a list of Descriptions in the Concept?
                var description = new Description
                {
                    Paragraph = addNewConceptwithDescriptionViewModel.ConceptDescription,
                    ApplicationUserId = user.Id,
                    ConceptId = concept.Id
                };
                _context.Descriptions.Add(description);
                await _context.SaveChangesAsync();


                ///How do I grab the ConceptId from the concept I just created




                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index), new { id = id });
            }
            catch
            {
                return View();
            }
        }

        // GET: Concept/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var viewModel = new EditConceptViewModel();

            var user = await GetCurrentUserAsync();
            var descriptions = await _context
                .Descriptions.Where(d => d.ConceptId == id).ToListAsync();
            var links = await _context
                .UsefulLinks.Where(l => l.ConceptId == id).ToListAsync();
            var concept = await _context.Concepts.FindAsync(id);
            viewModel.ConceptName = concept.Name;
            viewModel.Descriptions = descriptions;
            viewModel.Links = links;

            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, EditConceptViewModel editConceptViewModel)
        {
            try
            {//first or default takes a call-back function

                var concept = await _context.Concepts
                    .Include(c => c.Descriptions)
                    .Include(c => c.UsefulLinks)
                    .FirstOrDefaultAsync(concept => concept.Id == id);
                concept.Name = editConceptViewModel.ConceptName;
                //this is updating the lists with new list and it updates the links/descriptions database
                concept.UsefulLinks = editConceptViewModel.Links;
                concept.Descriptions = editConceptViewModel.Descriptions;
                concept.Id = id;
                //this is what edits the concept in the database.
                _context.Concepts.Update(concept);
                await _context.SaveChangesAsync();
                //the , new Id lets you grab the software id and include it in the route
                   return RedirectToAction(nameof(Index), new { id = concept.SoftwareLanguageId });
            





            }
            catch (Exception ex)
            {
                
                return View();
            }
        }



        // GET: Concept/Delete/5

        public async Task<ActionResult> Delete(int id)
        {
            var concept = await _context.Concepts
                .Include(c => c.Descriptions)
                .Include(c => c.UsefulLinks)
                .FirstOrDefaultAsync(c => c.Id == id);

            return View(concept);
        }

        // POST: Concept/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<ActionResult> Delete(int id, Concept concept)
        {
            try
            {
                var usefulLinks = await _context.UsefulLinks.Where(ul => ul.ConceptId == id).ToListAsync();
                var softwareLangId = concept.SoftwareLanguageId;
                _context.UsefulLinks.RemoveRange(usefulLinks);



                _context.Concepts.Remove(concept);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index), new { id = softwareLangId });
            }
            catch (Exception ex)
            {
                return View();
            }
        }
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);
    }
}