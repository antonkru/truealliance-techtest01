using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TechTest01.Web.Controllers
{
    public class ErrorController : Controller
    {
        public ViewResult Index()
        {
            return View("ErrorDetails");
        }

        //public ViewResult NotFound()
        //{
        //    Response.StatusCode = 404;  
        //    return View("NotFound");
        //}
    }
}