#pragma checksum "C:\Users\Guilmar\source\repos\fukin_project\fukin_project\Areas\Identity\Pages\_AuthLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d87dce838d0e050d7c0a0a9a14ea2ed0f955f512"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages__AuthLayout), @"mvc.1.0.view", @"/Areas/Identity/Pages/_AuthLayout.cshtml")]
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
#line 1 "C:\Users\Guilmar\source\repos\fukin_project\fukin_project\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Guilmar\source\repos\fukin_project\fukin_project\Areas\Identity\Pages\_ViewImports.cshtml"
using fukin_project.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Guilmar\source\repos\fukin_project\fukin_project\Areas\Identity\Pages\_ViewImports.cshtml"
using fukin_project.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Guilmar\source\repos\fukin_project\fukin_project\Areas\Identity\Pages\_ViewImports.cshtml"
using fukin_project.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d87dce838d0e050d7c0a0a9a14ea2ed0f955f512", @"/Areas/Identity/Pages/_AuthLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1072e6c4f3f347e33b84a5d9e808ffbd936fc3f9", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    public class Areas_Identity_Pages__AuthLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Guilmar\source\repos\fukin_project\fukin_project\Areas\Identity\Pages\_AuthLayout.cshtml"
  
    Layout = "/Views/Shared/_Layout.cshtml";



#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-md-6 offset-md-3"">
            <div class=""card login-logout-tab"">
                <div class=""card-header"">
                    <ul class=""nav nav-tabs card-header-tabs"">
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/Identity/Account/Login"">Sign in</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/Identity/Account/Register"">Sign up</a>
                        </li>
                    </ul>

                </div>
                <div class=""card-content"">
                    <div class=""row"">
                        <div class=""col-md-12"">
                            ");
#nullable restore
#line 23 "C:\Users\Guilmar\source\repos\fukin_project\fukin_project\Areas\Identity\Pages\_AuthLayout.cshtml"
                       Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                    </div>\n                </div>\n\n            </div>\n        </div>\n    </div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(" \n    ");
#nullable restore
#line 33 "C:\Users\Guilmar\source\repos\fukin_project\fukin_project\Areas\Identity\Pages\_AuthLayout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
<script>
    $(function () {
        var current = location.pathname;
        $(' .nav-tabs li a').each(function () {
            var $this = $(this); 
            if (current.indexOf($this.attr('href')) !== -1) {
                $this.addClass('active');
            }
        })
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
