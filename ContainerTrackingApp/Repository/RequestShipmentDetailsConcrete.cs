using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using ContainerTrackingApp.Context;
using ContainerTrackingApp.DTO;
using ContainerTrackingApp.Models;

namespace ContainerTrackingApp.Repository
{
    public class RequestShipmentDetailsConcrete : IRequestShipmentDetails
    {
        DatabaseContext _context;
        ILogService _logService;
        public RequestShipmentDetailsConcrete()
        {
            _logService = new RepositoryExceptionLog();
            _context = new DatabaseContext();
        }
        public bool AddShipmentInformation(dtoRequestDetails requestDetailsInfo)
        {
            try
            {
                RequestDetail requestDetails = Mapper.Map<dtoRequestDetails, RequestDetail>(requestDetailsInfo);
                ContainershipmentDetails _ContainershipmentDetails;
                var requestID = requestDetails.ID;
                requestDetails.RequestID = requestID;
                List<ContainershipmentDetails> ListOfContainerDetail = new List<ContainershipmentDetails>();

                if (requestDetailsInfo.containershipments.Count > 0)
                {
                    foreach (var shipment in requestDetailsInfo.containershipments)
                    {
                        _ContainershipmentDetails = new ContainershipmentDetails();
                        _ContainershipmentDetails = Mapper.Map<dtoContainershipments, ContainershipmentDetails>(shipment);
                        _ContainershipmentDetails.RequestID = requestID;
                        _ContainershipmentDetails.ContainerID = shipment.id.ToString();

                        if (shipment.current_vessel_nextport != null)
                        {
                            Vesselnextport vesselNextPort = new Vesselnextport();
                            vesselNextPort = Mapper.Map<dtoVesselnextport, Vesselnextport>(shipment.current_vessel_nextport);
                            _ContainershipmentDetails.current_vessel_nextport_eta = vesselNextPort.eta;
                            _ContainershipmentDetails.current_vessel_nextport_locode = vesselNextPort.locode;
                            _ContainershipmentDetails.current_vessel_nextport_name = vesselNextPort.name;
                        }

                        if (shipment.current_vessel_position != null)
                        {
                            VesselPosition vesselposition = new VesselPosition();
                            vesselposition = Mapper.Map<dtoVesselPosition, VesselPosition>(shipment.current_vessel_position);
                            _ContainershipmentDetails.current_vessel_position_heading = vesselposition.heading;
                            _ContainershipmentDetails.current_vessel_position_latitude = vesselposition.latitude;
                            _ContainershipmentDetails.current_vessel_position_longitude = vesselposition.longitude;
                            _ContainershipmentDetails.current_vessel_position_timestamp = vesselposition.timestamp;
                        }

                        if (shipment.current_vessel != null)
                        {
                            VesselInfo vesselNextPort = new VesselInfo();
                            vesselNextPort = Mapper.Map<dtoVesselInfo, VesselInfo>(shipment.current_vessel);
                            _ContainershipmentDetails.current_vessel_id = vesselNextPort.id;
                            _ContainershipmentDetails.current_vessel_imo = vesselNextPort.imo;
                            _ContainershipmentDetails.current_vessel_name = vesselNextPort.name;
                        }

                        if (shipment.empty_pickup_loc != null)
                        {
                            LocationInfo empty_pickup_loc = new LocationInfo();
                            empty_pickup_loc = Mapper.Map<dtoLocationInfo, LocationInfo>(shipment.empty_pickup_loc);
                            _ContainershipmentDetails.empty_pickup_loc_name = empty_pickup_loc.name;
                            _ContainershipmentDetails.empty_pickup_loc_locode = empty_pickup_loc.locode;
                        }

                        if (shipment.lif_loc != null)
                        {
                            LocationInfo lif_loc = new LocationInfo();
                            lif_loc = Mapper.Map<dtoLocationInfo, LocationInfo>(shipment.lif_loc);
                            _ContainershipmentDetails.lif_loc_name = lif_loc.name;
                            _ContainershipmentDetails.lif_loc_locode = lif_loc.locode;
                        }

                        if (shipment.empty_return_loc != null)
                        {
                            LocationInfo empty_return_loc = new LocationInfo();
                            empty_return_loc = Mapper.Map<dtoLocationInfo, LocationInfo>(shipment.empty_return_loc);
                            _ContainershipmentDetails.empty_return_loc_name = empty_return_loc.name;
                            _ContainershipmentDetails.empty_return_loc_locode = empty_return_loc.locode;
                        }

                        if (shipment.tsp4_loc != null)
                        {
                            LocationInfo tsp4_loc = new LocationInfo();
                            tsp4_loc = Mapper.Map<dtoLocationInfo, LocationInfo>(shipment.tsp4_loc);
                            _ContainershipmentDetails.tsp4_loc_name = tsp4_loc.name;
                            _ContainershipmentDetails.tsp4_loc_locode = tsp4_loc.locode;
                        }

                        if (shipment.tsp3_loc != null)
                        {
                            LocationInfo tsp3_loc = new LocationInfo();
                            tsp3_loc = Mapper.Map<dtoLocationInfo, LocationInfo>(shipment.tsp3_loc);
                            _ContainershipmentDetails.tsp3_loc_name = tsp3_loc.name;
                            _ContainershipmentDetails.tsp3_loc_locode = tsp3_loc.locode;
                        }

                        if (shipment.tsp2_loc != null)
                        {
                            LocationInfo tsp2_loc = new LocationInfo();
                            tsp2_loc = Mapper.Map<dtoLocationInfo, LocationInfo>(shipment.tsp2_loc);
                            _ContainershipmentDetails.tsp2_loc_name = tsp2_loc.name;
                            _ContainershipmentDetails.tsp2_loc_locode = tsp2_loc.locode;
                        }

                        if (shipment.tsp1_loc != null)
                        {
                            LocationInfo tsp1_loc = new LocationInfo();
                            tsp1_loc = Mapper.Map<dtoLocationInfo, LocationInfo>(shipment.tsp1_loc);
                            _ContainershipmentDetails.tsp1_loc_name = tsp1_loc.name;
                            _ContainershipmentDetails.tsp1_loc_locode = tsp1_loc.locode;
                        }

                        if (shipment.dlv_loc != null)
                        {
                            LocationInfo dlv_loc = new LocationInfo();
                            dlv_loc = Mapper.Map<dtoLocationInfo, LocationInfo>(shipment.dlv_loc);
                            _ContainershipmentDetails.dlv_loc_name = dlv_loc.name;
                            _ContainershipmentDetails.dlv_loc_locode = dlv_loc.locode;
                        }

                        if (shipment.pod_loc != null)
                        {
                            LocationInfo pod_loc = new LocationInfo();
                            pod_loc = Mapper.Map<dtoLocationInfo, LocationInfo>(shipment.pod_loc);
                            _ContainershipmentDetails.pod_loc_name = pod_loc.name;
                            _ContainershipmentDetails.pod_loc_locode = pod_loc.locode;
                        }

                        if (shipment.pol_loc != null)
                        {
                            LocationInfo pol_loc = new LocationInfo();
                            pol_loc = Mapper.Map<dtoLocationInfo, LocationInfo>(shipment.pol_loc);
                            _ContainershipmentDetails.pol_loc_name = pol_loc.name;
                            _ContainershipmentDetails.pol_loc_locode = pol_loc.locode;
                        }

                        if (shipment.origin_loc != null)
                        {
                            LocationInfo origin_loc = new LocationInfo();
                            origin_loc = Mapper.Map<dtoLocationInfo, LocationInfo>(shipment.origin_loc);
                            _ContainershipmentDetails.origin_loc_name = origin_loc.name;
                            _ContainershipmentDetails.origin_loc_locode = origin_loc.locode;
                        }

                        if (shipment.leg5_vessel != null)
                        {
                            VesselInfo leg5_vessel = new VesselInfo();
                            leg5_vessel = Mapper.Map<dtoVesselInfo, VesselInfo>(shipment.leg5_vessel);
                            _ContainershipmentDetails.leg5_vessel_id = leg5_vessel.name;
                            _ContainershipmentDetails.leg5_vessel_imo = leg5_vessel.imo;
                            _ContainershipmentDetails.leg5_vessel_name = leg5_vessel.name;
                        }

                        if (shipment.leg4_vessel != null)
                        {
                            VesselInfo leg4_vessel = new VesselInfo();
                            leg4_vessel = Mapper.Map<dtoVesselInfo, VesselInfo>(shipment.leg4_vessel);
                            _ContainershipmentDetails.leg4_vessel_id = leg4_vessel.name;
                            _ContainershipmentDetails.leg4_vessel_imo = leg4_vessel.imo;
                            _ContainershipmentDetails.leg4_vessel_name = leg4_vessel.name;
                        }

                        if (shipment.leg3_vessel != null)
                        {
                            VesselInfo leg3_vessel = new VesselInfo();
                            leg3_vessel = Mapper.Map<dtoVesselInfo, VesselInfo>(shipment.leg3_vessel);
                            _ContainershipmentDetails.leg3_vessel_id = leg3_vessel.name;
                            _ContainershipmentDetails.leg3_vessel_imo = leg3_vessel.imo;
                            _ContainershipmentDetails.leg3_vessel_name = leg3_vessel.name;
                        }

                        if (shipment.leg2_vessel != null)
                        {
                            VesselInfo leg2_vessel = new VesselInfo();
                            leg2_vessel = Mapper.Map<dtoVesselInfo, VesselInfo>(shipment.leg2_vessel);
                            _ContainershipmentDetails.leg2_vessel_id = leg2_vessel.name;
                            _ContainershipmentDetails.leg2_vessel_imo = leg2_vessel.imo;
                            _ContainershipmentDetails.leg2_vessel_name = leg2_vessel.name;
                        }

                        if (shipment.leg1_vessel != null)
                        {
                            VesselInfo leg1_vessel = new VesselInfo();
                            leg1_vessel = Mapper.Map<dtoVesselInfo, VesselInfo>(shipment.leg1_vessel);
                            _ContainershipmentDetails.leg1_vessel_id = leg1_vessel.name;
                            _ContainershipmentDetails.leg1_vessel_imo = leg1_vessel.imo;
                            _ContainershipmentDetails.leg1_vessel_name = leg1_vessel.name;
                        }
                        ListOfContainerDetail.Add(_ContainershipmentDetails);
                        var deletshipment = requestDetails.containershipments.Where(x => x.id == shipment.id).FirstOrDefault();
                        requestDetails.containershipments.Remove(deletshipment);
                        //_context.ContainershipmentDetails.Add(_ContainershipmentDetails);
                    }

                }
                //InsertDataToDB(requestDetails, ListOfContainerDetail);
                //InserRequestNContainerDetails(requestDetails, ListOfContainerDetail);
                CheckRequestExistInDB(requestDetails, ListOfContainerDetail);
            }
            catch (Exception ex)
            {
                _logService.AddException(ex);
                throw ex;
            }
            return true;
        }

