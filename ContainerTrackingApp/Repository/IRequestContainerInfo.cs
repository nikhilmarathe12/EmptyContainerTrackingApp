using ContainerTrackingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerTrackingApp.Repository
{
    public interface IRequestContainerInfo
    {
        List<RequestDetail> GetListRequestDetails();
        List<ContainershipmentDetails> GetListContainerDetailsByRequestID(int strRequestID);
    }
}
