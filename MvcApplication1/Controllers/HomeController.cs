using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetBrandsJson()
        {
            var allProducts = Database.GetProducts();
            var result = from p in allProducts
                group p by p.Brand
                into g
                select new {brand = g.Key};
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetCategoriesJson()
        {
            var allProducts = Database.GetProducts();
            var result = from p in allProducts
                group p by p.Category
                into g
                select new {category = g.Key};
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetAgesJson() 
        {
            var allProducts = Database.GetProducts();
            var result = from p in allProducts
                         group p by p.Age
                             into g
                             select new { age = g.Key }; 
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        private string _categoryName = string.Empty;
        private string _brandName = string.Empty;
        private string _age = string.Empty;
        private string _lowerPrice = string.Empty;
        private string _higherPrice = string.Empty;

        public ActionResult GetFirstPage()
        {
            var temp = new ProductQuery()
            {
                PageIndex = 1,
                PageSize = 6,
                Age = _age,
                BrandName = _brandName,
                CategoryName = _categoryName,
                HighPrice = _higherPrice,
                LowPrice = _lowerPrice,
                PaiXu = (short)AscDescEnum.asc
            };

            int totalNum = 0;

            var allProducts = Database.GetPageProducts(temp, out totalNum);
            var result = from p in allProducts
                select new {p.Name, p.Brand, p.Category, p.Age, p.Description, p.Price};
            var tempTotal = Convert.ToInt32(Math.Ceiling((double)(totalNum / 6))) +1;
            var jsonResult = new { total = tempTotal, rows = result };
            return Json(jsonResult, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult GetProductsBySearchSortPage(ProductQuery productQuery)
        {
            int totalNum = 0;
            var allProducts = Database.GetPageProducts(productQuery, out totalNum);

            var result = from p in allProducts
                         select new { p.Name, p.Brand, p.Category, p.Age, p.Description, p.Price };
            var tempTotal = Convert.ToInt32(Math.Ceiling((double)(totalNum / 6))) + 1;
            var jsonResult = new { total = tempTotal, rows = result };
            return Json(jsonResult);
        }

        #region 标签管理测试 后弃用
        public ActionResult Tags()
        {
            return View();
        } 
        #endregion

        #region 预先输入测试
        public ActionResult TypeHead()
        {
            return View();
        }

        public ActionResult GetCitiesJson()
        {
            var result = new List<City>()
            {
                new City(){Id = 1, Name = "青岛",PinYin = "qingdao"},
                new City(){Id = 10, Name = "青山",PinYin = "qingshan"},
                new City(){Id = 11, Name = "青峰",PinYin = "qingfeng"},
                new City(){Id = 2, Name = "武汉",PinYin = "wuhan"},
                new City(){Id = 3, Name = "烟台",PinYin = "yantai"},
                new City(){Id = 4, Name = "哈尔滨",PinYin = "haerbing"},
                new City(){Id = 5, Name = "北京",PinYin = "beijing"},
                new City(){Id = 6, Name = "安阳",PinYin = "angyang"},
                new City(){Id = 7, Name = "长春",PinYin = "changchun"},
                new City(){Id = 8, Name = "东阳",PinYin = "dongyang"},
                new City(){Id = 9, Name = "葛洲坝",PinYin = "gezhoubei"}
            };
            return Json(result, JsonRequestBehavior.AllowGet);
        } 
        #endregion
    }
}
