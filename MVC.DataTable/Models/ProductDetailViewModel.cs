using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.DataTable.Models
{
    public class ProductDetailViewModel
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string ProductName { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
    }
}