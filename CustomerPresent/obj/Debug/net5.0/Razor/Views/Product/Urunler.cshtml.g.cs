#pragma checksum "C:\Users\user\source\repos\AdminPannelMVC\CustomerPresent\Views\Product\Urunler.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f8b1956a55a832779d6a520b54d3e9f9749e1aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Urunler), @"mvc.1.0.view", @"/Views/Product/Urunler.cshtml")]
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
#line 1 "C:\Users\user\source\repos\AdminPannelMVC\CustomerPresent\Views\_ViewImports.cshtml"
using CustomerPresent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\AdminPannelMVC\CustomerPresent\Views\_ViewImports.cshtml"
using CustomerPresent.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\user\source\repos\AdminPannelMVC\CustomerPresent\Views\Product\Urunler.cshtml"
using EntityLayer;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f8b1956a55a832779d6a520b54d3e9f9749e1aa", @"/Views/Product/Urunler.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd962a422df01fb9d74fb520de8fee1c0ac92f05", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Urunler : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n <table id=\"example\" class=\"table table-dark table-striped\" style=\"width:100%\">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t<th>ID</th>\r\n\t\t\t<th>Name</th>\r\n\t\t\t<th>Description</th>\r\n\t\t\t<th>Price</th>\r\n\t\t\t<th>Stock</th>\r\n\t\t</tr>\r\n\t</thead>\r\n\t<tbody>\r\n");
#nullable restore
#line 16 "C:\Users\user\source\repos\AdminPannelMVC\CustomerPresent\Views\Product\Urunler.cshtml"
         foreach (var a in Model)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<tr>\r\n\t\t\t\t<td>");
#nullable restore
#line 19 "C:\Users\user\source\repos\AdminPannelMVC\CustomerPresent\Views\Product\Urunler.cshtml"
               Write(a.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t<td>");
#nullable restore
#line 20 "C:\Users\user\source\repos\AdminPannelMVC\CustomerPresent\Views\Product\Urunler.cshtml"
               Write(a.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t<td>");
#nullable restore
#line 21 "C:\Users\user\source\repos\AdminPannelMVC\CustomerPresent\Views\Product\Urunler.cshtml"
               Write(a.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t<td>");
#nullable restore
#line 22 "C:\Users\user\source\repos\AdminPannelMVC\CustomerPresent\Views\Product\Urunler.cshtml"
               Write(a.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t<td>");
#nullable restore
#line 23 "C:\Users\user\source\repos\AdminPannelMVC\CustomerPresent\Views\Product\Urunler.cshtml"
               Write(a.stock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t</tr>\r\n");
#nullable restore
#line 25 "C:\Users\user\source\repos\AdminPannelMVC\CustomerPresent\Views\Product\Urunler.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</tbody>\r\n</table>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591