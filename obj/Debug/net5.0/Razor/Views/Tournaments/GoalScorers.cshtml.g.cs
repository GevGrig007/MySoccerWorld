#pragma checksum "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\GoalScorers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66ee5dd60bb00c550967aa9f0413df841aea3c5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tournaments_GoalScorers), @"mvc.1.0.view", @"/Views/Tournaments/GoalScorers.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66ee5dd60bb00c550967aa9f0413df841aea3c5e", @"/Views/Tournaments/GoalScorers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27b41d72e309e687d740d9d0d2ac34708a534e9b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Tournaments_GoalScorers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GoalScorersViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("modalItem mb-4 btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateAwards", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/modal.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\GoalScorers.cshtml"
  
    Layout = "_TournamentLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66ee5dd60bb00c550967aa9f0413df841aea3c5e5998", async() => {
                WriteLiteral(" CREATE AWARDS ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 7 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\GoalScorers.cshtml"
                                                            WriteLiteral(Model.Tournament.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n");
#nullable restore
#line 10 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\GoalScorers.cshtml"
         foreach (var a in Model.TournamentAwards.Where(a => a.AwardsName == AwardsType.GoldenBall))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p> Golden Ball -   ");
#nullable restore
#line 12 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\GoalScorers.cshtml"
                           Write(a.PlayerTeam.Player.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 12 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\GoalScorers.cshtml"
                                                       Write(a.PlayerTeam.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </p>\r\n");
#nullable restore
#line 13 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\GoalScorers.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div>\r\n");
#nullable restore
#line 16 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\GoalScorers.cshtml"
         foreach (var a in Model.TournamentAwards.Where(a => a.AwardsName == AwardsType.SilverBall))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p> Silver Ball - ");
#nullable restore
#line 18 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\GoalScorers.cshtml"
                         Write(a.PlayerTeam.Player.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 18 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\GoalScorers.cshtml"
                                                     Write(a.PlayerTeam.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </p>\r\n");
#nullable restore
#line 19 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\GoalScorers.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div>\r\n");
#nullable restore
#line 22 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\GoalScorers.cshtml"
         foreach (var a in Model.TournamentAwards.Where(a => a.AwardsName == AwardsType.BronzeBall))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p> Bronze Ball -  ");
#nullable restore
#line 24 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\GoalScorers.cshtml"
                          Write(a.PlayerTeam.Player.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 24 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\GoalScorers.cshtml"
                                                      Write(a.PlayerTeam.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </p>\r\n");
#nullable restore
#line 25 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\GoalScorers.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div>\r\n");
#nullable restore
#line 28 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\GoalScorers.cshtml"
         foreach (var a in Model.TournamentAwards.Where(a => a.AwardsName == AwardsType.GoalScorer))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p> ");
#nullable restore
#line 30 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\GoalScorers.cshtml"
           Write(a.PlayerTeam.Player.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 30 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\GoalScorers.cshtml"
                                       Write(a.PlayerTeam.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </p>\r\n");
#nullable restore
#line 31 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\GoalScorers.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div>\r\n");
#nullable restore
#line 34 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\GoalScorers.cshtml"
         foreach (var a in Model.TournamentAwards.Where(a => a.AwardsName == AwardsType.Asister))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p> ");
#nullable restore
#line 36 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\GoalScorers.cshtml"
           Write(a.PlayerTeam.Player.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 36 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\GoalScorers.cshtml"
                                       Write(a.PlayerTeam.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </p>\r\n");
#nullable restore
#line 37 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\GoalScorers.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div>\r\n");
#nullable restore
#line 40 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\GoalScorers.cshtml"
         foreach (var a in Model.TournamentAwards.Where(a => a.AwardsName == AwardsType.Coach))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p> ");
#nullable restore
#line 42 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\GoalScorers.cshtml"
           Write(a.CoachTeam.Coach.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 42 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\GoalScorers.cshtml"
                                     Write(a.CoachTeam.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </p>\r\n");
#nullable restore
#line 43 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\GoalScorers.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n<div>\r\n");
#nullable restore
#line 47 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\GoalScorers.cshtml"
     foreach (var p in Model.PlayerTeams.Where(p => p.Goals.Count > 0 || p.Asists.Count > 0).GroupBy(c => c.Team))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"container\">\r\n\r\n            <table class=\"table\">\r\n                <thead>\r\n                    <tr>\r\n                        <th></th>\r\n                        <th> ");
#nullable restore
#line 55 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\GoalScorers.cshtml"
                        Write(p.Key.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                        <th></th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 61 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\GoalScorers.cshtml"
                     foreach (var c in p)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td> <img");
            BeginWriteAttribute("src", " src=\"", 2249, "\"", 2277, 1);
#nullable restore
#line 64 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\GoalScorers.cshtml"
WriteAttributeValue("", 2255, c.Player.Country.Flag, 2255, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"24\" height=\"24\" /> </td>\r\n                            <td> ");
#nullable restore
#line 65 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\GoalScorers.cshtml"
                            Write(c.Player.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td> ");
#nullable restore
#line 66 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\GoalScorers.cshtml"
                            Write(c.Goals.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td> ");
#nullable restore
#line 67 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\GoalScorers.cshtml"
                            Write(c.Asists.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        </tr>\r\n");
#nullable restore
#line 69 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\GoalScorers.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n\r\n        </div>\r\n");
#nullable restore
#line 74 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Tournaments\GoalScorers.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div id=\"modDialog\" class=\"modal fade\" style=\"top:5%\">\r\n    <div id=\"dialogContent\" class=\"modal-dialog\"></div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66ee5dd60bb00c550967aa9f0413df841aea3c5e18441", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66ee5dd60bb00c550967aa9f0413df841aea3c5e19481", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66ee5dd60bb00c550967aa9f0413df841aea3c5e20521", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GoalScorersViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591