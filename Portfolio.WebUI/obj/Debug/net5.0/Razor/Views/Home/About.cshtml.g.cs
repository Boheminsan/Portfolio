#pragma checksum "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba571223581b8e92b761482cf2b6cfb1b1463cd9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba571223581b8e92b761482cf2b6cfb1b1463cd9", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91615464df3ced54e946a5b71d4ddabe43cff52a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Home\About.cshtml"
  
    ViewData["Title"] = "Hakkımda";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container mt-3"">
    <div class=""row"">
        <div class=""col-6 mb-3"">
            <h3>Eğitim</h3>
            <div class=""card mb-3"">
                <div class=""card-body"">
                    <h5 class=""card-title"">Eskişehir Osmangazi Üniversitesi 2011-2017</h5>
                    <p class=""card-text"">FEF Matematik ve Bilgisayar Bilimleri</p>
                </div>
            </div>

            <div class=""card mb-3"">
                <div class=""card-body"">
                    <h5 class=""card-title"">Ankara Bahçelievler Anadolu Lisesi 2007-2011</h5>
                    <p class=""card-text"">Matematik ve Fen</p>
                </div>
            </div>

        </div>
        <div class=""col-6 mb-3"">
            <h3>Yetenekler</h3>
            <div class=""row"">

                <div class=""col-6"">
                    <div class=""card  mb-3"">
                        <div class=""card-body"">
                            <h5 class=""card-title"">Front End</h5>
          ");
            WriteLiteral(@"                  <ul>
                                <li class=""card-text"">HTML</li>
                                <li class=""card-text"">CSS</li>
                                <li class=""card-text"">JS</li>
                                <li>Frameworks
                                    <ul>
                                        <li class=""card-text"">JQuery</li>
                                        <li class=""card-text"">Bootstrap</li>
                                    </ul>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>

                <div class=""col-6"">
                    <div class=""card mb-3"">
                        <div class=""card-body"">
                            <h5 class=""card-title"">Back End</h5>
                            <ul>
                                <li class=""card-text"">C#
                                    <ul>
                               ");
            WriteLiteral(@"         <li class=""card-text"">ASP.NET Core MVC</li>
                                        <li class=""card-text"">Entity Framework</li>
                                    </ul>
                                </li>
                                <li class=""card-text"">MSSQL</li>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""row"">
                <div class=""col-6"">
                    <div class=""card mb-3"">
                        <div class=""card-body"">
                            <h5 class=""card-title"">Python</h5>
                            <ul>
                                <li class=""card-text"">Veri Görselleştirme
                                    <ul>
                                        <li class=""card-text"">Matplotlib</li>
                                        <li class=""card-text"">Plotly</li>
                          ");
            WriteLiteral(@"              <li class=""card-text"">Seaborn</li>
                                    </ul>
                                </li>
                                <li class=""card-text"">Makine Öğrenmesi
                                    <ul>
                                        <li class=""card-text"">Pandas</li>
                                        <li class=""card-text"">Numpy</li>
                                        <li class=""card-text"">Scikit-Learn</li>
                                    </ul>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
                <div class=""col-6"">
                    <div class=""card mb-3"">
                        <div class=""card-body"">
                            <h5 class=""card-title"">C#</h5>
                            <ul>
                                <li class=""card-text"">WinForms</li>
                                <li class=""card-text""");
            WriteLiteral(@">Metro Framework</li>
                                <li class=""card-text"">HTML Agility Pack</li>
                                <li class=""card-text"">VLCLib</li>
                                <li class=""card-text"">CefSharp</li>

                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591