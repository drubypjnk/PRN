using System;
using System.Collections.Generic;

#nullable disable

namespace project.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int ProductId { get; set; }
        public int? CategoryId { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public string Origin { get; set; }
        public string Thumbnail { get; set; }
        public string Describe { get; set; }
        public decimal? OriginalPrice { get; set; }
        public decimal? SalePrice { get; set; }
        public int? UnitInStock { get; set; }
        public int? UnitOnOrder { get; set; }
        public bool? Feature { get; set; }
        public string discount()
        {
            return String.Format("{0:0.##}", 100.0 * Convert.ToDouble((SalePrice / OriginalPrice)));
        }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
