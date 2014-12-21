namespace MvcApplication1.Models
{
    public class ProductQuery : QueryBase
    {
        public string CategoryName { get; set; }
        public string BrandName { get; set; }
        public string Age { get; set; }
        public string LowPrice { get; set; }
        public string HighPrice { get; set; }
    }
}