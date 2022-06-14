using AvaKids.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaKids.ViewComponents
{
    public class MainProductViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            var allProduct = new ListAllProduct();
            int j = 0;
            #region old loop
            //while (true)
            //{
            //    if (i >= 7)
            //    {
            //        break;
            //    }
            //    else if (allProduct.AllProduct[i].ProductID == id)
            //    {
            //        return View(allProduct.AllProduct[i]);
            //    }
            //    i++;
            //}
            #endregion
            for (int i = 0; i <= allProduct.AllProduct.Count();i++)
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

    public class ProductTitleViewComponent : ViewComponent
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

    public class ProductInfoViewComponent : ViewComponent
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

    public class ProductInfoArticleViewComponent : ViewComponent
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

    public class HighlightsViewComponent : ViewComponent
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
    public class ManualsViewComponent : ViewComponent
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
