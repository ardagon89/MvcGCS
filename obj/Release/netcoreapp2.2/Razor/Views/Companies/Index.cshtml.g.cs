#pragma checksum "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Companies\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "415f94e94c596902adcd227034bb59228cda4968"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Companies_Index), @"mvc.1.0.view", @"/Views/Companies/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Companies/Index.cshtml", typeof(AspNetCore.Views_Companies_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"415f94e94c596902adcd227034bb59228cda4968", @"/Views/Companies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15f339ab26e1f7c427971d34ecda8fd273fe3c5f", @"/Views/_ViewImports.cshtml")]
    public class Views_Companies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GCS.Models.Company>>
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
            BeginContext(39, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Companies\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(78, 426, true);
            WriteLiteral(@"
<!-- Breadcrumbs-->
<ol class=""breadcrumb"">
    <li class=""breadcrumb-item"">
        <a href=""#"">Home</a>
    </li>
    <li class=""breadcrumb-item active"">Company</li>
</ol>

<!-- DataTables Example -->
<div class=""card mb-3"">
    <div class=""card-header"">
        <i class=""fas fa-table""></i>
        Company List
    </div>
    <div class=""card-body"">
        <div class=""table-responsive"">
            <p>
                ");
            EndContext();
            BeginContext(504, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "415f94e94c596902adcd227034bb59228cda49684895", async() => {
                BeginContext(527, 10, true);
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
            BeginContext(541, 218, true);
            WriteLiteral("\n            </p>\n            <table class=\"table table-bordered\" id=\"dataTable\" width=\"100%\" cellspacing=\"0\">\n\n                <thead>\n                    <tr>\n                        <th>\n                            ");
            EndContext();
            BeginContext(760, 40, false);
#line 31 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Companies\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(800, 88, true);
            WriteLiteral("\n                        </th>\n                        <th>\n                            ");
            EndContext();
            BeginContext(889, 41, false);
#line 34 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Companies\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(930, 88, true);
            WriteLiteral("\n                        </th>\n                        <th>\n                            ");
            EndContext();
            BeginContext(1019, 43, false);
#line 37 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Companies\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Website));

#line default
#line hidden
            EndContext();
            BeginContext(1062, 88, true);
            WriteLiteral("\n                        </th>\n                        <th>\n                            ");
            EndContext();
            BeginContext(1151, 41, false);
#line 40 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Companies\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1192, 148, true);
            WriteLiteral("\n                        </th>\n\n                        <th>Actions</th>\n                    </tr>\n                </thead>\n                <tbody>\n");
            EndContext();
#line 47 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Companies\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1411, 94, true);
            WriteLiteral("                        <tr>\n                            <td>\n                                ");
            EndContext();
            BeginContext(1506, 39, false);
#line 51 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Companies\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1545, 100, true);
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
            EndContext();
            BeginContext(1646, 40, false);
#line 54 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Companies\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1686, 100, true);
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
            EndContext();
            BeginContext(1787, 42, false);
#line 57 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Companies\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Website));

#line default
#line hidden
            EndContext();
            BeginContext(1829, 100, true);
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
            EndContext();
            BeginContext(1930, 41, false);
#line 60 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Companies\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1971, 100, true);
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
            EndContext();
            BeginContext(2071, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "415f94e94c596902adcd227034bb59228cda496810880", async() => {
                BeginContext(2116, 4, true);
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
#line 63 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Companies\Index.cshtml"
                                                       WriteLiteral(item.Id);

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
            BeginContext(2124, 35, true);
            WriteLiteral(" |\n                                ");
            EndContext();
            BeginContext(2159, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "415f94e94c596902adcd227034bb59228cda496813276", async() => {
                BeginContext(2206, 6, true);
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
#line 64 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Companies\Index.cshtml"
                                                         WriteLiteral(item.Id);

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
            BeginContext(2216, 65, true);
            WriteLiteral("\n                            </td>\n                        </tr>\n");
            EndContext();
#line 67 "C:\Users\ankit\Downloads\latest\latest\MvcGCS-master (1)\MvcGCS-master\Views\Companies\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2303, 82, true);
            WriteLiteral("                </tbody>\n            </table>\n        </div>\n    </div>\n</div>\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GCS.Models.Company>> Html { get; private set; }
    }
}
#pragma warning restore 1591
