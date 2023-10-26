using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vrai_crud.Models;
using Vrai_crud.Context;
using Microsoft.AspNetCore.Mvc.Rendering;
using QRCoder;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace Vrai_crud.Controllers
{
    public class etudiantController : Controller
    {
        // GET: etudiantController
        readonly dal_etudiant dbContext = new dal_etudiant();

        public ActionResult Index()
        {
        
            List<etudiant> userList = dbContext.List_etudiants().ToList();
            List<etudiant> userListe = new List<etudiant>();
            return View(userList);
        }

        // GET: etudiantController/Details/5
        public ActionResult Details(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }
            etudiant etudiant = dbContext.GetEtudiantById(id);

            int matricule = id;
            QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
            QRCodeData qRCodeData = qRCodeGenerator.CreateQrCode(matricule.ToString(), QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qRCodeData);

            using (MemoryStream ms = new MemoryStream())
            {
                using (Bitmap bitmap = qrCode.GetGraphic(20))
                {
                    bitmap.Save(ms, ImageFormat.Png);
                    ViewBag.QRCodeImage = "data:image/png;base64," + Convert.ToBase64String(ms.ToArray());
                   
                }

            }

            if (etudiant == null)
            {
                return NotFound();
            }
            return View(etudiant);
        }

        // GET: etudiantController/Details/5
        public ActionResult Payement(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }
            etudiant etudiant = dbContext.GetEtudiantById(id);
            if (etudiant == null)
            {
                return NotFound();
            }
            return View(etudiant);
        }
        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Payement(int id, [Bind] etudiant etudiant)
        {
            try
            {
                if (id <= 0)
                {
                    return NotFound();
                }
                if (ModelState.IsValid)
                {
                    dbContext.Paiement_student(etudiant);
                    return RedirectToAction("Index", "Payement");
                }
                return View(dbContext);
            }
            catch
            {
                return View();
            }
        }

        // GET: etudiantController/Create
        [HttpGet]
        public ActionResult Create()
        {
           List<Faclute> typefac = dbContext.GetFac();
           SelectList selectLists = new SelectList(typefac, "id", "nom_faculte");
           ViewBag.typefaculte = selectLists;

            List<Promotion> typeprom = dbContext.Promotion();
            SelectList selectList = new SelectList(typeprom, "id", "promotion");
            ViewBag.typepromotion = selectList;
            return View();
        }

        // POST: UtilisateurController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync([Bind] etudiant etudiants, IFormFile fichier)
        {
            var cheminFichier = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", fichier.FileName);
            var nom = fichier.FileName;
            using (var stream = new FileStream(cheminFichier, FileMode.Create))
            {
                await fichier.CopyToAsync(stream);
            }

            var image = new etudiant
            {
                //Nom = fichier.FileName,
                photo = nom,

                //Taille = (int)fichier.Length
            };

            dbContext.Create_etudiant(etudiants, image);
               return RedirectToAction("Index");
               
        }


        // GET: etudiantController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: etudiantController/Edit/5
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

        // GET: etudiantController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: etudiantController/Delete/5
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
