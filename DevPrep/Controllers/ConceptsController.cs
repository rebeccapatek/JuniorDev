using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevPrep.Controllers
{
    public class ConceptController : Controller
    {
        // GET: Concept
        public ActionResult Index()
        {
            return View();
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