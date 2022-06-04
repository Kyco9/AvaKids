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

    public class ProductTitleViewComponent : ViewComponent
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

    public class ProductInfoViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            var allProduct = new ListAllProduct();
            int i = 0;
            while (true)
            {
                if (i >= 7)
                {
                    //return Content("Không có sản phẩm nào có id = " + id);
                    return View("~/Views/Shared/Error.cshtml");
                }
                else if (allProduct.AllProduct[i].ProductID == id)
                {
                    return View(allProduct.AllProduct[i]);
                }
                i++;
            }
        }
    }

    public class ProductInfoArticleViewComponent : ViewComponent
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

    public class HighlightsViewComponent : ViewComponent
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
    public class ManualsViewComponent : ViewComponent
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
