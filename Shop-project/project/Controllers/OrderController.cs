using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using project.Logics;
using project.Models;
using System;
using System.Collections.Generic;

namespace project.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public Cart GetCart()
        {   
            string? json = HttpContext.Session.GetString("cart");
            Cart cart = new Cart();
            if (json != null)
            {
                cart = JsonConvert.DeserializeObject<Cart>(json);
            }
            //refresh lại cart
            cart.refresh();
            return cart;
        }
        private void clearCart()
        {
            Cart cart =GetCart();
            cart.items.Clear();
            string json = JsonConvert.SerializeObject(cart);
            HttpContext.Session.SetString("cart", json);
        }
        private Account getAccount()
        {
            string? json = HttpContext.Session.GetString("account");
            Account account = new Account();
            if (json != null)
            {
                account = JsonConvert.DeserializeObject<Account>(json);
            }
            return account;
        }
        public IActionResult Checkout(string name, string phone,string ship_city, string ship_address)
        {
            Cart cart = GetCart();
            Account account = getAccount();
            if(account == null) //if not login
            {
                TempData["err"] = "access denied!";
              
                RedirectToAction("list","home");
            }
            //check cart 
            bool check = CheckCart(cart);
            if (check == false)
            {
                //set new cart session
                string json = JsonConvert.SerializeObject(cart);
                HttpContext.Session.SetString("cart", json);
                //ViewBag.err = "Your cart have change many item!";
                return RedirectToAction("Detail", "Cart");
            }
            //add note 
           

            account.Name = name;
            account.Mobile=phone;
            account.City = ship_city;
            account.Address = ship_address;
            ViewBag.Account = account;
            OrderManager orderManger = new OrderManager();
             orderManger.addOrder(account, cart);
            clearCart();

            List<Order> list=orderManger.getOrders(account.Username);
            int index=list.Count;
            Order o = list[0];

            Note n = new Note(o.OrderId, DateTime.Now, "Đơn hàng đã được tạo \nchờ xác nhận", account.Username);
            OrderManager orderManager = new OrderManager();
            orderManager.AddNote(n);
            return RedirectToAction("myorder", "user");
            //return View("views/Cart/detail.cshtml", cart);
        }
        [HttpPost] 
         public IActionResult CancelOrder(int order_id)
        {
            Account account = getAccount();
            OrderManager orderManager = new OrderManager();
            orderManager.cancel(order_id);

            Note n = new Note(order_id, DateTime.Now, "Đơn hàng đã bị hủy \n", account.Username);
            orderManager.AddNote(n);

            return RedirectToAction("myorder", "user");
        }

        public IActionResult Update(int order_id,string phone, string name)
        {
            OrderManager orderManager=new OrderManager();
            orderManager.update(order_id, phone, name);
            Account account = getAccount();

            Note n = new Note(order_id, DateTime.Now, "Thông tin đã được cập nhật \nchờ xác nhận", account.Username);
            orderManager.AddNote(n);

            return RedirectToAction("myorder", "user");
        }
        public bool CheckCart(Cart cart)
        {
            bool check = true;
            foreach(Item i in cart.items)
            {
                if (i.quantity > i.Product.UnitInStock)
                {
                    i.quantity = (int)i.Product.UnitInStock;
                    check = false;
                }
            }
            return check;
        }

        [HttpPost]
        public void ChangeOrderStatus( int order_id,int status)
        {
            OrderManager orderManager = new OrderManager();
            orderManager.updateStatus(order_id, status);
        }

    }

}
