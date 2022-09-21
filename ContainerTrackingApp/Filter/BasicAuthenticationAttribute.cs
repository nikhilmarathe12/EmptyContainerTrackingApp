using ContainerTrackingApp.AES256;
using ContainerTrackingApp.Context;
using ContainerTrackingApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace ContainerTrackingApp.Filter
{
    public class BasicAuthenticationAttribute : AuthorizeAttribute
    {
        private DatabaseContext db = new DatabaseContext();
        IAuthenticate _IAuthenticate;

        public override void OnAuthorization(HttpActionContext filterContext)
        {
            if (Authorize(filterContext))
            {
                return;
            }
            HandleUnauthorizedRequest(filterContext);

        }
        protected override void HandleUnauthorizedRequest(HttpActionContext filterContext)
        {
            base.HandleUnauthorizedRequest(filterContext);
        }
        private bool Authorize(HttpActionContext actionContext)
        {
            try
            {
                bool validFlag = false;
                //var encodedString = actionContext.Request.Headers.GetValues("UserName").First();
                string authenticationString = actionContext.Request.Headers.Authorization.Parameter;
                string originalString = Encoding.UTF8.GetString(Convert.FromBase64String(authenticationString));

                if (!string.IsNullOrEmpty(originalString))
                {
                    // Gets username and password  
                    string usrename = originalString.Split(':')[0];
                    string password = originalString.Split(':')[1];

                    _IAuthenticate = new AuthenticateConcrete();
                    var clientkeys = _IAuthenticate.GetClientKeysDetailsbyCLientIDandClientSecert(usrename, password);
                    if (clientkeys != null)
                    {
                        validFlag = true;
                    }
                    else { validFlag = false; }
                }
                return validFlag;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}