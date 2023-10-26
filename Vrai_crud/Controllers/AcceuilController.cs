using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Vrai_crud.Controllers
{
    public class AcceuilController : Controller
    {
        // GET: AcceuilController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AcceuilController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AcceuilController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AcceuilController/Create
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

        // GET: AcceuilController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AcceuilController/Edit/5
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

        // GET: AcceuilController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AcceuilController/Delete/5
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
