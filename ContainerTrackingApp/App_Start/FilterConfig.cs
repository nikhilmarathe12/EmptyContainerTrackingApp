using ContainerTrackingApp.Filter;
using System.Web;
using System.Web.Mvc;

namespace ContainerTrackingApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new CustomExceptionFilterAttribute());
        }
    }
}