        //private void InsertDataToDB(RequestDetail requestDetails, List<ContainershipmentDetails> ListOfContainerDetail)
        //{
        //    try
        //    {
        //        RequestDetail requestInfo = new RequestDetail();
        //        Boolean isContainerDatailsIsChange = false;
        //        List<ContainershipmentDetails> lstContainerDetailsHist = new List<ContainershipmentDetails>();
        //        using (DatabaseContext db = new DatabaseContext())
        //        {
        //            ///first check request object is exist in db 
        //            requestInfo = db.RequestDetails.Where(x => x.request_key == requestDetails.request_key).FirstOrDefault();
        //        }


        //        //check request data is exist in db
        //        if (requestInfo != null)
        //        {
        //            ///if yes then check for Request or Container is having any changes
        //            if (RequestDetail.Equals(requestInfo, requestDetails) == false)
        //            {
        //                foreach (ContainershipmentDetails CSD in ListOfContainerDetail)
        //                {
        //                    using (DatabaseContext dbQuery = new DatabaseContext())
        //                    {
        //                        var ContainerInfo = dbQuery.ContainershipmentDetails.Where(x => x.container_number == CSD.container_number).FirstOrDefault();
        //                        if (ContainershipmentDetails.Equals(CSD, ContainerInfo))
        //                        {
        //                            isContainerDatailsIsChange = true;
        //                        }
        //                    }
        //                }

