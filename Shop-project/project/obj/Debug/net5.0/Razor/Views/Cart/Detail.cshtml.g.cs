#pragma checksum "C:\Users\Admin\Desktop\Shop-project-20220710T082318Z-001\Shop-project\project\Views\Cart\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33831733d40df697b125af0bb9506fdf38bc81b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Detail), @"mvc.1.0.view", @"/Views/Cart/Detail.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 6 "C:\Users\Admin\Desktop\Shop-project-20220710T082318Z-001\Shop-project\project\Views\Cart\Detail.cshtml"
using project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33831733d40df697b125af0bb9506fdf38bc81b0", @"/Views/Cart/Detail.cshtml")]
    #nullable restore
    public class Views_Cart_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cart>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/asserts/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/asserts/css/stylecartdetails.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html id=\"content\">\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33831733d40df697b125af0bb9506fdf38bc81b04247", async() => {
                WriteLiteral(@"
        <meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"">
        <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
        <title>Cart details</title>
        <!--CSS-->
        <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor"" crossorigin=""anonymous"">
        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "33831733d40df697b125af0bb9506fdf38bc81b04966", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "33831733d40df697b125af0bb9506fdf38bc81b06148", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <!--font-awesome-->\r\n        <script src=\"https://kit.fontawesome.com/3c84cb624f.js\" crossorigin=\"anonymous\"></script>\r\n        <!--Ajax-->\r\n        <script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js\"></script>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33831733d40df697b125af0bb9506fdf38bc81b08303", async() => {
                WriteLiteral(@"
   
        <div class=""header"">
            
            </div>
            <div class=""container-lg mb-5"" >
                <div class=""row"">
                    <div class=""col-12"" >
                        <div class=""p-3 bg-white rounded shadow-sm mb-3"">
                            <div class=""text-center"">
                                <h3 class=""pb-3 text-uppercase font-weight-bold"">My Cart</h3>
                            </div>
                            <!-- Shopping cart table -->
                            <table class=""table table-hover"">
                                <thead>
                                    <tr class=""text-center"">
                                        
                                        <th>ID</th>
                                        <th>Sản Phẩm</th>
                                        <th>Đơn Giá</th>
                                        <th>Số lượng</th>
                                        <th>Tổng</th>
                  ");
                WriteLiteral("                      <th></th>\r\n                                    </tr>\r\n                                </thead>\r\n                                <tbody class=\"table-group-divider\">\r\n");
#nullable restore
#line 51 "C:\Users\Admin\Desktop\Shop-project-20220710T082318Z-001\Shop-project\project\Views\Cart\Detail.cshtml"
                             foreach(Item i in Model.items)
                            {
                           

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <tr style=""height: 100px"" id=""items"">
                                        <td class=""align-middle"">
                                            <p class=""mb-0 product-id-cart-contact"">
                                                 ");
#nullable restore
#line 57 "C:\Users\Admin\Desktop\Shop-project-20220710T082318Z-001\Shop-project\project\Views\Cart\Detail.cshtml"
                                            Write(i.Product.ProductId);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                            </p>
                                        </td>
                                        <td class=""align-middle"" style=""width: 30%"">
                                            <div class=""row"">
                                                <div class=""col-5 my-auto"">
                                                    <img");
                BeginWriteAttribute("src", " src=\"", 3073, "\"", 3099, 1);
#nullable restore
#line 63 "C:\Users\Admin\Desktop\Shop-project-20220710T082318Z-001\Shop-project\project\Views\Cart\Detail.cshtml"
WriteAttributeValue("", 3079, i.Product.Thumbnail, 3079, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 3100, "\"", 3106, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"img-fluid rounded\" style=\"cursor: pointer\"/>\r\n                                                </div>\r\n                                                    <a");
                BeginWriteAttribute("href", " href=\"", 3271, "\"", 3314, 2);
                WriteAttributeValue("", 3278, "/product/detail/", 3278, 16, true);
#nullable restore
#line 65 "C:\Users\Admin\Desktop\Shop-project-20220710T082318Z-001\Shop-project\project\Views\Cart\Detail.cshtml"
WriteAttributeValue("", 3294, i.Product.ProductId, 3294, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"text-decoration-none text-muted col\" style=\"align-self: center\">\r\n                                                    <b class=\"product-title\">");
#nullable restore
#line 66 "C:\Users\Admin\Desktop\Shop-project-20220710T082318Z-001\Shop-project\project\Views\Cart\Detail.cshtml"
                                                                        Write(i.Product.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</b>
                                                </a>
                                            </div>
                                        </td>
                                        <td class=""align-middle"" id=""price-items"">
                                          
                                            <b class=""d-flex justify-content-center"" >
                                              ");
#nullable restore
#line 73 "C:\Users\Admin\Desktop\Shop-project-20220710T082318Z-001\Shop-project\project\Views\Cart\Detail.cshtml"
                                          Write( (i.Product.SalePrice==null)?$"{i.Product.OriginalPrice}":$"{i.Product.SalePrice}");

#line default
#line hidden
#nullable disable
                WriteLiteral(@" đ
                                            </b>
                                        </td>
                                        <td class=""align-middle"">
                                            <div class=""d-flex justify-content-center"">
                                                <div class=""change-item"">
                                                    <a class=""btn btn-outline-success"" id=""down""");
                BeginWriteAttribute("href", "  href=\"", 4422, "\"", 4468, 3);
                WriteAttributeValue("", 4430, "/cart/Decrease/", 4430, 15, true);
#nullable restore
#line 79 "C:\Users\Admin\Desktop\Shop-project-20220710T082318Z-001\Shop-project\project\Views\Cart\Detail.cshtml"
WriteAttributeValue("", 4445, i.Product.ProductId, 4445, 20, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4465, "/-1", 4465, 3, true);
                EndWriteAttribute();
                WriteLiteral("\r\n                                                       >-</a>\r\n                                                 <b id=\"quantity\" class=\"quantity\">");
#nullable restore
#line 81 "C:\Users\Admin\Desktop\Shop-project-20220710T082318Z-001\Shop-project\project\Views\Cart\Detail.cshtml"
                                                                              Write(i.quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b>\r\n                                                <a class=\"btn btn-outline-success\" id=\"up\"");
                BeginWriteAttribute("href", " href=\"", 4724, "\"", 4768, 3);
                WriteAttributeValue("", 4731, "/cart/Increase/", 4731, 15, true);
#nullable restore
#line 82 "C:\Users\Admin\Desktop\Shop-project-20220710T082318Z-001\Shop-project\project\Views\Cart\Detail.cshtml"
WriteAttributeValue("", 4746, i.Product.ProductId, 4746, 20, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4766, "/1", 4766, 2, true);
                EndWriteAttribute();
                WriteLiteral(@"
                                                      >+</a>
                                                </div>
                                            </div>
                                        </td>
                                        <!--format number of price-->
                                        <td class=""align-middle"" >
                                            
                                            <b class=""d-flex justify-content-center""  style=""color: red;"">
                                                 ");
#nullable restore
#line 91 "C:\Users\Admin\Desktop\Shop-project-20220710T082318Z-001\Shop-project\project\Views\Cart\Detail.cshtml"
                                             Write( i.price*i.quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" đ
                                            </b> 
                                        </td>
                                        <td class=""align-middle"">
                                        <form action=""/Cart/Delete"" method=""post"" id=""Delete-form"">
                                             <button id=""submit"" type=""submit""  class=""btn btn-danger"">Delete</button>
                                             <input type=""hidden"" name=""id""");
                BeginWriteAttribute("value", " value=\"", 5817, "\"", 5845, 1);
#nullable restore
#line 97 "C:\Users\Admin\Desktop\Shop-project-20220710T082318Z-001\Shop-project\project\Views\Cart\Detail.cshtml"
WriteAttributeValue("", 5825, i.Product.ProductId, 5825, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                                        </form>\r\n                        \r\n                                    </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 102 "C:\Users\Admin\Desktop\Shop-project-20220710T082318Z-001\Shop-project\project\Views\Cart\Detail.cshtml"
                                
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                <!--</div>-->
                            </tbody>
                        </table>
                        <!-- End -->
                        <section class=""home-sp"">
                            <div class=""page-trang table"">
                                <a href=""#""></a>
                                <a href=""#""></a>
                            </div>
                        </section>

                    </div>
                   <form action=""checkout"" method=""get"">      
                    <div class=""p-3 bg-white rounded shadow-sm"">
                        <div class=""text-center"">
                            <h3 class=""pb-3 text-uppercase font-weight-bold"">Cart detail</h3>
                        </div>
                        <div class=""p-4"">
                            <ul class=""list-unstyled mb-4"">
                                <li class=""d-flex justify-content-between py-3 border-bottom""><b class=""text-muted"" >Tạm tính</b>
         ");
                WriteLiteral("                           <h5 class=\"font-weight-bold\" id=\"subtotal-final\" style=\"color: red;\">");
#nullable restore
#line 125 "C:\Users\Admin\Desktop\Shop-project-20220710T082318Z-001\Shop-project\project\Views\Cart\Detail.cshtml"
                                                                                                    Write(Model.GetTotalMoney());

#line default
#line hidden
#nullable disable
                WriteLiteral(@" đ</h5>
                                </li>
                                <li class=""d-flex justify-content-between py-3 border-bottom""><b class=""text-muted"">Phí vận chuyển</b> 
                                     <!--Total price >= 1.000.000 free ship-->
                                    
                                    
                                     <h5 class=""font-weight-bold"" id=""freight"" style=""color: red;"">Free ship</h5>
                                </li>
                                <li class=""d-flex justify-content-between py-3 border-bottom""><b class=""text-muted"">Tổng tiền</b>
                                    <h5 class=""font-weight-bold"" id=""total-final"" style=""color: red;"">");
#nullable restore
#line 134 "C:\Users\Admin\Desktop\Shop-project-20220710T082318Z-001\Shop-project\project\Views\Cart\Detail.cshtml"
                                                                                                 Write(Model.GetTotalMoney());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"đ</h5>
                                </li>
                            </ul>
                            <div class=""d-flex justify-content-end"">
                               
                                    <!--Disable order now function when cart empty-->
                                   <a href=""/home/list"" class=""btn"">Mua sau</a>
                                       <button ");
#nullable restore
#line 141 "C:\Users\Admin\Desktop\Shop-project-20220710T082318Z-001\Shop-project\project\Views\Cart\Detail.cshtml"
                                           Write(
                                           (Model.items.Count==0)?"disabled":""
                                           
                                       );

#line default
#line hidden
#nullable disable
                WriteLiteral(@" 
                                       type=""button"" id=""submit-cart"" class=""btn btn-outline-primary ms-3"" onclick=""window.location.href='/cart/contact'"" >Đặt Hàng</button>
                            </div>

                        </div>
                    </div>
                      </form>
                </div>
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-pprn3073KE6tl6bjs2QrFaJGz5/SUsLqktiwsUTF55Jfv3qYSDhgCecCxMW52nD2"" crossorigin=""anonymous""></script>
        
    <script>
        const tooltipTriggerList = document.querySelectorAll('[data-bs-toggle=""tooltip""]')
        const tooltipList = [...tooltipTriggerList].map(tooltipTriggerEl => new bootstrap.Tooltip(tooltipTriggerEl))
    </script>
    
</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cart> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
