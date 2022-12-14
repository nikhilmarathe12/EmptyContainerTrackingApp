USE [TestContainerTrackingDB]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 09/21/2022 13:17:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClientKeys]    Script Date: 09/21/2022 13:17:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientKeys](
	[ClientKeyID] [int] IDENTITY(1,1) NOT NULL,
	[CompanyID] [int] NOT NULL,
	[ClientID] [nvarchar](max) NULL,
	[ClientSecret] [nvarchar](150) NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[UserID] [int] NOT NULL,
 CONSTRAINT [PK_dbo.ClientKeys] PRIMARY KEY CLUSTERED 
(
	[ClientKeyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CompanyMappings]    Script Date: 09/21/2022 13:17:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompanyMappings](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CompanyID] [int] NOT NULL,
	[CompanyCode] [int] NOT NULL,
	[CompanyName] [nvarchar](max) NULL,
	[CompanyDBNames] [nvarchar](max) NULL,
	[CompanyDBInfo] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.CompanyMappings] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContainershipmentDetailHists]    Script Date: 09/21/2022 13:17:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContainershipmentDetailHists](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HistrefID] [int] NOT NULL,
	[RequestID] [int] NOT NULL,
	[ContainerID] [nvarchar](max) NULL,
	[shipmentsubscription_status_verbose] [nvarchar](max) NULL,
	[shipmentsubscription_status] [nvarchar](max) NULL,
	[shipmentsubscription_on_hold] [nvarchar](max) NULL,
	[shipmentsubscription_id] [nvarchar](max) NULL,
	[status_verbose] [nvarchar](max) NULL,
	[lifecycle_status_verbose] [nvarchar](max) NULL,
	[current_vessel_nextport_eta] [nvarchar](max) NULL,
	[current_vessel_nextport_name] [nvarchar](max) NULL,
	[current_vessel_nextport_locode] [nvarchar](max) NULL,
	[current_vessel_position_latitude] [nvarchar](max) NULL,
	[current_vessel_position_timestamp] [nvarchar](max) NULL,
	[current_vessel_position_heading] [nvarchar](max) NULL,
	[current_vessel_position_longitude] [nvarchar](max) NULL,
	[current_vessel_name] [nvarchar](max) NULL,
	[current_vessel_imo] [nvarchar](max) NULL,
	[current_vessel_id] [nvarchar](max) NULL,
	[tsp4_loc_ShipmentID] [int] NOT NULL,
	[tsp4_loc_name] [nvarchar](max) NULL,
	[tsp4_loc_locode] [nvarchar](max) NULL,
	[tsp3_loc_ShipmentID] [int] NOT NULL,
	[tsp3_loc_name] [nvarchar](max) NULL,
	[tsp3_loc_locode] [nvarchar](max) NULL,
	[tsp2_loc_ShipmentID] [int] NOT NULL,
	[tsp2_loc_name] [nvarchar](max) NULL,
	[tsp2_loc_locode] [nvarchar](max) NULL,
	[tsp1_loc_ShipmentID] [int] NOT NULL,
	[tsp1_loc_name] [nvarchar](max) NULL,
	[tsp1_loc_locode] [nvarchar](max) NULL,
	[leg5_vessel_id] [nvarchar](max) NULL,
	[leg5_vessel_name] [nvarchar](max) NULL,
	[leg5_vessel_imo] [nvarchar](max) NULL,
	[leg4_vessel_id] [nvarchar](max) NULL,
	[leg4_vessel_name] [nvarchar](max) NULL,
	[leg4_vessel_imo] [nvarchar](max) NULL,
	[leg3_vessel_id] [nvarchar](max) NULL,
	[leg3_vessel_name] [nvarchar](max) NULL,
	[leg3_vessel_imo] [nvarchar](max) NULL,
	[leg2_vessel_id] [nvarchar](max) NULL,
	[leg2_vessel_name] [nvarchar](max) NULL,
	[leg2_vessel_imo] [nvarchar](max) NULL,
	[leg1_vessel_id] [nvarchar](max) NULL,
	[leg1_vessel_name] [nvarchar](max) NULL,
	[leg1_vessel_imo] [nvarchar](max) NULL,
	[dlv_loc_name] [nvarchar](max) NULL,
	[dlv_loc_locode] [nvarchar](max) NULL,
	[pod_loc_name] [nvarchar](max) NULL,
	[pod_loc_locode] [nvarchar](max) NULL,
	[pol_loc_name] [nvarchar](max) NULL,
	[pol_loc_locode] [nvarchar](max) NULL,
	[origin_loc_name] [nvarchar](max) NULL,
	[origin_loc_locode] [nvarchar](max) NULL,
	[carrier_name] [nvarchar](max) NULL,
	[carrier_scac] [nvarchar](max) NULL,
	[container_type_iso] [nvarchar](max) NULL,
	[container_type_str] [nvarchar](max) NULL,
	[url] [nvarchar](max) NULL,
	[container_number] [nvarchar](max) NULL,
	[booking_number] [nvarchar](max) NULL,
	[bl_number] [nvarchar](max) NULL,
	[weight] [nvarchar](max) NULL,
	[status] [nvarchar](max) NULL,
	[lifecycle_status] [nvarchar](max) NULL,
	[id_date] [nvarchar](max) NULL,
	[descriptive_name] [nvarchar](max) NULL,
	[empty_pickup_planned_initial] [nvarchar](max) NULL,
	[empty_pickup_planned_last] [nvarchar](max) NULL,
	[empty_pickup_actual] [nvarchar](max) NULL,
	[origin_pickup_planned_initial] [nvarchar](max) NULL,
	[origin_pickup_planned_last] [nvarchar](max) NULL,
	[origin_pickup_actual] [nvarchar](max) NULL,
	[pol_arrival_planned_initial] [nvarchar](max) NULL,
	[pol_arrival_planned_last] [nvarchar](max) NULL,
	[pol_arrival_actual] [nvarchar](max) NULL,
	[pol_loaded_planned_initial] [nvarchar](max) NULL,
	[pol_loaded_planned_last] [nvarchar](max) NULL,
	[pol_loaded_actual] [nvarchar](max) NULL,
	[pol_vsldeparture_planned_initial] [nvarchar](max) NULL,
	[pol_vsldeparture_planned_last] [nvarchar](max) NULL,
	[pol_vsldeparture_actual] [nvarchar](max) NULL,
	[pol_vsldeparture_detected] [nvarchar](max) NULL,
	[leg1_voyage] [nvarchar](max) NULL,
	[tsp1_vslarrival_planned_initial] [nvarchar](max) NULL,
	[tsp1_vslarrival_planned_last] [nvarchar](max) NULL,
	[tsp1_vslarrival_actual] [nvarchar](max) NULL,
	[tsp1_vslarrival_detected] [nvarchar](max) NULL,
	[tsp1_discharge_planned_initial] [nvarchar](max) NULL,
	[tsp1_discharge_planned_last] [nvarchar](max) NULL,
	[tsp1_discharge_actual] [nvarchar](max) NULL,
	[tsp1_loaded_planned_initial] [nvarchar](max) NULL,
	[tsp1_loaded_planned_last] [nvarchar](max) NULL,
	[tsp1_loaded_actual] [nvarchar](max) NULL,
	[tsp1_vsldeparture_planned_initial] [nvarchar](max) NULL,
	[tsp1_vsldeparture_planned_last] [nvarchar](max) NULL,
	[tsp1_vsldeparture_actual] [nvarchar](max) NULL,
	[tsp1_vsldeparture_detected] [nvarchar](max) NULL,
	[leg2_voyage] [nvarchar](max) NULL,
	[tsp2_vslarrival_planned_initial] [nvarchar](max) NULL,
	[tsp2_vslarrival_planned_last] [nvarchar](max) NULL,
	[tsp2_vslarrival_actual] [nvarchar](max) NULL,
	[tsp2_vslarrival_detected] [nvarchar](max) NULL,
	[tsp2_discharge_planned_initial] [nvarchar](max) NULL,
	[tsp2_discharge_planned_last] [nvarchar](max) NULL,
	[tsp2_discharge_actual] [nvarchar](max) NULL,
	[tsp2_loaded_planned_initial] [nvarchar](max) NULL,
	[tsp2_loaded_planned_last] [nvarchar](max) NULL,
	[tsp2_loaded_actual] [nvarchar](max) NULL,
	[tsp2_vsldeparture_planned_initial] [nvarchar](max) NULL,
	[tsp2_vsldeparture_planned_last] [nvarchar](max) NULL,
	[tsp2_vsldeparture_actual] [nvarchar](max) NULL,
	[tsp2_vsldeparture_detected] [nvarchar](max) NULL,
	[leg3_voyage] [nvarchar](max) NULL,
	[tsp3_vslarrival_planned_initial] [nvarchar](max) NULL,
	[tsp3_vslarrival_planned_last] [nvarchar](max) NULL,
	[tsp3_vslarrival_actual] [nvarchar](max) NULL,
	[tsp3_vslarrival_detected] [nvarchar](max) NULL,
	[tsp3_discharge_planned_initial] [nvarchar](max) NULL,
	[tsp3_discharge_planned_last] [nvarchar](max) NULL,
	[tsp3_discharge_actual] [nvarchar](max) NULL,
	[tsp3_loaded_planned_initial] [nvarchar](max) NULL,
	[tsp3_loaded_planned_last] [nvarchar](max) NULL,
	[tsp3_loaded_actual] [nvarchar](max) NULL,
	[tsp3_vsldeparture_planned_initial] [nvarchar](max) NULL,
	[tsp3_vsldeparture_planned_last] [nvarchar](max) NULL,
	[tsp3_vsldeparture_actual] [nvarchar](max) NULL,
	[tsp3_vsldeparture_detected] [nvarchar](max) NULL,
	[leg4_voyage] [nvarchar](max) NULL,
	[tsp4_vslarrival_planned_initial] [nvarchar](max) NULL,
	[tsp4_vslarrival_planned_last] [nvarchar](max) NULL,
	[tsp4_vslarrival_actual] [nvarchar](max) NULL,
	[tsp4_vslarrival_detected] [nvarchar](max) NULL,
	[tsp4_discharge_planned_initial] [nvarchar](max) NULL,
	[tsp4_discharge_planned_last] [nvarchar](max) NULL,
	[tsp4_discharge_actual] [nvarchar](max) NULL,
	[tsp4_loaded_planned_initial] [nvarchar](max) NULL,
	[tsp4_loaded_planned_last] [nvarchar](max) NULL,
	[tsp4_loaded_actual] [nvarchar](max) NULL,
	[tsp4_vsldeparture_planned_initial] [nvarchar](max) NULL,
	[tsp4_vsldeparture_planned_last] [nvarchar](max) NULL,
	[tsp4_vsldeparture_actual] [nvarchar](max) NULL,
	[tsp4_vsldeparture_detected] [nvarchar](max) NULL,
	[leg5_voyage] [nvarchar](max) NULL,
	[pod_vslarrival_planned_initial] [nvarchar](max) NULL,
	[pod_vslarrival_planned_last] [nvarchar](max) NULL,
	[pod_vslarrival_actual] [nvarchar](max) NULL,
	[pod_vslarrival_detected] [nvarchar](max) NULL,
	[pod_discharge_planned_initial] [nvarchar](max) NULL,
	[pod_discharge_planned_last] [nvarchar](max) NULL,
	[pod_discharge_actual] [nvarchar](max) NULL,
	[pod_departure_planned_initial] [nvarchar](max) NULL,
	[pod_departure_planned_last] [nvarchar](max) NULL,
	[pod_departure_actual] [nvarchar](max) NULL,
	[dlv_delivery_planned_initial] [nvarchar](max) NULL,
	[dlv_delivery_planned_last] [nvarchar](max) NULL,
	[dlv_delivery_actual] [nvarchar](max) NULL,
	[empty_return_planned_initial] [nvarchar](max) NULL,
	[empty_return_planned_last] [nvarchar](max) NULL,
	[empty_return_actual] [nvarchar](max) NULL,
	[ts_count] [nvarchar](max) NULL,
	[last_carrier_update] [nvarchar](max) NULL,
	[last_actuals_update] [nvarchar](max) NULL,
	[created] [nvarchar](max) NULL,
	[modified] [nvarchar](max) NULL,
	[shipmentsubscription] [nvarchar](max) NULL,
	[empty_pickup_loc_name] [nvarchar](max) NULL,
	[empty_pickup_loc_locode] [nvarchar](max) NULL,
	[lif_loc_name] [nvarchar](max) NULL,
	[lif_loc_locode] [nvarchar](max) NULL,
	[empty_return_loc_name] [nvarchar](max) NULL,
	[empty_return_loc_locode] [nvarchar](max) NULL,
	[RequestDetailHist_ID] [int] NULL,
 CONSTRAINT [PK_dbo.ContainershipmentDetailHists] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContainershipmentDetails]    Script Date: 09/21/2022 13:17:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContainershipmentDetails](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[refID] [int] NOT NULL,
	[RequestID] [int] NOT NULL,
	[ContainerID] [nvarchar](max) NULL,
	[shipmentsubscription_status_verbose] [nvarchar](max) NULL,
	[shipmentsubscription_status] [nvarchar](max) NULL,
	[shipmentsubscription_on_hold] [nvarchar](max) NULL,
	[shipmentsubscription_id] [nvarchar](max) NULL,
	[status_verbose] [nvarchar](max) NULL,
	[lifecycle_status_verbose] [nvarchar](max) NULL,
	[current_vessel_nextport_eta] [nvarchar](max) NULL,
	[current_vessel_nextport_name] [nvarchar](max) NULL,
	[current_vessel_nextport_locode] [nvarchar](max) NULL,
	[current_vessel_position_latitude] [nvarchar](max) NULL,
	[current_vessel_position_timestamp] [nvarchar](max) NULL,
	[current_vessel_position_heading] [nvarchar](max) NULL,
	[current_vessel_position_longitude] [nvarchar](max) NULL,
	[current_vessel_name] [nvarchar](max) NULL,
	[current_vessel_imo] [nvarchar](max) NULL,
	[current_vessel_id] [nvarchar](max) NULL,
	[tsp4_loc_ShipmentID] [int] NOT NULL,
	[tsp4_loc_name] [nvarchar](max) NULL,
	[tsp4_loc_locode] [nvarchar](max) NULL,
	[tsp3_loc_ShipmentID] [int] NOT NULL,
	[tsp3_loc_name] [nvarchar](max) NULL,
	[tsp3_loc_locode] [nvarchar](max) NULL,
	[tsp2_loc_ShipmentID] [int] NOT NULL,
	[tsp2_loc_name] [nvarchar](max) NULL,
	[tsp2_loc_locode] [nvarchar](max) NULL,
	[tsp1_loc_ShipmentID] [int] NOT NULL,
	[tsp1_loc_name] [nvarchar](max) NULL,
	[tsp1_loc_locode] [nvarchar](max) NULL,
	[leg5_vessel_id] [nvarchar](max) NULL,
	[leg5_vessel_name] [nvarchar](max) NULL,
	[leg5_vessel_imo] [nvarchar](max) NULL,
	[leg4_vessel_id] [nvarchar](max) NULL,
	[leg4_vessel_name] [nvarchar](max) NULL,
	[leg4_vessel_imo] [nvarchar](max) NULL,
	[leg3_vessel_id] [nvarchar](max) NULL,
	[leg3_vessel_name] [nvarchar](max) NULL,
	[leg3_vessel_imo] [nvarchar](max) NULL,
	[leg2_vessel_id] [nvarchar](max) NULL,
	[leg2_vessel_name] [nvarchar](max) NULL,
	[leg2_vessel_imo] [nvarchar](max) NULL,
	[leg1_vessel_id] [nvarchar](max) NULL,
	[leg1_vessel_name] [nvarchar](max) NULL,
	[leg1_vessel_imo] [nvarchar](max) NULL,
	[dlv_loc_name] [nvarchar](max) NULL,
	[dlv_loc_locode] [nvarchar](max) NULL,
	[pod_loc_name] [nvarchar](max) NULL,
	[pod_loc_locode] [nvarchar](max) NULL,
	[pol_loc_name] [nvarchar](max) NULL,
	[pol_loc_locode] [nvarchar](max) NULL,
	[origin_loc_name] [nvarchar](max) NULL,
	[origin_loc_locode] [nvarchar](max) NULL,
	[carrier_name] [nvarchar](max) NULL,
	[carrier_scac] [nvarchar](max) NULL,
	[container_type_iso] [nvarchar](max) NULL,
	[container_type_str] [nvarchar](max) NULL,
	[url] [nvarchar](max) NULL,
	[container_number] [nvarchar](max) NULL,
	[booking_number] [nvarchar](max) NULL,
	[bl_number] [nvarchar](max) NULL,
	[weight] [nvarchar](max) NULL,
	[status] [nvarchar](max) NULL,
	[lifecycle_status] [nvarchar](max) NULL,
	[id_date] [nvarchar](max) NULL,
	[descriptive_name] [nvarchar](max) NULL,
	[empty_pickup_planned_initial] [nvarchar](max) NULL,
	[empty_pickup_planned_last] [nvarchar](max) NULL,
	[empty_pickup_actual] [nvarchar](max) NULL,
	[origin_pickup_planned_initial] [nvarchar](max) NULL,
	[origin_pickup_planned_last] [nvarchar](max) NULL,
	[origin_pickup_actual] [nvarchar](max) NULL,
	[pol_arrival_planned_initial] [nvarchar](max) NULL,
	[pol_arrival_planned_last] [nvarchar](max) NULL,
	[pol_arrival_actual] [nvarchar](max) NULL,
	[pol_loaded_planned_initial] [nvarchar](max) NULL,
	[pol_loaded_planned_last] [nvarchar](max) NULL,
	[pol_loaded_actual] [nvarchar](max) NULL,
	[pol_vsldeparture_planned_initial] [nvarchar](max) NULL,
	[pol_vsldeparture_planned_last] [nvarchar](max) NULL,
	[pol_vsldeparture_actual] [nvarchar](max) NULL,
	[pol_vsldeparture_detected] [nvarchar](max) NULL,
	[leg1_voyage] [nvarchar](max) NULL,
	[tsp1_vslarrival_planned_initial] [nvarchar](max) NULL,
	[tsp1_vslarrival_planned_last] [nvarchar](max) NULL,
	[tsp1_vslarrival_actual] [nvarchar](max) NULL,
	[tsp1_vslarrival_detected] [nvarchar](max) NULL,
	[tsp1_discharge_planned_initial] [nvarchar](max) NULL,
	[tsp1_discharge_planned_last] [nvarchar](max) NULL,
	[tsp1_discharge_actual] [nvarchar](max) NULL,
	[tsp1_loaded_planned_initial] [nvarchar](max) NULL,
	[tsp1_loaded_planned_last] [nvarchar](max) NULL,
	[tsp1_loaded_actual] [nvarchar](max) NULL,
	[tsp1_vsldeparture_planned_initial] [nvarchar](max) NULL,
	[tsp1_vsldeparture_planned_last] [nvarchar](max) NULL,
	[tsp1_vsldeparture_actual] [nvarchar](max) NULL,
	[tsp1_vsldeparture_detected] [nvarchar](max) NULL,
	[leg2_voyage] [nvarchar](max) NULL,
	[tsp2_vslarrival_planned_initial] [nvarchar](max) NULL,
	[tsp2_vslarrival_planned_last] [nvarchar](max) NULL,
	[tsp2_vslarrival_actual] [nvarchar](max) NULL,
	[tsp2_vslarrival_detected] [nvarchar](max) NULL,
	[tsp2_discharge_planned_initial] [nvarchar](max) NULL,
	[tsp2_discharge_planned_last] [nvarchar](max) NULL,
	[tsp2_discharge_actual] [nvarchar](max) NULL,
	[tsp2_loaded_planned_initial] [nvarchar](max) NULL,
	[tsp2_loaded_planned_last] [nvarchar](max) NULL,
	[tsp2_loaded_actual] [nvarchar](max) NULL,
	[tsp2_vsldeparture_planned_initial] [nvarchar](max) NULL,
	[tsp2_vsldeparture_planned_last] [nvarchar](max) NULL,
	[tsp2_vsldeparture_actual] [nvarchar](max) NULL,
	[tsp2_vsldeparture_detected] [nvarchar](max) NULL,
	[leg3_voyage] [nvarchar](max) NULL,
	[tsp3_vslarrival_planned_initial] [nvarchar](max) NULL,
	[tsp3_vslarrival_planned_last] [nvarchar](max) NULL,
	[tsp3_vslarrival_actual] [nvarchar](max) NULL,
	[tsp3_vslarrival_detected] [nvarchar](max) NULL,
	[tsp3_discharge_planned_initial] [nvarchar](max) NULL,
	[tsp3_discharge_planned_last] [nvarchar](max) NULL,
	[tsp3_discharge_actual] [nvarchar](max) NULL,
	[tsp3_loaded_planned_initial] [nvarchar](max) NULL,
	[tsp3_loaded_planned_last] [nvarchar](max) NULL,
	[tsp3_loaded_actual] [nvarchar](max) NULL,
	[tsp3_vsldeparture_planned_initial] [nvarchar](max) NULL,
	[tsp3_vsldeparture_planned_last] [nvarchar](max) NULL,
	[tsp3_vsldeparture_actual] [nvarchar](max) NULL,
	[tsp3_vsldeparture_detected] [nvarchar](max) NULL,
	[leg4_voyage] [nvarchar](max) NULL,
	[tsp4_vslarrival_planned_initial] [nvarchar](max) NULL,
	[tsp4_vslarrival_planned_last] [nvarchar](max) NULL,
	[tsp4_vslarrival_actual] [nvarchar](max) NULL,
	[tsp4_vslarrival_detected] [nvarchar](max) NULL,
	[tsp4_discharge_planned_initial] [nvarchar](max) NULL,
	[tsp4_discharge_planned_last] [nvarchar](max) NULL,
	[tsp4_discharge_actual] [nvarchar](max) NULL,
	[tsp4_loaded_planned_initial] [nvarchar](max) NULL,
	[tsp4_loaded_planned_last] [nvarchar](max) NULL,
	[tsp4_loaded_actual] [nvarchar](max) NULL,
	[tsp4_vsldeparture_planned_initial] [nvarchar](max) NULL,
	[tsp4_vsldeparture_planned_last] [nvarchar](max) NULL,
	[tsp4_vsldeparture_actual] [nvarchar](max) NULL,
	[tsp4_vsldeparture_detected] [nvarchar](max) NULL,
	[leg5_voyage] [nvarchar](max) NULL,
	[pod_vslarrival_planned_initial] [nvarchar](max) NULL,
	[pod_vslarrival_planned_last] [nvarchar](max) NULL,
	[pod_vslarrival_actual] [nvarchar](max) NULL,
	[pod_vslarrival_detected] [nvarchar](max) NULL,
	[pod_discharge_planned_initial] [nvarchar](max) NULL,
	[pod_discharge_planned_last] [nvarchar](max) NULL,
	[pod_discharge_actual] [nvarchar](max) NULL,
	[pod_departure_planned_initial] [nvarchar](max) NULL,
	[pod_departure_planned_last] [nvarchar](max) NULL,
	[pod_departure_actual] [nvarchar](max) NULL,
	[dlv_delivery_planned_initial] [nvarchar](max) NULL,
	[dlv_delivery_planned_last] [nvarchar](max) NULL,
	[dlv_delivery_actual] [nvarchar](max) NULL,
	[empty_return_planned_initial] [nvarchar](max) NULL,
	[empty_return_planned_last] [nvarchar](max) NULL,
	[empty_return_actual] [nvarchar](max) NULL,
	[ts_count] [nvarchar](max) NULL,
	[last_carrier_update] [nvarchar](max) NULL,
	[last_actuals_update] [nvarchar](max) NULL,
	[created] [nvarchar](max) NULL,
	[modified] [nvarchar](max) NULL,
	[shipmentsubscription] [nvarchar](max) NULL,
	[empty_pickup_loc_name] [nvarchar](max) NULL,
	[empty_pickup_loc_locode] [nvarchar](max) NULL,
	[lif_loc_name] [nvarchar](max) NULL,
	[lif_loc_locode] [nvarchar](max) NULL,
	[empty_return_loc_name] [nvarchar](max) NULL,
	[empty_return_loc_locode] [nvarchar](max) NULL,
	[RequestDetail_ID] [int] NULL,
 CONSTRAINT [PK_dbo.ContainershipmentDetails] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContainerTrackings]    Script Date: 09/21/2022 13:17:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContainerTrackings](
	[CID] [bigint] IDENTITY(1,1) NOT NULL,
	[SCAC_Code] [nvarchar](10) NOT NULL,
	[ShippingLineName] [nvarchar](max) NULL,
	[FFAgentName] [nvarchar](max) NULL,
	[VesselName] [nvarchar](max) NULL,
	[BillOfLading] [nvarchar](30) NOT NULL,
	[BookingNumber] [nvarchar](30) NOT NULL,
	[BookingReferenceNumber] [nvarchar](max) NULL,
	[MaterialName] [nvarchar](max) NULL,
	[InvoiceNO] [nvarchar](max) NULL,
	[SOE] [nvarchar](max) NULL,
	[JobRefNumber] [nvarchar](max) NULL,
	[DivisionName] [nvarchar](max) NULL,
	[CompanyName] [nvarchar](max) NULL,
	[ResponseID] [nvarchar](max) NULL,
	[ProcessSend] [bit] NOT NULL,
	[ProcessStatus] [nvarchar](30) NOT NULL,
	[BLStatus] [nvarchar](max) NULL,
	[StatusDate] [datetime] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[ModifiedOn] [datetime] NOT NULL,
 CONSTRAINT [PK_dbo.ContainerTrackings] PRIMARY KEY CLUSTERED 
(
	[CID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetailsInfoes]    Script Date: 09/21/2022 13:17:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetailsInfoes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[transport_mode] [nvarchar](max) NULL,
	[pos_datetime] [nvarchar](max) NULL,
	[longitude] [nvarchar](max) NULL,
	[latitude] [nvarchar](max) NULL,
	[message] [nvarchar](max) NULL,
	[pos_name] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.DetailsInfoes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DivisionMasters]    Script Date: 09/21/2022 13:17:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DivisionMasters](
	[sid] [int] IDENTITY(1,1) NOT NULL,
	[OI_AccountCode] [int] NOT NULL,
	[OI_DivisionName] [nvarchar](max) NULL,
	[OI_DivisionShotCode] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.DivisionMasters] PRIMARY KEY CLUSTERED 
