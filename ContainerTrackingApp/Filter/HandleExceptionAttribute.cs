using ContainerTrackingApp.Context;
using ContainerTrackingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.ExceptionHandling;
using System.Web.Http.Filters;

namespace ContainerTrackingApp.Filter
{
    public class ErrorHandler : ActionFilterAttribute,IExceptionFilter
    {
        ExceptionDetail exceptionDetail;
        private DatabaseContext _context = null;

        public Task ExecuteExceptionFilterAsync(HttpActionExecutedContext actionExecutedContext, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public void OnException(ExceptionContext filterContext)
        {
            //
            var Controller = filterContext.ControllerContext.Controller.ToString();
            var ActionMethod = filterContext.ActionContext.ActionDescriptor.ActionName.ToString();

            exceptionDetail = new ExceptionDetail()
            {
                ID = 0,
                ExceptionMessage = filterContext.Exception.Message.ToString(),
                ExceptionLocation = "Controller - " + Controller + "- ActionMethod -" + ActionMethod +"  "+ filterContext.Exception.Source.ToString(),
                ExceptionTrace = filterContext.Exception.InnerException.InnerException.ToString(),
                ExceptionDateTime = DateTime.Now
            };
            _context.ExceptionDetails.Add(exceptionDetail);
            _context.SaveChanges();

        }

        
    }
}