#pragma checksum "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67b482d7dd0cad31c1ea03382d572cecd2f8d6a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 2 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Views\_ViewImports.cshtml"
using Ecommerce.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67b482d7dd0cad31c1ea03382d572cecd2f8d6a1", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcea1ceec51730adabee2574f8a6e833f15c94ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67b482d7dd0cad31c1ea03382d572cecd2f8d6a13194", async() => {
                WriteLiteral("\r\n    <title>");
#nullable restore
#line 5 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n\r\n    ");
#nullable restore
#line 7 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("_HeadPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 8 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Views\Shared\_Layout.cshtml"
Write(RenderSection("CSS", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67b482d7dd0cad31c1ea03382d572cecd2f8d6a15069", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Views\Shared\_Layout.cshtml"
      
        ViewData["BannerTag"] = "";
        if (ViewData["Title"].ToString().Equals("Home"))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"main-banner\" id=\"home\">\r\n                ");
#nullable restore
#line 16 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Views\Shared\_Layout.cshtml"
           Write(await Html.PartialAsync("_MainBannerPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 17 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Views\Shared\_Layout.cshtml"
           Write(await Html.PartialAsync("_BannerInforPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 19 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Views\Shared\_Layout.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"main-banner inner\" id=\"home\">\r\n                ");
#nullable restore
#line 23 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Views\Shared\_Layout.cshtml"
           Write(await Html.PartialAsync("_MainBannerPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 25 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Views\Shared\_Layout.cshtml"
        }

    

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 29 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("_BreadCrumbPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 30 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 32 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("_FootPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    \r\n    ");
#nullable restore
#line 34 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 35 "C:\Users\nxgth\OneDrive\Desktop\FinalASP.NETCore_xongCRUD\FinalASP.NETCorecong\FinalASP.NETCore\Ecommerce\Views\Shared\_Layout.cshtml"
Write(RenderSection("JS", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
