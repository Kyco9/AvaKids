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



        public Product() {
            ProductID = 258122;
            ProductName = "Đồ chơi trạm cảnh sát tuần tra và cứu hỏa biển Lego City 60308 (297 chi tiết)";
            Price = 993200;
            PriceOld = 1399000;
            Image = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-6.jpg";

            Trademark = "Lego (Đan Mạch)";
            Type = "Đồ chơi bé trai Đồ chơi lắp ráp";
            Age = 5;
            Material = "Nhựa";
            BoxSize = "38x26x6 cm";
            Weight = 724;
            Note = "Có các chi tiết nhỏ; không dùng cho trẻ dưới 3 tuổi; tránh nguy cơ tiềm ẩn khi trẻ sử dụng sai";
            Manufacturing = "Trung Quốc";
          }

        
    } 
}
