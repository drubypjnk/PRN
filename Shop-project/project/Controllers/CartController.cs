using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using project.Logics;
using project.Models;
using System;

namespace project.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Detail()
        {
            Cart cart = GetCart();
            //set session
            string json = JsonConvert.SerializeObject(cart);
            HttpContext.Session.SetString("cart", json);
            return View(cart);
        }  
        //public string SetSession(int id)
        //{
        //    ProductManager p = new ProductManager();
        //    Product product = p.GetProductByID(id);
        //    string json=JsonConvert.SerializeObject(product);
        //    HttpContext.Session.SetString("product", json);

        //    //int id = 32;
        //    //HttpContext.Session.SetInt32("id", id);
            
        //    return $"Set Session";
        //}
        //public string ShowSession()
        //{
        //    //int id;
        //    //if(HttpContext.Session.GetInt32("id") is null)
        //    //{
        //    //    id = 0;
        //    //}
        //    //else
        //    //{
        //    //    id=(int)HttpContext.Session.GetInt32("id");
        //    //}
        //    //    return $"ID:{id}";
        //        //pass object
        //    string? json = HttpContext.Session.GetString("product");
        //    Product p = null;
        //    if(json != null)
        //    {
        //        p = JsonConvert.DeserializeObject<Product>(json);
        //    }
        //    return p.ProductName;
        //}
       
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

        public IActionResult AddtoCart(int id,int quantity)
        {
           Cart cart= GetCart();
            ProductManager productManager = new ProductManager();
            Product p= productManager.GetProductByID(id);
            Item item;
            if (p.SalePrice == null) //ko co sale price
            {
             item = new Item(p,quantity,(double)p.OriginalPrice);

            }
            else
            {

             item = new Item(p,quantity,(double)p.SalePrice);
            }
            if(p != null)
            {
                cart.addItem(item);
            }
            //set session
            string json = JsonConvert.SerializeObject(cart);
            HttpContext.Session.SetString("cart", json);
            return View("views/Cart/detail.cshtml",cart);
        }
        public IActionResult Increase(int id,int quantity)
        {
             quantity = 1;
            Cart cart = GetCart();
            ProductManager productManager = new ProductManager();
            Product p = productManager.GetProductByID(id);
            Item item;
            if (p.SalePrice == null) //ko co sale price
            {
                item = new Item(p, quantity, (double)p.OriginalPrice);

            }
            else
            {

                item = new Item(p, quantity, (double)p.SalePrice);
            }
            if (p != null)
            {
                cart.addItem(item);
            }
            //set session
            string json = JsonConvert.SerializeObject(cart);
            HttpContext.Session.SetString("cart", json);
            return View("views/Cart/detail.cshtml", cart);
        } 
        public IActionResult Decrease(int id, int quantity)
        {
             quantity = -1;
            Cart cart = GetCart();
            ProductManager productManager = new ProductManager();
            Product p = productManager.GetProductByID(id);
            Item item;

            if (quantity == -1 && cart.GetQuantityByID(id) <=1) //delete if het san pham trong gio
            {
                cart.RemoveItem(id);
            }
            else
            {
                if (p.SalePrice == null) //ko co sale price
                {
                    item = new Item(p, quantity, (double)p.OriginalPrice);

                }
                else
                {

                    item = new Item(p, quantity, (double)p.SalePrice);
                }
               
                if (p != null)
                {
                    cart.addItem(item);
                }
            }

            //set session
            string json = JsonConvert.SerializeObject(cart);
            HttpContext.Session.SetString("cart", json);
            return View("views/Cart/detail.cshtml", cart);
        }
        public IActionResult Delete(int id)
        {
            Cart cart = GetCart();
            cart.RemoveItem(id);
            //set session
            string json = JsonConvert.SerializeObject(cart);
            HttpContext.Session.SetString("cart", json);
            return View("views/Cart/detail.cshtml", cart);
        }
        public IActionResult Contact()
        {   
            Account a=new Account("dung","Bùi Anh Dũng,","Đại Học FPT","078332391",new DateTime(2001,01,01),"","drubypjnk@gmail.com","Hải Phòng");
            ViewBag.account = a;
            ViewBag.orderDate=DateTime.Now;
            Cart cart = GetCart();
            return View("views/Cart/contact.cshtml",cart);
        }
        

    }
}
