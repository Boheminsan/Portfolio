#pragma checksum "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\SubMenu\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a66df5f91bfebe4636b314d6207bc9d2420723ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_SubMenu_Index), @"mvc.1.0.view", @"/Views/Admin/SubMenu/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a66df5f91bfebe4636b314d6207bc9d2420723ba", @"/Views/Admin/SubMenu/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91615464df3ced54e946a5b71d4ddabe43cff52a", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_SubMenu_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SubMenu>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Admin/SubMenu/Delete/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\SubMenu\Index.cshtml"
  
    ViewData["Title"] = "Alt Menüler Anasayfa";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""col-md-12 mt-2 border border-primary"">
    <div class=""title-text text-center row mb-1"">
        <div class=""col-md-9"">
            <h2 style=""display:inline"">Menü</h2>
        </div>
        <div class=""col-md-3"">
            <a href=""/Admin/SubMenu/Create/"" class=""btn btn-success me-2 btn-md"">Yeni</a>
        </div>
    </div>
    <table class=""table table-bordered table-hover table-text admin"">
        <thead>
            <tr class=""text-center"">
                <th scope=""col"">#</th>
                <th scope=""col"">Alt Menü Adı</th>
                <th scope=""col"">Link</th>
                <th scope=""col"">Ebeveyn Id</th>
                <th scope=""col"" style=""width: 25%;"">İşlemler</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 26 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\SubMenu\Index.cshtml"
             foreach (var (item, i) in Model.Select((v, i) => (v, i)))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">");
#nullable restore
#line 29 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\SubMenu\Index.cshtml"
                               Write(item.SubMenuId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 30 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\SubMenu\Index.cshtml"
                   Write(item.SubMenuName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\SubMenu\Index.cshtml"
                   Write(item.Link);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\SubMenu\Index.cshtml"
                   Write(item.MenuItemId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"d-flex justify-content-center\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1305, "\"", 1349, 2);
            WriteAttributeValue("", 1312, "/Admin/SubMenu/Update/", 1312, 22, true);
#nullable restore
#line 34 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\SubMenu\Index.cshtml"
WriteAttributeValue("", 1334, item.SubMenuId, 1334, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                        class=\"btn btn-info text-light me-2 btn-md\">Düzenle</a>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a66df5f91bfebe4636b314d6207bc9d2420723ba7022", async() => {
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"SubMenuId\"");
                BeginWriteAttribute("value", " value=\"", 1576, "\"", 1599, 1);
#nullable restore
#line 37 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\SubMenu\Index.cshtml"
WriteAttributeValue("", 1584, item.SubMenuId, 1584, 15, false);

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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 42 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\SubMenu\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SubMenu>> Html { get; private set; }
    }
}
#pragma warning restore 1591
