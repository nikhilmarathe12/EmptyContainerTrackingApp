using AutoMapper;
using ContainerTrackingApp.Context;
using ContainerTrackingApp.DTO;
using ContainerTrackingApp.Filter;
using ContainerTrackingApp.Models;
using ContainerTrackingApp.Repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ContainerTrackingApp.Controllers
{
    [CustomExceptionFilter]
    [APIAuthorizeAttribute]
    //[BasicAuthenticationAttribute]
    public class ShipmentController : ApiController
    {
        IRequestShipmentDetails _IRequestShipmentDetails;
        IEventPushDetails IEventPushDetails;
        ILogService _logService;
        public ShipmentController()
        {
            _logService = new RepositoryExceptionLog();
            _IRequestShipmentDetails = new RequestShipmentDetailsConcrete();
            IEventPushDetails = new EventPushReceiverConcrete();
        }

        [HttpPost]
        public HttpResponseMessage PostBLInformation(DTO.dtoEventPushReceiver getEventPushReceiver)
        {
            try
            {
                //RequestDetail requestDetails = Mapper.Map<dtoRequestDetails, RequestDetail>(getRequestDetails);


                //if(_IRequestShipmentDetails.AddShipmentInformation(getRequestDetails))
                //{
                //    return new HttpResponseMessage { StatusCode = HttpStatusCode.OK };
                //}
                //else
                //    return new HttpResponseMessage { StatusCode = HttpStatusCode.BadRequest };

                if (IEventPushDetails.AddShipmentInformation(getEventPushReceiver))
                {
                    return new HttpResponseMessage { StatusCode = HttpStatusCode.OK };
                }
                else
                    return new HttpResponseMessage { StatusCode = HttpStatusCode.BadRequest };

            }
            catch (System.Exception ex)
            {
                _logService.AddException(ex);
                throw;
            }
        }
    }
}
