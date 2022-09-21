using ContainerTrackingApp.Context;
using ContainerTrackingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContainerTrackingApp.Filter
{
    public class CustomExceptionFilterAttribute: FilterAttribute, IExceptionFilter
    {
        ExceptionDetail exceptionDetail;
        private DatabaseContext _context = null;

        public void OnException(ExceptionContext filterContext)
        {
            var Controller = filterContext.Controller.ToString();

            exceptionDetail = new ExceptionDetail();
            exceptionDetail.ID = 0;
            exceptionDetail.ExceptionMessage = filterContext.Exception.Message.ToString();
            exceptionDetail.ExceptionLocation = "Controller - " + Controller + "  " + filterContext.Exception.Source.ToString();
            exceptionDetail.ExceptionTrace = filterContext.Exception.StackTrace.ToString();
            exceptionDetail.ExceptionDateTime = DateTime.Now;

            _context = new DatabaseContext();
            _context.ExceptionDetails.Add(exceptionDetail);
            _context.SaveChanges();
        }
    }
}