﻿using ContainerTrackingApp.AES256;
using ContainerTrackingApp.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace ContainerTrackingApp.Filter
{
    public class APIAuthorizeAttribute: AuthorizeAttribute
    {
        private DatabaseContext db = new DatabaseContext();
        AES256Encryption EncryptionLibrary = new AES256Encryption();
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
                var encodedString = actionContext.Request.Headers.GetValues("Token").First();

                bool validFlag = false;

                if (!string.IsNullOrEmpty(encodedString))
                {
                    var key = EncryptionLibrary.Decrypt(encodedString);

                    string[] parts = key.Split(new char[] { ':' });

                    var UserID = Convert.ToInt32(parts[0]);       // UserID
                    var RandomKey = parts[1];                     // Random Key
                    var CompanyID = Convert.ToInt32(parts[2]);    // CompanyID
                    long ticks = long.Parse(parts[3]);            // Ticks
                    DateTime IssuedOn = new DateTime(ticks);
                    var ClientID = parts[4];                      // ClientID 


                    // By passing this parameter 
                    var registerModel = (from register in db.ClientKeys
                                         where register.CompanyID == CompanyID
                                         && register.UserID == UserID
                                         && register.ClientID == ClientID
                                         select register).FirstOrDefault();

                    if (registerModel != null)
                    {
                        // Validating Time
                        var ExpiresOn = (from token in db.TokensManager
                                         where token.CompanyID == CompanyID
                                         select token.ExpiredOn).FirstOrDefault();

                        if ((DateTime.Now > ExpiresOn))
                        {
                            validFlag = false;
                        }
                        else
                        {
                            validFlag = true;
                        }
                    }
                    else
                    {
                        validFlag = false;
                    }
                }
                return validFlag;
            }
            catch (Exception ex)
            {
                //return false;
                throw ex;
            }
        }
    }
  }
