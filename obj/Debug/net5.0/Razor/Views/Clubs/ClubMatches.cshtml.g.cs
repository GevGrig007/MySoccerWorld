#pragma checksum "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Clubs\ClubMatches.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "755541834985dc130de7b89df969148ee8a235dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clubs_ClubMatches), @"mvc.1.0.view", @"/Views/Clubs/ClubMatches.cshtml")]
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
#line 1 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\_ViewImports.cshtml"
using MySoccerWorld;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\_ViewImports.cshtml"
using MySoccerWorld.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\_ViewImports.cshtml"
using MySoccerWorld.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\_ViewImports.cshtml"
using MySoccerWorld.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\_ViewImports.cshtml"
using MySoccerWorld.Models.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"755541834985dc130de7b89df969148ee8a235dc", @"/Views/Clubs/ClubMatches.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27b41d72e309e687d740d9d0d2ac34708a534e9b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Clubs_ClubMatches : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Match>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Clubs\ClubMatches.cshtml"
  
    ViewData["Title"] = "Club Matches";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    header {
        background-color: crimson;
    }
    .table td {
        vertical-align: unset;
        background-color: darkblue;
        color: azure;
    }
    .table thead {
        background-color: darkred;
    }
        .table thead th, a {
            color: aliceblue;
        } 
    a {
        text-decoration: none;
        color: cornsilk;
    }
        a:hover {
            text-decoration: none;
            color: lime;
        }
</style>
");
#nullable restore
#line 29 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Clubs\ClubMatches.cshtml"
Write(await Html.PartialAsync("MenuHeader"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div>
        <table class=""table"">
            <thead>
                <tr>
                    <th>DATA</th>
                    <th>HOME</th>
                    <th>TOURNAMENT</th>
                    <th>ROUND</th>
                    <th>GR</th>
                    <th></th>
                    <th></th>
                    <th></th>
                    <th></th>
                    <th>ET</th>
                    <th>ET</th>
                    <th>P</th>
                    <th>P</th>
                    <th>GOALS</th>
                </tr>
            </thead>
");
#nullable restore
#line 51 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Clubs\ClubMatches.cshtml"
             foreach (var m in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 54 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Clubs\ClubMatches.cshtml"
                   Write(m.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 55 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Clubs\ClubMatches.cshtml"
                   Write(m.Neytral);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 56 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Clubs\ClubMatches.cshtml"
                   Write(m.Tournament.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 57 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Clubs\ClubMatches.cshtml"
                   Write(m.Round);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 58 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Clubs\ClubMatches.cshtml"
                   Write(m.Group);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 59 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Clubs\ClubMatches.cshtml"
                   Write(m.Home.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 60 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Clubs\ClubMatches.cshtml"
                   Write(m.Away.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 61 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Clubs\ClubMatches.cshtml"
                   Write(m.HomeScore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 62 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Clubs\ClubMatches.cshtml"
                   Write(m.AwayScore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 63 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Clubs\ClubMatches.cshtml"
                   Write(m.HomeEx);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 64 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Clubs\ClubMatches.cshtml"
                   Write(m.AwayEx);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 65 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Clubs\ClubMatches.cshtml"
                   Write(m.HomePen);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 66 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Clubs\ClubMatches.cshtml"
                   Write(m.AwayPen);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td style=\" font-size:12px;\">\r\n");
#nullable restore
#line 68 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Clubs\ClubMatches.cshtml"
                         foreach (var g in m.Goals.GroupBy(g => g.PlayerTeam.Player.Name))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div> ");
#nullable restore
#line 70 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Clubs\ClubMatches.cshtml"
                             Write(g.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 70 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Clubs\ClubMatches.cshtml"
                                      Write(g.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n");
#nullable restore
#line 71 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Clubs\ClubMatches.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 74 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Clubs\ClubMatches.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n\r\n    </div>\r\n</div>");
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