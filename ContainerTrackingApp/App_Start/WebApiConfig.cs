using AutoMapper;
using ContainerTrackingApp.DTO;
using ContainerTrackingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ContainerTrackingApp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            Mapper.Initialize(configMapp => {
                configMapp.CreateMap<dtoRequestDetails, RequestDetail>().ReverseMap();
                configMapp.CreateMap<dtoEventPushReceiver, EventPushReceiver>().ReverseMap();
                configMapp.CreateMap<dtoContainershipments, ContainershipmentDetails>().IgnoreAllPropertiesWithAnInaccessibleSetter();
                configMapp.CreateMap<dtoLocationInfo, LocationInfo>().ReverseMap();
                configMapp.CreateMap<dtoVesselInfo, VesselInfo>().ReverseMap();
                configMapp.CreateMap<dtoVesselnextport, Vesselnextport>().ReverseMap();
                configMapp.CreateMap<dtoVesselPosition, VesselPosition>().ReverseMap();
                configMapp.CreateMap<RequestDetail, RequestDetailHist>().ReverseMap().IgnoreAllPropertiesWithAnInaccessibleSetter();
                configMapp.CreateMap<ContainershipmentDetails, ContainershipmentDetailHist>().IgnoreAllPropertiesWithAnInaccessibleSetter();

                configMapp.CreateMap<dtoEventInfo, EventInfo>().ReverseMap();
                configMapp.CreateMap<dtoShipmentInfo, ShipmentInfo>().ReverseMap();
                configMapp.CreateMap<dtoDetailsInfo, DetailsInfo>().ReverseMap();
            });

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
