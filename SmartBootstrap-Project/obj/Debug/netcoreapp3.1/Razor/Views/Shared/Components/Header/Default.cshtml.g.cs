#pragma checksum "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\SmartBootstrap-Project\SmartBootstrap-Project\Views\Shared\Components\Header\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72bdda3b327afb4722af16b0b452fccf9f140f3a"
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
#line 1 "D:\HP\Documents\Private\Code Academy\Back-End\ASP.Net\SmartBootstrap-Project\SmartBootstrap-Project\Views\_ViewImports.cshtml"
using SmartBootstrap_Project.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72bdda3b327afb4722af16b0b452fccf9f140f3a", @"/Views/Shared/Components/Header/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"170b415e6c9fc8e81e601fefd47aed54c071a263", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Header_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<header>
    <section id=""nav"" style=""background-color: #2c3e50;"" class=""navres"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <nav class=""navbar navbar-expand-lg"">
                        <a class=""navbar-brand"" href=""#"">SMART BOOTSTRAP</a>
                        <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse""
                                data-target=""#navbarNav"" aria-controls=""navbarNav"" aria-expanded=""false""
                                aria-label=""Toggle navigation"">
                            <span class=""navbar-toggler-icon d-flex justify-content-end burger"">Menu <i class=""fas fa-bars"" aria-hidden=""true""></i></span>
                        </button>
                        <div class=""collapse navbar-collapse d-flex justify-content-end burgerBack"" id=""navbarNav"">
                            <ul class=""navbar-nav"">
                                <li class=""nav-item active"">
           ");
            WriteLiteral(@"                         <a class=""nav-link"" href=""#portfolio"">
                                        PORTFOLIO <span class=""sr-only"">(current)</span>
                                    </a>
                                </li>
                                <li class=""nav-item"">
                                    <a class=""nav-link"" href=""#about"">ABOUT</a>
                                </li>
                                <li class=""nav-item"">
                                    <a class=""nav-link"" href=""#contact"">CONTACT</a>
                                </li>
                            </ul>
                        </div>
                    </nav>
                </div>
            </div>
        </div>
    </section>
</header>");
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
