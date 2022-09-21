using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using AutoMapper;
using ContainerTrackingApp.Context;
using ContainerTrackingApp.DTO;
using ContainerTrackingApp.Models;

namespace ContainerTrackingApp.Repository
{
    public class EventPushReceiverConcrete : IEventPushDetails
    {
        DatabaseContext _context;
        ILogService _logService;

        public EventPushReceiverConcrete()
        {
            _logService = new RepositoryExceptionLog();
            _context = new DatabaseContext();
        }

        public bool AddShipmentInformation(dtoEventPushReceiver dtoeventPushReceiver)
        {
            try
            {
                EventPushReceiver eventPushReceiver = Mapper.Map<dtoEventPushReceiver, EventPushReceiver>(dtoeventPushReceiver);
                //ContainershipmentDetails _ContainershipmentDetails = new ContainershipmentDetails();
                ShipmentInfo shipmentInfo = new ShipmentInfo();
                if (eventPushReceiver.shipmentInfo != null)
                {
                    
                    shipmentInfo.shipmentsubscription_status_verbose = dtoeventPushReceiver.shipmentInfo.shipmentsubscription_status_verbose;
                    shipmentInfo.shipmentsubscription_status = dtoeventPushReceiver.shipmentInfo.shipmentsubscription_status;
                    shipmentInfo.shipmentsubscription_on_hold = dtoeventPushReceiver.shipmentInfo.shipmentsubscription_on_hold;
                    shipmentInfo.shipmentsubscription_id = dtoeventPushReceiver.shipmentInfo.shipmentsubscription_id;
                    shipmentInfo.status_verbose = dtoeventPushReceiver.shipmentInfo.status_verbose;
                    shipmentInfo.lifecycle_status_verbose = dtoeventPushReceiver.shipmentInfo.lifecycle_status_verbose;
                    shipmentInfo.carrier_name = dtoeventPushReceiver.shipmentInfo.carrier_name;
                    shipmentInfo.carrier_scac = dtoeventPushReceiver.shipmentInfo.carrier_scac;
                    shipmentInfo.container_type_iso = dtoeventPushReceiver.shipmentInfo.container_type_iso;
                    shipmentInfo.container_type_str = dtoeventPushReceiver.shipmentInfo.container_type_str;
                    shipmentInfo.url = dtoeventPushReceiver.shipmentInfo.url;
                    shipmentInfo.container_number = dtoeventPushReceiver.shipmentInfo.container_number;
                    shipmentInfo.booking_number = dtoeventPushReceiver.shipmentInfo.booking_number;
                    shipmentInfo.bl_number = dtoeventPushReceiver.shipmentInfo.bl_number;
                    shipmentInfo.weight = dtoeventPushReceiver.shipmentInfo.weight;
                    shipmentInfo.status = dtoeventPushReceiver.shipmentInfo.status;
                    shipmentInfo.lifecycle_status = dtoeventPushReceiver.shipmentInfo.lifecycle_status;
                    shipmentInfo.id_date = dtoeventPushReceiver.shipmentInfo.id_date;
                    shipmentInfo.descriptive_name = dtoeventPushReceiver.shipmentInfo.descriptive_name;
                    shipmentInfo.empty_pickup_planned_initial = dtoeventPushReceiver.shipmentInfo.empty_pickup_planned_initial;
                    shipmentInfo.empty_pickup_planned_last = dtoeventPushReceiver.shipmentInfo.empty_pickup_planned_last;
                    shipmentInfo.empty_pickup_actual = dtoeventPushReceiver.shipmentInfo.empty_pickup_actual;
                    shipmentInfo.origin_pickup_planned_initial = dtoeventPushReceiver.shipmentInfo.origin_pickup_planned_initial;
                    shipmentInfo.origin_pickup_planned_last = dtoeventPushReceiver.shipmentInfo.origin_pickup_planned_last;
                    shipmentInfo.origin_pickup_actual = dtoeventPushReceiver.shipmentInfo.origin_pickup_actual;
                    shipmentInfo.pol_arrival_planned_initial = dtoeventPushReceiver.shipmentInfo.pol_arrival_planned_initial;
                    shipmentInfo.pol_arrival_planned_last = dtoeventPushReceiver.shipmentInfo.pol_arrival_planned_last;
                    shipmentInfo.pol_arrival_actual = dtoeventPushReceiver.shipmentInfo.pol_arrival_actual;
                    shipmentInfo.pol_loaded_planned_initial = dtoeventPushReceiver.shipmentInfo.pol_loaded_planned_initial;
                    shipmentInfo.pol_loaded_planned_last = dtoeventPushReceiver.shipmentInfo.pol_loaded_planned_last;
                    shipmentInfo.pol_loaded_actual = dtoeventPushReceiver.shipmentInfo.pol_loaded_actual;
                    shipmentInfo.pol_vsldeparture_planned_initial = dtoeventPushReceiver.shipmentInfo.pol_vsldeparture_planned_initial;
                    shipmentInfo.pol_vsldeparture_planned_last = dtoeventPushReceiver.shipmentInfo.pol_vsldeparture_planned_last;
                    shipmentInfo.pol_vsldeparture_actual = dtoeventPushReceiver.shipmentInfo.pol_vsldeparture_actual;
                    shipmentInfo.pol_vsldeparture_detected = dtoeventPushReceiver.shipmentInfo.pol_vsldeparture_detected;
                    shipmentInfo.leg1_voyage = dtoeventPushReceiver.shipmentInfo.leg1_voyage;
                    shipmentInfo.tsp1_vslarrival_planned_initial = dtoeventPushReceiver.shipmentInfo.tsp1_vslarrival_planned_initial;
                    shipmentInfo.tsp1_vslarrival_planned_last = dtoeventPushReceiver.shipmentInfo.tsp1_vslarrival_planned_last;
                    shipmentInfo.tsp1_vslarrival_actual = dtoeventPushReceiver.shipmentInfo.tsp1_vslarrival_actual;
                    shipmentInfo.tsp1_vslarrival_detected = dtoeventPushReceiver.shipmentInfo.tsp1_vslarrival_detected;
                    shipmentInfo.tsp1_discharge_planned_initial = dtoeventPushReceiver.shipmentInfo.tsp1_discharge_planned_initial;
                    shipmentInfo.tsp1_discharge_planned_last = dtoeventPushReceiver.shipmentInfo.tsp1_discharge_planned_last;

                    shipmentInfo.tsp1_discharge_actual = dtoeventPushReceiver.shipmentInfo.tsp1_discharge_actual;
                    shipmentInfo.tsp1_loaded_planned_initial = dtoeventPushReceiver.shipmentInfo.tsp1_loaded_planned_initial;
                    shipmentInfo.tsp1_loaded_planned_last = dtoeventPushReceiver.shipmentInfo.tsp1_loaded_planned_last;
                    shipmentInfo.tsp1_loaded_actual = dtoeventPushReceiver.shipmentInfo.tsp1_loaded_actual;
                    shipmentInfo.tsp1_vsldeparture_planned_initial = dtoeventPushReceiver.shipmentInfo.tsp1_vsldeparture_planned_initial;
                    shipmentInfo.tsp1_vsldeparture_planned_last = dtoeventPushReceiver.shipmentInfo.tsp1_vsldeparture_planned_last;
                    shipmentInfo.tsp1_vsldeparture_actual = dtoeventPushReceiver.shipmentInfo.tsp1_vsldeparture_actual;
                    shipmentInfo.tsp1_vsldeparture_detected = dtoeventPushReceiver.shipmentInfo.tsp1_vsldeparture_detected;
                    shipmentInfo.leg2_voyage = dtoeventPushReceiver.shipmentInfo.leg2_voyage;
                    shipmentInfo.tsp2_vslarrival_planned_initial = dtoeventPushReceiver.shipmentInfo.tsp2_vslarrival_planned_initial;
                    shipmentInfo.tsp2_vslarrival_planned_last = dtoeventPushReceiver.shipmentInfo.tsp2_vslarrival_planned_last;
                    shipmentInfo.tsp2_vslarrival_actual = dtoeventPushReceiver.shipmentInfo.tsp2_vslarrival_actual;
                    shipmentInfo.tsp2_vslarrival_detected = dtoeventPushReceiver.shipmentInfo.tsp2_vslarrival_detected;
                    shipmentInfo.tsp2_discharge_planned_initial = dtoeventPushReceiver.shipmentInfo.tsp2_discharge_planned_initial;
                    shipmentInfo.tsp2_discharge_planned_last = dtoeventPushReceiver.shipmentInfo.tsp2_discharge_planned_last;
                    shipmentInfo.tsp2_discharge_actual = dtoeventPushReceiver.shipmentInfo.tsp2_discharge_actual;
                    shipmentInfo.tsp2_loaded_planned_initial = dtoeventPushReceiver.shipmentInfo.tsp2_loaded_planned_initial;
                    shipmentInfo.tsp2_loaded_planned_last = dtoeventPushReceiver.shipmentInfo.tsp2_loaded_planned_last;
                    shipmentInfo.tsp2_loaded_actual = dtoeventPushReceiver.shipmentInfo.tsp2_loaded_actual;
                    shipmentInfo.tsp2_vsldeparture_planned_initial = dtoeventPushReceiver.shipmentInfo.tsp2_vsldeparture_planned_initial;
                    shipmentInfo.tsp2_vsldeparture_planned_last = dtoeventPushReceiver.shipmentInfo.tsp2_vsldeparture_planned_last;
                    shipmentInfo.tsp2_vsldeparture_actual = dtoeventPushReceiver.shipmentInfo.tsp2_vsldeparture_actual;
                    shipmentInfo.tsp2_vsldeparture_detected = dtoeventPushReceiver.shipmentInfo.tsp2_vsldeparture_detected;
                    shipmentInfo.leg3_voyage = dtoeventPushReceiver.shipmentInfo.leg3_voyage;
                    shipmentInfo.tsp3_vslarrival_planned_initial = dtoeventPushReceiver.shipmentInfo.tsp3_vslarrival_planned_initial;
                    shipmentInfo.tsp3_vslarrival_planned_last = dtoeventPushReceiver.shipmentInfo.tsp3_vslarrival_planned_last;
                    shipmentInfo.tsp3_vslarrival_actual = dtoeventPushReceiver.shipmentInfo.tsp3_vslarrival_actual;
                    shipmentInfo.tsp3_vslarrival_detected = dtoeventPushReceiver.shipmentInfo.tsp3_vslarrival_detected;
                    shipmentInfo.tsp3_discharge_planned_initial = dtoeventPushReceiver.shipmentInfo.tsp3_discharge_planned_initial;
                    shipmentInfo.tsp3_discharge_planned_last = dtoeventPushReceiver.shipmentInfo.tsp3_discharge_planned_last;
                    shipmentInfo.tsp3_discharge_actual = dtoeventPushReceiver.shipmentInfo.tsp3_discharge_actual;


                    shipmentInfo.tsp3_loaded_planned_initial = dtoeventPushReceiver.shipmentInfo.tsp3_loaded_planned_initial;
                    shipmentInfo.tsp3_loaded_planned_last = dtoeventPushReceiver.shipmentInfo.tsp3_loaded_planned_last;
                    shipmentInfo.tsp3_loaded_actual = dtoeventPushReceiver.shipmentInfo.tsp3_loaded_actual;
                    shipmentInfo.tsp3_vsldeparture_planned_initial = dtoeventPushReceiver.shipmentInfo.tsp3_vsldeparture_planned_initial;
                    shipmentInfo.tsp3_vsldeparture_planned_last = dtoeventPushReceiver.shipmentInfo.tsp3_vsldeparture_planned_last;
                    shipmentInfo.tsp3_vsldeparture_actual = dtoeventPushReceiver.shipmentInfo.tsp3_vsldeparture_actual;
                    shipmentInfo.tsp3_vsldeparture_detected = dtoeventPushReceiver.shipmentInfo.tsp3_vsldeparture_detected;
                    shipmentInfo.leg4_voyage = dtoeventPushReceiver.shipmentInfo.leg4_voyage;
                    shipmentInfo.tsp4_vslarrival_planned_initial = dtoeventPushReceiver.shipmentInfo.tsp4_vslarrival_planned_initial;
                    shipmentInfo.tsp4_vslarrival_planned_last = dtoeventPushReceiver.shipmentInfo.tsp4_vslarrival_planned_last;
                    shipmentInfo.tsp4_vslarrival_actual = dtoeventPushReceiver.shipmentInfo.tsp4_vslarrival_actual;
                    shipmentInfo.tsp2_vslarrival_actual = dtoeventPushReceiver.shipmentInfo.tsp2_vslarrival_actual;
                    shipmentInfo.tsp4_vslarrival_detected = dtoeventPushReceiver.shipmentInfo.tsp4_vslarrival_detected;
                    shipmentInfo.tsp4_discharge_planned_initial = dtoeventPushReceiver.shipmentInfo.tsp4_discharge_planned_initial;
                    shipmentInfo.tsp4_discharge_planned_last = dtoeventPushReceiver.shipmentInfo.tsp4_discharge_planned_last;
                    shipmentInfo.tsp4_discharge_actual = dtoeventPushReceiver.shipmentInfo.tsp4_discharge_actual;
                    shipmentInfo.tsp4_loaded_planned_initial = dtoeventPushReceiver.shipmentInfo.tsp4_loaded_planned_initial;
                    shipmentInfo.tsp4_loaded_planned_last = dtoeventPushReceiver.shipmentInfo.tsp4_loaded_planned_last;
                    shipmentInfo.tsp4_loaded_actual = dtoeventPushReceiver.shipmentInfo.tsp4_loaded_actual;
                    shipmentInfo.tsp4_vsldeparture_planned_initial = dtoeventPushReceiver.shipmentInfo.tsp4_vsldeparture_planned_initial;
                    shipmentInfo.tsp4_vsldeparture_planned_last = dtoeventPushReceiver.shipmentInfo.tsp4_vsldeparture_planned_last;
                    shipmentInfo.tsp4_vsldeparture_actual = dtoeventPushReceiver.shipmentInfo.tsp4_vsldeparture_actual;
                    shipmentInfo.tsp4_vsldeparture_detected = dtoeventPushReceiver.shipmentInfo.tsp4_vsldeparture_detected;
                    shipmentInfo.leg5_voyage = dtoeventPushReceiver.shipmentInfo.leg5_voyage;
                    shipmentInfo.pod_vslarrival_planned_initial = dtoeventPushReceiver.shipmentInfo.pod_vslarrival_planned_initial;
                    shipmentInfo.pod_vslarrival_planned_last = dtoeventPushReceiver.shipmentInfo.pod_vslarrival_planned_last;
                    shipmentInfo.pod_vslarrival_actual = dtoeventPushReceiver.shipmentInfo.pod_vslarrival_actual;
                    shipmentInfo.pod_vslarrival_detected = dtoeventPushReceiver.shipmentInfo.pod_vslarrival_detected;
                    shipmentInfo.pod_discharge_planned_initial = dtoeventPushReceiver.shipmentInfo.pod_discharge_planned_initial;
                    shipmentInfo.pod_discharge_planned_last = dtoeventPushReceiver.shipmentInfo.pod_discharge_actual;
                    shipmentInfo.pod_departure_planned_initial = dtoeventPushReceiver.shipmentInfo.pod_departure_planned_initial;


                    shipmentInfo.pod_departure_planned_last = dtoeventPushReceiver.shipmentInfo.pod_departure_planned_last;
                    shipmentInfo.pod_departure_actual = dtoeventPushReceiver.shipmentInfo.pod_departure_actual;
                    shipmentInfo.dlv_delivery_planned_initial = dtoeventPushReceiver.shipmentInfo.dlv_delivery_planned_initial;
                    shipmentInfo.dlv_delivery_planned_last = dtoeventPushReceiver.shipmentInfo.dlv_delivery_planned_last;
                    shipmentInfo.dlv_delivery_actual = dtoeventPushReceiver.shipmentInfo.dlv_delivery_actual;
                    shipmentInfo.empty_return_planned_initial = dtoeventPushReceiver.shipmentInfo.empty_return_planned_initial;
                    shipmentInfo.empty_return_planned_last = dtoeventPushReceiver.shipmentInfo.empty_return_planned_last;
                    shipmentInfo.empty_return_actual = dtoeventPushReceiver.shipmentInfo.empty_return_actual;
                    shipmentInfo.ts_count = dtoeventPushReceiver.shipmentInfo.ts_count;
                    shipmentInfo.last_carrier_update = dtoeventPushReceiver.shipmentInfo.last_carrier_update;
                    shipmentInfo.last_actuals_update = dtoeventPushReceiver.shipmentInfo.last_actuals_update;
                    shipmentInfo.created = dtoeventPushReceiver.shipmentInfo.created;
                    shipmentInfo.modified = dtoeventPushReceiver.shipmentInfo.modified;
                    shipmentInfo.shipmentsubscription = dtoeventPushReceiver.shipmentInfo.shipmentsubscription;

                    if (dtoeventPushReceiver.shipmentInfo.current_vessel_nextport != null)
                    {
                        Vesselnextport vesselNextPort = new Vesselnextport();
                        vesselNextPort = Mapper.Map<dtoVesselnextport, Vesselnextport>(dtoeventPushReceiver.shipmentInfo.current_vessel_nextport);
                        shipmentInfo.current_vessel_nextport_eta = vesselNextPort.eta;
                        shipmentInfo.current_vessel_nextport_locode = vesselNextPort.locode;
                        shipmentInfo.current_vessel_nextport_name = vesselNextPort.name;
                    }

                    if (dtoeventPushReceiver.shipmentInfo.current_vessel_position != null)
                    {
                        VesselPosition vesselposition = new VesselPosition();
                        vesselposition = Mapper.Map<dtoVesselPosition, VesselPosition>(dtoeventPushReceiver.shipmentInfo.current_vessel_position);
                        shipmentInfo.current_vessel_position_heading = vesselposition.heading;
                        shipmentInfo.current_vessel_position_latitude = vesselposition.latitude;
                        shipmentInfo.current_vessel_position_longitude = vesselposition.longitude;
                        shipmentInfo.current_vessel_position_timestamp = vesselposition.timestamp;
                    }

                    if (dtoeventPushReceiver.shipmentInfo.current_vessel != null)
                    {
                        VesselInfo vesselNextPort = new VesselInfo();
                        vesselNextPort = Mapper.Map<dtoVesselInfo, VesselInfo>(dtoeventPushReceiver.shipmentInfo.current_vessel);
                        shipmentInfo.current_vessel_id = vesselNextPort.id;
                        shipmentInfo.current_vessel_imo = vesselNextPort.imo;
                        shipmentInfo.current_vessel_name = vesselNextPort.name;
                    }

                    if (dtoeventPushReceiver.shipmentInfo.empty_pickup_loc != null)
                    {
                        LocationInfo empty_pickup_loc = new LocationInfo();
                        empty_pickup_loc = Mapper.Map<dtoLocationInfo, LocationInfo>(dtoeventPushReceiver.shipmentInfo.empty_pickup_loc);
                        shipmentInfo.empty_pickup_loc_name = empty_pickup_loc.name;
                        shipmentInfo.empty_pickup_loc_locode = empty_pickup_loc.locode;
                    }

                    if (dtoeventPushReceiver.shipmentInfo.lif_loc != null)
                    {
                        LocationInfo lif_loc = new LocationInfo();
                        lif_loc = Mapper.Map<dtoLocationInfo, LocationInfo>(dtoeventPushReceiver.shipmentInfo.lif_loc);
                        shipmentInfo.lif_loc_name = lif_loc.name;
                        shipmentInfo.lif_loc_locode = lif_loc.locode;
                    }

                    if (dtoeventPushReceiver.shipmentInfo.empty_return_loc != null)
                    {
                        LocationInfo empty_return_loc = new LocationInfo();
                        empty_return_loc = Mapper.Map<dtoLocationInfo, LocationInfo>(dtoeventPushReceiver.shipmentInfo.empty_return_loc);
                        shipmentInfo.empty_return_loc_name = empty_return_loc.name;
                        shipmentInfo.empty_return_loc_locode = empty_return_loc.locode;
                    }

                    if (dtoeventPushReceiver.shipmentInfo.tsp4_loc != null)
                    {
                        LocationInfo tsp4_loc = new LocationInfo();
                        tsp4_loc = Mapper.Map<dtoLocationInfo, LocationInfo>(dtoeventPushReceiver.shipmentInfo.tsp4_loc);
                        shipmentInfo.tsp4_loc_name = tsp4_loc.name;
                        shipmentInfo.tsp4_loc_locode = tsp4_loc.locode;
                    }

                    if (dtoeventPushReceiver.shipmentInfo.tsp3_loc != null)
                    {
                        LocationInfo tsp3_loc = new LocationInfo();
                        tsp3_loc = Mapper.Map<dtoLocationInfo, LocationInfo>(dtoeventPushReceiver.shipmentInfo.tsp3_loc);
                        shipmentInfo.tsp3_loc_name = tsp3_loc.name;
                        shipmentInfo.tsp3_loc_locode = tsp3_loc.locode;
                    }

                    if (dtoeventPushReceiver.shipmentInfo.tsp2_loc != null)
                    {
                        LocationInfo tsp2_loc = new LocationInfo();
                        tsp2_loc = Mapper.Map<dtoLocationInfo, LocationInfo>(dtoeventPushReceiver.shipmentInfo.tsp2_loc);
                        shipmentInfo.tsp2_loc_name = tsp2_loc.name;
                        shipmentInfo.tsp2_loc_locode = tsp2_loc.locode;
                    }

                    if (dtoeventPushReceiver.shipmentInfo.tsp1_loc != null)
                    {
                        LocationInfo tsp1_loc = new LocationInfo();
                        tsp1_loc = Mapper.Map<dtoLocationInfo, LocationInfo>(dtoeventPushReceiver.shipmentInfo.tsp1_loc);
                        shipmentInfo.tsp1_loc_name = tsp1_loc.name;
                        shipmentInfo.tsp1_loc_locode = tsp1_loc.locode;
                    }

                    if (dtoeventPushReceiver.shipmentInfo.dlv_loc != null)
                    {
                        LocationInfo dlv_loc = new LocationInfo();
                        dlv_loc = Mapper.Map<dtoLocationInfo, LocationInfo>(dtoeventPushReceiver.shipmentInfo.dlv_loc);
                        shipmentInfo.dlv_loc_name = dlv_loc.name;
                        shipmentInfo.dlv_loc_locode = dlv_loc.locode;
                    }

                    if (dtoeventPushReceiver.shipmentInfo.pod_loc != null)
                    {
                        LocationInfo pod_loc = new LocationInfo();
                        pod_loc = Mapper.Map<dtoLocationInfo, LocationInfo>(dtoeventPushReceiver.shipmentInfo.pod_loc);
                        shipmentInfo.pod_loc_name = pod_loc.name;
                        shipmentInfo.pod_loc_locode = pod_loc.locode;
                    }

                    if (dtoeventPushReceiver.shipmentInfo.pol_loc != null)
                    {
                        LocationInfo pol_loc = new LocationInfo();
                        pol_loc = Mapper.Map<dtoLocationInfo, LocationInfo>(dtoeventPushReceiver.shipmentInfo.pol_loc);
                        shipmentInfo.pol_loc_name = pol_loc.name;
                        shipmentInfo.pol_loc_locode = pol_loc.locode;
                    }

                    if (dtoeventPushReceiver.shipmentInfo.origin_loc != null)
                    {
                        LocationInfo origin_loc = new LocationInfo();
                        origin_loc = Mapper.Map<dtoLocationInfo, LocationInfo>(dtoeventPushReceiver.shipmentInfo.origin_loc);
                        shipmentInfo.origin_loc_name = origin_loc.name;
                        shipmentInfo.origin_loc_locode = origin_loc.locode;
                    }

                    if (dtoeventPushReceiver.shipmentInfo.leg5_vessel != null)
                    {
                        VesselInfo leg5_vessel = new VesselInfo();
                        leg5_vessel = Mapper.Map<dtoVesselInfo, VesselInfo>(dtoeventPushReceiver.shipmentInfo.leg5_vessel);
                        shipmentInfo.leg5_vessel_id = leg5_vessel.name;
                        shipmentInfo.leg5_vessel_imo = leg5_vessel.imo;
                        shipmentInfo.leg5_vessel_name = leg5_vessel.name;
                    }

                    if (dtoeventPushReceiver.shipmentInfo.leg4_vessel != null)
                    {
                        VesselInfo leg4_vessel = new VesselInfo();
                        leg4_vessel = Mapper.Map<dtoVesselInfo, VesselInfo>(dtoeventPushReceiver.shipmentInfo.leg4_vessel);
                        shipmentInfo.leg4_vessel_id = leg4_vessel.name;
                        shipmentInfo.leg4_vessel_imo = leg4_vessel.imo;
                        shipmentInfo.leg4_vessel_name = leg4_vessel.name;
                    }

                    if (dtoeventPushReceiver.shipmentInfo.leg3_vessel != null)
                    {
                        VesselInfo leg3_vessel = new VesselInfo();
                        leg3_vessel = Mapper.Map<dtoVesselInfo, VesselInfo>(dtoeventPushReceiver.shipmentInfo.leg3_vessel);
                        shipmentInfo.leg3_vessel_id = leg3_vessel.name;
                        shipmentInfo.leg3_vessel_imo = leg3_vessel.imo;
                        shipmentInfo.leg3_vessel_name = leg3_vessel.name;
                    }

                    if (dtoeventPushReceiver.shipmentInfo.leg2_vessel != null)
                    {
                        VesselInfo leg2_vessel = new VesselInfo();
                        leg2_vessel = Mapper.Map<dtoVesselInfo, VesselInfo>(dtoeventPushReceiver.shipmentInfo.leg2_vessel);
                        shipmentInfo.leg2_vessel_id = leg2_vessel.name;
                        shipmentInfo.leg2_vessel_imo = leg2_vessel.imo;
                        shipmentInfo.leg2_vessel_name = leg2_vessel.name;
                    }

                    if (dtoeventPushReceiver.shipmentInfo.leg1_vessel != null)
                    {
                        VesselInfo leg1_vessel = new VesselInfo();
                        leg1_vessel = Mapper.Map<dtoVesselInfo, VesselInfo>(dtoeventPushReceiver.shipmentInfo.leg1_vessel);
                        shipmentInfo.leg1_vessel_id = leg1_vessel.name;
                        shipmentInfo.leg1_vessel_imo = leg1_vessel.imo;
                        shipmentInfo.leg1_vessel_name = leg1_vessel.name;
                    }
                }

                eventPushReceiver.shipmentInfo = null;
                _context.EventPushReceiver.Add(eventPushReceiver);
                //_context.ShipmentInfo.Add(shipmentInfo);
                _context.SaveChanges();
                InsertIntoShippmentInformation(shipmentInfo);
            }
            catch(Exception ex)
            {
                _logService.AddException(ex);
                throw ex;
            }
            return true;
        }

