#pragma checksum "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\Shared\Components\Header\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f4d7cb51dfde4d54fd261b00f56ac43afefde38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Header_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Header/Default.cshtml")]
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
#line 1 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\_ViewImports.cshtml"
using CorkBoardUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\_ViewImports.cshtml"
using CorkBoardUI.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f4d7cb51dfde4d54fd261b00f56ac43afefde38", @"/Views/Shared/Components/Header/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"977f12720aff1e491a5cec67a59b8bba8f711f02", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Header_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!--Page Header-->\r\n<header class=\"masthead\"");
            BeginWriteAttribute("style", " style=\"", 44, "\"", 101, 4);
            WriteAttributeValue("", 52, "background-image:", 52, 17, true);
            WriteAttributeValue(" ", 69, "url(\'", 70, 6, true);
#nullable restore
#line 2 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\Shared\Components\Header\Default.cshtml"
WriteAttributeValue("", 75, ViewData["HeaderImage"], 75, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 99, "\')", 99, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"overlay\"></div>\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-8 col-md-10 mx-auto\">\r\n                <div class=\"site-heading\">\r\n                    <h1>");
#nullable restore
#line 8 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\Shared\Components\Header\Default.cshtml"
                   Write(ViewData["HeaderTitle"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    <span class=\"subheading\">");
#nullable restore
#line 9 "C:\Lessons\ASP.NET\Complete ASP.NET Core Applications\CorkBoardFiles\CorkBoard\CorkBoardUI\Views\Shared\Components\Header\Default.cshtml"
                                        Write(ViewData["SubHeader"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</header>");
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
