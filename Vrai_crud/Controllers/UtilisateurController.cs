using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vrai_crud.Models;
using Vrai_crud.Context;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Vrai_crud.Controllers
{
    public class UtilisateurController : Controller
    {
        // GET: UtilisateurController
        readonly dal_utilisateur dbContext = new dal_utilisateur();
       
        public ActionResult Index()
        {
            List<Utilisateur> userList = dbContext.Affutilisateur().ToList();
            List<Utilisateur> userListe = new List<Utilisateur>();
            return View(userList);
        }

        // GET: UtilisateurController/Details/5
        public ActionResult Details(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }
            Utilisateur student = dbContext.GetUserById(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // GET: UtilisateurController/Create
        [HttpGet]
        public ActionResult Create()
        {
            List<Utilisateur> typeuser = dbContext.GetUtilisateurs();
            SelectList selectLists = new SelectList(typeuser, "id", "noms");
            ViewBag.typeutilisateur = selectLists;
            return View();
        }

        // POST: UtilisateurController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind] Utilisateur utilisateur)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    dbContext.Create_utilisateur(utilisateur);
                    return RedirectToAction("Index");
                }
                return View(utilisateur);
            }
            catch
            {
                return View();
            }
        }

        // GET: UtilisateurController/Edit/5
        public ActionResult Edit(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }
            List<Utilisateur> typeuser = dbContext.GetUtilisateurs();
            SelectList selectLists = new SelectList(typeuser, "id", "noms");
            ViewBag.typeutilisateur = selectLists;

            Utilisateur utilisateur = dbContext.GetUserById(id);
            if (utilisateur == null)
            {
                return NotFound();
            }
            return View(utilisateur);
        }

        // POST: UtilisateurController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [Bind] Utilisateur utilisateur)
        {
            try
            {
                if (id <= 0)
                {
                    return NotFound();
                }
                if (ModelState.IsValid)
                {
                    dbContext.Update_utilisateur(utilisateur);
                    return RedirectToAction("Index");
                }
                return View(dbContext);
            }
            catch
            {
                return View();
            }
        }

        // GET: UtilisateurController/Delete/5
        public ActionResult Delete(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }
            Utilisateur utilisateur = dbContext.GetUserById(id);
            if (utilisateur== null)
            {
                return NotFound();
            }
            return View(utilisateur);
        }

        // POST: UtilisateurController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                dbContext.Delete_utilisateur(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
