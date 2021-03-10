#pragma checksum "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4580d826eb7cecf43b6040051c4ef800f258524f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#line 1 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\_ViewImports.cshtml"
using Portfolio.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\_ViewImports.cshtml"
using Portfolio.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4580d826eb7cecf43b6040051c4ef800f258524f", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91615464df3ced54e946a5b71d4ddabe43cff52a", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdminViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Admin Anasayfa";
    Layout = "~/Views/Admin/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\" style=\"margin-right:0;\">\r\n    <div class=\"col-md-2\">\r\n        ");
#nullable restore
#line 9 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Index.cshtml"
   Write(await Html.PartialAsync("_adminSideBar",Model.SideBar));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
    <div class=""col-md-10"">
        <div class=""col-md-12 mt-2 border border-primary"">
            <div class=""title-text text-center row mb-1"">
                <div class=""col-md-9"">
                    <h2 style=""display:inline"">Kategoriler</h2>
                </div>
                <div class=""col-md-3""><button class=""btn btn-success me-2 btn-admin"">Yeni</button>
                </div>
            </div>
            <table class=""table table-bordered table-hover table-text admin"">
                <thead>
                    <tr class=""text-center"">
                        <th scope=""col"" style=""width:3%"">#</th>
                        <th scope=""col"">Kategori Adı</th>
                        <th scope=""col"">Kategori Türü</th>
                        <th scope=""col"" style=""width: 25%;"">İşlemler</th>

                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 31 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Index.cshtml"
                     foreach (var item in Model.Categories)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th scope=\"row\">");
