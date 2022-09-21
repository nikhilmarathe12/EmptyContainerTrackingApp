using ContainerTrackingApp.AES256;
using ContainerTrackingApp.Filter;
using ContainerTrackingApp.Models;
using ContainerTrackingApp.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContainerTrackingApp.Controllers
{
    [CustomExceptionFilter]
    public class RegisterUserController : Controller
    {
        IRegisterUser repository;
        AES256Encryption EncryptionLibrary;
        public RegisterUserController()
        {
            EncryptionLibrary = new AES256Encryption();
            repository = new RegisterUserConcrete();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new RegisterUser());
        }

        [HttpPost]
        public ActionResult Create(RegisterUser RegisterUser)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View("Create", RegisterUser);
                }

                // Validating Username 
                if (repository.ValidateUsername(RegisterUser))
                {
                    ModelState.AddModelError("", "User is Already Registered");
                    return View("Create", RegisterUser);
                }
                RegisterUser.CreatedOn = DateTime.Now;
                
                // Encrypting Password with AES 256 Algorithm
                RegisterUser.Password = EncryptionLibrary.Encrypt(RegisterUser.Password.ToString());

                // Saving User Details in Database
                repository.Add(RegisterUser);
                TempData["UserMessage"] = "User Registered Successfully";
                ModelState.Clear();
                return View("Create", new RegisterUser());
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
            catch (Exception)
            {
                return View();
            }
        }
    }
}