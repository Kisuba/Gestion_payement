using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vrai_crud.Models;
using Vrai_crud.Context;

namespace Vrai_crud.Controllers
{
    public class FaculteController : Controller
    {
        // GET: FaculteController
        readonly dal_fac dbContext = new dal_fac();
        public ActionResult Index()
        {
            List<Faclute> userList = dbContext.Aff_fac().ToList();
            List<Faclute> userListe = new List<Faclute>();
            return View(userList);
        }

        // GET: FaculteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FaculteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FaculteController/Create
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

        // GET: FaculteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FaculteController/Edit/5
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

        // GET: FaculteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FaculteController/Delete/5
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
