#pragma checksum "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01ef2ad33f599f58ecc51c68698826e4cab28d5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(LeagueMatchHistory.Pages.MatchEvents.Pages_MatchEvents_Delete), @"mvc.1.0.razor-page", @"/Pages/MatchEvents/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01ef2ad33f599f58ecc51c68698826e4cab28d5f", @"/Pages/MatchEvents/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0101b22c9b0662bea1d5afa92441d45d2bce17f9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MatchEvents_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>MatchEvent</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.MatchId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.MatchId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.EventType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.EventType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.afterId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.afterId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.beforeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.beforeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.bounty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.bounty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 46 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.buildingType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 49 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.buildingType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 52 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.gameId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 55 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.gameId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 58 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.goldGain));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 61 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.goldGain));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 64 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.itemId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 67 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.itemId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 70 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.killStreakLength));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 73 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.killStreakLength));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 76 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.killType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 79 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.killType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 82 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.killerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 85 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.killerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 88 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.killerTeamId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 91 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.killerTeamId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 94 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.laneType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 97 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.laneType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 100 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.level));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 103 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.level));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 106 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.levelUpType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 109 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.levelUpType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 112 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.monsterSubType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 115 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.monsterSubType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 118 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.monsterType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 121 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.monsterType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 124 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 127 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 130 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.participantId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 133 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.participantId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 136 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.x));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 139 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.x));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 142 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.y));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 145 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.y));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 148 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.realTimeStamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 151 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.realTimeStamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 154 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.skillSlot));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 157 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.skillSlot));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 160 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.teamId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 163 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.teamId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 166 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.timestamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 169 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.timestamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 172 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.towerType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 175 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.towerType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 178 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 181 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 184 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.winningTeam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 187 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.winningTeam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 190 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.assistingParticipant0));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 193 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.assistingParticipant0));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 196 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.assistingParticipant1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 199 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.assistingParticipant1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 202 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.assistingParticipant2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 205 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.assistingParticipant2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 208 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.assistingParticipant3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 211 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.assistingParticipant3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 214 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.assistingParticipant4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 217 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.assistingParticipant4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 220 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.assistingParticipant5));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 223 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.assistingParticipant5));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 226 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.assistingParticipant6));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 229 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.assistingParticipant6));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 232 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.assistingParticipant7));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 235 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.assistingParticipant7));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 238 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.assistingParticipant8));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 241 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.assistingParticipant8));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 244 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MatchEvent.assistingParticipant9));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 247 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MatchEvent.assistingParticipant9));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01ef2ad33f599f58ecc51c68698826e4cab28d5f29240", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "01ef2ad33f599f58ecc51c68698826e4cab28d5f29507", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 252 "C:\Git Projects\ASP.NET-RIOT\Pages\MatchEvents\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MatchEvent.ID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01ef2ad33f599f58ecc51c68698826e4cab28d5f31287", async() => {
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
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LeagueMatchHistory.Pages.MatchEvents.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LeagueMatchHistory.Pages.MatchEvents.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LeagueMatchHistory.Pages.MatchEvents.DeleteModel>)PageContext?.ViewData;
        public LeagueMatchHistory.Pages.MatchEvents.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
