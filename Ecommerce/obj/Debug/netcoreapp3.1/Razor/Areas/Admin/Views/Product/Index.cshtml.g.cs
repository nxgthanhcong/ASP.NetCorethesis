#pragma checksum "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Areas\Admin\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b52c9874571f5e4eeeca4c2914ae5162d203db65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/Index.cshtml")]
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
#line 2 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Areas\Admin\Views\_ViewImports.cshtml"
using Ecommerce.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b52c9874571f5e4eeeca4c2914ae5162d203db65", @"/Areas/Admin/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcea1ceec51730adabee2574f8a6e833f15c94ce", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Ecommerce.Areas.Admin.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100px; height: auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Areas\Admin\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b52c9874571f5e4eeeca4c2914ae5162d203db656498", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b52c9874571f5e4eeeca4c2914ae5162d203db657665", async() => {
                WriteLiteral("\r\n    <p>\r\n        Name: <input type=\"text\" name=\"SearchString\">\r\n        <input type=\"submit\" value=\"Sreach\" />\r\n    </p>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Areas\Admin\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Areas\Admin\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SerialNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Areas\Admin\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Areas\Admin\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Imgage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Areas\Admin\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Areas\Admin\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Brand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Areas\Admin\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Namsx));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Areas\Admin\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TinhTrang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Areas\Admin\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 52 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Areas\Admin\Views\Product\Index.cshtml"
         foreach (Product item in ViewBag.listProduct)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Areas\Admin\Views\Product\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 59 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Areas\Admin\Views\Product\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.SerialNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 62 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Areas\Admin\Views\Product\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b52c9874571f5e4eeeca4c2914ae5162d203db6514666", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1858, "~/img/pro/", 1858, 10, true);
#nullable restore
#line 65 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Areas\Admin\Views\Product\Index.cshtml"
AddHtmlAttributeValue("", 1868, Html.DisplayFor(modelItem => item.Imgage), 1868, 42, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 68 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Areas\Admin\Views\Product\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Category.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 71 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Areas\Admin\Views\Product\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Brand.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 74 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Areas\Admin\Views\Product\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Namsx));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 77 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Areas\Admin\Views\Product\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TinhTrang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <input");
            BeginWriteAttribute("id", " id=\"", 2470, "\"", 2483, 1);
#nullable restore
#line 80 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Areas\Admin\Views\Product\Index.cshtml"
WriteAttributeValue("", 2475, item.ID, 2475, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"checkbox\" name=\"name\"\r\n                           ");
#nullable restore
#line 81 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Areas\Admin\Views\Product\Index.cshtml"
                              if (item.Status == true) {

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            WriteLiteral(" checked\r\n");
#nullable restore
#line 82 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Areas\Admin\Views\Product\Index.cshtml"
                           } else {

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            WriteLiteral(" uncheck\r\n");
#nullable restore
#line 83 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Areas\Admin\Views\Product\Index.cshtml"
                           } 

#line default
#line hidden
#nullable disable
            WriteLiteral(" disabled />\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b52c9874571f5e4eeeca4c2914ae5162d203db6519551", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 86 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Areas\Admin\Views\Product\Index.cshtml"
                                                                   WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b52c9874571f5e4eeeca4c2914ae5162d203db6521897", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 87 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Areas\Admin\Views\Product\Index.cshtml"
                                                                      WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                    <button id=\"txtbtn\" class=\"btn btn-warning\" name=\"btn_update_stt\" data-id=\"");
#nullable restore
#line 88 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Areas\Admin\Views\Product\Index.cshtml"
                                                                                          Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-stt=\"");
#nullable restore
#line 88 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Areas\Admin\Views\Product\Index.cshtml"
                                                                                                               Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-name=\"");
#nullable restore
#line 88 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Areas\Admin\Views\Product\Index.cshtml"
                                                                                                                                         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n");
#nullable restore
#line 89 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Areas\Admin\Views\Product\Index.cshtml"
                          
                            if (item.Status == true)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            WriteLiteral("Ẩn\r\n");
#nullable restore
#line 93 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Areas\Admin\Views\Product\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            WriteLiteral("Hiện\r\n");
#nullable restore
#line 97 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Areas\Admin\Views\Product\Index.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 102 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Areas\Admin\Views\Product\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 106 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Areas\Admin\Views\Product\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral(@"
    <script>
        var stt = ($('button[name=btn_update_stt]').attr('data-stt'));
        stt = JSON.parse(stt.toLowerCase());

        $('button[name=btn_update_stt]').on('click', function () {
            var id = $(this).attr('data-id');

            $.ajax({
                method: ""POST"",
                url: ""../api/product_api/UpdateStatus"",
                contentType: 'application/json; charset=UTF-8',
                data: JSON.stringify({ ""ma"": parseInt(id), ""stt"": stt }),
                success: function (msg) {
                    if (msg == '0') {
                        alert(""Cập nhập thất bại!!"");
                    }
                    else {
                        var r = JSON.parse(msg);
                        if (r.stt == ""True"") {
                            $('button[name=btn_update_stt][data-id=' + r.id + ']').html('Ẩn');
                            $(""#"" + id).prop(""checked"", true);
                            stt = !stt;
                        }
     ");
                WriteLiteral(@"                   else {
                            $('button[name=btn_update_stt][data-id=' + r.id + ']').html('Hiện');
                            $(""#"" + id).prop(""checked"", false);
                            stt = !stt;
                        }
                    }
                },
                error: function (err) {
                    console.log(err)
                }
            })
        })

        function readURL(input, idImg) {
            if (input.files && input.files[0]) {
                var reader = new FileReader();

                reader.onload = function (e) {
                    $(idImg).attr('src', e.target.result);
                }

                reader.readAsDataURL(input.files[0]); // convert to base64 string
            }
        }

        $(""#ful"").change(function () {
            readURL(this, '#imgPre');
        })

    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Ecommerce.Areas.Admin.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591