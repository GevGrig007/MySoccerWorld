#pragma checksum "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\EuroCupDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5117fa7488f614f7b68746b114bc2e92129e736f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tournaments_EuroCupDetails), @"mvc.1.0.view", @"/Views/Tournaments/EuroCupDetails.cshtml")]
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
using MySoccerWorld.Model.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\_ViewImports.cshtml"
using MySoccerWorld.Model.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\_ViewImports.cshtml"
using MySoccerWorld.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\_ViewImports.cshtml"
using MySoccerWorld.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\_ViewImports.cshtml"
using MySoccerWorld.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5117fa7488f614f7b68746b114bc2e92129e736f", @"/Views/Tournaments/EuroCupDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ff5490c79fad3a972f5b6a0ec8d739c7ff68661", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Tournaments_EuroCupDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EuroCupViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\EuroCupDetails.cshtml"
  
    Layout = "_TournamentLayout";
    ViewData["Title"] = Model.Tournament.Name + "" + "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>\r\n    ");
#nullable restore
#line 7 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\EuroCupDetails.cshtml"
Write(Model.Tournament.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 7 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\EuroCupDetails.cshtml"
                        Write(Model.Tournament.Season.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 7 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\EuroCupDetails.cshtml"
                                                        Write(Model.Tournament.Place);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</h1>\r\n<div>\r\n");
#nullable restore
#line 10 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\EuroCupDetails.cshtml"
      
        if (Model.Matches.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n                <div>\r\n");
#nullable restore
#line 15 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\EuroCupDetails.cshtml"
                     foreach (var g in Model.Groups)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"round\">\r\n                            ");
#nullable restore
#line 18 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\EuroCupDetails.cshtml"
                       Write(g.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"row align-items-center\">\r\n                            <div class=\"col-7\">\r\n");
#nullable restore
#line 22 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\EuroCupDetails.cshtml"
                                 foreach (var m in g.Matches)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div>\r\n                                        ");
#nullable restore
#line 25 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\EuroCupDetails.cshtml"
                                   Write(await Html.PartialAsync("Match", m));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n");
#nullable restore
#line 27 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\EuroCupDetails.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                            <div class=\"col-5\">\r\n                                ");
#nullable restore
#line 30 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\EuroCupDetails.cshtml"
                           Write(await Html.PartialAsync("Standing", g.GroupStandings));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 33 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\EuroCupDetails.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"mt-4\">\r\n                    <div>\r\n                        ");
#nullable restore
#line 37 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\EuroCupDetails.cshtml"
                   Write(await Html.PartialAsync("KnockOut", Model.Matches));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-6"">
                        <div id=""goalscorers"">
                            <div class=""title"">
                                GOALSCORERS
                            </div>
");
#nullable restore
#line 46 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\EuroCupDetails.cshtml"
                             foreach (var c in Model.Goals.Where(g => g.Goals.Count > 2).OrderByDescending(g => g.Goals.Count))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"row m-0\" style=\"border-bottom:1px solid\">\r\n                                    <div class=\"col-6 player\">\r\n                                        ");
#nullable restore
#line 50 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\EuroCupDetails.cshtml"
                                   Write(c.Player.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"col-5 team\">");
#nullable restore
#line 52 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\EuroCupDetails.cshtml"
                                                       Write(c.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                    <div class=\"col-1 count\">");
#nullable restore
#line 53 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\EuroCupDetails.cshtml"
                                                        Write(c.Goals.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                </div>\r\n");
#nullable restore
#line 55 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\EuroCupDetails.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>
                    <div class=""col-6"">
                        <div id=""goalscorers"">
                            <div class=""title"">
                                ASSISTANTS
                            </div>
");
#nullable restore
#line 63 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\EuroCupDetails.cshtml"
                             foreach (var c in Model.Asists.Where(a => a.Asists.Count > 1).OrderByDescending(g => g.Asists.Count))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"row m-0\" style=\"border-bottom:1px solid\">\r\n                                    <div class=\"col-6 player\">\r\n                                        ");
#nullable restore
#line 67 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\EuroCupDetails.cshtml"
                                   Write(c.Player.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"col-5 team\">");
#nullable restore
#line 69 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\EuroCupDetails.cshtml"
                                                       Write(c.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                    <div class=\"col-1 count\">");
#nullable restore
#line 70 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\EuroCupDetails.cshtml"
                                                        Write(c.Asists.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                </div>\r\n");
#nullable restore
#line 72 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\EuroCupDetails.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 77 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\EuroCupDetails.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>Please create a shedulle for tournament</p>");
#nullable restore
#line 79 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\EuroCupDetails.cshtml"
                                                       ;
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>\r\n");
#nullable restore
#line 84 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\EuroCupDetails.cshtml"
     if (Model.BestPlayer.Count() > 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\EuroCupDetails.cshtml"
   Write(await Html.PartialAsync("BestPlayer", Model.Tournament));

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\EuroCupDetails.cshtml"
                                                                
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
