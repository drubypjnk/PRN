using project.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace project.Logics
{
    public class OrderManager
    {
        public void AddNote(Note note)
        {
            using (var context = new Shop_PRNContext())
            {
                context.Notes.Add(note);
                context.SaveChanges();
            }
        } 
        public List<Note>getNote(int order_id)
        {
            using (var context = new Shop_PRNContext())
            {
                List<Note> notes = context.Notes.Where(x=>x.OrderId==order_id).OrderBy(x=>x.Date).ToList();
                return notes;
            }
        }
        public Order addOrder(Account a, Cart cart)
        {
            using (var context = new Shop_PRNContext())
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
                    OrderDetail od = new OrderDetail(order.OrderId, productID, item.quantity, Convert.ToDecimal(item.price), order);
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

        public List<Order> getOrders(string username)
        {
            List<Order> list =new List<Order>();
            using (var context = new Shop_PRNContext())
            {
                var order = (from o in context.Orders
                             join od in context.OrderDetails on o.OrderId equals od.OrderId
                             join p in context.Products on od.ProductId equals p.ProductId
                             select new
                             {  
                                 o.OrderId,
                                 o.Username
                             }).Where(s=>s.Username== username).Distinct().OrderBy(x=>-x.OrderId).ToList();
                foreach(var o in order)
                {
                    list.Add(getOrder(o.OrderId));

                }
            }
            return list;
        }

        public List<Order> AllOrder()
        {
            List<Order> list = new List<Order>();
            using (var context = new Shop_PRNContext())
            {
                var order = (from o in context.Orders
                             join od in context.OrderDetails on o.OrderId equals od.OrderId
                             join p in context.Products on od.ProductId equals p.ProductId
                             select new
                             {
                                 o.OrderId,
                                 o.Username
                             }).Distinct().OrderByDescending(x=>x.OrderId).ToList();
                foreach (var o in order)
                {
                    list.Add(getOrder(o.OrderId));

                }
            }
            return list;
        }
        public Order getOrder(int id)
        {
            Order order = new Order();
            using (var context = new Shop_PRNContext())
            {
                order = context.Orders.FirstOrDefault(s => s.OrderId == id);
            }
            List<OrderDetail> od = GetOrderDetails(id);
            order.OrderDetails = od;
            return order;
        }
        public List<OrderDetail>GetOrderDetails(int order_id){
            List<OrderDetail> list;
            using (var context = new Shop_PRNContext())
            {
                list= context.OrderDetails.Where(s => s.OrderId == order_id).ToList();
            }
            ProductManager productManager=new ProductManager();
            foreach(OrderDetail orderDetail in list)
            {
                orderDetail.Product= productManager.GetProductByID(orderDetail.ProductId);
            }

            return list;
        }
        
        public void cancel(int id)
        {
            using (var context = new Shop_PRNContext())
            {
                    //set status =0;
                context.Orders.FirstOrDefault(x => x.OrderId == id).Status=0;

                //re plus quantity
                List<OrderDetail>orderDetails=GetOrderDetails(id);
               foreach(OrderDetail od in orderDetails)
                {
                    Product product = context.Products.FirstOrDefault(x => x.ProductId == od.ProductId);
                    product.UnitInStock += od.Quantity;
                    product.UnitOnOrder -= od.Quantity;
                }
                //remove from order details
                //context.OrderDetails.RemoveRange(orderDetails);
                context.SaveChanges();
            }
        }

        public void update(int order_id, string phone, string name)
        {
            using (var context = new Shop_PRNContext())
            {
                Order o=context.Orders.FirstOrDefault(x => x.OrderId == order_id); 
                o.ShipName= name;
                o.ShipMobile = phone;
                context.SaveChanges();
            }
        }
        
        public void updateStatus(int order_id,int status)
        {
            using (var context = new Shop_PRNContext())
            {
                context.Orders.FirstOrDefault(x => x.OrderId == order_id).Status=status;
                context.SaveChanges();
            }
        }
    }
}
