#pragma checksum "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fc2691f028b6f6f35bf413b45411f9e48bcd71f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(LeagueMatchHistory.Pages.MatchEvents.Pages_MatchEvents_Details), @"mvc.1.0.razor-page", @"/Pages/MatchEvents/Details.cshtml")]
namespace LeagueMatchHistory.Pages.MatchEvents
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fc2691f028b6f6f35bf413b45411f9e48bcd71f", @"/Pages/MatchEvents/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0101b22c9b0662bea1d5afa92441d45d2bce17f9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MatchEvents_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>MatchEvent</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.MatchId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.MatchId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.EventType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.EventType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.afterId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.afterId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.beforeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.beforeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.bounty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.bounty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.buildingType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.buildingType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.gameId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.gameId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.goldGain));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.goldGain));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.itemId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.itemId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.killStreakLength));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.killStreakLength));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 75 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.killType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 78 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.killType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 81 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.killerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 84 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.killerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 87 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.killerTeamId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 90 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.killerTeamId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 93 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.laneType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 96 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.laneType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 99 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.level));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 102 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.level));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 105 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.levelUpType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 108 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.levelUpType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 111 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.monsterSubType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 114 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.monsterSubType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 117 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.monsterType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 120 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.monsterType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 123 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 126 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 129 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.participantId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 132 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.participantId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 135 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.x));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 138 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.x));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 141 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.y));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 144 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.y));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 147 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.realTimeStamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 150 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.realTimeStamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 153 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.skillSlot));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 156 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.skillSlot));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 159 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.teamId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 162 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.teamId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 165 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.timestamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 168 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.timestamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 171 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.towerType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 174 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.towerType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 177 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 180 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 183 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.winningTeam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 186 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.winningTeam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 189 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.assistingParticipant0));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 192 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.assistingParticipant0));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 195 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.assistingParticipant1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 198 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.assistingParticipant1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 201 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.assistingParticipant2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 204 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.assistingParticipant2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 207 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.assistingParticipant3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 210 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.assistingParticipant3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 213 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.assistingParticipant4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 216 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.assistingParticipant4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 219 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.assistingParticipant5));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 222 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.assistingParticipant5));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 225 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.assistingParticipant6));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 228 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.assistingParticipant6));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 231 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.assistingParticipant7));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 234 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.assistingParticipant7));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 237 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.assistingParticipant8));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 240 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.assistingParticipant8));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 243 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.assistingParticipant9));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 246 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.assistingParticipant9));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fc2691f028b6f6f35bf413b45411f9e48bcd71f28583", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 251 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Details.cshtml"
                           WriteLiteral(Model.MatchEvent.ID);

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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0fc2691f028b6f6f35bf413b45411f9e48bcd71f30718", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LeagueMatchHistory.Pages.MatchEvents.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LeagueMatchHistory.Pages.MatchEvents.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LeagueMatchHistory.Pages.MatchEvents.DetailsModel>)PageContext?.ViewData;
        public LeagueMatchHistory.Pages.MatchEvents.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
