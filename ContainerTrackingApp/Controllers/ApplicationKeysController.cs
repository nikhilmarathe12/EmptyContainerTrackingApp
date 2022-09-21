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
    public class ApplicationKeysController : Controller
    {
        IClientKeys _IClientKeys;
        IRegisterCompany _IRegisterCompany;

        public ApplicationKeysController()
        {
            _IClientKeys = new ClientKeysConcrete();
            _IRegisterCompany = new RegisterCompanyConcrete();
        }

        [HttpGet]
        public ActionResult GetApplicationKey()
        {
            try
            {
                ClientKey clientkeys = new ClientKey();

                // Validating ClientID and ClientSecert already Exists
                var keyExists = _IClientKeys.IsUniqueKeyAlreadyGenerate(Convert.ToInt32(Session["UserID"]));
                if (keyExists)
                {
                    // Getting Generate ClientID and ClientSecert Key By UserID
                    clientkeys = _IClientKeys.GetGenerateUniqueKeyByUserID(Convert.ToInt32(Session["UserID"]));
                    var (ClientName, clientSecertName) = _IClientKeys.GenerateDecryptedKey(clientkeys.ClientID, clientkeys.ClientSecret);
                    clientkeys.ClientID = ClientName;
                    clientkeys.ClientSecret = clientSecertName;
                }
                else
                {
                    string clientID = string.Empty;
                    string clientSecert = string.Empty;
                    int companyId = 0;
                    var company = _IRegisterCompany.FindCompanyByUserId(Convert.ToInt32(Session["UserID"]));
                    companyId = company.CompanyID;
                    //Saving Keys Details in Database
                    clientkeys.ClientKeyID = 0;
                    clientkeys.CompanyID = companyId;
                    clientkeys.CreatedOn = DateTime.Now;
                    clientkeys.ClientID = clientID;
                    clientkeys.ClientSecret = clientSecert;
                    clientkeys.UserID = Convert.ToInt32(Session["UserID"]);
                }
                return View(clientkeys);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public ActionResult GetApplicationKeyByID(int ID)
        {
            try
            {
                ClientKey clientkeys = new ClientKey();

                // Validating ClientID and ClientSecert already Exists
                var keyExists = _IClientKeys.IsUniqueKeyAlreadyGenerate(Convert.ToInt32(Session["UserID"]), ID);
                if (keyExists)
                {
                    // Getting Generate ClientID and ClientSecert Key By UserID
                    clientkeys = _IClientKeys.GetGenerateUniqueKeyByUserID(Convert.ToInt32(Session["UserID"]), ID);
                    var (ClientName, clientSecertName) = _IClientKeys.GenerateDecryptedKey(clientkeys.ClientID, clientkeys.ClientSecret);
                    clientkeys.ClientID = ClientName;
                    clientkeys.ClientSecret = clientSecertName;
                }
                else
                {
                    string clientID = string.Empty;
                    string clientSecert = string.Empty;
                    int companyId = 0;
                    var company = _IRegisterCompany.FindCompanyByUserId(Convert.ToInt32(Session["UserID"]), ID);
                    companyId = company.CompanyID;
                    //Saving Keys Details in Database
                    clientkeys.ClientKeyID = 0;
                    clientkeys.CompanyID = companyId;
                    clientkeys.CreatedOn = DateTime.Now;
                    clientkeys.ClientID = clientID;
                    clientkeys.ClientSecret = clientSecert;
                    clientkeys.UserID = Convert.ToInt32(Session["UserID"]);
                }
                return View(clientkeys);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        // GET: ApplicationKeys/GenerateKeys
        //[HttpGet]
        //public ActionResult GenerateKeys()
        //{
        //    try
        //    {
        //        ClientKey clientkeys = new ClientKey();

        //        // Validating ClientID and ClientSecert already Exists
        //        var keyExists = _IClientKeys.IsUniqueKeyAlreadyGenerate(Convert.ToInt32(Session["UserID"]));

        //        if (keyExists)
        //        {
        //            // Getting Generate ClientID and ClientSecert Key By UserID
        //            clientkeys = _IClientKeys.GetGenerateUniqueKeyByUserID(Convert.ToInt32(Session["UserID"]));
        //        }
        //        else
        //        {
        //            string clientID = string.Empty;
        //            string clientSecert = string.Empty;
        //            int companyId = 0;

        //            var company = _IRegisterCompany.FindCompanyByUserId(Convert.ToInt32(Session["UserID"]));
        //            companyId = company.CompanyID;

        //            //Generate Keys
        //            _IClientKeys.GenerateUniqueKey(clientID, clientSecert);


        //            //Saving Keys Details in Database
        //            clientkeys.ClientKeyID = 0;
        //            clientkeys.CompanyID = companyId;
        //            clientkeys.CreatedOn = DateTime.Now;
        //            clientkeys.ClientID = clientID;
        //            clientkeys.ClientSecret = clientSecert;
        //            clientkeys.UserID = Convert.ToInt32(Session["UserID"]);
        //            _IClientKeys.SaveClientIDandClientSecert(clientkeys);

        //        }

        //        return View(clientkeys);
        //    }
        //    catch (DbEntityValidationException e)
        //    {
        //        foreach (var eve in e.EntityValidationErrors)
        //        {
        //            Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
        //                eve.Entry.Entity.GetType().Name, eve.Entry.State);
        //            foreach (var ve in eve.ValidationErrors)
        //            {
        //                Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
        //                    ve.PropertyName, ve.ErrorMessage);
        //            }
        //        }
        //        throw;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}


        // POST: ApplicationKeys/GenerateKeys
        [HttpPost]
        public ActionResult GenerateKeys(ClientKey clientkeys)
        {
            try
            {
                string clientID = clientkeys.ClientID;
                string clientSecert = clientkeys.ClientSecret;

                //Generate Keys
                // _IClientKeys.GenerateUniqueKey(out clientID, out clientSecert);
                var (ClientName, clientSecertName) = _IClientKeys.GenerateEncryptedKey(clientID, clientSecert);

                //Updating ClientID and ClientSecert 
                var company = _IRegisterCompany.FindCompanyByUserId(Convert.ToInt32(Session["UserID"]), clientkeys.CompanyID);
                //var company = _IRegisterCompany.FindCompanyByUserId(Convert.ToInt32(Session["UserID"]));
                clientkeys.CompanyID = company.CompanyID;
                clientkeys.CreatedOn = DateTime.Now;
                clientkeys.ClientID = ClientName;
                clientkeys.ClientSecret = clientSecertName;
                clientkeys.UserID = Convert.ToInt32(Session["UserID"]);
                _IClientKeys.SaveClientIDandClientSecert(clientkeys);

                return RedirectToAction("GetApplicationKey");
                //return RedirectToAction("ListOfGeneratedKeys");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ActionResult ListOfGeneratedKeys()
        {
            try
            {
                List<ClientTokenViewModel> listVMClientToken =  _IClientKeys.GetLitKeysTokenListByUserID(Convert.ToInt32(Session["UserID"]));
                return View(listVMClientToken);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ActionResult GetClientKeyTokenDetails(int ID)
        {
            try
            {
                ClientTokenViewModel clientToken = new ClientTokenViewModel();
                var keyExists = _IClientKeys.IsUniqueKeyAlreadyGenerate(Convert.ToInt32(Session["UserID"]), ID);
                if (keyExists)
                {
                    // Getting Generate ClientID and ClientSecert Key By UserID
                    clientToken = _IClientKeys.GetClientTokenByID(Convert.ToInt32(Session["UserID"]), ID);
                }
                else
                {
                    string clientID = string.Empty;
                    string clientSecert = string.Empty;
                    int companyId = 0;
                    var company = _IRegisterCompany.FindCompanyByUserId(Convert.ToInt32(Session["UserID"]), ID);
                    companyId = company.CompanyID;
                    //Saving Keys Details in Database
                    clientToken.ClientKeyID = 0;
                    clientToken.CompanyID = companyId;
                    clientToken.CreatedOn = DateTime.Now;
                    clientToken.ClientID = clientID;
                    clientToken.ClientSecret = clientSecert;
                    clientToken.UserID = Convert.ToInt32(Session["UserID"]);
                }
                return View(clientToken);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}