#nullable restore
#line 34 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Index.cshtml"
                                       Write(item.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td>");
#nullable restore
#line 35 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Index.cshtml"
                           Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 36 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Index.cshtml"
                           Write(item.CType);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                            <td class=""text-center"">
                                <button class=""btn btn-info me-2 btn-admin"">Düzenle</button>
                                <button class=""btn btn-danger btn-admin"">Sil</button>
                            </td>
                        </tr>
");
#nullable restore
#line 42 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n");
            WriteLiteral(@"        <div class=""col-md-12 mt-2 border border-primary"">
            <div class=""title-text text-center row mb-1"">
                <div class=""col-md-9"">
                    <h2 style=""display:inline"">Menü</h2>
                </div>
                <div class=""col-md-3""><button class=""btn btn-success me-2 btn-admin"">Yeni</button>
                </div>
            </div>
            <table class=""table table-bordered table-hover table-text admin"">
                <thead>
                    <tr class=""text-center"">
                        <th scope=""col"">#</th>
                        <th scope=""col"">Menü Adı</th>
                        <th scope=""col"">Link</th>
                        <th scope=""col"" style=""width: 25%;"">İşlemler</th>

                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 104 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Index.cshtml"
                     foreach (var item in Model.MenuItems)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th scope=\"row\">");
#nullable restore
#line 107 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Index.cshtml"
                                       Write(item.MenuItemId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td>");
#nullable restore
#line 108 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Index.cshtml"
                           Write(item.MenuItemName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 109 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Index.cshtml"
                           Write(item.Link);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                            <td class=""text-center"">
                                <button class=""btn btn-info me-2 btn-admin"">Düzenle</button>
                                <button class=""btn btn-danger btn-admin"">Sil</button>
                            </td>
                        </tr>
");
#nullable restore
#line 115 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n");
            WriteLiteral(@"        <div class=""col-md-12 mt-2 border border-primary"">
            <div class=""title-text text-center row mb-1"">
                <div class=""col-md-9"">
                    <h2 style=""display:inline"">Projeler</h2>
                </div>
                <div class=""col-md-3""><button class=""btn btn-success me-2 btn-admin"">Yeni</button>
                </div>
            </div>
            <table class=""table table-bordered table-hover table-text admin"">
                <thead>
                    <tr class=""text-center"">
                        <th scope=""col"" style=""width:3%"">#</th>
                        <th scope=""col"">Resim</th>
                        <th scope=""col"">Başlık</th>
                        <th scope=""col"" style=""width:40%"">Metin</th>
");
            WriteLiteral(@"                        <th scope=""col"">isDone</th>
                        <th scope=""col"">isHome</th>
                        <th scope=""col"" style=""width: 25%;"">İşlemler</th>

                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 173 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Index.cshtml"
                     foreach (var project in Model.Projects)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th scope=\"row\">");
#nullable restore
#line 176 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Index.cshtml"
                                       Write(project.ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td>");
#nullable restore
#line 177 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Index.cshtml"
                           Write(project.Image);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 178 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Index.cshtml"
                           Write(project.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 179 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Index.cshtml"
                           Write(project.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                            <td>");
#nullable restore
#line 186 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Index.cshtml"
                           Write(project.isDone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 187 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Index.cshtml"
                           Write(project.isHome);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                            <td class=""text-center"">
                                <button class=""btn btn-info me-2 btn-admin"">Düzenle</button>
                                <button class=""btn btn-danger btn-admin"">Sil</button>
                            </td>
                        </tr>
");
#nullable restore
#line 193 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>
        <div class=""col-md-12 mt-2 border border-primary"">
            <div class=""title-text text-center row mb-1"">
                <div class=""col-md-9"">
                    <h2 style=""display:inline"">Slider</h2>
                </div>
                <div class=""col-md-3""><button class=""btn btn-success me-2 btn-admin"">Yeni</button>
                </div>
            </div>
            <table class=""table table-bordered table-hover table-text admin"">
                <thead>
                    <tr class=""text-center"">
                        <th scope=""col"" style=""width:3%"">#</th>
                        <th scope=""col"">Resim</th>
                        <th scope=""col"">isHome</th>
                        <th scope=""col"" style=""width: 25%;"">İşlemler</th>

                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 216 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Index.cshtml"
                     foreach (var slider in Model.Sliders)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th scope=\"row\">");
#nullable restore
#line 219 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Index.cshtml"
                                       Write(slider.SliderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td>");
#nullable restore
#line 220 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Index.cshtml"
                           Write(slider.Image);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 221 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Index.cshtml"
                           Write(slider.isHome);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                            <td class=""text-center"">
                                <button class=""btn btn-info me-2 btn-admin"">Düzenle</button>
                                <button class=""btn btn-danger btn-admin"">Sil</button>
                            </td>
                        </tr>
");
#nullable restore
#line 227 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>
        <div class=""col-md-12 mt-2 border border-primary"">
            <div class=""title-text text-center row mb-1"">
                <div class=""col-md-9"">
                    <h2 style=""display:inline"">Servisler</h2>
                </div>
                <div class=""col-md-3""><button class=""btn btn-success me-2 btn-admin"">Yeni</button>
                </div>
            </div>
            <table class=""table table-bordered table-hover table-text admin"">
                <thead>
                    <tr class=""text-center"">
                        <th scope=""col"" style=""width:3%"">#</th>
                        <th scope=""col"">Resim</th>
                        <th scope=""col"">Başlık</th>
                        <th scope=""col"">Metin</th>
                        <th scope=""col"">isHome</th>
                        <th scope=""col"" style=""width: 25%;"">İşlemler</th>

                    </tr>
                </thead>
               ");
            WriteLiteral(" <tbody>\r\n");
#nullable restore
#line 252 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Index.cshtml"
                     foreach (var service in Model.Services)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th scope=\"row\">");
#nullable restore
#line 255 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Index.cshtml"
                                       Write(service.ServiceId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td>");
#nullable restore
#line 256 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Index.cshtml"
                           Write(service.Image);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 257 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Index.cshtml"
                           Write(service.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 258 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Index.cshtml"
                           Write(service.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 259 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Index.cshtml"
                           Write(service.isHome);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                            <td class=""text-center"">
                                <button class=""btn btn-info me-2 btn-admin"">Düzenle</button>
                                <button class=""btn btn-danger btn-admin"">Sil</button>
                            </td>
                        </tr>
");
#nullable restore
#line 265 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>
        <div class=""col-md-12 mt-2 border border-primary"">
            <div class=""title-text text-center row mb-1"">
                <div class=""col-md-9"">
                    <h2 style=""display:inline"">Yorumlar</h2>
                </div>
                <div class=""col-md-3""><button class=""btn btn-success me-2 btn-admin"">Yeni</button>
                </div>
            </div>
            <table class=""table table-bordered table-hover table-text admin"">
                <thead>
                    <tr class=""text-center"">
                        <th scope=""col"" style=""width:3%"">#</th>
                        <th scope=""col"">Image</th>
                        <th scope=""col"">Başlık</th>
                        <th scope=""col"">Yazı</th>
                        <th scope=""col"">isHome</th>
                        <th scope=""col"" style=""width: 25%;"">İşlemler</th>
                    </tr>
                </thead>
                <tb");
            WriteLiteral("ody>\r\n");
#nullable restore
#line 289 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Index.cshtml"
                     foreach (var test in Model.Testimonials)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th scope=\"row\">");
#nullable restore
#line 292 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Index.cshtml"
                                       Write(test.TestimonialId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td>");
#nullable restore
#line 293 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Index.cshtml"
                           Write(test.Image);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 294 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Index.cshtml"
                           Write(test.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 295 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Index.cshtml"
                           Write(test.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 296 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Index.cshtml"
                           Write(test.isHome);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                            <td class=""text-center"">
                                <button class=""btn btn-info me-2 btn-admin"">Düzenle</button>
                                <button class=""btn btn-danger btn-admin"">Sil</button>
                            </td>
                        </tr>
");
#nullable restore
#line 302 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdminViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
