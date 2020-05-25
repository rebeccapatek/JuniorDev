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
using Microsoft.EntityFrameworkCore;

namespace DevPrep.Controllers
{
    [Authorize]
    public class InterviewQuestionsController : Controller
    {
            private readonly ApplicationDbContext _context;
            private readonly SignInManager<ApplicationUser> _signInManager;
            private readonly UserManager<ApplicationUser> _userManager;

            public InterviewQuestionsController(ApplicationDbContext ctx, SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
            {
                _signInManager = signInManager;
                _userManager = userManager;
                _context = ctx;
            }
            // GET: InterviewQuestions
            public async Task<ActionResult> Index()
        {
    
                var model = new InterviewQuestionViewModel();
                var user = await GetCurrentUserAsync();
                model.InterviewQuestions = await _context.InterviewQuestions.ToListAsync();
                model.LoggedInUser = user;
                return View(model);
            
        }

        // GET: InterviewQuestions/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InterviewQuestions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InterviewQuestions/Create
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

        // GET: InterviewQuestions/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InterviewQuestions/Edit/5
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

        // GET: InterviewQuestions/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InterviewQuestions/Delete/5
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