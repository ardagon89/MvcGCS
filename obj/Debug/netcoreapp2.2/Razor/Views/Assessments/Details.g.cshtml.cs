#pragma checksum "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93611837d1f1b776df153ed2583f2fb68883af8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Assessments_Details), @"mvc.1.0.view", @"/Views/Assessments/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Assessments/Details.cshtml", typeof(AspNetCore.Views_Assessments_Details))]
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
#line 1 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\_ViewImports.cshtml"
using MvcMovie;

#line default
#line hidden
#line 2 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\_ViewImports.cshtml"
using MvcMovie.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93611837d1f1b776df153ed2583f2fb68883af8d", @"/Views/Assessments/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15f339ab26e1f7c427971d34ecda8fd273fe3c5f", @"/Views/_ViewImports.cshtml")]
    public class Views_Assessments_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GCS.Models.Assessment>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(29, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(70, 193, true);
            WriteLiteral("\n<h1>Details</h1>\n\n<div>\n    <h4>Assessment</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class=\"col-sm-2\">\n            Company Name\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(264, 20, false);
#line 17 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(ViewBag.company.Name);

#line default
#line hidden
            EndContext();
            BeginContext(284, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(344, 51, false);
#line 20 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Assessment_date));

#line default
#line hidden
            EndContext();
            BeginContext(395, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(456, 47, false);
#line 23 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayFor(model => model.Assessment_date));

#line default
#line hidden
            EndContext();
            BeginContext(503, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(563, 52, false);
#line 26 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Vision_agreement));

#line default
#line hidden
            EndContext();
            BeginContext(615, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(676, 48, false);
#line 29 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayFor(model => model.Vision_agreement));

#line default
#line hidden
            EndContext();
            BeginContext(724, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(784, 57, false);
#line 32 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Core_values_agreement));

#line default
#line hidden
            EndContext();
            BeginContext(841, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(902, 53, false);
#line 35 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayFor(model => model.Core_values_agreement));

#line default
#line hidden
            EndContext();
            BeginContext(955, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1015, 63, false);
#line 38 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Mission_statement_agreement));

#line default
#line hidden
            EndContext();
            BeginContext(1078, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1139, 59, false);
#line 41 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayFor(model => model.Mission_statement_agreement));

#line default
#line hidden
            EndContext();
            BeginContext(1198, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1258, 60, false);
#line 44 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Vision_outcome_agreement));

#line default
#line hidden
            EndContext();
            BeginContext(1318, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1379, 56, false);
#line 47 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayFor(model => model.Vision_outcome_agreement));

#line default
#line hidden
            EndContext();
            BeginContext(1435, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1495, 66, false);
#line 50 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Competitive_strategy_agreement));

#line default
#line hidden
            EndContext();
            BeginContext(1561, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1622, 62, false);
#line 53 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayFor(model => model.Competitive_strategy_agreement));

#line default
#line hidden
            EndContext();
            BeginContext(1684, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1744, 59, false);
#line 56 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Company_composite_score));

#line default
#line hidden
            EndContext();
            BeginContext(1803, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1864, 55, false);
#line 59 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayFor(model => model.Company_composite_score));

#line default
#line hidden
            EndContext();
            BeginContext(1919, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1979, 54, false);
#line 62 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Strat_people_score));

#line default
#line hidden
            EndContext();
            BeginContext(2033, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(2094, 50, false);
#line 65 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayFor(model => model.Strat_people_score));

#line default
#line hidden
            EndContext();
            BeginContext(2144, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(2204, 57, false);
#line 68 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Strat_resources_score));

#line default
#line hidden
            EndContext();
            BeginContext(2261, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(2322, 53, false);
#line 71 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayFor(model => model.Strat_resources_score));

#line default
#line hidden
            EndContext();
            BeginContext(2375, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(2435, 57, false);
#line 74 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Strat_processes_score));

#line default
#line hidden
            EndContext();
            BeginContext(2492, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(2553, 53, false);
#line 77 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayFor(model => model.Strat_processes_score));

#line default
#line hidden
            EndContext();
            BeginContext(2606, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(2666, 55, false);
#line 80 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Strat_culture_score));

#line default
#line hidden
            EndContext();
            BeginContext(2721, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(2782, 51, false);
#line 83 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayFor(model => model.Strat_culture_score));

#line default
#line hidden
            EndContext();
            BeginContext(2833, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(2893, 57, false);
#line 86 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Strat_composite_score));

#line default
#line hidden
            EndContext();
            BeginContext(2950, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(3011, 53, false);
#line 89 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayFor(model => model.Strat_composite_score));

#line default
#line hidden
            EndContext();
            BeginContext(3064, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(3124, 54, false);
#line 92 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Stake_people_score));

#line default
#line hidden
            EndContext();
            BeginContext(3178, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(3239, 50, false);
#line 95 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayFor(model => model.Stake_people_score));

#line default
#line hidden
            EndContext();
            BeginContext(3289, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(3349, 57, false);
#line 98 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Stake_resources_score));

#line default
#line hidden
            EndContext();
            BeginContext(3406, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(3467, 53, false);
#line 101 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayFor(model => model.Stake_resources_score));

#line default
#line hidden
            EndContext();
            BeginContext(3520, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(3580, 57, false);
#line 104 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Stake_processes_score));

#line default
#line hidden
            EndContext();
            BeginContext(3637, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(3698, 53, false);
#line 107 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayFor(model => model.Stake_processes_score));

#line default
#line hidden
            EndContext();
            BeginContext(3751, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(3811, 55, false);
#line 110 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Stake_culture_score));

#line default
#line hidden
            EndContext();
            BeginContext(3866, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(3927, 51, false);
#line 113 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayFor(model => model.Stake_culture_score));

#line default
#line hidden
            EndContext();
            BeginContext(3978, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(4038, 57, false);
#line 116 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Stake_composite_score));

#line default
#line hidden
            EndContext();
            BeginContext(4095, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(4156, 53, false);
#line 119 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayFor(model => model.Stake_composite_score));

#line default
#line hidden
            EndContext();
            BeginContext(4209, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(4269, 53, false);
#line 122 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Oper_people_score));

#line default
#line hidden
            EndContext();
            BeginContext(4322, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(4383, 49, false);
#line 125 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayFor(model => model.Oper_people_score));

#line default
#line hidden
            EndContext();
            BeginContext(4432, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(4492, 56, false);
#line 128 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Oper_resources_score));

#line default
#line hidden
            EndContext();
            BeginContext(4548, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(4609, 52, false);
#line 131 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayFor(model => model.Oper_resources_score));

#line default
#line hidden
            EndContext();
            BeginContext(4661, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(4721, 56, false);
#line 134 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Oper_processes_score));

#line default
#line hidden
            EndContext();
            BeginContext(4777, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(4838, 52, false);
#line 137 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayFor(model => model.Oper_processes_score));

#line default
#line hidden
            EndContext();
            BeginContext(4890, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(4950, 54, false);
#line 140 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Oper_culture_score));

#line default
#line hidden
            EndContext();
            BeginContext(5004, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(5065, 50, false);
#line 143 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayFor(model => model.Oper_culture_score));

#line default
#line hidden
            EndContext();
            BeginContext(5115, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(5175, 56, false);
#line 146 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Oper_composite_score));

#line default
#line hidden
            EndContext();
            BeginContext(5231, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(5292, 52, false);
#line 149 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayFor(model => model.Oper_composite_score));

#line default
#line hidden
            EndContext();
            BeginContext(5344, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(5404, 53, false);
#line 152 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Risk_people_score));

#line default
#line hidden
            EndContext();
            BeginContext(5457, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(5518, 49, false);
#line 155 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayFor(model => model.Risk_people_score));

#line default
#line hidden
            EndContext();
            BeginContext(5567, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(5627, 56, false);
#line 158 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Risk_resources_score));

#line default
#line hidden
            EndContext();
            BeginContext(5683, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(5744, 52, false);
#line 161 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayFor(model => model.Risk_resources_score));

#line default
#line hidden
            EndContext();
            BeginContext(5796, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(5856, 56, false);
#line 164 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Risk_processes_score));

#line default
#line hidden
            EndContext();
            BeginContext(5912, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(5973, 52, false);
#line 167 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayFor(model => model.Risk_processes_score));

#line default
#line hidden
            EndContext();
            BeginContext(6025, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(6085, 54, false);
#line 170 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Risk_culture_score));

#line default
#line hidden
            EndContext();
            BeginContext(6139, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(6200, 50, false);
#line 173 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayFor(model => model.Risk_culture_score));

#line default
#line hidden
            EndContext();
            BeginContext(6250, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(6310, 56, false);
#line 176 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Risk_composite_score));

#line default
#line hidden
            EndContext();
            BeginContext(6366, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(6427, 52, false);
#line 179 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
       Write(Html.DisplayFor(model => model.Risk_composite_score));

#line default
#line hidden
            EndContext();
            BeginContext(6479, 42, true);
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(6521, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93611837d1f1b776df153ed2583f2fb68883af8d28705", async() => {
                BeginContext(6567, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 184 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Assessments\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(6575, 7, true);
            WriteLiteral(" |\n    ");
            EndContext();
            BeginContext(6582, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93611837d1f1b776df153ed2583f2fb68883af8d31039", async() => {
                BeginContext(6604, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6620, 8, true);
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GCS.Models.Assessment> Html { get; private set; }
    }
}
#pragma warning restore 1591
