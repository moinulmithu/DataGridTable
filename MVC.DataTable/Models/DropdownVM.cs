using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.DataTable.Models
{
    public class DropdownVM
    {
        public List<Customer> Customers { get; set; }
        public string CustomerName { get; set; }
    }
}