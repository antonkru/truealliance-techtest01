using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechTest01.Services;

namespace TechTest01.Web.Filters
{
    public class LoggingFilterAttribute : ActionFilterAttribute
    {
        
        ILogManager _logger; 

        public LoggingFilterAttribute()
        {
            _logger = new Logger();
        }


        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (_logger.IsDebugEnabled)
            {
                _logger.LogDebug(string.Format("Controller Called ({0})", filterContext.HttpContext.Request.Url));
            }

            if (filterContext.Exception != null && _logger.IsErrorEnabled)
            {
                _logger.LogError(string.Format("Controller Error ({0})", filterContext.HttpContext.Request.Url), filterContext.Exception);
            }

            
        }
    }
}