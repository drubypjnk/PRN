using System;
using System.Collections.Generic;

#nullable disable

namespace project.Models
{
    public partial class OrderDetail
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
        public OrderDetail(int orderId, int productId, int? quantity, decimal? price, Order order, Product product)
        {
            OrderId = orderId;
            ProductId = productId;
            Quantity = quantity;
            Price = price;
            Order = order;
            Product = product;
        }

        public OrderDetail(int orderId, int productId, int? quantity, decimal? price, Order order)
        {
            OrderId = orderId;
            ProductId = productId;
            Quantity = quantity;
            Price = price;
            Order = order;
        }

        public OrderDetail()
        {
        }

      
    }
}