        //                if (isContainerDatailsIsChange == true)
        //                {
        //                    ///request data not having any changes only container having changes then container data to history table and then add to regular container table

        //                    using (DatabaseContext dbUpdate = new DatabaseContext())
        //                    {
        //                        foreach (ContainershipmentDetails cSD in lstContainerDetailsHist)
        //                        {
        //                            ContainershipmentDetailHist containershipmentDetailsHist = Mapper.Map<ContainershipmentDetails, ContainershipmentDetailHist>(cSD);
        //                            containershipmentDetailsHist.HistrefID = cSD.refID;
        //                            dbUpdate.ContainershipmentDetails.Remove(cSD);
        //                            dbUpdate.ContainershipmentDetailHists.Add(containershipmentDetailsHist);
        //                        }
        //                        dbUpdate.SaveChanges();
        //                    }
        //                }
        //            }
        //            else
        //            {
        //                /// move the data to history and insert new data complete regular adding process 
        //                /// need to add method for adding request and container infor in history db
        //                using (DatabaseContext dbDetails = new DatabaseContext())
        //                {
        //                    var request = dbDetails.RequestDetails.Where(x => x.request_key == requestDetails.request_key).FirstOrDefault();
        //                    RequestDetailHist requestDetailHistInfo = Mapper.Map<RequestDetail, RequestDetailHist>(request);
        //                    requestDetailHistInfo.HistID = request.ID;
        //                    dbDetails.RequestDetailsHists.Add(requestDetailHistInfo);
        //                    dbDetails.RequestDetails.Remove(request);
        //                    dbDetails.SaveChanges();

