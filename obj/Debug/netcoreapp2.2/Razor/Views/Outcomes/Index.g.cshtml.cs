#pragma checksum "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Outcomes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5947ad59878eec6c59b4928a3a2e2457e53f52f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Outcomes_Index), @"mvc.1.0.view", @"/Views/Outcomes/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Outcomes/Index.cshtml", typeof(AspNetCore.Views_Outcomes_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5947ad59878eec6c59b4928a3a2e2457e53f52f4", @"/Views/Outcomes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15f339ab26e1f7c427971d34ecda8fd273fe3c5f", @"/Views/_ViewImports.cshtml")]
    public class Views_Outcomes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GCS.Models.OutcomeCompanyViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(55, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Outcomes\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(94, 80, true);
            WriteLiteral("\n    <ol class=\"breadcrumb\">\n        <li class=\"breadcrumb-item\">\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 174, "\"", 209, 1);
#line 9 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Outcomes\Index.cshtml"
WriteAttributeValue("", 181, Url.Action("Index", "Home"), 181, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(210, 351, true);
            WriteLiteral(@">Home</a>
        </li>
        <li class=""breadcrumb-item active"">Outcomes</li>
    </ol>

    <div class=""card mb-3"">
        <div class=""card-header"">
            <i class=""fas fa-table""></i>
            Outcomes List
        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">
                <p>
                    ");
            EndContext();
            BeginContext(561, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5947ad59878eec6c59b4928a3a2e2457e53f52f45278", async() => {
                BeginContext(584, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(598, 411, true);
            WriteLiteral(@"
                </p>
                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">

                    <thead>
                        <tr>
                            <th>Company Name</th>
                            <th>Assessment Date</th>
                            <th>Action</th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 34 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Outcomes\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(1088, 70, true);
            WriteLiteral("                            <tr>\n                                <td> ");
            EndContext();
            BeginContext(1159, 47, false);
#line 37 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Outcomes\Index.cshtml"
                                Write(Html.DisplayFor(modelItem => item.company.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1206, 44, true);
            WriteLiteral(" </td>\n                                <td> ");
            EndContext();
            BeginContext(1251, 58, false);
#line 38 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Outcomes\Index.cshtml"
                                Write(Html.DisplayFor(modelItem => item.outcome.Assessment_date));

#line default
#line hidden
            EndContext();
            BeginContext(1309, 79, true);
            WriteLiteral("</td>\n                                <td>\n                                    ");
            EndContext();
            BeginContext(1388, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5947ad59878eec6c59b4928a3a2e2457e53f52f48374", async() => {
                BeginContext(1441, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 40 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Outcomes\Index.cshtml"
                                                           WriteLiteral(item.outcome.Id);

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
            BeginContext(1449, 3, true);
            WriteLiteral(" |\n");
            EndContext();
            BeginContext(1554, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(1590, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5947ad59878eec6c59b4928a3a2e2457e53f52f410873", async() => {
                BeginContext(1645, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 42 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Outcomes\Index.cshtml"
                                                             WriteLiteral(item.outcome.Id);

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
            BeginContext(1655, 73, true);
            WriteLiteral("\n                                </td>\n                            </tr>\n");
            EndContext();
#line 45 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Outcomes\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1754, 165, true);
            WriteLiteral("                    </tbody>\n                </table>\n            </div>\n        </div>\n        <!--  <div class=\"card-footer small text-muted\"></div> -->\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GCS.Models.OutcomeCompanyViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
