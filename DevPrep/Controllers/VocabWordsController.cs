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
    public class VocabWordsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public VocabWordsController(ApplicationDbContext ctx, SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _context = ctx;
        }
        // GET: VocabWords
        public async Task<ActionResult> Index()
        {
            List<VocabWord> vocabWords = await _context.VocabWords.ToListAsync();
            return View(vocabWords);
        }

        // GET: VocabWords/Details/5
        public async Task<ActionResult> DetailsFront(int id)
        {
            var user = await GetCurrentUserAsync();
            var word = await _context.VocabWords
               .FirstOrDefaultAsync(vw => vw.Id == id);


            return View(word);
        }
        public async Task<ActionResult> DetailsBack(int id)
        {
            var user = await GetCurrentUserAsync();
            var word = await _context.VocabWords
               .FirstOrDefaultAsync(vw => vw.Id == id);
            return View(word);
        }


        // GET: VocabWords/Create
        public async Task<ActionResult> Create()
        {
            //Go through all of the to do statuses(select is like a map) and this creates a drop down of all of the statuses)
            var allSoftwareLanguages = await _context.SoftwareLanguages
                .Select(l => new SelectListItem()
                {
                    Text = l.Name,
                    Value = l.Id.ToString()
                })
                .ToListAsync();

            var viewModel = new VocabWordCreateViewModel();

            viewModel.SoftwareLanguageOptions = allSoftwareLanguages;



            return View(viewModel);
        }

        // POST: VocabWords/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <ActionResult> Create(VocabWordCreateViewModel vocabWordCreateViewModel)
        {
            try
            {
                var user = await GetCurrentUserAsync();

                var vocabWord = new VocabWord
                {
                    Word = vocabWordCreateViewModel.Word,
                    Definition = vocabWordCreateViewModel.Definition,

                    SoftwareLanguageId = vocabWordCreateViewModel.SoftwareLanguageId,
                };
                //Set application user id to the the the lod in user's id

                vocabWord.ApplicationUserId = user.Id;
                //add the new todoitem to the list of todoitems? Or promise to add the the todoitems to the db.


                _context.VocabWords.Add(vocabWord);
                //Save changes to the databse
                await _context.SaveChangesAsync();
                //Return to the list of todoitems once you've created a new todoItem

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VocabWords/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var allSoftwareLanguages = await _context.SoftwareLanguages
                .Select(l => new SelectListItem()
                {
                    Text = l.Name,
                    Value = l.Id.ToString()
                })
                .ToListAsync();
            var user = await GetCurrentUserAsync();
            var vocabWord = await _context.VocabWords.FindAsync(id);
            //return the view model and populate it with the information from the returned todoItem
            var viewModel = new VocabWordCreateViewModel()
            {
                Id = vocabWord.Id,
                Word = vocabWord.Word,
                Definition = vocabWord.Definition,
                ApplicationUserId = user.Id,
                SoftwareLanguageId = vocabWord.SoftwareLanguageId,
                SoftwareLanguageOptions = allSoftwareLanguages
            };

            if (vocabWord == null)
            {
                return NotFound();
            }
            //return the populated view Model
            return View(viewModel);
        }

        // POST: VocabWords/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int? id, VocabWordCreateViewModel vocabWordCreateViewModel)
        {
            try
            {

                var allSoftwareLanguages = await _context.SoftwareLanguages
                    .Select(l => new SelectListItem()
                    {
                        Text = l.Name,
                        Value = l.Id.ToString()
                    })
                    .ToListAsync();

                var vocabWord = _context.VocabWords.FirstOrDefault(item => item.Id == id);
                //This is getting the current user who is logged in
                var user = await GetCurrentUserAsync();
                //using the same view model as the create 

                vocabWord.Word = vocabWordCreateViewModel.Word;
                vocabWord.Definition = vocabWordCreateViewModel.Definition;
                vocabWord.ApplicationUserId = user.Id;
                vocabWord.SoftwareLanguageId = vocabWordCreateViewModel.SoftwareLanguageId;
               
                _context.VocabWords.Update(vocabWord);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: VocabWords/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var vocabWord = await _context.VocabWords.FirstOrDefaultAsync(vw => vw.Id == id);
            //get the logged in user id
            var loggedInUser = await GetCurrentUserAsync();

            if (vocabWord.ApplicationUserId != loggedInUser.Id)
            {
                return NotFound();
            }

            return View(vocabWord);
        }

        // POST: VocabWords/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, VocabWord vocabWord)
        {
            try
            {
                _context.VocabWords.Remove(vocabWord);
                await _context.SaveChangesAsync();

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