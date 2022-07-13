using project.Models;
using System;
using System.Linq;

namespace project.Logics
{
    public class OrderManager
    {
       public Order addOrder(Account a,Cart cart)
        { using (var context = new Shop_PRNContext())
            {

                //add order
                Order order = new Order();
                order.Username = a.Username;
                order.OrderDate = DateTime.Now;
                order.Freight = 0;
                order.ShipCity = a.City;
                order.ShipName = a.Name;
                order.ShipAddress = a.Address;
                order.ShipMobile = a.Mobile;
                order.Status = 1;

                order.TotalPrice = Convert.ToDecimal(cart.GetTotalMoney());
                context.Orders.Add(order);
                //add order detail
                //int orderID = context.Orders.Max(x => x.OrderId) + 1;
                foreach (var item in cart.items)
                {
                    int productID = item.Product.ProductId;
                 OrderDetail od=new OrderDetail(order.OrderId, productID, item.quantity, Convert.ToDecimal(item.price),order);
                    context.OrderDetails.Add(od);
                }
                //update instock
                foreach (var item in cart.items)
                {
                    context.Products.FirstOrDefault(x => x.ProductId == item.Product.ProductId).UnitOnOrder += item.quantity;
                    context.Products.FirstOrDefault(x => x.ProductId == item.Product.ProductId).UnitInStock -= item.quantity;
                }
                    context.SaveChanges();
                return order;
            }
        }
    }
}
