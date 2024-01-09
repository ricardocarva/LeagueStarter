#pragma checksum "/Users/ricardocarvalheira/Documents/repos/LeagueStarter/Pages/Teams/Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "bacda3854208f3fce6aa85fc2e5854caa222fad3c17ba8581a6afc143741cbb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(League.Pages.Teams.Pages_Teams_Index), @"mvc.1.0.razor-page", @"/Pages/Teams/Index.cshtml")]
namespace League.Pages.Teams
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/ricardocarvalheira/Documents/repos/LeagueStarter/Pages/_ViewImports.cshtml"
using League;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/ricardocarvalheira/Documents/repos/LeagueStarter/Pages/Teams/Index.cshtml"
using League.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"bacda3854208f3fce6aa85fc2e5854caa222fad3c17ba8581a6afc143741cbb2", @"/Pages/Teams/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"5f088290de2bf8b800def2262432c5928f679871215bc838aec033500e74ff67", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Teams_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 5 "/Users/ricardocarvalheira/Documents/repos/LeagueStarter/Pages/Teams/Index.cshtml"
  
  ViewData["Title"] = "Team page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center jumbotron"">
  <h2 class=""display-3"">League</h2>
</div>

<div class= ""d-flex bg-success text-white"">
  <div class=""p-2"" style=""flex:0 0 auto"">Team</div>
  <div class=""p-2"" style=""flex:0 0 auto"">Location</div>
  <div class=""p-2"" style=""flex:0 0 auto"">Name</div>
  <div class=""p-2"" style=""flex:0 0 auto"">Win</div>
  <div class=""p-2"" style=""flex:0 0 auto"">Loss</div>
  <div class=""p-2"" style=""flex:0 0 auto"">Tie</div>
  <!-- <div class=""p-2"" style=""flex:0 0 auto"">PointsFor</div>
  <div class=""p-2"" style=""flex:0 0 auto"">PointsAgainst</div>
  <div class=""p-2"" style=""flex:0 0 auto"">Stadium</div>
  <div class=""p-2"" style=""flex:0 0 auto"">Capacity</div>
  <div class=""p-2"" style=""flex:0 0 auto"">Address</div>
  <div class=""p-2"" style=""flex:0 0 auto"">City</div>
  <div class=""p-2"" style=""flex:0 0 auto"">State</div>
  <div class=""p-2"" style=""flex:0 0 auto"">Zip</div>
  <div class=""p-2"" style=""flex:0 0 auto"">Latitude</div>
  <div class=""p-2"" style=""flex:0 0 auto"">Longitude</div> -->
</div>

");
#nullable restore
#line 32 "/Users/ricardocarvalheira/Documents/repos/LeagueStarter/Pages/Teams/Index.cshtml"
 foreach (Conference Conference in Model.Conferences)
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "/Users/ricardocarvalheira/Documents/repos/LeagueStarter/Pages/Teams/Index.cshtml"
   foreach (Division Division in Model.GetConferenceDivisions(Conference.ConferenceId))
  {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "/Users/ricardocarvalheira/Documents/repos/LeagueStarter/Pages/Teams/Index.cshtml"
     foreach (Team Team in Model.GetDivisionTeams(Division.DivisionId))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <div class= \"d-flex border-left border-right border-bottom border-primary\">\n        <div class=\"p-2\" style=\"flex:0 0 auto\">");
#nullable restore
#line 39 "/Users/ricardocarvalheira/Documents/repos/LeagueStarter/Pages/Teams/Index.cshtml"
                                          Write(Team.TeamId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n        <div class=\"p-2\" style=\"flex:0 0 auto\">");
#nullable restore
#line 40 "/Users/ricardocarvalheira/Documents/repos/LeagueStarter/Pages/Teams/Index.cshtml"
                                          Write(Team.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n        <div class=\"p-2\" style=\"flex:0 0 auto\">");
