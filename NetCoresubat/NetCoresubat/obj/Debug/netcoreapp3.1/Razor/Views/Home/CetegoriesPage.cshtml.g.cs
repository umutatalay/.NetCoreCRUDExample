#pragma checksum "D:\Users\UMUT\source\repos\NetCoresubat\NetCoresubat\Views\Home\CetegoriesPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46ab91cdbe85c56abb45f9f7a8c121891f29d44f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CetegoriesPage), @"mvc.1.0.view", @"/Views/Home/CetegoriesPage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46ab91cdbe85c56abb45f9f7a8c121891f29d44f", @"/Views/Home/CetegoriesPage.cshtml")]
    public class Views_Home_CetegoriesPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<NetCoresubat.Entities.category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Users\UMUT\source\repos\NetCoresubat\NetCoresubat\Views\Home\CetegoriesPage.cshtml"
  
    ViewData["Title"] = "CetegoriesPage";
    Layout = "~/Views/Shared/_MainLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>CetegoriesPage</h1>\r\n\r\n<table>\r\n    <thead>\r\n        <tr>ID</tr>\r\n        <tr>Categories Name</tr>\r\n    </thead>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 15 "D:\Users\UMUT\source\repos\NetCoresubat\NetCoresubat\Views\Home\CetegoriesPage.cshtml"
             foreach (var item in Model)
        {
             

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Users\UMUT\source\repos\NetCoresubat\NetCoresubat\Views\Home\CetegoriesPage.cshtml"
        Write(item.categoryID);

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Users\UMUT\source\repos\NetCoresubat\NetCoresubat\Views\Home\CetegoriesPage.cshtml"
                             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n        <td>");
#nullable restore
#line 20 "D:\Users\UMUT\source\repos\NetCoresubat\NetCoresubat\Views\Home\CetegoriesPage.cshtml"
              foreach (var name in Model)
        {
              

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\Users\UMUT\source\repos\NetCoresubat\NetCoresubat\Views\Home\CetegoriesPage.cshtml"
         Write(name.categoryName);

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\Users\UMUT\source\repos\NetCoresubat\NetCoresubat\Views\Home\CetegoriesPage.cshtml"
                                
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<NetCoresubat.Entities.category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
