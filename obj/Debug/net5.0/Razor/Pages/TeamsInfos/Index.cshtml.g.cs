#pragma checksum "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f9b20d90cbadaf65ddb6c0dc801485e699a6f1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(LeagueMatchHistory.Pages.TeamsInfos.Pages_TeamsInfos_Index), @"mvc.1.0.razor-page", @"/Pages/TeamsInfos/Index.cshtml")]
namespace LeagueMatchHistory.Pages.TeamsInfos
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
#line 1 "C:\Git Projects\ASP.NET-RIOT\Pages\_ViewImports.cshtml"
using LeagueMatchHistory;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f9b20d90cbadaf65ddb6c0dc801485e699a6f1c", @"/Pages/TeamsInfos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0101b22c9b0662bea1d5afa92441d45d2bce17f9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_TeamsInfos_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f9b20d90cbadaf65ddb6c0dc801485e699a6f1c4356", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TeamsInfo[0].MatchId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TeamsInfo[0].Ban0));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TeamsInfo[0].Ban1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TeamsInfo[0].Ban2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TeamsInfo[0].Ban3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TeamsInfo[0].Ban4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TeamsInfo[0].FirstBaron));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TeamsInfo[0].BaronKills));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TeamsInfo[0].FirstBlood));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TeamsInfo[0].ChampionKills));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 47 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TeamsInfo[0].FirstDragon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 50 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TeamsInfo[0].DragonKills));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 53 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TeamsInfo[0].FirstInhibitor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 56 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TeamsInfo[0].InhibitorKills));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 59 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TeamsInfo[0].FirstRitHerald));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 62 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TeamsInfo[0].RiftHeraldKills));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 65 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TeamsInfo[0].FirstTower));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 68 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TeamsInfo[0].TowerKills));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 71 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TeamsInfo[0].TeamId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 74 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TeamsInfo[0].Win));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 80 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
 foreach (var item in Model.TeamsInfo) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 83 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MatchId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 86 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Ban0));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 89 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Ban1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 92 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Ban2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 95 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Ban3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 98 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Ban4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 101 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstBaron));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 104 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BaronKills));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 107 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstBlood));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 110 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ChampionKills));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 113 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstDragon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 116 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DragonKills));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 119 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstInhibitor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 122 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.InhibitorKills));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 125 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstRitHerald));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 128 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RiftHeraldKills));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 131 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstTower));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 134 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TowerKills));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 137 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TeamId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 140 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Win));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f9b20d90cbadaf65ddb6c0dc801485e699a6f1c18087", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 143 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
                                       WriteLiteral(item.ID);

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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f9b20d90cbadaf65ddb6c0dc801485e699a6f1c20231", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 144 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
                                          WriteLiteral(item.ID);

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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f9b20d90cbadaf65ddb6c0dc801485e699a6f1c22381", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 145 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
                                         WriteLiteral(item.ID);

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
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 148 "C:\Git Projects\ASP.NET-RIOT\Pages\TeamsInfos\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LeagueMatchHistory.Pages.TeamsInfos.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LeagueMatchHistory.Pages.TeamsInfos.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LeagueMatchHistory.Pages.TeamsInfos.IndexModel>)PageContext?.ViewData;
        public LeagueMatchHistory.Pages.TeamsInfos.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
