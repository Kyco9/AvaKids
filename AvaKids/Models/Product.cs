using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaKids.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public decimal PriceOld { get; set; }
        public string Image { get; set; }
        public string Trademark { get; set; }
        public string Type { get; set; }
        public byte Age { get; set; }
        public string Material { get; set; }
        public string BoxSize { get; set; }
        public float Weight { get; set; }
        public string Note { get; set; }
        public string Manufacturing { get; set; }


    }
    

    public class LegoCity
    {
        public Product ProductMain { get; set; }
        public List<Product> ProductsList { get; set; }

        public LegoCity()
        {
            ProductMain = new Product() {
                ProductID = 258122,
                ProductName = "Đồ chơi trạm cảnh sát tuần tra và cứu hỏa biển Lego City 60308 (297 chi tiết)",
                Price = 993200,
                PriceOld = 1399000,
                Image = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-6.jpg",

                Trademark = "Lego (Đan Mạch)",
                Type = "Đồ chơi bé trai Đồ chơi lắp ráp",
                Age = 5,
                Material = "Nhựa",
                BoxSize = "38x26x6 cm",
                Weight = 724,
                Note = "Có các chi tiết nhỏ; không dùng cho trẻ dưới 3 tuổi; tránh nguy cơ tiềm ẩn khi trẻ sử dụng sai",
                Manufacturing = "Trung Quốc"
            };

            ProductsList = new List<Product>()
            {
                new Product
                {
                    ProductName="Đồ chơi xe địa hình cứu hộ Lego City 60301 (157 chi tiết)",
                    Price = 993200,
                    PriceOld = 1399000,
                    Image = "do-choi-xe-dia-hinh-cuu-ho-lego-city-60301-201121-124424-600x600.jpg",

                    Trademark = "Lego (Đan Mạch)",
                    Type = "Đồ chơi bé trai Đồ chơi lắp ráp",
                    Age = 5,
                    Material = "Nhựa",
                    BoxSize = "38x26x6 cm",
                    Weight = 724,
                    Note = "Có các chi tiết nhỏ; không dùng cho trẻ dưới 3 tuổi; tránh nguy cơ tiềm ẩn khi trẻ sử dụng sai",
                    Manufacturing = "Trung Quốc"
                },
                new Product
                {
                    ProductName="Đồ chơi trạm rửa xe thông minh Hot Wheels FTB66",
                    Price = 998200,
                    PriceOld = 1349000,
                    Image = "do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-181121-105405-600x600.jpg"


                },
                new Product
                {
                    ProductName="Đồ chơi thùng gạch sáng tạo Lego Duplo 10913 (65 chi tiết)",
                    Price = 1002400,
                    PriceOld = 1319000,
                    Image = "do-choi-thung-gach-duplo-sang-tao-lego-duplo-10913-070322-100629-600x600.jpg"
                },
                new Product
                {
                    ProductName="Đồ chơi phi cơ chiến đấu của Cole Lego Ninjago 71736 (449 chi tiết)",
                    Price = 1000200,
                    PriceOld = 1299000,
                    Image = "do-choi-phi-co-chien-dau-cua-cole-lego-ninjago-71736-070322-111209-600x600.jpg"
                },
                new Product
                {
                    ProductName="Đồ chơi tàu chiến hạm bay Bounty Lego Ninjago 71749 (147 chi tiết)",
                    Price = 1039200,
                    PriceOld = 1269000,
                    Image = "do-choi-tau-chien-ham-bay-bounty-lego-ninjago-71749-070322-110850-600x600.jpg"
                },
                new Product
                {
                    ProductName="Đồ chơi cắm trại ngoài trời Lego Friends 41392LG (241 chi tiết)",
                    Price = 1002500,
                    PriceOld = 1269000,
                    Image = "do-choi-cam-trai-ngoai-troi-lego-friends-41392lg-130322-112928-600x600.jpg"
                }
            };
        }

    }

    //#region other product
    //public class OtherProduct
    //{

    //    public string oProductName { get; set; }
    //    public decimal oPrice { get; set; }
    //    public decimal oPriceOld { get; set; }
    //    public string oImage { get; set; }


    //    public OtherProduct()
    //    {
    //        var otherpd = new List<OtherProduct>
    //        {
    //            new OtherProduct
    //            {
    //                oProductName="Đồ chơi xe địa hình cứu hộ Lego City 60301 (157 chi tiết)",
    //                oPrice = 993200,
    //                oPriceOld = 1399000,
    //                oImage = "do-choi-xe-dia-hinh-cuu-ho-lego-city-60301-201121-124424-600x600.jpg"
    //            },
    //            new OtherProduct
    //            {
    //                oProductName="Đồ chơi trạm rửa xe thông minh Hot Wheels FTB66",
    //                oPrice = 998200,
    //                oPriceOld = 1349000,
    //                oImage = "do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-181121-105405-600x600.jpg"
    //            },
    //            new OtherProduct
    //            {
    //                oProductName="Đồ chơi thùng gạch sáng tạo Lego Duplo 10913 (65 chi tiết)",
    //                oPrice = 1002400,
    //                oPriceOld = 1319000,
    //                oImage = "do-choi-thung-gach-duplo-sang-tao-lego-duplo-10913-070322-100629-600x600.jpg"
    //            },
    //            new OtherProduct
    //            {
    //                oProductName="Đồ chơi phi cơ chiến đấu của Cole Lego Ninjago 71736 (449 chi tiết)",
    //                oPrice = 1000200,
    //                oPriceOld = 1299000,
    //                oImage = "do-choi-phi-co-chien-dau-cua-cole-lego-ninjago-71736-070322-111209-600x600.jpg"
    //            },
    //            new OtherProduct
    //            {
    //                oProductName="Đồ chơi tàu chiến hạm bay Bounty Lego Ninjago 71749 (147 chi tiết)",
    //                oPrice = 1039200,
    //                oPriceOld = 1269000,
    //                oImage = "do-choi-tau-chien-ham-bay-bounty-lego-ninjago-71749-070322-110850-600x600.jpg"
    //            },
    //            new OtherProduct
    //            {
    //                oProductName="Đồ chơi cắm trại ngoài trời Lego Friends 41392LG (241 chi tiết)",
    //                oPrice = 1002500,
    //                oPriceOld = 1269000,
    //                oImage = "do-choi-cam-trai-ngoai-troi-lego-friends-41392lg-130322-112928-600x600.jpg"
    //            }
    //        };
    //    }
    //}
    //#endregion
}
