#pragma checksum "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74396033878e36b37a0b794d08cc1306e873ba35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projects_Details), @"mvc.1.0.view", @"/Views/Projects/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74396033878e36b37a0b794d08cc1306e873ba35", @"/Views/Projects/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91615464df3ced54e946a5b71d4ddabe43cff52a", @"/Views/_ViewImports.cshtml")]
    public class Views_Projects_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Details.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\" style=\"margin-top:1rem;\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n            <div id=\"carouselExampleIndicators\" class=\"carousel slide\" data-bs-ride=\"carousel\">\r\n                <div class=\"carousel-indicators\">\r\n");
#nullable restore
#line 10 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Details.cshtml"
                     for (int i = 0; i < Model.Images.Count; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button type=\"button\" data-bs-target=\"#carouselExampleIndicators\" data-bs-slide-to=\"");
#nullable restore
#line 12 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Details.cshtml"
                                                                                                        Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("class", "\r\n                        class=\'", 526, "\'", 578, 1);
#nullable restore
#line 13 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Details.cshtml"
WriteAttributeValue("", 559, i==0?"active":"", 559, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-current=\"true\"");
            BeginWriteAttribute("aria-label", " aria-label=\"", 599, "\"", 624, 2);
            WriteAttributeValue("", 612, "Slide", 612, 5, true);
#nullable restore
#line 13 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Details.cshtml"
WriteAttributeValue(" ", 617, i+1, 618, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></button>\r\n");
#nullable restore
#line 14 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 17 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Details.cshtml"
                     foreach (var res in Model.Images.Select((item, index) => new { item, index }))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("class", " class=\'", 882, "\'", 931, 2);
            WriteAttributeValue("", 890, "carousel-item", 890, 13, true);
#nullable restore
#line 19 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Details.cshtml"
WriteAttributeValue(" ", 903, res.index==0?"active":"", 904, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "74396033878e36b37a0b794d08cc1306e873ba356580", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 973, "~/", 973, 2, true);
#nullable restore
#line 20 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Details.cshtml"
AddHtmlAttributeValue("", 975, res.item.FullPath, 975, 18, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 993, "/", 993, 1, true);
#nullable restore
#line 20 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Details.cshtml"
AddHtmlAttributeValue("", 994, res.item.ImageName, 994, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 21 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Details.cshtml"
AddHtmlAttributeValue("", 1071, res.item.ImageName, 1071, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 23 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
                <button class=""carousel-control-prev"" type=""button"" data-bs-target=""#carouselExampleIndicators""
                    data-bs-slide=""prev"">
                    <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                    <span class=""visually-hidden"">Previous</span>
                </button>
                <button class=""carousel-control-next"" type=""button"" data-bs-target=""#carouselExampleIndicators""
                    data-bs-slide=""next"">
                    <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                    <span class=""visually-hidden"">Next</span>
                </button>
            </div>
        </div>
        <div class=""col-md-8"">
            <h2> ");
#nullable restore
#line 38 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Details.cshtml"
            Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <p>\r\n                ");
#nullable restore
#line 40 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Projects\Details.cshtml"
           Write(Model.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project> Html { get; private set; }
    }
}
#pragma warning restore 1591
