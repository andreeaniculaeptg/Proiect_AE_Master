#pragma checksum "C:\Users\Andreea\source\repos\Puzzle4UbyNAM\Puzzle4UbyNAM.Web\Views\Product\New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89d9c72e59a85bf2e56a3ad7b4f32a9d5160ba40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_New), @"mvc.1.0.view", @"/Views/Product/New.cshtml")]
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
#line 1 "C:\Users\Andreea\source\repos\Puzzle4UbyNAM\Puzzle4UbyNAM.Web\Views\_ViewImports.cshtml"
using Puzzle4UbyNAM.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Andreea\source\repos\Puzzle4UbyNAM\Puzzle4UbyNAM.Web\Views\_ViewImports.cshtml"
using Puzzle4UbyNAM.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Andreea\source\repos\Puzzle4UbyNAM\Puzzle4UbyNAM.Web\Views\_ViewImports.cshtml"
using Puzzle4UbyNAM.Models.DTOs.VM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Andreea\source\repos\Puzzle4UbyNAM\Puzzle4UbyNAM.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89d9c72e59a85bf2e56a3ad7b4f32a9d5160ba40", @"/Views/Product/New.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ca379ef6f4fadef1efd240459ca076cbd336dcc", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Andreea\source\repos\Puzzle4UbyNAM\Puzzle4UbyNAM.Web\Views\Product\New.cshtml"
  
    ViewData["Title"] = "Create a product";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 7 "C:\Users\Andreea\source\repos\Puzzle4UbyNAM\Puzzle4UbyNAM.Web\Views\Product\New.cshtml"
   ViewBag.IsNew = true;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 9 "C:\Users\Andreea\source\repos\Puzzle4UbyNAM\Puzzle4UbyNAM.Web\Views\Product\New.cshtml"
Write(await Html.PartialAsync(@"../Shared/Components/_Product.cshtml"));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
