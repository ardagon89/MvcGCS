#pragma checksum "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Companies\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0906cb982219edb1d7cb70aecdf1dcd96d3ad2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Companies_Delete), @"mvc.1.0.view", @"/Views/Companies/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Companies/Delete.cshtml", typeof(AspNetCore.Views_Companies_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0906cb982219edb1d7cb70aecdf1dcd96d3ad2f", @"/Views/Companies/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15f339ab26e1f7c427971d34ecda8fd273fe3c5f", @"/Views/_ViewImports.cshtml")]
    public class Views_Companies_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GCS.Models.Company>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Companies\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(66, 80, true);
            WriteLiteral("\n    <ol class=\"breadcrumb\">\n        <li class=\"breadcrumb-item\">\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 146, "\"", 186, 1);
#line 9 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Companies\Delete.cshtml"
WriteAttributeValue("", 153, Url.Action("Index", "Companies"), 153, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(187, 292, true);
            WriteLiteral(@">Company</a>
        </li>
        <li class=""breadcrumb-item active"">Delete</li>
    </ol>

<h5>Are you sure you want to delete this?</h5>
<div>
    <hr />
    <dl class=""row"">
        <dt class=""col-sm-2"">
            Company Name :
        </dt>
        <dd class=""col-sm-10"">
            ");
            EndContext();
            BeginContext(480, 36, false);
#line 22 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(516, 126, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Address 1 :\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(643, 40, false);
#line 28 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Address1));

#line default
#line hidden
            EndContext();
            BeginContext(683, 126, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Address 2 :\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(810, 40, false);
#line 34 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Address2));

#line default
#line hidden
            EndContext();
            BeginContext(850, 121, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            City :\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(972, 36, false);
#line 40 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(1008, 122, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            State :\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1131, 37, false);
#line 46 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.State));

#line default
#line hidden
            EndContext();
            BeginContext(1168, 120, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Zip :\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1289, 35, false);
#line 52 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Zip));

#line default
#line hidden
            EndContext();
            BeginContext(1324, 123, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n           Country :\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1448, 39, false);
#line 58 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Country));

#line default
#line hidden
            EndContext();
            BeginContext(1487, 122, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Email :\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1610, 37, false);
#line 64 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1647, 124, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Website :\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1772, 39, false);
#line 70 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Website));

#line default
#line hidden
            EndContext();
            BeginContext(1811, 122, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Phone :\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1934, 37, false);
#line 76 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1971, 123, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Vision :\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(2095, 38, false);
#line 82 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Vision));

#line default
#line hidden
            EndContext();
            BeginContext(2133, 124, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Mission :\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(2258, 39, false);
#line 88 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Mission));

#line default
#line hidden
            EndContext();
            BeginContext(2297, 123, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Values :\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(2421, 37, false);
#line 94 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Value));

#line default
#line hidden
            EndContext();
            BeginContext(2458, 129, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Company Type :\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(2588, 36, false);
#line 100 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(2624, 132, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Company revenue :\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(2757, 44, false);
#line 106 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Revenue_band));

#line default
#line hidden
            EndContext();
            BeginContext(2801, 133, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Company Employee :\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(2935, 45, false);
#line 112 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Employee_band));

#line default
#line hidden
            EndContext();
            BeginContext(2980, 130, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            Company Stage :\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(3111, 37, false);
#line 118 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Companies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Stage));

#line default
#line hidden
            EndContext();
            BeginContext(3148, 34, true);
            WriteLiteral("\n        </dd>\n    </dl>\n    \n    ");
            EndContext();
            BeginContext(3182, 255, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0906cb982219edb1d7cb70aecdf1dcd96d3ad2f13956", async() => {
                BeginContext(3208, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(3217, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c0906cb982219edb1d7cb70aecdf1dcd96d3ad2f14346", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 123 "C:\Users\shari\source\repos\MvcGCS-master (1)\MvcGCS-master\Views\Companies\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3253, 83, true);
                WriteLiteral("\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger btn\" />\n        ");
                EndContext();
                BeginContext(3336, 89, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0906cb982219edb1d7cb70aecdf1dcd96d3ad2f16261", async() => {
                    BeginContext(3358, 63, true);
                    WriteLiteral("<input type=\"button\" value=\"Cancel\" class=\"btn btn-primary\" /> ");
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
                BeginContext(3425, 5, true);
                WriteLiteral("\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3437, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GCS.Models.Company> Html { get; private set; }
    }
}
#pragma warning restore 1591
