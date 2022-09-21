using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContainerTrackingApp.DTO
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class dtoContainershipments
    {
        [JsonProperty(PropertyName = "id")]
        public int id { get; set; }

        [JsonProperty(PropertyName = "shipmentsubscription_status_verbose")]
        public string shipmentsubscription_status_verbose { get; set; }

        [JsonProperty(PropertyName = "shipmentsubscription_status")]
        public string shipmentsubscription_status { get; set; }

        [JsonProperty(PropertyName = "shipmentsubscription_on_hold")]
        public string shipmentsubscription_on_hold { get; set; }

        [JsonProperty(PropertyName = "shipmentsubscription_id")]
        public string shipmentsubscription_id { get; set; }

        [JsonProperty(PropertyName = "status_verbose")]
        public string status_verbose { get; set; }

        [JsonProperty(PropertyName = "lifecycle_status_verbose")]
        public string lifecycle_status_verbose { get; set; }

        [JsonProperty(PropertyName = "current_vessel_nextport")]
        public dtoVesselnextport current_vessel_nextport { get; set; }

        [JsonProperty(PropertyName = "current_vessel_position")]
        public dtoVesselPosition current_vessel_position { get; set; }

        [JsonProperty(PropertyName = "current_vessel")]
        public dtoVesselInfo current_vessel { get; set; }

        [JsonProperty(PropertyName = "tsp4_loc")]
        public dtoLocationInfo tsp4_loc { get; set; }

        [JsonProperty(PropertyName = "tsp3_loc")]
        public dtoLocationInfo tsp3_loc { get; set; }

        [JsonProperty(PropertyName = "tsp2_loc")]
        public dtoLocationInfo tsp2_loc { get; set; }

        [JsonProperty(PropertyName = "tsp1_loc")]
        public dtoLocationInfo tsp1_loc { get; set; }

        [JsonProperty(PropertyName = "leg5_vessel")]
        public dtoVesselInfo leg5_vessel { get; set; }

        [JsonProperty(PropertyName = "leg4_vessel")]
        public dtoVesselInfo leg4_vessel { get; set; }

        [JsonProperty(PropertyName = "leg3_vessel")]
        public dtoVesselInfo leg3_vessel { get; set; }

        [JsonProperty(PropertyName = "leg2_vessel")]
        public dtoVesselInfo leg2_vessel { get; set; }

        [JsonProperty(PropertyName = "leg1_vessel")]
        public dtoVesselInfo leg1_vessel { get; set; }

        [JsonProperty(PropertyName = "dlv_loc")]
        public dtoLocationInfo dlv_loc { get; set; }

        [JsonProperty(PropertyName = "pod_loc")]
        public dtoLocationInfo pod_loc { get; set; }

        [JsonProperty(PropertyName = "pol_loc")]
        public dtoLocationInfo pol_loc { get; set; }

        [JsonProperty(PropertyName = "origin_loc")]
        public dtoLocationInfo origin_loc { get; set; }

        [JsonProperty(PropertyName = "carrier_name")]
        public string carrier_name { get; set; }

        [JsonProperty(PropertyName = "carrier_scac")]
        public string carrier_scac { get; set; }

        [JsonProperty(PropertyName = "container_type_iso")]
        public string container_type_iso { get; set; }

        [JsonProperty(PropertyName = "container_type_str")]
        public string container_type_str { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string url { get; set; }

        [JsonProperty(PropertyName = "container_number")]
        public string container_number { get; set; }

        [JsonProperty(PropertyName = "booking_number")]
        public string booking_number { get; set; }

        [JsonProperty(PropertyName = "bl_number")]
        public string bl_number { get; set; }

        [JsonProperty(PropertyName = "weight")]
        public string weight { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string status { get; set; }

        [JsonProperty(PropertyName = "lifecycle_status")]
        public string lifecycle_status { get; set; }

        [JsonProperty(PropertyName = "id_date")]
        public string id_date { get; set; }

        [JsonProperty(PropertyName = "descriptive_name")]
        public string descriptive_name { get; set; }

        [JsonProperty(PropertyName = "empty_pickup_planned_initial")]
        public string empty_pickup_planned_initial { get; set; }

        [JsonProperty(PropertyName = "empty_pickup_planned_last")]
        public string empty_pickup_planned_last { get; set; }

        [JsonProperty(PropertyName = "empty_pickup_actual")]
        public string empty_pickup_actual { get; set; }

        [JsonProperty(PropertyName = "origin_pickup_planned_initial")]
        public string origin_pickup_planned_initial { get; set; }

        [JsonProperty(PropertyName = "origin_pickup_planned_last")]
        public string origin_pickup_planned_last { get; set; }

        [JsonProperty(PropertyName = "origin_pickup_actual")]
        public string origin_pickup_actual { get; set; }

        [JsonProperty(PropertyName = "pol_arrival_planned_initial")]
        public string pol_arrival_planned_initial { get; set; }

        [JsonProperty(PropertyName = "pol_arrival_planned_last")]
        public string pol_arrival_planned_last { get; set; }

        [JsonProperty(PropertyName = "pol_arrival_actual")]
        public string pol_arrival_actual { get; set; }

        [JsonProperty(PropertyName = "pol_loaded_planned_initial")]
        public string pol_loaded_planned_initial { get; set; }

        [JsonProperty(PropertyName = "pol_loaded_planned_last")]
        public string pol_loaded_planned_last { get; set; }

        [JsonProperty(PropertyName = "pol_loaded_actual")]
        public string pol_loaded_actual { get; set; }

        [JsonProperty(PropertyName = "pol_vsldeparture_planned_initial")]
        public string pol_vsldeparture_planned_initial { get; set; }

        [JsonProperty(PropertyName = "pol_vsldeparture_planned_last")]
        public string pol_vsldeparture_planned_last { get; set; }

        [JsonProperty(PropertyName = "pol_vsldeparture_actual")]
        public string pol_vsldeparture_actual { get; set; }

        [JsonProperty(PropertyName = "pol_vsldeparture_detected")]
        public string pol_vsldeparture_detected { get; set; }

        [JsonProperty(PropertyName = "leg1_voyage")]
        public string leg1_voyage { get; set; }

        [JsonProperty(PropertyName = "tsp1_vslarrival_planned_initial")]
        public string tsp1_vslarrival_planned_initial { get; set; }

        [JsonProperty(PropertyName = "tsp1_vslarrival_planned_last")]
        public string tsp1_vslarrival_planned_last { get; set; }

        [JsonProperty(PropertyName = "tsp1_vslarrival_actual")]
        public string tsp1_vslarrival_actual { get; set; }

        [JsonProperty(PropertyName = "tsp1_vslarrival_detected")]
        public string tsp1_vslarrival_detected { get; set; }

        [JsonProperty(PropertyName = "tsp1_discharge_planned_initial")]
        public string tsp1_discharge_planned_initial { get; set; }

        [JsonProperty(PropertyName = "tsp1_discharge_planned_last")]
        public string tsp1_discharge_planned_last { get; set; }

        [JsonProperty(PropertyName = "tsp1_discharge_actual")]
        public string tsp1_discharge_actual { get; set; }

        [JsonProperty(PropertyName = "tsp1_loaded_planned_initial")]
        public string tsp1_loaded_planned_initial { get; set; }

        [JsonProperty(PropertyName = "tsp1_loaded_planned_last")]
        public string tsp1_loaded_planned_last { get; set; }

        [JsonProperty(PropertyName = "tsp1_loaded_actual")]
        public string tsp1_loaded_actual { get; set; }

        [JsonProperty(PropertyName = "tsp1_vsldeparture_planned_initial")]
        public string tsp1_vsldeparture_planned_initial { get; set; }

        [JsonProperty(PropertyName = "tsp1_vsldeparture_planned_last")]
        public string tsp1_vsldeparture_planned_last { get; set; }

        [JsonProperty(PropertyName = "tsp1_vsldeparture_actual")]
        public string tsp1_vsldeparture_actual { get; set; }

        [JsonProperty(PropertyName = "tsp1_vsldeparture_detected")]
        public string tsp1_vsldeparture_detected { get; set; }

        [JsonProperty(PropertyName = "leg2_voyage")]
        public string leg2_voyage { get; set; }

        [JsonProperty(PropertyName = "tsp2_vslarrival_planned_initial")]
        public string tsp2_vslarrival_planned_initial { get; set; }

        [JsonProperty(PropertyName = "tsp2_vslarrival_planned_last")]
        public string tsp2_vslarrival_planned_last { get; set; }

        [JsonProperty(PropertyName = "tsp2_vslarrival_actual")]
        public string tsp2_vslarrival_actual { get; set; }

        [JsonProperty(PropertyName = "tsp2_vslarrival_detected")]
        public string tsp2_vslarrival_detected { get; set; }

        [JsonProperty(PropertyName = "tsp2_discharge_planned_initial")]
        public string tsp2_discharge_planned_initial { get; set; }

        [JsonProperty(PropertyName = "tsp2_discharge_planned_last")]
        public string tsp2_discharge_planned_last { get; set; }

        [JsonProperty(PropertyName = "tsp2_discharge_actual")]
        public string tsp2_discharge_actual { get; set; }

        [JsonProperty(PropertyName = "tsp2_loaded_planned_initial")]
        public string tsp2_loaded_planned_initial { get; set; }

        [JsonProperty(PropertyName = "tsp2_loaded_planned_last")]
        public string tsp2_loaded_planned_last { get; set; }

        [JsonProperty(PropertyName = "tsp2_loaded_actual")]
        public string tsp2_loaded_actual { get; set; }

        [JsonProperty(PropertyName = "tsp2_vsldeparture_planned_initial")]
        public string tsp2_vsldeparture_planned_initial { get; set; }

        [JsonProperty(PropertyName = "tsp2_vsldeparture_planned_last")]
        public string tsp2_vsldeparture_planned_last { get; set; }

        [JsonProperty(PropertyName = "tsp2_vsldeparture_actual")]
        public string tsp2_vsldeparture_actual { get; set; }

        [JsonProperty(PropertyName = "tsp2_vsldeparture_detected")]
        public string tsp2_vsldeparture_detected { get; set; }

        [JsonProperty(PropertyName = "leg3_voyage")]
        public string leg3_voyage { get; set; }

        [JsonProperty(PropertyName = "tsp3_vslarrival_planned_initial")]
        public string tsp3_vslarrival_planned_initial { get; set; }

        [JsonProperty(PropertyName = "tsp3_vslarrival_planned_last")]
        public string tsp3_vslarrival_planned_last { get; set; }

        [JsonProperty(PropertyName = "tsp3_vslarrival_actual")]
        public string tsp3_vslarrival_actual { get; set; }

        [JsonProperty(PropertyName = "tsp3_vslarrival_detected")]
        public string tsp3_vslarrival_detected { get; set; }

        [JsonProperty(PropertyName = "tsp3_discharge_planned_initial")]
        public string tsp3_discharge_planned_initial { get; set; }

        [JsonProperty(PropertyName = "tsp3_discharge_planned_last")]
        public string tsp3_discharge_planned_last { get; set; }

        [JsonProperty(PropertyName = "tsp3_discharge_actual")]
        public string tsp3_discharge_actual { get; set; }

        [JsonProperty(PropertyName = "tsp3_loaded_planned_initial")]
        public string tsp3_loaded_planned_initial { get; set; }

        [JsonProperty(PropertyName = "tsp3_loaded_planned_last")]
        public string tsp3_loaded_planned_last { get; set; }

        [JsonProperty(PropertyName = "tsp3_loaded_actual")]
        public string tsp3_loaded_actual { get; set; }

        [JsonProperty(PropertyName = "tsp3_vsldeparture_planned_initial")]
        public string tsp3_vsldeparture_planned_initial { get; set; }

        [JsonProperty(PropertyName = "tsp3_vsldeparture_planned_last")]
        public string tsp3_vsldeparture_planned_last { get; set; }

        [JsonProperty(PropertyName = "tsp3_vsldeparture_actual")]
        public string tsp3_vsldeparture_actual { get; set; }

        [JsonProperty(PropertyName = "tsp3_vsldeparture_detected")]
        public string tsp3_vsldeparture_detected { get; set; }

        [JsonProperty(PropertyName = "leg4_voyage")]
        public string leg4_voyage { get; set; }

        [JsonProperty(PropertyName = "tsp4_vslarrival_planned_initial")]
        public string tsp4_vslarrival_planned_initial { get; set; }

        [JsonProperty(PropertyName = "tsp4_vslarrival_planned_last")]
        public string tsp4_vslarrival_planned_last { get; set; }

        [JsonProperty(PropertyName = "tsp4_vslarrival_actual")]
        public string tsp4_vslarrival_actual { get; set; }

        [JsonProperty(PropertyName = "tsp4_vslarrival_detected")]
        public string tsp4_vslarrival_detected { get; set; }

        [JsonProperty(PropertyName = "tsp4_discharge_planned_initial")]
        public string tsp4_discharge_planned_initial { get; set; }

        [JsonProperty(PropertyName = "tsp4_discharge_planned_last")]
        public string tsp4_discharge_planned_last { get; set; }

        [JsonProperty(PropertyName = "tsp4_discharge_actual")]
        public string tsp4_discharge_actual { get; set; }

        [JsonProperty(PropertyName = "tsp4_loaded_planned_initial")]
        public string tsp4_loaded_planned_initial { get; set; }

        [JsonProperty(PropertyName = "tsp4_loaded_planned_last")]
        public string tsp4_loaded_planned_last { get; set; }

        [JsonProperty(PropertyName = "tsp4_loaded_actual")]
        public string tsp4_loaded_actual { get; set; }

        [JsonProperty(PropertyName = "tsp4_vsldeparture_planned_initial")]
        public string tsp4_vsldeparture_planned_initial { get; set; }

        [JsonProperty(PropertyName = "tsp4_vsldeparture_planned_last")]
        public string tsp4_vsldeparture_planned_last { get; set; }

        [JsonProperty(PropertyName = "tsp4_vsldeparture_actual")]
        public string tsp4_vsldeparture_actual { get; set; }

        [JsonProperty(PropertyName = "tsp4_vsldeparture_detected")]
        public string tsp4_vsldeparture_detected { get; set; }

        [JsonProperty(PropertyName = "leg5_voyage")]
        public string leg5_voyage { get; set; }

        [JsonProperty(PropertyName = "pod_vslarrival_planned_initial")]
        public string pod_vslarrival_planned_initial { get; set; }

        [JsonProperty(PropertyName = "pod_vslarrival_planned_last")]
        public string pod_vslarrival_planned_last { get; set; }

        [JsonProperty(PropertyName = "pod_vslarrival_actual")]
        public string pod_vslarrival_actual { get; set; }

        [JsonProperty(PropertyName = "pod_vslarrival_detected")]
        public string pod_vslarrival_detected { get; set; }

        [JsonProperty(PropertyName = "pod_discharge_planned_initial")]
        public string pod_discharge_planned_initial { get; set; }

        [JsonProperty(PropertyName = "pod_discharge_planned_last")]
        public string pod_discharge_planned_last { get; set; }

        [JsonProperty(PropertyName = "pod_discharge_actual")]
        public string pod_discharge_actual { get; set; }

        [JsonProperty(PropertyName = "pod_departure_planned_initial")]
        public string pod_departure_planned_initial { get; set; }

        [JsonProperty(PropertyName = "pod_departure_planned_last")]
        public string pod_departure_planned_last { get; set; }

        [JsonProperty(PropertyName = "pod_departure_actual")]
        public string pod_departure_actual { get; set; }

        [JsonProperty(PropertyName = "dlv_delivery_planned_initial")]
        public string dlv_delivery_planned_initial { get; set; }

        [JsonProperty(PropertyName = "dlv_delivery_planned_last")]
        public string dlv_delivery_planned_last { get; set; }

        [JsonProperty(PropertyName = "dlv_delivery_actual")]
        public string dlv_delivery_actual { get; set; }

        [JsonProperty(PropertyName = "empty_return_planned_initial")]
        public string empty_return_planned_initial { get; set; }

        [JsonProperty(PropertyName = "empty_return_planned_last")]
        public string empty_return_planned_last { get; set; }

        [JsonProperty(PropertyName = "empty_return_actual")]
        public string empty_return_actual { get; set; }

        [JsonProperty(PropertyName = "ts_count")]
        public string ts_count { get; set; }

        [JsonProperty(PropertyName = "last_carrier_update")]
        public string last_carrier_update { get; set; }

        [JsonProperty(PropertyName = "last_actuals_update")]
        public string last_actuals_update { get; set; }

        [JsonProperty(PropertyName = "created")]
        public string created { get; set; }

        [JsonProperty(PropertyName = "modified")]
        public string modified { get; set; }

        [JsonProperty(PropertyName = "shipmentsubscription")]
        public string shipmentsubscription { get; set; }

        [JsonProperty(PropertyName = "empty_pickup_loc")]
        public dtoLocationInfo empty_pickup_loc { get; set; }

        [JsonProperty(PropertyName = "lif_loc")]
        public dtoLocationInfo lif_loc { get; set; }

        [JsonProperty(PropertyName = "empty_return_loc")]
        public dtoLocationInfo empty_return_loc { get; set; }
    }
}