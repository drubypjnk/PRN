#pragma checksum "C:\Users\win\Desktop\Project-PRN\Project-PRN\Shop-project\project\Views\User\MyOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bde14b9e3ff25a541fb2f6f281bce9fa0bfce70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_MyOrder), @"mvc.1.0.view", @"/Views/User/MyOrder.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 5 "C:\Users\win\Desktop\Project-PRN\Project-PRN\Shop-project\project\Views\User\MyOrder.cshtml"
using project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\win\Desktop\Project-PRN\Project-PRN\Shop-project\project\Views\User\MyOrder.cshtml"
using System;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bde14b9e3ff25a541fb2f6f281bce9fa0bfce70", @"/Views/User/MyOrder.cshtml")]
    #nullable restore
    public class Views_User_MyOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Order>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/asserts/js/form.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/asserts/css/order.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/asserts/css/profile.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 8 "C:\Users\win\Desktop\Project-PRN\Project-PRN\Shop-project\project\Views\User\MyOrder.cshtml"
        Layout = "_layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bde14b9e3ff25a541fb2f6f281bce9fa0bfce704626", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5bde14b9e3ff25a541fb2f6f281bce9fa0bfce705669", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5bde14b9e3ff25a541fb2f6f281bce9fa0bfce706788", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral(@"        <div class=""app__container"">
            <div class=""grid"">
                <div class=""grid__row "">
                    <div class=""grid__column-2"">
                        <div class=""profile"">
                            <div class=""profile__heading"">
                                <div class=""profile__heading profile__heading-avatar"">
                                    <img src=""https://cf.shopee.vn/file/e4b8614be265b210727bdef25190db23_tn""
                                        alt=""avatar"">
                                </div>
                                <div class=""profile__heading profile__heading-content"">
                                    <div
                                        class=""profile__heading profile__heading-content profile__heading-content-acount"">
                                        Dũng Bùi
                                    </div>
                                    <div
                                        class=""profile__heading profile");
            WriteLiteral(@"__heading-content profile__heading-content-title"">
                                        <i
                                            class=""fa-solid fa-pen profile__heading-content-fix profile__heading-content-fix-icon""></i>
                                        <a
                                            class="" profile__heading profile__heading-content profile__heading-content-fix"">
                                            sửa hồ sơ
                                        </a>
                                    </div>
                                </div>
                            </div>
                             <ul class=""profile-list"">
                            <h class=""profile__heading-item""><i class=""fa-solid fa-user profile__heading-item-icon ""></i> 
                                Tài khoản của tôi</h>
                            <!-- <li class=""profile-item profile-item"">
                                <a href=""#"" class=""profile-item__link profile-item__link-mai");
            WriteLiteral(@"n"">Tài khoản của tôi</a>
                            </li> -->
                            <li class=""profile-item "">
                                    <a href=""/user/profile"" class=""profile-item__link"">Hồ Sơ</a>
                            </li>
                            <li class=""profile-item "">
                                <a href=""address.jsp"" class=""profile-item__link"">Địa chỉ</a>
                            </li>
                            <li class=""profile-item "">
                                <a href=""/user/changepassword"" class=""profile-item__link"">Đổi mật khẩu</a>
                            </li>
                            <div class=""profile-item__link-group"">
                                <img src=""https://cf.shopee.vn/file/f0049e9df4e536bc3e7f140d071e9078""");
            BeginWriteAttribute("alt", " alt=\"", 3257, "\"", 3263, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""profile-item profile-item-img"">
                                <li class=""profile-item profile-item--active"">
                                    <a href=""/user/myorder"" class=""profile-item__link"">Đơn mua</a>
                                </li>
                            </div>
                            
                        </ul>
                        </div>
                    </div>
                    <!-- <div class=""grid__column-2"">
                        <div class=""category"">
                            <h3 class=""category__heading"">
                                <i class=""category__heading-icon fas fa-list""></i> Danh mục
                            </h3>
                            <ul class=""category-list"">
                                <li class=""category-item category-item--active"">
                                    <a href=""#"" class=""category-item__link"">Tất cả</a>
                                </li>
                                <li class=""category");
            WriteLiteral(@"-item"">
                                    <a href=""#"" class=""category-item__link"">Tai nghe cao cấp</a>
                                </li>
                                <li class=""category-item"">
                                    <a href=""#"" class=""category-item__link"">Chuột không dây cao cấp</a>
                                </li>
                            </ul>
                        </div>
                    </div> -->
                    <!-- /* Home sort+filter  */ -->
                    <div class=""grid__column-10"">
                        <div class=""home-filter"">
                            <span class=""home-filter__label"">Sắp xếp theo</span>
                            <button class=""home-filter-btn btn"">Tất cả</button>
                            <button class=""home-filter-btn btn btn--primary"">Mới nhất</button>
                            <button class=""home-filter-btn btn"">Chờ xác nhận </button>
                            <button class=""home-filter-btn btn"">Đã hủy <");
            WriteLiteral(@"/button>
                            <div class=""select-input"">
                                <span class=""select-input__label"">Giá</span>
                                <i class='select-input__icon fa-solid fa-chevron-down'></i>
                                <div class=""select-input-option"">
                                    <ul class=""select-input___list"">
                                        <li class=""select-input__item"">
                                            <a");
            BeginWriteAttribute("href", " href=\"", 5805, "\"", 5812, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"select-input__link\">Giá thấp đến cao</a>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 5909, "\"", 5916, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""select-input__link"">Giá cao đến thấp</a>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                         
                        </div>
                        <!--Home Product-->
                        <div class=""home-product"">
                            <div class=""grid__row order-list-contai"">
                                                <!--Item-->
                                                <ul class=""home-product home-product-list"">
                                                    
");
#nullable restore
#line 110 "C:\Users\win\Desktop\Project-PRN\Project-PRN\Shop-project\project\Views\User\MyOrder.cshtml"
                             foreach( Order o in Model)
                            {
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"home-product-item\"");
            BeginWriteAttribute("onclick", " onclick=\"", 6747, "\"", 6816, 3);
            WriteAttributeValue("", 6757, "window.location.href=\'orderinformation?order_id=", 6757, 48, true);
#nullable restore
#line 113 "C:\Users\win\Desktop\Project-PRN\Project-PRN\Shop-project\project\Views\User\MyOrder.cshtml"
WriteAttributeValue("", 6805, o.OrderId, 6805, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6815, "\'", 6815, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                                        <div class=""grid__column-10 main-product"" style=""width:100%"">
                                                            <!--Heading-->
                                                      <div class=""order-item oder-item-heading"">
                                                          <div class=""order-item order-item__action"">
                                                             
                                                              <div class=""order-item order-item__action order-item__name"">Order ID:");
#nullable restore
#line 119 "C:\Users\win\Desktop\Project-PRN\Project-PRN\Shop-project\project\Views\User\MyOrder.cshtml"
                                                                                                                              Write(o.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                                              <div class=""order-item order-item__action  order-item__action--chat"">
                                                                
                                                              </div>
                                                              <a class=""order-item order-item__action  order-item__action--viewshop"" href=""/home/list"">
                                                                  <button class=""stardust-button"">
                                                                      <svg enable-background=""new 0 0 15 15"" viewBox=""0 0 15 15"" x=""0""
                                                                          y=""0"" class=""shopee-svg-icon icon-btn-shop"">
                                                                          <path
                                                                              d=""m15 4.8c-.1-1-.8-2-1.6-2.9-.4-.3-.7-.5-1-.8-.1-.1-.7-.5-.7-.5h-8.5s-1.4 1.4-");
            WriteLiteral(@"1.6 1.6c-.4.4-.8 1-1.1 1.4-.1.4-.4.8-.4 1.1-.3 1.4 0 2.3.6 3.3l.3.3v3.5c0 1.5 1.1 2.6 2.6 2.6h8c1.5 0 2.5-1.1 2.5-2.6v-3.7c.1-.1.1-.3.3-.3.4-.8.7-1.7.6-3zm-3 7c0 .4-.1.5-.4.5h-8c-.3 0-.5-.1-.5-.5v-3.1c.3 0 .5-.1.8-.4.1 0 .3-.1.3-.1.4.4 1 .7 1.5.7.7 0 1.2-.1 1.6-.5.5.3 1.1.4 1.6.4.7 0 1.2-.3 1.8-.7.1.1.3.3.5.4.3.1.5.3.8.3zm.5-5.2c0 .1-.4.7-.3.5l-.1.1c-.1 0-.3 0-.4-.1s-.3-.3-.5-.5l-.5-1.1-.5 1.1c-.4.4-.8.7-1.4.7-.5 0-.7 0-1-.5l-.6-1.1-.5 1.1c-.3.5-.6.6-1.1.6-.3 0-.6-.2-.9-.8l-.5-1-.7 1c-.1.3-.3.4-.4.6-.1 0-.3.1-.3.1s-.4-.4-.4-.5c-.4-.5-.5-.9-.4-1.5 0-.1.1-.4.3-.5.3-.5.4-.8.8-1.2.7-.8.8-1 1-1h7s .3.1.8.7c.5.5 1.1 1.2 1.1 1.8-.1.7-.2 1.2-.5 1.5z"">
                                                                          </path>
                                                                      </svg>
                                                                      <span>xem shop</span>
                                                                  </button>
                                        ");
            WriteLiteral("                      </a>\r\n                                                          </div>\r\n                                                      </div>\r\n                                                              <!--Body-->\r\n");
#nullable restore
#line 137 "C:\Users\win\Desktop\Project-PRN\Project-PRN\Shop-project\project\Views\User\MyOrder.cshtml"
                                     foreach( OrderDetail od in o.OrderDetails)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <div class=""order-item-body"">
                                                          <div class=""order-item order-item__product"">
                                                              <div class=""order-item order-item__product-image""");
            BeginWriteAttribute("style", "\r\n                                                                  style=\"", 10101, "\"", 10221, 4);
            WriteAttributeValue("", 10176, "background-image:", 10176, 17, true);
            WriteAttributeValue(" ", 10193, "url(", 10194, 5, true);
#nullable restore
#line 142 "C:\Users\win\Desktop\Project-PRN\Project-PRN\Shop-project\project\Views\User\MyOrder.cshtml"
WriteAttributeValue("", 10198, od.Product.Thumbnail, 10198, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 10219, ");", 10219, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                                              </div>
                                                              <div class=""order-item order-item__product-content"">
                                                                  <div class=""name-container"">
                                                                      <div class=""order-item order-item__product-content order-item__product-content--name"">
                                                                          <span class=""_30COVM""> 
                                                                              ");
#nullable restore
#line 148 "C:\Users\win\Desktop\Project-PRN\Project-PRN\Shop-project\project\Views\User\MyOrder.cshtml"
                                                                         Write(od.Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                                          </span>
                                                                      </div>
                                                                  </div>
                                                                  <div class=""order-item order-item__product-content order-item__product-content--attributes"">
                                                                      <div class=""order-item__product-content--attributes order-item__product-content--type"">
                                                                              <div class=""order-product-item order-product-type"">");
#nullable restore
#line 154 "C:\Users\win\Desktop\Project-PRN\Project-PRN\Shop-project\project\Views\User\MyOrder.cshtml"
                                                                                                                            Write(od.Product.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                                                              <div class=""order-product-item order-product-price"">
                                                                                  <div class=""order-product-item__oldprice"" >");
#nullable restore
#line 156 "C:\Users\win\Desktop\Project-PRN\Project-PRN\Shop-project\project\Views\User\MyOrder.cshtml"
                                                                                                                         Write(String.Format("{0:0,00}", @od.Product.OriginalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("  đ</div>\r\n                                                                                  <div class=\"order-item__product-content--price\">");
#nullable restore
#line 157 "C:\Users\win\Desktop\Project-PRN\Project-PRN\Shop-project\project\Views\User\MyOrder.cshtml"
                                                                                                                              Write(String.Format("{0:0,00}", @od.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" đ</div>
                                                                              </div>
                                                                      </div>
                                                                      <div class=""order-item__product-content--attributes order-item__product-content--unit"">x ");
#nullable restore
#line 160 "C:\Users\win\Desktop\Project-PRN\Project-PRN\Shop-project\project\Views\User\MyOrder.cshtml"
                                                                                                                                                          Write(od.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                                                  </div>
                                                              </div>
                                                          </div>
                                                      </div>
");
#nullable restore
#line 165 "C:\Users\win\Desktop\Project-PRN\Project-PRN\Shop-project\project\Views\User\MyOrder.cshtml"
                                        
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                              <!--Footer-->
                                                      <div class=""order-item order-item-bill "">
                                                          <div class=""order-item order-item-bill order-item--total"">
                                                              <div class=""order-item--total order-item--total__content"">
                                                                  <span class=""order-item--total__content-icon"">
                                                                      <div class=""_-8oSuS"">
                                                                          <svg width=""16"" height=""17"" viewBox=""0 0 253 263"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                                                                              <path 
                                                                              fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M126.5 0.389801C126.5 0");
            WriteLiteral(@".389801 82.61 27.8998 5.75 26.8598C5.08763 26.8507 4.43006 26.9733 3.81548 27.2205C3.20091 27.4677 2.64159 27.8346 2.17 28.2998C1.69998 28.7657 1.32713 29.3203 1.07307 29.9314C0.819019 30.5425 0.688805 31.198 0.689995 31.8598V106.97C0.687073 131.07 6.77532 154.78 18.3892 175.898C30.003 197.015 46.7657 214.855 67.12 227.76L118.47 260.28C120.872 261.802 123.657 262.61 126.5 262.61C129.343 262.61 132.128 261.802 134.53 260.28L185.88 227.73C206.234 214.825 222.997 196.985 234.611 175.868C246.225 154.75 252.313 131.04 252.31 106.94V31.8598C252.31 31.1973 252.178 30.5414 251.922 29.9303C251.667 29.3191 251.292 28.7649 250.82 28.2998C250.35 27.8358 249.792 27.4696 249.179 27.2225C248.566 26.9753 247.911 26.852 247.25 26.8598C170.39 27.8998 126.5 0.389801 126.5 0.389801Z"" fill=""#ee4d2d""></path>
                                                                              <path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M207.7 149.66L119.61 107.03C116.386 105.472 113.914 102.697 112.736 99.3154C111.558 95.9342 111.77");
            WriteLiteral(@"2 92.2235 113.33 88.9998C114.888 85.7761 117.663 83.3034 121.044 82.1257C124.426 80.948 128.136 81.1617 131.36 82.7198L215.43 123.38C215.7 120.38 215.85 117.38 215.85 114.31V61.0298C215.848 60.5592 215.753 60.0936 215.57 59.6598C215.393 59.2232 215.128 58.8281 214.79 58.4998C214.457 58.1705 214.063 57.909 213.63 57.7298C213.194 57.5576 212.729 57.4727 212.26 57.4798C157.69 58.2298 126.5 38.6798 126.5 38.6798C126.5 38.6798 95.31 58.2298 40.71 57.4798C40.2401 57.4732 39.7735 57.5602 39.3376 57.7357C38.9017 57.9113 38.5051 58.1719 38.1709 58.5023C37.8367 58.8328 37.5717 59.2264 37.3913 59.6604C37.2108 60.0943 37.1186 60.5599 37.12 61.0298V108.03L118.84 147.57C121.591 148.902 123.808 151.128 125.129 153.884C126.45 156.64 126.797 159.762 126.113 162.741C125.429 165.72 123.755 168.378 121.363 170.282C118.972 172.185 116.006 173.221 112.95 173.22C110.919 173.221 108.915 172.76 107.09 171.87L40.24 139.48C46.6407 164.573 62.3785 186.277 84.24 200.16L124.49 225.7C125.061 226.053 125.719 226.24 126.39 226.24C127.061 226");
            WriteLiteral(@".24 127.719 226.053 128.29 225.7L168.57 200.16C187.187 188.399 201.464 170.892 209.24 150.29C208.715 150.11 208.2 149.9 207.7 149.66Z"" fill=""#fff""></path>
                                                                          </svg>
                                                                      </div>
                                                                  </span>
                                                                  <div class=""order-item--total__text"">Tổng số tiền:</div>
                                                                  <div class=""order-item--total__price"">₫ ");
#nullable restore
#line 181 "C:\Users\win\Desktop\Project-PRN\Project-PRN\Shop-project\project\Views\User\MyOrder.cshtml"
                                                                                                      Write(String.Format("{0:0,00}", o.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </div>
                                                              </div>
                                                          </div>
                                                          <div class=""order-item order-item-bill order-item--atribute"">
                                                              <div class=""order-item--atribute order-item--atribute__rating"">
                                                                  <span>Không nhận được đánh giá</span>
                                                              </div>
                                                              <div class="" order-item--atribute  order-item--atribute__container"">
                                                                  <div class=""order-item--atribute__container order-item--atribute__container--rebuy"">
                                                                      <button class=""stardust-button stardust-button--primary _2x5SvJ"">Mua lại</button>
                   ");
            WriteLiteral(@"                                               </div>
                                                                  <div class=""order-item--atribute__container order-item--atribute__container--contact"">
                                                                      <button class=""stardust-button stardust-button--secondary _2x5SvJ"">Liên hệ Người bán</button>
                                                                  </div>
                                                              </div>
                                                          </div>
                                                      </div>
                                                    </li>
");
#nullable restore
#line 199 "C:\Users\win\Desktop\Project-PRN\Project-PRN\Shop-project\project\Views\User\MyOrder.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                    
                                                </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Order>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
