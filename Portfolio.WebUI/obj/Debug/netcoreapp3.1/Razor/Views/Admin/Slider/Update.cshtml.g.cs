#pragma checksum "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Slider\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9e24ebd1da1c00aff0594eab122d481878c24fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Slider_Update), @"mvc.1.0.view", @"/Views/Admin/Slider/Update.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9e24ebd1da1c00aff0594eab122d481878c24fb", @"/Views/Admin/Slider/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91615464df3ced54e946a5b71d4ddabe43cff52a", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Slider_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Slider>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Slider", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Slider\Update.cshtml"
  
    ViewData["Title"] = "Slider Düzenle";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container mt-4 pt-4\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-10\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9e24ebd1da1c00aff0594eab122d481878c24fb5719", async() => {
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"SliderId\"");
                BeginWriteAttribute("value", " value=\"", 368, "\"", 391, 1);
#nullable restore
#line 10 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Slider\Update.cshtml"
WriteAttributeValue("", 376, Model.SliderId, 376, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <input type=\"hidden\" name=\"Image.ImageId\"");
                BeginWriteAttribute("value", " value=\"", 452, "\"", 474, 1);
#nullable restore
#line 11 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Slider\Update.cshtml"
WriteAttributeValue("", 460, Model.ImageId, 460, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <div class=\"mb-3\">\r\n                    <label class=\"form-label\" for=\"ImageName\"></label>\r\n                    <input for=\"ImageName\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 649, "\"", 679, 1);
#nullable restore
#line 14 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Slider\Update.cshtml"
WriteAttributeValue("", 657, Model.Image.ImageName, 657, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a9e24ebd1da1c00aff0594eab122d481878c24fb7442", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 713, "~/", 713, 2, true);
#nullable restore
#line 15 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Slider\Update.cshtml"
AddHtmlAttributeValue("", 715, Model.Image.FullPath, 715, 21, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 736, "/", 736, 1, true);
#nullable restore
#line 15 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Slider\Update.cshtml"
AddHtmlAttributeValue("", 737, Model.Image.ImageName, 737, 22, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 16 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Slider\Update.cshtml"
AddHtmlAttributeValue("", 803, Model.Image.ImageName, 803, 22, false);

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
                WriteLiteral(@"
                </div>
                <div class=""mb-3 mt-4"">
                <div id=""gizle"" class=""btn btn-sm btn-outline-primary"">Gizle/Göster</div>
                    <div class=""btn btn-sm btn-outline-success"" id=""secimiTemizle"">Seçimi Temizle</div>
                    <div class=""row"" id=""gallery"">
");
#nullable restore
#line 22 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Slider\Update.cshtml"
                         if (ViewBag.Images != null)
                        {
                           

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Slider\Update.cshtml"
                            foreach (var item in (List<Image>)ViewBag.Images)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"form-check col-lg-3 col-xl-2\">\r\n                                <input class=\"form-check-input\" type=\"radio\" name=\"imgId\"");
                BeginWriteAttribute("value", " value=\"", 1494, "\"", 1515, 1);
#nullable restore
#line 27 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Slider\Update.cshtml"
WriteAttributeValue("", 1502, item.ImageId, 1502, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 1516, "\"", 1538, 2);
                WriteAttributeValue("", 1521, "img_", 1521, 4, true);
#nullable restore
#line 27 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Slider\Update.cshtml"
WriteAttributeValue("", 1525, item.ImageId, 1525, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n                                ");
#nullable restore
#line 28 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Slider\Update.cshtml"
                            Write(Model.Image.ImageId==item.ImageId?"checked":"");

#line default
#line hidden
#nullable disable
                WriteLiteral(">\r\n                                <label class=\"form-check-label\"");
                BeginWriteAttribute("for", " for=\"", 1688, "\"", 1711, 2);
                WriteAttributeValue("", 1694, "img_", 1694, 4, true);
#nullable restore
#line 29 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Slider\Update.cshtml"
WriteAttributeValue("", 1698, item.ImageId, 1698, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a9e24ebd1da1c00aff0594eab122d481878c24fb12562", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1779, "~/", 1779, 2, true);
#nullable restore
#line 30 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Slider\Update.cshtml"
AddHtmlAttributeValue("", 1781, item.FullPath, 1781, 14, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 1795, "/", 1795, 1, true);
#nullable restore
#line 30 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Slider\Update.cshtml"
AddHtmlAttributeValue("", 1796, item.ImageName, 1796, 15, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 30 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Slider\Update.cshtml"
AddHtmlAttributeValue("", 1818, item.ImageName, 1818, 15, false);

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
                WriteLiteral("\r\n                                </label>\r\n                            </div>\r\n");
#nullable restore
#line 33 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Slider\Update.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Slider\Update.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </div>
                    <div class=""row w-50"" id=""tekli"">
                        <input type=""file"" name=""file"" id=""file"" class=""form-control"">
                    </div>
                </div>
                <div class=""form-check form-switch mb-3"">
                    <input class=""form-check-input"" type=""checkbox"" ");
#nullable restore
#line 41 "D:\Web Programlama\Portfolio\Portfolio.WebUI\Views\Admin\Slider\Update.cshtml"
                                                                Write(Model.isHome?"checked":"");

#line default
#line hidden
#nullable disable
                WriteLiteral(@" id=""isHomeBool""
                        name=""isHomeBool"">
                    <label class=""form-check-label"" for=""isHomeBool"">
                        Anasayfada mı? </label>
                </div>
                <button type=""submit"" class=""btn btn-success"">Kaydet</button>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Slider> Html { get; private set; }
    }
}
#pragma warning restore 1591
