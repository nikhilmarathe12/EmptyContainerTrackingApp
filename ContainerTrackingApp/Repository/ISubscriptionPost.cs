using ContainerTrackingApp.DTO;
using ContainerTrackingApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerTrackingApp.Repository
{
    public interface ISubscriptionPost
    {
        Task<string> SubscriptionContainerDetails(HttpClientRequestService httpClientRequestService, dtoConainerRequest conainerRequest);

    }
}
