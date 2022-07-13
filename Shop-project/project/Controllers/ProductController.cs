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
        public IActionResult Detail(int id)
        {
             Cart cart=GetCart();
            ProductManager productManager = new ProductManager();
            Product product = productManager.GetProductByID(id);
            CategoryManager categoryManager = new CategoryManager();
            List<Category> categories = categoryManager.GetCategory((int)product.CategoryId);
            ViewBag.categoryName=categories[0].CategoryName;
            ViewBag.cart = cart;
            return View(product);
        }
        
    }
}
