using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ASP.Areas.HomeWork1.Models
{
    public class Order
    {
        [DisplayName("訂單編號")]
        public int OrderID { get; set; }
        [DisplayName("客戶編號")]
        public int CustomerID { get; set; }
        [DisplayName("員工編號")]
        public int EmployeeID { get; set; }

        /// <summary>
        /// To Fix Datetime
        /// </summary>
        [DisplayName("訂購日期")]
        public string OrderDate { get; set; }
        [DisplayName("需要日期")]
        public string RequiredDate { get; set; }
        [DisplayName("發貨日期")]
        public string ShippedDate { get; set; }

        [DisplayName("出貨編號")]
        public int ShipperID { get; set; }
        [DisplayName("運費")]
        public Decimal Freight { get; set; }
        [DisplayName("出貨地址")]
        public string ShipAddress { get; set; }
        [DisplayName("出貨城市")]
        public string ShipCity { get; set; }
        [DisplayName("出貨地區")]
        public string ShipRegion { get; set; }
        [DisplayName("郵遞區號")]
        public string ShipPostalCode { get; set; }
        [DisplayName("出貨國家")]
        public string ShipCountry { get; set; }

    }
}