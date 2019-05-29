using System.Collections.Generic;

namespace VuePartielleExercice.Models
{
    public class Product
    {
        public string name { get; set; }
        public string description { get; set; }
        public int rating { get; set; }
        public ProductDetail details { get; set; }
    }

    public class ProductDetail
    {
        public string size { get; set; }
        public List<string> availableColors { get; set; }
        public decimal price { get; set; }
    }
}
