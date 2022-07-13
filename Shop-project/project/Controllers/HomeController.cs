using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using project.Logics;
using project.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List(int id, int curPage)
        {    //gui session account

           
            Account account=new Account("dung","Bùi Anh Dũng,","Đại Học FPT","078332391",new DateTime(2001,01,01),"","drubypjnk@gmail.com","Hải Phòng");
            string json = JsonConvert.SerializeObject(account);
            HttpContext.Session.SetString("account", json);
            //check cart exist ?
            string? json1 = HttpContext.Session.GetString("cart");
            Cart cart = new Cart();
            if (json1 != null)
            {
                cart = JsonConvert.DeserializeObject<Cart>(json1);
            }
            
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            string pageSize = config.GetConnectionString("PageSize");
            int size = Convert.ToInt32(pageSize);
            ProductManager productManager = new ProductManager();
            CategoryManager categoryManager = new CategoryManager();
            List<Product> products = productManager.GetProductsByCategory(id);
            List<Category> categories = categoryManager.GetCategory(0); //get all category
            ViewBag.categories= categories;
            ViewBag.curCategory = id;
            ViewBag.numPage=(products.Count%size==0? products.Count/size:(products.Count/size)+1);
          //  if (products.Count == 0) ViewBag.numPage = 1;
             ViewBag.cart=cart;
            ViewBag.curPage = curPage;
            ViewBag.size = size;
            return View(products.Skip(size * (curPage-1)).Take(size).ToList());
        }
      
    }
}
