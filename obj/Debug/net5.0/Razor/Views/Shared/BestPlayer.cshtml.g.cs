#pragma checksum "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\BestPlayer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c030be38e7eb29906f4d21717ab5a1603193f1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_BestPlayer), @"mvc.1.0.view", @"/Views/Shared/BestPlayer.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c030be38e7eb29906f4d21717ab5a1603193f1d", @"/Views/Shared/BestPlayer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27b41d72e309e687d740d9d0d2ac34708a534e9b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_BestPlayer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tournament>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("disabled", new global::Microsoft.AspNetCore.Html.HtmlString("disabled"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "bp", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditBP", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Tournaments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"center\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c030be38e7eb29906f4d21717ab5a1603193f1d6025", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 154, "\"", 171, 1);
#nullable restore
#line 4 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\BestPlayer.cshtml"
WriteAttributeValue("", 162, Model.Id, 162, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c030be38e7eb29906f4d21717ab5a1603193f1d6704", async() => {
                    WriteLiteral("\r\n            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c030be38e7eb29906f4d21717ab5a1603193f1d6984", async() => {
                        WriteLiteral(" ");
#nullable restore
#line 6 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\BestPlayer.cshtml"
                                                        Write(Model.BestPlayerSchema);

#line default
#line hidden
#nullable disable
                        WriteLiteral(" ");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 5 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\BestPlayer.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Html.GetEnumSelectList<BPSchema>();

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"apply\" />\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
#nullable restore
#line 11 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\BestPlayer.cshtml"
  
    if (Model.BestPlayerSchema == BPSchema.F_31213)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\BestPlayer.cshtml"
   Write(await Html.PartialAsync("~/Views/BestPlayers/BestPlayer31213.cshtml", Model.BestPlayers));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\BestPlayer.cshtml"
                                                                                                 
    }
    else if (Model.BestPlayerSchema == BPSchema.F_31222)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\BestPlayer.cshtml"
   Write(await Html.PartialAsync("~/Views/BestPlayers/BestPlayer31222.cshtml", Model.BestPlayers));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\BestPlayer.cshtml"
                                                                                                 
    }
    else if (Model.BestPlayerSchema == BPSchema.F_31321)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\BestPlayer.cshtml"
   Write(await Html.PartialAsync("~/Views/BestPlayers/BestPlayer31321.cshtml", Model.BestPlayers));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\BestPlayer.cshtml"
                                                                                                 
    }
    else if (Model.BestPlayerSchema == BPSchema.F_3223)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\BestPlayer.cshtml"
   Write(await Html.PartialAsync("~/Views/BestPlayers/BestPlayer3223.cshtml", Model.BestPlayers));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\BestPlayer.cshtml"
                                                                                                
    }
    else if (Model.BestPlayerSchema == BPSchema.F_3232)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\BestPlayer.cshtml"
   Write(await Html.PartialAsync("~/Views/BestPlayers/BestPlayer3232.cshtml", Model.BestPlayers));

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\BestPlayer.cshtml"
                                                                                                
    }
    else if (Model.BestPlayerSchema == BPSchema.F_3313)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\BestPlayer.cshtml"
   Write(await Html.PartialAsync("~/Views/BestPlayers/BestPlayer3313.cshtml", Model.BestPlayers));

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\BestPlayer.cshtml"
                                                                                                
    }
    else if (Model.BestPlayerSchema == BPSchema.F_3322)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\BestPlayer.cshtml"
   Write(await Html.PartialAsync("~/Views/BestPlayers/BestPlayer3322.cshtml", Model.BestPlayers));

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\BestPlayer.cshtml"
                                                                                                
    }
    else if (Model.BestPlayerSchema == BPSchema.F_3331)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\BestPlayer.cshtml"
   Write(await Html.PartialAsync("~/Views/BestPlayers/BestPlayer3331.cshtml", Model.BestPlayers));

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\BestPlayer.cshtml"
                                                                                                
    }
    else if (Model.BestPlayerSchema == BPSchema.F_442)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\BestPlayer.cshtml"
   Write(await Html.PartialAsync("~/Views/BestPlayers/BestPlayer442.cshtml", Model.BestPlayers));

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\BestPlayer.cshtml"
                                                                                               
    }
    else if (Model.BestPlayerSchema == BPSchema.F_32131)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\BestPlayer.cshtml"
   Write(await Html.PartialAsync("~/Views/BestPlayers/BestPlayer32131.cshtml", Model.BestPlayers));

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\BestPlayer.cshtml"
                                                                                                 
    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\BestPlayer.cshtml"
   Write(await Html.PartialAsync("~/Views/BestPlayers/BestPlayer3133.cshtml", Model.BestPlayers));

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\User\Desktop\Projects\MySoccerWorld\Views\Shared\BestPlayer.cshtml"
                                                                                                
    }


#line default
#line hidden
#nullable disable
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
