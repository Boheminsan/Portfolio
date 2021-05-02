#pragma checksum "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b825b27fe1f93955abade07032b52cbefb5cb1e3"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b825b27fe1f93955abade07032b52cbefb5cb1e3", @"/Views/Projects/Draft.cshtml")]
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

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"<section class=""project-area"">
    <div class=""container"">
        <div class=""project-title pb-5"">
            <h1 class=""letterspaced text-uppercase text-center title-h1"">Taslak projeler</h1>
        </div>
    </div>
    <div class=""button-group"">
");
#nullable restore
#line 14 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
         foreach (var type in (List<Category>)ViewBag.SelectedCategories)
        {
            if (type.CType == CategoryType.Lang)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <button type=\"button\"");
            BeginWriteAttribute("class", " class=\"", 554, "\"", 562, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"btn1\" data-filter=\"");
#nullable restore
#line 18 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
                                                                 Write(type.Filter);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 18 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
                                                                               Write(type.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </button>\r\n");
#nullable restore
#line 20 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"button-group\">\r\n");
#nullable restore
#line 24 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
         foreach (var type in (List<Category>)ViewBag.SelectedCategories)
        {
            if (type.CType == CategoryType.Tech)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <button type=\"button\"");
            BeginWriteAttribute("class", " class=\"", 906, "\"", 914, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"btn1\" data-filter=\"");
#nullable restore
#line 28 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
                                                                 Write(type.Filter);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 28 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
                                                                               Write(type.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </button>\r\n");
#nullable restore
#line 30 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"row grid\">\r\n");
#nullable restore
#line 34 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
         foreach (var item in Model)
        {
            var classes = "";
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("class", " class=\"", 1299, "\"", 1356, 5);
            WriteAttributeValue("", 1307, "col-lg-4", 1307, 8, true);
            WriteAttributeValue(" ", 1315, "col-md-6", 1316, 9, true);
            WriteAttributeValue(" ", 1324, "col-sm-12", 1325, 10, true);
            WriteAttributeValue(" ", 1334, "element-item", 1335, 13, true);
#nullable restore
#line 41 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
WriteAttributeValue(" ", 1347, classes, 1348, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
            WriteLiteral("                <div class=\"our-project\">\r\n                    <div class=\"img\">\r\n                        <a class=\"test-popup-link\"");
            BeginWriteAttribute("href", " href=\"", 1533, "\"", 1571, 2);
            WriteAttributeValue("", 1540, "/Projects/Draft/", 1540, 16, true);
#nullable restore
#line 45 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
WriteAttributeValue("", 1556, item.ProjectId, 1556, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b825b27fe1f93955abade07032b52cbefb5cb1e38341", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1613, "~/assets/img/portfolio/", 1613, 23, true);
#nullable restore
#line 46 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
AddHtmlAttributeValue("", 1636, item.CoverImage, 1636, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 46 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
AddHtmlAttributeValue("", 1659, item.Title, 1659, 11, false);

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
#line 50 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
                                              Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <span class=\"text-secondary\">");
#nullable restore
#line 51 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
                                                Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 55 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
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