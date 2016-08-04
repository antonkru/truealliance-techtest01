using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechTest01.Services;
using TechTest01.Services.Catalog;

namespace TechTest01.Web.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(IProductService productService, ILogManager logManager) : base(productService, logManager)
        {
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}