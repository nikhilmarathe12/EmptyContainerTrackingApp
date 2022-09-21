using ContainerTrackingApp.Models;
using ContainerTrackingApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContainerTrackingApp.Controllers
{
    public class RequestInformationController : Controller
    {
        IRequestContainerInfo _IRequestContainerInfo;
        public RequestInformationController()
        {
            _IRequestContainerInfo = new RequestContainerInfo();
        }
        // GET: GMapLocation
        public ActionResult RequestContainer()
        {
            List<RequestDetail> requestDetails = _IRequestContainerInfo.GetListRequestDetails();
            return View(requestDetails);
        }

        public ActionResult ContainerDetailView(int RequestID)
        {
            List<ContainershipmentDetails> containershipmentDetails = _IRequestContainerInfo.GetListContainerDetailsByRequestID(Convert.ToInt32(RequestID));
            return View(containershipmentDetails);
        }

        public ActionResult RequestSearchByBlNumber(string BLNumber)
        {
            List<RequestDetail> requestDetails = _IRequestContainerInfo.GetListRequestDetails().Where(x=> x.request_key == BLNumber).ToList() ;
            return View("RequestContainer", requestDetails);
        }
    }
}