        //                    lstContainerDetailsHist = new List<ContainershipmentDetails>();
        //                    lstContainerDetailsHist = dbDetails.ContainershipmentDetails.Where(x => x.RequestID == requestInfo.RequestID).ToList();
        //                    foreach (ContainershipmentDetails cSD in lstContainerDetailsHist)
        //                    {
        //                        ContainershipmentDetailHist containershipmentDetailsHist = Mapper.Map<ContainershipmentDetails, ContainershipmentDetailHist>(cSD);
        //                        containershipmentDetailsHist.HistrefID = cSD.refID;
        //                        dbDetails.ContainershipmentDetailHists.Add(containershipmentDetailsHist);
        //                        dbDetails.ContainershipmentDetails.Remove(cSD);
        //                    }
        //                    dbDetails.SaveChanges();
        //                }
        //                InserRequestNContainerDetails(requestDetails, ListOfContainerDetail);
        //            }
        //        }
        //        else
        //        {
        //            /// if no request data then insert complete regular adding process
        //            InserRequestNContainerDetails(requestDetails, ListOfContainerDetail);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _logService.AddException(ex);
        //        throw ex;
        //    }
        //}

        private void InsertDataToDB(RequestDetail requestDetails, List<ContainershipmentDetails> ListOfContainerDetail)
        {
            try
            {
                RequestDetail requestInfo = new RequestDetail();
                List<ContainershipmentDetails> lstContainerDetailsHist = new List<ContainershipmentDetails>();
                using (DatabaseContext db = new DatabaseContext())
                {
                    ///first check request object is exist in db 
                    requestInfo = db.RequestDetails.Where(x => x.request_key == requestDetails.request_key).FirstOrDefault();
                }


                //check request data is exist in db
                if (requestInfo != null)
                {
                    ///if yes then check for Request or Container is having any changes
                    /////if (RequestDetail.Equals(requestInfo, requestDetails) == false)
                    if (requestInfo.status == requestDetails.status)
                    {
                        foreach (ContainershipmentDetails CSD in ListOfContainerDetail)
                        {
                            using (DatabaseContext dbQuery = new DatabaseContext())
                            {
                                var ContainerInfo = dbQuery.ContainershipmentDetails.Where(x => x.container_number == CSD.container_number).FirstOrDefault();
                                //if (ContainershipmentDetails.Equals(CSD, ContainerInfo))
                                if (CSD.status != ContainerInfo.status)
                                {
                                    ContainershipmentDetailHist containershipmentDetailsHist = Mapper.Map<ContainershipmentDetails, ContainershipmentDetailHist>(CSD);
                                    containershipmentDetailsHist.HistrefID = CSD.refID;
                                    dbQuery.ContainershipmentDetailHists.Add(containershipmentDetailsHist);
                                    dbQuery.SaveChanges();
                                }
                            }
                        }
                    }
                    else
                    {
                        /// move the data to history and insert new data complete regular adding process 
                        /// need to add method for adding request and container infor in history db
                        using (DatabaseContext dbDetails = new DatabaseContext())
                        {
                            var request = dbDetails.RequestDetails.Where(x => x.request_key == requestDetails.request_key).FirstOrDefault();
                            RequestDetailHist requestDetailHistInfo = Mapper.Map<RequestDetail, RequestDetailHist>(request);
                            requestDetailHistInfo.HistID = request.ID;
                            dbDetails.RequestDetailsHists.Add(requestDetailHistInfo);
                            dbDetails.RequestDetails.Remove(request);
                            dbDetails.SaveChanges();

                            lstContainerDetailsHist = new List<ContainershipmentDetails>();
                            lstContainerDetailsHist = dbDetails.ContainershipmentDetails.Where(x => x.RequestID == requestInfo.RequestID).ToList();
                            foreach (ContainershipmentDetails cSD in lstContainerDetailsHist)
                            {
                                ContainershipmentDetailHist containershipmentDetailsHist = Mapper.Map<ContainershipmentDetails, ContainershipmentDetailHist>(cSD);
                                containershipmentDetailsHist.HistrefID = cSD.refID;
                                dbDetails.ContainershipmentDetailHists.Add(containershipmentDetailsHist);
                                dbDetails.ContainershipmentDetails.Remove(cSD);
                            }
                            dbDetails.SaveChanges();
                        }
                        InserRequestNContainerDetails(requestDetails, ListOfContainerDetail);
                    }
                }
                else
                {
                    /// if no request data then insert complete regular adding process
                    InserRequestNContainerDetails(requestDetails, ListOfContainerDetail);
                }
            }
            catch (Exception ex)
            {
                _logService.AddException(ex);
                throw ex;
            }
        }

