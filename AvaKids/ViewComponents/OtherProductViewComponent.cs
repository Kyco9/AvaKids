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
            int j = 0;
            for (int i = 0; i <= allProduct.AllProduct.Count(); i++)
            {
                if (allProduct.AllProduct[i].ProductID == id)
                {
                    j = i;
                    break;
                }
            }
            return View(allProduct.AllProduct[j]);
        }
    }
}
