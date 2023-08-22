using Giftshoplibary.Business;
using Giftshoplibary.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Giftshop.Controllers
{
    public class StudentController : Controller
    {
        public StudentInformationBusiness obj;

        public StudentController()
        {
            obj = new StudentInformationBusiness();
        }
        // GET: StudentController
        public ActionResult List()
        {
            return View("list", new List<StudentInfoModel>( obj.GetStudentInformations()));
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View("Insert", new StudentInfoModel());
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StudentInfoModel Data)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    obj.InsertStudentInformation(Data);
                    return RedirectToAction(nameof(List));
                }
                else
                {
                    return View("Insert", new StudentInfoModel());

                }
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentController/Edit/5
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

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentController/Delete/5
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
