#pragma checksum "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Clients\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0932d6d2ff9d02cdb5c7737a1227a4b4bcb5a8a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Details), @"mvc.1.0.view", @"/Views/Clients/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clients/Details.cshtml", typeof(AspNetCore.Views_Clients_Details))]
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
#line 1 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\_ViewImports.cshtml"
using FlowAuth;

#line default
#line hidden
#line 2 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\_ViewImports.cshtml"
using FlowAuth.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0932d6d2ff9d02cdb5c7737a1227a4b4bcb5a8a5", @"/Views/Clients/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89129962b79090d0f1ae5f5d5048e447eef01cf2", @"/Views/_ViewImports.cshtml")]
    public class Views_Clients_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FlowAuth.Models.Client>
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
            BeginContext(30, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Clients\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(71, 112, true);
            WriteLiteral("\n<h2>Details</h2>\n\n<div>\n    <h4>Client</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(184, 47, false);
#line 14 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Client_name));

#line default
#line hidden
            EndContext();
            BeginContext(231, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(272, 43, false);
#line 17 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Client_name));

#line default
#line hidden
            EndContext();
            BeginContext(315, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(356, 50, false);
#line 20 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Client_service));

#line default
#line hidden
            EndContext();
            BeginContext(406, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(447, 46, false);
#line 23 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Client_service));

#line default
#line hidden
            EndContext();
            BeginContext(493, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(534, 49, false);
#line 26 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Company_regNo));

#line default
#line hidden
            EndContext();
            BeginContext(583, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(624, 45, false);
#line 29 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Company_regNo));

#line default
#line hidden
            EndContext();
            BeginContext(669, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(710, 55, false);
#line 32 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Client_work_address));

#line default
#line hidden
            EndContext();
            BeginContext(765, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(806, 51, false);
#line 35 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Client_work_address));

#line default
#line hidden
            EndContext();
            BeginContext(857, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(898, 49, false);
#line 38 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Client_workNo));

#line default
#line hidden
            EndContext();
            BeginContext(947, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(988, 45, false);
#line 41 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Client_workNo));

#line default
#line hidden
            EndContext();
            BeginContext(1033, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1074, 46, false);
#line 44 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Client_DOB));

#line default
#line hidden
            EndContext();
            BeginContext(1120, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1161, 42, false);
#line 47 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Client_DOB));

#line default
#line hidden
            EndContext();
            BeginContext(1203, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1244, 48, false);
#line 50 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Client_id_no));

#line default
#line hidden
            EndContext();
            BeginContext(1292, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1333, 44, false);
#line 53 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Client_id_no));

#line default
#line hidden
            EndContext();
            BeginContext(1377, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1418, 54, false);
#line 56 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Client_contactName));

#line default
#line hidden
            EndContext();
            BeginContext(1472, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1513, 50, false);
#line 59 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Client_contactName));

#line default
#line hidden
            EndContext();
            BeginContext(1563, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1604, 55, false);
#line 62 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Client_contactEmail));

#line default
#line hidden
            EndContext();
            BeginContext(1659, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1700, 51, false);
#line 65 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Client_contactEmail));

#line default
#line hidden
            EndContext();
            BeginContext(1751, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1792, 52, false);
#line 68 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Client_contactNo));

#line default
#line hidden
            EndContext();
            BeginContext(1844, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1885, 48, false);
#line 71 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Client_contactNo));

#line default
#line hidden
            EndContext();
            BeginContext(1933, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1974, 50, false);
#line 74 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Clients\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Account_status));

#line default
#line hidden
            EndContext();
            BeginContext(2024, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(2065, 46, false);
#line 77 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Clients\Details.cshtml"
       Write(Html.DisplayFor(model => model.Account_status));

#line default
#line hidden
            EndContext();
            BeginContext(2111, 42, true);
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(2153, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfa4887ffdc44b3083c73411adda8a6b", async() => {
                BeginContext(2205, 4, true);
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
#line 82 "C:\Users\stsplanet\source\repos\Project day\FlowAuth\FlowAuth\Views\Clients\Details.cshtml"
                           WriteLiteral(Model.ClientID);

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
            BeginContext(2213, 7, true);
            WriteLiteral(" |\n    ");
            EndContext();
            BeginContext(2220, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac1de689ef1c4db2ae48a97d9142db39", async() => {
                BeginContext(2242, 12, true);
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
            BeginContext(2258, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FlowAuth.Models.Client> Html { get; private set; }
    }
}
#pragma warning restore 1591