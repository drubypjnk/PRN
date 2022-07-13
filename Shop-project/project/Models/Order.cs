using System;
using System.Collections.Generic;

#nullable disable

namespace project.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public string Username { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequireDate { get; set; }
        public DateTime? ShipedDate { get; set; }
        public decimal? Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public bool? ShipGender { get; set; }
        public string ShipMobile { get; set; }
        public int? Status { get; set; }
        public decimal? TotalPrice { get; set; }
        public string ShipCity { get; set; }

        public virtual Account UsernameNavigation { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
