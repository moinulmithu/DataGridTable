using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.DataTable.Models;

namespace MVC.DataTable.Repository
{
    public class Repository
    {
        NORTHWNDEntities db = new NORTHWNDEntities();

        public List<Region> GetRegions()
        {
            var region = db.Regions.ToList();
            return region;
        }

        public List<Product> GetProducts()
        {
            var products = db.Products.ToList();
            return products;
        }

        public List<Product> GetProductByCategory(int categoryId)
        {
            var product = db.Products.Where(x => x.CategoryID == categoryId).ToList();
            return product;
        } 
        public List<Category> GetCategories()
        {
            var categories = db.Categories.ToList();
            return categories;
        }

        public List<Product> ProductDetail(int? categoryId, int? productId)
        {
            //var detail = db.Products.Select(x => new {Name = x.ProductName, Price = x.UnitPrice })
           var details = db.Products.AsEnumerable()
                    .Select(
                        x =>
                            new Product()
                            {
                                ProductID = x.ProductID,
                                ProductName = x.ProductName,
                                UnitPrice = x.UnitPrice,
                                CategoryID = x.CategoryID,
                                Category = new Category() { CategoryID = x.Category.CategoryID, Description = x.Category.Description }
                            }).Where(x => x.ProductID == productId || x.CategoryID == categoryId)
                    .ToList();
            return details;
        } 
    }
}