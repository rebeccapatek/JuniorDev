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
    public class SoftwareLanguageController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public SoftwareLanguageController(ApplicationDbContext ctx, SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _context = ctx;
        }

        // GET: SoftwareLanguages
        public async Task<ActionResult> Index()
        {
            List<SoftwareLanguage> softwareLanguages = await _context.SoftwareLanguages.ToListAsync();
            return View(softwareLanguages);
        }

        // GET: SoftwareLanguages/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SoftwareLanguages/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SoftwareLanguages/Create
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

        // GET: SoftwareLanguages/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SoftwareLanguages/Edit/5
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

        // GET: SoftwareLanguages/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SoftwareLanguages/Delete/5
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