using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaKids.Models
{
    public class TypeList
    {
        public string dd { get; set; }
    }

    public class ThumbnailList
    {
        public string thumb { get; set; }
    }

    public class Highlight
    {
        public string highlight { get; set; }
    }

    public class Manual
    {
        public string manual { get; set; }
    }

    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public decimal PriceOld { get; set; }
        public string Image { get; set; }
        public string Trademark { get; set; }
        public List<TypeList> Type { get; set; }
        public double Age { get; set; }
        public string Material { get; set; }
        public string BoxSize { get; set; }
        public float Weight { get; set; }
        public string Note { get; set; }
        public string Manufacturing { get; set; }
        public List<ThumbnailList> ThumbnailProduct { get; set; }
        public List<Product> OtherProductList { get; set; }

        public List<Highlight> Highlights { get; set; }
        public List<Manual> Manuals { get; set; }


        public string TypeDiapers { get; set; }
        public string WeighDiapers { get; set; }
        public string Size { get; set; }

    }


    public class ListBimTa
    {
        public List<Product> BimTa { get; set; }

        public ListBimTa()
        {
            BimTa = new List<Product>()
            {
                //Bobby
                new Product
                {
                    ProductID = 1,
                    ProductName="Tã quần Bobby size M 76 miếng (6 - 11 kg)",
                    Price = 343400,
                    PriceOld = 404000,
                    Image = "/img/BimTa/bobby/1.jpg",
                    Trademark = "Bobby",
                    TypeDiapers = "Miếng lót sơ sinh",
                    WeighDiapers = "Dưới 5kg",
                    Size = "NB"
                },
                new Product
                {
                    ProductID = 2,
                    ProductName="Tã quần Bobby size XL 62 miếng (12 - 17 kg)",
                    Price = 243400,
                    PriceOld = 304000,
                    Image = "/img/BimTa/bobby/2.jpg",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5kg - 10kg",Size = "S"
                },
                new Product
                {
                    ProductID = 3,
                    ProductName="Tã quần Bobby size L 68 miếng (9 - 13 kg)",
                    Price = 143400,
                    PriceOld = 204000,
                    Image = "/img/BimTa/bobby/3.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 4,
                    ProductName="Tã quần Bobby size XXL 56 miếng (15 - 25 kg)",
                    Price = 323100,
                    PriceOld = 359000,
                    Image = "/img/BimTa/bobby/4.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 5,
                    ProductName="Tã quần Bobby Extra Soft-Dry size L 52 miếng (9 - 13 kg)",
                    Price = 291500,
                    PriceOld = 304000,
                    Image = "/img/BimTa/bobby/5.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 6,
                    ProductName="Tã quần Bobby Extra Soft-Dry size XXL 42 miếng (Trên 16 kg)",
                    Price = 2915000,
                    PriceOld = 434000,
                    Image = "/img/BimTa/bobby/6.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 7,
                    ProductName="Tã quần Bobby Extra Soft-Dry size M 60 miếng (6 - 11 kg)",
                    Price = 291500,
                    PriceOld = 343000,
                    Image = "/img/BimTa/bobby/7.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 8,
                    ProductName="Tã dán Bobby siêu mỏng size XXL 56 miếng (Trên 16 kg)",
                    Price = 289000,
                    PriceOld = 340000,
                    Image = "/img/BimTa/bobby/8.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 9,
                    ProductName="Tã quần Bobby size M 76 miếng (6 - 11 kg)",
                    Price = 278000,
                    PriceOld = 504000,
                    Image = "/img/BimTa/bobby/9.jpg",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 10,
                    ProductName="Tã quần Bobby Extra Soft-Dry size XL 46 miếng (12 - 17 kg)",
                    Price = 274400,
                    PriceOld = 344000,
                    Image = "/img/BimTa/bobby/10.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 11,
                    ProductName="Tã quần Bobby size M 76 miếng (6 - 11 kg)",
                    Price = 278000,
                    PriceOld = 504000,
                    Image = "/img/BimTa/bobby/9.jpg",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 12,
                    ProductName="Tã quần Bobby Extra Soft-Dry size XL 46 miếng (12 - 17 kg)",
                    Price = 274400,
                    PriceOld = 344000,
                    Image = "/img/BimTa/bobby/10.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 1,
                    ProductName="Sản phẩm đầu tiên page 1",
                    Price = 343400,
                    PriceOld = 404000,
                    Image = "/img/BimTa/bobby/1.jpg",
                    Trademark = "Bobby",
                    TypeDiapers = "Miếng lót sơ sinh",
                    WeighDiapers = "Dưới 5kg",
                    Size = "NB"
                },
                new Product
                {
                    ProductID = 2,
                    ProductName="Tã quần Bobby size XL 62 miếng (12 - 17 kg)",
                    Price = 243400,
                    PriceOld = 304000,
                    Image = "/img/BimTa/bobby/2.jpg",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5kg - 10kg",Size = "S"
                },
                new Product
                {
                    ProductID = 3,
                    ProductName="Tã quần Bobby size L 68 miếng (9 - 13 kg)",
                    Price = 143400,
                    PriceOld = 204000,
                    Image = "/img/BimTa/bobby/3.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 4,
                    ProductName="Tã quần Bobby size XXL 56 miếng (15 - 25 kg)",
                    Price = 323100,
                    PriceOld = 359000,
                    Image = "/img/BimTa/bobby/4.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 5,
                    ProductName="Tã quần Bobby Extra Soft-Dry size L 52 miếng (9 - 13 kg)",
                    Price = 291500,
                    PriceOld = 304000,
                    Image = "/img/BimTa/bobby/5.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 6,
                    ProductName="Tã quần Bobby Extra Soft-Dry size XXL 42 miếng (Trên 16 kg)",
                    Price = 2915000,
                    PriceOld = 434000,
                    Image = "/img/BimTa/bobby/6.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 7,
                    ProductName="Tã quần Bobby Extra Soft-Dry size M 60 miếng (6 - 11 kg)",
                    Price = 291500,
                    PriceOld = 343000,
                    Image = "/img/BimTa/bobby/7.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 8,
                    ProductName="Tã dán Bobby siêu mỏng size XXL 56 miếng (Trên 16 kg)",
                    Price = 289000,
                    PriceOld = 340000,
                    Image = "/img/BimTa/bobby/8.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 9,
                    ProductName="Tã quần Bobby size M 76 miếng (6 - 11 kg)",
                    Price = 278000,
                    PriceOld = 504000,
                    Image = "/img/BimTa/bobby/9.jpg",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 10,
                    ProductName="Tã quần Bobby Extra Soft-Dry size XL 46 miếng (12 - 17 kg)",
                    Price = 274400,
                    PriceOld = 344000,
                    Image = "/img/BimTa/bobby/10.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 11,
                    ProductName="Tã quần Bobby size M 76 miếng (6 - 11 kg)",
                    Price = 278000,
                    PriceOld = 504000,
                    Image = "/img/BimTa/bobby/9.jpg",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 12,
                    ProductName="Tã quần Bobby Extra Soft-Dry size XL 46 miếng (12 - 17 kg)",
                    Price = 274400,
                    PriceOld = 344000,
                    Image = "/img/BimTa/bobby/10.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },

                //Huggies
                new Product
                {
                    ProductID = 11,
                    ProductName="Tã quần Huggies Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 342400,
                    PriceOld = 380000,
                    Image = "/img/BimTa/huggies/11.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 12,
                    ProductName="Tã quần Huggies Dry size XXL 56 miếng (Trên 15 kg)",
                    Price = 342400,
                    PriceOld = 380000,
                    Image = "/img/BimTa/huggies/12.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 13,
                    ProductName="Tã quần Huggies Dry size L",
                    Price = 442400,
                    PriceOld = 580000,
                    Image = "/img/BimTa/huggies/13.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 14,
                    ProductName="Tã quần Huggies Platinum nature made siêu cao cấp size L 44 miếng (9 - 14 kg)",
                    Price = 337500,
                    PriceOld = 375000,
                    Image = "/img/BimTa/huggies/14.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 15,
                    ProductName="Tã dán Huggies Platinum nature made siêu cao cấp size L 54 miếng (9 - 14 kg)",
                    Price = 618000,
                    PriceOld = 780000,
                    Image = "/img/BimTa/huggies/15.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 16,
                    ProductName="Tã dán Huggies Platinum nature made siêu cao cấp size NB 60 miếng (Dưới 5 kg)",
                    Price = 189900,
                    PriceOld = 211000,
                    Image = "/img/BimTa/huggies/16.jpg",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 17,
                    ProductName="Tã lót Huggies size NB2 60 miếng (4 - 7 kg)",
                    Price = 94300,
                    PriceOld = 111000,
                    Image = "/img/BimTa/huggies/17.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 18,
                    ProductName="Tã dán Huggies Dry size S 56 miếng (4 - 8 kg)",
                    Price = 242400,
                    PriceOld = 380000,
                    Image = "/img/BimTa/huggies/18.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 19,
                    ProductName="Tã quần Huggies Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 842400,
                    PriceOld = 980000,
                    Image = "/img/BimTa/huggies/19.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 20,
                    ProductName="Tã quần Huggies Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 1042400,
                    PriceOld = 1180000,
                    Image = "/img/BimTa/huggies/20.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 11,
                    ProductName="Tã quần Huggies Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 342400,
                    PriceOld = 380000,
                    Image = "/img/BimTa/huggies/11.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 12,
                    ProductName="Tã quần Huggies Dry size XXL 56 miếng (Trên 15 kg)",
                    Price = 342400,
                    PriceOld = 380000,
                    Image = "/img/BimTa/huggies/12.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 13,
                    ProductName="Tã quần Huggies Dry size L",
                    Price = 442400,
                    PriceOld = 580000,
                    Image = "/img/BimTa/huggies/13.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 14,
                    ProductName="Tã quần Huggies Platinum nature made siêu cao cấp size L 44 miếng (9 - 14 kg)",
                    Price = 337500,
                    PriceOld = 375000,
                    Image = "/img/BimTa/huggies/14.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 15,
                    ProductName="Tã dán Huggies Platinum nature made siêu cao cấp size L 54 miếng (9 - 14 kg)",
                    Price = 618000,
                    PriceOld = 780000,
                    Image = "/img/BimTa/huggies/15.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 16,
                    ProductName="Tã dán Huggies Platinum nature made siêu cao cấp size NB 60 miếng (Dưới 5 kg)",
                    Price = 189900,
                    PriceOld = 211000,
                    Image = "/img/BimTa/huggies/16.jpg",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 17,
                    ProductName="Tã lót Huggies size NB2 60 miếng (4 - 7 kg)",
                    Price = 94300,
                    PriceOld = 111000,
                    Image = "/img/BimTa/huggies/17.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 18,
                    ProductName="Tã dán Huggies Dry size S 56 miếng (4 - 8 kg)",
                    Price = 242400,
                    PriceOld = 380000,
                    Image = "/img/BimTa/huggies/18.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 19,
                    ProductName="Tã quần Huggies Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 842400,
                    PriceOld = 980000,
                    Image = "/img/BimTa/huggies/19.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 20,
                    ProductName="Tã quần Huggies Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 1042400,
                    PriceOld = 1180000,
                    Image = "/img/BimTa/huggies/20.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },

                //moony
                new Product
                {
                    ProductID = 21,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 378000,
                    PriceOld = 445000,
                    Image = "/img/BimTa/moony/21.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 22,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 578000,
                    PriceOld = 645000,
                    Image = "/img/BimTa/moony/22.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 23,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 778000,
                    PriceOld = 845000,
                    Image = "/img/BimTa/moony/23.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 24,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 978000,
                    PriceOld = 999000,
                    Image = "/img/BimTa/moony/24.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 25,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 278000,
                    PriceOld = 345000,
                    Image = "/img/BimTa/moony/25.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 26,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 878000,
                    PriceOld = 945000,
                    Image = "/img/BimTa/moony/26.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 27,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 778000,
                    PriceOld = 945000,
                    Image = "/img/BimTa/moony/27.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 28,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 278000,
                    PriceOld = 545000,
                    Image = "/img/BimTa/moony/28.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 29,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 178000,
                    PriceOld = 195000,
                    Image = "/img/BimTa/moony/29.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 30,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 1878000,
                    PriceOld = 1445000,
                    Image = "/img/BimTa/moony/30.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 21,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 378000,
                    PriceOld = 445000,
                    Image = "/img/BimTa/moony/21.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 22,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 578000,
                    PriceOld = 645000,
                    Image = "/img/BimTa/moony/22.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 23,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 778000,
                    PriceOld = 845000,
                    Image = "/img/BimTa/moony/23.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 24,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 978000,
                    PriceOld = 999000,
                    Image = "/img/BimTa/moony/24.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 25,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 278000,
                    PriceOld = 345000,
                    Image = "/img/BimTa/moony/25.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 26,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 878000,
                    PriceOld = 945000,
                    Image = "/img/BimTa/moony/26.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 27,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 778000,
                    PriceOld = 945000,
                    Image = "/img/BimTa/moony/27.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 28,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 278000,
                    PriceOld = 545000,
                    Image = "/img/BimTa/moony/28.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 29,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 178000,
                    PriceOld = 195000,
                    Image = "/img/BimTa/moony/29.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 30,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 1878000,
                    PriceOld = 1445000,
                    Image = "/img/BimTa/moony/30.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 29,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 178000,
                    PriceOld = 195000,
                    Image = "/img/BimTa/moony/29.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 30,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 1878000,
                    PriceOld = 1445000,
                    Image = "/img/BimTa/moony/30.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },

                //Bobby
                new Product
                {
                    ProductID = 1,
                    ProductName="Tã quần Bobby size M 76 miếng (6 - 11 kg)",
                    Price = 343400,
                    PriceOld = 404000,
                    Image = "/img/BimTa/bobby/1.jpg",
                    Trademark = "Bobby",
                    TypeDiapers = "Miếng lót sơ sinh",
                    WeighDiapers = "Dưới 5kg",
                    Size = "NB"
                },
                new Product
                {
                    ProductID = 2,
                    ProductName="Tã quần Bobby size XL 62 miếng (12 - 17 kg)",
                    Price = 243400,
                    PriceOld = 304000,
                    Image = "/img/BimTa/bobby/2.jpg",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5kg - 10kg",Size = "S"
                },
                new Product
                {
                    ProductID = 3,
                    ProductName="Tã quần Bobby size L 68 miếng (9 - 13 kg)",
                    Price = 143400,
                    PriceOld = 204000,
                    Image = "/img/BimTa/bobby/3.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 4,
                    ProductName="Tã quần Bobby size XXL 56 miếng (15 - 25 kg)",
                    Price = 323100,
                    PriceOld = 359000,
                    Image = "/img/BimTa/bobby/4.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 5,
                    ProductName="Tã quần Bobby Extra Soft-Dry size L 52 miếng (9 - 13 kg)",
                    Price = 291500,
                    PriceOld = 304000,
                    Image = "/img/BimTa/bobby/5.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 6,
                    ProductName="Tã quần Bobby Extra Soft-Dry size XXL 42 miếng (Trên 16 kg)",
                    Price = 2915000,
                    PriceOld = 434000,
                    Image = "/img/BimTa/bobby/6.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 7,
                    ProductName="Tã quần Bobby Extra Soft-Dry size M 60 miếng (6 - 11 kg)",
                    Price = 291500,
                    PriceOld = 343000,
                    Image = "/img/BimTa/bobby/7.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 8,
                    ProductName="Tã dán Bobby siêu mỏng size XXL 56 miếng (Trên 16 kg)",
                    Price = 289000,
                    PriceOld = 340000,
                    Image = "/img/BimTa/bobby/8.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 9,
                    ProductName="Tã quần Bobby size M 76 miếng (6 - 11 kg)",
                    Price = 278000,
                    PriceOld = 504000,
                    Image = "/img/BimTa/bobby/9.jpg",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 10,
                    ProductName="Tã quần Bobby Extra Soft-Dry size XL 46 miếng (12 - 17 kg)",
                    Price = 274400,
                    PriceOld = 344000,
                    Image = "/img/BimTa/bobby/10.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 11,
                    ProductName="Tã quần Bobby size M 76 miếng (6 - 11 kg)",
                    Price = 278000,
                    PriceOld = 504000,
                    Image = "/img/BimTa/bobby/9.jpg",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 12,
                    ProductName="Tã quần Bobby Extra Soft-Dry size XL 46 miếng (12 - 17 kg)",
                    Price = 274400,
                    PriceOld = 344000,
                    Image = "/img/BimTa/bobby/10.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 1,
                    ProductName="Tã quần Bobby size M 76 miếng (6 - 11 kg)",
                    Price = 343400,
                    PriceOld = 404000,
                    Image = "/img/BimTa/bobby/1.jpg",
                    Trademark = "Bobby",
                    TypeDiapers = "Miếng lót sơ sinh",
                    WeighDiapers = "Dưới 5kg",
                    Size = "NB"
                },
                new Product
                {
                    ProductID = 2,
                    ProductName="Tã quần Bobby size XL 62 miếng (12 - 17 kg)",
                    Price = 243400,
                    PriceOld = 304000,
                    Image = "/img/BimTa/bobby/2.jpg",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5kg - 10kg",Size = "S"
                },
                new Product
                {
                    ProductID = 3,
                    ProductName="Tã quần Bobby size L 68 miếng (9 - 13 kg)",
                    Price = 143400,
                    PriceOld = 204000,
                    Image = "/img/BimTa/bobby/3.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 4,
                    ProductName="Tã quần Bobby size XXL 56 miếng (15 - 25 kg)",
                    Price = 323100,
                    PriceOld = 359000,
                    Image = "/img/BimTa/bobby/4.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 5,
                    ProductName="Tã quần Bobby Extra Soft-Dry size L 52 miếng (9 - 13 kg)",
                    Price = 291500,
                    PriceOld = 304000,
                    Image = "/img/BimTa/bobby/5.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 6,
                    ProductName="Tã quần Bobby Extra Soft-Dry size XXL 42 miếng (Trên 16 kg)",
                    Price = 2915000,
                    PriceOld = 434000,
                    Image = "/img/BimTa/bobby/6.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 7,
                    ProductName="Tã quần Bobby Extra Soft-Dry size M 60 miếng (6 - 11 kg)",
                    Price = 291500,
                    PriceOld = 343000,
                    Image = "/img/BimTa/bobby/7.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 8,
                    ProductName="Tã dán Bobby siêu mỏng size XXL 56 miếng (Trên 16 kg)",
                    Price = 289000,
                    PriceOld = 340000,
                    Image = "/img/BimTa/bobby/8.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 9,
                    ProductName="Tã quần Bobby size M 76 miếng (6 - 11 kg)",
                    Price = 278000,
                    PriceOld = 504000,
                    Image = "/img/BimTa/bobby/9.jpg",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 10,
                    ProductName="Tã quần Bobby Extra Soft-Dry size XL 46 miếng (12 - 17 kg)",
                    Price = 274400,
                    PriceOld = 344000,
                    Image = "/img/BimTa/bobby/10.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 11,
                    ProductName="Tã quần Bobby size M 76 miếng (6 - 11 kg)",
                    Price = 278000,
                    PriceOld = 504000,
                    Image = "/img/BimTa/bobby/9.jpg",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 12,
                    ProductName="Tã quần Bobby Extra Soft-Dry size XL 46 miếng (12 - 17 kg)",
                    Price = 274400,
                    PriceOld = 344000,
                    Image = "/img/BimTa/bobby/10.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },

                //Huggies
                new Product
                {
                    ProductID = 11,
                    ProductName="Tã quần Huggies Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 342400,
                    PriceOld = 380000,
                    Image = "/img/BimTa/huggies/11.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 12,
                    ProductName="Tã quần Huggies Dry size XXL 56 miếng (Trên 15 kg)",
                    Price = 342400,
                    PriceOld = 380000,
                    Image = "/img/BimTa/huggies/12.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 13,
                    ProductName="Tã quần Huggies Dry size L",
                    Price = 442400,
                    PriceOld = 580000,
                    Image = "/img/BimTa/huggies/13.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 14,
                    ProductName="Tã quần Huggies Platinum nature made siêu cao cấp size L 44 miếng (9 - 14 kg)",
                    Price = 337500,
                    PriceOld = 375000,
                    Image = "/img/BimTa/huggies/14.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 15,
                    ProductName="Tã dán Huggies Platinum nature made siêu cao cấp size L 54 miếng (9 - 14 kg)",
                    Price = 618000,
                    PriceOld = 780000,
                    Image = "/img/BimTa/huggies/15.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 16,
                    ProductName="Tã dán Huggies Platinum nature made siêu cao cấp size NB 60 miếng (Dưới 5 kg)",
                    Price = 189900,
                    PriceOld = 211000,
                    Image = "/img/BimTa/huggies/16.jpg",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 17,
                    ProductName="Tã lót Huggies size NB2 60 miếng (4 - 7 kg)",
                    Price = 94300,
                    PriceOld = 111000,
                    Image = "/img/BimTa/huggies/17.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 18,
                    ProductName="Tã dán Huggies Dry size S 56 miếng (4 - 8 kg)",
                    Price = 242400,
                    PriceOld = 380000,
                    Image = "/img/BimTa/huggies/18.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 19,
                    ProductName="Tã quần Huggies Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 842400,
                    PriceOld = 980000,
                    Image = "/img/BimTa/huggies/19.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 20,
                    ProductName="Tã quần Huggies Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 1042400,
                    PriceOld = 1180000,
                    Image = "/img/BimTa/huggies/20.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 11,
                    ProductName="Tã quần Huggies Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 342400,
                    PriceOld = 380000,
                    Image = "/img/BimTa/huggies/11.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 12,
                    ProductName="Tã quần Huggies Dry size XXL 56 miếng (Trên 15 kg)",
                    Price = 342400,
                    PriceOld = 380000,
                    Image = "/img/BimTa/huggies/12.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 13,
                    ProductName="Tã quần Huggies Dry size L",
                    Price = 442400,
                    PriceOld = 580000,
                    Image = "/img/BimTa/huggies/13.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 14,
                    ProductName="Tã quần Huggies Platinum nature made siêu cao cấp size L 44 miếng (9 - 14 kg)",
                    Price = 337500,
                    PriceOld = 375000,
                    Image = "/img/BimTa/huggies/14.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 15,
                    ProductName="Tã dán Huggies Platinum nature made siêu cao cấp size L 54 miếng (9 - 14 kg)",
                    Price = 618000,
                    PriceOld = 780000,
                    Image = "/img/BimTa/huggies/15.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 16,
                    ProductName="Tã dán Huggies Platinum nature made siêu cao cấp size NB 60 miếng (Dưới 5 kg)",
                    Price = 189900,
                    PriceOld = 211000,
                    Image = "/img/BimTa/huggies/16.jpg",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 17,
                    ProductName="Tã lót Huggies size NB2 60 miếng (4 - 7 kg)",
                    Price = 94300,
                    PriceOld = 111000,
                    Image = "/img/BimTa/huggies/17.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 18,
                    ProductName="Tã dán Huggies Dry size S 56 miếng (4 - 8 kg)",
                    Price = 242400,
                    PriceOld = 380000,
                    Image = "/img/BimTa/huggies/18.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 19,
                    ProductName="Tã quần Huggies Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 842400,
                    PriceOld = 980000,
                    Image = "/img/BimTa/huggies/19.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 20,
                    ProductName="Tã quần Huggies Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 1042400,
                    PriceOld = 1180000,
                    Image = "/img/BimTa/huggies/20.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },

                //moony
                new Product
                {
                    ProductID = 21,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 378000,
                    PriceOld = 445000,
                    Image = "/img/BimTa/moony/21.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 22,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 578000,
                    PriceOld = 645000,
                    Image = "/img/BimTa/moony/22.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 23,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 778000,
                    PriceOld = 845000,
                    Image = "/img/BimTa/moony/23.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 24,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 978000,
                    PriceOld = 999000,
                    Image = "/img/BimTa/moony/24.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 25,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 278000,
                    PriceOld = 345000,
                    Image = "/img/BimTa/moony/25.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 26,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 878000,
                    PriceOld = 945000,
                    Image = "/img/BimTa/moony/26.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 27,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 778000,
                    PriceOld = 945000,
                    Image = "/img/BimTa/moony/27.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 28,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 278000,
                    PriceOld = 545000,
                    Image = "/img/BimTa/moony/28.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 29,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 178000,
                    PriceOld = 195000,
                    Image = "/img/BimTa/moony/29.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 30,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 1878000,
                    PriceOld = 1445000,
                    Image = "/img/BimTa/moony/30.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 21,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 378000,
                    PriceOld = 445000,
                    Image = "/img/BimTa/moony/21.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 22,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 578000,
                    PriceOld = 645000,
                    Image = "/img/BimTa/moony/22.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 23,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 778000,
                    PriceOld = 845000,
                    Image = "/img/BimTa/moony/23.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 24,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 978000,
                    PriceOld = 999000,
                    Image = "/img/BimTa/moony/24.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 25,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 278000,
                    PriceOld = 345000,
                    Image = "/img/BimTa/moony/25.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 26,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 878000,
                    PriceOld = 945000,
                    Image = "/img/BimTa/moony/26.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 27,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 778000,
                    PriceOld = 945000,
                    Image = "/img/BimTa/moony/27.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 28,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 278000,
                    PriceOld = 545000,
                    Image = "/img/BimTa/moony/28.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 29,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 178000,
                    PriceOld = 195000,
                    Image = "/img/BimTa/moony/29.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 30,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 1878000,
                    PriceOld = 1445000,
                    Image = "/img/BimTa/moony/30.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 29,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 178000,
                    PriceOld = 195000,
                    Image = "/img/BimTa/moony/29.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 30,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 1878000,
                    PriceOld = 1445000,
                    Image = "/img/BimTa/moony/30.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },

                //Bobby
                new Product
                {
                    ProductID = 1,
                    ProductName="Tã quần Bobby size M 76 miếng (6 - 11 kg)",
                    Price = 343400,
                    PriceOld = 404000,
                    Image = "/img/BimTa/bobby/1.jpg",
                    Trademark = "Bobby",
                    TypeDiapers = "Miếng lót sơ sinh",
                    WeighDiapers = "Dưới 5kg",
                    Size = "NB"
                },
                new Product
                {
                    ProductID = 2,
                    ProductName="Tã quần Bobby size XL 62 miếng (12 - 17 kg)",
                    Price = 243400,
                    PriceOld = 304000,
                    Image = "/img/BimTa/bobby/2.jpg",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5kg - 10kg",Size = "S"
                },
                new Product
                {
                    ProductID = 3,
                    ProductName="Tã quần Bobby size L 68 miếng (9 - 13 kg)",
                    Price = 143400,
                    PriceOld = 204000,
                    Image = "/img/BimTa/bobby/3.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 4,
                    ProductName="Tã quần Bobby size XXL 56 miếng (15 - 25 kg)",
                    Price = 323100,
                    PriceOld = 359000,
                    Image = "/img/BimTa/bobby/4.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 5,
                    ProductName="Tã quần Bobby Extra Soft-Dry size L 52 miếng (9 - 13 kg)",
                    Price = 291500,
                    PriceOld = 304000,
                    Image = "/img/BimTa/bobby/5.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 6,
                    ProductName="Tã quần Bobby Extra Soft-Dry size XXL 42 miếng (Trên 16 kg)",
                    Price = 2915000,
                    PriceOld = 434000,
                    Image = "/img/BimTa/bobby/6.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 7,
                    ProductName="Tã quần Bobby Extra Soft-Dry size M 60 miếng (6 - 11 kg)",
                    Price = 291500,
                    PriceOld = 343000,
                    Image = "/img/BimTa/bobby/7.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 8,
                    ProductName="Tã dán Bobby siêu mỏng size XXL 56 miếng (Trên 16 kg)",
                    Price = 289000,
                    PriceOld = 340000,
                    Image = "/img/BimTa/bobby/8.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 9,
                    ProductName="Tã quần Bobby size M 76 miếng (6 - 11 kg)",
                    Price = 278000,
                    PriceOld = 504000,
                    Image = "/img/BimTa/bobby/9.jpg",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 10,
                    ProductName="Tã quần Bobby Extra Soft-Dry size XL 46 miếng (12 - 17 kg)",
                    Price = 274400,
                    PriceOld = 344000,
                    Image = "/img/BimTa/bobby/10.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 11,
                    ProductName="Tã quần Bobby size M 76 miếng (6 - 11 kg)",
                    Price = 278000,
                    PriceOld = 504000,
                    Image = "/img/BimTa/bobby/9.jpg",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 12,
                    ProductName="Tã quần Bobby Extra Soft-Dry size XL 46 miếng (12 - 17 kg)",
                    Price = 274400,
                    PriceOld = 344000,
                    Image = "/img/BimTa/bobby/10.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 1,
                    ProductName="Tã quần Bobby size M 76 miếng (6 - 11 kg)",
                    Price = 343400,
                    PriceOld = 404000,
                    Image = "/img/BimTa/bobby/1.jpg",
                    Trademark = "Bobby",
                    TypeDiapers = "Miếng lót sơ sinh",
                    WeighDiapers = "Dưới 5kg",
                    Size = "NB"
                },
                new Product
                {
                    ProductID = 2,
                    ProductName="Tã quần Bobby size XL 62 miếng (12 - 17 kg)",
                    Price = 243400,
                    PriceOld = 304000,
                    Image = "/img/BimTa/bobby/2.jpg",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5kg - 10kg",Size = "S"
                },
                new Product
                {
                    ProductID = 3,
                    ProductName="Tã quần Bobby size L 68 miếng (9 - 13 kg)",
                    Price = 143400,
                    PriceOld = 204000,
                    Image = "/img/BimTa/bobby/3.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 4,
                    ProductName="Tã quần Bobby size XXL 56 miếng (15 - 25 kg)",
                    Price = 323100,
                    PriceOld = 359000,
                    Image = "/img/BimTa/bobby/4.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 5,
                    ProductName="Tã quần Bobby Extra Soft-Dry size L 52 miếng (9 - 13 kg)",
                    Price = 291500,
                    PriceOld = 304000,
                    Image = "/img/BimTa/bobby/5.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 6,
                    ProductName="Tã quần Bobby Extra Soft-Dry size XXL 42 miếng (Trên 16 kg)",
                    Price = 2915000,
                    PriceOld = 434000,
                    Image = "/img/BimTa/bobby/6.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 7,
                    ProductName="Tã quần Bobby Extra Soft-Dry size M 60 miếng (6 - 11 kg)",
                    Price = 291500,
                    PriceOld = 343000,
                    Image = "/img/BimTa/bobby/7.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 8,
                    ProductName="Tã dán Bobby siêu mỏng size XXL 56 miếng (Trên 16 kg)",
                    Price = 289000,
                    PriceOld = 340000,
                    Image = "/img/BimTa/bobby/8.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 9,
                    ProductName="Tã quần Bobby size M 76 miếng (6 - 11 kg)",
                    Price = 278000,
                    PriceOld = 504000,
                    Image = "/img/BimTa/bobby/9.jpg",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 10,
                    ProductName="Tã quần Bobby Extra Soft-Dry size XL 46 miếng (12 - 17 kg)",
                    Price = 274400,
                    PriceOld = 344000,
                    Image = "/img/BimTa/bobby/10.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 11,
                    ProductName="Tã quần Bobby size M 76 miếng (6 - 11 kg)",
                    Price = 278000,
                    PriceOld = 504000,
                    Image = "/img/BimTa/bobby/9.jpg",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 12,
                    ProductName="Tã quần Bobby Extra Soft-Dry size XL 46 miếng (12 - 17 kg)",
                    Price = 274400,
                    PriceOld = 344000,
                    Image = "/img/BimTa/bobby/10.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },

                //Huggies
                new Product
                {
                    ProductID = 11,
                    ProductName="Tã quần Huggies Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 342400,
                    PriceOld = 380000,
                    Image = "/img/BimTa/huggies/11.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 12,
                    ProductName="Tã quần Huggies Dry size XXL 56 miếng (Trên 15 kg)",
                    Price = 342400,
                    PriceOld = 380000,
                    Image = "/img/BimTa/huggies/12.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 13,
                    ProductName="Tã quần Huggies Dry size L",
                    Price = 442400,
                    PriceOld = 580000,
                    Image = "/img/BimTa/huggies/13.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 14,
                    ProductName="Tã quần Huggies Platinum nature made siêu cao cấp size L 44 miếng (9 - 14 kg)",
                    Price = 337500,
                    PriceOld = 375000,
                    Image = "/img/BimTa/huggies/14.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 15,
                    ProductName="Tã dán Huggies Platinum nature made siêu cao cấp size L 54 miếng (9 - 14 kg)",
                    Price = 618000,
                    PriceOld = 780000,
                    Image = "/img/BimTa/huggies/15.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 16,
                    ProductName="Tã dán Huggies Platinum nature made siêu cao cấp size NB 60 miếng (Dưới 5 kg)",
                    Price = 189900,
                    PriceOld = 211000,
                    Image = "/img/BimTa/huggies/16.jpg",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 17,
                    ProductName="Tã lót Huggies size NB2 60 miếng (4 - 7 kg)",
                    Price = 94300,
                    PriceOld = 111000,
                    Image = "/img/BimTa/huggies/17.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 18,
                    ProductName="Tã dán Huggies Dry size S 56 miếng (4 - 8 kg)",
                    Price = 242400,
                    PriceOld = 380000,
                    Image = "/img/BimTa/huggies/18.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 19,
                    ProductName="Tã quần Huggies Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 842400,
                    PriceOld = 980000,
                    Image = "/img/BimTa/huggies/19.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 20,
                    ProductName="Tã quần Huggies Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 1042400,
                    PriceOld = 1180000,
                    Image = "/img/BimTa/huggies/20.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 11,
                    ProductName="Tã quần Huggies Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 342400,
                    PriceOld = 380000,
                    Image = "/img/BimTa/huggies/11.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 12,
                    ProductName="Tã quần Huggies Dry size XXL 56 miếng (Trên 15 kg)",
                    Price = 342400,
                    PriceOld = 380000,
                    Image = "/img/BimTa/huggies/12.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 13,
                    ProductName="Tã quần Huggies Dry size L",
                    Price = 442400,
                    PriceOld = 580000,
                    Image = "/img/BimTa/huggies/13.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 14,
                    ProductName="Tã quần Huggies Platinum nature made siêu cao cấp size L 44 miếng (9 - 14 kg)",
                    Price = 337500,
                    PriceOld = 375000,
                    Image = "/img/BimTa/huggies/14.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 15,
                    ProductName="Tã dán Huggies Platinum nature made siêu cao cấp size L 54 miếng (9 - 14 kg)",
                    Price = 618000,
                    PriceOld = 780000,
                    Image = "/img/BimTa/huggies/15.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 16,
                    ProductName="Tã dán Huggies Platinum nature made siêu cao cấp size NB 60 miếng (Dưới 5 kg)",
                    Price = 189900,
                    PriceOld = 211000,
                    Image = "/img/BimTa/huggies/16.jpg",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 17,
                    ProductName="Tã lót Huggies size NB2 60 miếng (4 - 7 kg)",
                    Price = 94300,
                    PriceOld = 111000,
                    Image = "/img/BimTa/huggies/17.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 18,
                    ProductName="Tã dán Huggies Dry size S 56 miếng (4 - 8 kg)",
                    Price = 242400,
                    PriceOld = 380000,
                    Image = "/img/BimTa/huggies/18.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 19,
                    ProductName="Tã quần Huggies Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 842400,
                    PriceOld = 980000,
                    Image = "/img/BimTa/huggies/19.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 20,
                    ProductName="Tã quần Huggies Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 1042400,
                    PriceOld = 1180000,
                    Image = "/img/BimTa/huggies/20.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },

                //moony
                new Product
                {
                    ProductID = 21,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 378000,
                    PriceOld = 445000,
                    Image = "/img/BimTa/moony/21.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 22,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 578000,
                    PriceOld = 645000,
                    Image = "/img/BimTa/moony/22.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 23,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 778000,
                    PriceOld = 845000,
                    Image = "/img/BimTa/moony/23.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 24,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 978000,
                    PriceOld = 999000,
                    Image = "/img/BimTa/moony/24.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 25,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 278000,
                    PriceOld = 345000,
                    Image = "/img/BimTa/moony/25.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 26,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 878000,
                    PriceOld = 945000,
                    Image = "/img/BimTa/moony/26.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 27,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 778000,
                    PriceOld = 945000,
                    Image = "/img/BimTa/moony/27.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 28,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 278000,
                    PriceOld = 545000,
                    Image = "/img/BimTa/moony/28.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 29,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 178000,
                    PriceOld = 195000,
                    Image = "/img/BimTa/moony/29.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 30,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 1878000,
                    PriceOld = 1445000,
                    Image = "/img/BimTa/moony/30.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 21,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 378000,
                    PriceOld = 445000,
                    Image = "/img/BimTa/moony/21.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 22,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 578000,
                    PriceOld = 645000,
                    Image = "/img/BimTa/moony/22.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 23,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 778000,
                    PriceOld = 845000,
                    Image = "/img/BimTa/moony/23.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 24,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 978000,
                    PriceOld = 999000,
                    Image = "/img/BimTa/moony/24.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 25,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 278000,
                    PriceOld = 345000,
                    Image = "/img/BimTa/moony/25.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 26,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 878000,
                    PriceOld = 945000,
                    Image = "/img/BimTa/moony/26.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 27,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 778000,
                    PriceOld = 945000,
                    Image = "/img/BimTa/moony/27.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 28,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 278000,
                    PriceOld = 545000,
                    Image = "/img/BimTa/moony/28.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 29,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 178000,
                    PriceOld = 195000,
                    Image = "/img/BimTa/moony/29.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 30,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 1878000,
                    PriceOld = 1445000,
                    Image = "/img/BimTa/moony/30.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 29,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 178000,
                    PriceOld = 195000,
                    Image = "/img/BimTa/moony/29.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 30,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 1878000,
                    PriceOld = 1445000,
                    Image = "/img/BimTa/moony/30.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
            };
        }
    }

    public class Query
    {
        public string TrademarkQR { get; set; }
        public string PriceForm { get; set; }
        public string TypeQR { get; set; }
        public string SizeQR { get; set; }
        public string WeightQR { get; set; }
        public int Order { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int PageMax { get; set; }
        public int CountSP { get; set; }

        public List<Product> Bimta { get; set; }
        public List<Product> Filtered { get; set; }

        public Query()
        {
            Bimta = new List<Product>()
            {
                //Bobby
                new Product
                {
                    ProductID = 1,
                    ProductName="Tã quần Bobby size M 76 miếng (6 - 11 kg)",
                    Price = 343400,
                    PriceOld = 404000,
                    Image = "/img/BimTa/bobby/1.jpg",
                    Trademark = "Bobby",
                    TypeDiapers = "Miếng lót sơ sinh",
                    WeighDiapers = "Dưới 5kg",
                    Size = "NB"
                },
                new Product
                {
                    ProductID = 2,
                    ProductName="Tã quần Bobby size XL 62 miếng (12 - 17 kg)",
                    Price = 243400,
                    PriceOld = 304000,
                    Image = "/img/BimTa/bobby/2.jpg",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5kg - 10kg",Size = "S"
                },
                new Product
                {
                    ProductID = 3,
                    ProductName="Tã quần Bobby size L 68 miếng (9 - 13 kg)",
                    Price = 143400,
                    PriceOld = 204000,
                    Image = "/img/BimTa/bobby/3.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 4,
                    ProductName="Tã quần Bobby size XXL 56 miếng (15 - 25 kg)",
                    Price = 323100,
                    PriceOld = 359000,
                    Image = "/img/BimTa/bobby/4.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 5,
                    ProductName="Tã quần Bobby Extra Soft-Dry size L 52 miếng (9 - 13 kg)",
                    Price = 291500,
                    PriceOld = 304000,
                    Image = "/img/BimTa/bobby/5.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 6,
                    ProductName="Tã quần Bobby Extra Soft-Dry size XXL 42 miếng (Trên 16 kg)",
                    Price = 2915000,
                    PriceOld = 434000,
                    Image = "/img/BimTa/bobby/6.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 7,
                    ProductName="Tã quần Bobby Extra Soft-Dry size M 60 miếng (6 - 11 kg)",
                    Price = 291500,
                    PriceOld = 343000,
                    Image = "/img/BimTa/bobby/7.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 8,
                    ProductName="Tã dán Bobby siêu mỏng size XXL 56 miếng (Trên 16 kg)",
                    Price = 289000,
                    PriceOld = 340000,
                    Image = "/img/BimTa/bobby/8.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 9,
                    ProductName="Tã quần Bobby size M 76 miếng (6 - 11 kg)",
                    Price = 278000,
                    PriceOld = 504000,
                    Image = "/img/BimTa/bobby/9.jpg",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 10,
                    ProductName="Tã quần Bobby Extra Soft-Dry size XL 46 miếng (12 - 17 kg)",
                    Price = 274400,
                    PriceOld = 344000,
                    Image = "/img/BimTa/bobby/10.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 11,
                    ProductName="Tã quần Bobby size M 76 miếng (6 - 11 kg)",
                    Price = 278000,
                    PriceOld = 504000,
                    Image = "/img/BimTa/bobby/9.jpg",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 12,
                    ProductName="Tã quần Bobby Extra Soft-Dry size XL 46 miếng (12 - 17 kg)",
                    Price = 274400,
                    PriceOld = 344000,
                    Image = "/img/BimTa/bobby/10.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 1,
                    ProductName="Tã quần Bobby size M 76 miếng (6 - 11 kg)",
                    Price = 343400,
                    PriceOld = 404000,
                    Image = "/img/BimTa/bobby/1.jpg",
                    Trademark = "Bobby",
                    TypeDiapers = "Miếng lót sơ sinh",
                    WeighDiapers = "Dưới 5kg",
                    Size = "NB"
                },
                new Product
                {
                    ProductID = 2,
                    ProductName="Tã quần Bobby size XL 62 miếng (12 - 17 kg)",
                    Price = 243400,
                    PriceOld = 304000,
                    Image = "/img/BimTa/bobby/2.jpg",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5kg - 10kg",Size = "S"
                },
                new Product
                {
                    ProductID = 3,
                    ProductName="Tã quần Bobby size L 68 miếng (9 - 13 kg)",
                    Price = 143400,
                    PriceOld = 204000,
                    Image = "/img/BimTa/bobby/3.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 4,
                    ProductName="Tã quần Bobby size XXL 56 miếng (15 - 25 kg)",
                    Price = 323100,
                    PriceOld = 359000,
                    Image = "/img/BimTa/bobby/4.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 5,
                    ProductName="Tã quần Bobby Extra Soft-Dry size L 52 miếng (9 - 13 kg)",
                    Price = 291500,
                    PriceOld = 304000,
                    Image = "/img/BimTa/bobby/5.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 6,
                    ProductName="Tã quần Bobby Extra Soft-Dry size XXL 42 miếng (Trên 16 kg)",
                    Price = 2915000,
                    PriceOld = 434000,
                    Image = "/img/BimTa/bobby/6.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 7,
                    ProductName="Tã quần Bobby Extra Soft-Dry size M 60 miếng (6 - 11 kg)",
                    Price = 291500,
                    PriceOld = 343000,
                    Image = "/img/BimTa/bobby/7.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 8,
                    ProductName="Tã dán Bobby siêu mỏng size XXL 56 miếng (Trên 16 kg)",
                    Price = 289000,
                    PriceOld = 340000,
                    Image = "/img/BimTa/bobby/8.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 9,
                    ProductName="Tã quần Bobby size M 76 miếng (6 - 11 kg)",
                    Price = 278000,
                    PriceOld = 504000,
                    Image = "/img/BimTa/bobby/9.jpg",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 10,
                    ProductName="Tã quần Bobby Extra Soft-Dry size XL 46 miếng (12 - 17 kg)",
                    Price = 274400,
                    PriceOld = 344000,
                    Image = "/img/BimTa/bobby/10.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 11,
                    ProductName="Tã quần Bobby size M 76 miếng (6 - 11 kg)",
                    Price = 278000,
                    PriceOld = 504000,
                    Image = "/img/BimTa/bobby/9.jpg",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 12,
                    ProductName="Tã quần Bobby Extra Soft-Dry size XL 46 miếng (12 - 17 kg)",
                    Price = 274400,
                    PriceOld = 344000,
                    Image = "/img/BimTa/bobby/10.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },

                //Huggies
                new Product
                {
                    ProductID = 11,
                    ProductName="Tã quần Huggies Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 342400,
                    PriceOld = 380000,
                    Image = "/img/BimTa/huggies/11.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 12,
                    ProductName="Tã quần Huggies Dry size XXL 56 miếng (Trên 15 kg)",
                    Price = 342400,
                    PriceOld = 380000,
                    Image = "/img/BimTa/huggies/12.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 13,
                    ProductName="Tã quần Huggies Dry size L",
                    Price = 442400,
                    PriceOld = 580000,
                    Image = "/img/BimTa/huggies/13.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 14,
                    ProductName="Tã quần Huggies Platinum nature made siêu cao cấp size L 44 miếng (9 - 14 kg)",
                    Price = 337500,
                    PriceOld = 375000,
                    Image = "/img/BimTa/huggies/14.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 15,
                    ProductName="Tã dán Huggies Platinum nature made siêu cao cấp size L 54 miếng (9 - 14 kg)",
                    Price = 618000,
                    PriceOld = 780000,
                    Image = "/img/BimTa/huggies/15.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 16,
                    ProductName="Tã dán Huggies Platinum nature made siêu cao cấp size NB 60 miếng (Dưới 5 kg)",
                    Price = 189900,
                    PriceOld = 211000,
                    Image = "/img/BimTa/huggies/16.jpg",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 17,
                    ProductName="Tã lót Huggies size NB2 60 miếng (4 - 7 kg)",
                    Price = 94300,
                    PriceOld = 111000,
                    Image = "/img/BimTa/huggies/17.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 18,
                    ProductName="Tã dán Huggies Dry size S 56 miếng (4 - 8 kg)",
                    Price = 242400,
                    PriceOld = 380000,
                    Image = "/img/BimTa/huggies/18.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 19,
                    ProductName="Tã quần Huggies Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 842400,
                    PriceOld = 980000,
                    Image = "/img/BimTa/huggies/19.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 20,
                    ProductName="Tã quần Huggies Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 1042400,
                    PriceOld = 1180000,
                    Image = "/img/BimTa/huggies/20.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 11,
                    ProductName="Tã quần Huggies Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 342400,
                    PriceOld = 380000,
                    Image = "/img/BimTa/huggies/11.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 12,
                    ProductName="Tã quần Huggies Dry size XXL 56 miếng (Trên 15 kg)",
                    Price = 342400,
                    PriceOld = 380000,
                    Image = "/img/BimTa/huggies/12.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 13,
                    ProductName="Tã quần Huggies Dry size L",
                    Price = 442400,
                    PriceOld = 580000,
                    Image = "/img/BimTa/huggies/13.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 14,
                    ProductName="Tã quần Huggies Platinum nature made siêu cao cấp size L 44 miếng (9 - 14 kg)",
                    Price = 337500,
                    PriceOld = 375000,
                    Image = "/img/BimTa/huggies/14.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 15,
                    ProductName="Tã dán Huggies Platinum nature made siêu cao cấp size L 54 miếng (9 - 14 kg)",
                    Price = 618000,
                    PriceOld = 780000,
                    Image = "/img/BimTa/huggies/15.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 16,
                    ProductName="Tã dán Huggies Platinum nature made siêu cao cấp size NB 60 miếng (Dưới 5 kg)",
                    Price = 189900,
                    PriceOld = 211000,
                    Image = "/img/BimTa/huggies/16.jpg",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 17,
                    ProductName="Tã lót Huggies size NB2 60 miếng (4 - 7 kg)",
                    Price = 94300,
                    PriceOld = 111000,
                    Image = "/img/BimTa/huggies/17.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 18,
                    ProductName="Tã dán Huggies Dry size S 56 miếng (4 - 8 kg)",
                    Price = 242400,
                    PriceOld = 380000,
                    Image = "/img/BimTa/huggies/18.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 19,
                    ProductName="Tã quần Huggies Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 842400,
                    PriceOld = 980000,
                    Image = "/img/BimTa/huggies/19.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 20,
                    ProductName="Tã quần Huggies Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 1042400,
                    PriceOld = 1180000,
                    Image = "/img/BimTa/huggies/20.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },

                //moony
                new Product
                {
                    ProductID = 21,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 378000,
                    PriceOld = 445000,
                    Image = "/img/BimTa/moony/21.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 22,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 578000,
                    PriceOld = 645000,
                    Image = "/img/BimTa/moony/22.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 23,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 778000,
                    PriceOld = 845000,
                    Image = "/img/BimTa/moony/23.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 24,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 978000,
                    PriceOld = 999000,
                    Image = "/img/BimTa/moony/24.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 25,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 278000,
                    PriceOld = 345000,
                    Image = "/img/BimTa/moony/25.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 26,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 878000,
                    PriceOld = 945000,
                    Image = "/img/BimTa/moony/26.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 27,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 778000,
                    PriceOld = 945000,
                    Image = "/img/BimTa/moony/27.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 28,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 278000,
                    PriceOld = 545000,
                    Image = "/img/BimTa/moony/28.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 29,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 178000,
                    PriceOld = 195000,
                    Image = "/img/BimTa/moony/29.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 30,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 1878000,
                    PriceOld = 1445000,
                    Image = "/img/BimTa/moony/30.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 21,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 378000,
                    PriceOld = 445000,
                    Image = "/img/BimTa/moony/21.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 22,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 578000,
                    PriceOld = 645000,
                    Image = "/img/BimTa/moony/22.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 23,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 778000,
                    PriceOld = 845000,
                    Image = "/img/BimTa/moony/23.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 24,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 978000,
                    PriceOld = 999000,
                    Image = "/img/BimTa/moony/24.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 25,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 278000,
                    PriceOld = 345000,
                    Image = "/img/BimTa/moony/25.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 26,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 878000,
                    PriceOld = 945000,
                    Image = "/img/BimTa/moony/26.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 27,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 778000,
                    PriceOld = 945000,
                    Image = "/img/BimTa/moony/27.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 28,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 278000,
                    PriceOld = 545000,
                    Image = "/img/BimTa/moony/28.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 29,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 178000,
                    PriceOld = 195000,
                    Image = "/img/BimTa/moony/29.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 30,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 1878000,
                    PriceOld = 1445000,
                    Image = "/img/BimTa/moony/30.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 29,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 178000,
                    PriceOld = 195000,
                    Image = "/img/BimTa/moony/29.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 30,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 1878000,
                    PriceOld = 1445000,
                    Image = "/img/BimTa/moony/30.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },

                //Bobby
                new Product
                {
                    ProductID = 1,
                    ProductName="Tã quần Bobby size M 76 miếng (6 - 11 kg)",
                    Price = 343400,
                    PriceOld = 404000,
                    Image = "/img/BimTa/bobby/1.jpg",
                    Trademark = "Bobby",
                    TypeDiapers = "Miếng lót sơ sinh",
                    WeighDiapers = "Dưới 5kg",
                    Size = "NB"
                },
                new Product
                {
                    ProductID = 2,
                    ProductName="Tã quần Bobby size XL 62 miếng (12 - 17 kg)",
                    Price = 243400,
                    PriceOld = 304000,
                    Image = "/img/BimTa/bobby/2.jpg",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5kg - 10kg",Size = "S"
                },
                new Product
                {
                    ProductID = 3,
                    ProductName="Tã quần Bobby size L 68 miếng (9 - 13 kg)",
                    Price = 143400,
                    PriceOld = 204000,
                    Image = "/img/BimTa/bobby/3.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 4,
                    ProductName="Tã quần Bobby size XXL 56 miếng (15 - 25 kg)",
                    Price = 323100,
                    PriceOld = 359000,
                    Image = "/img/BimTa/bobby/4.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 5,
                    ProductName="Tã quần Bobby Extra Soft-Dry size L 52 miếng (9 - 13 kg)",
                    Price = 291500,
                    PriceOld = 304000,
                    Image = "/img/BimTa/bobby/5.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 6,
                    ProductName="Tã quần Bobby Extra Soft-Dry size XXL 42 miếng (Trên 16 kg)",
                    Price = 2915000,
                    PriceOld = 434000,
                    Image = "/img/BimTa/bobby/6.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 7,
                    ProductName="Tã quần Bobby Extra Soft-Dry size M 60 miếng (6 - 11 kg)",
                    Price = 291500,
                    PriceOld = 343000,
                    Image = "/img/BimTa/bobby/7.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 8,
                    ProductName="Tã dán Bobby siêu mỏng size XXL 56 miếng (Trên 16 kg)",
                    Price = 289000,
                    PriceOld = 340000,
                    Image = "/img/BimTa/bobby/8.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 9,
                    ProductName="Tã quần Bobby size M 76 miếng (6 - 11 kg)",
                    Price = 278000,
                    PriceOld = 504000,
                    Image = "/img/BimTa/bobby/9.jpg",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 10,
                    ProductName="Tã quần Bobby Extra Soft-Dry size XL 46 miếng (12 - 17 kg)",
                    Price = 274400,
                    PriceOld = 344000,
                    Image = "/img/BimTa/bobby/10.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 11,
                    ProductName="Tã quần Bobby size M 76 miếng (6 - 11 kg)",
                    Price = 278000,
                    PriceOld = 504000,
                    Image = "/img/BimTa/bobby/9.jpg",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 12,
                    ProductName="Tã quần Bobby Extra Soft-Dry size XL 46 miếng (12 - 17 kg)",
                    Price = 274400,
                    PriceOld = 344000,
                    Image = "/img/BimTa/bobby/10.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 1,
                    ProductName="Tã quần Bobby size M 76 miếng (6 - 11 kg)",
                    Price = 343400,
                    PriceOld = 404000,
                    Image = "/img/BimTa/bobby/1.jpg",
                    Trademark = "Bobby",
                    TypeDiapers = "Miếng lót sơ sinh",
                    WeighDiapers = "Dưới 5kg",
                    Size = "NB"
                },
                new Product
                {
                    ProductID = 2,
                    ProductName="Tã quần Bobby size XL 62 miếng (12 - 17 kg)",
                    Price = 243400,
                    PriceOld = 304000,
                    Image = "/img/BimTa/bobby/2.jpg",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5kg - 10kg",Size = "S"
                },
                new Product
                {
                    ProductID = 3,
                    ProductName="Tã quần Bobby size L 68 miếng (9 - 13 kg)",
                    Price = 143400,
                    PriceOld = 204000,
                    Image = "/img/BimTa/bobby/3.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 4,
                    ProductName="Tã quần Bobby size XXL 56 miếng (15 - 25 kg)",
                    Price = 323100,
                    PriceOld = 359000,
                    Image = "/img/BimTa/bobby/4.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 5,
                    ProductName="Tã quần Bobby Extra Soft-Dry size L 52 miếng (9 - 13 kg)",
                    Price = 291500,
                    PriceOld = 304000,
                    Image = "/img/BimTa/bobby/5.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 6,
                    ProductName="Tã quần Bobby Extra Soft-Dry size XXL 42 miếng (Trên 16 kg)",
                    Price = 2915000,
                    PriceOld = 434000,
                    Image = "/img/BimTa/bobby/6.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 7,
                    ProductName="Tã quần Bobby Extra Soft-Dry size M 60 miếng (6 - 11 kg)",
                    Price = 291500,
                    PriceOld = 343000,
                    Image = "/img/BimTa/bobby/7.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 8,
                    ProductName="Tã dán Bobby siêu mỏng size XXL 56 miếng (Trên 16 kg)",
                    Price = 289000,
                    PriceOld = 340000,
                    Image = "/img/BimTa/bobby/8.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 9,
                    ProductName="Tã quần Bobby size M 76 miếng (6 - 11 kg)",
                    Price = 278000,
                    PriceOld = 504000,
                    Image = "/img/BimTa/bobby/9.jpg",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 10,
                    ProductName="Tã quần Bobby Extra Soft-Dry size XL 46 miếng (12 - 17 kg)",
                    Price = 274400,
                    PriceOld = 344000,
                    Image = "/img/BimTa/bobby/10.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 11,
                    ProductName="Tã quần Bobby size M 76 miếng (6 - 11 kg)",
                    Price = 278000,
                    PriceOld = 504000,
                    Image = "/img/BimTa/bobby/9.jpg",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 12,
                    ProductName="Tã quần Bobby Extra Soft-Dry size XL 46 miếng (12 - 17 kg)",
                    Price = 274400,
                    PriceOld = 344000,
                    Image = "/img/BimTa/bobby/10.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },

                //Huggies
                new Product
                {
                    ProductID = 11,
                    ProductName="Tã quần Huggies Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 342400,
                    PriceOld = 380000,
                    Image = "/img/BimTa/huggies/11.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 12,
                    ProductName="Tã quần Huggies Dry size XXL 56 miếng (Trên 15 kg)",
                    Price = 342400,
                    PriceOld = 380000,
                    Image = "/img/BimTa/huggies/12.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 13,
                    ProductName="Tã quần Huggies Dry size L",
                    Price = 442400,
                    PriceOld = 580000,
                    Image = "/img/BimTa/huggies/13.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 14,
                    ProductName="Tã quần Huggies Platinum nature made siêu cao cấp size L 44 miếng (9 - 14 kg)",
                    Price = 337500,
                    PriceOld = 375000,
                    Image = "/img/BimTa/huggies/14.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 15,
                    ProductName="Tã dán Huggies Platinum nature made siêu cao cấp size L 54 miếng (9 - 14 kg)",
                    Price = 618000,
                    PriceOld = 780000,
                    Image = "/img/BimTa/huggies/15.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 16,
                    ProductName="Tã dán Huggies Platinum nature made siêu cao cấp size NB 60 miếng (Dưới 5 kg)",
                    Price = 189900,
                    PriceOld = 211000,
                    Image = "/img/BimTa/huggies/16.jpg",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 17,
                    ProductName="Tã lót Huggies size NB2 60 miếng (4 - 7 kg)",
                    Price = 94300,
                    PriceOld = 111000,
                    Image = "/img/BimTa/huggies/17.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 18,
                    ProductName="Tã dán Huggies Dry size S 56 miếng (4 - 8 kg)",
                    Price = 242400,
                    PriceOld = 380000,
                    Image = "/img/BimTa/huggies/18.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 19,
                    ProductName="Tã quần Huggies Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 842400,
                    PriceOld = 980000,
                    Image = "/img/BimTa/huggies/19.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 20,
                    ProductName="Tã quần Huggies Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 1042400,
                    PriceOld = 1180000,
                    Image = "/img/BimTa/huggies/20.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 11,
                    ProductName="Tã quần Huggies Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 342400,
                    PriceOld = 380000,
                    Image = "/img/BimTa/huggies/11.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 12,
                    ProductName="Tã quần Huggies Dry size XXL 56 miếng (Trên 15 kg)",
                    Price = 342400,
                    PriceOld = 380000,
                    Image = "/img/BimTa/huggies/12.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 13,
                    ProductName="Tã quần Huggies Dry size L",
                    Price = 442400,
                    PriceOld = 580000,
                    Image = "/img/BimTa/huggies/13.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 14,
                    ProductName="Tã quần Huggies Platinum nature made siêu cao cấp size L 44 miếng (9 - 14 kg)",
                    Price = 337500,
                    PriceOld = 375000,
                    Image = "/img/BimTa/huggies/14.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 15,
                    ProductName="Tã dán Huggies Platinum nature made siêu cao cấp size L 54 miếng (9 - 14 kg)",
                    Price = 618000,
                    PriceOld = 780000,
                    Image = "/img/BimTa/huggies/15.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 16,
                    ProductName="Tã dán Huggies Platinum nature made siêu cao cấp size NB 60 miếng (Dưới 5 kg)",
                    Price = 189900,
                    PriceOld = 211000,
                    Image = "/img/BimTa/huggies/16.jpg",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 17,
                    ProductName="Tã lót Huggies size NB2 60 miếng (4 - 7 kg)",
                    Price = 94300,
                    PriceOld = 111000,
                    Image = "/img/BimTa/huggies/17.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 18,
                    ProductName="Tã dán Huggies Dry size S 56 miếng (4 - 8 kg)",
                    Price = 242400,
                    PriceOld = 380000,
                    Image = "/img/BimTa/huggies/18.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 19,
                    ProductName="Tã quần Huggies Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 842400,
                    PriceOld = 980000,
                    Image = "/img/BimTa/huggies/19.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 20,
                    ProductName="Tã quần Huggies Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 1042400,
                    PriceOld = 1180000,
                    Image = "/img/BimTa/huggies/20.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },

                //moony
                new Product
                {
                    ProductID = 21,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 378000,
                    PriceOld = 445000,
                    Image = "/img/BimTa/moony/21.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 22,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 578000,
                    PriceOld = 645000,
                    Image = "/img/BimTa/moony/22.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 23,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 778000,
                    PriceOld = 845000,
                    Image = "/img/BimTa/moony/23.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 24,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 978000,
                    PriceOld = 999000,
                    Image = "/img/BimTa/moony/24.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 25,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 278000,
                    PriceOld = 345000,
                    Image = "/img/BimTa/moony/25.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 26,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 878000,
                    PriceOld = 945000,
                    Image = "/img/BimTa/moony/26.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 27,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 778000,
                    PriceOld = 945000,
                    Image = "/img/BimTa/moony/27.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 28,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 278000,
                    PriceOld = 545000,
                    Image = "/img/BimTa/moony/28.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 29,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 178000,
                    PriceOld = 195000,
                    Image = "/img/BimTa/moony/29.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 30,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 1878000,
                    PriceOld = 1445000,
                    Image = "/img/BimTa/moony/30.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 21,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 378000,
                    PriceOld = 445000,
                    Image = "/img/BimTa/moony/21.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 22,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 578000,
                    PriceOld = 645000,
                    Image = "/img/BimTa/moony/22.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 23,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 778000,
                    PriceOld = 845000,
                    Image = "/img/BimTa/moony/23.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 24,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 978000,
                    PriceOld = 999000,
                    Image = "/img/BimTa/moony/24.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 25,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 278000,
                    PriceOld = 345000,
                    Image = "/img/BimTa/moony/25.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 26,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 878000,
                    PriceOld = 945000,
                    Image = "/img/BimTa/moony/26.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 27,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 778000,
                    PriceOld = 945000,
                    Image = "/img/BimTa/moony/27.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 28,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 278000,
                    PriceOld = 545000,
                    Image = "/img/BimTa/moony/28.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 29,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 178000,
                    PriceOld = 195000,
                    Image = "/img/BimTa/moony/29.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 30,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 1878000,
                    PriceOld = 1445000,
                    Image = "/img/BimTa/moony/30.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 29,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 178000,
                    PriceOld = 195000,
                    Image = "/img/BimTa/moony/29.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 30,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 1878000,
                    PriceOld = 1445000,
                    Image = "/img/BimTa/moony/30.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },

                //Bobby
                new Product
                {
                    ProductID = 1,
                    ProductName="Tã quần Bobby size M 76 miếng (6 - 11 kg)",
                    Price = 343400,
                    PriceOld = 404000,
                    Image = "/img/BimTa/bobby/1.jpg",
                    Trademark = "Bobby",
                    TypeDiapers = "Miếng lót sơ sinh",
                    WeighDiapers = "Dưới 5kg",
                    Size = "NB"
                },
                new Product
                {
                    ProductID = 2,
                    ProductName="Tã quần Bobby size XL 62 miếng (12 - 17 kg)",
                    Price = 243400,
                    PriceOld = 304000,
                    Image = "/img/BimTa/bobby/2.jpg",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5kg - 10kg",Size = "S"
                },
                new Product
                {
                    ProductID = 3,
                    ProductName="Tã quần Bobby size L 68 miếng (9 - 13 kg)",
                    Price = 143400,
                    PriceOld = 204000,
                    Image = "/img/BimTa/bobby/3.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 4,
                    ProductName="Tã quần Bobby size XXL 56 miếng (15 - 25 kg)",
                    Price = 323100,
                    PriceOld = 359000,
                    Image = "/img/BimTa/bobby/4.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 5,
                    ProductName="Tã quần Bobby Extra Soft-Dry size L 52 miếng (9 - 13 kg)",
                    Price = 291500,
                    PriceOld = 304000,
                    Image = "/img/BimTa/bobby/5.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 6,
                    ProductName="Tã quần Bobby Extra Soft-Dry size XXL 42 miếng (Trên 16 kg)",
                    Price = 2915000,
                    PriceOld = 434000,
                    Image = "/img/BimTa/bobby/6.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 7,
                    ProductName="Tã quần Bobby Extra Soft-Dry size M 60 miếng (6 - 11 kg)",
                    Price = 291500,
                    PriceOld = 343000,
                    Image = "/img/BimTa/bobby/7.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 8,
                    ProductName="Tã dán Bobby siêu mỏng size XXL 56 miếng (Trên 16 kg)",
                    Price = 289000,
                    PriceOld = 340000,
                    Image = "/img/BimTa/bobby/8.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 9,
                    ProductName="Tã quần Bobby size M 76 miếng (6 - 11 kg)",
                    Price = 278000,
                    PriceOld = 504000,
                    Image = "/img/BimTa/bobby/9.jpg",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 10,
                    ProductName="Tã quần Bobby Extra Soft-Dry size XL 46 miếng (12 - 17 kg)",
                    Price = 274400,
                    PriceOld = 344000,
                    Image = "/img/BimTa/bobby/10.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 11,
                    ProductName="Tã quần Bobby size M 76 miếng (6 - 11 kg)",
                    Price = 278000,
                    PriceOld = 504000,
                    Image = "/img/BimTa/bobby/9.jpg",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 12,
                    ProductName="Tã quần Bobby Extra Soft-Dry size XL 46 miếng (12 - 17 kg)",
                    Price = 274400,
                    PriceOld = 344000,
                    Image = "/img/BimTa/bobby/10.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 1,
                    ProductName="Tã quần Bobby size M 76 miếng (6 - 11 kg)",
                    Price = 343400,
                    PriceOld = 404000,
                    Image = "/img/BimTa/bobby/1.jpg",
                    Trademark = "Bobby",
                    TypeDiapers = "Miếng lót sơ sinh",
                    WeighDiapers = "Dưới 5kg",
                    Size = "NB"
                },
                new Product
                {
                    ProductID = 2,
                    ProductName="Tã quần Bobby size XL 62 miếng (12 - 17 kg)",
                    Price = 243400,
                    PriceOld = 304000,
                    Image = "/img/BimTa/bobby/2.jpg",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5kg - 10kg",Size = "S"
                },
                new Product
                {
                    ProductID = 3,
                    ProductName="Tã quần Bobby size L 68 miếng (9 - 13 kg)",
                    Price = 143400,
                    PriceOld = 204000,
                    Image = "/img/BimTa/bobby/3.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 4,
                    ProductName="Tã quần Bobby size XXL 56 miếng (15 - 25 kg)",
                    Price = 323100,
                    PriceOld = 359000,
                    Image = "/img/BimTa/bobby/4.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 5,
                    ProductName="Tã quần Bobby Extra Soft-Dry size L 52 miếng (9 - 13 kg)",
                    Price = 291500,
                    PriceOld = 304000,
                    Image = "/img/BimTa/bobby/5.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 6,
                    ProductName="Tã quần Bobby Extra Soft-Dry size XXL 42 miếng (Trên 16 kg)",
                    Price = 2915000,
                    PriceOld = 434000,
                    Image = "/img/BimTa/bobby/6.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 7,
                    ProductName="Tã quần Bobby Extra Soft-Dry size M 60 miếng (6 - 11 kg)",
                    Price = 291500,
                    PriceOld = 343000,
                    Image = "/img/BimTa/bobby/7.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 8,
                    ProductName="Tã dán Bobby siêu mỏng size XXL 56 miếng (Trên 16 kg)",
                    Price = 289000,
                    PriceOld = 340000,
                    Image = "/img/BimTa/bobby/8.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 9,
                    ProductName="Tã quần Bobby size M 76 miếng (6 - 11 kg)",
                    Price = 278000,
                    PriceOld = 504000,
                    Image = "/img/BimTa/bobby/9.jpg",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 10,
                    ProductName="Tã quần Bobby Extra Soft-Dry size XL 46 miếng (12 - 17 kg)",
                    Price = 274400,
                    PriceOld = 344000,
                    Image = "/img/BimTa/bobby/10.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 11,
                    ProductName="Tã quần Bobby size M 76 miếng (6 - 11 kg)",
                    Price = 278000,
                    PriceOld = 504000,
                    Image = "/img/BimTa/bobby/9.jpg",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 12,
                    ProductName="Tã quần Bobby Extra Soft-Dry size XL 46 miếng (12 - 17 kg)",
                    Price = 274400,
                    PriceOld = 344000,
                    Image = "/img/BimTa/bobby/10.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },

                //Huggies
                new Product
                {
                    ProductID = 11,
                    ProductName="Tã quần Huggies Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 342400,
                    PriceOld = 380000,
                    Image = "/img/BimTa/huggies/11.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 12,
                    ProductName="Tã quần Huggies Dry size XXL 56 miếng (Trên 15 kg)",
                    Price = 342400,
                    PriceOld = 380000,
                    Image = "/img/BimTa/huggies/12.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 13,
                    ProductName="Tã quần Huggies Dry size L",
                    Price = 442400,
                    PriceOld = 580000,
                    Image = "/img/BimTa/huggies/13.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 14,
                    ProductName="Tã quần Huggies Platinum nature made siêu cao cấp size L 44 miếng (9 - 14 kg)",
                    Price = 337500,
                    PriceOld = 375000,
                    Image = "/img/BimTa/huggies/14.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 15,
                    ProductName="Tã dán Huggies Platinum nature made siêu cao cấp size L 54 miếng (9 - 14 kg)",
                    Price = 618000,
                    PriceOld = 780000,
                    Image = "/img/BimTa/huggies/15.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 16,
                    ProductName="Tã dán Huggies Platinum nature made siêu cao cấp size NB 60 miếng (Dưới 5 kg)",
                    Price = 189900,
                    PriceOld = 211000,
                    Image = "/img/BimTa/huggies/16.jpg",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 17,
                    ProductName="Tã lót Huggies size NB2 60 miếng (4 - 7 kg)",
                    Price = 94300,
                    PriceOld = 111000,
                    Image = "/img/BimTa/huggies/17.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 18,
                    ProductName="Tã dán Huggies Dry size S 56 miếng (4 - 8 kg)",
                    Price = 242400,
                    PriceOld = 380000,
                    Image = "/img/BimTa/huggies/18.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 19,
                    ProductName="Tã quần Huggies Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 842400,
                    PriceOld = 980000,
                    Image = "/img/BimTa/huggies/19.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 20,
                    ProductName="Tã quần Huggies Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 1042400,
                    PriceOld = 1180000,
                    Image = "/img/BimTa/huggies/20.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 11,
                    ProductName="Tã quần Huggies Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 342400,
                    PriceOld = 380000,
                    Image = "/img/BimTa/huggies/11.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 12,
                    ProductName="Tã quần Huggies Dry size XXL 56 miếng (Trên 15 kg)",
                    Price = 342400,
                    PriceOld = 380000,
                    Image = "/img/BimTa/huggies/12.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 13,
                    ProductName="Tã quần Huggies Dry size L",
                    Price = 442400,
                    PriceOld = 580000,
                    Image = "/img/BimTa/huggies/13.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 14,
                    ProductName="Tã quần Huggies Platinum nature made siêu cao cấp size L 44 miếng (9 - 14 kg)",
                    Price = 337500,
                    PriceOld = 375000,
                    Image = "/img/BimTa/huggies/14.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 15,
                    ProductName="Tã dán Huggies Platinum nature made siêu cao cấp size L 54 miếng (9 - 14 kg)",
                    Price = 618000,
                    PriceOld = 780000,
                    Image = "/img/BimTa/huggies/15.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 16,
                    ProductName="Tã dán Huggies Platinum nature made siêu cao cấp size NB 60 miếng (Dưới 5 kg)",
                    Price = 189900,
                    PriceOld = 211000,
                    Image = "/img/BimTa/huggies/16.jpg",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 17,
                    ProductName="Tã lót Huggies size NB2 60 miếng (4 - 7 kg)",
                    Price = 94300,
                    PriceOld = 111000,
                    Image = "/img/BimTa/huggies/17.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 18,
                    ProductName="Tã dán Huggies Dry size S 56 miếng (4 - 8 kg)",
                    Price = 242400,
                    PriceOld = 380000,
                    Image = "/img/BimTa/huggies/18.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 19,
                    ProductName="Tã quần Huggies Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 842400,
                    PriceOld = 980000,
                    Image = "/img/BimTa/huggies/19.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 20,
                    ProductName="Tã quần Huggies Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 1042400,
                    PriceOld = 1180000,
                    Image = "/img/BimTa/huggies/20.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },

                //moony
                new Product
                {
                    ProductID = 21,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 378000,
                    PriceOld = 445000,
                    Image = "/img/BimTa/moony/21.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 22,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 578000,
                    PriceOld = 645000,
                    Image = "/img/BimTa/moony/22.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 23,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 778000,
                    PriceOld = 845000,
                    Image = "/img/BimTa/moony/23.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 24,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 978000,
                    PriceOld = 999000,
                    Image = "/img/BimTa/moony/24.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 25,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 278000,
                    PriceOld = 345000,
                    Image = "/img/BimTa/moony/25.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 26,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 878000,
                    PriceOld = 945000,
                    Image = "/img/BimTa/moony/26.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 27,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 778000,
                    PriceOld = 945000,
                    Image = "/img/BimTa/moony/27.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 28,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 278000,
                    PriceOld = 545000,
                    Image = "/img/BimTa/moony/28.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 29,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 178000,
                    PriceOld = 195000,
                    Image = "/img/BimTa/moony/29.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 30,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 1878000,
                    PriceOld = 1445000,
                    Image = "/img/BimTa/moony/30.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 21,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 378000,
                    PriceOld = 445000,
                    Image = "/img/BimTa/moony/21.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 22,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 578000,
                    PriceOld = 645000,
                    Image = "/img/BimTa/moony/22.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 23,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 778000,
                    PriceOld = 845000,
                    Image = "/img/BimTa/moony/23.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 24,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 978000,
                    PriceOld = 999000,
                    Image = "/img/BimTa/moony/24.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 25,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 278000,
                    PriceOld = 345000,
                    Image = "/img/BimTa/moony/25.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 26,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 878000,
                    PriceOld = 945000,
                    Image = "/img/BimTa/moony/26.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 27,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 778000,
                    PriceOld = 945000,
                    Image = "/img/BimTa/moony/27.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 28,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 278000,
                    PriceOld = 545000,
                    Image = "/img/BimTa/moony/28.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 29,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 178000,
                    PriceOld = 195000,
                    Image = "/img/BimTa/moony/29.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 30,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 1878000,
                    PriceOld = 1445000,
                    Image = "/img/BimTa/moony/30.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 29,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 178000,
                    PriceOld = 195000,
                    Image = "/img/BimTa/moony/29.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 30,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 1878000,
                    PriceOld = 1445000,
                    Image = "/img/BimTa/moony/30.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },

                //Bobby
                new Product
                {
                    ProductID = 1,
                    ProductName="Tã quần Bobby size M 76 miếng (6 - 11 kg)",
                    Price = 343400,
                    PriceOld = 404000,
                    Image = "/img/BimTa/bobby/1.jpg",
                    Trademark = "Bobby",
                    TypeDiapers = "Miếng lót sơ sinh",
                    WeighDiapers = "Dưới 5kg",
                    Size = "NB"
                },
                new Product
                {
                    ProductID = 2,
                    ProductName="Tã quần Bobby size XL 62 miếng (12 - 17 kg)",
                    Price = 243400,
                    PriceOld = 304000,
                    Image = "/img/BimTa/bobby/2.jpg",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5kg - 10kg",Size = "S"
                },
                new Product
                {
                    ProductID = 3,
                    ProductName="Tã quần Bobby size L 68 miếng (9 - 13 kg)",
                    Price = 143400,
                    PriceOld = 204000,
                    Image = "/img/BimTa/bobby/3.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 4,
                    ProductName="Tã quần Bobby size XXL 56 miếng (15 - 25 kg)",
                    Price = 323100,
                    PriceOld = 359000,
                    Image = "/img/BimTa/bobby/4.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 5,
                    ProductName="Tã quần Bobby Extra Soft-Dry size L 52 miếng (9 - 13 kg)",
                    Price = 291500,
                    PriceOld = 304000,
                    Image = "/img/BimTa/bobby/5.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 6,
                    ProductName="Tã quần Bobby Extra Soft-Dry size XXL 42 miếng (Trên 16 kg)",
                    Price = 2915000,
                    PriceOld = 434000,
                    Image = "/img/BimTa/bobby/6.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 7,
                    ProductName="Tã quần Bobby Extra Soft-Dry size M 60 miếng (6 - 11 kg)",
                    Price = 291500,
                    PriceOld = 343000,
                    Image = "/img/BimTa/bobby/7.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 8,
                    ProductName="Tã dán Bobby siêu mỏng size XXL 56 miếng (Trên 16 kg)",
                    Price = 289000,
                    PriceOld = 340000,
                    Image = "/img/BimTa/bobby/8.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 9,
                    ProductName="Tã quần Bobby size M 76 miếng (6 - 11 kg)",
                    Price = 278000,
                    PriceOld = 504000,
                    Image = "/img/BimTa/bobby/9.jpg",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 10,
                    ProductName="Tã quần Bobby Extra Soft-Dry size XL 46 miếng (12 - 17 kg)",
                    Price = 274400,
                    PriceOld = 344000,
                    Image = "/img/BimTa/bobby/10.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 11,
                    ProductName="Tã quần Bobby size M 76 miếng (6 - 11 kg)",
                    Price = 278000,
                    PriceOld = 504000,
                    Image = "/img/BimTa/bobby/9.jpg",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 12,
                    ProductName="Tã quần Bobby Extra Soft-Dry size XL 46 miếng (12 - 17 kg)",
                    Price = 274400,
                    PriceOld = 344000,
                    Image = "/img/BimTa/bobby/10.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 1,
                    ProductName="Tã quần Bobby size M 76 miếng (6 - 11 kg)",
                    Price = 343400,
                    PriceOld = 404000,
                    Image = "/img/BimTa/bobby/1.jpg",
                    Trademark = "Bobby",
                    TypeDiapers = "Miếng lót sơ sinh",
                    WeighDiapers = "Dưới 5kg",
                    Size = "NB"
                },
                new Product
                {
                    ProductID = 2,
                    ProductName="Tã quần Bobby size XL 62 miếng (12 - 17 kg)",
                    Price = 243400,
                    PriceOld = 304000,
                    Image = "/img/BimTa/bobby/2.jpg",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5kg - 10kg",Size = "S"
                },
                new Product
                {
                    ProductID = 3,
                    ProductName="Tã quần Bobby size L 68 miếng (9 - 13 kg)",
                    Price = 143400,
                    PriceOld = 204000,
                    Image = "/img/BimTa/bobby/3.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 4,
                    ProductName="Tã quần Bobby size XXL 56 miếng (15 - 25 kg)",
                    Price = 323100,
                    PriceOld = 359000,
                    Image = "/img/BimTa/bobby/4.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 5,
                    ProductName="Tã quần Bobby Extra Soft-Dry size L 52 miếng (9 - 13 kg)",
                    Price = 291500,
                    PriceOld = 304000,
                    Image = "/img/BimTa/bobby/5.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 6,
                    ProductName="Tã quần Bobby Extra Soft-Dry size XXL 42 miếng (Trên 16 kg)",
                    Price = 2915000,
                    PriceOld = 434000,
                    Image = "/img/BimTa/bobby/6.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 7,
                    ProductName="Tã quần Bobby Extra Soft-Dry size M 60 miếng (6 - 11 kg)",
                    Price = 291500,
                    PriceOld = 343000,
                    Image = "/img/BimTa/bobby/7.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 8,
                    ProductName="Tã dán Bobby siêu mỏng size XXL 56 miếng (Trên 16 kg)",
                    Price = 289000,
                    PriceOld = 340000,
                    Image = "/img/BimTa/bobby/8.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 9,
                    ProductName="Tã quần Bobby size M 76 miếng (6 - 11 kg)",
                    Price = 278000,
                    PriceOld = 504000,
                    Image = "/img/BimTa/bobby/9.jpg",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 10,
                    ProductName="Tã quần Bobby Extra Soft-Dry size XL 46 miếng (12 - 17 kg)",
                    Price = 274400,
                    PriceOld = 344000,
                    Image = "/img/BimTa/bobby/10.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 11,
                    ProductName="Tã quần Bobby size M 76 miếng (6 - 11 kg)",
                    Price = 278000,
                    PriceOld = 504000,
                    Image = "/img/BimTa/bobby/9.jpg",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 12,
                    ProductName="Tã quần Bobby Extra Soft-Dry size XL 46 miếng (12 - 17 kg)",
                    Price = 274400,
                    PriceOld = 344000,
                    Image = "/img/BimTa/bobby/10.png",
                    Trademark = "Bobby", TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },

                //Huggies
                new Product
                {
                    ProductID = 11,
                    ProductName="Tã quần Huggies Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 342400,
                    PriceOld = 380000,
                    Image = "/img/BimTa/huggies/11.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 12,
                    ProductName="Tã quần Huggies Dry size XXL 56 miếng (Trên 15 kg)",
                    Price = 342400,
                    PriceOld = 380000,
                    Image = "/img/BimTa/huggies/12.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 13,
                    ProductName="Tã quần Huggies Dry size L",
                    Price = 442400,
                    PriceOld = 580000,
                    Image = "/img/BimTa/huggies/13.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 14,
                    ProductName="Tã quần Huggies Platinum nature made siêu cao cấp size L 44 miếng (9 - 14 kg)",
                    Price = 337500,
                    PriceOld = 375000,
                    Image = "/img/BimTa/huggies/14.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 15,
                    ProductName="Tã dán Huggies Platinum nature made siêu cao cấp size L 54 miếng (9 - 14 kg)",
                    Price = 618000,
                    PriceOld = 780000,
                    Image = "/img/BimTa/huggies/15.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 16,
                    ProductName="Tã dán Huggies Platinum nature made siêu cao cấp size NB 60 miếng (Dưới 5 kg)",
                    Price = 189900,
                    PriceOld = 211000,
                    Image = "/img/BimTa/huggies/16.jpg",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 17,
                    ProductName="Tã lót Huggies size NB2 60 miếng (4 - 7 kg)",
                    Price = 94300,
                    PriceOld = 111000,
                    Image = "/img/BimTa/huggies/17.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 18,
                    ProductName="Tã dán Huggies Dry size S 56 miếng (4 - 8 kg)",
                    Price = 242400,
                    PriceOld = 380000,
                    Image = "/img/BimTa/huggies/18.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 19,
                    ProductName="Tã quần Huggies Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 842400,
                    PriceOld = 980000,
                    Image = "/img/BimTa/huggies/19.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 20,
                    ProductName="Tã quần Huggies Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 1042400,
                    PriceOld = 1180000,
                    Image = "/img/BimTa/huggies/20.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 11,
                    ProductName="Tã quần Huggies Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 342400,
                    PriceOld = 380000,
                    Image = "/img/BimTa/huggies/11.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 12,
                    ProductName="Tã quần Huggies Dry size XXL 56 miếng (Trên 15 kg)",
                    Price = 342400,
                    PriceOld = 380000,
                    Image = "/img/BimTa/huggies/12.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 13,
                    ProductName="Tã quần Huggies Dry size L",
                    Price = 442400,
                    PriceOld = 580000,
                    Image = "/img/BimTa/huggies/13.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 14,
                    ProductName="Tã quần Huggies Platinum nature made siêu cao cấp size L 44 miếng (9 - 14 kg)",
                    Price = 337500,
                    PriceOld = 375000,
                    Image = "/img/BimTa/huggies/14.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 15,
                    ProductName="Tã dán Huggies Platinum nature made siêu cao cấp size L 54 miếng (9 - 14 kg)",
                    Price = 618000,
                    PriceOld = 780000,
                    Image = "/img/BimTa/huggies/15.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 16,
                    ProductName="Tã dán Huggies Platinum nature made siêu cao cấp size NB 60 miếng (Dưới 5 kg)",
                    Price = 189900,
                    PriceOld = 211000,
                    Image = "/img/BimTa/huggies/16.jpg",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 17,
                    ProductName="Tã lót Huggies size NB2 60 miếng (4 - 7 kg)",
                    Price = 94300,
                    PriceOld = 111000,
                    Image = "/img/BimTa/huggies/17.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 18,
                    ProductName="Tã dán Huggies Dry size S 56 miếng (4 - 8 kg)",
                    Price = 242400,
                    PriceOld = 380000,
                    Image = "/img/BimTa/huggies/18.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 19,
                    ProductName="Tã quần Huggies Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 842400,
                    PriceOld = 980000,
                    Image = "/img/BimTa/huggies/19.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 20,
                    ProductName="Tã quần Huggies Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 1042400,
                    PriceOld = 1180000,
                    Image = "/img/BimTa/huggies/20.png",
                    Trademark = "Huggies",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },

                //moony
                new Product
                {
                    ProductID = 21,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 378000,
                    PriceOld = 445000,
                    Image = "/img/BimTa/moony/21.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 22,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 578000,
                    PriceOld = 645000,
                    Image = "/img/BimTa/moony/22.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 23,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 778000,
                    PriceOld = 845000,
                    Image = "/img/BimTa/moony/23.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 24,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 978000,
                    PriceOld = 999000,
                    Image = "/img/BimTa/moony/24.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 25,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 278000,
                    PriceOld = 345000,
                    Image = "/img/BimTa/moony/25.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 26,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 878000,
                    PriceOld = 945000,
                    Image = "/img/BimTa/moony/26.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 27,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 778000,
                    PriceOld = 945000,
                    Image = "/img/BimTa/moony/27.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 28,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 278000,
                    PriceOld = 545000,
                    Image = "/img/BimTa/moony/28.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 29,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 178000,
                    PriceOld = 195000,
                    Image = "/img/BimTa/moony/29.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 30,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 1878000,
                    PriceOld = 1445000,
                    Image = "/img/BimTa/moony/30.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 21,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 378000,
                    PriceOld = 445000,
                    Image = "/img/BimTa/moony/21.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 22,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 578000,
                    PriceOld = 645000,
                    Image = "/img/BimTa/moony/22.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 23,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 778000,
                    PriceOld = 845000,
                    Image = "/img/BimTa/moony/23.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 10 - 13kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 24,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 978000,
                    PriceOld = 999000,
                    Image = "/img/BimTa/moony/24.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 25,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 278000,
                    PriceOld = 345000,
                    Image = "/img/BimTa/moony/25.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 26,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 878000,
                    PriceOld = 945000,
                    Image = "/img/BimTa/moony/26.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 27,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 778000,
                    PriceOld = 945000,
                    Image = "/img/BimTa/moony/27.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 28,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 278000,
                    PriceOld = 545000,
                    Image = "/img/BimTa/moony/28.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Từ 5 - 10kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 29,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 178000,
                    PriceOld = 195000,
                    Image = "/img/BimTa/moony/29.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 30,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 1878000,
                    PriceOld = 1445000,
                    Image = "/img/BimTa/moony/30.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 29,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 178000,
                    PriceOld = 195000,
                    Image = "/img/BimTa/moony/29.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
                new Product
                {
                    ProductID = 30,
                    ProductName="Tã quần Moony Dry size XL 62 miếng (12 - 17 kg)",
                    Price = 1878000,
                    PriceOld = 1445000,
                    Image = "/img/BimTa/moony/30.png",
                    Trademark = "Moony",TypeDiapers = "Miếng lót sơ sinh", WeighDiapers = "Dưới 5kg",Size = "NB"
                },
            };

            Page = 0;
        }
    }


    public class PageModel
    {
        public Product ProductMain { get; set; }
        public List<Product> ProductsList { get; set; }

        public PageModel()
        {
            ProductMain = new Product()
            {
                ProductID = 258122,
                ProductName = "Đồ chơi trạm cảnh sát tuần tra và cứu hỏa biển Lego City 60308 (297 chi tiết)",
                Price = 993200,
                PriceOld = 1399000,
                Image = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-6.jpg",

                Trademark = "Lego (Đan Mạch)",
                Type = new List<TypeList>() {
                    new TypeList
                    {
                        dd = "Đồ chơi bé trai"
                    },
                    new TypeList
                    {
                        dd = "Đồ chơi lắp ráp"
                    }
                },
                Age = 5,
                Material = "Nhựa",
                BoxSize = "38x26x6 cm",
                Weight = 724,
                Note = "Có các chi tiết nhỏ; không dùng cho trẻ dưới 3 tuổi; tránh nguy cơ tiềm ẩn khi trẻ sử dụng sai",
                Manufacturing = "Trung Quốc",

                ThumbnailProduct = new List<ThumbnailList>
                {
                    new ThumbnailList
                    {
                        thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-6.jpg"
                    },
                    new ThumbnailList
                    {
                        thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-8.jpg",
                    },
                    new ThumbnailList
                    {
                        thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-2.jpg",

                    },
                    new ThumbnailList
                    {
                        thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-3.jpg",
                    },
                    new ThumbnailList
                    {
                        thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-4.jpg",
                    },
                    new ThumbnailList
                    {
                        thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-5.jpg"
                    },
                    new ThumbnailList
                    {
                        thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-7.jpg",
                    },
                    new ThumbnailList
                    {
                        thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-9.jpg",
                    }
                }
            };

            ProductsList = new List<Product>()
            {
                new Product
                {
                    ProductID = 2,
                    ProductName = "Đồ chơi xe địa hình cứu hộ Lego City 60301 (157 chi tiết)",
                    Price = 993200,
                    PriceOld = 1399000,
                    Image = "do-choi-xe-dia-hinh-cuu-ho-lego-city-60301-201121-124424-600x600.jpg",
                    Trademark = "Lego (Đan Mạch)",
                    Type = new List<TypeList>() {
                        new TypeList
                        {
                            dd = "Đồ chơi bé trai"
                        },
                        new TypeList
                        {
                            dd = "Đồ chơi lắp ráp"
                        }
                    },
                    Age = 4,
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



    public class ListAllProduct
    {
        public List<Product> AllProduct { get; set; }

        public ListAllProduct()
        {
            AllProduct = new List<Product>()
            {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Đồ chơi trạm cảnh sát tuần tra và cứu hỏa biển Lego City 60308 (297 chi tiết)",
                    Price = 993200,
                    PriceOld = 1399000,
                    Image = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-6.jpg",

                    Trademark = "Lego (Đan Mạch)",
                    Type = new List<TypeList>() {
                        new TypeList
                        {
                            dd = "Đồ chơi bé trai"
                        },
                        new TypeList
                        {
                            dd = "Đồ chơi lắp ráp"
                        }
                    },
                    Age = 5,
                    Material = "Nhựa",
                    BoxSize = "38x26x6 cm",
                    Weight = 724,
                    Note = "Có các chi tiết nhỏ; không dùng cho trẻ dưới 3 tuổi; tránh nguy cơ tiềm ẩn khi trẻ sử dụng sai",
                    Manufacturing = "Trung Quốc",

                    ThumbnailProduct = new List<ThumbnailList>
                    {
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-6.jpg"
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-8.jpg",
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-2.jpg",

                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-3.jpg",
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-4.jpg",
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-5.jpg"
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-7.jpg",
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-9.jpg",
                        }
                    },

                    OtherProductList = new List<Product>
                    {
                        new Product
                        {
                            ProductID = 2,
                            ProductName = "Đồ chơi xe địa hình cứu hộ Lego City 60301 (157 chi tiết)",
                            Price = 993200,
                            PriceOld = 1399000,
                            Image = "do-choi-xe-dia-hinh-cuu-ho-lego-city-60301-201121-124424-600x600.jpg"
                        },
                        new Product
                        {
                            ProductID = 4,
                            ProductName="Đồ chơi trạm rửa xe thông minh Hot Wheels FTB66",
                            Price = 998200,
                            PriceOld = 1349000,
                            Image = "do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-181121-105405-600x600.jpg"
                        },
                        new Product
                        {
                            ProductID = 5,
                            ProductName="Đồ chơi phi cơ chiến đấu của Cole Lego Ninjago 71736 (449 chi tiết)",
                            Price = 1002400,
                            PriceOld = 1319000,
                            Image = "do-choi-phi-co-chien-dau-cua-cole-lego-ninjago-71736-070322-111209-600x600.jpg"
                        },
                        new Product
                        {
                            ProductID = 6,
                            ProductName="Đồ chơi tàu chiến hạm bay Bounty Lego Ninjago 71749 (147 chi tiết)",
                            Price = 1000200,
                            PriceOld = 1299000,
                            Image = "do-choi-tau-chien-ham-bay-bounty-lego-ninjago-71749-070322-110850-600x600.jpg"
                        },
                        new Product
                        {
                            ProductID = 7,
                            ProductName="Đồ chơi cắm trại ngoài trời Lego Friends 41392LG (241 chi tiết)",
                            Price = 1039200,
                            PriceOld = 1269000,
                            Image = "do-choi-cam-trai-ngoai-troi-lego-friends-41392lg-130322-112928-600x600.jpg"
                        },
                        new Product
                        {
                            ProductID = 3,
                            ProductName="Đồ chơi trạm rửa xe thông minh Hot Wheels FTB66",
                            Price = 998200,
                            PriceOld = 1349000,
                            Image = "do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-181121-105405-600x600.jpg"
                        }
                    },

                    Highlights = new List<Highlight>
                    {
                        new Highlight
                        {
                            highlight = "Đồ chơi trạm cảnh sát tuần tra và cứu hỏa biển Lego City 60308 bao gồm 297 chi tiết."
                        },
                        new Highlight
                        {
                            highlight = "Bé có thể sáng tạo và tưởng tượng câu chuyện của mình."
                        },
                        new Highlight
                        {
                            highlight = "Đồ chơi lắp ráp giúp rèn luyện tính rỉ mỉ, sáng tạo của bé khi lắp ráp."
                        },
                        new Highlight
                        {
                            highlight = "Đồ chơi Lego City không có góc nhọn, thành phần độc hại nên an toàn cho bé."
                        }
                    },

                    Manuals = new List<Manual>
                    {
                        new Manual
                        {
                            manual = "Đồ chơi không dùng pin."
                        },
                        new Manual
                        {
                            manual = "Lắp ráp các khớp nối với nhau theo hình trên bao bì."
                        },
                        new Manual
                        {
                            manual = "Có thể sáng tạo theo trí tưởng tượng của bé."
                        }
                    }
                },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Đồ chơi xe địa hình cứu hộ Lego City 60301 (157 chi tiết)",
                    Price = 993200,
                    PriceOld = 1399000,
                    Image = "do-choi-xe-dia-hinh-cuu-ho-lego-city-60301-201121-124424-600x600.jpg",

                    Trademark = "Lego (Đan Mạch)",
                    Type = new List<TypeList>() {
                        new TypeList
                        {
                            dd = "Đồ chơi bé trai"
                        },
                        new TypeList
                        {
                            dd = "Đồ chơi lắp ráp"
                        }
                    },
                    Age = 4,
                    Material = "Nhựa",
                    BoxSize = "38x26x6 cm",
                    Weight = 724,
                    Note = "Có các chi tiết nhỏ; không dùng cho trẻ dưới 3 tuổi; tránh nguy cơ tiềm ẩn khi trẻ sử dụng sai",
                    Manufacturing = "Trung Quốc",

                    ThumbnailProduct = new List<ThumbnailList>
                    {
                        new ThumbnailList
                        {
                            thumb = "do-choi-xe-dia-hinh-cuu-ho-lego-city-60301-201121-124424-600x600.jpg"
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-xe-dia-hinh-cuu-ho-lego-city-60301-201121-124424-600x600 (2).jpg"
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-xe-dia-hinh-cuu-ho-lego-city-60301-201121-124424-600x600 (3).jpg"

                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-xe-dia-hinh-cuu-ho-lego-city-60301-201121-124424-600x600 (4).jpg"
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-xe-dia-hinh-cuu-ho-lego-city-60301-201121-124424-600x600 (5).jpg"
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-5.jpg"
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-7.jpg",
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-9.jpg",
                        }
                    },

                    OtherProductList = new List<Product>
                    {
                        new Product
                        {
                            ProductID = 2,
                            ProductName = "Đồ chơi xe địa hình cứu hộ Lego City 60301 (157 chi tiết)",
                            Price = 993200,
                            PriceOld = 1399000,
                            Image = "do-choi-xe-dia-hinh-cuu-ho-lego-city-60301-201121-124424-600x600.jpg"
                        },
                        new Product
                        {
                            ProductID = 4,
                            ProductName="Đồ chơi trạm rửa xe thông minh Hot Wheels FTB66",
                            Price = 998200,
                            PriceOld = 1349000,
                            Image = "do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-181121-105405-600x600.jpg"
                        },
                        new Product
                        {
                            ProductID = 5,
                            ProductName="Đồ chơi phi cơ chiến đấu của Cole Lego Ninjago 71736 (449 chi tiết)",
                            Price = 1002400,
                            PriceOld = 1319000,
                            Image = "do-choi-phi-co-chien-dau-cua-cole-lego-ninjago-71736-070322-111209-600x600.jpg"
                        },
                        new Product
                        {
                            ProductID = 6,
                            ProductName="Đồ chơi tàu chiến hạm bay Bounty Lego Ninjago 71749 (147 chi tiết)",
                            Price = 1000200,
                            PriceOld = 1299000,
                            Image = "do-choi-tau-chien-ham-bay-bounty-lego-ninjago-71749-070322-110850-600x600.jpg"
                        },
                        new Product
                        {
                            ProductID = 7,
                            ProductName="Đồ chơi cắm trại ngoài trời Lego Friends 41392LG (241 chi tiết)",
                            Price = 1039200,
                            PriceOld = 1269000,
                            Image = "do-choi-cam-trai-ngoai-troi-lego-friends-41392lg-130322-112928-600x600.jpg"
                        },
                        new Product
                        {
                            ProductID = 1,
                            ProductName="Đồ chơi trạm cảnh sát tuần tra và cứu hỏa biển Lego City 60308 (297 chi tiết)",
                            Price = 993200,
                            PriceOld = 1399000,
                            Image = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-6.jpg"
                        }
                    },

                    Highlights = new List<Highlight>
                    {
                        new Highlight
                        {
                            highlight = "Đồ chơi xe địa hình cứu hộ Lego City 60301 bao gồm 157 chi tiết."
                        },
                        new Highlight
                        {
                            highlight = "Đồ chơi giúp bé khám phá các bộ phận của xe địa hình cứu hộ."
                        },
                        new Highlight
                        {
                            highlight = "Đồ chơi lắp ráp giúp rèn luyện tính rỉ mỉ, sáng tạo của bé khi lắp ráp."
                        },
                        new Highlight
                        {
                            highlight = "Đồ chơi Lego City không có góc nhọn, thành phần độc hại nên an toàn cho bé."
                        }
                    },

                    Manuals = new List<Manual>
                    {
                        new Manual
                        {
                            manual = "Lắp ráp các khớp nối với nhau theo hình trên bao bì."
                        },
                        new Manual
                        {
                            manual = "Có thể sáng tạo theo trí tưởng tượng của bé."
                        }
                    }
                },
                new Product
                {
                    ProductID = 3,
                    ProductName="Đồ chơi trạm rửa xe thông minh Hot Wheels FTB66",
                    Price = 998200,
                    PriceOld = 1349000,
                    Image = "do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-181121-105405-600x600.jpg",

                    Trademark = "Lego (Đan Mạch)",
                    Type = new List<TypeList>() {
                        new TypeList
                        {
                            dd = "Đồ chơi bé trai"
                        },
                        new TypeList
                        {
                            dd = "Đồ chơi nhập vai"
                        }
                    },
                    Age = 4,
                    Material = "Nhựa",
                    BoxSize = "38x26x6 cm",
                    Weight = 724,
                    Note = "Có các chi tiết nhỏ; không dùng cho trẻ dưới 3 tuổi; tránh nguy cơ tiềm ẩn khi trẻ sử dụng sai",
                    Manufacturing = "Trung Quốc",

                    ThumbnailProduct = new List<ThumbnailList>
                    {
                        new ThumbnailList
                        {
                            thumb = "do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-181121-105405-600x600.jpg"
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-181121-105405-600x600 (2).jpg",
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-181121-105405-600x600 (3).jpg",

                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-181121-105405-600x600 (4).jpg",
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-181121-105405-600x600 (5).jpg",
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-5.jpg"
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-7.jpg",
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-9.jpg",
                        }
                    },

                    OtherProductList = new List<Product>
                    {
                        new Product
                        {
                            ProductID = 2,
                            ProductName = "Đồ chơi xe địa hình cứu hộ Lego City 60301 (157 chi tiết)",
                            Price = 993200,
                            PriceOld = 1399000,
                            Image = "do-choi-xe-dia-hinh-cuu-ho-lego-city-60301-201121-124424-600x600.jpg",
                        },
                        new Product
                        {
                            ProductID = 4,
                            ProductName="Đồ chơi thùng gạch sáng tạo Lego Duplo 10913 (65 chi tiết)",
                            Price = 1002400,
                            PriceOld = 1319000,
                            Image = "do-choi-thung-gach-duplo-sang-tao-lego-duplo-10913-070322-100629-600x600.jpg"
                        },
                        new Product
                        {
                            ProductID = 5,
                            ProductName="Đồ chơi phi cơ chiến đấu của Cole Lego Ninjago 71736 (449 chi tiết)",
                            Price = 1002400,
                            PriceOld = 1319000,
                            Image = "do-choi-phi-co-chien-dau-cua-cole-lego-ninjago-71736-070322-111209-600x600.jpg"
                        },
                        new Product
                        {
                            ProductID = 6,
                            ProductName="Đồ chơi tàu chiến hạm bay Bounty Lego Ninjago 71749 (147 chi tiết)",
                            Price = 1000200,
                            PriceOld = 1299000,
                            Image = "do-choi-tau-chien-ham-bay-bounty-lego-ninjago-71749-070322-110850-600x600.jpg"
                        },
                        new Product
                        {
                            ProductID = 7,
                            ProductName="Đồ chơi cắm trại ngoài trời Lego Friends 41392LG (241 chi tiết)",
                            Price = 1039200,
                            PriceOld = 1269000,
                            Image = "do-choi-cam-trai-ngoai-troi-lego-friends-41392lg-130322-112928-600x600.jpg"
                        },
                        new Product
                        {
                            ProductID = 1,
                            ProductName="Đồ chơi trạm cảnh sát tuần tra và cứu hỏa biển Lego City 60308 (297 chi tiết)",
                            Price = 993200,
                            PriceOld = 1399000,
                            Image = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-6.jpg"
                        }
                    },

                    Highlights = new List<Highlight>
                    {
                        new Highlight
                        {
                            highlight = "Đồ chơi trạm rửa xe thông minh Hot Wheels FTB66 trang bị đầy đủ các tính năng rửa xe sống động."
                        },
                        new Highlight
                        {
                            highlight = "Đồ chơi Hot Wheels có thể kết hợp với nhiều mô hình khác giúp bé khám phá thế giới"
                        },
                        new Highlight
                        {
                            highlight = "Đồ chơi vận động không có góc nhọn, thành phần độc hại nên an toàn cho bé."
                        }
                    },

                    Manuals = new List<Manual>
                    {
                        new Manual
                        {
                            manual = "Đồ chơi dùng để chơi và trưng bày."
                        }
                    }
                },
                new Product
                {
                    ProductID = 4,
                    ProductName="Đồ chơi thùng gạch sáng tạo Lego Duplo 10913 (65 chi tiết)",
                    Price = 1002400,
                    PriceOld = 1319000,
                    Image = "do-choi-thung-gach-duplo-sang-tao-lego-duplo-10913-070322-100629-600x600.jpg",

                    Trademark = "Lego (Đan Mạch)",
                    Type = new List<TypeList>() {
                        new TypeList
                        {
                            dd = "Đồ chơi bé trai"
                        },
                        new TypeList
                        {
                            dd = "Đồ chơi bé gái"
                        },
                        new TypeList
                        {
                            dd = "Đồ chơi lắp ráp"
                        }
                    },
                    Age = 1.5,
                    Material = "Nhựa",
                    BoxSize = "38x26x6 cm",
                    Weight = 1046,
                    Note = "Chỉ thích hợp cho trẻ em từ 1.5 tuổi trở lên",
                    Manufacturing = "Trung Quốc",

                    ThumbnailProduct = new List<ThumbnailList>
                    {
                        new ThumbnailList
                        {
                            thumb = "do-choi-thung-gach-duplo-sang-tao-lego-duplo-10913-070322-100629-600x600.jpg"
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-thung-gach-duplo-sang-tao-lego-duplo-10913-070322-100629-600x600 (2).jpg",
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-thung-gach-duplo-sang-tao-lego-duplo-10913-070322-100629-600x600 (3).jpg",

                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-thung-gach-duplo-sang-tao-lego-duplo-10913-070322-100629-600x600 (4).jpg",
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-thung-gach-duplo-sang-tao-lego-duplo-10913-070322-100629-600x600 (5).jpg",
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-thung-gach-duplo-sang-tao-lego-duplo-10913-070322-100629-600x600 (6).jpg"
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-5.jpg"
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-7.jpg",
                        }
                    },

                    OtherProductList = new List<Product>
                    {
                        new Product
                        {
                            ProductID = 2,
                            ProductName = "Đồ chơi xe địa hình cứu hộ Lego City 60301 (157 chi tiết)",
                            Price = 993200,
                            PriceOld = 1399000,
                            Image = "do-choi-xe-dia-hinh-cuu-ho-lego-city-60301-201121-124424-600x600.jpg",
                        },
                        new Product
                        {
                            ProductID = 3,
                            ProductName="Đồ chơi trạm rửa xe thông minh Hot Wheels FTB66",
                            Price = 998200,
                            PriceOld = 1349000,
                            Image = "do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-181121-105405-600x600.jpg"
                        },
                        new Product
                        {
                            ProductID = 5,
                            ProductName="Đồ chơi phi cơ chiến đấu của Cole Lego Ninjago 71736 (449 chi tiết)",
                            Price = 1002400,
                            PriceOld = 1319000,
                            Image = "do-choi-phi-co-chien-dau-cua-cole-lego-ninjago-71736-070322-111209-600x600.jpg"
                        },
                        new Product
                        {
                            ProductID = 6,
                            ProductName="Đồ chơi tàu chiến hạm bay Bounty Lego Ninjago 71749 (147 chi tiết)",
                            Price = 1000200,
                            PriceOld = 1299000,
                            Image = "do-choi-tau-chien-ham-bay-bounty-lego-ninjago-71749-070322-110850-600x600.jpg"
                        },
                        new Product
                        {
                            ProductID = 7,
                            ProductName="Đồ chơi cắm trại ngoài trời Lego Friends 41392LG (241 chi tiết)",
                            Price = 1039200,
                            PriceOld = 1269000,
                            Image = "do-choi-cam-trai-ngoai-troi-lego-friends-41392lg-130322-112928-600x600.jpg"
                        },
                        new Product
                        {
                            ProductID = 1,
                            ProductName="Đồ chơi trạm cảnh sát tuần tra và cứu hỏa biển Lego City 60308 (297 chi tiết)",
                            Price = 993200,
                            PriceOld = 1399000,
                            Image = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-6.jpg"
                        }
                    },

                    Highlights = new List<Highlight>
                    {
                        new Highlight
                        {
                            highlight = "Đồ chơi thùng gạch sáng tạo Lego Duplo 10913 bao gồm 65 chi tiết."
                        },
                        new Highlight
                        {
                            highlight = "Đồ chơi học tập giúp bé tập làm quen với các con số"
                        },
                        new Highlight
                        {
                            highlight = "Đồ chơi giúp bé phát triển tư duy, sáng tạo khi chơi."
                        },
                        new Highlight
                        {
                            highlight = "Đồ chơi Lego có các góc được bo tròn an toàn cho bé."
                        }
                    },

                    Manuals = new List<Manual>
                    {
                        new Manual
                        {
                            manual = "Lắp ráp các khớp nối với nhau theo hình trên bao bì."
                        },
                        new Manual
                        {
                            manual = "Có thể sáng tạo theo trí tưởng tượng của bé."
                        }
                    }
                },
                new Product
                {
                    ProductID = 5,
                    ProductName="Đồ chơi phi cơ chiến đấu của Cole Lego Ninjago 71736 (449 chi tiết)",
                    Price = 1000200,
                    PriceOld = 1299000,
                    Image = "do-choi-phi-co-chien-dau-cua-cole-lego-ninjago-71736-070322-111209-600x600.jpg",

                    Trademark = "Lego (Đan Mạch)",
                    Type = new List<TypeList>() {
                        new TypeList
                        {
                            dd = "Đồ chơi bé trai"
                        },
                        new TypeList
                        {
                            dd = "Đồ chơi lắp ráp"
                        }
                    },
                    Age = 4,
                    Material = "Nhựa",
                    BoxSize = "38x26x6 cm",
                    Weight = 724,
                    Note = "Có các chi tiết nhỏ; không dùng cho trẻ dưới 3 tuổi; tránh nguy cơ tiềm ẩn khi trẻ sử dụng sai",
                    Manufacturing = "Trung Quốc",

                    ThumbnailProduct = new List<ThumbnailList>
                    {
                        new ThumbnailList
                        {
                            thumb = "do-choi-phi-co-chien-dau-cua-cole-lego-ninjago-71736-070322-111209-600x600.jpg"
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-8.jpg",
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-2.jpg",

                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-3.jpg",
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-4.jpg",
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-5.jpg"
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-7.jpg",
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-9.jpg",
                        }
                    },

                    OtherProductList = new List<Product>
                    {
                        new Product
                        {
                            ProductID = 2,
                            ProductName = "Đồ chơi xe địa hình cứu hộ Lego City 60301 (157 chi tiết)",
                            Price = 993200,
                            PriceOld = 1399000,
                            Image = "do-choi-xe-dia-hinh-cuu-ho-lego-city-60301-201121-124424-600x600.jpg",
                        },
                        new Product
                        {
                            ProductID = 3,
                            ProductName="Đồ chơi trạm rửa xe thông minh Hot Wheels FTB66",
                            Price = 998200,
                            PriceOld = 1349000,
                            Image = "do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-181121-105405-600x600.jpg"
                        },
                        new Product
                        {
                            ProductID = 4,
                            ProductName="Đồ chơi thùng gạch sáng tạo Lego Duplo 10913 (65 chi tiết)",
                            Price = 1002400,
                            PriceOld = 1319000,
                            Image = "do-choi-thung-gach-duplo-sang-tao-lego-duplo-10913-070322-100629-600x600.jpg"
                        },
                        new Product
                        {
                            ProductID = 6,
                            ProductName="Đồ chơi tàu chiến hạm bay Bounty Lego Ninjago 71749 (147 chi tiết)",
                            Price = 1000200,
                            PriceOld = 1299000,
                            Image = "do-choi-tau-chien-ham-bay-bounty-lego-ninjago-71749-070322-110850-600x600.jpg"
                        },
                        new Product
                        {
                            ProductID = 7,
                            ProductName="Đồ chơi cắm trại ngoài trời Lego Friends 41392LG (241 chi tiết)",
                            Price = 1039200,
                            PriceOld = 1269000,
                            Image = "do-choi-cam-trai-ngoai-troi-lego-friends-41392lg-130322-112928-600x600.jpg"
                        },
                        new Product
                        {
                            ProductID = 1,
                            ProductName="Đồ chơi trạm cảnh sát tuần tra và cứu hỏa biển Lego City 60308 (297 chi tiết)",
                            Price = 993200,
                            PriceOld = 1399000,
                            Image = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-6.jpg"
                        }
                    },

                    Highlights = new List<Highlight>
                    {
                        new Highlight
                        {
                            highlight = "Đồ chơi phi cơ chiến đấu của Cole Lego Ninjago 71736 bao gồm 449 chi tiết."
                        },
                        new Highlight
                        {
                            highlight = "Đồ chơi lắp ráp giúp bé có thể sáng tạo và tưởng tượng câu chuyện của mình."
                        },
                        new Highlight
                        {
                            highlight = "Đồ chơi Lego giúp bé rèn luyện tính rỉ mỉ, sáng tạo khi lắp ráp."
                        },
                        new Highlight
                        {
                            highlight = "Đồ chơi không có góc nhọn, thành phần độc hại nên an toàn cho bé."
                        }
                    },

                    Manuals = new List<Manual>
                    {
                        new Manual
                        {
                            manual = "Lắp ráp các khớp nối với nhau theo hình trên bao bì."
                        },
                        new Manual
                        {
                            manual = "Có thể sáng tạo theo trí tưởng tượng của bé."
                        }
                    }
                },
                new Product
                {
                    ProductID = 6,
                    ProductName="Đồ chơi tàu chiến hạm bay Bounty Lego Ninjago 71749 (147 chi tiết)",
                    Price = 1039200,
                    PriceOld = 1269000,
                    Image = "do-choi-tau-chien-ham-bay-bounty-lego-ninjago-71749-070322-110850-600x600.jpg",

                    Trademark = "Lego (Đan Mạch)",
                    Type = new List<TypeList>() {
                        new TypeList
                        {
                            dd = "Đồ chơi bé trai"
                        },
                        new TypeList
                        {
                            dd = "Đồ chơi lắp ráp"
                        }
                    },
                    Age = 4,
                    Material = "Nhựa",
                    BoxSize = "38x26x6 cm",
                    Weight = 724,
                    Note = "Có các chi tiết nhỏ; không dùng cho trẻ dưới 3 tuổi; tránh nguy cơ tiềm ẩn khi trẻ sử dụng sai",
                    Manufacturing = "Trung Quốc",

                    ThumbnailProduct = new List<ThumbnailList>
                    {
                        new ThumbnailList
                        {
                            thumb = "do-choi-tau-chien-ham-bay-bounty-lego-ninjago-71749-070322-110850-600x600.jpg"
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tau-chien-ham-bay-bounty-lego-ninjago-71749-070322-110850-600x600 (2).jpg",
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tau-chien-ham-bay-bounty-lego-ninjago-71749-070322-110850-600x600 (3).jpg",

                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tau-chien-ham-bay-bounty-lego-ninjago-71749-070322-110850-600x600 (4).jpg",
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tau-chien-ham-bay-bounty-lego-ninjago-71749-070322-110850-600x600 (5).jpg",
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-5.jpg"
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-7.jpg",
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-9.jpg",
                        }
                    },

                    OtherProductList = new List<Product>
                    {
                        new Product
                        {
                            ProductID = 2,
                            ProductName = "Đồ chơi xe địa hình cứu hộ Lego City 60301 (157 chi tiết)",
                            Price = 993200,
                            PriceOld = 1399000,
                            Image = "do-choi-xe-dia-hinh-cuu-ho-lego-city-60301-201121-124424-600x600.jpg",
                        },
                        new Product
                        {
                            ProductID = 3,
                            ProductName="Đồ chơi trạm rửa xe thông minh Hot Wheels FTB66",
                            Price = 998200,
                            PriceOld = 1349000,
                            Image = "do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-181121-105405-600x600.jpg"
                        },
                        new Product
                        {
                            ProductID = 4,
                            ProductName="Đồ chơi thùng gạch sáng tạo Lego Duplo 10913 (65 chi tiết)",
                            Price = 1002400,
                            PriceOld = 1319000,
                            Image = "do-choi-thung-gach-duplo-sang-tao-lego-duplo-10913-070322-100629-600x600.jpg"
                        },
                        new Product
                        {
                            ProductID = 5,
                            ProductName="Đồ chơi phi cơ chiến đấu của Cole Lego Ninjago 71736 (449 chi tiết)",
                            Price = 1000200,
                            PriceOld = 1299000,
                            Image = "do-choi-phi-co-chien-dau-cua-cole-lego-ninjago-71736-070322-111209-600x600.jpg"
                        },
                        new Product
                        {
                            ProductID = 7,
                            ProductName="Đồ chơi cắm trại ngoài trời Lego Friends 41392LG (241 chi tiết)",
                            Price = 1039200,
                            PriceOld = 1269000,
                            Image = "do-choi-cam-trai-ngoai-troi-lego-friends-41392lg-130322-112928-600x600.jpg"
                        },
                        new Product
                        {
                            ProductID = 1,
                            ProductName="Đồ chơi trạm cảnh sát tuần tra và cứu hỏa biển Lego City 60308 (297 chi tiết)",
                            Price = 993200,
                            PriceOld = 1399000,
                            Image = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-6.jpg"
                        }
                    },

                    Highlights = new List<Highlight>
                    {
                        new Highlight
                        {
                            highlight = "Đồ chơi tàu chiến hạm bay Bounty Lego Ninjago 71749 bao gồm 147 chi tiết."
                        },
                        new Highlight
                        {
                            highlight = "Đồ chơi lắp ráp giúp bé có thể sáng tạo và tưởng tượng câu chuyện của mình."
                        },
                        new Highlight
                        {
                            highlight = "Đồ chơi Lego giúp bé rèn luyện tính rỉ mỉ, sáng tạo khi lắp ráp."
                        },
                        new Highlight
                        {
                            highlight = "Đồ chơi không có góc nhọn, thành phần độc hại nên an toàn cho bé."
                        }
                    },

                    Manuals = new List<Manual>
                    {
                        new Manual
                        {
                            manual = "Lắp ráp các khớp nối với nhau theo hình trên bao bì."
                        },
                        new Manual
                        {
                            manual = "Có thể sáng tạo theo trí tưởng tượng của bé."
                        }
                    }
                },
                new Product
                {
                    ProductID = 7,
                    ProductName="Đồ chơi cắm trại ngoài trời Lego Friends 41392LG (241 chi tiết)",
                    Price = 1002500,
                    PriceOld = 1269000,
                    Image = "do-choi-cam-trai-ngoai-troi-lego-friends-41392lg-130322-112928-600x600.jpg",

                    Trademark = "Lego (Đan Mạch)",
                    Type = new List<TypeList>() {
                        new TypeList
                        {
                            dd = "Đồ chơi bé trai"
                        },
                        new TypeList
                        {
                            dd = "Đồ chơi lắp ráp"
                        }
                    },
                    Age = 4,
                    Material = "Nhựa",
                    BoxSize = "38x26x6 cm",
                    Weight = 724,
                    Note = "Có các chi tiết nhỏ; không dùng cho trẻ dưới 3 tuổi; tránh nguy cơ tiềm ẩn khi trẻ sử dụng sai",
                    Manufacturing = "Trung Quốc",

                    ThumbnailProduct = new List<ThumbnailList>
                    {
                        new ThumbnailList
                        {
                            thumb = "do-choi-cam-trai-ngoai-troi-lego-friends-41392lg-130322-112928-600x600.jpg"
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-8.jpg",
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-2.jpg",

                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-3.jpg",
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-4.jpg",
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-5.jpg"
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-7.jpg",
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-9.jpg",
                        }
                    },

                    OtherProductList = new List<Product>
                    {
                        new Product
                        {
                            ProductID = 2,
                            ProductName = "Đồ chơi xe địa hình cứu hộ Lego City 60301 (157 chi tiết)",
                            Price = 993200,
                            PriceOld = 1399000,
                            Image = "do-choi-xe-dia-hinh-cuu-ho-lego-city-60301-201121-124424-600x600.jpg",
                        },
                        new Product
                        {
                            ProductID = 3,
                            ProductName="Đồ chơi trạm rửa xe thông minh Hot Wheels FTB66",
                            Price = 998200,
                            PriceOld = 1349000,
                            Image = "do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-181121-105405-600x600.jpg"


                        },
                        new Product
                        {
                            ProductID = 4,
                            ProductName="Đồ chơi thùng gạch sáng tạo Lego Duplo 10913 (65 chi tiết)",
                            Price = 1002400,
                            PriceOld = 1319000,
                            Image = "do-choi-thung-gach-duplo-sang-tao-lego-duplo-10913-070322-100629-600x600.jpg"
                        },
                        new Product
                        {
                            ProductID = 5,
                            ProductName="Đồ chơi phi cơ chiến đấu của Cole Lego Ninjago 71736 (449 chi tiết)",
                            Price = 1000200,
                            PriceOld = 1299000,
                            Image = "do-choi-phi-co-chien-dau-cua-cole-lego-ninjago-71736-070322-111209-600x600.jpg"
                        },
                        new Product
                        {
                            ProductID = 6,
                            ProductName="Đồ chơi tàu chiến hạm bay Bounty Lego Ninjago 71749 (147 chi tiết)",
                            Price = 1039200,
                            PriceOld = 1269000,
                            Image = "do-choi-tau-chien-ham-bay-bounty-lego-ninjago-71749-070322-110850-600x600.jpg"
                        },
                        new Product
                        {
                            ProductID = 1,
                            ProductName="Đồ chơi trạm cảnh sát tuần tra và cứu hỏa biển Lego City 60308 (297 chi tiết)",
                            Price = 993200,
                            PriceOld = 1399000,
                            Image = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-6.jpg"
                        }
                    },

                    Highlights = new List<Highlight>
                    {
                        new Highlight
                        {
                            highlight = "Đồ chơi cắm trại ngoài trời Lego Friends 41392LG bao gồm 241 chi tiết."
                        },
                        new Highlight
                        {
                            highlight = "Đồ chơi lắp ráp giúp bé có thể sáng tạo và tưởng tượng câu chuyện của mình."
                        },
                        new Highlight
                        {
                            highlight = "Đồ chơi Lego giúp bé rèn luyện tính tỉ mỉ, sáng tạo khi lắp ráp."
                        },
                        new Highlight
                        {
                            highlight = "Đồ chơi không có góc nhọn, thành phần độc hại nên an toàn cho bé."
                        }
                    },

                    Manuals = new List<Manual>
                    {
                        new Manual
                        {
                            manual = "Lắp ráp các khớp nối với nhau theo hình trên bao bì."
                        },
                        new Manual
                        {
                            manual = "Có thể sáng tạo theo trí tưởng tượng của bé."
                        }
                    }
                },
                new Product
                {
                    ProductID = 8,
                    ProductName="Đồ chơi trẻ em: Lắp ráp chiến giáp của lloyd Lego 71757 (57 chi tiết)",
                    Price = 229000,
                    PriceOld = 599000,
                    Image = "loyl-robo.jpg",

                    #region not important
                    Trademark = "Lego (Đan Mạch)",
                    Type = new List<TypeList>() {
                        new TypeList
                        {
                            dd = "Đồ chơi bé trai"
                        },
                        new TypeList
                        {
                            dd = "Đồ chơi lắp ráp"
                        }
                    },
                    Age = 4,
                    Material = "Nhựa",
                    BoxSize = "38x26x6 cm",
                    Weight = 724,
                    Note = "Có các chi tiết nhỏ; không dùng cho trẻ dưới 3 tuổi; tránh nguy cơ tiềm ẩn khi trẻ sử dụng sai",
                    Manufacturing = "Trung Quốc",

                    ThumbnailProduct = new List<ThumbnailList>
                    {
                        new ThumbnailList
                        {
                            thumb = "loyl-robo.jpg"
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-8.jpg",
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-2.jpg",

                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-3.jpg",
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-4.jpg",
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-5.jpg"
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-7.jpg",
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-9.jpg",
                        }
                    },

                    OtherProductList = new List<Product>
                    {
                        new Product
                        {
                            ProductID = 2,
                            ProductName = "Đồ chơi xe địa hình cứu hộ Lego City 60301 (157 chi tiết)",
                            Price = 993200,
                            PriceOld = 1399000,
                            Image = "do-choi-xe-dia-hinh-cuu-ho-lego-city-60301-201121-124424-600x600.jpg",
                        },
                        new Product
                        {
                            ProductID = 3,
                            ProductName="Đồ chơi trạm rửa xe thông minh Hot Wheels FTB66",
                            Price = 998200,
                            PriceOld = 1349000,
                            Image = "do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-181121-105405-600x600.jpg"


                        },
                        new Product
                        {
                            ProductID = 4,
                            ProductName="Đồ chơi thùng gạch sáng tạo Lego Duplo 10913 (65 chi tiết)",
                            Price = 1002400,
                            PriceOld = 1319000,
                            Image = "do-choi-thung-gach-duplo-sang-tao-lego-duplo-10913-070322-100629-600x600.jpg"
                        },
                        new Product
                        {
                            ProductID = 5,
                            ProductName="Đồ chơi phi cơ chiến đấu của Cole Lego Ninjago 71736 (449 chi tiết)",
                            Price = 1000200,
                            PriceOld = 1299000,
                            Image = "do-choi-phi-co-chien-dau-cua-cole-lego-ninjago-71736-070322-111209-600x600.jpg"
                        },
                        new Product
                        {
                            ProductID = 6,
                            ProductName="Đồ chơi tàu chiến hạm bay Bounty Lego Ninjago 71749 (147 chi tiết)",
                            Price = 1039200,
                            PriceOld = 1269000,
                            Image = "do-choi-tau-chien-ham-bay-bounty-lego-ninjago-71749-070322-110850-600x600.jpg"
                        },
                        new Product
                        {
                            ProductID = 1,
                            ProductName="Đồ chơi trạm cảnh sát tuần tra và cứu hỏa biển Lego City 60308 (297 chi tiết)",
                            Price = 993200,
                            PriceOld = 1399000,
                            Image = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-6.jpg"
                        }
                    },

                    Highlights = new List<Highlight>
                    {
                        new Highlight
                        {
                            highlight = "Đồ chơi cắm trại ngoài trời Lego Friends 41392LG bao gồm 241 chi tiết."
                        },
                        new Highlight
                        {
                            highlight = "Đồ chơi lắp ráp giúp bé có thể sáng tạo và tưởng tượng câu chuyện của mình."
                        },
                        new Highlight
                        {
                            highlight = "Đồ chơi Lego giúp bé rèn luyện tính tỉ mỉ, sáng tạo khi lắp ráp."
                        },
                        new Highlight
                        {
                            highlight = "Đồ chơi không có góc nhọn, thành phần độc hại nên an toàn cho bé."
                        }
                    },

                    Manuals = new List<Manual>
                    {
                        new Manual
                        {
                            manual = "Lắp ráp các khớp nối với nhau theo hình trên bao bì."
                        },
                        new Manual
                        {
                            manual = "Có thể sáng tạo theo trí tưởng tượng của bé."
                        }
                    }
                    #endregion
                },
                new Product
                {
                    ProductID = 9,
                    ProductName="Đồ chơi trẻ em: Lắp ráp xe cảnh sát Lego 60312 (94 chi tiết)",
                    Price = 269100,
                    PriceOld = 299000,
                    Image = "police-blue.jpg",

                    #region not important
                    Trademark = "Lego (Đan Mạch)",
                    Type = new List<TypeList>() {
                        new TypeList
                        {
                            dd = "Đồ chơi bé trai"
                        },
                        new TypeList
                        {
                            dd = "Đồ chơi lắp ráp"
                        }
                    },
                    Age = 4,
                    Material = "Nhựa",
                    BoxSize = "38x26x6 cm",
                    Weight = 724,
                    Note = "Có các chi tiết nhỏ; không dùng cho trẻ dưới 3 tuổi; tránh nguy cơ tiềm ẩn khi trẻ sử dụng sai",
                    Manufacturing = "Trung Quốc",

                    ThumbnailProduct = new List<ThumbnailList>
                    {
                        new ThumbnailList
                        {
                            thumb = "police-blue.jpg"
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-8.jpg",
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-2.jpg",

                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-3.jpg",
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-4.jpg",
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-5.jpg"
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-7.jpg",
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-9.jpg",
                        }
                    },

                    OtherProductList = new List<Product>
                    {
                        new Product
                        {
                            ProductID = 2,
                            ProductName = "Đồ chơi xe địa hình cứu hộ Lego City 60301 (157 chi tiết)",
                            Price = 993200,
                            PriceOld = 1399000,
                            Image = "do-choi-xe-dia-hinh-cuu-ho-lego-city-60301-201121-124424-600x600.jpg",
                        },
                        new Product
                        {
                            ProductID = 3,
                            ProductName="Đồ chơi trạm rửa xe thông minh Hot Wheels FTB66",
                            Price = 998200,
                            PriceOld = 1349000,
                            Image = "do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-181121-105405-600x600.jpg"


                        },
                        new Product
                        {
                            ProductID = 4,
                            ProductName="Đồ chơi thùng gạch sáng tạo Lego Duplo 10913 (65 chi tiết)",
                            Price = 1002400,
                            PriceOld = 1319000,
                            Image = "do-choi-thung-gach-duplo-sang-tao-lego-duplo-10913-070322-100629-600x600.jpg"
                        },
                        new Product
                        {
                            ProductID = 5,
                            ProductName="Đồ chơi phi cơ chiến đấu của Cole Lego Ninjago 71736 (449 chi tiết)",
                            Price = 1000200,
                            PriceOld = 1299000,
                            Image = "do-choi-phi-co-chien-dau-cua-cole-lego-ninjago-71736-070322-111209-600x600.jpg"
                        },
                        new Product
                        {
                            ProductID = 6,
                            ProductName="Đồ chơi tàu chiến hạm bay Bounty Lego Ninjago 71749 (147 chi tiết)",
                            Price = 1039200,
                            PriceOld = 1269000,
                            Image = "do-choi-tau-chien-ham-bay-bounty-lego-ninjago-71749-070322-110850-600x600.jpg"
                        },
                        new Product
                        {
                            ProductID = 1,
                            ProductName="Đồ chơi trạm cảnh sát tuần tra và cứu hỏa biển Lego City 60308 (297 chi tiết)",
                            Price = 993200,
                            PriceOld = 1399000,
                            Image = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-6.jpg"
                        }
                    },

                    Highlights = new List<Highlight>
                    {
                        new Highlight
                        {
                            highlight = "Đồ chơi cắm trại ngoài trời Lego Friends 41392LG bao gồm 241 chi tiết."
                        },
                        new Highlight
                        {
                            highlight = "Đồ chơi lắp ráp giúp bé có thể sáng tạo và tưởng tượng câu chuyện của mình."
                        },
                        new Highlight
                        {
                            highlight = "Đồ chơi Lego giúp bé rèn luyện tính tỉ mỉ, sáng tạo khi lắp ráp."
                        },
                        new Highlight
                        {
                            highlight = "Đồ chơi không có góc nhọn, thành phần độc hại nên an toàn cho bé."
                        }
                    },

                    Manuals = new List<Manual>
                    {
                        new Manual
                        {
                            manual = "Lắp ráp các khớp nối với nhau theo hình trên bao bì."
                        },
                        new Manual
                        {
                            manual = "Có thể sáng tạo theo trí tưởng tượng của bé."
                        }
                    }
                    #endregion
                },
                new Product
                {
                    ProductID = 10,
                    ProductName="Đồ chơi câu chuyện phiêu lưu của Belle Lego Disney Princess 43177 (111 chi tiết)",
                    Price = 545200,
                    PriceOld = 699000,
                    Image = "belle-disney.jpg",


                    #region not important
                    Trademark = "Lego (Đan Mạch)",
                    Type = new List<TypeList>() {
                        new TypeList
                        {
                            dd = "Đồ chơi bé trai"
                        },
                        new TypeList
                        {
                            dd = "Đồ chơi lắp ráp"
                        }
                    },
                    Age = 4,
                    Material = "Nhựa",
                    BoxSize = "38x26x6 cm",
                    Weight = 724,
                    Note = "Có các chi tiết nhỏ; không dùng cho trẻ dưới 3 tuổi; tránh nguy cơ tiềm ẩn khi trẻ sử dụng sai",
                    Manufacturing = "Trung Quốc",

                    ThumbnailProduct = new List<ThumbnailList>
                    {
                        new ThumbnailList
                        {
                            thumb = "belle-disney.jpg"
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-8.jpg",
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-2.jpg",

                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-3.jpg",
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-4.jpg",
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-5.jpg"
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-7.jpg",
                        },
                        new ThumbnailList
                        {
                            thumb = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-9.jpg",
                        }
                    },

                    OtherProductList = new List<Product>
                    {
                        new Product
                        {
                            ProductID = 2,
                            ProductName = "Đồ chơi xe địa hình cứu hộ Lego City 60301 (157 chi tiết)",
                            Price = 993200,
                            PriceOld = 1399000,
                            Image = "do-choi-xe-dia-hinh-cuu-ho-lego-city-60301-201121-124424-600x600.jpg",
                        },
                        new Product
                        {
                            ProductID = 3,
                            ProductName="Đồ chơi trạm rửa xe thông minh Hot Wheels FTB66",
                            Price = 998200,
                            PriceOld = 1349000,
                            Image = "do-choi-mo-hinh-tram-rua-xe-thong-minh-tuyet-dinh-hot-wheels-ftb66-181121-105405-600x600.jpg"


                        },
                        new Product
                        {
                            ProductID = 4,
                            ProductName="Đồ chơi thùng gạch sáng tạo Lego Duplo 10913 (65 chi tiết)",
                            Price = 1002400,
                            PriceOld = 1319000,
                            Image = "do-choi-thung-gach-duplo-sang-tao-lego-duplo-10913-070322-100629-600x600.jpg"
                        },
                        new Product
                        {
                            ProductID = 5,
                            ProductName="Đồ chơi phi cơ chiến đấu của Cole Lego Ninjago 71736 (449 chi tiết)",
                            Price = 1000200,
                            PriceOld = 1299000,
                            Image = "do-choi-phi-co-chien-dau-cua-cole-lego-ninjago-71736-070322-111209-600x600.jpg"
                        },
                        new Product
                        {
                            ProductID = 6,
                            ProductName="Đồ chơi tàu chiến hạm bay Bounty Lego Ninjago 71749 (147 chi tiết)",
                            Price = 1039200,
                            PriceOld = 1269000,
                            Image = "do-choi-tau-chien-ham-bay-bounty-lego-ninjago-71749-070322-110850-600x600.jpg"
                        },
                        new Product
                        {
                            ProductID = 1,
                            ProductName="Đồ chơi trạm cảnh sát tuần tra và cứu hỏa biển Lego City 60308 (297 chi tiết)",
                            Price = 993200,
                            PriceOld = 1399000,
                            Image = "do-choi-tram-canh-sat-tuan-tra-cuu-hoa-bien-lego-city-60308-6.jpg"
                        }
                    },

                    Highlights = new List<Highlight>
                    {
                        new Highlight
                        {
                            highlight = "Đồ chơi cắm trại ngoài trời Lego Friends 41392LG bao gồm 241 chi tiết."
                        },
                        new Highlight
                        {
                            highlight = "Đồ chơi lắp ráp giúp bé có thể sáng tạo và tưởng tượng câu chuyện của mình."
                        },
                        new Highlight
                        {
                            highlight = "Đồ chơi Lego giúp bé rèn luyện tính tỉ mỉ, sáng tạo khi lắp ráp."
                        },
                        new Highlight
                        {
                            highlight = "Đồ chơi không có góc nhọn, thành phần độc hại nên an toàn cho bé."
                        }
                    },

                    Manuals = new List<Manual>
                    {
                        new Manual
                        {
                            manual = "Lắp ráp các khớp nối với nhau theo hình trên bao bì."
                        },
                        new Manual
                        {
                            manual = "Có thể sáng tạo theo trí tưởng tượng của bé."
                        }
                    }
                    #endregion
                },
            };
        }
    }


    
}
