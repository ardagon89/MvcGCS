#pragma checksum "C:\Users\shari\source\repos\MvcGCS-master\Views\Users\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb516036a5e8b279690d45025a5013fd4b5998c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Delete), @"mvc.1.0.view", @"/Views/Users/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/Delete.cshtml", typeof(AspNetCore.Views_Users_Delete))]
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
#line 1 "C:\Users\shari\source\repos\MvcGCS-master\Views\_ViewImports.cshtml"
using MvcMovie;

#line default
#line hidden
#line 2 "C:\Users\shari\source\repos\MvcGCS-master\Views\_ViewImports.cshtml"
using MvcMovie.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb516036a5e8b279690d45025a5013fd4b5998c6", @"/Views/Users/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15f339ab26e1f7c427971d34ecda8fd273fe3c5f", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GCS.Models.UserCompanyViewModel>
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
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\shari\source\repos\MvcGCS-master\Views\Users\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(84, 296, true);
            WriteLiteral(@"
<ol class=""breadcrumb"">
    <li class=""breadcrumb-item"">
        <a href=""#"">Users</a>
    </li>
    <li class=""breadcrumb-item active"">Delete</li>
</ol>

<h5>Are you sure you want to delete this?</h5>
<div>
    <hr />
    <dl class=""row"">
        <dt class=""col-sm-2"">
            ");
            EndContext();
            BeginContext(381, 48, false);
#line 19 "C:\Users\shari\source\repos\MvcGCS-master\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.company.Name));

#line default
#line hidden
            EndContext();
            BeginContext(429, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(491, 44, false);
#line 22 "C:\Users\shari\source\repos\MvcGCS-master\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.company.Name));

#line default
#line hidden
            EndContext();
            BeginContext(535, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(596, 46, false);
#line 25 "C:\Users\shari\source\repos\MvcGCS-master\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.user.Fname));

#line default
#line hidden
            EndContext();
            BeginContext(642, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(704, 42, false);
#line 28 "C:\Users\shari\source\repos\MvcGCS-master\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.user.Fname));

#line default
#line hidden
            EndContext();
            BeginContext(746, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(807, 46, false);
#line 31 "C:\Users\shari\source\repos\MvcGCS-master\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.user.Lname));

#line default
#line hidden
            EndContext();
            BeginContext(853, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(915, 42, false);
#line 34 "C:\Users\shari\source\repos\MvcGCS-master\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.user.Lname));

#line default
#line hidden
            EndContext();
            BeginContext(957, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1018, 49, false);
#line 37 "C:\Users\shari\source\repos\MvcGCS-master\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.user.Address1));

#line default
#line hidden
            EndContext();
            BeginContext(1067, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1129, 45, false);
#line 40 "C:\Users\shari\source\repos\MvcGCS-master\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.user.Address1));

#line default
#line hidden
            EndContext();
            BeginContext(1174, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1235, 49, false);
#line 43 "C:\Users\shari\source\repos\MvcGCS-master\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.user.Address2));

#line default
#line hidden
            EndContext();
            BeginContext(1284, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1346, 45, false);
#line 46 "C:\Users\shari\source\repos\MvcGCS-master\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.user.Address2));

#line default
#line hidden
            EndContext();
            BeginContext(1391, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1452, 45, false);
#line 49 "C:\Users\shari\source\repos\MvcGCS-master\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.user.City));

#line default
#line hidden
            EndContext();
            BeginContext(1497, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1559, 41, false);
#line 52 "C:\Users\shari\source\repos\MvcGCS-master\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.user.City));

#line default
#line hidden
            EndContext();
            BeginContext(1600, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1661, 46, false);
#line 55 "C:\Users\shari\source\repos\MvcGCS-master\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.user.State));

#line default
#line hidden
            EndContext();
            BeginContext(1707, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1769, 42, false);
#line 58 "C:\Users\shari\source\repos\MvcGCS-master\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.user.State));

#line default
#line hidden
            EndContext();
            BeginContext(1811, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1872, 44, false);
#line 61 "C:\Users\shari\source\repos\MvcGCS-master\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.user.Zip));

#line default
#line hidden
            EndContext();
            BeginContext(1916, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1978, 40, false);
#line 64 "C:\Users\shari\source\repos\MvcGCS-master\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.user.Zip));

#line default
#line hidden
            EndContext();
            BeginContext(2018, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2079, 48, false);
#line 67 "C:\Users\shari\source\repos\MvcGCS-master\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.user.Country));

#line default
#line hidden
            EndContext();
            BeginContext(2127, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2189, 44, false);
#line 70 "C:\Users\shari\source\repos\MvcGCS-master\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.user.Country));

#line default
#line hidden
            EndContext();
            BeginContext(2233, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2294, 46, false);
#line 73 "C:\Users\shari\source\repos\MvcGCS-master\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.user.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(2340, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2402, 42, false);
#line 76 "C:\Users\shari\source\repos\MvcGCS-master\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.user.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(2444, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2505, 46, false);
#line 79 "C:\Users\shari\source\repos\MvcGCS-master\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.user.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2551, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2613, 42, false);
#line 82 "C:\Users\shari\source\repos\MvcGCS-master\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.user.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2655, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2716, 49, false);
#line 85 "C:\Users\shari\source\repos\MvcGCS-master\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.user.Password));

#line default
#line hidden
            EndContext();
            BeginContext(2765, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2827, 45, false);
#line 88 "C:\Users\shari\source\repos\MvcGCS-master\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.user.Password));

#line default
#line hidden
            EndContext();
            BeginContext(2872, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2933, 49, false);
#line 91 "C:\Users\shari\source\repos\MvcGCS-master\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.user.Is_admin));

#line default
#line hidden
            EndContext();
            BeginContext(2982, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3044, 45, false);
#line 94 "C:\Users\shari\source\repos\MvcGCS-master\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.user.Is_admin));

#line default
#line hidden
            EndContext();
            BeginContext(3089, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3150, 47, false);
#line 97 "C:\Users\shari\source\repos\MvcGCS-master\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.user.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(3197, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3259, 43, false);
#line 100 "C:\Users\shari\source\repos\MvcGCS-master\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.user.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(3302, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3363, 45, false);
#line 103 "C:\Users\shari\source\repos\MvcGCS-master\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.user.Race));

#line default
#line hidden
            EndContext();
            BeginContext(3408, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3470, 41, false);
#line 106 "C:\Users\shari\source\repos\MvcGCS-master\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.user.Race));

#line default
#line hidden
            EndContext();
            BeginContext(3511, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3572, 45, false);
#line 109 "C:\Users\shari\source\repos\MvcGCS-master\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.user.Role));

#line default
#line hidden
            EndContext();
            BeginContext(3617, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3679, 41, false);
#line 112 "C:\Users\shari\source\repos\MvcGCS-master\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.user.Role));

#line default
#line hidden
            EndContext();
            BeginContext(3720, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3781, 55, false);
#line 115 "C:\Users\shari\source\repos\MvcGCS-master\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.user.Company_length));

#line default
#line hidden
            EndContext();
            BeginContext(3836, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3898, 51, false);
#line 118 "C:\Users\shari\source\repos\MvcGCS-master\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.user.Company_length));

#line default
#line hidden
            EndContext();
            BeginContext(3949, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4010, 52, false);
#line 121 "C:\Users\shari\source\repos\MvcGCS-master\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.user.Role_length));

#line default
#line hidden
            EndContext();
            BeginContext(4062, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4124, 48, false);
#line 124 "C:\Users\shari\source\repos\MvcGCS-master\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.user.Role_length));

#line default
#line hidden
            EndContext();
            BeginContext(4172, 36, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n\r\n    ");
            EndContext();
            BeginContext(4208, 260, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb516036a5e8b279690d45025a5013fd4b5998c619912", async() => {
                BeginContext(4234, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(4244, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cb516036a5e8b279690d45025a5013fd4b5998c620305", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 130 "C:\Users\shari\source\repos\MvcGCS-master\Views\Users\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.user.Id);

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
                BeginContext(4285, 81, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />\r\n        ");
                EndContext();
                BeginContext(4366, 89, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb516036a5e8b279690d45025a5013fd4b5998c622203", async() => {
                    BeginContext(4388, 63, true);
                    WriteLiteral("<input type=\"submit\" value=\"Cancel\" class=\"btn btn-primary\" /> ");
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
                BeginContext(4455, 6, true);
                WriteLiteral("\r\n    ");
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
            BeginContext(4468, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GCS.Models.UserCompanyViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
