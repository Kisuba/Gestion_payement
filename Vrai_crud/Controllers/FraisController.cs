using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vrai_crud.Context;
using Vrai_crud.Models;
namespace Vrai_crud.Controllers
{
    public class FraisController : Controller
    {
        readonly dal_frais dbContext = new dal_frais();
        // GET: FraisController
        public ActionResult Index()
        {
            List<Frais> fraisList = dbContext.Aff_frais().ToList();
            List<Frais> fraisListe = new List<Frais>();
            return View(fraisList);
        }

        // GET: FraisController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FraisController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FraisController/Create
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

        // GET: FraisController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FraisController/Edit/5
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

        // GET: FraisController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FraisController/Delete/5
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
