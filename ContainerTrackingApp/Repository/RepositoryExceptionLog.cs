using ContainerTrackingApp.Context;
using ContainerTrackingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContainerTrackingApp.Repository
{
    public class RepositoryExceptionLog : ILogService
    {

        DatabaseContext _context;

        public RepositoryExceptionLog()
        {
            _context = new DatabaseContext();
        }

        public void AddException(Exception exception)
        {
            ExceptionDetail exceptionDetail = new ExceptionDetail();
            System.Text.StringBuilder ErrorMessage = new System.Text.StringBuilder();
            ErrorMessage.Append("StackTrace --" + exception.StackTrace);
            ErrorMessage.Append("InnerException--" + exception.InnerException);
            ErrorMessage.Append("HelpLink--" + exception.InnerException.HelpLink);
            ErrorMessage.Append("HResult--" + exception.HResult);
            exceptionDetail.ID = 0;
            exceptionDetail.ExceptionMessage = exception.Message;
            exceptionDetail.ExceptionLocation = exception.Source;
            exceptionDetail.ExceptionTrace = ErrorMessage.ToString();
            exceptionDetail.ExceptionDateTime = DateTime.Now;

            DatabaseContext _context = new DatabaseContext();
            _context.ExceptionDetails.Add(exceptionDetail);
            _context.SaveChanges();

        }

        public List<ExceptionDetail> GetExceptionDetails()
        {
            var ExceptionList = (from excetionDetail in _context.ExceptionDetails
                                 orderby excetionDetail.ExceptionDateTime descending
                                 select excetionDetail).ToList();
            return ExceptionList;
       
        }
    }
}