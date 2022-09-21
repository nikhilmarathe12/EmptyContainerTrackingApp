using ContainerTrackingApp.DTO;
using ContainerTrackingApp.Filter;
using ContainerTrackingApp.Repository;
using ContainerTrackingApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ContainerTrackingApp.Controllers
{
    [CustomExceptionFilter]
    public class PushSubscriptionsController : ApiController
    {
        private ISubscriptionPost _ISubscriptionPost = null;
        
        public async Task<HttpResponseMessage>  CallSubscriptionsAPI(dtoConainerRequest _ConainerRequest)
        {
            try
            {
                ///dtoConainerRequest _ConainerRequest = new dtoConainerRequest();
                HttpClientRequestService httpClientRequestService = new HttpClientRequestService();
                httpClientRequestService.authTech = autheticationTechnique.NetworkCredential;
                httpClientRequestService.httpMethod = httpVerb.POST;
                httpClientRequestService.authType = authenticationType.Basic;
                httpClientRequestService.userName = "premier_info_dev";
                httpClientRequestService.userPassword = "Moll189-irre";
                //restClient.endPoint = "http://localhost:51846/api/Product";
                httpClientRequestService.endPoint = "http://capi.ocean-insights.com/containertracking/v1/subscriptions/";

                await _ISubscriptionPost.SubscriptionContainerDetails(httpClientRequestService, _ConainerRequest);
                var message = new HttpResponseMessage(HttpStatusCode.OK);
                return message;
                #region "Commented code direct call to Services"
                //---------------------------------------
                //dtoConainerRequest _ConainerRequest = new dtoConainerRequest();
                //HttpClientRequestService httpClientRequestService = new HttpClientRequestService();
                //httpClientRequestService.authTech = autheticationTechnique.NetworkCredential;
                //httpClientRequestService.httpMethod = httpVerb.POST;
                //httpClientRequestService.authType = authenticationType.Basic;
                //httpClientRequestService.userName = "premier_info_dev";
                //httpClientRequestService.userPassword = "Moll189-irre";
                ////restClient.endPoint = "http://localhost:51846/api/Product";
                //httpClientRequestService.endPoint = "http://capi.ocean-insights.com/containertracking/v1/subscriptions/";
                //await httpClientRequestService.CallWebAPIAsync(httpClientRequestService, _ConainerRequest);
                //var message = new HttpResponseMessage(HttpStatusCode.OK);
                //return message;
                #endregion
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [NonAction]
        public async Task ServiCallSubscriptions(dtoConainerRequest _ConainerRequest)
        {
            try
            {
                dtoConainerRequest ConainerRequest = new dtoConainerRequest();
                ConainerRequest = _ConainerRequest;
                HttpClientRequestService httpClientRequestService = new HttpClientRequestService();
                httpClientRequestService.authTech = autheticationTechnique.NetworkCredential;
                httpClientRequestService.httpMethod = httpVerb.POST;
                httpClientRequestService.authType = authenticationType.Basic;
                httpClientRequestService.userName = "premier_info_dev";
                httpClientRequestService.userPassword = "Moll189-irre";
                //restClient.endPoint = "http://localhost:51846/api/Product";
                httpClientRequestService.endPoint = "http://capi.ocean-insights.com/containertracking/v1/subscriptions/";

                _ISubscriptionPost = new SubscriptionPostConcrete();

                await _ISubscriptionPost.SubscriptionContainerDetails(httpClientRequestService, ConainerRequest);
                var message = new HttpResponseMessage(HttpStatusCode.OK);
                //return message;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
