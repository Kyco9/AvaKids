using AvaKids.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaKids.ViewComponents
{
    public class CommentViewComponent:ViewComponent
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
