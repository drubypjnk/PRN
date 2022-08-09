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

namespace project.Controllers
{
    public class User : Controller
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
            return cart;
        }
        private Account GetAccountSession()
        {  
            AccountManager accountManager=new AccountManager();
            //get account session
            Account account;
            string? json = HttpContext.Session.GetString("account");
            if (json != null)
            {
                account = JsonConvert.DeserializeObject<Account>(json);
            }
            else {
                return null; }
            //clear old session
            HttpContext.Session.Clear();
            //refresh sesion
            account = accountManager.Refresh(account.Username);
             //set a new session
            string json1 = JsonConvert.SerializeObject(account);
            HttpContext.Session.SetString("account", json1);
            return account;
        }
        public IActionResult Profile()
        {   
            Account account = GetAccountSession();
            if(account == null)
            {
                TempData["err"] = "access denied!";

                return RedirectToAction("list", "home");
            }
            Cart cart = GetCart();
            ViewBag.Account = account;
            ViewBag.cart = cart;
            return View(account);
        }
        [HttpPost]
        public IActionResult UpdateProfile(string name, string newphone, string city,string address,string gender,DateTime dob)
        {
            Account account = GetAccountSession();
            if (account == null)
            {
                TempData["err"] = "access denied!";

                return RedirectToAction("list", "home");
            }
            account.Name = name;
            if (newphone != null)
            {
            account.Mobile = newphone;
            }
            account.City = city;
            account.Address = address;
            account.Gender = (Convert.ToInt32(gender) == 1);
            account.Dob = dob;
            AccountManager accountManager = new AccountManager();
            accountManager.UpdateInformation(account);
            Cart cart = GetCart();
            //remove old session
            //set a session
            return RedirectToAction("Profile");
        }
        
        public IActionResult Changepassword()
        {
            Account account = GetAccountSession();
            if (account == null)
            {
                TempData["err"] = "access denied!";

                return RedirectToAction("list", "home");
            }
            ViewBag.err = TempData["err1"] as string;
            Cart cart = GetCart();
            ViewBag.Account = account;
            ViewBag.cart = cart;
            return View(account);
        }
        [HttpPost]
         public IActionResult ChangePass(string curPass, string newPass,string reNewPass)
        {
            if (curPass.Equals(newPass))
            {
                TempData["err1"] = "Mật khẩu mới phải khác mật khẩu cũ";
               return RedirectToAction("Changepassword");
            }
            Account account = GetAccountSession();
            if (!account.Password.Equals(curPass))
            {
                TempData["err1"] = "Mật khẩu sai,mời nhập lại";
                return RedirectToAction("Changepassword");
            }
            AccountManager accountManager = new AccountManager();
            accountManager.ChangePassword(account.Username, newPass);
            TempData["err1"] = "Thay đổi mật khẩu thành công";
            return RedirectToAction("Changepassword");
        }

        public IActionResult MyOrder()
        {
            Account account = GetAccountSession();
            if (account == null)
            {
                TempData["err"] = "access denied!";

                return RedirectToAction("list", "home");
            }

            Cart cart = GetCart();
            ViewBag.Account = account;
            ViewBag.cart = cart;
            //content
            OrderManager orderManager = new OrderManager();
            List<Order> orders = orderManager.getOrders(account.Username);
            return View(orders);
        }
        public IActionResult OrderInformation(int order_id)
        {
            Account account = GetAccountSession();
            if (account == null)
            {
                TempData["err"] = "access denied!";

                return RedirectToAction("list", "home");
            }
            OrderManager orderManager = new OrderManager();
            Order order = orderManager.getOrder(order_id);
            List<Note> notes = orderManager.getNote(order_id);
            ViewBag.notes = notes;
            Cart cart = GetCart();
            ViewBag.Account = account;
            ViewBag.cart = cart;
            //content
            return View(order);  
        }
    }
}
