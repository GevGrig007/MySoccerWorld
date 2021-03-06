#pragma checksum "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shedulles\AddTeams.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99322b0749bb691051b23bba580b06942a482d6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shedulles_AddTeams), @"mvc.1.0.view", @"/Views/Shedulles/AddTeams.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99322b0749bb691051b23bba580b06942a482d6a", @"/Views/Shedulles/AddTeams.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27b41d72e309e687d740d9d0d2ac34708a534e9b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shedulles_AddTeams : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tournament>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddTeams", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shedulles\AddTeams.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"modal-content\">\r\n    <div class=\"modal-header\">\r\n        <button class=\"close\" data-dismiss=\"modal\" area-hidden=\"true\">X</button>\r\n    </div>\r\n    <div class=\"modal-body p-0\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99322b0749bb691051b23bba580b06942a482d6a4835", async() => {
                WriteLiteral("\r\n            <h3 class=\"d-flex justify-content-center\" style=\"background-color:brown;color:antiquewhite;padding:5px;\"> Select Teams </h3>\r\n            ");
#nullable restore
#line 12 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shedulles\AddTeams.cshtml"
       Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <div class=\"d-flex justify-content-center\">\r\n                ");
#nullable restore
#line 14 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shedulles\AddTeams.cshtml"
           Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\"d-flex justify-content-center\"><b>Teams</b></div>\r\n\r\n");
#nullable restore
#line 18 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shedulles\AddTeams.cshtml"
             if (Model.League.Type == "Regional")
            {
                List<Club> teams = ViewBag.Clubs;
                foreach (Club c in teams)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <input type=\"checkbox\" name=\"selectedClubs\"");
                BeginWriteAttribute("value", " value=\"", 923, "\"", 936, 1);
#nullable restore
#line 23 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shedulles\AddTeams.cshtml"
WriteAttributeValue("", 931, c.Id, 931, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"margin-left:20%;\"\r\n                           ");
#nullable restore
#line 24 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shedulles\AddTeams.cshtml"
                       Write(Model.Teams.Contains(c) ? "checked=\"checked\"" : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(" />\r\n");
#nullable restore
#line 25 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shedulles\AddTeams.cshtml"
               Write(c.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <br />\r\n");
#nullable restore
#line 27 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shedulles\AddTeams.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shedulles\AddTeams.cshtml"
             if (Model.League.Type == "EuroCup")
            {
                List<Club> teams = ViewBag.EuroClubs;
                foreach (Club c in teams)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <input type=\"checkbox\" name=\"selectedClubs\"");
                BeginWriteAttribute("value", " value=\"", 1387, "\"", 1400, 1);
#nullable restore
#line 34 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shedulles\AddTeams.cshtml"
WriteAttributeValue("", 1395, c.Id, 1395, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"margin-left:20%;\"\r\n                           ");
#nullable restore
#line 35 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shedulles\AddTeams.cshtml"
                       Write(Model.Teams.Contains(c) ? "checked=\"checked\"" : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(" />\r\n");
#nullable restore
#line 36 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shedulles\AddTeams.cshtml"
               Write(c.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <br />\r\n");
#nullable restore
#line 38 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shedulles\AddTeams.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shedulles\AddTeams.cshtml"
             if (Model.League.Type == "National")
            {
                List<National> teams = ViewBag.Nationals;
                foreach (National c in teams)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <input type=\"checkbox\" name=\"selectedClubs\"");
                BeginWriteAttribute("value", " value=\"", 1860, "\"", 1873, 1);
#nullable restore
#line 45 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shedulles\AddTeams.cshtml"
WriteAttributeValue("", 1868, c.Id, 1868, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"margin-left:20%;\"\r\n                           ");
#nullable restore
#line 46 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shedulles\AddTeams.cshtml"
                       Write(Model.Teams.Contains(c) ? "checked=\"checked\"" : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(" />\r\n");
#nullable restore
#line 47 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shedulles\AddTeams.cshtml"
               Write(c.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <br />\r\n");
#nullable restore
#line 49 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shedulles\AddTeams.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <p class=\"d-flex justify-content-center\">\r\n                <input type=\"submit\" value=\"ADD SELECTED TEAMS\" />\r\n            </p>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tournament> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
