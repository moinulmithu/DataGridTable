using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.DataTable.Models;

namespace MVC.DataTable.Controllers
{
    public class OrderController : Controller
    {
        DropdownVM viewModel = new DropdownVM();
        NORTHWNDEntities db = new NORTHWNDEntities();
        // GET: Order
        public ActionResult Index()
        {
            ViewBag.Order = new SelectList(db.Orders, "CustomerID", "CustomerID");
            return View();
        }

        public ActionResult LoadOrders(string custId)
        {
            var orderList = db.Orders.Where(x => x.CustomerID == custId).ToList();
            return PartialView(orderList);
        }
        //public JsonResult LoadOrders(string custId)
        //{
        //    var orderList = db.Orders.Where(x => x.CustomerID == custId).ToList();
        //    //return PartialView(orderList);
        //    return Json(orderList, JsonRequestBehavior.AllowGet);
        //}
        // GET: Order/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Order/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Order/Create
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

        // GET: Order/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Order/Edit/5
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

        // GET: Order/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Order/Delete/5
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
