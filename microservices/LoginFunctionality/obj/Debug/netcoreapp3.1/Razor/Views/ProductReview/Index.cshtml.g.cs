#pragma checksum "C:\Users\SormitaChakraborty\source\repos\SolarVann\src\LoginFunctionality\Views\ProductReview\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7061e2fce3fd5b38fa5ab62656c92e5ae3f6a8f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductReview_Index), @"mvc.1.0.view", @"/Views/ProductReview/Index.cshtml")]
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
#line 1 "C:\Users\SormitaChakraborty\source\repos\SolarVann\src\LoginFunctionality\Views\_ViewImports.cshtml"
using LoginFunctionality;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SormitaChakraborty\source\repos\SolarVann\src\LoginFunctionality\Views\_ViewImports.cshtml"
using LoginFunctionality.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7061e2fce3fd5b38fa5ab62656c92e5ae3f6a8f5", @"/Views/ProductReview/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"516a8fbbdae999d9c7877b467536469816d0730b", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductReview_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Review>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\SormitaChakraborty\source\repos\SolarVann\src\LoginFunctionality\Views\ProductReview\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Product Review</h1>\r\n<div class=\"row\">\r\n    <ul>\r\n");
#nullable restore
#line 10 "C:\Users\SormitaChakraborty\source\repos\SolarVann\src\LoginFunctionality\Views\ProductReview\Index.cshtml"
         foreach (var revw in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 12 "C:\Users\SormitaChakraborty\source\repos\SolarVann\src\LoginFunctionality\Views\ProductReview\Index.cshtml"
           Write(Html.DisplayFor(modelItem => revw.reviewDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("  </li>\r\n            <li>");
#nullable restore
#line 13 "C:\Users\SormitaChakraborty\source\repos\SolarVann\src\LoginFunctionality\Views\ProductReview\Index.cshtml"
           Write(Html.DisplayFor(modelItem => revw.reviewerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("  </li>\r\n            <li>");
#nullable restore
#line 14 "C:\Users\SormitaChakraborty\source\repos\SolarVann\src\LoginFunctionality\Views\ProductReview\Index.cshtml"
           Write(Html.DisplayFor(modelItem => revw.Comments));

#line default
#line hidden
#nullable disable
            WriteLiteral("  </li>\r\n            <li>");
#nullable restore
#line 15 "C:\Users\SormitaChakraborty\source\repos\SolarVann\src\LoginFunctionality\Views\ProductReview\Index.cshtml"
           Write(Html.DisplayFor(modelItem => revw.EmailAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("  </li>\r\n");
#nullable restore
#line 16 "C:\Users\SormitaChakraborty\source\repos\SolarVann\src\LoginFunctionality\Views\ProductReview\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Review>> Html { get; private set; }
    }
}
#pragma warning restore 1591