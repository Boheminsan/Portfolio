#pragma checksum "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Shared\Components\Footer\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e798d8d4ffacdba211948b3b01079a1e69c6c697"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Footer_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Footer/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e798d8d4ffacdba211948b3b01079a1e69c6c697", @"/Views/Shared/Components/Footer/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91615464df3ced54e946a5b71d4ddabe43cff52a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Footer_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Footer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<footer class=\"footer-area\">\r\n    <div class=\"container footer\">\r\n        <div class=\"d-sm-flex flex-row justify-content-center flex-wrap\">\r\n            <div class=\"site-logo text-center py-4\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 236, "\"", 243, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 271, "\"", 277, 0);
            EndWriteAttribute();
            WriteLiteral(" alt=\"Buraya logo gelecek.\">\r\n                </a>\r\n                <div class=\"social text-center\">\r\n                    <h5>Beni takip edin:</h5>\r\n");
#nullable restore
#line 12 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Shared\Components\Footer\Default.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 526, "\"", 543, 1);
#nullable restore
#line 14 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 533, item.Link, 533, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i");
            BeginWriteAttribute("class", " class=\"", 547, "\"", 565, 1);
#nullable restore
#line 14 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 555, item.Icon, 555, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a>\r\n");
#nullable restore
#line 15 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Shared\Components\Footer\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
                <div class=""copyright text-center"">
                    <p class=""para"">
                        Copyright ©2020-2021 All Rights Reserved. This site designed by <a
                            href=""htttp://batuhanaktas.blogspot.com""><span
                                style=""color:var(--primary-color);"">Bohemsoft.</span></a>
                    </p>
                </div>
            </div>
        </div>
    </div>
</footer>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Footer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
