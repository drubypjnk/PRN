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
    public class HomeController : Controller
    {
     
        public IActionResult Index()
        {
            return View();
        }
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

        public IActionResult List(int id = 0, int curPage = 1)
        {
            ViewBag.err = TempData["err"] as string;
            //get account session
            Account account=GetAccountSession();
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
            ViewBag.categories = categories;
            ViewBag.curCategory = id;
            ViewBag.numPage = (products.Count % size == 0 ? products.Count / size : (products.Count / size) + 1);
            //  if (products.Count == 0) ViewBag.numPage = 1;
            ViewBag.cart = cart;
            ViewBag.curPage = curPage;
            ViewBag.size = size;
            ViewBag.account=account;
            return View(products.Skip(size * (curPage - 1)).Take(size).ToList());
        }
        [HttpPost]
        public string search(int id, int curPage, string word, int sortID)
        {   //get page size
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            string pageSize = config.GetConnectionString("PageSize");
            int size = Convert.ToInt32(pageSize);
            //filter products
            ProductManager productManager = new ProductManager();
            List<Product> list = productManager.filter(id, word, sortID);
            //paging
            List<Product> products = list.Skip(size * (curPage - 1)).Take(size).ToList();
            string content = getContent(products);
            return content;
        }



        public string getContent(List<Product> products)
        {
            string content = "";
            foreach (Product p in products)
            {

                content += "<div class=\"grid__column-2-4\">\n" +
   "                                    <a class=\"home-product-item\" href=\"/product/detail/"
           + p.ProductId
           + "\">\n" +
   "                                        <div class=\"home-product-item__img\"\n" +
   "                                            style=\"background-image: url("
           + p.Thumbnail
           + ");\">\n" +
   "                                        </div>\n" +
   "                                        <h4 class=\"home-product-item__img-name\">\n" +
   "                                          "
           + p.ProductName
           + "\n" +
   "                                        </h4>\n" +
   "                                        <div class=\"home-product-item__price\">\n" +
   "                                            <span class=\"home-product-item__oldprice\">"
           + String.Format("{0:0,00}", p.OriginalPrice)
           + " đ</span>\n" +
   "                                            <span class=\"home-product-item__current\">"
           + (String.Format("{0:0,00}", p.SalePrice))
           + " đ </span>\n" +
   "                                        </div>\n" +
   "                                        <div class=\"home-product-item__action\">\n" +
   "                                            <span class=\"home-product-item__like home-product-item__like--liked\">\n" +
   "                                                <i class=\"home-product-item__like-icon-empty far fa-heart\"></i>\n" +
   "                                                <i class=\"home-product-item__like-icon-fill fas fa-heart\"></i>\n" +
   "                                            </span>\n" +
   "\n" +
   "\n" +
   "                                            <div class=\"home-product-item__rating\">\n" +
   "                                                <i class=\"fas fa-star home-product-item__stargold\"></i>\n" +
   "                                                <i class=\"fas fa-star home-product-item__stargold\"></i>\n" +
   "                                                <i class=\"fas fa-star home-product-item__stargold\"></i>\n" +
   "                                                <i class=\"fas fa-star home-product-item__stargold\"></i>\n" +
   "                                                <i class=\"fas fa-star home-product-item__stargold\"></i>\n" +
   "                                            </div>\n" +
   "                                            <span class=\"home-product-item__sold\">"
           + p.UnitOnOrder
           + " đã bán</span>\n" +
   "                                        </div>\n" +
   "                                        <div class=\"home-product-item__origin\">\n" +
   "                                            <span class=\"home-product-item__brand\">"
           + p.Brand
           + "</span>\n" +
   "                                           <span class=\"home-product-item__origin-name\">"
           + p.Origin
           + "</span>\n" +
   "                                        </div>\n" +
   "                                        <div class=\"home-product-item__favourite\">\n" +
   "                                            <span>\n" +
   "                                                <i class=\"fas fa-check\"></i> Yêu thích\n" +
   "                                            </span>\n" +
   "\n" +
   "                                        </div>\n" +
   "                                        <div class=\"home-product-item__sale-off\">\n" +
   "                                            <span class=\"home-product-item__sale-off-percent\">"
           + p.discount() +
           "%"
           + "</span>\n" +
   "                                            <span class=\"home-product-item__sale-off-label\">Giảm</span>\n" +
   "                                        </div>\n" +
   "                                    </a>\n" +
   "                                </div>";
            }
            return content;
        }

        [HttpPost]
        public string Paging(int id, int curPage, string word, int sortID)
        {
            //get page size
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            string pageSize = config.GetConnectionString("PageSize");
            int size = Convert.ToInt32(pageSize);

            ProductManager productManager = new ProductManager();
            List<Product> list = productManager.filter(id, word, sortID);
            //paging
            int numpage = (list.Count % size == 0 ? list.Count / size : (list.Count / size) + 1);

            string content = getPageContent(curPage, numpage);
            return content;
        }
        public string getPageContent(int curPage, int numPage)
        {
            string content = "                        <div class=\"grid__column-2\"></div>\n" +
"                        <div class=\"content-paging content-paging-footer\" name=\"page\">\n" +
"                            <div class=\"title-paging\"> <span>Page "
            + curPage
            + "  of "
            + numPage
            + "<span></div>\n" +
"                            <nav class=\"\" aria-label=\"...\">\n" +
"                                <ul class=\"pagination\">\n" +
"    \n" +
"                                    <li class=\"page-item\">\n" +
"                                        <a class=\"page-link  \n" +
"                                         ";
            if (1 == curPage)
            {
                content += "disabled";
            }


            content +=
         "\"\n" +
"                                        onclick=\"paging("
        + (curPage - 1)
        + ")\" >Previous</a>\n";

            content +=
"                                    </li>\n" +
"                                   \n" +

"                                    <select class=\"select-paginate\" id=\"paging\" \n" +
"                                        onchange=\"submitForm($('#paging').children('option:selected').val())\">\n";
            for (int i = 1; i <= numPage; i++)
            {
                content += "{\n" +
"                                        <option value=\"" +
i +
"\" ";
                if (curPage == i)
                {
                    content += "selected";
                }
                content +=
" >\n" +
"                                           " +
i +
"\n" +
"                                        </option>\n" +
"                                       \n";
            }

            content += "\n" +
"                                    </select>\n" +
"                                    <li class=\"page-item \">\n" +
"                                        <a class=\"page-link ";
            if (numPage == curPage)
            {
                content += "disabled";
            }
            content +=
               "\" onclick=\"paging("
              + (curPage + 1)
              + ")\"  >Next</a>\n" +
  "                                    </li>\n" +
  "                                </ul>\n" +
  "                            </nav>\n" +
  "                        </div>";
            return content;
        }

        //public string SetCookie()
        //{
        //    Response.Cookies.Append("SE1611_User", "chilp");
        //    return $"Set Cookie";
        //}
        //public string GetCookie()
        //{
        //    string user; 
        //    if(Request.Cookies["SE1611_User"]!=null)
        //    {
        //        user = Request.Cookies["SE1611_User"];
        //    }
        //    else
        //    {
        //        user = "nobody";
        //    }
        //    return $"user:{user}";
        //}
       
        public IActionResult Login(string user,string pass,string check="start")
        {   Account acc=GetAccountSession();
            if (acc != null)
            {
                return RedirectToAction("List");
            }
            AccountManager accountManager=new AccountManager();
            Account account = accountManager.getAccount(user, pass);
                ViewBag.user=Request.Cookies["user"];
                ViewBag.pass=Request.Cookies["pass"];
                ViewBag.pick=Request.Cookies["check"];
            if (check!="start")
            {
             ViewBag.err = "Sai tên đăng nhập hoặc mật khẩu,xin mời nhập lại";
            }
            if(account==null)
              return View();
            else
            {
                if (check == null)
                {
                    CookieOptions option = new CookieOptions
                    {
                        Expires = DateTime.Now.AddMinutes(0)
                    };
                    Response.Cookies.Append("user", user,option);
                    Response.Cookies.Append("pass", pass);
                    Response.Cookies.Append("check", check);
                    ViewBag.check = check;
                    
                }
                else
                {
                    Response.Cookies.Append("user", user);
                    Response.Cookies.Append("pass", pass);
                    Response.Cookies.Append("check", check);
                    ViewBag.check = check;
                    //set a session
                    string json = JsonConvert.SerializeObject(account);
                    HttpContext.Session.SetString("account", json);

                }
                if (account.RoleId == 1)
                {
                    return RedirectToAction("List");
                }
                //if (account.RoleId == 2)
                //{
                //}
                    return RedirectToAction("productmanager","admin");
            }
        }
        public IActionResult logout()
        {
            HttpContext.Session.Remove("account");
            return RedirectToAction("list");
        }
        
     }
 }
    


