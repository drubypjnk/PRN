using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using project.Logics;
using project.Models;
using System.Collections.Generic;

namespace project.Controllers
{
    public class ProductController : Controller
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
        public Account GetAccountSession()
        {
            //get account session
            Account account;
            string? json = HttpContext.Session.GetString("account");
            if (json != null)
            {
                account = JsonConvert.DeserializeObject<Account>(json);
            }
            else { account = null; }
            return account;
        }
        public IActionResult Detail(int id)
        {   
            Account account = GetAccountSession();
             Cart cart=GetCart();
            ProductManager productManager = new ProductManager();
            Product product = productManager.GetProductByID(id);
            CategoryManager categoryManager = new CategoryManager();
            List<Category> categories = categoryManager.GetCategory((int)product.CategoryId);
            ViewBag.account=account;
            ViewBag.categoryName=categories[0].CategoryName;
            ViewBag.cart = cart;
            return View(product);
        }
        
    }
}
