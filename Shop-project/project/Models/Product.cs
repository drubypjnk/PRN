using System;
using System.Collections.Generic;

#nullable disable

namespace project.Models
{
    public partial class Product
    {
        public Product()
        {
            Comments = new HashSet<Comment>();
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
        public DateTime? UpdateDate { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public string discount()
        {
            return String.Format("{0:0.##}", 100.0 * Convert.ToDouble((SalePrice / OriginalPrice)));
        }
    }
}
