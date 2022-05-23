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
            var otherpd = new List<OtherProduct>
            {
                new OtherProduct
                {
                    oProductName="Đồ chơi xe địa hình cứu hộ Lego City 60301 (157 chi tiết)",
                    oPrice = 993200,
                    oPriceOld = 1399000,
                    oImage = "do-choi-xe-dia-hinh-cuu-ho-lego-city-60301-201121-124424-600x600.jpg"
                },
                new OtherProduct
                {
                    oProductName="Đồ chơi trạm rửa xe thông minh Hot Wheels FTB66",
                    oPrice = 998200,
                    oPriceOld = 1349000,
                    oImage = "do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-181121-105405-600x600.jpg"
                },
                new OtherProduct
                {
                    oProductName="Đồ chơi thùng gạch sáng tạo Lego Duplo 10913 (65 chi tiết)",
                    oPrice = 1002400,
                    oPriceOld = 1319000,
                    oImage = "do-choi-thung-gach-duplo-sang-tao-lego-duplo-10913-070322-100629-600x600.jpg"
                },
                new OtherProduct
                {
                    oProductName="Đồ chơi phi cơ chiến đấu của Cole Lego Ninjago 71736 (449 chi tiết)",
                    oPrice = 1000200,
                    oPriceOld = 1299000,
                    oImage = "do-choi-phi-co-chien-dau-cua-cole-lego-ninjago-71736-070322-111209-600x600.jpg"
                },
                new OtherProduct
                {
                    oProductName="Đồ chơi tàu chiến hạm bay Bounty Lego Ninjago 71749 (147 chi tiết)",
                    oPrice = 1039200,
                    oPriceOld = 1269000,
                    oImage = "do-choi-tau-chien-ham-bay-bounty-lego-ninjago-71749-070322-110850-600x600.jpg"
                },
                new OtherProduct
                {
                    oProductName="Đồ chơi cắm trại ngoài trời Lego Friends 41392LG (241 chi tiết)",
                    oPrice = 1002500,
                    oPriceOld = 1269000,
                    oImage = "do-choi-cam-trai-ngoai-troi-lego-friends-41392lg-130322-112928-600x600.jpg"
                }
            };


            ViewBag.OtherProduct = otherpd;
            var product = new Product();
            return View(product);
        }

        public class OtherProduct
        {

            public string oProductName { get; set; }
            public decimal oPrice { get; set; }
            public decimal oPriceOld { get; set; }
            public string oImage { get; set; }
        }



    }
}
