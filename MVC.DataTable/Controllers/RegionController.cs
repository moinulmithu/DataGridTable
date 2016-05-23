using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.DataTable.Models;



namespace MVC.DataTable.Controllers
{
    public class RegionController : Controller
    {
        Repository.Repository objRepository = new Repository.Repository();
        // GET: Region
        public ActionResult Index()
        {
            List<Region> regions = objRepository.GetRegions();
            ViewBag.Region = regions;
            List<Product> products = objRepository.GetProducts();
            ViewBag.Products = products;
            List<Category> categories = objRepository.GetCategories();
            ViewBag.Category = categories;
            return View();
        }

        public JsonResult GetProductByCategory(int categoryId)
        {
            var product = objRepository.GetProductByCategory(categoryId);
            //ViewBag.Products = product;
            return Json(product.Select(x => new { Id = x.ProductID, Name = x.ProductName}), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetProductDetails(int? categoryId, int? productId)
        {
            var productDetails = objRepository.ProductDetail(categoryId, productId);
            return Json(productDetails, JsonRequestBehavior.AllowGet);
        }

        // GET: Region/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Region/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Region/Create
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

        // GET: Region/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Region/Edit/5
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

        // GET: Region/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Region/Delete/5
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
