#pragma checksum "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer442.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8935be08d2d12ff4a19fb7a9b52b4d3852f8f438"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BestPlayers_BestPlayer442), @"mvc.1.0.view", @"/Views/BestPlayers/BestPlayer442.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8935be08d2d12ff4a19fb7a9b52b4d3852f8f438", @"/Views/BestPlayers/BestPlayer442.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27b41d72e309e687d740d9d0d2ac34708a534e9b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_BestPlayers_BestPlayer442 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BestPlayer>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer442.cshtml"
  
    var p1 = Model.Where(p => p.Position == 1).Single();
    var p2 = Model.Where(p => p.Position == 2).Single();
    var p3 = Model.Where(p => p.Position == 3).Single();
    var p4 = Model.Where(p => p.Position == 4).Single();
    var p5 = Model.Where(p => p.Position == 5).Single();
    var p6 = Model.Where(p => p.Position == 6).Single();
    var p7 = Model.Where(p => p.Position == 7).Single();
    var p8 = Model.Where(p => p.Position == 8).Single();
    var p9 = Model.Where(p => p.Position == 9).Single();
    var p10 = Model.Where(p => p.Position == 10).Single();
    var p11 = Model.Where(p => p.Position == 11).Single();


#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
<div class=""container mt-5"" style=""background:url(/images/Field.jpg) no-repeat;background-size:cover;width:830px;height:500px;"">
    <div class=""row bprow"" style=""height:50px;"">
        <div class=""col-3"">
            <p class=""bestplayer"" style="" background-color: darkgreen; color: aliceblue; border-color: darkcyan;"">
                ");
#nullable restore
#line 23 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer442.cshtml"
           Write(p1.PlayerTeam.Player.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p> <p class=\"bpclub\"> ");
#nullable restore
#line 24 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer442.cshtml"
                               Write(p1.PlayerTeam.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"row bprow\" style=\"height:50px;\">\r\n    </div>\r\n    <div class=\"row bprow\" style=\"height:50px;\">\r\n        <div class=\"col-3\"> <p class=\"bestplayer\">");
#nullable restore
#line 30 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer442.cshtml"
                                             Write(p2.PlayerTeam.Player.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> <p class=\"bpclub\"> ");
#nullable restore
#line 30 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer442.cshtml"
                                                                                               Write(p2.PlayerTeam.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p> </div>\r\n        <div class=\"col-3\"> <p class=\"bestplayer\">");
#nullable restore
#line 31 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer442.cshtml"
                                             Write(p3.PlayerTeam.Player.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> <p class=\"bpclub\">");
#nullable restore
#line 31 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer442.cshtml"
                                                                                              Write(p3.PlayerTeam.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> </div>\r\n        <div class=\"col-3\"> <p class=\"bestplayer\">");
#nullable restore
#line 32 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer442.cshtml"
                                             Write(p4.PlayerTeam.Player.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> <p class=\"bpclub\"> ");
#nullable restore
#line 32 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer442.cshtml"
                                                                                               Write(p4.PlayerTeam.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> </div>\r\n        <div class=\"col-3\"> <p class=\"bestplayer\">");
#nullable restore
#line 33 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer442.cshtml"
                                             Write(p5.PlayerTeam.Player.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> <p class=\"bpclub\">");
#nullable restore
#line 33 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer442.cshtml"
                                                                                              Write(p5.PlayerTeam.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p> </div>
    </div>
    <div class=""row bprow"" style=""height:50px;"">
    </div>
    <div class=""row bprow"" style=""height:50px;"">        
    </div>
    <div class=""row bprow"" style=""height:50px;"">
        <div class=""col-3""> <p class=""bestplayer"">");
#nullable restore
#line 40 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer442.cshtml"
                                             Write(p6.PlayerTeam.Player.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> <p class=\"bpclub\"> ");
#nullable restore
#line 40 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer442.cshtml"
                                                                                               Write(p6.PlayerTeam.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> </div>\r\n        <div class=\"col-3\"> <p class=\"bestplayer\">");
#nullable restore
#line 41 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer442.cshtml"
                                             Write(p7.PlayerTeam.Player.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> <p class=\"bpclub\"> ");
#nullable restore
#line 41 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer442.cshtml"
                                                                                               Write(p7.PlayerTeam.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> </div>\r\n        <div class=\"col-3\"> <p class=\"bestplayer\">");
#nullable restore
#line 42 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer442.cshtml"
                                             Write(p8.PlayerTeam.Player.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> <p class=\"bpclub\"> ");
#nullable restore
#line 42 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer442.cshtml"
                                                                                               Write(p8.PlayerTeam.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> </div>\r\n        <div class=\"col-3\"> <p class=\"bestplayer\">");
#nullable restore
#line 43 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer442.cshtml"
                                             Write(p9.PlayerTeam.Player.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> <p class=\"bpclub\">");
#nullable restore
#line 43 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer442.cshtml"
                                                                                              Write(p9.PlayerTeam.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p> </div>
    </div>
    <div class=""row bprow"" style=""height:50px;"">
        
    </div>
    <div class=""row bprow"" style=""height:50px;"">
    </div>
    <div class=""row bprow"" style=""height:50px;"">
        <div class=""col-3""> <p class=""bestplayer"">");
#nullable restore
#line 51 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer442.cshtml"
                                             Write(p10.PlayerTeam.Player.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> <p class=\"bpclub\">");
#nullable restore
#line 51 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer442.cshtml"
                                                                                               Write(p10.PlayerTeam.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> </div>\r\n        <div class=\"col-3\"> <p class=\"bestplayer\">");
#nullable restore
#line 52 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer442.cshtml"
                                             Write(p11.PlayerTeam.Player.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> <p class=\"bpclub\"> ");
#nullable restore
#line 52 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\BestPlayers\BestPlayer442.cshtml"
                                                                                                Write(p11.PlayerTeam.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p> </div>
    </div>
    <div class=""row bprow"" style=""height:50px;"">
    </div>
</div>
<style>
    .bestplayer {
        justify-content: center;
        display: flex;
        align-items: center;
        border: solid;
        border-color: darkolivegreen;
        background-color: #90ee9094;
    }

    .bpclub {
        font-size: 12px;
        display: flex;
        justify-content: center;
        color: darkviolet;
        text-transform: uppercase;
        font-weight: bolder;
    }

    .bprow {
        justify-content: space-around;
    }

    p {
        margin: 0;
    }
</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BestPlayer>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
