#pragma checksum "C:\Users\SormitaChakraborty\source\repos\PostGresqlDapperLoginDocker\LoginFunctionality\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbdb66fdfb3519e69708f6904f5b1fa86d59a9f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\SormitaChakraborty\source\repos\PostGresqlDapperLoginDocker\LoginFunctionality\Views\_ViewImports.cshtml"
using LoginFunctionality;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SormitaChakraborty\source\repos\PostGresqlDapperLoginDocker\LoginFunctionality\Views\_ViewImports.cshtml"
using LoginFunctionality.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbdb66fdfb3519e69708f6904f5b1fa86d59a9f0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"516a8fbbdae999d9c7877b467536469816d0730b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\SormitaChakraborty\source\repos\PostGresqlDapperLoginDocker\LoginFunctionality\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"text-center\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 103, "\"", 141, 1);
#nullable restore
#line 8 "C:\Users\SormitaChakraborty\source\repos\PostGresqlDapperLoginDocker\LoginFunctionality\Views\Home\Index.cshtml"
WriteAttributeValue("", 110, Url.Action("Index", "Product"), 110, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Product List</a>\r\n\r\n\r\n        <h1 class=\"display-4\">Welcome</h1><a");
            BeginWriteAttribute("href", " href=\"", 209, "\"", 248, 1);
#nullable restore
#line 11 "C:\Users\SormitaChakraborty\source\repos\PostGresqlDapperLoginDocker\LoginFunctionality\Views\Home\Index.cshtml"
WriteAttributeValue("", 216, Url.Action("Logout", "Account"), 216, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Logout</a>\r\n        <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 392, "\"", 430, 1);
#nullable restore
#line 14 "C:\Users\SormitaChakraborty\source\repos\PostGresqlDapperLoginDocker\LoginFunctionality\Views\Home\Index.cshtml"
WriteAttributeValue("", 399, Url.Action("Index", "Patient"), 399, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Book an Appointment</a>\r\n\r\n");
#nullable restore
#line 16 "C:\Users\SormitaChakraborty\source\repos\PostGresqlDapperLoginDocker\LoginFunctionality\Views\Home\Index.cshtml"
         if (User.Identity.IsAuthenticated)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <table class=\"table-table-sm\">\r\n");
#nullable restore
#line 19 "C:\Users\SormitaChakraborty\source\repos\PostGresqlDapperLoginDocker\LoginFunctionality\Views\Home\Index.cshtml"
                 foreach (var claim in User.Claims)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 23 "C:\Users\SormitaChakraborty\source\repos\PostGresqlDapperLoginDocker\LoginFunctionality\Views\Home\Index.cshtml"
                       Write(claim.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 26 "C:\Users\SormitaChakraborty\source\repos\PostGresqlDapperLoginDocker\LoginFunctionality\Views\Home\Index.cshtml"
                       Write(claim.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 29 "C:\Users\SormitaChakraborty\source\repos\PostGresqlDapperLoginDocker\LoginFunctionality\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n");
#nullable restore
#line 31 "C:\Users\SormitaChakraborty\source\repos\PostGresqlDapperLoginDocker\LoginFunctionality\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