(
	[sid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EventInfoes]    Script Date: 09/21/2022 13:17:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventInfoes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[shipment_id] [nvarchar](max) NULL,
	[shipment] [nvarchar](max) NULL,
	[code] [nvarchar](max) NULL,
	[severity] [nvarchar](max) NULL,
	[walltime] [datetime] NOT NULL,
	[created] [datetime] NOT NULL,
	[detailsInfo_ID] [int] NULL,
 CONSTRAINT [PK_dbo.EventInfoes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EventPushReceivers]    Script Date: 09/21/2022 13:17:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventPushReceivers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[security_token] [nvarchar](max) NULL,
	[generated] [nvarchar](max) NULL,
	[event_class] [nvarchar](max) NULL,
	[eventInfo_id] [int] NULL,
	[shipmentInfo_id] [int] NULL,
 CONSTRAINT [PK_dbo.EventPushReceivers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExceptionDetails]    Script Date: 09/21/2022 13:17:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExceptionDetails](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ExceptionLocation] [nvarchar](max) NULL,
	[ExceptionMessage] [nvarchar](max) NULL,
	[ExceptionTrace] [nvarchar](max) NULL,
	[ExceptionDateTime] [datetime] NOT NULL,
 CONSTRAINT [PK_dbo.ExceptionDetails] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LAShippingMasters]    Script Date: 09/21/2022 13:17:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LAShippingMasters](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[OISCACCode] [nvarchar](max) NULL,
	[ShippingShortCode] [nvarchar](max) NULL,
	[ShippingName] [nvarchar](max) NULL,
	[IsMapped] [int] NOT NULL,
 CONSTRAINT [PK_dbo.LAShippingMasters] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OceanInsightShippingMasters]    Script Date: 09/21/2022 13:17:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OceanInsightShippingMasters](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[shortname] [nvarchar](max) NULL,
	[OfficialName] [nvarchar](max) NULL,
	[SCACCode] [nvarchar](max) NULL,
	[OICODE] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.OceanInsightShippingMasters] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RegisterCompanies]    Script Date: 09/21/2022 13:17:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RegisterCompanies](
	[CompanyID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](150) NOT NULL,
	[PersonInCharge] [nvarchar](50) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[EmailID] [nvarchar](max) NOT NULL,
	[Status] [nvarchar](50) NOT NULL,
	[UserID] [int] NOT NULL,
 CONSTRAINT [PK_dbo.RegisterCompanies] PRIMARY KEY CLUSTERED 
(
	[CompanyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RegisterUser]    Script Date: 09/21/2022 13:17:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RegisterUser](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](30) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[EmailID] [nvarchar](max) NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
 CONSTRAINT [PK_dbo.RegisterUser] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RequestDetailHists]    Script Date: 09/21/2022 13:17:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RequestDetailHists](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HistID] [int] NOT NULL,
	[RequestID] [int] NOT NULL,
	[request_carrier_name] [nvarchar](max) NULL,
	[suspicious_key] [nvarchar](max) NULL,
	[descriptive_name] [nvarchar](max) NULL,
	[status_verbose] [nvarchar](max) NULL,
	[url] [nvarchar](max) NULL,
	[request_type] [nvarchar](max) NULL,
	[request_key] [nvarchar](max) NULL,
	[contractual_eta_pod] [nvarchar](max) NULL,
	[contractual_eta_dlv] [nvarchar](max) NULL,
	[owner_internal_id] [nvarchar](max) NULL,
	[created] [nvarchar](max) NULL,
	[modified] [nvarchar](max) NULL,
	[last_carrier_update] [nvarchar](max) NULL,
	[last_actuals_update] [nvarchar](max) NULL,
	[status] [nvarchar](max) NULL,
	[on_hold] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.RequestDetailHists] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RequestDetails]    Script Date: 09/21/2022 13:17:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RequestDetails](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[RequestID] [int] NOT NULL,
	[request_carrier_name] [nvarchar](max) NULL,
	[suspicious_key] [nvarchar](max) NULL,
	[descriptive_name] [nvarchar](max) NULL,
	[status_verbose] [nvarchar](max) NULL,
	[url] [nvarchar](max) NULL,
	[request_type] [nvarchar](max) NULL,
	[request_key] [nvarchar](max) NULL,
	[contractual_eta_pod] [nvarchar](max) NULL,
	[contractual_eta_dlv] [nvarchar](max) NULL,
	[owner_internal_id] [nvarchar](max) NULL,
	[created] [nvarchar](max) NULL,
	[modified] [nvarchar](max) NULL,
	[last_carrier_update] [nvarchar](max) NULL,
	[last_actuals_update] [nvarchar](max) NULL,
	[status] [nvarchar](max) NULL,
	[on_hold] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.RequestDetails] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShipmentInfoes]    Script Date: 09/21/2022 13:17:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShipmentInfoes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[refID] [int] NOT NULL,
	[RequestID] [int] NOT NULL,
	[ContainerID] [nvarchar](max) NULL,
	[shipmentsubscription_status_verbose] [nvarchar](max) NULL,
	[shipmentsubscription_status] [nvarchar](max) NULL,
	[shipmentsubscription_on_hold] [nvarchar](max) NULL,
	[shipmentsubscription_id] [nvarchar](max) NULL,
	[status_verbose] [nvarchar](max) NULL,
	[lifecycle_status_verbose] [nvarchar](max) NULL,
	[current_vessel_nextport_eta] [nvarchar](max) NULL,
	[current_vessel_nextport_name] [nvarchar](max) NULL,
	[current_vessel_nextport_locode] [nvarchar](max) NULL,
	[current_vessel_position_latitude] [nvarchar](max) NULL,
	[current_vessel_position_timestamp] [nvarchar](max) NULL,
	[current_vessel_position_heading] [nvarchar](max) NULL,
	[current_vessel_position_longitude] [nvarchar](max) NULL,
	[current_vessel_name] [nvarchar](max) NULL,
	[current_vessel_imo] [nvarchar](max) NULL,
	[current_vessel_id] [nvarchar](max) NULL,
	[tsp4_loc_ShipmentID] [int] NOT NULL,
	[tsp4_loc_name] [nvarchar](max) NULL,
	[tsp4_loc_locode] [nvarchar](max) NULL,
	[tsp3_loc_ShipmentID] [int] NOT NULL,
	[tsp3_loc_name] [nvarchar](max) NULL,
	[tsp3_loc_locode] [nvarchar](max) NULL,
	[tsp2_loc_ShipmentID] [int] NOT NULL,
	[tsp2_loc_name] [nvarchar](max) NULL,
	[tsp2_loc_locode] [nvarchar](max) NULL,
	[tsp1_loc_ShipmentID] [int] NOT NULL,
	[tsp1_loc_name] [nvarchar](max) NULL,
	[tsp1_loc_locode] [nvarchar](max) NULL,
	[leg5_vessel_id] [nvarchar](max) NULL,
	[leg5_vessel_name] [nvarchar](max) NULL,
	[leg5_vessel_imo] [nvarchar](max) NULL,
	[leg4_vessel_id] [nvarchar](max) NULL,
	[leg4_vessel_name] [nvarchar](max) NULL,
	[leg4_vessel_imo] [nvarchar](max) NULL,
	[leg3_vessel_id] [nvarchar](max) NULL,
	[leg3_vessel_name] [nvarchar](max) NULL,
	[leg3_vessel_imo] [nvarchar](max) NULL,
	[leg2_vessel_id] [nvarchar](max) NULL,
	[leg2_vessel_name] [nvarchar](max) NULL,
	[leg2_vessel_imo] [nvarchar](max) NULL,
	[leg1_vessel_id] [nvarchar](max) NULL,
	[leg1_vessel_name] [nvarchar](max) NULL,
	[leg1_vessel_imo] [nvarchar](max) NULL,
	[dlv_loc_name] [nvarchar](max) NULL,
	[dlv_loc_locode] [nvarchar](max) NULL,
	[pod_loc_name] [nvarchar](max) NULL,
	[pod_loc_locode] [nvarchar](max) NULL,
	[pol_loc_name] [nvarchar](max) NULL,
	[pol_loc_locode] [nvarchar](max) NULL,
	[origin_loc_name] [nvarchar](max) NULL,
	[origin_loc_locode] [nvarchar](max) NULL,
	[carrier_name] [nvarchar](max) NULL,
	[carrier_scac] [nvarchar](max) NULL,
	[container_type_iso] [nvarchar](max) NULL,
	[container_type_str] [nvarchar](max) NULL,
	[url] [nvarchar](max) NULL,
	[container_number] [nvarchar](max) NULL,
	[booking_number] [nvarchar](max) NULL,
	[bl_number] [nvarchar](max) NULL,
	[weight] [nvarchar](max) NULL,
	[status] [nvarchar](max) NULL,
	[lifecycle_status] [nvarchar](max) NULL,
	[id_date] [nvarchar](max) NULL,
	[descriptive_name] [nvarchar](max) NULL,
	[empty_pickup_planned_initial] [nvarchar](max) NULL,
	[empty_pickup_planned_last] [nvarchar](max) NULL,
	[empty_pickup_actual] [nvarchar](max) NULL,
	[origin_pickup_planned_initial] [nvarchar](max) NULL,
	[origin_pickup_planned_last] [nvarchar](max) NULL,
	[origin_pickup_actual] [nvarchar](max) NULL,
	[pol_arrival_planned_initial] [nvarchar](max) NULL,
	[pol_arrival_planned_last] [nvarchar](max) NULL,
	[pol_arrival_actual] [nvarchar](max) NULL,
	[pol_loaded_planned_initial] [nvarchar](max) NULL,
	[pol_loaded_planned_last] [nvarchar](max) NULL,
	[pol_loaded_actual] [nvarchar](max) NULL,
	[pol_vsldeparture_planned_initial] [nvarchar](max) NULL,
	[pol_vsldeparture_planned_last] [nvarchar](max) NULL,
	[pol_vsldeparture_actual] [nvarchar](max) NULL,
	[pol_vsldeparture_detected] [nvarchar](max) NULL,
	[leg1_voyage] [nvarchar](max) NULL,
	[tsp1_vslarrival_planned_initial] [nvarchar](max) NULL,
	[tsp1_vslarrival_planned_last] [nvarchar](max) NULL,
	[tsp1_vslarrival_actual] [nvarchar](max) NULL,
	[tsp1_vslarrival_detected] [nvarchar](max) NULL,
	[tsp1_discharge_planned_initial] [nvarchar](max) NULL,
	[tsp1_discharge_planned_last] [nvarchar](max) NULL,
	[tsp1_discharge_actual] [nvarchar](max) NULL,
	[tsp1_loaded_planned_initial] [nvarchar](max) NULL,
	[tsp1_loaded_planned_last] [nvarchar](max) NULL,
	[tsp1_loaded_actual] [nvarchar](max) NULL,
	[tsp1_vsldeparture_planned_initial] [nvarchar](max) NULL,
	[tsp1_vsldeparture_planned_last] [nvarchar](max) NULL,
	[tsp1_vsldeparture_actual] [nvarchar](max) NULL,
	[tsp1_vsldeparture_detected] [nvarchar](max) NULL,
	[leg2_voyage] [nvarchar](max) NULL,
	[tsp2_vslarrival_planned_initial] [nvarchar](max) NULL,
	[tsp2_vslarrival_planned_last] [nvarchar](max) NULL,
	[tsp2_vslarrival_actual] [nvarchar](max) NULL,
	[tsp2_vslarrival_detected] [nvarchar](max) NULL,
	[tsp2_discharge_planned_initial] [nvarchar](max) NULL,
	[tsp2_discharge_planned_last] [nvarchar](max) NULL,
	[tsp2_discharge_actual] [nvarchar](max) NULL,
	[tsp2_loaded_planned_initial] [nvarchar](max) NULL,
	[tsp2_loaded_planned_last] [nvarchar](max) NULL,
	[tsp2_loaded_actual] [nvarchar](max) NULL,
	[tsp2_vsldeparture_planned_initial] [nvarchar](max) NULL,
	[tsp2_vsldeparture_planned_last] [nvarchar](max) NULL,
	[tsp2_vsldeparture_actual] [nvarchar](max) NULL,
	[tsp2_vsldeparture_detected] [nvarchar](max) NULL,
	[leg3_voyage] [nvarchar](max) NULL,
	[tsp3_vslarrival_planned_initial] [nvarchar](max) NULL,
	[tsp3_vslarrival_planned_last] [nvarchar](max) NULL,
	[tsp3_vslarrival_actual] [nvarchar](max) NULL,
	[tsp3_vslarrival_detected] [nvarchar](max) NULL,
	[tsp3_discharge_planned_initial] [nvarchar](max) NULL,
	[tsp3_discharge_planned_last] [nvarchar](max) NULL,
	[tsp3_discharge_actual] [nvarchar](max) NULL,
	[tsp3_loaded_planned_initial] [nvarchar](max) NULL,
	[tsp3_loaded_planned_last] [nvarchar](max) NULL,
	[tsp3_loaded_actual] [nvarchar](max) NULL,
	[tsp3_vsldeparture_planned_initial] [nvarchar](max) NULL,
	[tsp3_vsldeparture_planned_last] [nvarchar](max) NULL,
	[tsp3_vsldeparture_actual] [nvarchar](max) NULL,
	[tsp3_vsldeparture_detected] [nvarchar](max) NULL,
	[leg4_voyage] [nvarchar](max) NULL,
	[tsp4_vslarrival_planned_initial] [nvarchar](max) NULL,
	[tsp4_vslarrival_planned_last] [nvarchar](max) NULL,
	[tsp4_vslarrival_actual] [nvarchar](max) NULL,
	[tsp4_vslarrival_detected] [nvarchar](max) NULL,
	[tsp4_discharge_planned_initial] [nvarchar](max) NULL,
	[tsp4_discharge_planned_last] [nvarchar](max) NULL,
	[tsp4_discharge_actual] [nvarchar](max) NULL,
	[tsp4_loaded_planned_initial] [nvarchar](max) NULL,
	[tsp4_loaded_planned_last] [nvarchar](max) NULL,
	[tsp4_loaded_actual] [nvarchar](max) NULL,
	[tsp4_vsldeparture_planned_initial] [nvarchar](max) NULL,
	[tsp4_vsldeparture_planned_last] [nvarchar](max) NULL,
	[tsp4_vsldeparture_actual] [nvarchar](max) NULL,
	[tsp4_vsldeparture_detected] [nvarchar](max) NULL,
	[leg5_voyage] [nvarchar](max) NULL,
	[pod_vslarrival_planned_initial] [nvarchar](max) NULL,
	[pod_vslarrival_planned_last] [nvarchar](max) NULL,
	[pod_vslarrival_actual] [nvarchar](max) NULL,
	[pod_vslarrival_detected] [nvarchar](max) NULL,
	[pod_discharge_planned_initial] [nvarchar](max) NULL,
	[pod_discharge_planned_last] [nvarchar](max) NULL,
	[pod_discharge_actual] [nvarchar](max) NULL,
	[pod_departure_planned_initial] [nvarchar](max) NULL,
	[pod_departure_planned_last] [nvarchar](max) NULL,
	[pod_departure_actual] [nvarchar](max) NULL,
	[dlv_delivery_planned_initial] [nvarchar](max) NULL,
	[dlv_delivery_planned_last] [nvarchar](max) NULL,
	[dlv_delivery_actual] [nvarchar](max) NULL,
	[empty_return_planned_initial] [nvarchar](max) NULL,
	[empty_return_planned_last] [nvarchar](max) NULL,
	[empty_return_actual] [nvarchar](max) NULL,
	[ts_count] [nvarchar](max) NULL,
	[last_carrier_update] [nvarchar](max) NULL,
	[last_actuals_update] [nvarchar](max) NULL,
	[created] [nvarchar](max) NULL,
	[modified] [nvarchar](max) NULL,
	[shipmentsubscription] [nvarchar](max) NULL,
	[empty_pickup_loc_name] [nvarchar](max) NULL,
	[empty_pickup_loc_locode] [nvarchar](max) NULL,
	[lif_loc_name] [nvarchar](max) NULL,
	[lif_loc_locode] [nvarchar](max) NULL,
	[empty_return_loc_name] [nvarchar](max) NULL,
	[empty_return_loc_locode] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.ShipmentInfoes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TokensManagers]    Script Date: 09/21/2022 13:17:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TokensManagers](
	[TokenID] [bigint] IDENTITY(1,1) NOT NULL,
	[TokenKey] [nvarchar](max) NULL,
	[IssuedOn] [datetime] NOT NULL,
	[ExpiredOn] [datetime] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[CompanyID] [int] NOT NULL,
 CONSTRAINT [PK_dbo.TokensManagers] PRIMARY KEY CLUSTERED 
(
	[TokenID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[ContainershipmentDetailHists]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ContainershipmentDetailHists_dbo.RequestDetailHists_RequestDetailHist_ID] FOREIGN KEY([RequestDetailHist_ID])
REFERENCES [dbo].[RequestDetailHists] ([ID])
GO
ALTER TABLE [dbo].[ContainershipmentDetailHists] CHECK CONSTRAINT [FK_dbo.ContainershipmentDetailHists_dbo.RequestDetailHists_RequestDetailHist_ID]
GO
ALTER TABLE [dbo].[ContainershipmentDetails]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ContainershipmentDetails_dbo.RequestDetails_RequestDetail_ID] FOREIGN KEY([RequestDetail_ID])
REFERENCES [dbo].[RequestDetails] ([ID])
GO
ALTER TABLE [dbo].[ContainershipmentDetails] CHECK CONSTRAINT [FK_dbo.ContainershipmentDetails_dbo.RequestDetails_RequestDetail_ID]
GO
ALTER TABLE [dbo].[EventInfoes]  WITH CHECK ADD  CONSTRAINT [FK_dbo.EventInfoes_dbo.DetailsInfoes_detailsInfo_ID] FOREIGN KEY([detailsInfo_ID])
REFERENCES [dbo].[DetailsInfoes] ([ID])
GO
ALTER TABLE [dbo].[EventInfoes] CHECK CONSTRAINT [FK_dbo.EventInfoes_dbo.DetailsInfoes_detailsInfo_ID]
GO
ALTER TABLE [dbo].[EventPushReceivers]  WITH CHECK ADD  CONSTRAINT [FK_dbo.EventPushReceivers_dbo.EventInfoes_eventInfo_id] FOREIGN KEY([eventInfo_id])
REFERENCES [dbo].[EventInfoes] ([id])
GO
ALTER TABLE [dbo].[EventPushReceivers] CHECK CONSTRAINT [FK_dbo.EventPushReceivers_dbo.EventInfoes_eventInfo_id]
GO
ALTER TABLE [dbo].[EventPushReceivers]  WITH CHECK ADD  CONSTRAINT [FK_dbo.EventPushReceivers_dbo.ShipmentInfoes_shipmentInfo_id] FOREIGN KEY([shipmentInfo_id])
REFERENCES [dbo].[ShipmentInfoes] ([id])
GO
ALTER TABLE [dbo].[EventPushReceivers] CHECK CONSTRAINT [FK_dbo.EventPushReceivers_dbo.ShipmentInfoes_shipmentInfo_id]
GO
/****** Object:  StoredProcedure [dbo].[Insert_Shipment_Details]    Script Date: 09/21/2022 13:17:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [dbo].[Insert_Shipment_Details]
@refID int =0,
@RequestID int =0,
@ContainerID nvarchar(max) = null,
@shipmentsubscription_status_verbose nvarchar(max) = null,
@shipmentsubscription_status nvarchar(max) = null,
@shipmentsubscription_on_hold nvarchar(max) = null,
@shipmentsubscription_id nvarchar(max) = null,
@status_verbose nvarchar(max) = null,
@lifecycle_status_verbose nvarchar(max) = null,
@current_vessel_nextport_eta nvarchar(max) = null,
@current_vessel_nextport_name nvarchar(max) = null,
@current_vessel_nextport_locode nvarchar(max) = null,
@current_vessel_position_latitude nvarchar(max) = null,
@current_vessel_position_timestamp nvarchar(max) = null,
@current_vessel_position_heading nvarchar(max) = null,
@current_vessel_position_longitude nvarchar(max) = null,
@current_vessel_name nvarchar(max) = null,
@current_vessel_imo nvarchar(max) = null,
@current_vessel_id nvarchar(max) = null,
@tsp4_loc_ShipmentID int =0,
@tsp4_loc_name nvarchar(max) = null,
@tsp4_loc_locode nvarchar(max) = null,
@tsp3_loc_ShipmentID int =0,
@tsp3_loc_name nvarchar(max) = null,
@tsp3_loc_locode nvarchar(max) = null,
@tsp2_loc_ShipmentID int =0,
@tsp2_loc_name nvarchar(max) = null,
@tsp2_loc_locode nvarchar(max) = null,
@tsp1_loc_ShipmentID int =0,
@tsp1_loc_name nvarchar(max) = null,
@tsp1_loc_locode nvarchar(max) = null,
@leg5_vessel_id nvarchar(max) = null,
@leg5_vessel_name nvarchar(max) = null,
@leg5_vessel_imo nvarchar(max) = null,
@leg4_vessel_id nvarchar(max) = null,
@leg4_vessel_name nvarchar(max) = null,
@leg4_vessel_imo nvarchar(max) = null,
@leg3_vessel_id nvarchar(max) = null,
@leg3_vessel_name nvarchar(max) = null,
@leg3_vessel_imo nvarchar(max) = null,
@leg2_vessel_id nvarchar(max) = null,
@leg2_vessel_name nvarchar(max) = null,
@leg2_vessel_imo nvarchar(max) = null,
@leg1_vessel_id nvarchar(max) = null,
@leg1_vessel_name nvarchar(max) = null,
@leg1_vessel_imo nvarchar(max) = null,
@dlv_loc_name nvarchar(max) = null,
@dlv_loc_locode nvarchar(max) = null,
@pod_loc_name nvarchar(max) = null,
@pod_loc_locode nvarchar(max) = null,
@pol_loc_name nvarchar(max) = null,
@pol_loc_locode nvarchar(max) = null,
@origin_loc_name nvarchar(max) = null,
@origin_loc_locode nvarchar(max) = null,
@carrier_name nvarchar(max) = null,
@carrier_scac nvarchar(max) = null,
@container_type_iso nvarchar(max) = null,
@container_type_str nvarchar(max) = null,
@url nvarchar(max) = null,
@container_number nvarchar(max) = null,
@booking_number nvarchar(max) = null,
@bl_number nvarchar(max) = null,
@weight nvarchar(max) = null,
@status nvarchar(max) = null,
@lifecycle_status nvarchar(max) = null,
@id_date nvarchar(max) = null,
@descriptive_name nvarchar(max) = null,
@empty_pickup_planned_initial nvarchar(max) = null,
@empty_pickup_planned_last nvarchar(max) = null,
@empty_pickup_actual nvarchar(max) = null,
@origin_pickup_planned_initial nvarchar(max) = null,
@origin_pickup_planned_last nvarchar(max) = null,
@origin_pickup_actual nvarchar(max) = null,
@pol_arrival_planned_initial nvarchar(max) = null,
@pol_arrival_planned_last nvarchar(max) = null,
@pol_arrival_actual nvarchar(max) = null,
@pol_loaded_planned_initial nvarchar(max) = null,
@pol_loaded_planned_last nvarchar(max) = null,
@pol_loaded_actual nvarchar(max) = null,
@pol_vsldeparture_planned_initial nvarchar(max) = null,
@pol_vsldeparture_planned_last nvarchar(max) = null,
@pol_vsldeparture_actual nvarchar(max) = null,
@pol_vsldeparture_detected nvarchar(max) = null,
@leg1_voyage nvarchar(max) = null,
@tsp1_vslarrival_planned_initial nvarchar(max) = null,
@tsp1_vslarrival_planned_last nvarchar(max) = null,
@tsp1_vslarrival_actual nvarchar(max) = null,
@tsp1_vslarrival_detected nvarchar(max) = null,
@tsp1_discharge_planned_initial nvarchar(max) = null,
@tsp1_discharge_planned_last nvarchar(max) = null,
@tsp1_discharge_actual nvarchar(max) = null,
@tsp1_loaded_planned_initial nvarchar(max) = null,
@tsp1_loaded_planned_last nvarchar(max) = null,
@tsp1_loaded_actual nvarchar(max) = null,
@tsp1_vsldeparture_planned_initial nvarchar(max) = null,
@tsp1_vsldeparture_planned_last nvarchar(max) = null,
@tsp1_vsldeparture_actual nvarchar(max) = null,
@tsp1_vsldeparture_detected nvarchar(max) = null,
@leg2_voyage nvarchar(max) = null,
@tsp2_vslarrival_planned_initial nvarchar(max) = null,
@tsp2_vslarrival_planned_last nvarchar(max) = null,
@tsp2_vslarrival_actual nvarchar(max) = null,
@tsp2_vslarrival_detected nvarchar(max) = null,
@tsp2_discharge_planned_initial nvarchar(max) = null,
@tsp2_discharge_planned_last nvarchar(max) = null,
@tsp2_discharge_actual nvarchar(max) = null,
@tsp2_loaded_planned_initial nvarchar(max) = null,
@tsp2_loaded_planned_last nvarchar(max) = null,
@tsp2_loaded_actual nvarchar(max) = null,
@tsp2_vsldeparture_planned_initial nvarchar(max) = null,
@tsp2_vsldeparture_planned_last nvarchar(max) = null,
@tsp2_vsldeparture_actual nvarchar(max) = null,
@tsp2_vsldeparture_detected nvarchar(max) = null,
@leg3_voyage nvarchar(max) = null,
@tsp3_vslarrival_planned_initial nvarchar(max) = null,
@tsp3_vslarrival_planned_last nvarchar(max) = null,
@tsp3_vslarrival_actual nvarchar(max) = null,
@tsp3_vslarrival_detected nvarchar(max) = null,
@tsp3_discharge_planned_initial nvarchar(max) = null,
@tsp3_discharge_planned_last nvarchar(max) = null,
@tsp3_discharge_actual nvarchar(max) = null,
@tsp3_loaded_planned_initial nvarchar(max) = null,
@tsp3_loaded_planned_last nvarchar(max) = null,
@tsp3_loaded_actual nvarchar(max) = null,
@tsp3_vsldeparture_planned_initial nvarchar(max) = null,
@tsp3_vsldeparture_planned_last nvarchar(max) = null,
@tsp3_vsldeparture_actual nvarchar(max) = null,
@tsp3_vsldeparture_detected nvarchar(max) = null,
@leg4_voyage nvarchar(max) = null,
@tsp4_vslarrival_planned_initial nvarchar(max) = null,
@tsp4_vslarrival_planned_last nvarchar(max) = null,
@tsp4_vslarrival_actual nvarchar(max) = null,
@tsp4_vslarrival_detected nvarchar(max) = null,
@tsp4_discharge_planned_initial nvarchar(max) = null,
@tsp4_discharge_planned_last nvarchar(max) = null,
@tsp4_discharge_actual nvarchar(max) = null,
@tsp4_loaded_planned_initial nvarchar(max) = null,
@tsp4_loaded_planned_last nvarchar(max) = null,
@tsp4_loaded_actual nvarchar(max) = null,
@tsp4_vsldeparture_planned_initial nvarchar(max) = null,
@tsp4_vsldeparture_planned_last nvarchar(max) = null,
@tsp4_vsldeparture_actual nvarchar(max) = null,
@tsp4_vsldeparture_detected nvarchar(max) = null,
@leg5_voyage nvarchar(max) = null,
@pod_vslarrival_planned_initial nvarchar(max) = null,
@pod_vslarrival_planned_last nvarchar(max) = null,
@pod_vslarrival_actual nvarchar(max) = null,
@pod_vslarrival_detected nvarchar(max) = null,
@pod_discharge_planned_initial nvarchar(max) = null,
@pod_discharge_planned_last nvarchar(max) = null,
@pod_discharge_actual nvarchar(max) = null,
@pod_departure_planned_initial nvarchar(max) = null,
@pod_departure_planned_last nvarchar(max) = null,
@pod_departure_actual nvarchar(max) = null,
@dlv_delivery_planned_initial nvarchar(max) = null,
@dlv_delivery_planned_last nvarchar(max) = null,
@dlv_delivery_actual nvarchar(max) = null,
@empty_return_planned_initial nvarchar(max) = null,
@empty_return_planned_last nvarchar(max) = null,
@empty_return_actual nvarchar(max) = null,
@ts_count nvarchar(max) = null,
@last_carrier_update nvarchar(max) = null,
@last_actuals_update nvarchar(max) = null,
@created nvarchar(max) = null,
@modified nvarchar(max) = null,
@shipmentsubscription nvarchar(max) = null,
@empty_pickup_loc_name nvarchar(max) = null,
@empty_pickup_loc_locode nvarchar(max) = null,
@lif_loc_name nvarchar(max) = null,
@lif_loc_locode nvarchar(max) = null,
@empty_return_loc_name nvarchar(max) = null,
@empty_return_loc_locode nvarchar(max) = null

AS


Begin Try


INSERT INTO [dbo].[ShipmentInfoes]([refID],[RequestID],[ContainerID],[shipmentsubscription_status_verbose],[shipmentsubscription_status],[shipmentsubscription_on_hold],[shipmentsubscription_id],[status_verbose],[lifecycle_status_verbose],[current_vessel_nextport_eta],[current_vessel_nextport_name],[current_vessel_nextport_locode]
           ,[current_vessel_position_latitude],[current_vessel_position_timestamp],[current_vessel_position_heading],[current_vessel_position_longitude],[current_vessel_name],[current_vessel_imo],[current_vessel_id],[tsp4_loc_ShipmentID],[tsp4_loc_name],[tsp4_loc_locode],[tsp3_loc_ShipmentID],[tsp3_loc_name],[tsp3_loc_locode],[tsp2_loc_ShipmentID]
           ,[tsp2_loc_name],[tsp2_loc_locode],[tsp1_loc_ShipmentID],[tsp1_loc_name],[tsp1_loc_locode],[leg5_vessel_id],[leg5_vessel_name],[leg5_vessel_imo],[leg4_vessel_id],[leg4_vessel_name],[leg4_vessel_imo],[leg3_vessel_id],[leg3_vessel_name],[leg3_vessel_imo],[leg2_vessel_id],[leg2_vessel_name],[leg2_vessel_imo],[leg1_vessel_id],[leg1_vessel_name]
           ,[leg1_vessel_imo],[dlv_loc_name],[dlv_loc_locode],[pod_loc_name],[pod_loc_locode],[pol_loc_name],[pol_loc_locode],[origin_loc_name],[origin_loc_locode],[carrier_name],[carrier_scac],[container_type_iso],[container_type_str],[url],[container_number],[booking_number],[bl_number],[weight],[status],[lifecycle_status],[id_date],[descriptive_name]
           ,[empty_pickup_planned_initial],[empty_pickup_planned_last],[empty_pickup_actual],[origin_pickup_planned_initial],[origin_pickup_planned_last],[origin_pickup_actual],[pol_arrival_planned_initial],[pol_arrival_planned_last],[pol_arrival_actual],[pol_loaded_planned_initial],[pol_loaded_planned_last],[pol_loaded_actual],[pol_vsldeparture_planned_initial]
           ,[pol_vsldeparture_planned_last],[pol_vsldeparture_actual],[pol_vsldeparture_detected],[leg1_voyage],[tsp1_vslarrival_planned_initial],[tsp1_vslarrival_planned_last],[tsp1_vslarrival_actual],[tsp1_vslarrival_detected],[tsp1_discharge_planned_initial],[tsp1_discharge_planned_last],[tsp1_discharge_actual],[tsp1_loaded_planned_initial],[tsp1_loaded_planned_last]
           ,[tsp1_loaded_actual],[tsp1_vsldeparture_planned_initial],[tsp1_vsldeparture_planned_last],[tsp1_vsldeparture_actual],[tsp1_vsldeparture_detected],[leg2_voyage],[tsp2_vslarrival_planned_initial],[tsp2_vslarrival_planned_last],[tsp2_vslarrival_actual],[tsp2_vslarrival_detected],[tsp2_discharge_planned_initial],[tsp2_discharge_planned_last],[tsp2_discharge_actual]
           ,[tsp2_loaded_planned_initial],[tsp2_loaded_planned_last],[tsp2_loaded_actual],[tsp2_vsldeparture_planned_initial],[tsp2_vsldeparture_planned_last],[tsp2_vsldeparture_actual],[tsp2_vsldeparture_detected],[leg3_voyage],[tsp3_vslarrival_planned_initial],[tsp3_vslarrival_planned_last],[tsp3_vslarrival_actual],[tsp3_vslarrival_detected],[tsp3_discharge_planned_initial]
           ,[tsp3_discharge_planned_last],[tsp3_discharge_actual],[tsp3_loaded_planned_initial],[tsp3_loaded_planned_last],[tsp3_loaded_actual],[tsp3_vsldeparture_planned_initial],[tsp3_vsldeparture_planned_last],[tsp3_vsldeparture_actual],[tsp3_vsldeparture_detected],[leg4_voyage],[tsp4_vslarrival_planned_initial],[tsp4_vslarrival_planned_last],[tsp4_vslarrival_actual],[tsp4_vslarrival_detected]
           ,[tsp4_discharge_planned_initial],[tsp4_discharge_planned_last],[tsp4_discharge_actual],[tsp4_loaded_planned_initial],[tsp4_loaded_planned_last],[tsp4_loaded_actual],[tsp4_vsldeparture_planned_initial],[tsp4_vsldeparture_planned_last],[tsp4_vsldeparture_actual],[tsp4_vsldeparture_detected],[leg5_voyage],[pod_vslarrival_planned_initial],[pod_vslarrival_planned_last],[pod_vslarrival_actual]
           ,[pod_vslarrival_detected],[pod_discharge_planned_initial],[pod_discharge_planned_last],[pod_discharge_actual],[pod_departure_planned_initial],[pod_departure_planned_last],[pod_departure_actual],[dlv_delivery_planned_initial],[dlv_delivery_planned_last],[dlv_delivery_actual],[empty_return_planned_initial],[empty_return_planned_last],[empty_return_actual],[ts_count],[last_carrier_update]
           ,[last_actuals_update],[created],[modified],[shipmentsubscription],[empty_pickup_loc_name],[empty_pickup_loc_locode],[lif_loc_name],[lif_loc_locode],[empty_return_loc_name],[empty_return_loc_locode])
     VALUES
           (@refID,@RequestID,@ContainerID,@shipmentsubscription_status_verbose,@shipmentsubscription_status,@shipmentsubscription_on_hold,@shipmentsubscription_id,@status_verbose,@lifecycle_status_verbose,@current_vessel_nextport_eta,@current_vessel_nextport_name,@current_vessel_nextport_locode,@current_vessel_position_latitude,@current_vessel_position_timestamp,@current_vessel_position_heading,@current_vessel_position_longitude,
            @current_vessel_name,@current_vessel_imo,@current_vessel_id,@tsp4_loc_ShipmentID,@tsp4_loc_name,@tsp4_loc_locode,@tsp3_loc_ShipmentID,@tsp3_loc_name,@tsp3_loc_locode,@tsp2_loc_ShipmentID,@tsp2_loc_name,@tsp2_loc_locode,@tsp1_loc_ShipmentID,@tsp1_loc_name,@tsp1_loc_locode,@leg5_vessel_id,@leg5_vessel_name,@leg5_vessel_imo,@leg4_vessel_id,@leg4_vessel_name,@leg4_vessel_imo,@leg3_vessel_id,@leg3_vessel_name,@leg3_vessel_imo,@leg2_vessel_id,
            @leg2_vessel_name,@leg2_vessel_imo,@leg1_vessel_id,@leg1_vessel_name,@leg1_vessel_imo,@dlv_loc_name,@dlv_loc_locode,@pod_loc_name,@pod_loc_locode,@pol_loc_name,@pol_loc_locode,@origin_loc_name,@origin_loc_locode,@carrier_name,@carrier_scac,@container_type_iso,@container_type_str,@url,@container_number,@booking_number,@bl_number,@weight,@status,@lifecycle_status,@id_date,@descriptive_name,@empty_pickup_planned_initial,@empty_pickup_planned_last,@empty_pickup_actual,@origin_pickup_planned_initial,
            @origin_pickup_planned_last,@origin_pickup_actual,@pol_arrival_planned_initial,@pol_arrival_planned_last,@pol_arrival_actual,@pol_loaded_planned_initial,@pol_loaded_planned_last,@pol_loaded_actual,@pol_vsldeparture_planned_initial,@pol_vsldeparture_planned_last,@pol_vsldeparture_actual,@pol_vsldeparture_detected,@leg1_voyage,@tsp1_vslarrival_planned_initial,@tsp1_vslarrival_planned_last,@tsp1_vslarrival_actual,@tsp1_vslarrival_detected,@tsp1_discharge_planned_initial,
            @tsp1_discharge_planned_last,@tsp1_discharge_actual,@tsp1_loaded_planned_initial,@tsp1_loaded_planned_last,@tsp1_loaded_actual,@tsp1_vsldeparture_planned_initial,@tsp1_vsldeparture_planned_last,@tsp1_vsldeparture_actual,@tsp1_vsldeparture_detected,@leg2_voyage,@tsp2_vslarrival_planned_initial,@tsp2_vslarrival_planned_last,@tsp2_vslarrival_actual,@tsp2_vslarrival_detected,@tsp2_discharge_planned_initial,@tsp2_discharge_planned_last,@tsp2_discharge_actual,@tsp2_loaded_planned_initial,@tsp2_loaded_planned_last,
            @tsp2_loaded_actual,@tsp2_vsldeparture_planned_initial,@tsp2_vsldeparture_planned_last,@tsp2_vsldeparture_actual,@tsp2_vsldeparture_detected,@leg3_voyage,@tsp3_vslarrival_planned_initial,@tsp3_vslarrival_planned_last,@tsp3_vslarrival_actual,@tsp3_vslarrival_detected,@tsp3_discharge_planned_initial,@tsp3_discharge_planned_last,@tsp3_discharge_actual,@tsp3_loaded_planned_initial,@tsp3_loaded_planned_last,@tsp3_loaded_actual,@tsp3_vsldeparture_planned_initial,
            @tsp3_vsldeparture_planned_last,@tsp3_vsldeparture_actual,@tsp3_vsldeparture_detected,@leg4_voyage,@tsp4_vslarrival_planned_initial,@tsp4_vslarrival_planned_last,@tsp4_vslarrival_actual,@tsp4_vslarrival_detected,@tsp4_discharge_planned_initial,@tsp4_discharge_planned_last,@tsp4_discharge_actual,@tsp4_loaded_planned_initial,@tsp4_loaded_planned_last,@tsp4_loaded_actual,@tsp4_vsldeparture_planned_initial,@tsp4_vsldeparture_planned_last,@tsp4_vsldeparture_actual,@tsp4_vsldeparture_detected,@leg5_voyage,
            @pod_vslarrival_planned_initial,@pod_vslarrival_planned_last,@pod_vslarrival_actual,@pod_vslarrival_detected,@pod_discharge_planned_initial,@pod_discharge_planned_last,@pod_discharge_actual,@pod_departure_planned_initial,@pod_departure_planned_last,@pod_departure_actual,@dlv_delivery_planned_initial,@dlv_delivery_planned_last,@dlv_delivery_actual,@empty_return_planned_initial,@empty_return_planned_last,@empty_return_actual,@ts_count,@last_carrier_update,@last_actuals_update,@created,@modified,@shipmentsubscription,
            @empty_pickup_loc_name,@empty_pickup_loc_locode,@lif_loc_name,@lif_loc_locode,@empty_return_loc_name,@empty_return_loc_locode)

END Try
Begin Catch
	Declare @ErrorLine as varchar(50)
	Declare @ErrorMessage as varchar(50)
	SELECT  @ErrorLine= ERROR_LINE() , @ErrorMessage =ERROR_MESSAGE(); 
	Insert into [dbo].[ExceptionDetails] (ID,ExceptionLocation,ExceptionMessage,ExceptionTrace,ExceptionDateTime) values (0,'Insert Shippment StoreProcedure',@ErrorMessage,@ErrorLine,GETDATE())
End Catch

GO
