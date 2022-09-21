using ContainerTrackingApp.Filter;
using ContainerTrackingApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContainerTrackingApp.Controllers
{
    [CustomExceptionFilter]
    public class ExceptionDetailsController : Controller
    {

        ILogService _logService;

        public ExceptionDetailsController()
        {
            _logService = new RepositoryExceptionLog();
        }
        // GET: ExceptionDetails
        public ActionResult Index()
        {
            var ExceptionInfo = _logService.GetExceptionDetails();
            return View(ExceptionInfo);
        }
    }
}