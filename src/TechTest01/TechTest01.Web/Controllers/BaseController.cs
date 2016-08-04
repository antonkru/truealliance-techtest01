using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechTest01.Services;
using TechTest01.Services.Catalog;

namespace TechTest01.Web.Controllers
{
    public abstract class BaseController : Controller
    {
        public BaseController(IProductService productService, ILogManager logManager)
        {
            ProductService = productService;
            LogManager = logManager;
        }

        public IProductService ProductService { get; private set; }

        public ILogManager LogManager { get; private set; }
    }
}
