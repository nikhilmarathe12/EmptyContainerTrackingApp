using ContainerTrackingApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerTrackingApp.Repository
{
    public interface IEventPushDetails
    {
        bool AddShipmentInformation(dtoEventPushReceiver requestDetailsInfo);
    }
}
