using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.Areas.HomeWork1.Controllers
{
    public class IndexController : Controller
    {
        // GET: HomeWork1/Index
        public ActionResult Index()
        {
            
            Models.OrderService orderService = new Models.OrderService();
            var SearchData = orderService.GetSearchData();
            var OrderData = orderService.GetOrderData();
            ViewBag.SearchData = SearchData;
            ViewBag.OrderData = OrderData;

            return View();
        }

        [HttpGet()]
        public ActionResult InsertOrder()
        {
            Models.Order result = new Models.Order();
            return View(result);
        }

    }
}