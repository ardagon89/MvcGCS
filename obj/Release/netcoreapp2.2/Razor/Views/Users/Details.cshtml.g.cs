#pragma checksum "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Users\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6141476d46bb022965bb858b5de84de585c7e03a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Details), @"mvc.1.0.view", @"/Views/Users/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/Details.cshtml", typeof(AspNetCore.Views_Users_Details))]
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
#line 1 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\_ViewImports.cshtml"
using MvcMovie;

#line default
#line hidden
#line 2 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\_ViewImports.cshtml"
using MvcMovie.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6141476d46bb022965bb858b5de84de585c7e03a", @"/Views/Users/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15f339ab26e1f7c427971d34ecda8fd273fe3c5f", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GCS.Models.UserCompanyViewModel>
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
            BeginContext(39, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Users\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(80, 117, true);
            WriteLiteral("\n<h1>Details</h1>\n\n<div>\n    <h4>User</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(198, 48, false);
#line 14 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Users\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.company.Name));

#line default
#line hidden
            EndContext();
            BeginContext(246, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(305, 44, false);
#line 17 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.company.Name));

#line default
#line hidden
            EndContext();
            BeginContext(349, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(407, 46, false);
#line 20 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Users\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.user.Fname));

#line default
#line hidden
            EndContext();
            BeginContext(453, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(512, 42, false);
#line 23 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.user.Fname));

#line default
#line hidden
            EndContext();
            BeginContext(554, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(612, 46, false);
#line 26 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Users\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.user.Lname));

#line default
#line hidden
            EndContext();
            BeginContext(658, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(717, 42, false);
#line 29 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.user.Lname));

#line default
#line hidden
            EndContext();
            BeginContext(759, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(817, 49, false);
#line 32 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Users\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.user.Address1));

#line default
#line hidden
            EndContext();
            BeginContext(866, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(925, 45, false);
#line 35 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.user.Address1));

#line default
#line hidden
            EndContext();
            BeginContext(970, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1028, 49, false);
#line 38 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Users\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.user.Address2));

#line default
#line hidden
            EndContext();
            BeginContext(1077, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1136, 45, false);
#line 41 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.user.Address2));

#line default
#line hidden
            EndContext();
            BeginContext(1181, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1239, 45, false);
#line 44 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Users\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.user.City));

#line default
#line hidden
            EndContext();
            BeginContext(1284, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1343, 41, false);
#line 47 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.user.City));

#line default
#line hidden
            EndContext();
            BeginContext(1384, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1442, 46, false);
#line 50 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Users\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.user.State));

#line default
#line hidden
            EndContext();
            BeginContext(1488, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1547, 42, false);
#line 53 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.user.State));

#line default
#line hidden
            EndContext();
            BeginContext(1589, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1647, 44, false);
#line 56 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Users\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.user.Zip));

#line default
#line hidden
            EndContext();
            BeginContext(1691, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1750, 40, false);
#line 59 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.user.Zip));

#line default
#line hidden
            EndContext();
            BeginContext(1790, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1848, 48, false);
#line 62 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Users\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.user.Country));

#line default
#line hidden
            EndContext();
            BeginContext(1896, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1955, 44, false);
#line 65 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.user.Country));

#line default
#line hidden
            EndContext();
            BeginContext(1999, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(2057, 46, false);
#line 68 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Users\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.user.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(2103, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(2162, 42, false);
#line 71 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.user.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(2204, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(2262, 46, false);
#line 74 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Users\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.user.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2308, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(2367, 42, false);
#line 77 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.user.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2409, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(2467, 49, false);
#line 80 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Users\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.user.Password));

#line default
#line hidden
            EndContext();
            BeginContext(2516, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(2575, 45, false);
#line 83 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.user.Password));

#line default
#line hidden
            EndContext();
            BeginContext(2620, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(2678, 49, false);
#line 86 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Users\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.user.Is_admin));

#line default
#line hidden
            EndContext();
            BeginContext(2727, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(2786, 45, false);
#line 89 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.user.Is_admin));

#line default
#line hidden
            EndContext();
            BeginContext(2831, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(2889, 47, false);
#line 92 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Users\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.user.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(2936, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(2995, 43, false);
#line 95 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.user.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(3038, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(3096, 45, false);
#line 98 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Users\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.user.Race));

#line default
#line hidden
            EndContext();
            BeginContext(3141, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(3200, 41, false);
#line 101 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.user.Race));

#line default
#line hidden
            EndContext();
            BeginContext(3241, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(3299, 45, false);
#line 104 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Users\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.user.Role));

#line default
#line hidden
            EndContext();
            BeginContext(3344, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(3403, 41, false);
#line 107 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.user.Role));

#line default
#line hidden
            EndContext();
            BeginContext(3444, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(3502, 55, false);
#line 110 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Users\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.user.Company_length));

#line default
#line hidden
            EndContext();
            BeginContext(3557, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(3616, 51, false);
#line 113 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.user.Company_length));

#line default
#line hidden
            EndContext();
            BeginContext(3667, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(3725, 52, false);
#line 116 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Users\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.user.Role_length));

#line default
#line hidden
            EndContext();
            BeginContext(3777, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(3836, 48, false);
#line 119 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Users\Details.cshtml"
       Write(Html.DisplayFor(model => model.user.Role_length));

#line default
#line hidden
            EndContext();
            BeginContext(3884, 43, true);
            WriteLiteral("\n        </dd>\n\n    </dl>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(3927, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6141476d46bb022965bb858b5de84de585c7e03a20010", async() => {
                BeginContext(3979, 4, true);
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
#line 125 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Users\Details.cshtml"
                            WriteLiteral(Model.user.Id);

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
            BeginContext(3987, 7, true);
            WriteLiteral(" |\n    ");
            EndContext();
            BeginContext(3994, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6141476d46bb022965bb858b5de84de585c7e03a22355", async() => {
                BeginContext(4016, 12, true);
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
            BeginContext(4032, 7, true);
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GCS.Models.UserCompanyViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
