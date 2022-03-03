#pragma checksum "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\NationalEuro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b594fa30e8c5c60d1872457ee68dc220c6153b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tournaments_NationalEuro), @"mvc.1.0.view", @"/Views/Tournaments/NationalEuro.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b594fa30e8c5c60d1872457ee68dc220c6153b5", @"/Views/Tournaments/NationalEuro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27b41d72e309e687d740d9d0d2ac34708a534e9b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Tournaments_NationalEuro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EuroCupViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\NationalEuro.cshtml"
  
    Layout = "_TournamentLayout";
    ViewData["Title"] = Model.Tournament.Name + "" + "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1 class=\"justify-content-center d-flex\"\r\n    style=\"color: blanchedalmond; background-color: brown; padding: 15px; margin-bottom: 50px; border: solid 3px; border-color: indigo; font-family: Impact;\">\r\n    ");
#nullable restore
#line 8 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\NationalEuro.cshtml"
Write(Model.Tournament.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 8 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\NationalEuro.cshtml"
                        Write(Model.Tournament.Season.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</h1>\r\n<div>\r\n");
#nullable restore
#line 11 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\NationalEuro.cshtml"
      
        if (Model.Tournament.Matches.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n                <div>\r\n");
#nullable restore
#line 16 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\NationalEuro.cshtml"
                     foreach (var g in Model.Groups)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-12 justify-content-center text-center\" style=\"background-color:darkcyan; color:white; padding:10px\">\r\n                            ");
#nullable restore
#line 19 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\NationalEuro.cshtml"
                       Write(g.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"row\">\r\n                            <div class=\"col-6\">\r\n                                ");
#nullable restore
#line 23 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\NationalEuro.cshtml"
                           Write(await Html.PartialAsync("Standing", g.GroupStandings));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col-6\">\r\n");
#nullable restore
#line 26 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\NationalEuro.cshtml"
                                 foreach (var m in g.Matches)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"container\">\r\n                                        ");
#nullable restore
#line 29 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\NationalEuro.cshtml"
                                   Write(await Html.PartialAsync("Match", m));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n");
#nullable restore
#line 31 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\NationalEuro.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 34 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\NationalEuro.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div>\r\n                    <div>\r\n                        ");
#nullable restore
#line 38 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\NationalEuro.cshtml"
                   Write(await Html.PartialAsync("KnockOut", Model.Matches));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
            <div>
                <div class=""row"">
                    <div class=""col-6"" style=""border: solid; border-color: coral; margin-top: 25px;"">
                        <div style=""font-size: x-large;
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
#line 54 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\NationalEuro.cshtml"
                         foreach (var c in Model.Goals.Where(g => g.Goals.Count > 2).OrderByDescending(g => g.Goals.Count))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"row m-0\" style=\"border-bottom:1px solid\">\r\n                                <div class=\"col-6\" style=\"background-color:lightblue;font-size:14px;margin-left:0;\">\r\n                                    ");
#nullable restore
#line 58 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\NationalEuro.cshtml"
                               Write(c.Player.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-5\" style=\"font-size:13px;\">");
#nullable restore
#line 60 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\NationalEuro.cshtml"
                                                                      Write(c.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                <div class=\"col-1\" style=\"background-color:brown;color:ivory\">");
#nullable restore
#line 61 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\NationalEuro.cshtml"
                                                                                         Write(c.Goals.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            </div>\r\n");
#nullable restore
#line 63 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\NationalEuro.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                    <div class=""col-6"" style=""border: solid; border-color: coral; margin-top:25px;"">
                        <div style=""font-size: x-large;
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
#line 75 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\NationalEuro.cshtml"
                         foreach (var c in Model.Asists.Where(a => a.Asists.Count > 1).OrderByDescending(g => g.Asists.Count))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"row m-0\" style=\"border-bottom:1px solid\">\r\n                                <div class=\"col-6\" style=\"background-color:lightblue;font-size:14px;margin-left:0;\">\r\n                                    ");
#nullable restore
#line 79 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\NationalEuro.cshtml"
                               Write(c.Player.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-5\" style=\"font-size:13px;\">");
#nullable restore
#line 81 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\NationalEuro.cshtml"
                                                                      Write(c.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                <div class=\"col-1\" style=\"background-color:brown;color:ivory\">");
#nullable restore
#line 82 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\NationalEuro.cshtml"
                                                                                         Write(c.Asists.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            </div>\r\n");
#nullable restore
#line 84 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\NationalEuro.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 88 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\NationalEuro.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\"Please create a shedulle for tournament\"</p>");
#nullable restore
#line 90 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\NationalEuro.cshtml"
                                                         ;
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>\r\n");
#nullable restore
#line 95 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\NationalEuro.cshtml"
     if (Model.BestPlayer.Count() > 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\NationalEuro.cshtml"
   Write(await Html.PartialAsync("BestPlayer", Model.Tournament));

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\NationalEuro.cshtml"
                                                                
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EuroCupViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
