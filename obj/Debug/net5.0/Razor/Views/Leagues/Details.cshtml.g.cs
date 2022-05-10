#pragma checksum "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7903acf4455ab94a9305248d7912487a3a6ec40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Leagues_Details), @"mvc.1.0.view", @"/Views/Leagues/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7903acf4455ab94a9305248d7912487a3a6ec40", @"/Views/Leagues/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ff5490c79fad3a972f5b6a0ec8d739c7ff68661", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Leagues_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LeagueViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:cyan"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Tournaments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TournamentManage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("modal-btn nav-link text-white position-fixed"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("bottom:50px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"" style=""margin-right:0;"">
    <div class=""col-3"">
        <div class=""mainrow"" style=""width:20%"">
            <a href=""/"" class=""d-flex align-items-center mb-3 mb-md-0 me-md-auto text-white text-decoration-none"">
                <h4 class=""fs-4"" style=""margin-bottom:50px;"">My Soccer World</h4>
            </a>
            <hr>
            <ul class=""nav nav-pills flex-column mb-auto"">
                <li class=""nav-item"">
                    <a href=""#"" class=""nav-link active"" aria-current=""page"">
                        Home
                    </a>
                </li>
");
#nullable restore
#line 18 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                 foreach (var c in Model.Tournaments.OrderByDescending(c => c.Season.Data).ThenBy(c => c.Division))
                {
                    var link = "";
                    if (c.TournamentType == TournamentType.Regular)
                    {
                        link = "RegionalDetails";
                    }
                    else if (c.TournamentType == TournamentType.EuroCup)
                    {
                        link = "EuroCupDetails";
                    }
                    else if (c.TournamentType == TournamentType.EuroCupKnockOut)
                    {
                        link = "EuroCupKnockOut";
                    }
                    else if (c.TournamentType == TournamentType.National8)
                    {
                        link = "NationalDetails";
                    }
                    else if (c.TournamentType == TournamentType.NationalEuro)
                    {
                        link = "NationalEuro";
                    }
                    else if (c.TournamentType == TournamentType.Qualification)
                    {
                        link = "Qualification";
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li style=\"padding:5px\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7903acf4455ab94a9305248d7912487a3a6ec407772", async() => {
                WriteLiteral("\r\n                            ");
#nullable restore
#line 47 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                       Write(c.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 47 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                 Write(c.Season.Data);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                             WriteLiteral(link);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                                                                              WriteLiteral(c.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </li>\r\n");
#nullable restore
#line 50 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7903acf4455ab94a9305248d7912487a3a6ec4011591", async() => {
                WriteLiteral("\r\n                        Manage Tournaments\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                                                                    WriteLiteral(Model.League.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-9\">\r\n        <div >\r\n            ");
#nullable restore
#line 63 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
       Write(await Html.PartialAsync("MenuHeader"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n        </div>\r\n        <div>\r\n");
#nullable restore
#line 66 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
             if (Model.Tournaments.Count >0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"d-flex justify-content-center\">\r\n                    <div>\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 2854, "\"", 2878, 1);
#nullable restore
#line 70 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
WriteAttributeValue("", 2860, Model.League.Logo, 2860, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"600\" height=\"400\" />\r\n                        <div class=\"d-flex justify-content-center text-white\"> ");
#nullable restore
#line 71 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                                                          Write(Model.League.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </div>
                    </div>
                </div>
                <div class=""mt-5"">
                    <table class=""table table-striped"">
                        <thead>
                            <tr>
                                <th style=""background-color: cornsilk""> SEASON </th>
                                <th style=""background-color:gold""> WINNER </th>
                                <th style=""background-color:lightgray""> SILVER </th>
                                <th style=""background-color:goldenrod""> BRONZE </th>
                            </tr>
                        </thead>
                        <tbody>

");
#nullable restore
#line 86 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                             foreach (var r in Model.Ratings.GroupBy(r => r.Tournament))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>  ");
#nullable restore
#line 89 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                     Write(r.Key.Season.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 90 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                     foreach (var t in r.Key.Ratings.Where(r => r.Position == 1))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td> <img");
            BeginWriteAttribute("src", " src=\"", 4084, "\"", 4102, 1);
#nullable restore
#line 92 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
WriteAttributeValue("", 4090, t.Team.Flag, 4090, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"60\" height=\"60\"/> ");
#nullable restore
#line 92 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                                                                         Write(t.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </td>\r\n");
#nullable restore
#line 93 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                     foreach (var t in r.Key.Ratings.Where(r => r.Round == "Winner"))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td> <img");
            BeginWriteAttribute("src", " src=\"", 4380, "\"", 4398, 1);
#nullable restore
#line 96 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
WriteAttributeValue("", 4386, t.Team.Flag, 4386, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"60\" height=\"60\"/> ");
#nullable restore
#line 96 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                                                                         Write(t.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 97 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 98 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                     foreach (var t in r.Key.Ratings.Where(r => r.Position == 2))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td> <img");
            BeginWriteAttribute("src", " src=\"", 4671, "\"", 4689, 1);
#nullable restore
#line 100 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
WriteAttributeValue("", 4677, t.Team.Flag, 4677, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"60\" height=\"60\"/> ");
#nullable restore
#line 100 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                                                                         Write(t.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 101 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                     foreach (var t in r.Key.Ratings.Where(r => r.Round == "Silver"))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td> <img");
            BeginWriteAttribute("src", " src=\"", 4966, "\"", 4984, 1);
#nullable restore
#line 104 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
WriteAttributeValue("", 4972, t.Team.Flag, 4972, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"60\" height=\"60\"/> ");
#nullable restore
#line 104 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                                                                         Write(t.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 105 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                     foreach (var t in r.Key.Ratings.Where(r => r.Position == 3))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td> <img");
            BeginWriteAttribute("src", " src=\"", 5257, "\"", 5275, 1);
#nullable restore
#line 108 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
WriteAttributeValue("", 5263, t.Team.Flag, 5263, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"60\" height=\"60\"/> ");
#nullable restore
#line 108 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                                                                         Write(t.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 109 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                     foreach (var t in r.Key.Ratings.Where(r => r.Round == "Bronze"))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td> <img");
            BeginWriteAttribute("src", " src=\"", 5552, "\"", 5570, 1);
#nullable restore
#line 112 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
WriteAttributeValue("", 5558, t.Team.Flag, 5558, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"60\" height=\"60\"/> ");
#nullable restore
#line 112 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                                                                         Write(t.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 113 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tr>\r\n");
#nullable restore
#line 115 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
                <div class=""container d-flex justify-content-center"" style="" background-color: darkslateblue; color: aliceblue;"">
                    <div>
                        <div class=""row"">
                            <div> Games -  ");
#nullable restore
#line 122 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                      Write(Model.Stats.Games);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n                            <div> Goals - ");
#nullable restore
#line 123 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                     Write(Model.Stats.Goals);

#line default
#line hidden
#nullable disable
            WriteLiteral("   </div>\r\n                            <div> Average Total per game -");
#nullable restore
#line 124 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                                     Write(Math.Round((Double)Model.Stats.AverageTotal, 1));

#line default
#line hidden
#nullable disable
            WriteLiteral("  </div>\r\n                        </div>\r\n                        <div> Over Total Games :  ");
#nullable restore
#line 126 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                             Write(Model.Stats.OverResultGame.Home.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("  -");
#nullable restore
#line 126 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                                                                     Write(Model.Stats.OverResultGame.Away.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 126 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                                                                                                            Write(Model.Stats.OverResultGame.HomeScore);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 126 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                                                                                                                                                    Write(Model.Stats.OverResultGame.AwayScore);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </div>\r\n                        <div> Big win games :  ");
#nullable restore
#line 127 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                          Write(Model.Stats.MaxWin.Home.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("  -");
#nullable restore
#line 127 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                                                          Write(Model.Stats.MaxWin.Away.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 127 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                                                                                         Write(Model.Stats.MaxWin.HomeScore);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 127 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                                                                                                                         Write(Model.Stats.MaxWin.AwayScore);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  </div>
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
#line 136 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                             foreach (var c in Model.Goals.GroupBy(p => p.Player).OrderByDescending(p => p.Key.PlayerTeams.Sum(p => p.Goals.Count)).Take(15))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"row m-0\" style=\"border-bottom:1px solid\">\r\n                                    <div class=\"col-6 player\">\r\n                                        ");
#nullable restore
#line 140 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                   Write(c.Key.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"col-5 team\">\r\n");
#nullable restore
#line 143 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                         foreach (var g in c.Key.PlayerTeams)
                                        {
                                            if (g.Goals.Count() > 0)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div> ");
#nullable restore
#line 146 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                              Write(g.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 146 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                                             Write(g.Goals.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>");
#nullable restore
#line 146 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                                                                         }
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                    <div class=\"col-1 count\" >");
#nullable restore
#line 149 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                                         Write(c.Key.PlayerTeams.Sum(c => c.Goals.Count()));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                </div>\r\n");
#nullable restore
#line 151 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
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
#line 159 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                             foreach (var c in Model.Asists.GroupBy(p => p.Player).OrderByDescending(p => p.Key.PlayerTeams.Sum(p => p.Asists.Count)).Take(15))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"row m-0\" style=\"border-bottom:1px solid\">\r\n                                    <div class=\"col-6 player\">\r\n                                        ");
#nullable restore
#line 163 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                   Write(c.Key.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"col-5 team\">\r\n");
#nullable restore
#line 166 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                         foreach (var g in c.Key.PlayerTeams)
                                        {
                                            if (g.Asists.Count() > 0)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div> ");
#nullable restore
#line 169 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                              Write(g.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 169 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                                             Write(g.Asists.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>");
#nullable restore
#line 169 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                                                                          }
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                    <div class=\"col-1 count\">");
#nullable restore
#line 172 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                                        Write(c.Key.PlayerTeams.Sum(c => c.Asists.Count()));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                </div>\r\n");
#nullable restore
#line 174 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 178 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
            }
            else {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <p class=\"linkforcreate\"> Please go to -\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7903acf4455ab94a9305248d7912487a3a6ec4036454", async() => {
                WriteLiteral(" MANAGE TOURNAMETS  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 180 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                                                            WriteLiteral(Model.League.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n            - for create a new tournament   </p> ");
#nullable restore
#line 181 "C:\Users\GevorgGrigoryan\Desktop\Projects\MySoccerWorld\Views\Leagues\Details.cshtml"
                                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LeagueViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
