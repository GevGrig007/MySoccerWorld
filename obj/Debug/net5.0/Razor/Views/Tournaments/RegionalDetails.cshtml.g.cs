#pragma checksum "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\RegionalDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa6517767734a8fc69338ce3370fe7d42ecea271"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tournaments_RegionalDetails), @"mvc.1.0.view", @"/Views/Tournaments/RegionalDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa6517767734a8fc69338ce3370fe7d42ecea271", @"/Views/Tournaments/RegionalDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27b41d72e309e687d740d9d0d2ac34708a534e9b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Tournaments_RegionalDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TournamentViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\RegionalDetails.cshtml"
  
    Layout = "_TournamentLayout";
    ViewData["Title"] = Model.Tournament.Name + "Info";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1 class=\"justify-content-center d-flex\"\r\n    style=\"color: blanchedalmond; background-color: brown; padding: 15px; margin-bottom: 50px; border: solid 3px; border-color: indigo; font-family: Impact;\">\r\n    ");
#nullable restore
#line 8 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\RegionalDetails.cshtml"
Write(Model.Tournament.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 8 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\RegionalDetails.cshtml"
                        Write(Model.Tournament.Season.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</h1>\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-7\">\r\n            ");
#nullable restore
#line 13 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\RegionalDetails.cshtml"
       Write(await Html.PartialAsync("Standing", Model.TournamentStandings));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-5\">\r\n            <div class=\"justify-content-center\">\r\n                <div style=\"border: solid; border-color: coral;\">\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 737, "\"", 745, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""font-size: x-large;
                                  background-color: navy;
                                  color: darkorange;
                                  font-family: cursive;
                                  justify-content: center;
                                  border-bottom: solid;
                                  display: flex;"">
                        GOALSCORERS
                    </div>
");
#nullable restore
#line 27 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\RegionalDetails.cshtml"
                     foreach (var c in Model.Goals.Where(g => g.Goals.Count > 2).OrderByDescending(g => g.Goals.Count).Take(15))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"row m-0\" style=\"border-bottom:1px solid\">\r\n                            <div class=\"col-6\" style=\"background-color:lightblue;font-size:14px;margin-left:0;\">\r\n                                ");
#nullable restore
#line 31 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\RegionalDetails.cshtml"
                           Write(c.Player.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col-5\" style=\"font-size:13px;\">");
#nullable restore
#line 33 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\RegionalDetails.cshtml"
                                                                  Write(c.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <div class=\"col-1\" style=\"background-color:brown;color:ivory\">");
#nullable restore
#line 34 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\RegionalDetails.cshtml"
                                                                                     Write(c.Goals.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        </div>\r\n");
#nullable restore
#line 36 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\RegionalDetails.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div style=\"border: solid; border-color: coral; margin-top:25px;\">\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 2001, "\"", 2009, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""font-size: x-large;
                                  background-color: navy;
                                  color: darkorange;
                                  font-family: cursive;
                                  justify-content: center;
                                  border-bottom: solid;
                                  display: flex;"">
                        ASSISTANTS
                    </div>
");
#nullable restore
#line 48 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\RegionalDetails.cshtml"
                     foreach (var c in Model.Asists.Where(a => a.Asists.Count > 1).OrderByDescending(g => g.Asists.Count).Take(15))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"row m-0\" style=\"border-bottom:1px solid\">\r\n                            <div class=\"col-6\" style=\"background-color:lightblue;font-size:14px;margin-left:0;\">\r\n                                ");
#nullable restore
#line 52 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\RegionalDetails.cshtml"
                           Write(c.Player.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col-5\" style=\"font-size:13px;\">");
#nullable restore
#line 54 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\RegionalDetails.cshtml"
                                                                  Write(c.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <div class=\"col-1\" style=\"background-color:brown;color:ivory\">");
#nullable restore
#line 55 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\RegionalDetails.cshtml"
                                                                                     Write(c.Asists.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        </div>\r\n");
#nullable restore
#line 57 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\RegionalDetails.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div>\r\n");
#nullable restore
#line 63 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\RegionalDetails.cshtml"
         foreach (var m in Model.Matches.OrderBy(c => c.Round).GroupBy(c => c.Round))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n                <div class=\"row justify-content-center bg-success text-white p-2\" style=\"border: solid 2px #3c14b9;font-size: 22px;font-weight: 700;\">\r\n                    ");
#nullable restore
#line 67 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\RegionalDetails.cshtml"
               Write(m.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ROUND\r\n                </div>\r\n");
#nullable restore
#line 69 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\RegionalDetails.cshtml"
                 foreach (var c in m)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"container\">\r\n                        ");
#nullable restore
#line 72 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\RegionalDetails.cshtml"
                   Write(await Html.PartialAsync("Match", c));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 74 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\RegionalDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 76 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\RegionalDetails.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n<div>\r\n");
#nullable restore
#line 80 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\RegionalDetails.cshtml"
     if (Model.BestPlayer.Count() > 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\RegionalDetails.cshtml"
   Write(await Html.PartialAsync("BestPlayer", Model.Tournament));

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\RegionalDetails.cshtml"
                                                                
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TournamentViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
