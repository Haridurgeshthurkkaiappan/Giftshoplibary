using Giftshop.Models;
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
        public CourseBusiness obj1;


        public StudentController()
        {
            obj = new StudentInformationBusiness();
            obj1 = new CourseBusiness();
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
            var model = new StudentInfoModel();
            model.CourcesBE = obj1.Getcoursename();
            return View("Insert", model);
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StudentInfoModel data)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (obj.Itexists(data.Name))
                    {
                        ModelState.AddModelError("Name", "Name already exists");
                        data.CourcesBE = obj1.Getcoursename();
                        return View("Insert", data);
                    }
                    obj.InsertStudentInformation(data);
                    return RedirectToAction(nameof(List));
                }
                else
                {
                    data.CourcesBE = obj1.Getcoursename();
                    return View("Insert", data);

                }
            }
            catch (Exception ex)
            {
                return View("Error",new ErrorViewModel { CustomMessage = "Error in Insert", ActualErrorMessage = ex.Message });
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            var result = obj.GetStudentInformation(id);
            result.CourcesBE = obj1.Getcoursename();
           
            return View("Edit", result);
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, StudentInfoModel data)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if(obj.Itexistsyid(data.Name,data.studentid))
                    {
                        ModelState.AddModelError("Name", "Name already exists");
                        data.CourcesBE = obj1.Getcoursename();
                        return View("Edit", data);

                    }
                    obj.UpdateStudentInformation(data);
                    return RedirectToAction(nameof(List));
                }
                else
                {
                    data.CourcesBE = obj1.Getcoursename();
                    return View("Edit",  data);

                }
              
            }
            catch (Exception ex)
            {
                return View("Error", new ErrorViewModel { CustomMessage = "Error in Insert", ActualErrorMessage = ex.Message });
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int studentid)
        {
            var result = obj.GetStudentInformation(studentid);

            return View("Delete", result);
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Remove(int studentid)
        {
            try
            {
                obj.DeleteStudentInformation(studentid);
                return RedirectToAction(nameof(List));
            }
            catch (Exception ex)
            {
                return View("Error", new ErrorViewModel { CustomMessage = "Error in Insert", ActualErrorMessage = ex.Message });
            }
        }
    }
}