        private void CheckRequestExistInDB(RequestDetail requestDetails, List<ContainershipmentDetails> ListOfContainerDetail)
        {
            try
            {
                RequestDetail requestInfo = new RequestDetail();
                List<ContainershipmentDetails> lstContainerDetailsHist = new List<ContainershipmentDetails>();
                using (DatabaseContext db = new DatabaseContext())
                {
                    ///first check request object is exist in db 
                    requestInfo = db.RequestDetails.Where(x => x.request_key == requestDetails.request_key).FirstOrDefault();
                }
                //check request data is exist in db
                if (requestInfo != null)
                {
                    using (DatabaseContext dbDetails = new DatabaseContext())
                    {
                        var request = dbDetails.RequestDetails.Where(x => x.request_key == requestDetails.request_key).FirstOrDefault();
                        RequestDetailHist requestDetailHistInfo = Mapper.Map<RequestDetail, RequestDetailHist>(request);
                        requestDetailHistInfo.HistID = request.ID;
                        dbDetails.RequestDetailsHists.Add(requestDetailHistInfo);
                        dbDetails.RequestDetails.Remove(request);
                        dbDetails.SaveChanges();

                        lstContainerDetailsHist = new List<ContainershipmentDetails>();
                        lstContainerDetailsHist = dbDetails.ContainershipmentDetails.Where(x => x.RequestID == requestInfo.RequestID).ToList();
                        foreach (ContainershipmentDetails cSD in lstContainerDetailsHist)
                        {
                            ContainershipmentDetailHist containershipmentDetailsHist = Mapper.Map<ContainershipmentDetails, ContainershipmentDetailHist>(cSD);
                            containershipmentDetailsHist.HistrefID = cSD.refID;
                            dbDetails.ContainershipmentDetailHists.Add(containershipmentDetailsHist);
                            dbDetails.ContainershipmentDetails.Remove(cSD);
                        }
                        dbDetails.SaveChanges();
                    }
                    InserRequestNContainerDetails(requestDetails, ListOfContainerDetail);
                }
                else
                {
                    InserRequestNContainerDetails(requestDetails, ListOfContainerDetail);
                }
            }
            catch (Exception ex)
            {
                //_logService.AddException(ex);
                throw ex;
            }
        }

        private void InserRequestNContainerDetails(RequestDetail requestDetails, List<ContainershipmentDetails> ListOfContainerDetail)
        {
            try
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    db.RequestDetails.Add(requestDetails);
                    db.SaveChanges();
                    var refID = requestDetails.ID;
                    foreach (ContainershipmentDetails cSD in ListOfContainerDetail)
                    {
                        cSD.refID = refID;
                        db.ContainershipmentDetails.Add(cSD);
                    }
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                //_logService.AddException(ex);
                throw ex;
            }
        }
    }
}