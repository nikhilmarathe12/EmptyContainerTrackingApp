using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContainerTrackingApp.Context;
using ContainerTrackingApp.Models;

namespace ContainerTrackingApp.Repository
{
    public class RequestContainerInfo : IRequestContainerInfo
    {
        DatabaseContext _context;
        ILogService _logService;
        public RequestContainerInfo()
        {
            _logService = new RepositoryExceptionLog();
            _context = new DatabaseContext();
        }


        public List<RequestDetail> GetListRequestDetails()
        {
            try
            {
                var RequestList = (from Request in _context.RequestDetails
                                   select Request).ToList();
                return RequestList;
            }
            catch (Exception ex)
            {
                _logService.AddException(ex);
                throw ex;
            }
        }

        public List<ContainershipmentDetails> GetListContainerDetailsByRequestID(int strRequestID)
        {
            try
            {
                var ContainerList = (from container in _context.ContainershipmentDetails
                                     where container.RequestID == strRequestID
                                     select container).ToList();
                return ContainerList;
            }
            catch(Exception ex)
            {
                _logService.AddException(ex);
                throw ex;
            }
        }
    }
}