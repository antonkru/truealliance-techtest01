using System.Web;
using System.Web.Mvc;

using TechTest01.Web.Filters;

namespace TechTest01.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new LoggingFilterAttribute());
            filters.Add(new HandleErrorAttribute());
           
        }
    }
}