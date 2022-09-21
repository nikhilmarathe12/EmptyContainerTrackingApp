using ContainerTrackingApp.Context;
using ContainerTrackingApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ContainerTrackingApp.Service
{
    public class PushBLContainerInfo
    {
        static PushBLContainerInfo _instance = null;
        NewBLContainerNotifier _newBLContainerNotifier;
        Action<string,string> _dispatcher;
        string _connString;
        string _selectQuery;
        public static PushBLContainerInfo GetInstance(Action<string, string> dispatcher)
        {
            if (_instance == null)
                _instance = new PushBLContainerInfo(dispatcher);

            return _instance;
        }

        private PushBLContainerInfo(Action<string,string> dispatcher)
        {
            _dispatcher = dispatcher;
            _connString = ConfigurationManager.ConnectionStrings["ContainerTrackingDBEntities"].ConnectionString;
            _selectQuery = @"SELECT [CID],[SCAC_Code],[ContainerNumber],[BillOfLading],[BookingNumber],[ProcessSend],[ProcessStatus],[ContainerStatus],[StatusDate],[CreatedOn],[ModifiedOn] FROM [dbo].[ContainerTrackingStatusInfoes]";
            _newBLContainerNotifier = new NewBLContainerNotifier(_connString, _selectQuery);
            _newBLContainerNotifier.NewBLnContainer += NewBLnContainerInformationRecieved;
        }

        private void NewBLnContainerInformationRecieved(object sender, SqlNotificationEventArgs e)
        {
            IEnumerable<ContainerTracking> newContainerTrackingStatusInfo = FetchContainerTrackingStatusInfoFromDB();
            ContainerTracking _containerRequest = (from s in newContainerTrackingStatusInfo select new ContainerTracking { SCAC_Code = s.SCAC_Code, BillOfLading = s.BillOfLading }).FirstOrDefault();
            _dispatcher(_containerRequest.SCAC_Code, _containerRequest.BillOfLading);
        }

        private IEnumerable<ContainerTracking> FetchContainerTrackingStatusInfoFromDB()
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                var Query = db.ContainerTracking.Where(lm => lm.ProcessSend == false);
                return Query.ToList();
            }
        }
    }
}