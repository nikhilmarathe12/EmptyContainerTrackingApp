﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContainerTrackingApp.Models
{
    public class Containershipment
    {
        public int id { get; set; }
        public int RequestID { get; set; }
        public string shipmentsubscription_status_verbose { get; set; }
        public string shipmentsubscription_status { get; set; }
        public string shipmentsubscription_on_hold { get; set; }
        public string shipmentsubscription_id { get; set; }
        public string status_verbose { get; set; }
        public string lifecycle_status_verbose { get; set; }
        public string current_vessel_nextport { get; set; }
        public string current_vessel_position { get; set; }
        public string current_vessel { get; set; }
        public LocationInfo tsp4_loc { get; set; }
        public LocationInfo tsp3_loc { get; set; }
        public LocationInfo tsp2_loc { get; set; }
        public LocationInfo tsp1_loc { get; set; }
        public VesselInfo leg5_vessel { get; set; }
        public VesselInfo leg4_vessel { get; set; }
        public VesselInfo leg3_vessel { get; set; }
        public VesselInfo leg2_vessel { get; set; }
        public VesselInfo leg1_vessel { get; set; }
        public LocationInfo dlv_loc { get; set; }
        public LocationInfo pod_loc { get; set; }
        public LocationInfo pol_loc { get; set; }
        public LocationInfo origin_loc { get; set; }
        public string carrier_name { get; set; }
        public string carrier_scac { get; set; }
        public string container_type_iso { get; set; }
        public string container_type_str { get; set; }
        public string url { get; set; }
        public string container_number { get; set; }
        public string booking_number { get; set; }
        public string bl_number { get; set; }
        public string weight { get; set; }
        public string status { get; set; }
        public string lifecycle_status { get; set; }
        public string id_date { get; set; }
        public string descriptive_name { get; set; }
        public string empty_pickup_planned_initial { get; set; }
        public string empty_pickup_planned_last { get; set; }
        public string empty_pickup_actual { get; set; }
        public string origin_pickup_planned_initial { get; set; }
        public string origin_pickup_planned_last { get; set; }
        public string origin_pickup_actual { get; set; }
        public string pol_arrival_planned_initial { get; set; }
        public string pol_arrival_planned_last { get; set; }
        public string pol_arrival_actual { get; set; }
        public string pol_loaded_planned_initial { get; set; }
        public string pol_loaded_planned_last { get; set; }
        public string pol_loaded_actual { get; set; }
        public string pol_vsldeparture_planned_initial { get; set; }
        public string pol_vsldeparture_planned_last { get; set; }
        public string pol_vsldeparture_actual { get; set; }
        public string pol_vsldeparture_detected { get; set; }
        public string leg1_voyage { get; set; }
        public string tsp1_vslarrival_planned_initial { get; set; }
        public string tsp1_vslarrival_planned_last { get; set; }
        public string tsp1_vslarrival_actual { get; set; }
        public string tsp1_vslarrival_detected { get; set; }
        public string tsp1_discharge_planned_initial { get; set; }
        public string tsp1_discharge_planned_last { get; set; }
        public string tsp1_discharge_actual { get; set; }
        public string tsp1_loaded_planned_initial { get; set; }
        public string tsp1_loaded_planned_last { get; set; }
        public string tsp1_loaded_actual { get; set; }
        public string tsp1_vsldeparture_planned_initial { get; set; }
        public string tsp1_vsldeparture_planned_last { get; set; }
        public string tsp1_vsldeparture_actual { get; set; }
        public string tsp1_vsldeparture_detected { get; set; }
        public string leg2_voyage { get; set; }
        public string tsp2_vslarrival_planned_initial { get; set; }
        public string tsp2_vslarrival_planned_last { get; set; }
        public string tsp2_vslarrival_actual { get; set; }
        public string tsp2_vslarrival_detected { get; set; }
        public string tsp2_discharge_planned_initial { get; set; }
        public string tsp2_discharge_planned_last { get; set; }
        public string tsp2_discharge_actual { get; set; }
        public string tsp2_loaded_planned_initial { get; set; }
        public string tsp2_loaded_planned_last { get; set; }
        public string tsp2_loaded_actual { get; set; }
        public string tsp2_vsldeparture_planned_initial { get; set; }
        public string tsp2_vsldeparture_planned_last { get; set; }
        public string tsp2_vsldeparture_actual { get; set; }
        public string tsp2_vsldeparture_detected { get; set; }
        public string leg3_voyage { get; set; }
        public string tsp3_vslarrival_planned_initial { get; set; }
        public string tsp3_vslarrival_planned_last { get; set; }
        public string tsp3_vslarrival_actual { get; set; }
        public string tsp3_vslarrival_detected { get; set; }
        public string tsp3_discharge_planned_initial { get; set; }
        public string tsp3_discharge_planned_last { get; set; }
        public string tsp3_discharge_actual { get; set; }
        public string tsp3_loaded_planned_initial { get; set; }
        public string tsp3_loaded_planned_last { get; set; }
        public string tsp3_loaded_actual { get; set; }
        public string tsp3_vsldeparture_planned_initial { get; set; }
        public string tsp3_vsldeparture_planned_last { get; set; }
        public string tsp3_vsldeparture_actual { get; set; }
        public string tsp3_vsldeparture_detected { get; set; }
        public string leg4_voyage { get; set; }
        public string tsp4_vslarrival_planned_initial { get; set; }
        public string tsp4_vslarrival_planned_last { get; set; }
        public string tsp4_vslarrival_actual { get; set; }
        public string tsp4_vslarrival_detected { get; set; }
        public string tsp4_discharge_planned_initial { get; set; }
        public string tsp4_discharge_planned_last { get; set; }
        public string tsp4_discharge_actual { get; set; }
        public string tsp4_loaded_planned_initial { get; set; }
        public string tsp4_loaded_planned_last { get; set; }
        public string tsp4_loaded_actual { get; set; }
        public string tsp4_vsldeparture_planned_initial { get; set; }
        public string tsp4_vsldeparture_planned_last { get; set; }
        public string tsp4_vsldeparture_actual { get; set; }
        public string tsp4_vsldeparture_detected { get; set; }
        public string leg5_voyage { get; set; }
        public string pod_vslarrival_planned_initial { get; set; }
        public string pod_vslarrival_planned_last { get; set; }
        public string pod_vslarrival_actual { get; set; }
        public string pod_vslarrival_detected { get; set; }
        public string pod_discharge_planned_initial { get; set; }
        public string pod_discharge_planned_last { get; set; }
        public string pod_discharge_actual { get; set; }
        public string pod_departure_planned_initial { get; set; }
        public string pod_departure_planned_last { get; set; }
        public string pod_departure_actual { get; set; }
        public string dlv_delivery_planned_initial { get; set; }
        public string dlv_delivery_planned_last { get; set; }
        public string dlv_delivery_actual { get; set; }
        public string empty_return_planned_initial { get; set; }
        public string empty_return_planned_last { get; set; }
        public string empty_return_actual { get; set; }
        public string ts_count { get; set; }
        public string last_carrier_update { get; set; }
        public string last_actuals_update { get; set; }
        public string created { get; set; }
        public string modified { get; set; }
        public string shipmentsubscription { get; set; }
        public LocationInfo empty_pickup_loc { get; set; }
        public LocationInfo lif_loc { get; set; }
        public LocationInfo empty_return_loc { get; set; }
    }
}