#pragma checksum "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "effe9893b71ed262a36b2804b290b387ed0d5f73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projects_Draft), @"mvc.1.0.view", @"/Views/Projects/Draft.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"effe9893b71ed262a36b2804b290b387ed0d5f73", @"/Views/Projects/Draft.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91615464df3ced54e946a5b71d4ddabe43cff52a", @"/Views/_ViewImports.cshtml")]
    public class Views_Projects_Draft : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Project>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "Taslak";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"<section class=""project-area"">
    <div class=""container"">
        <div class=""project-title pb-5"">
            <h1 class=""letterspaced text-uppercase text-center title-h1"">Taslak Projeler</h1>
        </div>
    </div>
    <div class=""button-group"">
        <button type=""button"" class=""active"" id=""btn0"" data-filter=""*"">Tümü</button>
");
#nullable restore
#line 16 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
         foreach (var type in (List<Category>)ViewBag.SelectedCategories)
        {
            if (type.CType == CategoryType.Lang)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <button type=\"button\"");
            BeginWriteAttribute("class", " class=\"", 675, "\"", 683, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"btn@type.CategoryId\" data-filter=\"");
#nullable restore
#line 20 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
                                                                                Write(type.Filter);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 20 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
                                                                                              Write(type.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </button>\r\n");
#nullable restore
#line 22 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"button-group\">\r\n");
#nullable restore
#line 26 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
         foreach (var type in (List<Category>)ViewBag.SelectedCategories)
        {
            if (type.CType == CategoryType.Tech)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <button type=\"button\"");
            BeginWriteAttribute("class", " class=\"", 1042, "\"", 1050, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"btn@type.CategoryId\" data-filter=\"");
#nullable restore
#line 30 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
                                                                                Write(type.Filter);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 30 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
                                                                                              Write(type.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </button>\r\n");
#nullable restore
#line 32 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"row grid\">\r\n");
#nullable restore
#line 36 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
         foreach (var item in Model)
        {
            var categories = (List<Category>)ViewBag.SelectedCategories;
            var classes = "";
            foreach (var cat in categories)
            {
                if (item.Categories.Any(z => z.CategoryId == cat.CategoryId))
                {
                    classes += cat.Filter.Replace(".", "") + " ";
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("class", " class=\"", 1646, "\"", 1703, 5);
            WriteAttributeValue("", 1654, "col-lg-4", 1654, 8, true);
            WriteAttributeValue(" ", 1662, "col-md-6", 1663, 9, true);
            WriteAttributeValue(" ", 1671, "col-sm-12", 1672, 10, true);
            WriteAttributeValue(" ", 1681, "element-item", 1682, 13, true);
#nullable restore
#line 47 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
WriteAttributeValue(" ", 1694, classes, 1695, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
            WriteLiteral("                <div class=\"our-project\">\r\n                    <div class=\"img\">\r\n                        <a class=\"test-popup-link\"");
            BeginWriteAttribute("href", " href=\"", 1880, "\"", 1918, 2);
            WriteAttributeValue("", 1887, "/Projects/Draft/", 1887, 16, true);
#nullable restore
#line 51 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
WriteAttributeValue("", 1903, item.ProjectId, 1903, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "effe9893b71ed262a36b2804b290b387ed0d5f738881", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1960, "~/assets/img/portfolio/", 1960, 23, true);
#nullable restore
#line 52 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
AddHtmlAttributeValue("", 1983, item.CoverImage, 1983, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 52 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
AddHtmlAttributeValue("", 2006, item.Title, 2006, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </a>\r\n                    </div>\r\n                    <div class=\"title py-4\">\r\n                        <h4 class=\"text-uppercase\">");
#nullable restore
#line 56 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
                                              Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <span class=\"text-secondary\">");
#nullable restore
#line 57 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
                                                Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 61 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Project>> Html { get; private set; }
    }
}
#pragma warning restore 1591
