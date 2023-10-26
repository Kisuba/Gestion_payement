using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Vrai_crud.Models;
using Vrai_crud.Context;
namespace Vrai_crud.Controllers
{
    public class StudentController : Controller
    {
        // GET: StudentController
        readonly Crud_Dal dbContext = new Crud_Dal();

        // GET: StudentController
        public ActionResult Index()
        {
            List<Student> studentList = dbContext.GetAllStudents().ToList();
          
            return View(studentList);
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }
            Student student = dbContext.GetStudentById(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind] Student student)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    dbContext.Create_student(student);
                    return RedirectToAction("Index");
                }
                return View(student);
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }
            Student student = dbContext.GetStudentById(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [Bind] Student student)
        {
            try
            {
                if (id <= 0)
                {
                    return NotFound();
                }
                if (ModelState.IsValid)
                {
                    dbContext.Update_student(student);
                    return RedirectToAction("Index");
                }
                return View(dbContext);
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }
            Student student = dbContext.GetStudentById(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // POST: StudentController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                dbContext.Delete_student(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
