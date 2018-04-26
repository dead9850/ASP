using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ASP.Areas.HomeWork1.Models
{
    public class OrderSearchArg
    {
        [DisplayName("訂單編號")]
        public string OrderID { get; set; }
        [DisplayName("客戶名稱")]
        public string CustomerName { get; set; }
        [DisplayName("負責員工")]
        public string EmployeeName { get; set; }
        [DisplayName("出貨公司")]
        public string CompanyName { get; set; }
        [DisplayName("訂購日期")]
        public string RequiredDate { get; set; }
        [DisplayName("出貨日期")]
        public string ShippedDate { get; set; }
        [DisplayName("需要日期")]
        public string OrderDate { get; set; }
    }
}