#nullable restore
#line 41 "/Users/ricardocarvalheira/Documents/repos/LeagueStarter/Pages/Teams/Index.cshtml"
                                          Write(Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n        <div class=\"p-2\" style=\"flex:0 0 auto\">");
#nullable restore
#line 42 "/Users/ricardocarvalheira/Documents/repos/LeagueStarter/Pages/Teams/Index.cshtml"
                                          Write(Team.Win);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n        <div class=\"p-2\" style=\"flex:0 0 auto\">");
#nullable restore
#line 43 "/Users/ricardocarvalheira/Documents/repos/LeagueStarter/Pages/Teams/Index.cshtml"
                                          Write(Team.Loss);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n        <div class=\"p-2\" style=\"flex:0 0 auto\">");
#nullable restore
#line 44 "/Users/ricardocarvalheira/Documents/repos/LeagueStarter/Pages/Teams/Index.cshtml"
                                          Write(Team.Tie);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n        <!-- <div class=\"p-2\" style=\"flex:0 0 auto\">");
#nullable restore
#line 45 "/Users/ricardocarvalheira/Documents/repos/LeagueStarter/Pages/Teams/Index.cshtml"
                                               Write(Team.PointsFor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n        <div class=\"p-2\" style=\"flex:0 0 auto\">");
#nullable restore
#line 46 "/Users/ricardocarvalheira/Documents/repos/LeagueStarter/Pages/Teams/Index.cshtml"
                                          Write(Team.PointsAgainst);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n        <div class=\"p-2\" style=\"flex:0 0 auto\">");
#nullable restore
#line 47 "/Users/ricardocarvalheira/Documents/repos/LeagueStarter/Pages/Teams/Index.cshtml"
                                          Write(Team.Stadium);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n        <div class=\"p-2\" style=\"flex:0 0 auto\">");
#nullable restore
#line 48 "/Users/ricardocarvalheira/Documents/repos/LeagueStarter/Pages/Teams/Index.cshtml"
                                          Write(Team.Capacity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n        <div class=\"p-2\" style=\"flex:0 0 auto\">");
#nullable restore
#line 49 "/Users/ricardocarvalheira/Documents/repos/LeagueStarter/Pages/Teams/Index.cshtml"
                                          Write(Team.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n        <div class=\"p-2\" style=\"flex:0 0 auto\">");
#nullable restore
#line 50 "/Users/ricardocarvalheira/Documents/repos/LeagueStarter/Pages/Teams/Index.cshtml"
                                          Write(Team.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n        <div class=\"p-2\" style=\"flex:0 0 auto\">");
#nullable restore
#line 51 "/Users/ricardocarvalheira/Documents/repos/LeagueStarter/Pages/Teams/Index.cshtml"
                                          Write(Team.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n        <div class=\"p-2\" style=\"flex:0 0 auto\">");
#nullable restore
#line 52 "/Users/ricardocarvalheira/Documents/repos/LeagueStarter/Pages/Teams/Index.cshtml"
                                          Write(Team.Zip);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n        <div class=\"p-2\" style=\"flex:0 0 auto\">");
#nullable restore
#line 53 "/Users/ricardocarvalheira/Documents/repos/LeagueStarter/Pages/Teams/Index.cshtml"
                                          Write(Team.Latitude);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n        <div class=\"p-2\" style=\"flex:0 0 auto\">");
#nullable restore
#line 54 "/Users/ricardocarvalheira/Documents/repos/LeagueStarter/Pages/Teams/Index.cshtml"
                                          Write(Team.Longitude);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div> -->\n      </div>\n");
#nullable restore
#line 56 "/Users/ricardocarvalheira/Documents/repos/LeagueStarter/Pages/Teams/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "/Users/ricardocarvalheira/Documents/repos/LeagueStarter/Pages/Teams/Index.cshtml"
     

  }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "/Users/ricardocarvalheira/Documents/repos/LeagueStarter/Pages/Teams/Index.cshtml"
   
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
