using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Giftshop.Controllers
{
    public class GiftshopController : Controller
    {
        // GET: GistshopController1
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult index()
        {
            return View();
        }
        public ActionResult Shop()
        {
            return View();
        }
        public ActionResult testimonial()
        {
            return View();
        }
        public ActionResult Why()
        {
            return View();
        }

        // GET: GistshopController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GistshopController1/Create
        public ActionResult Create()
        {
            return View("Coustmerdata" );
        }

        // POST: GistshopController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GistshopController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GistshopController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GistshopController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GistshopController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
