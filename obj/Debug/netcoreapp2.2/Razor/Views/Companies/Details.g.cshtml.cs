#pragma checksum "C:\Users\shari\source\repos\MvcGCS\Views\Companies\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8566263644412b6f8397123acbc0e9168c8d281"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Companies_Details), @"mvc.1.0.view", @"/Views/Companies/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Companies/Details.cshtml", typeof(AspNetCore.Views_Companies_Details))]
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
#line 1 "C:\Users\shari\source\repos\MvcGCS\Views\_ViewImports.cshtml"
using MvcMovie;

#line default
#line hidden
#line 2 "C:\Users\shari\source\repos\MvcGCS\Views\_ViewImports.cshtml"
using MvcMovie.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8566263644412b6f8397123acbc0e9168c8d281", @"/Views/Companies/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"686ad2e38abb871af45be971520cc6c3156da389", @"/Views/_ViewImports.cshtml")]
    public class Views_Companies_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GCS.Models.Company>
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
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\shari\source\repos\MvcGCS\Views\Companies\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(72, 130, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Company</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(203, 40, false);
#line 14 "C:\Users\shari\source\repos\MvcGCS\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(243, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(307, 36, false);
#line 17 "C:\Users\shari\source\repos\MvcGCS\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(343, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(406, 43, false);
#line 20 "C:\Users\shari\source\repos\MvcGCS\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(449, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(513, 39, false);
#line 23 "C:\Users\shari\source\repos\MvcGCS\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(552, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(615, 41, false);
#line 26 "C:\Users\shari\source\repos\MvcGCS\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(656, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(720, 37, false);
#line 29 "C:\Users\shari\source\repos\MvcGCS\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(757, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(820, 43, false);
#line 32 "C:\Users\shari\source\repos\MvcGCS\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Website));

#line default
#line hidden
            EndContext();
            BeginContext(863, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(927, 39, false);
#line 35 "C:\Users\shari\source\repos\MvcGCS\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Website));

#line default
#line hidden
            EndContext();
            BeginContext(966, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1029, 41, false);
#line 38 "C:\Users\shari\source\repos\MvcGCS\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1070, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1134, 37, false);
#line 41 "C:\Users\shari\source\repos\MvcGCS\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1171, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1234, 42, false);
#line 44 "C:\Users\shari\source\repos\MvcGCS\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Vision));

#line default
#line hidden
            EndContext();
            BeginContext(1276, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1340, 38, false);
#line 47 "C:\Users\shari\source\repos\MvcGCS\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Vision));

#line default
#line hidden
            EndContext();
            BeginContext(1378, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1441, 43, false);
#line 50 "C:\Users\shari\source\repos\MvcGCS\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Mission));

#line default
#line hidden
            EndContext();
            BeginContext(1484, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1548, 39, false);
#line 53 "C:\Users\shari\source\repos\MvcGCS\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Mission));

#line default
#line hidden
            EndContext();
            BeginContext(1587, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1650, 41, false);
#line 56 "C:\Users\shari\source\repos\MvcGCS\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Value));

#line default
#line hidden
            EndContext();
            BeginContext(1691, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1755, 37, false);
#line 59 "C:\Users\shari\source\repos\MvcGCS\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Value));

#line default
#line hidden
            EndContext();
            BeginContext(1792, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1855, 40, false);
#line 62 "C:\Users\shari\source\repos\MvcGCS\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(1895, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1959, 36, false);
#line 65 "C:\Users\shari\source\repos\MvcGCS\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(1995, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2058, 48, false);
#line 68 "C:\Users\shari\source\repos\MvcGCS\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Revenue_band));

#line default
#line hidden
            EndContext();
            BeginContext(2106, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2170, 44, false);
#line 71 "C:\Users\shari\source\repos\MvcGCS\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Revenue_band));

#line default
#line hidden
            EndContext();
            BeginContext(2214, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2277, 49, false);
#line 74 "C:\Users\shari\source\repos\MvcGCS\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee_band));

#line default
#line hidden
            EndContext();
            BeginContext(2326, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2390, 45, false);
#line 77 "C:\Users\shari\source\repos\MvcGCS\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee_band));

#line default
#line hidden
            EndContext();
            BeginContext(2435, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2498, 41, false);
#line 80 "C:\Users\shari\source\repos\MvcGCS\Views\Companies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Stage));

#line default
#line hidden
            EndContext();
            BeginContext(2539, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2603, 37, false);
#line 83 "C:\Users\shari\source\repos\MvcGCS\Views\Companies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Stage));

#line default
#line hidden
            EndContext();
            BeginContext(2640, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2687, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8566263644412b6f8397123acbc0e9168c8d28113955", async() => {
                BeginContext(2733, 4, true);
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
#line 88 "C:\Users\shari\source\repos\MvcGCS\Views\Companies\Details.cshtml"
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
            BeginContext(2741, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2749, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8566263644412b6f8397123acbc0e9168c8d28116263", async() => {
                BeginContext(2771, 12, true);
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
            BeginContext(2787, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GCS.Models.Company> Html { get; private set; }
    }
}
#pragma warning restore 1591