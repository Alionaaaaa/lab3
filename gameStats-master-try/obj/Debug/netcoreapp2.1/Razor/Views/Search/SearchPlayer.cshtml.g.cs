#pragma checksum "D:\UNIVERSITATE\Semestrul 5\IDWeb\Lab 3\App\gameStats-master - try\Views\Search\SearchPlayer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca0b912e2e75d0d4fe5728fb48031d6f79a68636"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_SearchPlayer), @"mvc.1.0.view", @"/Views/Search/SearchPlayer.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Search/SearchPlayer.cshtml", typeof(AspNetCore.Views_Search_SearchPlayer))]
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
#line 1 "D:\UNIVERSITATE\Semestrul 5\IDWeb\Lab 3\App\gameStats-master - try\Views\_ViewImports.cshtml"
using gameStats;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca0b912e2e75d0d4fe5728fb48031d6f79a68636", @"/Views/Search/SearchPlayer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7022991342fb45a33057a6fb86c94f440c9b65e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_SearchPlayer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<gameStats.Models.Players>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SearchHome", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(45, 101, true);
            WriteLiteral("\n<h2>Player</h2>\n\n    <h4>Stats</h4>\n\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>");
            EndContext();
            BeginContext(147, 44, false);
#line 10 "D:\UNIVERSITATE\Semestrul 5\IDWeb\Lab 3\App\gameStats-master - try\Views\Search\SearchPlayer.cshtml"
           Write(Html.DisplayNameFor(model => model.Nickname));

#line default
#line hidden
            EndContext();
            BeginContext(191, 22, true);
            WriteLiteral("</th>\n            <th>");
            EndContext();
            BeginContext(214, 44, false);
#line 11 "D:\UNIVERSITATE\Semestrul 5\IDWeb\Lab 3\App\gameStats-master - try\Views\Search\SearchPlayer.cshtml"
           Write(Html.DisplayNameFor(model => model.Distance));

#line default
#line hidden
            EndContext();
            BeginContext(258, 22, true);
            WriteLiteral("</th>\n            <th>");
            EndContext();
            BeginContext(281, 41, false);
#line 12 "D:\UNIVERSITATE\Semestrul 5\IDWeb\Lab 3\App\gameStats-master - try\Views\Search\SearchPlayer.cshtml"
           Write(Html.DisplayNameFor(model => model.Shots));

#line default
#line hidden
            EndContext();
            BeginContext(322, 38, true);
            WriteLiteral("</th>                \n            <th>");
            EndContext();
            BeginContext(361, 40, false);
#line 13 "D:\UNIVERSITATE\Semestrul 5\IDWeb\Lab 3\App\gameStats-master - try\Views\Search\SearchPlayer.cshtml"
           Write(Html.DisplayNameFor(model => model.Hits));

#line default
#line hidden
            EndContext();
            BeginContext(401, 45, true);
            WriteLiteral("</th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 17 "D:\UNIVERSITATE\Semestrul 5\IDWeb\Lab 3\App\gameStats-master - try\Views\Search\SearchPlayer.cshtml"
    foreach (var item in Model) {

#line default
#line hidden
            BeginContext(480, 29, true);
            WriteLiteral("        <tr>\n            <td>");
            EndContext();
            BeginContext(510, 43, false);
#line 19 "D:\UNIVERSITATE\Semestrul 5\IDWeb\Lab 3\App\gameStats-master - try\Views\Search\SearchPlayer.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nickname));

#line default
#line hidden
            EndContext();
            BeginContext(553, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(576, 43, false);
#line 20 "D:\UNIVERSITATE\Semestrul 5\IDWeb\Lab 3\App\gameStats-master - try\Views\Search\SearchPlayer.cshtml"
           Write(Html.DisplayFor(modelItem => item.Distance));

#line default
#line hidden
            EndContext();
            BeginContext(619, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(642, 40, false);
#line 21 "D:\UNIVERSITATE\Semestrul 5\IDWeb\Lab 3\App\gameStats-master - try\Views\Search\SearchPlayer.cshtml"
           Write(Html.DisplayFor(modelItem => item.Shots));

#line default
#line hidden
            EndContext();
            BeginContext(682, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(705, 39, false);
#line 22 "D:\UNIVERSITATE\Semestrul 5\IDWeb\Lab 3\App\gameStats-master - try\Views\Search\SearchPlayer.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hits));

#line default
#line hidden
            EndContext();
            BeginContext(744, 20, true);
            WriteLiteral("</td>\n        </tr>\n");
            EndContext();
#line 24 "D:\UNIVERSITATE\Semestrul 5\IDWeb\Lab 3\App\gameStats-master - try\Views\Search\SearchPlayer.cshtml"
   }

#line default
#line hidden
            BeginContext(769, 22, true);
            WriteLiteral("   </tbody>\n</table>\n ");
            EndContext();
            BeginContext(791, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca0b912e2e75d0d4fe5728fb48031d6f79a686367881", async() => {
                BeginContext(834, 47, true);
                WriteLiteral("\n    <input type=\"submit\" value=\"Go Back\">\n    ");
                EndContext();
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
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<gameStats.Models.Players>> Html { get; private set; }
    }
}
#pragma warning restore 1591
