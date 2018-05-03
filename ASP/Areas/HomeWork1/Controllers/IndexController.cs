using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ASP.Areas.HomeWork1.Controllers
{
    public class IndexController : Controller
    {
        // GET: HomeWork1/Index
        public ActionResult Index()
        {
            string connStr = GetConnStr();
            SqlConnection conn = new SqlConnection(connStr);
            string sql = @"Select * From [HR].[Employees]
                           Select * From [Sales].[Customers]
                           Select * From [Sales].[Customers] Inner Join [Sales].[Orders] ON [Sales].[Customers].CustomerID = [Sales].[Orders].CustomerID
                           Inner Join [HR].[Employees] ON [Sales].[Orders].EmployeeID = [HR].[Employees].EmployeeID";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);

            Models.OrderService orderService = new Models.OrderService();
            var SearchData = orderService.GetSearchData();
            var OrderData = orderService.GetOrderData();
            ViewBag.SearchData = SearchData;
            ViewBag.OrderData = OrderData;

            return View(ds);
        }

        [HttpGet()]
        public ActionResult InsertOrder()
        {
            Models.Order result = new Models.Order();
            return View(result);
        }

        private string GetConnStr()
        {
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            return connectionString;
        }

    }
}