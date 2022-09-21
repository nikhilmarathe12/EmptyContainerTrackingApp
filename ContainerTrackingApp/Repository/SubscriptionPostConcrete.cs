using ContainerTrackingApp.Context;
using ContainerTrackingApp.DTO;
using ContainerTrackingApp.Models;
using ContainerTrackingApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ContainerTrackingApp.Repository
{
    public class SubscriptionPostConcrete : ISubscriptionPost
    {
        DatabaseContext _context;
        ILogService _logService;
        public SubscriptionPostConcrete()
        {
            _logService = new RepositoryExceptionLog();
            _context = new DatabaseContext();
        }

        public async Task<string> SubscriptionContainerDetails(HttpClientRequestService httpClientRequestService, dtoConainerRequest conainerRequest)
        {
            try
            {
                //HttpClientRequestService httpClientRequestService = new HttpClientRequestService();
                //httpClientRequestService.authTech = autheticationTechnique.NetworkCredential;
                //httpClientRequestService.httpMethod = httpVerb.POST;
                //httpClientRequestService.authType = authenticationType.Basic;
                //httpClientRequestService.userName = username;
                //httpClientRequestService.userPassword = password;
                ////restClient.endPoint = "http://localhost:51846/api/Product";
                //httpClientRequestService.endPoint = "http://capi.ocean-insights.com/containertracking/v1/subscriptions/";
                string message = await httpClientRequestService.CallWebAPIAsync(httpClientRequestService, conainerRequest);
                return message;
            }
            catch (Exception ex)
            {
                _logService.AddException(ex);
                throw ex;
            }
}
    }
}