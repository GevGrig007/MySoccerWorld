#pragma checksum "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Clubs\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23d80c2296d9939b54552aaf469df0cbfa9b5ba7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clubs_Details), @"mvc.1.0.view", @"/Views/Clubs/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23d80c2296d9939b54552aaf469df0cbfa9b5ba7", @"/Views/Clubs/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27b41d72e309e687d740d9d0d2ac34708a534e9b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Clubs_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClubViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Clubs\Details.cshtml"
  
    Layout = "_Details";
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    ");
#nullable restore
#line 7 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Clubs\Details.cshtml"
Write(await Html.PartialAsync("MenuHeader"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div class=\"container box\">\r\n    <div class=\"mainrow\">\r\n        <div>\r\n            <div class=\"center\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 275, "\"", 297, 1);
#nullable restore
#line 13 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Clubs\Details.cshtml"
WriteAttributeValue("", 281, Model.Team.Flag, 281, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <div class=\"ml-5 p-4\">\r\n                    <h1> ");
#nullable restore
#line 15 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Clubs\Details.cshtml"
                    Write(Model.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n                    <div class=\"center\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 462, "\"", 492, 1);
#nullable restore
#line 17 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Clubs\Details.cshtml"
WriteAttributeValue("", 468, Model.Team.Country.Flag, 468, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height:26px;width:28px;margin-right:10px;\" /> ");
#nullable restore
#line 17 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Clubs\Details.cshtml"
                                                                                                            Write(Model.Team.Country.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
        <div class=""mt-5"">
            <table class=""table"">
                <thead>
                    <tr>
                        <th> GAMES </th>
                        <th> WIN </th>
                        <th> DRAW </th>
                        <th> LOST </th>
                        <th> GOALS </th>
                    </tr>
                </thead>
                <tr>
                    <td> ");
#nullable restore
#line 34 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Clubs\Details.cshtml"
                    Write(Model.Stats.Games);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 35 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Clubs\Details.cshtml"
                    Write(Model.Stats.Win);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 36 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Clubs\Details.cshtml"
                    Write(Model.Stats.Draw);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 37 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Clubs\Details.cshtml"
                    Write(Model.Stats.Lost);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 38 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Clubs\Details.cshtml"
                    Write(Model.Stats.GoalsFor);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 38 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Clubs\Details.cshtml"
                                            Write(Model.Stats.GoalsAgainst);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </td>
                </tr>
            </table>
        </div>
        <div class=""mainrow d-flex mt-5"">
            <div class=""col-6"">
                <div class=""center mainname"">
                    TOURNAMENTS
                </div>
                <div class=""p-5"">
");
#nullable restore
#line 48 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Clubs\Details.cshtml"
                     foreach (var r in Model.Ratings)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"ctr-spacearound\">\r\n                        <div class=\"col-3\"> ");
#nullable restore
#line 51 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Clubs\Details.cshtml"
                                       Write(r.Tournament.Season.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n                        <div class=\"col-6\"> ");
#nullable restore
#line 52 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Clubs\Details.cshtml"
                                       Write(r.Tournament.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n                        <div class=\"col-3\"> ");
#nullable restore
#line 53 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Clubs\Details.cshtml"
                                       Write(r.Round);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 53 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Clubs\Details.cshtml"
                                                 Write(r.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n                    </div>  \r\n");
#nullable restore
#line 55 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Clubs\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n            <div class=\"col-6\">\r\n                <div>\r\n                    <div class=\"center mainname\">\r\n                        PLAYERS\r\n                    </div>\r\n");
#nullable restore
#line 63 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Clubs\Details.cshtml"
                     foreach (var p in Model.Players)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"d-flex ml-5\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 2392, "\"", 2413, 1);
#nullable restore
#line 66 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Clubs\Details.cshtml"
WriteAttributeValue("", 2398, p.Country.Flag, 2398, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"24\" height=\"22\" />\r\n                            <div class=\"ml-2\">  ");
#nullable restore
#line 67 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Clubs\Details.cshtml"
                                           Write(p.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n                        </div>\r\n");
#nullable restore
#line 69 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Clubs\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
        <div class=""mt-5"">
            <div class=""mainname""> MATCHES </div>
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
#line 94 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Clubs\Details.cshtml"
                 foreach (var m in Model.Matches)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 97 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Clubs\Details.cshtml"
                       Write(m.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 98 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Clubs\Details.cshtml"
                       Write(m.Neytral);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 99 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Clubs\Details.cshtml"
                       Write(m.Tournament.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 100 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Clubs\Details.cshtml"
                       Write(m.Round);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 101 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Clubs\Details.cshtml"
                       Write(m.Group);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 102 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Clubs\Details.cshtml"
                       Write(m.Home.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 103 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Clubs\Details.cshtml"
                       Write(m.Away.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 104 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Clubs\Details.cshtml"
                       Write(m.HomeScore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 105 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Clubs\Details.cshtml"
                       Write(m.AwayScore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 106 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Clubs\Details.cshtml"
                       Write(m.HomeEx);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 107 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Clubs\Details.cshtml"
                       Write(m.AwayEx);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 108 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Clubs\Details.cshtml"
                       Write(m.HomePen);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 109 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Clubs\Details.cshtml"
                       Write(m.AwayPen);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td style=\" font-size:12px;\">\r\n");
#nullable restore
#line 111 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Clubs\Details.cshtml"
                             foreach (var g in m.Goals.GroupBy(g => g.PlayerTeam.Player.Name))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div> ");
#nullable restore
#line 113 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Clubs\Details.cshtml"
                                 Write(g.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 113 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Clubs\Details.cshtml"
                                          Write(g.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n");
#nullable restore
#line 114 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Clubs\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 117 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Clubs\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClubViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
