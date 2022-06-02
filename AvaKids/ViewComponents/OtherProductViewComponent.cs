using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AvaKids.Controllers;
using AvaKids.Models;

namespace AvaKids.ViewComponents
{
    public class OtherProductViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            var allProduct = new ListAllProduct();
            int i = 0;
            while (true)
            {
                if (i >= 7)
                {
                    return Content("Không có sản phẩm nào có id = " + id);
                }
                else if (allProduct.AllProduct[i].ProductID == id)
                {
                    return View(allProduct.AllProduct[i]);
                }
                i++;
            }
        }
    }
}
