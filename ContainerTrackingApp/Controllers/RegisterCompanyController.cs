using ContainerTrackingApp.Filter;
using ContainerTrackingApp.Models;
using ContainerTrackingApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContainerTrackingApp.Controllers
{
    [CustomExceptionFilter]
    public class RegisterCompanyController : Controller
    {
        IRegisterCompany _IRegister;
        IRegisterUser _IRegisterUser;
        public RegisterCompanyController()
        {
            _IRegister = new RegisterCompanyConcrete();
            _IRegisterUser = new RegisterUserConcrete();
        }

        // GET: RegisterCompany
        public ActionResult Index()
        {
            var RegisterList = _IRegister.ListofCompanies(Convert.ToInt32(Session["UserID"]));
            return View(RegisterList);
        }

        public ActionResult Create(string info)
        {
            var Company = _IRegister.CheckIsCompanyRegistered(Convert.ToInt32(Session["UserID"]));
            if (Company)
            {
                if (info == "Index")
                {
                    return RedirectToAction("Index");

                }
                else if(info== "Create")
                {
                    var UserInfo = _IRegisterUser.GetUser(Convert.ToInt32(Session["UserID"]));
                    ViewBag.UserName = UserInfo.UserName;
                    return View();
                }
            }
            else
            {
                var UserInfo = _IRegisterUser.GetUser(Convert.ToInt32(Session["UserID"]));
                ViewBag.UserName = UserInfo.UserName;
            }
            return View();
        }

        [HttpPost]
        public ActionResult Create(RegisterCompany RegisterCompany)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View("Create", RegisterCompany);
                }

                if (_IRegister.ValidateCompanyName(RegisterCompany))
                {
                    ModelState.AddModelError("", "Company is Already Registered");
                    return View("Create", RegisterCompany);
                }
                RegisterCompany.UserID = Convert.ToInt32(Session["UserID"]);
                RegisterCompany.CreatedOn = DateTime.Now;
                _IRegister.Add(RegisterCompany);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

      
        public ActionResult Edit(int ID)
        {
            var Company = _IRegister.FindCompanyByCompanyId(ID);
            if (Company != null)
            {
                return View(Company);
            }
            return RedirectToAction("Index");
        }
        
        [HttpPost]
        public ActionResult Edit(RegisterCompany registerCompany)
        {
                var Company = _IRegister.FindCompanyByCompanyId(registerCompany.CompanyID);
                Company.Name = registerCompany.Name;
                Company.PersonInCharge = registerCompany.PersonInCharge;
                Company.Description = registerCompany.Description;
                _IRegister.Update(Company);
                return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var Company = _IRegister.FindCompanyByCompanyId(id);
            return View(Company);
        }

        [HttpPost]
        public ActionResult Delete(int ID)
        {
            var Company = _IRegister.FindCompanyByCompanyId(ID);
            if(Company!=null)
                return Json(true, JsonRequestBehavior.AllowGet);
            return Json(false, JsonRequestBehavior.AllowGet);
        }
    }
}