        public void InsertIntoShippmentInformation(ShipmentInfo shipmentInfo)
        {
            using (_context)
            {
                using (_context.Database.Connection)
                {
                    _context.Database.Connection.Open();
                    System.Data.Common.DbCommand cmd = _context.Database.Connection.CreateCommand();
                    cmd.CommandText = "Insert_Shipment_Details";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@shipmentsubscription_status_verbose", shipmentInfo.shipmentsubscription_status_verbose));
                    cmd.Parameters.Add(new SqlParameter("@lifecycle_status_verbose", shipmentInfo.lifecycle_status_verbose));
                    cmd.Parameters.Add(new SqlParameter("@shipmentsubscription_id", shipmentInfo.shipmentsubscription_id));
                    cmd.Parameters.Add(new SqlParameter("@status", shipmentInfo.status));
                    cmd.Parameters.Add(new SqlParameter("@status_verbose", shipmentInfo.status_verbose));
                    cmd.Parameters.Add(new SqlParameter("@container_number", shipmentInfo.container_number));
                    cmd.Parameters.Add(new SqlParameter("@bl_number", shipmentInfo.bl_number));
                    cmd.Parameters.Add(new SqlParameter("@pol_arrival_actual", shipmentInfo.pol_arrival_actual));
                    cmd.Parameters.Add(new SqlParameter("@pol_loaded_actual", shipmentInfo.pol_loaded_actual));
                    cmd.Parameters.Add(new SqlParameter("@tsp1_loc_locode", shipmentInfo.tsp1_loc_locode));
                    cmd.Parameters.Add(new SqlParameter("@tsp1_loc_name", shipmentInfo.tsp1_loc_name));
                    cmd.Parameters.Add(new SqlParameter("@tsp1_vslarrival_actual", shipmentInfo.tsp1_vslarrival_actual));
                    cmd.Parameters.Add(new SqlParameter("@tsp1_vslarrival_detected", shipmentInfo.tsp1_vslarrival_detected));
                    cmd.Parameters.Add(new SqlParameter("@tsp1_vsldeparture_actual", shipmentInfo.tsp1_vsldeparture_actual));
                    cmd.Parameters.Add(new SqlParameter("@tsp1_vsldeparture_detected", shipmentInfo.tsp1_vsldeparture_detected));
                    cmd.Parameters.Add(new SqlParameter("@tsp2_loc_locode", shipmentInfo.tsp2_loc_locode));
                    cmd.Parameters.Add(new SqlParameter("@tsp2_loc_name", shipmentInfo.tsp2_loc_name));
                    cmd.Parameters.Add(new SqlParameter("@tsp2_vslarrival_actual", shipmentInfo.tsp2_vslarrival_actual));
                    cmd.Parameters.Add(new SqlParameter("@tsp2_vslarrival_detected", shipmentInfo.tsp2_vslarrival_detected));
                    cmd.Parameters.Add(new SqlParameter("@tsp2_vsldeparture_actual", shipmentInfo.tsp2_vsldeparture_actual));
                    cmd.Parameters.Add(new SqlParameter("@tsp2_vsldeparture_detected", shipmentInfo.tsp2_vsldeparture_detected));
                    cmd.Parameters.Add(new SqlParameter("@tsp3_loc_locode", shipmentInfo.tsp3_loc_locode));
                    cmd.Parameters.Add(new SqlParameter("@tsp3_loc_name", shipmentInfo.tsp3_loc_name));
                    cmd.Parameters.Add(new SqlParameter("@tsp3_vslarrival_actual", shipmentInfo.tsp3_vslarrival_actual));
                    cmd.Parameters.Add(new SqlParameter("@tsp3_vslarrival_detected", shipmentInfo.tsp3_vslarrival_detected));
                    cmd.Parameters.Add(new SqlParameter("@tsp3_vsldeparture_actual", shipmentInfo.tsp3_vsldeparture_actual));
                    cmd.Parameters.Add(new SqlParameter("@tsp3_vsldeparture_detected", shipmentInfo.tsp3_vsldeparture_detected));
                    cmd.Parameters.Add(new SqlParameter("@tsp4_loc_locode", shipmentInfo.tsp4_loc_locode));
                    cmd.Parameters.Add(new SqlParameter("@tsp4_loc_name", shipmentInfo.tsp4_loc_name));
                    cmd.Parameters.Add(new SqlParameter("@tsp4_vslarrival_actual", shipmentInfo.tsp4_vslarrival_actual));
                    cmd.Parameters.Add(new SqlParameter("@tsp4_vslarrival_detected", shipmentInfo.tsp4_vslarrival_detected));
                    cmd.Parameters.Add(new SqlParameter("@tsp4_vsldeparture_actual", shipmentInfo.tsp4_vsldeparture_actual));
                    cmd.Parameters.Add(new SqlParameter("@tsp4_vsldeparture_detected", shipmentInfo.tsp4_vsldeparture_detected));
                    cmd.Parameters.Add(new SqlParameter("@pod_vslarrival_planned_initial", shipmentInfo.pod_vslarrival_planned_initial));
                    cmd.Parameters.Add(new SqlParameter("@pod_vslarrival_planned_last", shipmentInfo.pod_vslarrival_planned_last));
                    cmd.Parameters.Add(new SqlParameter("@dlv_delivery_planned_initial", shipmentInfo.dlv_delivery_planned_initial));
                    cmd.Parameters.Add(new SqlParameter("@dlv_delivery_planned_last", shipmentInfo.dlv_delivery_planned_last));
                    cmd.Parameters.Add(new SqlParameter("@empty_pickup_loc_name", shipmentInfo.empty_pickup_loc_name));
                    cmd.Parameters.Add(new SqlParameter("@empty_pickup_loc_locode", shipmentInfo.empty_pickup_loc_locode));
                    cmd.Parameters.Add(new SqlParameter("@empty_return_loc_name", shipmentInfo.empty_return_loc_name));
                    cmd.Parameters.Add(new SqlParameter("@empty_return_loc_locode", shipmentInfo.empty_return_loc_locode));
                    cmd.Parameters.Add(new SqlParameter("@current_vessel_position_latitude", shipmentInfo.current_vessel_position_latitude));
                    cmd.Parameters.Add(new SqlParameter("@current_vessel_position_longitude", shipmentInfo.current_vessel_position_longitude));
                    cmd.Parameters.Add(new SqlParameter("@pod_vslarrival_actual", shipmentInfo.pod_vslarrival_actual));
                    cmd.Parameters.Add(new SqlParameter("@pod_discharge_planned_last", shipmentInfo.pod_discharge_planned_last));
                    cmd.Parameters.Add(new SqlParameter("@shipmentsubscription", shipmentInfo.shipmentsubscription));
                    cmd.Parameters.Add(new SqlParameter("@shipmentsubscription_status", shipmentInfo.shipmentsubscription_status));
                    cmd.Parameters.Add(new SqlParameter("@shipmentsubscription_on_hold", shipmentInfo.shipmentsubscription_on_hold));
                    cmd.Parameters.Add(new SqlParameter("@leg1_vessel_id", shipmentInfo.leg1_vessel_id));
                    cmd.Parameters.Add(new SqlParameter("@leg1_vessel_name", shipmentInfo.leg1_vessel_name));
                    cmd.Parameters.Add(new SqlParameter("@leg1_vessel_imo", shipmentInfo.leg1_vessel_imo));
                    cmd.Parameters.Add(new SqlParameter("@dlv_loc_name", shipmentInfo.dlv_loc_name));
                    cmd.Parameters.Add(new SqlParameter("@dlv_loc_locode", shipmentInfo.dlv_loc_locode));
                    cmd.Parameters.Add(new SqlParameter("@pod_loc_name", shipmentInfo.pod_loc_name));
                    cmd.Parameters.Add(new SqlParameter("@pod_loc_locode", shipmentInfo.pod_loc_locode));
                    cmd.Parameters.Add(new SqlParameter("@pol_loc_name", shipmentInfo.pol_loc_name));
                    cmd.Parameters.Add(new SqlParameter("@pol_loc_locode", shipmentInfo.pol_loc_locode));
                    cmd.Parameters.Add(new SqlParameter("@origin_loc_name", shipmentInfo.origin_loc_name));
                    cmd.Parameters.Add(new SqlParameter("@origin_loc_locode", shipmentInfo.origin_loc_locode));
                    cmd.Parameters.Add(new SqlParameter("@carrier_name", shipmentInfo.carrier_name));
                    cmd.Parameters.Add(new SqlParameter("@carrier_scac", shipmentInfo.carrier_scac));
                    cmd.Parameters.Add(new SqlParameter("@url", shipmentInfo.url));
                    cmd.Parameters.Add(new SqlParameter("@lifecycle_status", shipmentInfo.lifecycle_status));
                    cmd.Parameters.Add(new SqlParameter("@id_date", shipmentInfo.id_date));
                    cmd.Parameters.Add(new SqlParameter("@empty_pickup_actual", shipmentInfo.empty_pickup_actual));
                    cmd.Parameters.Add(new SqlParameter("@origin_pickup_actual", shipmentInfo.origin_pickup_actual));
                    cmd.Parameters.Add(new SqlParameter("@pol_vsldeparture_planned_initial", shipmentInfo.pol_vsldeparture_planned_initial));
                    cmd.Parameters.Add(new SqlParameter("@pol_vsldeparture_planned_last", shipmentInfo.pol_vsldeparture_planned_last));
                    cmd.Parameters.Add(new SqlParameter("@pol_vsldeparture_actual", shipmentInfo.pol_vsldeparture_actual));
                    cmd.Parameters.Add(new SqlParameter("@leg1_voyage", shipmentInfo.leg1_voyage));

                    int result = cmd.ExecuteNonQuery();
                }
            }
        }

    }
}