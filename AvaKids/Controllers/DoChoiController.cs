using AvaKids.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaKids.Controllers
{
    public class DoChoiController : Controller
    {
        public IActionResult DoChoiLego()
        {
            var pageModel = new PageModel();
            return View(pageModel);
        }

        public IActionResult SanPham(int pid = 1)
        {
            var allProduct = new ListAllProduct();
            
            int i = 0;
            while (true)
            {
                if (i>=7)
                {
                    return Content("Không có sản phẩm nào có id = " + pid);
                }
                else if (allProduct.AllProduct[i].ProductID == pid)
                {
                    return View(allProduct.AllProduct[i]);
                }
                i++;
            }
            //ViewBag.ID += 1;
            
        }
    }
}
