using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using project.Logics;
using project.Models;

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
                RedirectToAction("list","home");
            }
            account.Name = name;
            account.Mobile=phone;
            account.City = ship_city;
            account.Address = ship_address;
            ViewBag.Account = account;
            OrderManager orderManger = new OrderManager();
            orderManger.addOrder(account, cart);
            clearCart();
            return View("views/Cart/detail.cshtml", cart);
        } 
      

    }

}
