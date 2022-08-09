using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using project.Logics;
using project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.IO;

namespace project.Controllers
{
    public class AdminController : Controller
    {
        private Account GetAccountSession()
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

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProductManager()
        {
            ViewBag.err = TempData["err"] as string;
            //get account session
            Account account = GetAccountSession();
            if (account == null)
            {
                return RedirectToAction("list", "home");
            }
            ViewBag.account = account;
            if (account.RoleId == 2)
            {
                ProductManager productManager = new ProductManager();
                List<Product> products = productManager.GetProducts();
                return View(products);
                //return View();
            }
            else
            {
                return RedirectToAction("list", "home");
            }
          

        }
        [HttpPost]
        public IActionResult ProductDetail(int id)
        {
            ViewBag.err = TempData["err"] as string;
            //get account session
            Account account = GetAccountSession();
            if (account == null)
            {
                return RedirectToAction("list", "home");
            }
            ViewBag.account = account;
            if (account.RoleId == 2)
            {
                CategoryManager categoryManager = new CategoryManager();
                List<Category> categories = categoryManager.getCategories();
                ViewBag.categories = categories;
                ProductManager productManager = new ProductManager();
                Product product = productManager.GetProductByID(id);
                return View(product);
            }
            else
            {
                return RedirectToAction("list", "home");
            }
           

        }
        [HttpPost]
        public IActionResult updateProduct(Product NewProduct, IFormFile myfile)
        {
            if (myfile != null)
            {
                //chỉ định đường dẫn
                string fullPath = Path.Combine(Directory.GetCurrentDirectory()
                    , "wwwroot", "product-image", myfile.FileName);


                //add file to folder
                using (var file = new FileStream(fullPath, FileMode.Create))
                {
                    myfile.CopyTo(file);
                }

                NewProduct.Thumbnail = "../product-image/" + myfile.FileName;
            }


            ProductManager productManager = new ProductManager();
            //update product
            productManager.UpdateProduct(NewProduct);
            return RedirectToAction("ProductManager");
        }
        [HttpPost]
        public IActionResult HideProduct(int id)
        {
            ProductManager productManager = new ProductManager();
            productManager.HideProduct(id);
            return RedirectToAction("ProductManager");
        }
        public IActionResult AddProduct()
        {
            ViewBag.err = TempData["err"] as string;
            //get account session
            Account account = GetAccountSession();
            if (account == null)
            {
                return RedirectToAction("list", "home");
            }
            ViewBag.account = account;
            if (account.RoleId == 2)
            {
                CategoryManager categoryManager = new CategoryManager();
                List<Category> categories = categoryManager.getCategories();
                ViewBag.categories = categories;
                return View();
            }
            else
            {
                return RedirectToAction("list", "home");
            }
           
            
        }
        [HttpPost]
        public IActionResult AddNewProduct(Product NewProduct, IFormFile myfile)
        {
            if (myfile != null)
            {
                //chỉ định đường dẫn
                string fullPath = Path.Combine(Directory.GetCurrentDirectory()
                    , "wwwroot", "product-image", myfile.FileName);


                //add file to folder
                using (var file = new FileStream(fullPath, FileMode.Create))
                {
                    myfile.CopyTo(file);
                }

                NewProduct.Thumbnail = "../product-image/" + myfile.FileName;
            }


            ProductManager productManager = new ProductManager();
            //update product
            productManager.Addproduct(NewProduct);
            return RedirectToAction("ProductManager");
        }

        public IActionResult OrderManager()
        {
            ViewBag.err = TempData["err"] as string;
            //get account session
            Account account = GetAccountSession();
            if (account == null)
            {
                return RedirectToAction("list", "home");
            }
            ViewBag.account = account;
            if (account.RoleId == 2)
            {
                OrderManager orderManager = new OrderManager();
                List<Order> orders = orderManager.AllOrder();
                return View(orders);
            }
            else
            {
                return RedirectToAction("list", "home");
            }
            //OrderManager orderManager = new OrderManager();
            //List<Order> orders = orderManager.AllOrder();
            //return View(orders);
        }
        public IActionResult OrderDetail(int id)
        {
            ViewBag.err = TempData["err"] as string;
            //get account session
            Account account = GetAccountSession();
            if (account == null)
            {
                return RedirectToAction("list", "home");
            }
            ViewBag.account = account;
            if (account.RoleId == 2)
            {
                OrderManager orderManager = new OrderManager();
                Order order = orderManager.getOrder(id);
                List<Note> notes = orderManager.getNote(id);
                ViewBag.notes = notes;
                return View(order);
            }
            else
            {
                return RedirectToAction("list", "home");
            }

            //OrderManager orderManager = new OrderManager();
            //Order order = orderManager.getOrder(id);
            //List<Note> notes = orderManager.getNote(id);
            //ViewBag.notes = notes;
            //return View(order);
        }
        public string getContentNote(List<Note>notes)
        {
            string content = "";

            foreach (Note note in notes)
            {

                content +=
            "                                                <li class=\"container-content-chat\">\n" +
            "                                                     <div class=\"time-item col-3\">\n" +
            "                                                         " +
            note.Date +
            "\n" +
            "                                                     </div>\n" +
            "                                                      <div class=\"user-item col-1\">\n" +
            "                                                         " +
            note.Username +
            "\n" +
            "                                                     </div>\n" +
            "                                                     :\n" +
            "                                                     <div class=\"title-chat-item col-9\">\n" +
            "                                                        " +
            note.Content +
            "\n" +
            "                                                     </div>\n" +
            "                                                   </li>\n";
            }
            return content;
        }


        [HttpPost]
        public string AddNote(int order_id, string note)
        {
            Account account = GetAccountSession();
            Note n = new Note(order_id, DateTime.Now, note, account.Username);
            OrderManager orderManager = new OrderManager();
            orderManager.AddNote(n);
            //getnote
             List<Note>notes=orderManager.getNote(order_id);
            string s=getContentNote(notes);
            return s;
        }


        
    }

}
