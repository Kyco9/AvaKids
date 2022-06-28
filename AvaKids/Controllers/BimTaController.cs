using AvaKids.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaKids.Controllers
{
    public class BimTaController : Controller
    {
        public IActionResult DanhSachBimTa(Query qr)
        {
            qr.Filtered = FilterLinQ(qr.TrademarkQR, qr.PriceForm, qr.WeightQR);

            var data = FilterLinQ(qr.TrademarkQR, qr.PriceForm, qr.WeightQR);

            qr.PageSize = 12;
            var count = data.Count();
            qr.PageMax = (count / qr.PageSize) - (count % qr.PageSize == 0 ? 1 : 0);

            ViewBag.PageMax = qr.PageMax;
            ViewBag.Page = qr.Page;

            qr.Filtered = data.Skip(qr.Page * qr.PageSize).Take(qr.PageSize).ToList();
            qr.CountSP = data.Count();
            return View(qr);
        }


        //[HttpGet]
        //public IActionResult DanhSachBimTa(Query qr)
        //{
        //    var bimta = new ListBimTa().BimTa;
        //    ViewBag.TongSoLuong = bimta.Count();

        //    IEnumerable<Product> query = new ListBimTa().BimTa;
        //    if (qr.TrademarkQR != null)
        //    {
        //        query = query.Where(x => x.Trademark == qr.TrademarkQR);
        //    }
        //    if (qr.PriceForm != -1)
        //    {
        //        if (qr.PriceForm == 1)
        //        {
        //            query = query.Where(x => x.Price >= 100000 && x.Price <= 200000);
        //        }
        //        if (qr.PriceForm == 2)
        //        {
        //            query = query.Where(x => x.Price > 200000 && x.Price <= 300000);
        //        }
        //    }
        //    if (qr.TypeQR != null)
        //    {
        //        query = query.Where(x => x.TypeDiapers == qr.TypeQR);
        //    }
        //    if (qr.WeightQR != null)
        //    {
        //        query = query.Where(x => x.WeighDiapers == qr.WeightQR);
        //    }
        //    if (qr.SizeQR != null)
        //    {
        //        query = query.Where(x => x.Size == qr.SizeQR);
        //    }

        //    List<Product> Filtered = query.ToList();
        //    ViewBag.SoLuongFilter = Filtered.Count();

        //    return View(Filtered);
        //}

        //[HttpPost]
        //public JsonResult DanhSachBimTaJSON(Query qr)
        //{
        //    IEnumerable<Product> query = new ListBimTa().BimTa;
        //    if (qr.TrademarkQR != null)
        //    {
        //        query = query.Where(x => x.Trademark == qr.TrademarkQR);
        //    }
        //    if (qr.PriceForm != -1)
        //    {
        //        if (qr.PriceForm == 1)
        //        {
        //            query = query.Where(x => x.Price >= 100000 && x.Price <= 200000);
        //        }
        //        if (qr.PriceForm == 2)
        //        {
        //            query = query.Where(x => x.Price > 200000 && x.Price <= 300000);
        //        }
        //    }
        //    if (qr.TypeQR != null)
        //    {
        //        query = query.Where(x => x.TypeDiapers == qr.TypeQR);
        //    }
        //    if (qr.WeightQR != null)
        //    {
        //        query = query.Where(x => x.WeighDiapers == qr.WeightQR);
        //    }
        //    if (qr.SizeQR != null)
        //    {
        //        query = query.Where(x => x.Size == qr.SizeQR);
        //    }

        //    object productsSearched = query;

        //    string value = string.Empty;
        //    value = JsonConvert.SerializeObject(productsSearched, Formatting.Indented, new JsonSerializerSettings
        //    {
        //        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
        //    });
        //    return Json(value);
        //}

        //[HttpGet]
        //[Route("DanhSachBimTa/FilteredTest")]
        //public ActionResult FilteredTest(string trademark, decimal price, string type, string weight, string size)
        //{

        //    price = -1;
        //    type = null;
        //    weight = null;
        //    size = null;

        //    IEnumerable<Product> query = new ListBimTa().BimTa;

        //    if (trademark != null)
        //    {
        //        query = query.Where(x => x.Trademark == trademark);
        //    }
        //    if (price != -1)
        //    {
        //        if (price == 1)
        //        {
        //            query = query.Where(x => x.Price >= 100000 && x.Price <= 200000);
        //        }
        //        if (price == 2)
        //        {
        //            query = query.Where(x => x.Price > 200000 && x.Price <= 300000);
        //        }
        //    }
        //    if (type != null)
        //    {
        //        query = query.Where(x => x.TypeDiapers == type);
        //    }
        //    if (weight != null)
        //    {
        //        query = query.Where(x => x.WeighDiapers == weight);
        //    }
        //    if (size != null)
        //    {
        //        query = query.Where(x => x.Size == size);
        //    }

        //    List<Product> Filtered = query.ToList();

        //    return PartialView("FilteredTest", Filtered);
        //}



        private List<Product> FilterLinQ(string t, string p, string w)
        {

            IEnumerable<Product> query = new ListBimTa().BimTa;

            if (t != null)
            {
                query = query.Where(x => x.Trademark == t);
            }
            if (p != "-1")
            {
                if (p == "1")
                {
                    query = query.Where(x => x.Price >= 100000 && x.Price <= 200000);
                }
                if (p == "2")
                {
                    query = query.Where(x => x.Price > 200000 && x.Price <= 300000);
                }
            }
            if (w != null)
            {
                query = query.Where(x => x.WeighDiapers == w);
            }
            return query.ToList(); ;
        }

        public IActionResult FilteredTestQR()
        {
            var qr = new Query();

            return PartialView(qr);
        }

        [HttpPost]
        public IActionResult FilteredTestQR([FromBody] Query qr)
        {
            //int count = Filtered.Count();
            //qr.PageSize = 12;
            //var data = Filtered.Skip(qr.Page * qr.PageSize).Take(qr.PageSize).ToList();
            //this.ViewBag.MaxPage = (count / qr.PageSize) - (count % qr.PageSize == 0 ? 1 : 0);
            //this.ViewBag.Page = qr.Page;
            //double pageCount = (double)((decimal)Filtered.Count() / Convert.ToDecimal(qr.PageSize));
            //qr.PageCount = (int)Math.Ceiling(pageCount);
            //qr.PageCur = qr.Page;


            var data = FilterLinQ(qr.TrademarkQR, qr.PriceForm, qr.WeightQR);

            qr.PageSize = 12;
            var count = data.Count();
            qr.PageMax = (count / qr.PageSize) - (count % qr.PageSize == 0 ? 1 : 0);
            

            qr.Filtered = data.Skip(qr.Page * qr.PageSize).Take(qr.PageSize).ToList();
            return PartialView("FilteredTestQR", qr);
        }

        

    }


}
