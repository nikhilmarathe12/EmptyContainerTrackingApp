using ContainerTrackingApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ContainerTrackingApp.Service
{
    public class HttpClientRequestService
    {
        public string endPoint { get; set; }
        public httpVerb httpMethod { get; set; }
        public authenticationType authType { get; set; }
        public autheticationTechnique authTech { get; set; }
        public string userName { get; set; }
        public string userPassword { get; set; }

        public HttpClientRequestService()
        {
            endPoint = string.Empty;
            httpMethod = httpVerb.GET;
        }

        public async Task<string> CallWebAPIAsync(HttpClientRequestService httpClientRequestService, dtoConainerRequest conainerRequest)
        {
            string Message = string.Empty;
            using (var client = new HttpClient())
            {
                var authData = string.Format("{0}:{1}", httpClientRequestService.userName, httpClientRequestService.userPassword);
                var authHeaderValue = Convert.ToBase64String(Encoding.UTF8.GetBytes(authData));

                client.MaxResponseContentBufferSize = 256000;
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authHeaderValue);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //POST Method
                //var conainerRequest = new dtoConainerRequest() { request_carrier_code = "COSCO", request_key = "FSCU8724655", request_type = "c_id" };
                var Request = new dtoConainerRequest() { request_carrier_code = conainerRequest.request_carrier_code, request_key = conainerRequest.request_key, request_type = conainerRequest.request_type};
                //HttpResponseMessage responsePost = await client.PostAsJsonAsync("http://capi.ocean-insights.com/containertracking/v1/subscriptions/", conainerRequest);
                HttpResponseMessage responsePost = await client.PostAsJsonAsync(httpClientRequestService.endPoint, Request);
                if (responsePost.IsSuccessStatusCode)
                {
                    // Get the URI of the created resource.
                    Uri returnUrl = responsePost.Headers.Location;
                    //        Console.WriteLine(returnUrl);
                    Message= returnUrl.ToString();
                }
            }
            return Message;
        }
    }
}