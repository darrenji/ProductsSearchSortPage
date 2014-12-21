using System.Collections.Generic;
using System.Linq;
using MvcApplication1.Models;

namespace MvcApplication1
{
    public class Database
    {
        public static IEnumerable<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product(){Id = 1, Name = "羽绒服新时尚",Category = "服饰",Brand = "南极人",Age = 1, ImageUrl = "~/images/1.jpg",Price = 85m,Description = "产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述"},
                new Product(){Id = 2, Name = "最新鲜潮货",Category = "服饰",Brand = "初语",Age = 2, ImageUrl = "~/images/2.jpg",Price = 95m,Description = "产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述"},
                new Product(){Id = 3, Name = "新鲜态度",Category = "服饰",Brand = "文艺",Age = 3, ImageUrl = "~/images/3.jpg",Price = 105m,Description = "产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述"},
                new Product(){Id = 4, Name = "儿童保暖内衣",Category = "服饰",Brand = "南极人",Age = 4, ImageUrl = "~/images/4.jpg",Price = 115m,Description = "产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述"},
                new Product(){Id = 5, Name = "韩版蝴蝶结",Category = "服饰",Brand = "南极人",Age = 5, ImageUrl = "~/images/5.jpg",Price = 125m,Description = "产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述"},
                new Product(){Id = 6, Name = "时尚童装加绒",Category = "服饰",Brand = "南极人",Age = 6, ImageUrl = "~/images/6.jpg",Price = 135m,Description = "产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述"},
                new Product(){Id = 7, Name = "棉质儿童短袜",Category = "服饰",Brand = "南极人",Age = 7, ImageUrl = "~/images/7.jpg",Price = 145m,Description = "产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述"},
                new Product(){Id = 8, Name = "灯芯绒打底单裤",Category = "服饰",Brand = "南极人",Age = 8, ImageUrl = "~/images/8.jpg",Price = 155m,Description = "产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述"},
                new Product(){Id = 9, Name = "公主范裤子",Category = "服饰",Brand = "南极人",Age = 9, ImageUrl = "~/images/9.jpg",Price = 165m,Description = "产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述"},
                new Product(){Id = 10, Name = "儿童百搭潮流",Category = "服饰",Brand = "南极人",Age = 10, ImageUrl = "~/images/10.jpg",Price = 175m,Description = "产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述"},
                new Product(){Id = 11, Name = "童装牛仔裤",Category = "服饰",Brand = "南极人",Age = 11, ImageUrl = "~/images/11.jpg",Price = 185m,Description = "产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述"},
                new Product(){Id = 12, Name = "吸汗条纹袜",Category = "服饰",Brand = "南极人",Age = 12, ImageUrl = "~/images/12.jpg",Price = 195m,Description = "产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述"},
                new Product(){Id = 13, Name = "秋衣秋裤",Category = "服饰",Brand = "南极人",Age = 13, ImageUrl = "~/images/13.jpg",Price = 205m,Description = "产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述"},
                new Product(){Id = 14, Name = "全棉棉毛套",Category = "服饰",Brand = "南极人",Age = 14, ImageUrl = "~/images/14.jpg",Price = 215m,Description = "产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述"},
                new Product(){Id = 15, Name = "卡内衣套装",Category = "服饰",Brand = "南极人",Age = 15, ImageUrl = "~/images/15.jpg",Price = 215m,Description = "产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述"},
                new Product(){Id = 16, Name = "保暖内衣套装",Category = "服饰",Brand = "南极人",Age = 16, ImageUrl = "~/images/16.jpg",Price = 225m,Description = "产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述"},
                new Product(){Id = 17, Name = "精纱全棉内衣",Category = "服饰",Brand = "南极人",Age = 17, ImageUrl = "~/images/17.jpg",Price = 235m,Description = "产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述"},

                new Product(){Id = 18, Name = "真我香水EDP",Category = "香水",Brand = "迪奥",Age = 18, ImageUrl = "~/images/18.jpg",Price = 245m,Description = "产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述"},
                new Product(){Id = 19, Name = "晶钻粉钻香恋",Category = "香水",Brand = "范思哲",Age = 19, ImageUrl = "~/images/19.jpg",Price = 255m,Description = "产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述"},
                new Product(){Id = 20, Name = "绿邂逅清新",Category = "香水",Brand = "香奈儿",Age = 20, ImageUrl = "~/images/20.jpg",Price = 235m,Description = "产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述产品描述"}
            };
        }

        public static IEnumerable<Product> GetPageProducts(ProductQuery query, out int total)
        {
            var allProducts = GetProducts();

            if (!string.IsNullOrEmpty(query.BrandName))
            {
                allProducts = allProducts.Where(p => p.Brand == query.BrandName);
            }

            if (!string.IsNullOrEmpty(query.CategoryName))
            {
                allProducts = allProducts.Where(p => p.Category == query.CategoryName);
            }

            if (!string.IsNullOrEmpty(query.Age))
            {
                int intAge = int.Parse(query.Age);
                allProducts = allProducts.Where(p => p.Age == intAge);
            }

            if (!string.IsNullOrEmpty(query.LowPrice) && !string.IsNullOrEmpty(query.HighPrice))
            {
                decimal lowerPrice = decimal.Parse(query.LowPrice);
                decimal higherPrice = decimal.Parse(query.HighPrice);
                allProducts = allProducts.Where(p => p.Price >= lowerPrice && p.Price <= higherPrice); 
            }

            if (!string.IsNullOrEmpty(query.LowPrice) && string.IsNullOrEmpty(query.HighPrice))
            {
                decimal lowerPrice = decimal.Parse(query.LowPrice);
                allProducts = allProducts.Where(p => p.Price <= lowerPrice);
            }

            if (string.IsNullOrEmpty(query.LowPrice) && !string.IsNullOrEmpty(query.HighPrice))
            {
                decimal higherPrice = decimal.Parse(query.HighPrice);
                allProducts = allProducts.Where(p => p.Price >= higherPrice);
            }

            total = allProducts.Count();

            if (query.PaiXu == (short) AscDescEnum.asc)
            {
                allProducts = allProducts
                    .OrderBy(p => p.Price)
                    .Skip(query.PageSize*(query.PageIndex - 1))
                    .Take(query.PageSize);
            }
            else
            {
                allProducts = allProducts
                    .OrderByDescending(p => p.Price)
                    .Skip(query.PageSize * (query.PageIndex - 1))
                    .Take(query.PageSize);
            }

            return allProducts;
        }
    }
}