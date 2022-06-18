using AvaKids.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AvaKids.Controllers
{
    public class DoChoiController : Controller
    {
        private object productsSearched;

        public IActionResult DoChoiLego()
        {
            var pageModel = new PageModel();
            return View(pageModel);
        }

        public IActionResult SanPham(int pid = 1)
        {
            var a = new ListAllProduct();
            if (pid > a.AllProduct.Count() || pid <= 0)
            {
                return View("/Views/Shared/Error.cshtml");
            }
            else
            {
                ViewBag.Pid = pid;
                return View();
            }
        }

        public JsonResult Search(string searchText)
        {
            var SearchProduct = new ListAllProduct();
            object SearchedProduct = from sp in SearchProduct.AllProduct
                                     select sp;
            string value = string.Empty;
            value = JsonConvert.SerializeObject(SearchProduct, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            return Json(value);


            //var products = new ListAllProduct().AllProduct;
            //productsSearched = from product in products
            //                   where product.ProductName.StartsWith(searchText)
            //                   || product.ProductName.EndsWith(searchText)
            //                   || product.ProductName.Contains(searchText)
            //                   select product;
            //string value = string.Empty;
            //value = JsonConvert.SerializeObject(productsSearched, Formatting.Indented, new JsonSerializerSettings
            //{
            //    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            //});

            //return Json(value);
        }
    }
}
