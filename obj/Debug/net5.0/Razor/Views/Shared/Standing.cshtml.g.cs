#pragma checksum "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\Standing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "597c1be5c74548e97d689185d78d2690fb94823c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Standing), @"mvc.1.0.view", @"/Views/Shared/Standing.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"597c1be5c74548e97d689185d78d2690fb94823c", @"/Views/Shared/Standing.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27b41d72e309e687d740d9d0d2ac34708a534e9b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Standing : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TournamentTable>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    \r\n<div>\r\n");
#nullable restore
#line 4 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\Standing.cshtml"
      
        var standings = Model.Select((p, i) => new { Index = i + 1, standing = p });

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table"">
            <thead >
                <tr>
                    <td> #    </td>
                    <td> Club </td>
                    <td> P    </td>
                    <td> W    </td>
                    <td> D    </td>
                    <td> L    </td>
                    <td> G    </td>
                    <td> D    </td>
                    <td> P    </td>
                </tr>
            </thead>
            <tbody >
");
#nullable restore
#line 21 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\Standing.cshtml"
                 foreach (var c in standings)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n");
#nullable restore
#line 24 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\Standing.cshtml"
                         if (c.Index == 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td style=\"background-color:gold\"> ");
#nullable restore
#line 26 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\Standing.cshtml"
                                                          Write(c.Index);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 27 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\Standing.cshtml"
                        }
                        else if (c.Index == 2)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td style=\"background-color:silver\"> ");
#nullable restore
#line 30 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\Standing.cshtml"
                                                            Write(c.Index);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 31 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\Standing.cshtml"
                        }
                        else if (c.Index == 3)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td style=\"background-color:goldenrod\"> ");
#nullable restore
#line 34 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\Standing.cshtml"
                                                               Write(c.Index);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 35 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\Standing.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td> ");
#nullable restore
#line 38 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\Standing.cshtml"
                            Write(c.Index);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 39 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\Standing.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td id=\"club\" >\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 1463, "\"", 1485, 1);
#nullable restore
#line 41 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\Standing.cshtml"
WriteAttributeValue("", 1469, c.standing.Flag, 1469, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            ");
#nullable restore
#line 42 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\Standing.cshtml"
                       Write(c.standing.TeamName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td> ");
#nullable restore
#line 44 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\Standing.cshtml"
                        Write(c.standing.Played);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </td>\r\n                        <td> ");
#nullable restore
#line 45 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\Standing.cshtml"
                        Write(c.standing.Won);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td> ");
#nullable restore
#line 46 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\Standing.cshtml"
                        Write(c.standing.Draw);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </td>\r\n                        <td> ");
#nullable restore
#line 47 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\Standing.cshtml"
                        Write(c.standing.Lost);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td> ");
#nullable restore
#line 48 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\Standing.cshtml"
                        Write(c.standing.GoalsFor);

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 48 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\Standing.cshtml"
                                             Write(c.standing.GoalsAgainst);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td> ");
#nullable restore
#line 49 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\Standing.cshtml"
                        Write(c.standing.GoalDifference);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td id=\"points\"> ");
#nullable restore
#line 50 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\Standing.cshtml"
                                    Write(c.standing.Points);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    </tr>\r\n");
#nullable restore
#line 52 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\Standing.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TournamentTable>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
