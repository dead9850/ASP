using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.Areas.HomeWork1.Models
{
    public class OrderService
    {
        public static List<Models.OrderSearchArg> result { get; set; }
        public static List<Models.Order> order_data { get; set; }
        public OrderService()
        {
            if (result==null) { 
                result = new List<OrderSearchArg>();
                result.Add(new OrderSearchArg() { EmployeeName = "員工1", CompanyName = "公司1" });
                result.Add(new OrderSearchArg() { EmployeeName = "員工2", CompanyName = "公司2" });

                order_data = new List<Order>();
                order_data.Add(new Models.Order()
                {
                    OrderID = 1,
                    CustomerID = 1,
                    EmployeeID = 1,
                    OrderDate = "1111/12/31",
                    RequiredDate = "1111/12/31",
                    ShippedDate = "1111/12/31",
                    ShipperID = 1,
                    Freight = 30,
                    ShipAddress = "高雄市大社區116號2F",
                    ShipCity = "高雄市",
                    ShipRegion = "大社區",
                    ShipPostalCode = "35169",
                    ShipCountry = "Taiwan"
                });
                order_data.Add(new Models.Order()
                {
                    OrderID = 2,
                    CustomerID = 2,
                    EmployeeID = 2,
                    OrderDate = "1999/12/31",
                    RequiredDate = "1999/12/31",
                    ShippedDate = "1999/12/31",
                    ShipperID = 2,
                    Freight = 30,
                    ShipAddress = "台北市燕巢區116號2F",
                    ShipCity = "台北市",
                    ShipRegion = "燕巢區",
                    ShipPostalCode = "35169",
                    ShipCountry = "Taiwan"
                });
            }
        }

        public List<Models.OrderSearchArg> GetSearchData()
        {
            return result;
        }

        public List<Models.Order> GetOrderData()
        {
            return order_data;
        }

    }
}