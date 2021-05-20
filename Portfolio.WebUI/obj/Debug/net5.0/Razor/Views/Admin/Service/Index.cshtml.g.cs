#pragma checksum "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Service\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d69e2a6c104adbf804c10b35169c2922bb138c08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Service_Index), @"mvc.1.0.view", @"/Views/Admin/Service/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d69e2a6c104adbf804c10b35169c2922bb138c08", @"/Views/Admin/Service/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91615464df3ced54e946a5b71d4ddabe43cff52a", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Service_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Service>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Admin/Service/Delete/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Service\Index.cshtml"
  
    ViewData["Title"] = "Servisler Anasayfa";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""col-md-12 mt-2 border border-primary"">
    <div class=""title-text text-center row mb-1"">
        <div class=""col-md-9"">
            <h2 style=""display:inline"">Servisler</h2>
        </div>
        <div class=""col-md-3""><a href=""/Admin/Service/Create/"" class=""btn btn-success me-2 btn-md"">Yeni</a>
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
        <tbody>
");
#nullable restore
#line 27 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Service\Index.cshtml"
             foreach (var service in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">");
#nullable restore
#line 30 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Service\Index.cshtml"
                               Write(service.ServiceId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td class=\"text-center\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d69e2a6c104adbf804c10b35169c2922bb138c086167", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1178, "~/", 1178, 2, true);
#nullable restore
#line 32 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Service\Index.cshtml"
AddHtmlAttributeValue("", 1180, service.Image.FullPath, 1180, 23, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1203, "/", 1203, 1, true);
#nullable restore
#line 32 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Service\Index.cshtml"
AddHtmlAttributeValue("", 1204, service.Image.ImageName, 1204, 24, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 32 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Service\Index.cshtml"
AddHtmlAttributeValue("", 1235, service.Image.ImageName, 1235, 24, false);

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
            WriteLiteral("\r\n                    </td>\r\n                    <td>");
#nullable restore
#line 35 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Service\Index.cshtml"
                   Write(service.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 36 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Service\Index.cshtml"
                   Write(service.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 37 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Service\Index.cshtml"
                   Write(service.isHome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"d-flex justify-content-center\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1552, "\"", 1599, 2);
            WriteAttributeValue("", 1559, "/Admin/Service/Update/", 1559, 22, true);
#nullable restore
#line 39 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Service\Index.cshtml"
WriteAttributeValue("", 1581, service.ServiceId, 1581, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                        class=\"btn btn-info text-light me-2 btn-md\">Düzenle</a>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d69e2a6c104adbf804c10b35169c2922bb138c089987", async() => {
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"ServiceId\"");
                BeginWriteAttribute("value", " value=\"", 1826, "\"", 1852, 1);
#nullable restore
#line 42 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Service\Index.cshtml"
WriteAttributeValue("", 1834, service.ServiceId, 1834, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <button type=\"submit\" class=\"btn btn-danger btn-md\">Sil</button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 47 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Service\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Service>> Html { get; private set; }
    }
}
#pragma warning restore 1591