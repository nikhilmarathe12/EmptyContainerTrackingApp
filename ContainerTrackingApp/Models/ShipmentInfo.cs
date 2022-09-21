using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContainerTrackingApp.Models
{
    public class ShipmentInfo
    {
        [Key]
        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("Ref ID")]
        public int refID { get; set; }

        [DisplayName("Request ID")]
        public int RequestID { get; set; }

        [DisplayName("Container ID")]
        public string ContainerID { get; set; }

        [DisplayName("subscription status verbose")]
        public string shipmentsubscription_status_verbose { get; set; }

        [DisplayName("subscription status")]
        public string shipmentsubscription_status { get; set; }

        [DisplayName("subscription Onhold")]
        public string shipmentsubscription_on_hold { get; set; }

        [DisplayName("subscription id")]
        public string shipmentsubscription_id { get; set; }

        [DisplayName("status verbose")]
        public string status_verbose { get; set; }

        [DisplayName("lifecycle status verbose")]
        public string lifecycle_status_verbose { get; set; }

        [DisplayName("current vessel nextport eta")]
        public string current_vessel_nextport_eta { get; set; }

        [DisplayName("current vessel nextport name")]
        public string current_vessel_nextport_name { get; set; }

        [DisplayName("current vessel nextport locode")]
        public string current_vessel_nextport_locode { get; set; }

        [DisplayName("current vessel position latitude")]
        public string current_vessel_position_latitude { get; set; }

        [DisplayName("current vessel position timestamp")]
        public string current_vessel_position_timestamp { get; set; }

        [DisplayName("current vessel position heading")]
        public string current_vessel_position_heading { get; set; }

        [DisplayName("current vessel position longitude")]
        public string current_vessel_position_longitude { get; set; }

        [DisplayName("current vessel name")]
        public string current_vessel_name { get; set; }

        [DisplayName("current vessel imo")]
        public string current_vessel_imo { get; set; }

        [DisplayName("current vessel id")]
        public string current_vessel_id { get; set; }

        [DisplayName("tsp4 loc ShipmentID")]
        public int tsp4_loc_ShipmentID { get; set; }

        [DisplayName("tsp4 loc name")]
        public string tsp4_loc_name { get; set; }

        [DisplayName("tsp4 loc locode")]
        public string tsp4_loc_locode { get; set; }

        [DisplayName("tsp4 loc ShipmentID")]
        public int tsp3_loc_ShipmentID { get; set; }

        [DisplayName("tsp3 loc name")]
        public string tsp3_loc_name { get; set; }

        [DisplayName("tsp3 loc locode")]
        public string tsp3_loc_locode { get; set; }

        [DisplayName("tsp2 loc ShipmentID")]
        public int tsp2_loc_ShipmentID { get; set; }

        [DisplayName("tsp2 loc name")]
        public string tsp2_loc_name { get; set; }

        [DisplayName("tsp2 loc locode")]
        public string tsp2_loc_locode { get; set; }

        [DisplayName("tsp1 loc ShipmentID")]
        public int tsp1_loc_ShipmentID { get; set; }

        [DisplayName("tsp1 loc name")]
        public string tsp1_loc_name { get; set; }

        [DisplayName("tsp1 loc locode")]
        public string tsp1_loc_locode { get; set; }

        [DisplayName("leg5 vessel id")]
        public string leg5_vessel_id { get; set; }

        [DisplayName("leg5 vessel name")]
        public string leg5_vessel_name { get; set; }

        [DisplayName("leg5 vessel imo")]
        public string leg5_vessel_imo { get; set; }

        [DisplayName("leg4 vessel id")]
        public string leg4_vessel_id { get; set; }

        [DisplayName("leg4 vessel name")]
        public string leg4_vessel_name { get; set; }

        [DisplayName("leg4 vessel imo")]
        public string leg4_vessel_imo { get; set; }

        [DisplayName("leg3 vessel id")]
        public string leg3_vessel_id { get; set; }

        [DisplayName("leg3 vessel name")]
        public string leg3_vessel_name { get; set; }

        [DisplayName("leg3 vessel imo")]
        public string leg3_vessel_imo { get; set; }

        [DisplayName("leg2 vessel id")]
        public string leg2_vessel_id { get; set; }

        [DisplayName("leg2 vessel name")]
        public string leg2_vessel_name { get; set; }

        [DisplayName("leg2 vessel imo")]
        public string leg2_vessel_imo { get; set; }

        [DisplayName("leg1 vessel id")]
        public string leg1_vessel_id { get; set; }

        [DisplayName("leg1 vessel name")]
        public string leg1_vessel_name { get; set; }

        [DisplayName("leg1 vessel imo")]
        public string leg1_vessel_imo { get; set; }

        [DisplayName("dlv name")]
        public string dlv_loc_name { get; set; }

        [DisplayName("dlv locode")]
        public string dlv_loc_locode { get; set; }

        [DisplayName(" pod name")]
        public string pod_loc_name { get; set; }

        [DisplayName("pod locode")]
        public string pod_loc_locode { get; set; }

        [DisplayName("pol name")]
        public string pol_loc_name { get; set; }

        [DisplayName("pol locode")]
        public string pol_loc_locode { get; set; }

        [DisplayName("origin name")]
        public string origin_loc_name { get; set; }

        [DisplayName("origin locode")]
        public string origin_loc_locode { get; set; }

        [DisplayName("Carrier Name")]
        public string carrier_name { get; set; }

        [DisplayName("carrier scac")]
        public string carrier_scac { get; set; }

        [DisplayName("containertype iso")]
        public string container_type_iso { get; set; }

        [DisplayName("container type")]
        public string container_type_str { get; set; }

        [DisplayName("url")]
        public string url { get; set; }

        [DisplayName("container number")]
        public string container_number { get; set; }

        [DisplayName("booking number")]
        public string booking_number { get; set; }

        [DisplayName("bl number")]
        public string bl_number { get; set; }

        [DisplayName("weight")]
        public string weight { get; set; }

        [DisplayName("status")]
        public string status { get; set; }

        [DisplayName("lifecycle status")]
        public string lifecycle_status { get; set; }

        [DisplayName("id date")]
        public string id_date { get; set; }

        [DisplayName("descriptive name")]
        public string descriptive_name { get; set; }

        [DisplayName("empty pickup planned initial")]
        public string empty_pickup_planned_initial { get; set; }

        [DisplayName("empty pickup planned last")]
        public string empty_pickup_planned_last { get; set; }

        [DisplayName("empty pickup actual")]
        public string empty_pickup_actual { get; set; }

        [DisplayName("origin pickup planned initial")]
        public string origin_pickup_planned_initial { get; set; }

        [DisplayName("origin pickup planned last")]
        public string origin_pickup_planned_last { get; set; }

        [DisplayName("origin pickup actual")]
        public string origin_pickup_actual { get; set; }

        [DisplayName("pol arrival planned initial")]
        public string pol_arrival_planned_initial { get; set; }

        [DisplayName("pol arrival planned last")]
        public string pol_arrival_planned_last { get; set; }

        [DisplayName("pol arrival actual")]
        public string pol_arrival_actual { get; set; }

        [DisplayName("pol loaded planned initial")]
        public string pol_loaded_planned_initial { get; set; }

        [DisplayName("pol loaded planned last")]
        public string pol_loaded_planned_last { get; set; }

        [DisplayName("pol loaded actual")]
        public string pol_loaded_actual { get; set; }

        [DisplayName("pol vsldeparture planned initial")]
        public string pol_vsldeparture_planned_initial { get; set; }

        [DisplayName("pol vsldeparture planned last")]
        public string pol_vsldeparture_planned_last { get; set; }

        [DisplayName("pol vsldeparture actual")]
        public string pol_vsldeparture_actual { get; set; }

        [DisplayName("pol vsldeparture detected")]
        public string pol_vsldeparture_detected { get; set; }

        [DisplayName("leg1 voyage")]
        public string leg1_voyage { get; set; }

        [DisplayName("tsp1 vslarrival planned initial")]
        public string tsp1_vslarrival_planned_initial { get; set; }

        [DisplayName("tsp1 vslarrival planned last")]
        public string tsp1_vslarrival_planned_last { get; set; }

        [DisplayName("tsp1 vslarrival actual")]
        public string tsp1_vslarrival_actual { get; set; }

        [DisplayName("tsp1 vslarrival detected")]
        public string tsp1_vslarrival_detected { get; set; }

        [DisplayName("tsp1 discharge planned initial")]
        public string tsp1_discharge_planned_initial { get; set; }

        [DisplayName("tsp1 discharge planned last")]
        public string tsp1_discharge_planned_last { get; set; }

        [DisplayName("tsp1 discharge actual")]
        public string tsp1_discharge_actual { get; set; }

        [DisplayName("tsp1 loaded planned initial")]
        public string tsp1_loaded_planned_initial { get; set; }

        [DisplayName("tsp1 loaded planned last")]
        public string tsp1_loaded_planned_last { get; set; }

        [DisplayName("tsp1 loaded actual")]
        public string tsp1_loaded_actual { get; set; }

        [DisplayName("tsp1 vsldeparture planned initial")]
        public string tsp1_vsldeparture_planned_initial { get; set; }

        [DisplayName("tsp1 vsldeparture planned last")]
        public string tsp1_vsldeparture_planned_last { get; set; }

        [DisplayName("tsp1 vsldeparture actual")]
        public string tsp1_vsldeparture_actual { get; set; }

        [DisplayName("tsp1 vsldeparture detected")]
        public string tsp1_vsldeparture_detected { get; set; }

        [DisplayName("leg2 voyage")]
        public string leg2_voyage { get; set; }

        [DisplayName("tsp2 vslarrival planned initial")]
        public string tsp2_vslarrival_planned_initial { get; set; }

        [DisplayName("tsp2 vslarrival planned last")]
        public string tsp2_vslarrival_planned_last { get; set; }

        [DisplayName("tsp2 vslarrival actual")]
        public string tsp2_vslarrival_actual { get; set; }

        [DisplayName("tsp2 vslarrival detected")]
        public string tsp2_vslarrival_detected { get; set; }

        [DisplayName("tsp2 discharge planned initial")]
        public string tsp2_discharge_planned_initial { get; set; }

        [DisplayName("tsp2 discharge planned last")]
        public string tsp2_discharge_planned_last { get; set; }

        [DisplayName("tsp2 discharge actual")]
        public string tsp2_discharge_actual { get; set; }

        [DisplayName("tsp2 loaded planned initial")]
        public string tsp2_loaded_planned_initial { get; set; }

        [DisplayName("tsp2 loaded planned last")]
        public string tsp2_loaded_planned_last { get; set; }

        [DisplayName("tsp2 loaded actual")]
        public string tsp2_loaded_actual { get; set; }

        [DisplayName("tsp2 vsldeparture planned initial")]
        public string tsp2_vsldeparture_planned_initial { get; set; }

        [DisplayName("tsp2 vsldeparture planned last")]
        public string tsp2_vsldeparture_planned_last { get; set; }

        [DisplayName("tsp2 vsldeparture actual")]
        public string tsp2_vsldeparture_actual { get; set; }

        [DisplayName("tsp2 vsldeparture detected")]
        public string tsp2_vsldeparture_detected { get; set; }

        [DisplayName("leg3 voyage")]
        public string leg3_voyage { get; set; }

        [DisplayName("tsp3 vslarrival planned initial")]
        public string tsp3_vslarrival_planned_initial { get; set; }

        [DisplayName("tsp3 vslarrival planned last")]
        public string tsp3_vslarrival_planned_last { get; set; }

        [DisplayName("tsp3 vslarrival actual")]
        public string tsp3_vslarrival_actual { get; set; }

        [DisplayName("tsp3 vslarrival detected")]
        public string tsp3_vslarrival_detected { get; set; }

        [DisplayName("tsp3 discharge planned initial")]
        public string tsp3_discharge_planned_initial { get; set; }

        [DisplayName("tsp3 discharge planned last")]
        public string tsp3_discharge_planned_last { get; set; }

        [DisplayName("tsp3 discharge actual")]
        public string tsp3_discharge_actual { get; set; }

        [DisplayName("tsp3 loaded planned initial")]
        public string tsp3_loaded_planned_initial { get; set; }

        [DisplayName("tsp3 loaded planned last")]
        public string tsp3_loaded_planned_last { get; set; }

        [DisplayName("tsp3 loaded actual")]
        public string tsp3_loaded_actual { get; set; }

        [DisplayName("tsp3 vsldeparture planned initial")]
        public string tsp3_vsldeparture_planned_initial { get; set; }

        [DisplayName("tsp3 vsldeparture planned last")]
        public string tsp3_vsldeparture_planned_last { get; set; }

        [DisplayName("tsp3 vsldeparture actual")]
        public string tsp3_vsldeparture_actual { get; set; }

        [DisplayName("tsp3 vsldeparture detected")]
        public string tsp3_vsldeparture_detected { get; set; }

        [DisplayName("leg4 voyage")]
        public string leg4_voyage { get; set; }

        [DisplayName("tsp4 vslarrival planned initial")]
        public string tsp4_vslarrival_planned_initial { get; set; }

        [DisplayName("tsp4 vslarrival planned last")]
        public string tsp4_vslarrival_planned_last { get; set; }

        [DisplayName("tsp4 vslarrival actual")]
        public string tsp4_vslarrival_actual { get; set; }

        [DisplayName("tsp4 vslarrival detected")]
        public string tsp4_vslarrival_detected { get; set; }

        [DisplayName("tsp4 discharge planned initial")]
        public string tsp4_discharge_planned_initial { get; set; }

        [DisplayName("tsp4 discharge planned last")]
        public string tsp4_discharge_planned_last { get; set; }

        [DisplayName("tsp4 discharge actual")]
        public string tsp4_discharge_actual { get; set; }

        [DisplayName("tsp4 loaded planned initial")]
        public string tsp4_loaded_planned_initial { get; set; }

        [DisplayName("tsp4 loaded planned last")]
        public string tsp4_loaded_planned_last { get; set; }

        [DisplayName("tsp4 loaded actual")]
        public string tsp4_loaded_actual { get; set; }

        [DisplayName("tsp4 vsldeparture planned initial")]
        public string tsp4_vsldeparture_planned_initial { get; set; }

        [DisplayName("tsp4 vsldeparture planned last")]
        public string tsp4_vsldeparture_planned_last { get; set; }

        [DisplayName("tsp4 vsldeparture actual")]
        public string tsp4_vsldeparture_actual { get; set; }

        [DisplayName("tsp4 vsldeparture detected")]
        public string tsp4_vsldeparture_detected { get; set; }

        [DisplayName("leg5 voyage")]
        public string leg5_voyage { get; set; }

        [DisplayName("pod vslarrival planned initial")]
        public string pod_vslarrival_planned_initial { get; set; }

        [DisplayName("pod vslarrival planned last")]
        public string pod_vslarrival_planned_last { get; set; }

        [DisplayName("pod vslarrival actual")]
        public string pod_vslarrival_actual { get; set; }

        [DisplayName("pod discharge planned initial")]
        public string pod_vslarrival_detected { get; set; }

        [DisplayName("pod discharge planned initial")]
        public string pod_discharge_planned_initial { get; set; }

        [DisplayName("pod discharge planned last")]
        public string pod_discharge_planned_last { get; set; }

        [DisplayName("pod discharge actual")]
        public string pod_discharge_actual { get; set; }

        [DisplayName("pod departure planned initial")]
        public string pod_departure_planned_initial { get; set; }

        [DisplayName("pod departure planned last")]
        public string pod_departure_planned_last { get; set; }

        [DisplayName("pod departure actual")]
        public string pod_departure_actual { get; set; }

        [DisplayName("dlv delivery planned initial")]
        public string dlv_delivery_planned_initial { get; set; }

        [DisplayName("dlv delivery planned last")]
        public string dlv_delivery_planned_last { get; set; }

        [DisplayName("dlv delivery actual")]
        public string dlv_delivery_actual { get; set; }

        [DisplayName("empty return planned initial")]
        public string empty_return_planned_initial { get; set; }

        [DisplayName("empty return planned last")]
        public string empty_return_planned_last { get; set; }

        [DisplayName("empty return actual")]
        public string empty_return_actual { get; set; }

        [DisplayName("Contianer count")]
        public string ts_count { get; set; }

        [DisplayName("last carrier update")]
        public string last_carrier_update { get; set; }

        [DisplayName("last actuals update")]
        public string last_actuals_update { get; set; }

        [DisplayName("created")]
        public string created { get; set; }

        [DisplayName("modified")]
        public string modified { get; set; }

        [DisplayName("shipment subscription")]
        public string shipmentsubscription { get; set; }

        [DisplayName("empty pickup name")]
        public string empty_pickup_loc_name { get; set; }

        [DisplayName("empty pickup locode")]
        public string empty_pickup_loc_locode { get; set; }

        [DisplayName("lif name")]
        public string lif_loc_name { get; set; }

        [DisplayName("lif locode")]
        public string lif_loc_locode { get; set; }

        [DisplayName("empty return name")]
        public string empty_return_loc_name { get; set; }

        [DisplayName("empty return locode")]
        public string empty_return_loc_locode { get; set; }
    }
}