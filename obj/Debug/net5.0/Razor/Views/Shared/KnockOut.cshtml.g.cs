#pragma checksum "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\KnockOut.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8094bcc2c90d66ecf065e7026ac2e2199fdbce6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_KnockOut), @"mvc.1.0.view", @"/Views/Shared/KnockOut.cshtml")]
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
#line 1 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\_ViewImports.cshtml"
using MySoccerWorld;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\_ViewImports.cshtml"
using MySoccerWorld.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\_ViewImports.cshtml"
using MySoccerWorld.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\_ViewImports.cshtml"
using MySoccerWorld.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\_ViewImports.cshtml"
using MySoccerWorld.Models.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8094bcc2c90d66ecf065e7026ac2e2199fdbce6", @"/Views/Shared/KnockOut.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27b41d72e309e687d740d9d0d2ac34708a534e9b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_KnockOut : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Match>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div>\r\n    <div class=\"roundrow\">\r\n");
#nullable restore
#line 4 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\KnockOut.cshtml"
         if (Model.Any(m => m.Round == "1/64 finals"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"round\">\r\n                1/64   FINAL\r\n            </div>\r\n");
#nullable restore
#line 9 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\KnockOut.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\KnockOut.cshtml"
         foreach (var m in Model.Where(m => m.Round == "1/64 finals"))
        {

            if (m != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>\r\n                    ");
#nullable restore
#line 16 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\KnockOut.cshtml"
               Write(await Html.PartialAsync("Match", m));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 18 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\KnockOut.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"roundrow\">\r\n");
#nullable restore
#line 22 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\KnockOut.cshtml"
         if (Model.Any(m => m.Round == "1/32 finals"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"round\">\r\n                1/32   FINAL\r\n            </div>\r\n");
#nullable restore
#line 27 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\KnockOut.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\KnockOut.cshtml"
         foreach (var m in Model.Where(m => m.Round == "1/32 finals"))
        {

            if (m != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>\r\n                    ");
#nullable restore
#line 34 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\KnockOut.cshtml"
               Write(await Html.PartialAsync("Match", m));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 36 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\KnockOut.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"roundrow\">\r\n");
#nullable restore
#line 40 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\KnockOut.cshtml"
         if (Model.Any(m => m.Round == "1/16 finals"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"round\">\r\n                1/16   FINAL\r\n            </div>\r\n");
#nullable restore
#line 45 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\KnockOut.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\KnockOut.cshtml"
         foreach (var m in Model.Where(m => m.Round == "1/16 finals"))
        {
            if (m != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>\r\n                    ");
#nullable restore
#line 51 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\KnockOut.cshtml"
               Write(await Html.PartialAsync("Match", m));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 53 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\KnockOut.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"roundrow\">\r\n");
#nullable restore
#line 57 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\KnockOut.cshtml"
         if (Model.Any(m => m.Round == "1/8 finals"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"round\">\r\n                1/8   FINAL\r\n            </div>\r\n");
#nullable restore
#line 62 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\KnockOut.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\KnockOut.cshtml"
         foreach (var m in Model.Where(m => m.Round == "1/8 finals"))
        {
            if (m != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>\r\n                    ");
#nullable restore
#line 68 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\KnockOut.cshtml"
               Write(await Html.PartialAsync("Match", m));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 70 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\KnockOut.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"roundrow\">\r\n");
#nullable restore
#line 74 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\KnockOut.cshtml"
         if (Model.Any(m => m.Round == "1/4 finals"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"round\">\r\n                1/4   FINAL\r\n            </div>\r\n");
#nullable restore
#line 79 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\KnockOut.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\KnockOut.cshtml"
         foreach (var m in Model.Where(m => m.Round == "1/4 finals"))
        {
            if (m != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>\r\n                    ");
#nullable restore
#line 85 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\KnockOut.cshtml"
               Write(await Html.PartialAsync("Match", m));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 87 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\KnockOut.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"roundrow\">\r\n");
#nullable restore
#line 91 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\KnockOut.cshtml"
         if (Model.Any(m => m.Round == "1/2 finals"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"round\">\r\n                1/2   FINAL\r\n            </div>\r\n");
#nullable restore
#line 96 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\KnockOut.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\KnockOut.cshtml"
         foreach (var m in Model.Where(m => m.Round == "1/2 finals"))
        {
            if (m != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>\r\n                    ");
#nullable restore
#line 102 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\KnockOut.cshtml"
               Write(await Html.PartialAsync("Match", m));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 104 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\KnockOut.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"roundrow\">\r\n");
#nullable restore
#line 108 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\KnockOut.cshtml"
         if (Model.Any(m => m.Round == "Bronze-Match"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"round\">\r\n                BRONZE-MATCH\r\n            </div>\r\n");
#nullable restore
#line 113 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\KnockOut.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 114 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\KnockOut.cshtml"
         foreach (var m in Model.Where(m => m.Round == "Bronze-Match"))
        {
            if (m != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>\r\n                    ");
#nullable restore
#line 119 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\KnockOut.cshtml"
               Write(await Html.PartialAsync("Match", m));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 121 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\KnockOut.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"roundrow\">\r\n");
#nullable restore
#line 125 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\KnockOut.cshtml"
         if (Model.Any(m => m.Round == "Final"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"round\">\r\n                FINAL\r\n            </div>\r\n");
#nullable restore
#line 130 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\KnockOut.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 131 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\KnockOut.cshtml"
         foreach (var m in Model.Where(m => m.Round == "Final"))
        {
            if (m != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>\r\n                    ");
#nullable restore
#line 136 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\KnockOut.cshtml"
               Write(await Html.PartialAsync("Match", m));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 138 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\KnockOut.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Match>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
