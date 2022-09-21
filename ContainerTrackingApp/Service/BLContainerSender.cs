using ContainerTrackingApp.Controllers;
using ContainerTrackingApp.DTO;
using ContainerTrackingApp.Models;
using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContainerTrackingApp.Service
{
    //public class BLContainerSender : Hub
    public class BLContainerSender 
    {
        public async System.Threading.Tasks.Task DispatchToClientAsync(string SCACCode, string BillOfLading)
        {
            //foreach(string blcontainerinfo in BLConainer)
            //{
            //    Clients.All.broadcastMessage(blcontainerinfo);
            //}

            dtoConainerRequest _dtoConainerRequest = null;
            if (BillOfLading != null)
            {
                _dtoConainerRequest = new dtoConainerRequest() { request_carrier_code = SCACCode, request_key = BillOfLading, request_type = "m_bl" };
            }

            PushSubscriptionsController _PushSubscriptionsController = new PushSubscriptionsController();
            await _PushSubscriptionsController.ServiCallSubscriptions(_dtoConainerRequest);
            ///Clients.All.broadcastMessage(SCACCode,BillOfLading);
        }

        public BLContainerSender()
        {
            Action<string,string> dispatcher = async (SCACCode, BillOfLading) => { await DispatchToClientAsync(SCACCode, BillOfLading); };
            PushBLContainerInfo.GetInstance(dispatcher);

        }
    }
}