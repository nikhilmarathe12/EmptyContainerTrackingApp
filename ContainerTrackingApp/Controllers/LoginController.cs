using ContainerTrackingApp.AES256;
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
    public class LoginController : Controller
    {
        IRegisterUser _IRegisterUser;
        AES256Encryption EncryptionLibrary;
        public LoginController()
        {
            _IRegisterUser = new RegisterUserConcrete();
            EncryptionLibrary = new AES256Encryption();
        }

        // GET: Login
        public ActionResult Login()
        {
            return View(new RegisterUser());
        }

        [HttpPost]
        public ActionResult Login(RegisterUser RegisterUser)
        {
            try
            {
                if (string.IsNullOrEmpty(RegisterUser.UserName) && (string.IsNullOrEmpty(RegisterUser.Password)))
                {
                    ModelState.AddModelError("", "Enter Username and Password");
                }
                else if (string.IsNullOrEmpty(RegisterUser.UserName))
                {
                    ModelState.AddModelError("", "Enter Username");
                }
                else if (string.IsNullOrEmpty(RegisterUser.Password))
                {
                    ModelState.AddModelError("", "Enter Password");
                }
                else
                {

                    RegisterUser.Password = EncryptionLibrary.Encrypt(RegisterUser.Password);
                    if (_IRegisterUser.ValidateRegisteredUser(RegisterUser))
                    {
                        var UserID = _IRegisterUser.GetLoggedUserID(RegisterUser);
                        Session["UserID"] = UserID;
                        return RedirectToAction("Create", "RegisterCompany", new { info="Index"});
                    }
                    else
                    {
                        ModelState.AddModelError("", "User is not registered.Please Sign up again!");
                        return View("Login", RegisterUser);
                    }
                }
                return View("Login", RegisterUser);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Login", "Login");
        }
    }
}