#pragma checksum "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer3223.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c725555fd14890950b327861482d6bafea4602e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BestPlayers_BestPlayer3223), @"mvc.1.0.view", @"/Views/BestPlayers/BestPlayer3223.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c725555fd14890950b327861482d6bafea4602e1", @"/Views/BestPlayers/BestPlayer3223.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27b41d72e309e687d740d9d0d2ac34708a534e9b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_BestPlayers_BestPlayer3223 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BestPlayer>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"container mt-5\" id=\"bestplayer\">\r\n    <div class=\"row bprow\">\r\n        <div class=\"col-3\">\r\n            <p class=\"bestplayer gk\">\r\n                ");
#nullable restore
#line 6 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer3223.cshtml"
           Write(Model[0].PlayerTeam.Player.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p> <p class=\"bpclub\"> ");
#nullable restore
#line 7 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer3223.cshtml"
                               Write(Model[0].PlayerTeam.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"row bprow\">\r\n    </div>\r\n    <div class=\"row bprow\">\r\n        <div class=\"col-3\"> <p class=\"bestplayer\">");
#nullable restore
#line 13 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer3223.cshtml"
                                             Write(Model[1].PlayerTeam.Player.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> <p class=\"bpclub\"> ");
#nullable restore
#line 13 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer3223.cshtml"
                                                                                                     Write(Model[1].PlayerTeam.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p> </div>\r\n        <div class=\"col-3\"> <p class=\"bestplayer\">");
#nullable restore
#line 14 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer3223.cshtml"
                                             Write(Model[2].PlayerTeam.Player.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> <p class=\"bpclub\">");
#nullable restore
#line 14 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer3223.cshtml"
                                                                                                    Write(Model[2].PlayerTeam.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> </div>\r\n        <div class=\"col-3\"> <p class=\"bestplayer\">");
#nullable restore
#line 15 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer3223.cshtml"
                                             Write(Model[3].PlayerTeam.Player.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> <p class=\"bpclub\"> ");
#nullable restore
#line 15 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer3223.cshtml"
                                                                                                     Write(Model[3].PlayerTeam.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> </div>\r\n    </div>\r\n    <div class=\"row bprow\">\r\n    </div>\r\n    <div class=\"row bprow\">\r\n        <div class=\"col-3\"> <p class=\"bestplayer\">");
#nullable restore
#line 20 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer3223.cshtml"
                                             Write(Model[4].PlayerTeam.Player.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> <p class=\"bpclub\"> ");
#nullable restore
#line 20 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer3223.cshtml"
                                                                                                     Write(Model[4].PlayerTeam.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> </div>\r\n        <div class=\"col-3\"> <p class=\"bestplayer\">");
#nullable restore
#line 21 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer3223.cshtml"
                                             Write(Model[5].PlayerTeam.Player.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> <p class=\"bpclub\"> ");
#nullable restore
#line 21 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer3223.cshtml"
                                                                                                     Write(Model[5].PlayerTeam.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> </div>\r\n    </div>\r\n    <div class=\"row bprow\">\r\n    </div>\r\n    <div class=\"row bprow\">\r\n        <div class=\"col-3\"> <p class=\"bestplayer\">");
#nullable restore
#line 26 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer3223.cshtml"
                                             Write(Model[6].PlayerTeam.Player.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> <p class=\"bpclub\"> ");
#nullable restore
#line 26 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer3223.cshtml"
                                                                                                     Write(Model[6].PlayerTeam.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> </div>\r\n        <div class=\"col-3\"> <p class=\"bestplayer\">");
#nullable restore
#line 27 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer3223.cshtml"
                                             Write(Model[7].PlayerTeam.Player.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> <p class=\"bpclub\"> ");
#nullable restore
#line 27 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer3223.cshtml"
                                                                                                     Write(Model[7].PlayerTeam.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> </div>\r\n    </div>\r\n    <div class=\"row bprow\">\r\n    </div>\r\n    <div class=\"row bprow\">\r\n        <div class=\"col-3\"> <p class=\"bestplayer\">");
#nullable restore
#line 32 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer3223.cshtml"
                                             Write(Model[8].PlayerTeam.Player.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> <p class=\"bpclub\"> ");
#nullable restore
#line 32 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer3223.cshtml"
                                                                                                     Write(Model[8].PlayerTeam.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> </div>\r\n        <div class=\"col-3\"> <p class=\"bestplayer\">");
#nullable restore
#line 33 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer3223.cshtml"
                                             Write(Model[9].PlayerTeam.Player.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> <p class=\"bpclub\"> ");
#nullable restore
#line 33 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer3223.cshtml"
                                                                                                     Write(Model[9].PlayerTeam.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> </div>\r\n        <div class=\"col-3\"> <p class=\"bestplayer\"> ");
#nullable restore
#line 34 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer3223.cshtml"
                                              Write(Model[10].PlayerTeam.Player.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> <p class=\"bpclub\"> ");
#nullable restore
#line 34 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer3223.cshtml"
                                                                                                       Write(Model[10].PlayerTeam.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> </div>\r\n    </div>\r\n    <div class=\"row bprow\">\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BestPlayer>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
