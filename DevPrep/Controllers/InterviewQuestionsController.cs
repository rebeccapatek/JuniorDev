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
        public async Task<ActionResult> Create()
        {
            var interviewQuestion = new InterviewQuestion();
            return View(interviewQuestion);
        }

        // POST: InterviewQuestions/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(InterviewQuestion interviewQuestion)
        {
            try
            {

                var user = await GetCurrentUserAsync();

                var question = new InterviewQuestion
                {
                    Question = interviewQuestion.Question,
                    Answer = interviewQuestion.Answer,
                    ApplicationUserId = user.Id

                };


                _context.InterviewQuestions.Add(question);
                //Save changes to the databse
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InterviewQuestions/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var user = await GetCurrentUserAsync();
            var question = await _context.InterviewQuestions.FindAsync(id);
            if (question == null)
            {
                return NotFound();
            }
            return View(question);
        }

        // POST: InterviewQuestions/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, InterviewQuestion interviewQuestion)
        {
            try
            {

                var user = await GetCurrentUserAsync();

                var question = new InterviewQuestion
                {
                    Id = id,
                    Question = interviewQuestion.Question,
                    Answer = interviewQuestion.Answer,
                    ApplicationUserId = user.Id

                };


                _context.InterviewQuestions.Update(question);
                //Save changes to the databse
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InterviewQuestions/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var question = await _context.InterviewQuestions.FirstOrDefaultAsync(iq => iq.Id == id);
            //get the logged in user id
            var loggedInUser = await GetCurrentUserAsync();

            if (question.ApplicationUserId != loggedInUser.Id)
            {
                return NotFound();
            }

            return View(question);
        }

        // POST: InterviewQuestions/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, InterviewQuestion interviewQuestion)
        {
            try
            {
                _context.InterviewQuestions.Remove(interviewQuestion);
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