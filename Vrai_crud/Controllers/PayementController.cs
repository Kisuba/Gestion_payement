using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QRCoder;
using Vrai_crud.Context;
using Vrai_crud.Models;

namespace Vrai_crud.Controllers
{
    public class PayementController : Controller
    {
        readonly dal_payement dbContext = new dal_payement();
        // GET: PayementController
        public ActionResult Index()
        {
            List<Payement> payementList = dbContext.List_payement().ToList();
            List<Payement> payementListe = new List<Payement>();
            return View(payementList);
        }

        // GET: PayementController/Details/5
        public ActionResult Details(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }
            Payement payement = dbContext.GetPayementByMatricule(id);
            if (payement == null)
            {
                return NotFound();
            }
            return View(payement);
            
        }

        public ActionResult Liste_paye(string  matricule)
        {
            if (matricule == "")
            {
                return NotFound();
            }
            List<Payement> payementList = dbContext.lite_payement_par_etudiant(matricule).ToList();
            List<Payement> payementListe = new List<Payement>();

            List<Payement> typefac = dbContext.Get_student_info(matricule);
            ViewBag.matricule = typefac.Select(x => x.matricule).ToList();
            ViewBag.noms = typefac.Select(x => x.noms).ToList();
            ViewBag.faculte = typefac.Select(x => x.faculte).ToList();
            ViewBag.promotion = typefac.Select(x => x.promotion).ToList();
            ViewBag.total = typefac.Select(x => x.total).ToList();
            ViewBag.photo = typefac.Select(x => x.photo).ToList();
            //return View();
            return View(payementList);
           
        }

        public ActionResult recu_payement(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }
            Payement payement = dbContext.recu_payement(id);
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
            if (payement == null)
            {
                return NotFound();
            }
            return View(payement);

        }

        // GET: PayementController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PayementController/Create
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

        // GET: PayementController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PayementController/Edit/5
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

        // GET: PayementController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PayementController/Delete/5
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
