#pragma checksum "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61e1fd588d8641e6408c778e611e2f9c29a2a0ec"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61e1fd588d8641e6408c778e611e2f9c29a2a0ec", @"/Views/Projects/Draft.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91615464df3ced54e946a5b71d4ddabe43cff52a", @"/Views/_ViewImports.cshtml")]
    public class Views_Projects_Draft : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectCategoryViewModel>
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
            WriteLiteral("<section class=\"project-area\">\r\n    <div class=\"container\">\r\n        <div class=\"project-title pb-5\">\r\n            <h1 class=\"letterspaced text-uppercase text-center title-h1\">Yakında</h1>\r\n        </div>\r\n    </div>\r\n    <div class=\"button-group\">\r\n");
#nullable restore
#line 13 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
         if (Model.Categories.Count != 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
             foreach (var type in Model.Categories.Where(k => k.CType == CategoryType.Lang))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <button type=\"button\"");
            BeginWriteAttribute("class", " class=\"", 567, "\"", 575, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"btn1\" data-filter=\"");
#nullable restore
#line 17 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
                                                                 Write(type.Filter);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 17 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
                                                                               Write(type.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </button>\r\n");
#nullable restore
#line 19 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"button-group\">\r\n");
#nullable restore
#line 23 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
         if (Model.Categories.Count != 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
             foreach (var type in Model.Categories.Where(k => k.CType == CategoryType.Tech))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <button type=\"button\"");
            BeginWriteAttribute("class", " class=\"", 931, "\"", 939, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"btn1\" data-filter=\"");
#nullable restore
#line 27 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
                                                                 Write(type.CType);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 27 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
                                                                              Write(type.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </button>\r\n");
#nullable restore
#line 28 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"row grid\">\r\n");
#nullable restore
#line 32 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
         if (Model.Projects.Count != 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
             foreach (var item in Model.Projects)
            {
                var classes = "";
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div");
            BeginWriteAttribute("class", " class=\"", 1399, "\"", 1456, 5);
            WriteAttributeValue("", 1407, "col-lg-4", 1407, 8, true);
            WriteAttributeValue(" ", 1415, "col-md-6", 1416, 9, true);
            WriteAttributeValue(" ", 1424, "col-sm-12", 1425, 10, true);
            WriteAttributeValue(" ", 1434, "element-item", 1435, 13, true);
#nullable restore
#line 41 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
WriteAttributeValue(" ", 1447, classes, 1448, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
            WriteLiteral("                    <div class=\"our-project\">\r\n                        <div class=\"img\">\r\n                            <a class=\"test-popup-link\"");
            BeginWriteAttribute("href", " href=\"", 1649, "\"", 1687, 2);
            WriteAttributeValue("", 1656, "/Projects/Draft/", 1656, 16, true);
#nullable restore
#line 45 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
WriteAttributeValue("", 1672, item.ProjectId, 1672, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "61e1fd588d8641e6408c778e611e2f9c29a2a0ec9264", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1733, "~/assets/img/portfolio/", 1733, 23, true);
#nullable restore
#line 46 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
AddHtmlAttributeValue("", 1756, item.CoverImage, 1756, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 46 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
AddHtmlAttributeValue("", 1779, item.Title, 1779, 11, false);

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
            WriteLiteral("\r\n                            </a>\r\n                        </div>\r\n                        <div class=\"title py-4\">\r\n                            <h4 class=\"text-uppercase\">");
#nullable restore
#line 50 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
                                                  Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            <span class=\"text-secondary\">");
#nullable restore
#line 51 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
                                                    Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 55 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Draft.cshtml"
            }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectCategoryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
