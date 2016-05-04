using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.DataTable.Models;

namespace MVC.DataTable.Controllers
{
    public class CustomerController : Controller
    {
        NORTHWNDEntities db = new NORTHWNDEntities();
        // GET: Customer
        public ActionResult Index(CustomerSearchModel customerSearchModel)
        {
            var result = db.Customers.AsQueryable();
            if (customerSearchModel != null)
            {
                if (!string.IsNullOrEmpty(customerSearchModel.CustomerID))
                {
                    result = result.Where(x => x.CustomerID.Contains(customerSearchModel.CustomerID));
                }
                else if (!string.IsNullOrEmpty(customerSearchModel.ContactName))
                {
                    result = result.Where(x => x.ContactName.Contains(customerSearchModel.ContactName));
                }
                else if (!string.IsNullOrEmpty(customerSearchModel.City))
                {
                    result = result.Where(x => x.City.Contains(customerSearchModel.City));
                }
                else if (!string.IsNullOrEmpty(customerSearchModel.Country))
                {
                    result = result.Where(x => x.Country.Contains(customerSearchModel.Country));
                }
                else
                {
                    result.ToList();
                }
            }
            return View(result);
        }

        public IQueryable<Customer> GetCustomers(CustomerSearchModel customerSearchModel)
        {
            var result = db.Customers.AsQueryable();
            if (customerSearchModel != null)
            {
                if (!string.IsNullOrEmpty(customerSearchModel.CustomerID))
                {
                    result = result.Where(x => x.CustomerID.Contains(customerSearchModel.CustomerID));
                }
                if (!string.IsNullOrEmpty(customerSearchModel.ContactName))
                {
                    result = result.Where(x => x.ContactName.Contains(customerSearchModel.ContactName));
                }
                if (!string.IsNullOrEmpty(customerSearchModel.City))
                {
                    result = result.Where(x => x.City.Contains(customerSearchModel.City));
                }
                if (!string.IsNullOrEmpty(customerSearchModel.Country))
                {
                    result = result.Where(x => x.Country.Contains(customerSearchModel.Country));
                }
            }
            return result;
        } 
        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
